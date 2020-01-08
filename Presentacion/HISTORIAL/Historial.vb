Imports System.Windows.Forms

Public Class Historial
    Private Metodo As Metodos = New Metodos
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Public Sub limpiar()
        Metodo.LimpiarTodo(GB_Ventas)
        Metodo.LimpiarTodo(GB_Inventario)
        Metodo.LimpiarTodo(GB_Calzado)
        Metodo.LimpiarTodo(GB_Cliente)
        Metodo.LimpiarTodo(GB_Proveedor)
    End Sub
    Public Function RetornarTipo(ByVal opc As Double) As String
        Dim opcion As String = ""
        Select Case opc
            Case 0
                opcion = ""
            Case 1
                opcion = "I"
            Case 2
                opcion = "D"
            Case 3
                opcion = "M"
        End Select
        Return opcion
    End Function

    Public Sub cargarVenta(ByVal Buscar As String)
        Dg_Ventas.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudiVenta(CBOpcionVenta.SelectedIndex, TxtBuscarVentas.Text)
        For fila = 0 To Tabla.Rows.Count - 1
            Dg_Ventas.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10))
        Next
    End Sub
    Public Sub cargarInventario(ByVal Buscar As String)
        Dg_Inventario.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudiInventario(CBOpcionInventario.SelectedIndex, TxtBuscarInventario.Text, RetornarTipo(CBTipoInventario.SelectedIndex))
        For fila = 0 To Tabla.Rows.Count - 1
            Dg_Inventario.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10))
        Next
    End Sub

    Public Sub cargarCalzado(ByVal Buscar As String)
        Dg_Calzado.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudiCalzado(CBOpcionCalzado.SelectedIndex, TxtBuscarCalzado.Text, RetornarTipo(CBTipoCalzado.SelectedIndex))
        For fila = 0 To Tabla.Rows.Count - 1
            Dg_Calzado.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10), Tabla.Rows(fila).Item(11), Tabla.Rows(fila).Item(12))
        Next
    End Sub

    Public Sub cargarCliente(ByVal Buscar As String)
        Dg_Cliente.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudiCliente(CBOpcionCliente.SelectedIndex, TxtBuscarCliente.Text, RetornarTipo(CBTipoCliente.SelectedIndex))
        For fila = 0 To Tabla.Rows.Count - 1
            Dg_Cliente.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10))
        Next
    End Sub

    Public Sub cargarProveedor(ByVal Buscar As String)
        Dg_Proveedor.Rows.Clear()
        Dim Tabla As New DataTable
        Tabla = Logicadatos.buscarAudiProveedor(CBOpcionProveedor.SelectedIndex, TxtBuscarProveedor.Text, RetornarTipo(CBTipoProveedor.SelectedIndex))
        For fila = 0 To Tabla.Rows.Count - 1
            Dg_Proveedor.Rows.Add(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Tabla.Rows(fila).Item(6), Tabla.Rows(fila).Item(7), Tabla.Rows(fila).Item(8), Tabla.Rows(fila).Item(9), Tabla.Rows(fila).Item(10))
        Next
    End Sub

    Private Sub Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        cargarVenta(TxtBuscarVentas.Text)
        cargarInventario(TxtBuscarInventario.Text)
        cargarCalzado(TxtBuscarCalzado.Text)
        cargarCliente(TxtBuscarCliente.Text)
        cargarProveedor(TxtBuscarProveedor.Text)
        Metodo.tooltip(TooMensaje, GB_Opciones)
    End Sub

    Private Sub TxtBuscarVentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarVentas.TextChanged
        cargarVenta(TxtBuscarVentas.Text)
    End Sub

    Private Sub CBOpcionVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcionVenta.SelectedIndexChanged
        cargarVenta(TxtBuscarVentas.Text)
    End Sub

    Private Sub CBOpcionInventario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcionInventario.SelectedIndexChanged
        cargarInventario(TxtBuscarInventario.Text)
    End Sub

    Private Sub CBTipoInventario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipoInventario.SelectedIndexChanged
        cargarInventario(TxtBuscarInventario.Text)
    End Sub

    Private Sub TxtBuscarInventario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarInventario.TextChanged
        cargarInventario(TxtBuscarInventario.Text)
    End Sub

    Private Sub TxtBuscarCalzado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarCalzado.TextChanged
        cargarCalzado(TxtBuscarCalzado.Text)
    End Sub

    Private Sub CBOpcionCalzado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcionCalzado.SelectedIndexChanged
        cargarCalzado(TxtBuscarCalzado.Text)
    End Sub

    Private Sub CBTipoCalzado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipoCalzado.SelectedIndexChanged
        cargarCalzado(TxtBuscarCalzado.Text)
    End Sub

    Private Sub TxtBuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarCliente.TextChanged
        cargarCliente(TxtBuscarCliente.Text)
    End Sub

    Private Sub CBOpcionCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcionCliente.SelectedIndexChanged
        cargarCliente(TxtBuscarCliente.Text)
    End Sub

    Private Sub CBTipoCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipoCliente.SelectedIndexChanged
        cargarCliente(TxtBuscarCliente.Text)
    End Sub

    Private Sub TxtBuscarProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscarProveedor.TextChanged
        cargarProveedor(TxtBuscarProveedor.Text)
    End Sub

    Private Sub CBOpcionProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcionProveedor.SelectedIndexChanged
        cargarProveedor(TxtBuscarProveedor.Text)
    End Sub

    Private Sub CBTipoProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipoProveedor.SelectedIndexChanged
        cargarProveedor(TxtBuscarProveedor.Text)
    End Sub

    Private Sub Dg_Ventas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Ventas.CellClick
        If Dg_Ventas.SelectedRows.Count > 0 Then
            Ind = Dg_Ventas.CurrentRow.Index
            Cod = Dg_Ventas.Rows(Ind).Cells(0).Value
            If Dg_Ventas.CurrentCell.ColumnIndex = 11 Then
                If (Cod > 0) Then
                    Con_Detalle.ShowDialog()
                End If
            End If
        End If
       

    End Sub
End Class