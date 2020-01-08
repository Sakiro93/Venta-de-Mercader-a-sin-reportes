Imports System.Windows.Forms
Imports Entidad

Public Class Man_Calzado
    Private banCal As Boolean
    Private Metodo As Metodos = New Metodos
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        Dim cat As String = ""
        Dim tal As String = ""
        Dim col As String = ""
        If CBColor.Items.Count > 0 And CBCategoria.Items.Count > 0 And CBTalla.Items.Count > 0 Then
            For Each cal In Logicadatos.buscarCal(CBOpcion.SelectedIndex, Buscar)
                CBCategoria.SelectedValue = cal.cal_CatID
                CBTalla.SelectedValue = cal.cal_TalID
                CBColor.SelectedValue = cal.cal_ColID
                tal = CBTalla.Text
                cat = CBCategoria.Text
                col = CBColor.Text
                Dg.Rows.Add(cal.cal_ID, cal.cal_Nombre, cat, tal, col, If(cal.cal_Genero, "MASCULINO", "FEMENINO"), cal.cal_Precio, cal.cal_Stock)
            Next
        End If
        llenarCombos()
        colorearDataGrid()
    End Sub
    Public Sub colorearDataGrid()
        For i As Integer = 0 To Dg.Rows.Count - 1
            If Dg.Rows(i).Cells(7).Value > 25 Then
                Dg.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.LightBlue
            ElseIf Dg.Rows(i).Cells(7).Value > 11 Then
                Dg.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.LightYellow
            Else
                Dg.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.LightPink
                banCal = True
            End If
        Next
    End Sub


    Public Sub llenarCombos()
        Logicadatos.llenarCombo(0, CBCategoria)
        If CBCategoria.Items.Count < 1 Then
            CBCategoria.Text = ""
        End If
        Logicadatos.llenarCombo(1, CBTalla)
        If CBTalla.Items.Count < 1 Then
            CBTalla.Text = ""
        End If
        Logicadatos.llenarCombo(2, CBColor)
        If CBColor.Items.Count < 1 Then
            CBColor.Text = ""
        End If
    End Sub

     Public Sub limpiar()
        ErrDatos.Clear()
        llenarCombos()
        banCal = False
        RBHombre.Checked = True
        Metodo.LimpiarGroupbox(GB_Ingresar)
        Metodo.LimpiarGroupbox(GB_Registros)
        CBOpcion.SelectedIndex = 0
        TxtPrecio.Text = 0
        TxtStock.Text = 0
    End Sub
    Private Sub Man_Calzado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargar(TxtBuscar.Text.Trim())
        If banCal Then
            MessageBox.Show("Advertencia: Existen registros con bajos Stocks")
        End If
        Metodo.tooltip(TooMensaje, GB_Opciones)
        Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
        Metodo.Cargar_Botones(4, GB_Opciones)
        Metodo.Botones(1)
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        Metodo.Habilitar_GroupBox(GB_Ingresar, 1)
        Metodo.Botones(2)
        grabarG = "N"
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Metodo.ValidaEntrada(ErrDatos, GB_Ingresar) Then
                Dim datos = New EntCalzado(Cod, TxtNombre.Text, CBCategoria.SelectedValue, CBTalla.SelectedValue, CBColor.SelectedValue, RBHombre.Checked, TxtPrecio.Text, TxtStock.Text)
                If grabarG = "N" Then
                    Logicadatos.ingresarCal(datos)
                Else
                    Logicadatos.modificarCal(datos)
                End If
                limpiar()
                cargar(TxtBuscar.Text)
                Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
                Metodo.Botones(1)
            End If
        Else
            limpiar()
            Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
            Metodo.Botones(1)
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea eliminar este dato en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim datos = New EntCalzado(Cod, TxtNombre.Text, CBCategoria.SelectedValue, CBTalla.SelectedValue, CBColor.SelectedValue, RBHombre.Checked, TxtPrecio.Text, TxtStock.Text)
            Logicadatos.eliminarCal(datos)
            limpiar()
            cargar(TxtBuscar.Text)
        End If
        Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
        Metodo.Botones(1)
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        grabarG = "M"
        Metodo.Habilitar_GroupBox(GB_Ingresar, 1)
        Metodo.Botones(4)
    End Sub
    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        ErrDatos.Clear()
        Metodo.LimpiarGroupbox(GB_Ingresar)
        Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
        cargar(TxtBuscar.Text.Trim())
    End Sub

    Private Sub Dg_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg.CellClick
        If Dg.SelectedRows.Count > 0 Then
            ErrDatos.Clear()
            Ind = Dg.CurrentRow.Index
            Cod = Dg.Rows(Ind).Cells(0).Value
            If (Cod > 0) Then
                MostrarDatos(Ind)
            End If
            Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
        End If
    End Sub

    Public Sub MostrarDatos(ByVal i As Integer)
        TxtNombre.Text = Dg.Rows(i).Cells(1).Value.ToString
        CBCategoria.Text = Dg.Rows(i).Cells(2).Value.ToString
        CBTalla.Text = Dg.Rows(i).Cells(3).Value.ToString
        CBColor.Text = Dg.Rows(i).Cells(4).Value.ToString
        If Dg.Rows(i).Cells(5).Value.ToString = "MASCULINO" Then
            RBHombre.Checked = True
        Else
            RBMujer.Checked = True
        End If
        TxtPrecio.Text = Dg.Rows(i).Cells(6).Value.ToString
        TxtStock.Text = Dg.Rows(i).Cells(7).Value.ToString
        Metodo.Botones(3)
    End Sub

    Private Sub CBOpcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcion.SelectedIndexChanged
        cargar(TxtBuscar.Text.Trim())
    End Sub

    Private Sub TxtPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        Metodo.ValidarPrecio(e, TxtPrecio)
    End Sub

    Private Sub TxtStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStock.KeyPress
        Metodo.ValidarNumeros(e)
    End Sub
End Class