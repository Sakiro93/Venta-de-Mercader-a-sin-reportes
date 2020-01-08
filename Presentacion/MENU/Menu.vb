Imports System.Windows.Forms
Imports System.Drawing

Public Class Menu

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tooltip()
    End Sub
    Private Sub tooltip() 'Mensaje 
        TooMensaje.SetToolTip(BtnSalir, "Salir Del Sistema")
        TooMensaje.SetToolTip(BtnCalzado, "Registrar Calzados")
        TooMensaje.SetToolTip(BtnVenta, "Realizar Ventas")
        TooMensaje.SetToolTip(BtnInventario, "Realizar Inventario")
        TooMensaje.SetToolTip(BtnClientes, "Registrar Clientes")
        TooMensaje.SetToolTip(BtnProveedores, "Registrar Proveedores")
        TooMensaje.SetToolTip(BtnHistorial, "Consultar Historial")
        TooMensaje.SetToolTip(BtnCategoria, "Registrar Categorías")
        TooMensaje.SetToolTip(BtnColor, "Registrar Colores")
        TooMensaje.SetToolTip(BtnTalla, "Registrar Tallas")
        TooMensaje.ToolTipTitle = "Sistema de Ventas de Mercadería"
        TooMensaje.ToolTipIcon = ToolTipIcon.None
        TooMensaje.BackColor = Color.Transparent
    End Sub
    Private Sub BtnCalzado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalzado.Click
        Man_Calzado.ShowDialog()
    End Sub

    Private Sub BtnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.Click
        Man_Venta.ShowDialog()
    End Sub

    Private Sub BtnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        Man_Cliente.ShowDialog()
    End Sub

    Private Sub BtnProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedores.Click
        Man_Proveedor.ShowDialog()
    End Sub

    Private Sub BtnCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategoria.Click
        Man_Categoria.ShowDialog()
    End Sub

    Private Sub BtnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColor.Click
        Man_Color.ShowDialog()
    End Sub

    Private Sub BtnTalla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTalla.Click
        Man_Talla.ShowDialog()
    End Sub

    Private Sub Tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tiempo.Tick
        LblFecha.Text = DateTime.Now.ToShortDateString
        LblTiempo.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("¿Esta Seguro de Salir del Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInventario.Click
        Man_Inventario.ShowDialog()
    End Sub

    Private Sub BtnHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistorial.Click
        Historial.ShowDialog()
    End Sub

   
End Class