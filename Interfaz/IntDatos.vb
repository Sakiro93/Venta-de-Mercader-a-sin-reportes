Imports Entidad
Imports System.Windows.Forms

Public Interface IntDatos
    'Calzado'
    Sub ingresarCal(ByVal Calzado As EntCalzado)
    Sub modificarCal(ByVal Calzado As EntCalzado)
    Sub eliminarCal(ByVal Calzado As EntCalzado)
    Function buscarCal(ByVal opc As Integer, ByVal filtro As String) As List(Of EntCalzado)
    'Categoría'
    Sub ingresarCat(ByVal Categoria As EntCategoria)
    Sub modificarCat(ByVal Categoria As EntCategoria)
    Sub eliminarCat(ByVal Categoria As EntCategoria)
    Function buscarCat(ByVal opc As Integer, ByVal filtro As String) As List(Of EntCategoria)
    'Cliente'
    Sub ingresarCli(ByVal Cliente As EntCliente)
    Sub modificarCli(ByVal Cliente As EntCliente)
    Sub eliminarCli(ByVal Cliente As EntCliente)
    Function buscarCli(ByVal opc As Integer, ByVal filtro As String) As List(Of EntCliente)
    'Color'
    Sub ingresarCol(ByVal Color As EntColor)
    Sub modificarCol(ByVal Color As EntColor)
    Sub eliminarCol(ByVal Color As EntColor)
    Function buscarCol(ByVal opc As Integer, ByVal filtro As String) As List(Of EntColor)
    'Detalle'
    Sub ingresarDet(ByVal Detalle As EntDetalle)
    Function buscarDet(ByVal opc As Integer, ByVal cod As Integer, ByVal filtro As String) As List(Of EntDetalle)
    'Inventario'
    Sub ingresarInv(ByVal Inventario As EntInventario)
    Sub modificarInv(ByVal Inventario As EntInventario)
    Sub eliminarInv(ByVal Inventario As EntInventario)
    Function buscarInv(ByVal opc As Integer, ByVal filtro As String) As List(Of EntInventario)
    'Proveedor'
    Sub ingresarPro(ByVal Proveedor As EntProveedor)
    Sub modificarPro(ByVal Proveedor As EntProveedor)
    Sub eliminarPro(ByVal Proveedor As EntProveedor)
    Function buscarPro(ByVal opc As Integer, ByVal filtro As String) As List(Of EntProveedor)
    'Talla'
    Sub ingresarTal(ByVal Talla As EntTalla)
    Sub modificarTal(ByVal Talla As EntTalla)
    Sub eliminarTal(ByVal Talla As EntTalla)
    Function buscarTal(ByVal opc As Integer, ByVal filtro As String) As List(Of EntTalla)
    'Venta'
    Sub ingresarVen(ByVal Venta As EntVenta)
    Function buscarVen(ByVal opc As Integer, ByVal filtro As String) As List(Of EntVenta)
    'ComboBox'
    Sub llenarCombo(ByVal opc As Integer, ByVal Combo As ComboBox)
    'Precio'
    Function buscarPrecio(ByVal id As String) As DataTable
    Function buscarCantidad(ByVal id As String) As DataTable
    'Auditoria'
    Function buscarAudiVenta(ByVal cod As Integer, ByVal filtro As String) As DataTable
    Function buscarAudiInventario(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As DataTable
    Function buscarAudiCalzado(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As DataTable
    Function buscarAudiCliente(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As DataTable
    Function buscarAudiProveedor(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As DataTable
    Function buscarAudiDetalle(ByVal cod As Integer, ByVal filtro As String, ByVal id As Integer) As DataTable
End Interface
