Imports System.Windows.Forms
Imports Entidad

Public Class Man_Cliente
    Private Metodo As Metodos = New Metodos
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        For Each cli In Logicadatos.buscarCli(CBOpcion.SelectedIndex, Buscar)
            Dg.Rows.Add(cli.cli_ID, cli.cli_Cedula, cli.cli_Nombres, cli.cli_Telefono, cli.cli_Email, If(cli.cli_Sexo, "Hombre", "Mujer"))
        Next
    End Sub
    Public Sub limpiar()
        ErrDatos.Clear()
        RBHombre.Checked = True
        Metodo.LimpiarGroupbox(GB_Ingresar)
        Metodo.LimpiarGroupbox(GB_Registros)
        CBOpcion.SelectedIndex = 0
    End Sub
    Private Sub Man_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim datos = New EntCliente(Cod, TxtCedula.Text, TxtNombres.Text, TxtTelefono.Text, TxtEmail.Text, RBHombre.Checked)
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Metodo.ValidaEntrada(ErrDatos, GB_Ingresar) Then
                If grabarG = "N" Then
                    Logicadatos.ingresarCli(datos)
                Else
                    Logicadatos.modificarCli(datos)
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
        Dim datos = New EntCliente(Cod, TxtCedula.Text, TxtNombres.Text, TxtTelefono.Text, TxtEmail.Text, RBHombre.Checked)
        If MessageBox.Show("¿Desea eliminar este dato en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Logicadatos.eliminarCli(datos)
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
        TxtCedula.Text = Dg.Rows(i).Cells(1).Value.ToString
        TxtNombres.Text = Dg.Rows(i).Cells(2).Value.ToString
        TxtTelefono.Text = Dg.Rows(i).Cells(3).Value.ToString
        TxtEmail.Text = Dg.Rows(i).Cells(4).Value.ToString
        If Dg.Rows(i).Cells(5).Value.ToString = "Hombre" Then
            RBHombre.Checked = True
        Else
            RBMujer.Checked = True
        End If
        Metodo.Botones(3)
    End Sub

    Private Sub CBOpcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcion.SelectedIndexChanged
        cargar(TxtBuscar.Text.Trim())
    End Sub

    Private Sub TxtEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmail.KeyPress
        Metodo.ValidarEspacio(e)
    End Sub

    Private Sub TxtTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        Metodo.ValidarNumeros(e)
    End Sub

    Private Sub TxtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCedula.KeyPress
        Metodo.ValidarNumeros(e)
    End Sub
End Class