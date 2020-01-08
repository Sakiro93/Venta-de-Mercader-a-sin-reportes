<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Man_Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Man_Venta))
        Me.GB_Cabecera = New System.Windows.Forms.GroupBox()
        Me.BtnAddCliente = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCliente = New System.Windows.Forms.ComboBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GB_Opciones = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calzado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_Detalle = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBCalzado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Cabecera.SuspendLayout()
        Me.GB_Opciones.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Detalle.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Cabecera
        '
        Me.GB_Cabecera.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.GB_Cabecera.Controls.Add(Me.BtnAddCliente)
        Me.GB_Cabecera.Controls.Add(Me.TxtTotal)
        Me.GB_Cabecera.Controls.Add(Me.Label6)
        Me.GB_Cabecera.Controls.Add(Me.TxtIVA)
        Me.GB_Cabecera.Controls.Add(Me.Label4)
        Me.GB_Cabecera.Controls.Add(Me.CBCliente)
        Me.GB_Cabecera.Controls.Add(Me.TxtSubtotal)
        Me.GB_Cabecera.Controls.Add(Me.Label5)
        Me.GB_Cabecera.Controls.Add(Me.Label3)
        Me.GB_Cabecera.Enabled = False
        Me.GB_Cabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Cabecera.Location = New System.Drawing.Point(14, 47)
        Me.GB_Cabecera.Name = "GB_Cabecera"
        Me.GB_Cabecera.Size = New System.Drawing.Size(803, 107)
        Me.GB_Cabecera.TabIndex = 100
        Me.GB_Cabecera.TabStop = False
        Me.GB_Cabecera.Text = "Cabecera"
        '
        'BtnAddCliente
        '
        Me.BtnAddCliente.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin
        Me.BtnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.BtnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddCliente.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCliente.ForeColor = System.Drawing.Color.White
        Me.BtnAddCliente.Image = CType(resources.GetObject("BtnAddCliente.Image"), System.Drawing.Image)
        Me.BtnAddCliente.Location = New System.Drawing.Point(315, 16)
        Me.BtnAddCliente.Name = "BtnAddCliente"
        Me.BtnAddCliente.Size = New System.Drawing.Size(36, 35)
        Me.BtnAddCliente.TabIndex = 167
        Me.BtnAddCliente.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(619, 66)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(161, 24)
        Me.TxtTotal.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(556, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Total :"
        '
        'TxtIVA
        '
        Me.TxtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIVA.Enabled = False
        Me.TxtIVA.Location = New System.Drawing.Point(369, 66)
        Me.TxtIVA.Multiline = True
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(161, 24)
        Me.TxtIVA.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "IVA :"
        '
        'CBCliente
        '
        Me.CBCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCliente.FormattingEnabled = True
        Me.CBCliente.Location = New System.Drawing.Point(126, 22)
        Me.CBCliente.Name = "CBCliente"
        Me.CBCliente.Size = New System.Drawing.Size(161, 23)
        Me.CBCliente.TabIndex = 15
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSubtotal.Enabled = False
        Me.TxtSubtotal.Location = New System.Drawing.Point(126, 66)
        Me.TxtSubtotal.Multiline = True
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(161, 24)
        Me.TxtSubtotal.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Subtotal :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CI - Cliente :"
        '
        'GB_Opciones
        '
        Me.GB_Opciones.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GB_Opciones.Controls.Add(Me.BtnGuardar)
        Me.GB_Opciones.Controls.Add(Me.BtnNuevo)
        Me.GB_Opciones.Controls.Add(Me.BtnRegresar)
        Me.GB_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Opciones.Location = New System.Drawing.Point(14, 408)
        Me.GB_Opciones.Name = "GB_Opciones"
        Me.GB_Opciones.Size = New System.Drawing.Size(803, 84)
        Me.GB_Opciones.TabIndex = 97
        Me.GB_Opciones.TabStop = False
        Me.GB_Opciones.Text = "Opciones"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(315, 26)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(123, 38)
        Me.BtnGuardar.TabIndex = 81
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(43, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(97, 38)
        Me.BtnNuevo.TabIndex = 80
        Me.BtnNuevo.Text = "NUEVO"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.DarkRed
        Me.BtnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.ForeColor = System.Drawing.Color.White
        Me.BtnRegresar.Image = CType(resources.GetObject("BtnRegresar.Image"), System.Drawing.Image)
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(636, 26)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(131, 38)
        Me.BtnRegresar.TabIndex = 78
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.BackgroundColor = System.Drawing.Color.White
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Calzado, Me.Cantidad, Me.Precio})
        Me.Dg.Location = New System.Drawing.Point(369, 29)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(423, 161)
        Me.Dg.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo Calzado"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Calzado
        '
        Me.Calzado.HeaderText = "Calzado"
        Me.Calzado.Name = "Calzado"
        Me.Calzado.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'GB_Detalle
        '
        Me.GB_Detalle.BackColor = System.Drawing.Color.SandyBrown
        Me.GB_Detalle.Controls.Add(Me.BtnEliminar)
        Me.GB_Detalle.Controls.Add(Me.BtnAgregar)
        Me.GB_Detalle.Controls.Add(Me.TxtPrecio)
        Me.GB_Detalle.Controls.Add(Me.Label8)
        Me.GB_Detalle.Controls.Add(Me.TxtCantidad)
        Me.GB_Detalle.Controls.Add(Me.Label7)
        Me.GB_Detalle.Controls.Add(Me.CBCalzado)
        Me.GB_Detalle.Controls.Add(Me.Label1)
        Me.GB_Detalle.Controls.Add(Me.Dg)
        Me.GB_Detalle.Enabled = False
        Me.GB_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Detalle.Location = New System.Drawing.Point(14, 160)
        Me.GB_Detalle.Name = "GB_Detalle"
        Me.GB_Detalle.Size = New System.Drawing.Size(803, 240)
        Me.GB_Detalle.TabIndex = 98
        Me.GB_Detalle.TabStop = False
        Me.GB_Detalle.Text = "Detalle"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(171, 165)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 38)
        Me.BtnEliminar.TabIndex = 84
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(15, 165)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 38)
        Me.BtnAgregar.TabIndex = 84
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(126, 112)
        Me.TxtPrecio.Multiline = True
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(161, 24)
        Me.TxtPrecio.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Precio :"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidad.Location = New System.Drawing.Point(126, 73)
        Me.TxtCantidad.MaxLength = 8
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(161, 24)
        Me.TxtCantidad.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cantidad :"
        '
        'CBCalzado
        '
        Me.CBCalzado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCalzado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCalzado.FormattingEnabled = True
        Me.CBCalzado.Location = New System.Drawing.Point(126, 36)
        Me.CBCalzado.Name = "CBCalzado"
        Me.CBCalzado.Size = New System.Drawing.Size(225, 23)
        Me.CBCalzado.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Calzado :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(224, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 33)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "VENTA DE CALZADOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'Man_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(830, 502)
        Me.Controls.Add(Me.GB_Cabecera)
        Me.Controls.Add(Me.GB_Opciones)
        Me.Controls.Add(Me.GB_Detalle)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Man_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Man_Venta"
        Me.GB_Cabecera.ResumeLayout(False)
        Me.GB_Cabecera.PerformLayout()
        Me.GB_Opciones.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Detalle.ResumeLayout(False)
        Me.GB_Detalle.PerformLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_Cabecera As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GB_Opciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBCliente As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddCliente As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBCalzado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calzado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
