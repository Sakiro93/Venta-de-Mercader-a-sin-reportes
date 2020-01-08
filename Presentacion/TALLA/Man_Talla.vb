Imports System.Windows.Forms
Imports Entidad

Public Class Man_Talla
    Private Metodo As Metodos = New Metodos
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        For Each tal In Logicadatos.buscarTal(CBOpcion.SelectedIndex, Buscar)
            Dg.Rows.Add(tal.tal_ID, tal.tal_Nombre)
        Next
    End Sub
    Public Sub limpiar()
        ErrDatos.Clear()
        Metodo.LimpiarGroupbox(GB_Ingresar)
        Metodo.LimpiarGroupbox(GB_Registros)
        CBOpcion.SelectedIndex = 0
    End Sub
    Private Sub Man_Talla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargar(TxtBuscar.Text.Trim())
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
        Dim datos = New EntTalla(Cod, TxtDescripcion.Text)
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Metodo.ValidaEntrada(ErrDatos, GB_Ingresar) Then
                If grabarG = "N" Then
                    Logicadatos.ingresarTal(datos)
                Else
                    Logicadatos.modificarTal(datos)
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
        Dim datos = New EntTalla(Cod, TxtDescripcion.Text)
        If MessageBox.Show("¿Desea eliminar este dato en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Logicadatos.eliminarTal(datos)
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
        TxtDescripcion.Text = Dg.Rows(i).Cells(1).Value.ToString
        Metodo.Botones(3)
    End Sub

    Private Sub CBOpcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcion.SelectedIndexChanged
        cargar(TxtBuscar.Text)
    End Sub
End Class