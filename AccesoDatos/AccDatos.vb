Imports Interfaz
Imports System.Data.SqlClient
Imports Entidad
Imports System.Windows.Forms

Public Class AccDatos
    Implements IntDatos
    Public Function buscarCal(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCalzado) Implements Interfaz.IntDatos.buscarCal
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_CAlZADO WHERE IDCALZADO LIKE '%" + filtro + "%' OR NOMBRE LIKE '%" + filtro + "%' ORDER BY IDCALZADO"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_CAlZADO WHERE IDCALZADO LIKE '%" + filtro + "%' ORDER BY IDCALZADO"
            Case 2
                cmd.CommandText = "SELECT * FROM VW_CAlZADO WHERE NOMBRE LIKE '%" + filtro + "%' ORDER BY IDCALZADO"
        End Select

        Dim LstCalzado As New List(Of EntCalzado)
        Dim Calzado As EntCalzado
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Calzado = New EntCalzado(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5), Convert.ToDouble(Tabla.Rows(fila).Item(6).ToString), Tabla.Rows(fila).Item(7))
            LstCalzado.Add(Calzado)
        Next
        Return LstCalzado
    End Function

    Public Function buscarCat(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCategoria) Implements Interfaz.IntDatos.buscarCat
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_CATEGORIA WHERE IDCATEGORIA LIKE '%" + filtro + "%' OR DESCRIPCION LIKE '%" + filtro + "%' ORDER BY IDCATEGORIA"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_CATEGORIA WHERE IDCATEGORIA LIKE '%" + filtro + "%' ORDER BY IDCATEGORIA"
            Case 2
                cmd.CommandText = "SELECT * FROM VW_CATEGORIA WHERE DESCRIPCION LIKE '%" + filtro + "%' ORDER BY IDCATEGORIA"
        End Select

        Dim LstCategoria As New List(Of EntCategoria)
        Dim Categoria As EntCategoria
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Categoria = New EntCategoria(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1))
            LstCategoria.Add(Categoria)
        Next
        Return LstCategoria
    End Function

    Public Function buscarCli(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCliente) Implements Interfaz.IntDatos.buscarCli
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_CLIENTE WHERE IDCLIENTE LIKE '%" + filtro + "%' OR NOMBRES LIKE '%" + filtro + "%' OR CEDULA LIKE '%" + filtro + "%' ORDER BY IDCLIENTE"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_CLIENTE WHERE IDCLIENTE LIKE '%" + filtro + "%' ORDER BY IDCLIENTE"
            Case 2
                cmd.CommandText = "SELECT * FROM VW_CLIENTE WHERE CEDULA LIKE '%" + filtro + "%' ORDER BY IDCLIENTE"
            Case 3
                cmd.CommandText = "SELECT * FROM VW_CLIENTE WHERE NOMBRES LIKE '%" + filtro + "%' ORDER BY IDCLIENTE"
        End Select

        Dim LstCliente As New List(Of EntCliente)
        Dim Cliente As EntCliente
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Cliente = New EntCliente(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5))
            LstCliente.Add(Cliente)
        Next
        Return LstCliente
    End Function

    Public Function buscarCol(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntColor) Implements Interfaz.IntDatos.buscarCol
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_COLOR WHERE IDCOLOR LIKE '%" + filtro + "%' OR NOMBRE LIKE '%" + filtro + "%' ORDER BY IDCOLOR"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_COLOR WHERE IDCOLOR LIKE '%" + filtro + "%' ORDER BY IDCOLOR"
            Case 2
                cmd.CommandText = "SELECT * FROM VW_COLOR WHERE NOMBRE LIKE '%" + filtro + "%' ORDER BY IDCOLOR"
        End Select

        Dim LstColor As New List(Of EntColor)
        Dim Color As EntColor
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Color = New EntColor(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1))
            LstColor.Add(Color)
        Next
        Return LstColor
    End Function

    Public Function buscarDet(ByVal opc As Integer, ByVal cod As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntDetalle) Implements Interfaz.IntDatos.buscarDet
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_DETALLE WHERE IDVENTA =" + cod + " AND IDCALZADO LIKE '%" + filtro + "%' ORDER BY IDVENTA"
        End Select
        Dim LstDetalle As New List(Of EntDetalle)
        Dim Detalle As EntDetalle
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Detalle = New EntDetalle(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3))
            LstDetalle.Add(Detalle)
        Next
        Return LstDetalle
    End Function

    Public Function buscarInv(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntInventario) Implements Interfaz.IntDatos.buscarInv
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT INV.IDINVENTARIO,PRO.IDPROVEEDOR,INV.IDCALZADO,INV.FREGISTRO,INV.CANTIDAD,INV.COMENTARIO FROM VW_INVENTARIO INV, VW_PROVEEDOR PRO  WHERE INV.IDPROVEEDOR=PRO.IDPROVEEDOR AND (PRO.RAZONSOCIAL LIKE '%" + filtro + "%' OR INV.IDINVENTARIO  LIKE '%" + filtro + "%') ORDER BY IDINVENTARIO"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_INVENTARIO WHERE IDINVENTARIO LIKE '%" + filtro + "%' ORDER BY IDINVENTARIO"
            Case 2
                cmd.CommandText = "SELECT INV.IDINVENTARIO,PRO.IDPROVEEDOR,INV.IDCALZADO,INV.FREGISTRO,INV.CANTIDAD,INV.COMENTARIO FROM VW_INVENTARIO INV, VW_PROVEEDOR PRO  WHERE INV.IDPROVEEDOR=PRO.IDPROVEEDOR AND PRO.RAZONSOCIAL LIKE '%" + filtro + "%' ORDER BY IDINVENTARIO"
        End Select
        Dim LstInventario As New List(Of EntInventario)
        Dim Inventario As EntInventario
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Inventario = New EntInventario(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5))
            LstInventario.Add(Inventario)
        Next
        Return LstInventario
    End Function

    Public Function buscarPro(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntProveedor) Implements Interfaz.IntDatos.buscarPro
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_PROVEEDOR WHERE IDPROVEEDOR LIKE '%" + filtro + "%' OR RAZONSOCIAL LIKE '%" + filtro + "%' ORDER BY IDPROVEEDOR"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_PROVEEDOR WHERE IDPROVEEDOR LIKE '%" + filtro + "%' ORDER BY IDPROVEEDOR"
            Case 2
                cmd.CommandText = "SELECT * FROM VW_PROVEEDOR WHERE RAZONSOCIAL LIKE '%" + filtro + "%' ORDER BY IDPROVEEDOR"
        End Select

        Dim LstProveedor As New List(Of EntProveedor)
        Dim Proveedor As EntProveedor
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Proveedor = New EntProveedor(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5))
            LstProveedor.Add(Proveedor)
        Next
        Return LstProveedor
    End Function

    Public Function buscarTal(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntTalla) Implements Interfaz.IntDatos.buscarTal
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_TALLA WHERE IDTALLA LIKE '%" + filtro + "%' OR NOMBRE LIKE '%" + filtro + "%' ORDER BY IDTALLA"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_TALLA WHERE IDTALLA LIKE '%" + filtro + "%' ORDER BY IDTALLA"
            Case 2
                cmd.CommandText = "SELECT * FROM VW_TALLA WHERE NOMBRE LIKE '%" + filtro + "%' ORDER BY IDTALLA"
        End Select

        Dim LstTalla As New List(Of EntTalla)
        Dim Talla As EntTalla
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Talla = New EntTalla(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1))
            LstTalla.Add(Talla)
        Next
        Return LstTalla
    End Function

    Public Function buscarVen(ByVal opc As Integer, ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntVenta) Implements Interfaz.IntDatos.buscarVen
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT * FROM VW_VENTA WHERE IDVENTA LIKE '%" + filtro + "%' OR IDCLIENTE LIKE '%" + filtro + "%' ORDER BY IDVENTA"
            Case 1
                cmd.CommandText = "SELECT * FROM VW_VENTA WHERE IDVENTA LIKE '%" + filtro + "%' ORDER BY IDVENTA"
            Case 2
                cmd.CommandText = "SELECT * FROM VW_VENTA WHERE NOMBRE LIKE '%" + filtro + "%' ORDER BY IDVENTA"
        End Select

        Dim LstVenta As New List(Of EntVenta)
        Dim Venta As EntVenta
        Dim Tabla As New DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Venta = New EntVenta(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1), Tabla.Rows(fila).Item(2), Tabla.Rows(fila).Item(3), Tabla.Rows(fila).Item(4), Tabla.Rows(fila).Item(5))
            LstVenta.Add(Venta)
        Next
        Return LstVenta
    End Function

    Public Sub eliminarCal(ByVal Calzado As EntCalzado) Implements Interfaz.IntDatos.eliminarCal
        CalzadoGrabar("ELI", Calzado)
    End Sub

    Public Sub eliminarCat(ByVal Categoria As EntCategoria) Implements Interfaz.IntDatos.eliminarCat
        CategoriaGrabar("ELI", Categoria)
    End Sub

    Public Sub eliminarCli(ByVal Cliente As EntCliente) Implements Interfaz.IntDatos.eliminarCli
        ClienteGrabar("ELI", Cliente)
    End Sub

    Public Sub eliminarCol(ByVal Color As EntColor) Implements Interfaz.IntDatos.eliminarCol
        ColorGrabar("ELI", Color)
    End Sub

    Public Sub eliminarInv(ByVal Inventario As EntInventario) Implements Interfaz.IntDatos.eliminarInv
        InventarioGrabar("ELI", Inventario)
    End Sub

    Public Sub eliminarPro(ByVal Proveedor As EntProveedor) Implements Interfaz.IntDatos.eliminarPro
        ProveedorGrabar("ELI", Proveedor)
    End Sub

    Public Sub eliminarTal(ByVal Talla As EntTalla) Implements Interfaz.IntDatos.eliminarTal
        TallaGrabar("ELI", Talla)
    End Sub

    Public Sub ingresarCal(ByVal Calzado As Entidad.EntCalzado) Implements Interfaz.IntDatos.ingresarCal
        CalzadoGrabar("INS", Calzado)
    End Sub

    Public Sub ingresarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.ingresarCat
        CategoriaGrabar("INS", Categoria)
    End Sub

    Public Sub ingresarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.ingresarCli
        ClienteGrabar("INS", Cliente)
    End Sub

    Public Sub ingresarCol(ByVal Color As Entidad.EntColor) Implements Interfaz.IntDatos.ingresarCol
        ColorGrabar("INS", Color)
    End Sub

    Public Sub ingresarDet(ByVal Detalle As Entidad.EntDetalle) Implements Interfaz.IntDatos.ingresarDet
        DetalleGrabar("INS", Detalle)
    End Sub

    Public Sub ingresarInv(ByVal Inventario As Entidad.EntInventario) Implements Interfaz.IntDatos.ingresarInv
        InventarioGrabar("INS", Inventario)
    End Sub

    Public Sub ingresarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.ingresarPro
        ProveedorGrabar("INS", Proveedor)
    End Sub

    Public Sub ingresarTal(ByVal Talla As Entidad.EntTalla) Implements Interfaz.IntDatos.ingresarTal
        TallaGrabar("INS", Talla)
    End Sub

    Public Sub ingresarVen(ByVal Venta As Entidad.EntVenta) Implements Interfaz.IntDatos.ingresarVen
        VentaGrabar("INS", Venta)
    End Sub

    Public Sub modificarCal(ByVal Calzado As Entidad.EntCalzado) Implements Interfaz.IntDatos.modificarCal
        CalzadoGrabar("MOD", Calzado)
    End Sub

    Public Sub modificarCat(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntDatos.modificarCat
        CategoriaGrabar("MOD", Categoria)
    End Sub

    Public Sub modificarCli(ByVal Cliente As Entidad.EntCliente) Implements Interfaz.IntDatos.modificarCli
        ClienteGrabar("MOD", Cliente)
    End Sub

    Public Sub modificarCol(ByVal Color As Entidad.EntColor) Implements Interfaz.IntDatos.modificarCol
        ColorGrabar("MOD", Color)
    End Sub

    Public Sub modificarInv(ByVal Inventario As Entidad.EntInventario) Implements Interfaz.IntDatos.modificarInv
        InventarioGrabar("MOD", Inventario)
    End Sub

    Public Sub modificarPro(ByVal Proveedor As Entidad.EntProveedor) Implements Interfaz.IntDatos.modificarPro
        ProveedorGrabar("MOD", Proveedor)
    End Sub

    Public Sub modificarTal(ByVal Talla As Entidad.EntTalla) Implements Interfaz.IntDatos.modificarTal
        TallaGrabar("MOD", Talla)
    End Sub


    Public Sub ColorGrabar(ByVal opc As String, ByVal Color As EntColor)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_COLOR"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Color.col_ID
                .Add("@NOM", SqlDbType.VarChar).Value = Color.col_Nombre
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try

    End Sub

    Public Sub CategoriaGrabar(ByVal opc As String, ByVal Categoria As EntCategoria)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_CATEGORIA"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Categoria.cat_ID
                .Add("@DESC", SqlDbType.VarChar).Value = Categoria.cat_Descripcion
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub TallaGrabar(ByVal opc As String, ByVal Talla As EntTalla)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_TALLA"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Talla.tal_ID
                .Add("@NOM", SqlDbType.VarChar).Value = Talla.tal_Nombre
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub ProveedorGrabar(ByVal opc As String, ByVal Proveedor As EntProveedor)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_PROVEEDOR"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Proveedor.pro_ID
                .Add("@RAZ", SqlDbType.VarChar).Value = Proveedor.pro_RazonSocial
                .Add("@RUC", SqlDbType.VarChar).Value = Proveedor.pro_Ruc
                .Add("@TEL", SqlDbType.VarChar).Value = Proveedor.pro_Telefono
                .Add("@EMAIL", SqlDbType.VarChar).Value = Proveedor.pro_Email
                .Add("@DIR", SqlDbType.VarChar).Value = Proveedor.pro_Direccion
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub ClienteGrabar(ByVal opc As String, ByVal Cliente As EntCliente)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_CLIENTE"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Cliente.cli_ID
                .Add("@CED", SqlDbType.VarChar).Value = Cliente.cli_Cedula
                .Add("@NOM", SqlDbType.VarChar).Value = Cliente.cli_Nombres
                .Add("@TEL", SqlDbType.VarChar).Value = Cliente.cli_Telefono
                .Add("@EMAIL", SqlDbType.VarChar).Value = Cliente.cli_Email
                .Add("@SEX", SqlDbType.Bit).Value = Cliente.cli_Sexo
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub CalzadoGrabar(ByVal opc As String, ByVal Calzado As EntCalzado)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_CALZADO"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Calzado.cal_ID
                .Add("@NOM", SqlDbType.VarChar).Value = Calzado.cal_Nombre
                .Add("@IDCAT", SqlDbType.Int).Value = Calzado.cal_CatID
                .Add("@IDTAL", SqlDbType.Int).Value = Calzado.cal_TalID
                .Add("@IDCOL", SqlDbType.Int).Value = Calzado.cal_ColID
                .Add("@GEN", SqlDbType.Bit).Value = Calzado.cal_Genero
                .Add("@PREC", SqlDbType.Real).Value = Calzado.cal_Precio
                .Add("@STOCK", SqlDbType.Int).Value = Calzado.cal_Stock
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Sub InventarioGrabar(ByVal opc As String, ByVal Inventario As EntInventario)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_INVENTARIO"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Inventario.inv_ID
                .Add("@IDPROV", SqlDbType.Int).Value = Inventario.inv_ProID
                .Add("@IDCAL", SqlDbType.Int).Value = Inventario.inv_CalID
                .Add("@CANT", SqlDbType.Int).Value = Inventario.inv_Cantidad
                .Add("@COM", SqlDbType.VarChar).Value = Inventario.inv_Comentario
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub

    Public Sub VentaGrabar(ByVal opc As String, ByVal Venta As EntVenta)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_VENTA"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@ID", SqlDbType.Int).Value = Venta.ven_ID
                .Add("@IDCLI", SqlDbType.Int).Value = Venta.ven_CliID
                .Add("@SUBT", SqlDbType.Real).Value = Venta.ven_SubTotal
                .Add("@IVA", SqlDbType.Real).Value = Venta.ven_IVA
                .Add("@TOTAL", SqlDbType.Real).Value = Venta.ven_Total
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub
    Public Sub DetalleGrabar(ByVal opc As String, ByVal Detalle As EntDetalle)
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_DETALLE"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@IDVENT", SqlDbType.Int).Value = Detalle.det_ID
                .Add("@IDCAL", SqlDbType.Int).Value = Detalle.det_CalID
                .Add("@CANT", SqlDbType.Int).Value = Detalle.det_Cantidad
                .Add("@PREC", SqlDbType.Real).Value = Detalle.det_Precio
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
    End Sub


    Public Sub llenarCombo(ByVal opc As Integer, ByVal Combo As System.Windows.Forms.ComboBox) Implements Interfaz.IntDatos.llenarCombo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Dim ID As String = ""
        Dim Descripcion As String = ""
        Select Case opc
            Case 0
                cmd.CommandText = "SELECT IDCATEGORIA,DESCRIPCION FROM VW_CATEGORIA ORDER BY IDCATEGORIA"
                ID = "IDCATEGORIA"
                Descripcion = "DESCRIPCION"
            Case 1
                cmd.CommandText = "SELECT IDTALLA,NOMBRE FROM VW_TALLA ORDER BY IDTALLA"
                ID = "IDTALLA"
                Descripcion = "NOMBRE"
            Case 2
                cmd.CommandText = "SELECT IDCOLOR,NOMBRE FROM VW_COLOR ORDER BY IDCOLOR"
                ID = "IDCOLOR"
                Descripcion = "NOMBRE"
            Case 3
                cmd.CommandText = "SELECT IDPROVEEDOR,RAZONSOCIAL FROM VW_PROVEEDOR ORDER BY IDPROVEEDOR"
                ID = "IDPROVEEDOR"
                Descripcion = "RAZONSOCIAL"
            Case 4
                cmd.CommandText = "SELECT IDCALZADO, (C.NOMBRE +' '+CAT.DESCRIPCION +' '+ CAST(CO.NOMBRE AS VARCHAR(5))+' '+TA.NOMBRE+' '+(CASE WHEN GENERO=0 THEN 'FEMENINO' ELSE 'MASCULINO' END)) AS NOMBRE FROM VW_CALZADO C, VW_COLOR CO,VW_CATEGORIA CAT,VW_TALLA TA  WHERE C.IDCOLOR=CO.IDCOLOR AND C.IDTALLA=TA.IDTALLA AND C.IDCATEGORIA=CAT.IDCATEGORIA ORDER BY IDCALZADO"
                ID = "IDCALZADO"
                Descripcion = "NOMBRE"
            Case 5
                cmd.CommandText = "SELECT IDCLIENTE,CEDULA FROM VW_CLIENTE ORDER BY IDCLIENTE"
                ID = "IDCLIENTE"
                Descripcion = "CEDULA"
            Case 6
                cmd.CommandText = "SELECT IDCALZADO, (C.NOMBRE +' '+CAT.DESCRIPCION +' '+ CAST(CO.NOMBRE AS VARCHAR(100))+' '+TA.NOMBRE+' '+(CASE WHEN GENERO=0 THEN 'FEMENINO' ELSE 'MASCULINO' END)) AS NOMBRE FROM VW_CALZADO C, VW_COLOR CO,VW_CATEGORIA CAT,VW_TALLA TA  WHERE C.IDCOLOR=CO.IDCOLOR AND C.IDTALLA=TA.IDTALLA AND C.IDCATEGORIA=CAT.IDCATEGORIA AND C.STOCK>0 ORDER BY IDCALZADO"
                ID = "IDCALZADO"
                Descripcion = "NOMBRE"
        End Select
        Dim Tabla As DataTable
        Tabla = sql.Consulta(cmd)
        Combo.DataSource = Tabla
        Combo.DisplayMember = Tabla.Columns(Descripcion).ToString
        Combo.ValueMember = Tabla.Columns(ID).ToString
    End Sub


    Public Function buscarPrecio(ByVal id As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarPrecio
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Dim Tabla As DataTable = Nothing
        cmd.CommandText = "SELECT PRECIO,STOCK FROM VW_CALZADO WHERE IDCALZADO = " + id
        Tabla = sql.Consulta(cmd)
        Return Tabla
    End Function


    Public Function buscarCantidad(ByVal id As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarCantidad
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Dim Tabla As DataTable = Nothing
        cmd.CommandText = "SELECT CANTIDAD FROM INVENTARIO WHERE IDINVENTARIO = " + id
        Tabla = sql.Consulta(cmd)
        Return Tabla
    End Function

    Public Function CargarAuditoria(ByVal opc As String, ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String, ByVal id As Integer) As DataTable
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        Dim Tabla As DataTable = Nothing
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_AUDIT_CONSULTAS"
            With cmd.Parameters
                .Add("@OPC", SqlDbType.VarChar).Value = opc
                .Add("@COD", SqlDbType.Int).Value = cod
                .Add("@FILTRO", SqlDbType.VarChar).Value = filtro
                .Add("@TIPO", SqlDbType.VarChar).Value = tipo
                .Add("@ID", SqlDbType.VarChar).Value = id
            End With
            sql.Ejecutar(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
        Tabla = sql.Consulta(cmd)
        Return Tabla
    End Function

    Public Function buscarAudiInventario(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiInventario
        Return CargarAuditoria("INV", cod, filtro, tipo, 0)
    End Function

    Public Function buscarAudiVenta(ByVal cod As Integer, ByVal filtro As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiVenta
        Return CargarAuditoria("VEN", cod, filtro, "", 0)
    End Function

    Public Function buscarAudiCalzado(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiCalzado
        Return CargarAuditoria("CAL", cod, filtro, tipo, 0)
    End Function

    Public Function buscarAudiCliente(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiCliente
        Return CargarAuditoria("CLI", cod, filtro, tipo, 0)
    End Function

    Public Function buscarAudiProveedor(ByVal cod As Integer, ByVal filtro As String, ByVal tipo As String) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiProveedor
        Return CargarAuditoria("PRO", cod, filtro, tipo, 0)
    End Function

    Public Function buscarAudiDetalle(ByVal cod As Integer, ByVal filtro As String, ByVal id As Integer) As System.Data.DataTable Implements Interfaz.IntDatos.buscarAudiDetalle
        Return CargarAuditoria("DET", cod, filtro, "", id)
    End Function
End Class
