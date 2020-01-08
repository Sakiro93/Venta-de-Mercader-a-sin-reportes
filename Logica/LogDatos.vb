Imports Interfaz
Imports AccesoDatos
Imports Entidad

Public Class LogDatos
    Implements IntDatos
    Dim logicadatos As New AccDatos()
    Public Function buscarCal(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCalzado) Implements Interfaz.IntDatos.buscarCal
        Return logicadatos.buscarCal(opc, filtro)
    End Function

    Public Function buscarCat(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCategoria) Implements Interfaz.IntDatos.buscarCat
        Return logicadatos.buscarCat(opc, filtro)
    End Function

    Public Function buscarCli(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCliente) Implements Interfaz.IntDatos.buscarCli
        Return logicadatos.buscarCli(opc, filtro)
    End Function

    Public Function buscarCol(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntColor) Implements Interfaz.IntDatos.buscarCol
        Return logicadatos.buscarCol(opc, filtro)
    End Function

    Public Function buscarDet(ByVal opc As Integer, ByVal cod As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntDetalle) Implements Interfaz.IntDatos.buscarDet
        Return logicadatos.buscarDet(opc, cod, filtro)
    End Function

    Public Function buscarInv(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntInventario) Implements Interfaz.IntDatos.buscarInv
        Return logicadatos.buscarInv(opc, filtro)
    End Function

    Public Function buscarPro(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntProveedor) Implements Interfaz.IntDatos.buscarPro
        Return logicadatos.buscarPro(opc, filtro)
    End Function

    Public Function buscarTal(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntTalla) Implements Interfaz.IntDatos.buscarTal
        Return logicadatos.buscarTal(opc, filtro)
    End Function

    Public Function buscarVen(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntVenta) Implements Interfaz.IntDatos.buscarVen
        Return logicadatos.buscarVen(opc, filtro)
    End Function

    Public Sub eliminarCal(ByVal Calzado As EntCalzado) Implements Interfaz.IntDatos.eliminarCal
        logicadatos.eliminarCal(Calzado)
    End Sub

    Public Sub eliminarCat(ByVal Categoria As EntCategoria) Implements Interfaz.IntDatos.eliminarCat
        logicadatos.eliminarCat(Categoria)
    End Sub

    Public Sub eliminarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.eliminarCli
        logicadatos.eliminarCli(Cliente)
    End Sub

    Public Sub eliminarCol(ByVal Color As Entidad.EntColor) Implements Interfaz.IntDatos.eliminarCol
        logicadatos.eliminarCol(Color)
    End Sub

    Public Sub eliminarInv(ByVal Inventario As EntInventario) Implements Interfaz.IntDatos.eliminarInv
        logicadatos.eliminarInv(Inventario)
    End Sub

    Public Sub eliminarPro(ByVal Proveedor As EntProveedor) Implements Interfaz.IntDatos.eliminarPro
        logicadatos.eliminarPro(Proveedor)
    End Sub

    Public Sub eliminarTal(ByVal Talla As EntTalla) Implements Interfaz.IntDatos.eliminarTal
        logicadatos.eliminarTal(Talla)
    End Sub

    Public Sub ingresarCal(ByVal Calzado As Entidad.EntCalzado) Implements Interfaz.IntDatos.ingresarCal
        logicadatos.ingresarCal(Calzado)
    End Sub

    Public Sub ingresarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.ingresarCat
        logicadatos.ingresarCat(Categoria)
    End Sub

    Public Sub ingresarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.ingresarCli
        logicadatos.ingresarCli(Cliente)
    End Sub

    Public Sub ingresarCol(ByVal Color As Entidad.EntColor) Implements Interfaz.IntDatos.ingresarCol
        logicadatos.ingresarCol(Color)
    End Sub

    Public Sub ingresarDet(ByVal Detalle As Entidad.EntDetalle) Implements Interfaz.IntDatos.ingresarDet
        logicadatos.ingresarDet(Detalle)
    End Sub

    Public Sub ingresarInv(ByVal Inventario As Entidad.EntInventario) Implements Interfaz.IntDatos.ingresarInv
        logicadatos.ingresarInv(Inventario)
    End Sub

    Public Sub ingresarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.ingresarPro
        logicadatos.ingresarPro(Proveedor)
    End Sub

    Public Sub ingresarTal(ByVal Talla As Entidad.EntTalla) Implements Interfaz.IntDatos.ingresarTal
        logicadatos.ingresarTal(Talla)
    End Sub

    Public Sub ingresarVen(ByVal Venta As Entidad.EntVenta) Implements Interfaz.IntDatos.ingresarVen
        logicadatos.ingresarVen(Venta)
    End Sub

    Public Sub modificarCal(ByVal Calzado As Entidad.EntCalzado) Implements Interfaz.IntDatos.modificarCal
        logicadatos.modificarCal(Calzado)
    End Sub

    Public Sub modificarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.modificarCat
        logicadatos.modificarCat(Categoria)
    End Sub

    Public Sub modificarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.modificarCli
        logicadatos.modificarCli(Cliente)
    End Sub

    Public Sub modificarCol(ByVal Color As Entidad.EntColor) Implements Interfaz.IntDatos.modificarCol
        logicadatos.modificarCol(Color)
    End Sub

    Public Sub modificarInv(ByVal Inventario As Entidad.EntInventario) Implements Interfaz.IntDatos.modificarInv
        logicadatos.modificarInv(Inventario)
    End Sub

    Public Sub modificarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.modificarPro
        logicadatos.modificarPro(Proveedor)
    End Sub

    Public Sub modificarTal(ByVal Talla As Entidad.EntTalla) Implements Interfaz.IntDatos.modificarTal
        logicadatos.modificarTal(Talla)
    End Sub

    Public Sub llenarCombo(ByVal opc As Integer, ByVal Combo As System.Windows.Forms.ComboBox) Implements Interfaz.IntDatos.llenarCombo
        logicadatos.llenarCombo(opc, Combo)
    End Sub


    Public Function buscarPrecio(ByVal id As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarPrecio
        Return logicadatos.buscarPrecio(id)
    End Function

    Public Function buscarCantidad(ByVal id As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarCantidad
        Return logicadatos.buscarCantidad(id)
    End Function

    Public Function buscarAudiInventario(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiInventario
        Return logicadatos.buscarAudiInventario(cod, filtro, tipo)
    End Function

    Public Function buscarAudiVenta(ByVal cod As Integer, ByVal filtro As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiVenta
        Return logicadatos.buscarAudiVenta(cod, filtro)
    End Function

    Public Function buscarAudiCalzado(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiCalzado
        Return logicadatos.buscarAudiCalzado(cod, filtro, tipo)
    End Function

    Public Function buscarAudiCliente(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiCliente
        Return logicadatos.buscarAudiCliente(cod, filtro, tipo)
    End Function

    Public Function buscarAudiProveedor(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiProveedor
        Return logicadatos.buscarAudiProveedor(cod, filtro, tipo)
    End Function

    Public Function buscarAudiDetalle(ByVal cod As Integer, ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiDetalle
        Return logicadatos.buscarAudiDetalle(cod, filtro, id)
    End Function
End Class
