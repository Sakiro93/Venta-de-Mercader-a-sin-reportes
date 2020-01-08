Public Class Con_Detalle
    Private Metodo As Metodos = New Metodos
    Public Sub limpiar()
        Metodo.LimpiarTodo(GB_Detalle)
    End Sub
    Private Sub Con_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargarDetalle(TxtBuscarDetalle.Text)
        Metodo.tooltip(TooMensaje, GB_Opciones)
    End Sub
    Public Sub cargarDetalle(ByVal Buscar As String)
        Dg_Detalle.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudiDetalle(CBOpcionDetalle.SelectedIndex, TxtBuscarDetalle.Text, Cod)
        For fila = 0 To Tabla.Rows.Count - 1
            Dg_Detalle.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10), Tabla.Rows(fila).Item(11), Tabla.Rows(fila).Item(12))
        Next
    End Sub

    Private Sub TxtBuscarDetalle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarDetalle.TextChanged
        cargarDetalle(TxtBuscarDetalle.Text)
    End Sub

    Private Sub CBOpcionDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcionDetalle.SelectedIndexChanged
        cargarDetalle(TxtBuscarDetalle.Text)
    End Sub

    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class