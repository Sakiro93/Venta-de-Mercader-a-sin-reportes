Imports System.Windows.Forms
Imports Entidad

Public Class Man_Venta
    Private Metodo As Metodos = New Metodos
    Dim Bandera As Boolean
    Dim BanderaCab As Boolean
    Dim BanderaCabGrab As Boolean
    Dim IDCalzado As Double = 0
    Dim Prec As Double = 0
    Dim Cant As Integer = 0
    Dim Stock As Integer = 0
   
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
    Public Sub llenarCombos()
        Bandera = False
        BanderaCab = False
        BanderaCabGrab = False
        Logicadatos.llenarCombo(6, CBCalzado)
        If CBCalzado.Items.Count < 1 Then
            CBCalzado.Text = ""
        End If
        Logicadatos.llenarCombo(5, CBCliente)
        If CBCliente.Items.Count < 1 Then
            CBCliente.Text = ""
        End If
    End Sub
    Public Sub limpiar()
        BtnEliminar.Enabled = False
        Dg.Rows.Clear()
        ErrDatos.Clear()
        llenarCombos()
        Metodo.LimpiarGroupbox(GB_Cabecera)
        Metodo.LimpiarGroupbox(GB_Detalle)
        IDCalzado = 0
        Prec = 0
        Cant = 0
        Stock = 0
        TxtCantidad.Text = 0
        TxtSubtotal.Text = 0
        TxtIVA.Text = 0
        TxtTotal.Text = 0
        TxtPrecio.Text = Prec * Cant
    End Sub

    Private Sub Man_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        Metodo.tooltip(TooMensaje, GB_Opciones)
        Metodo.tooltip(TooMensaje, GB_Detalle)
        Metodo.Habilitar_GroupBox(GB_Cabecera, 2)
        Metodo.Habilitar_GroupBox(GB_Detalle, 2)
        Metodo.Cargar_Botones(3, GB_Opciones)
        Metodo.Botones(5)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Metodo.Habilitar_GroupBox(GB_Cabecera, 1)
        Metodo.Habilitar_GroupBox(GB_Detalle, 1)
        Metodo.Botones(6)
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("¿Desea guardar estos datos en el Sistema?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            If Metodo.ValidaEntrada(ErrDatos, GB_Cabecera) And Dg.Rows.Count > 0 And BanderaCabGrab Then
                Dim datos = New EntVenta(Cod, CBCliente.SelectedValue, Date.Now, TxtSubtotal.Text, TxtIVA.Text, TxtTotal.Text)
                Logicadatos.ingresarVen(datos)
                guardarDetalle()
                limpiar()
                Metodo.Habilitar_GroupBox(GB_Cabecera, 2)
                Metodo.Habilitar_GroupBox(GB_Detalle, 2)
                Metodo.Botones(5)
            End If
        Else
            limpiar()
            Metodo.Habilitar_GroupBox(GB_Cabecera, 2)
            Metodo.Habilitar_GroupBox(GB_Detalle, 2)
            Metodo.Botones(5)
        End If
    End Sub

    Private Sub BtnAddCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCliente.Click
        Man_Cliente.ShowDialog()
        llenarCombos()
    End Sub

    Private Sub Dg_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg.CellClick
        If Dg.SelectedRows.Count > 0 Then
            ErrDatos.Clear()
            Ind = Dg.CurrentRow.Index
            Cod = Dg.Rows(Ind).Cells(0).Value
            BtnEliminar.Enabled = True
        End If
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If Prec > 0 And Cant > 0 And IDCalzado > 0 Then
            If repetidosCalzado(IDCalzado) = False Then
                If Cant <= Stock Then
                    Dg.Rows.Add(IDCalzado, CBCalzado.Text, Cant, (Prec * Cant))
                    actualizarCabecera()
                Else
                    MessageBox.Show("La cantidad supera al Stock-->" + Stock.ToString)
                End If
            Else
                MessageBox.Show("Calzado Repetido, agregue uno diferente")
            End If
           
        End If
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea eliminar este dato del Detalle?", "Sistema de Ventas de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dg.Rows.RemoveAt(Ind)
            actualizarCabecera()
            BtnEliminar.Enabled = False
        End If
    End Sub

    Private Sub CBCalzado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCalzado.SelectedIndexChanged
        actualizarPrecio()
        TxtPrecio.Text = Prec * Cant
    End Sub

    Private Sub CBCalzado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCalzado.Click
        Bandera = True
        IDCalzado = 0
    End Sub

    Private Sub CBCalzado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCalzado.TextChanged
        If CBCalzado.Text = "" Then
            Cant = 0
            Stock = 0
            TxtPrecio.Text = Prec * Cant
            IDCalzado = 0
            Bandera = False
        End If
    End Sub
    Public Sub actualizarPrecio()
        If Bandera Then
            If CBCalzado.Items.Count > 0 Then
                If CBCalzado.SelectedValue.ToString <> Nothing Then
                    Dim con = Logicadatos.buscarPrecio(CBCalzado.SelectedValue.ToString).Rows.Count
                    If con > 0 Then
                        IDCalzado = CBCalzado.SelectedValue
                        Prec = Convert.ToDouble(Logicadatos.buscarPrecio(CBCalzado.SelectedValue.ToString).Rows(0).Item(0).ToString)
                        Stock = Logicadatos.buscarPrecio(CBCalzado.SelectedValue.ToString).Rows(0).Item(1)
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub actualizarCabecera()
        Dim Subt As Double = 0
        Dim IVA As Double = 0
        Dim Total As Double = 0
        For i As Integer = 0 To Dg.Rows.Count - 1
            Subt += Dg.Rows(i).Cells(3).Value
            IVA += Subt * 0.12
            Total = Subt + IVA
        Next
        TxtSubtotal.Text = Math.Round(Subt, 2)
        TxtIVA.Text = Math.Round(IVA, 2)
        TxtTotal.Text = Math.Round(Total, 2)
    End Sub

    Public Sub guardarDetalle()
        For i As Integer = 0 To Dg.Rows.Count - 1
            Dim datos = New EntDetalle(0, Dg.Rows(i).Cells(0).Value, Dg.Rows(i).Cells(2).Value, Dg.Rows(i).Cells(3).Value)
            Logicadatos.ingresarDet(datos)
        Next
    End Sub

    Private Sub TxtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.TextChanged
        If TxtCantidad.Text <> "" Then
            Cant = Convert.ToInt32(TxtCantidad.Text.Trim)
        Else
            Cant = 0
        End If
        TxtPrecio.Text = Prec * Cant
    End Sub

    Private Sub CBCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCliente.Click
        BanderaCab = True
        BanderaCabGrab = False
    End Sub

    Private Sub CBCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCliente.SelectedIndexChanged
        codigoCliente()
    End Sub

    Public Sub codigoCliente()
        BanderaCabGrab = False
        If BanderaCab Then
            If CBCliente.Items.Count > 0 Then
                If CBCliente.SelectedValue.ToString <> Nothing Then
                    If CBCliente.SelectedValue > 0 Then
                        BanderaCabGrab = True
                    End If
                End If
            End If
        End If
        BanderaCab = False
    End Sub

    Private Sub CBCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCliente.TextChanged
        If CBCliente.Text = "" Then
            BanderaCab = False
        End If
        BanderaCabGrab = False
    End Sub

    Public Function repetidosCalzado(ByVal id As Double) As Boolean
        For i As Integer = 0 To Dg.Rows.Count - 1
            If id = Dg.Rows(i).Cells(0).Value Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub TxtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        Metodo.ValidarNumeros(e)
    End Sub
End Class