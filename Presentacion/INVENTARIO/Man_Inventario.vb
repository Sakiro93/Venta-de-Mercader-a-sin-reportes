Imports System.Windows.Forms
Imports Entidad

Public Class Man_Inventario
    Private Metodo As Metodos = New Metodos
    Dim Cant As Integer
    Dim IdProv As Double
    Dim IdCal As Double
    Dim BanderaCal As Boolean
    Dim BanderaPro As Boolean
    Dim Stock As Integer
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
    Public Sub cargar(ByVal Buscar As String)
        Dg.Rows.Clear()
        Dim pro As String = ""
        Dim cal As String = ""
        If CBProveedor.Items.Count > 0 And CBCalzado.Items.Count > 0 Then
            For Each inv In Logicadatos.buscarInv(CBOpcion.SelectedIndex, Buscar)
                CBProveedor.SelectedValue = inv.inv_ProID
                CBCalzado.SelectedValue = inv.inv_CalID
                pro = CBProveedor.Text
                cal = CBCalzado.Text
                Dg.Rows.Add(inv.inv_ID, pro, cal, inv.inv_FRegistro, inv.inv_Cantidad, inv.inv_Comentario)
            Next
        End If
        llenarCombos()
    End Sub
    Public Sub llenarCombos()
        Stock = 0
        Cant = 0
        IdProv = 0
        IdCal = 0
        BanderaCal = False
        BanderaPro = False
        Logicadatos.llenarCombo(3, CBProveedor)
        If CBProveedor.Items.Count < 1 Then
            CBProveedor.Text = ""
        End If
        Logicadatos.llenarCombo(4, CBCalzado)
        If CBCalzado.Items.Count < 1 Then
            CBCalzado.Text = ""
        End If
    End Sub
    Public Sub limpiar()
        ErrDatos.Clear()
        llenarCombos()
        Metodo.LimpiarGroupbox(GB_Ingresar)
        Metodo.LimpiarGroupbox(GB_Registros)
        CBOpcion.SelectedIndex = 0
        TxtCantidad.Text = 0
    End Sub
    Private Sub Man_Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Metodo.ValidaEntrada(ErrDatos, GB_Ingresar) Then
                If CBCalzado.Items.Count > 0 And CBProveedor.Items.Count > 0 Then
                    Dim datos = New EntInventario(Cod, CBProveedor.SelectedValue, CBCalzado.SelectedValue, Date.Now(), TxtCantidad.Text, TxtComentario.Text)
                    If grabarG = "N" Then
                        Logicadatos.ingresarInv(datos)
                    Else
                        If IdCal > 0 And IdProv > 0 Then
                            If Cant < Stock Then
                                datos = New EntInventario(Cod, CBProveedor.SelectedValue, CBCalzado.SelectedValue, Date.Now(), TxtCantidad.Text, TxtComentario.Text)
                                Logicadatos.modificarInv(datos)
                            Else
                                MessageBox.Show("No puede eliminar el registro, porque fue utilizado. Stock actual --->" + Stock.ToString)
                            End If
                        Else
                            MessageBox.Show("Seleccione o haga click en el Calzado o Proveedor")
                        End If
                       
                    End If
                    limpiar()
                    cargar(TxtBuscar.Text)
                    Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
                    Metodo.Botones(1)
                End If
            End If
        Else
            limpiar()
            Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
            Metodo.Botones(1)
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea eliminar este dato en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Stock = Logicadatos.buscarPrecio(CBCalzado.SelectedValue.ToString).Rows(0).Item(1)
            If TxtCantidad.Text < Stock Then
                Dim datos = New EntInventario(Cod, CBProveedor.SelectedValue, CBCalzado.SelectedValue, Date.Now(), TxtCantidad.Text, TxtComentario.Text)
                Logicadatos.eliminarInv(datos)
                limpiar()
                cargar(TxtBuscar.Text)
            Else
                MessageBox.Show("No puede eliminar el registro, porque fue utilizado. Stock actual --->" + Stock.ToString)
            End If
        End If
        Stock = 0
        Metodo.Habilitar_GroupBox(GB_Ingresar, 2)
        Metodo.Botones(1)
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        grabarG = "M"
        Metodo.Habilitar_GroupBox(GB_Ingresar, 1)
        Metodo.Botones(4)
    End Sub

    Private Sub BtnAddProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProveedor.Click
        Man_Proveedor.ShowDialog()
        llenarCombos()
        cargar(TxtBuscar.Text)
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
        CBProveedor.Text = Dg.Rows(i).Cells(1).Value.ToString
        CBCalzado.Text = Dg.Rows(i).Cells(2).Value.ToString
        TxtCantidad.Text = Dg.Rows(i).Cells(4).Value.ToString
        TxtComentario.Text = Dg.Rows(i).Cells(5).Value.ToString
        Metodo.Botones(3)
    End Sub
    
    Private Sub CBOpcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOpcion.SelectedIndexChanged
        cargar(TxtBuscar.Text.Trim())
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        Metodo.ValidarNumeros(e)
    End Sub

    Private Sub CBCalzado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCalzado.SelectedIndexChanged
        If grabarG = "M" Then
            IdCalzado()
        End If
    End Sub

    Private Sub CBProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProveedor.SelectedIndexChanged
        IdProveedor()
    End Sub

    Private Sub CBProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProveedor.Click
        BanderaPro = True
    End Sub

    Private Sub CBCalzado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCalzado.Click
        BanderaCal = True
    End Sub

    Private Sub CBProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProveedor.TextChanged
        If CBProveedor.Text = "" Then
            BanderaPro = False
            IdProv = 0
        End If
    End Sub

    Private Sub CBCalzado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCalzado.TextChanged
        If CBCalzado.Text = "" Then
            BanderaCal = False
            IdCal = 0
        End If
    End Sub
    Public Sub IdCalzado()
        IdCal = 0
        If BanderaCal Then
            If CBCalzado.Items.Count > 0 Then
                If CBCalzado.SelectedValue.ToString <> Nothing Then
                    If CBCalzado.SelectedValue > 0 Then
                        Cant = Logicadatos.buscarCantidad(Cod).Rows(0).Item(0)
                        IdCal = CBCalzado.SelectedValue
                    End If
                End If
            End If
        End If
        BanderaCal = False
    End Sub
    Public Sub IdProveedor()
        IdProv = 0
        If BanderaPro Then
            If CBProveedor.Items.Count > 0 Then
                If CBProveedor.SelectedValue.ToString <> Nothing Then
                    If CBProveedor.SelectedValue > 0 Then
                        Stock = Logicadatos.buscarPrecio(CBCalzado.SelectedValue.ToString).Rows(0).Item(1)
                        IdProv = CBProveedor.SelectedValue
                    End If
                End If
            End If
        End If
        BanderaPro = False
    End Sub
End Class