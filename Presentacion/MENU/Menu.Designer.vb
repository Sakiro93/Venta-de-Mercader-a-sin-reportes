<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblTiempo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_Listado = New System.Windows.Forms.GroupBox()
        Me.BtnTalla = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnCategoria = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnHistorial = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCalzado = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PB_Inicial = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Listado.SuspendLayout()
        CType(Me.PB_Inicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(30, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 80)
        Me.Label6.TabIndex = 159
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(442, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 21)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "HORA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(442, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 21)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "FECHA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(217, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 31)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "MENÚ"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.BackColor = System.Drawing.Color.White
        Me.LblFecha.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(544, 26)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(67, 21)
        Me.LblFecha.TabIndex = 155
        Me.LblFecha.Text = "Fecha"
        '
        'LblTiempo
        '
        Me.LblTiempo.AutoSize = True
        Me.LblTiempo.BackColor = System.Drawing.Color.White
        Me.LblTiempo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiempo.Location = New System.Drawing.Point(544, 70)
        Me.LblTiempo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTiempo.Name = "LblTiempo"
        Me.LblTiempo.Size = New System.Drawing.Size(57, 21)
        Me.LblTiempo.TabIndex = 154
        Me.LblTiempo.Text = "Hora"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(793, 116)
        Me.Label1.TabIndex = 153
        '
        'GB_Listado
        '
        Me.GB_Listado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GB_Listado.Controls.Add(Me.BtnTalla)
        Me.GB_Listado.Controls.Add(Me.Label14)
        Me.GB_Listado.Controls.Add(Me.BtnColor)
        Me.GB_Listado.Controls.Add(Me.Label13)
        Me.GB_Listado.Controls.Add(Me.BtnCategoria)
        Me.GB_Listado.Controls.Add(Me.Label12)
        Me.GB_Listado.Controls.Add(Me.BtnHistorial)
        Me.GB_Listado.Controls.Add(Me.Label11)
        Me.GB_Listado.Controls.Add(Me.BtnProveedores)
        Me.GB_Listado.Controls.Add(Me.Label10)
        Me.GB_Listado.Controls.Add(Me.BtnClientes)
        Me.GB_Listado.Controls.Add(Me.Label4)
        Me.GB_Listado.Controls.Add(Me.BtnVenta)
        Me.GB_Listado.Controls.Add(Me.Label3)
        Me.GB_Listado.Controls.Add(Me.Label2)
        Me.GB_Listado.Controls.Add(Me.BtnCalzado)
        Me.GB_Listado.Controls.Add(Me.BtnInventario)
        Me.GB_Listado.Controls.Add(Me.Label16)
        Me.GB_Listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Listado.Location = New System.Drawing.Point(353, 128)
        Me.GB_Listado.Name = "GB_Listado"
        Me.GB_Listado.Size = New System.Drawing.Size(450, 387)
        Me.GB_Listado.TabIndex = 166
        Me.GB_Listado.TabStop = False
        Me.GB_Listado.Text = "Listado"
        '
        'BtnTalla
        '
        Me.BtnTalla.BackColor = System.Drawing.Color.White
        Me.BtnTalla.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnTalla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.BtnTalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnTalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTalla.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTalla.ForeColor = System.Drawing.Color.White
        Me.BtnTalla.Image = CType(resources.GetObject("BtnTalla.Image"), System.Drawing.Image)
        Me.BtnTalla.Location = New System.Drawing.Point(326, 271)
        Me.BtnTalla.Name = "BtnTalla"
        Me.BtnTalla.Size = New System.Drawing.Size(104, 73)
        Me.BtnTalla.TabIndex = 181
        Me.BtnTalla.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(359, 347)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 180
        Me.Label14.Text = "Talla"
        '
        'BtnColor
        '
        Me.BtnColor.BackColor = System.Drawing.Color.White
        Me.BtnColor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnColor.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnColor.ForeColor = System.Drawing.Color.White
        Me.BtnColor.Image = CType(resources.GetObject("BtnColor.Image"), System.Drawing.Image)
        Me.BtnColor.Location = New System.Drawing.Point(184, 271)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(104, 73)
        Me.BtnColor.TabIndex = 179
        Me.BtnColor.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(217, 347)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 178
        Me.Label13.Text = "Color"
        '
        'BtnCategoria
        '
        Me.BtnCategoria.BackColor = System.Drawing.Color.White
        Me.BtnCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque
        Me.BtnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.BtnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategoria.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategoria.ForeColor = System.Drawing.Color.White
        Me.BtnCategoria.Image = CType(resources.GetObject("BtnCategoria.Image"), System.Drawing.Image)
        Me.BtnCategoria.Location = New System.Drawing.Point(33, 271)
        Me.BtnCategoria.Name = "BtnCategoria"
        Me.BtnCategoria.Size = New System.Drawing.Size(104, 73)
        Me.BtnCategoria.TabIndex = 177
        Me.BtnCategoria.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(44, 347)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = "Categoría"
        '
        'BtnHistorial
        '
        Me.BtnHistorial.BackColor = System.Drawing.Color.White
        Me.BtnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.BtnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistorial.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistorial.ForeColor = System.Drawing.Color.White
        Me.BtnHistorial.Image = CType(resources.GetObject("BtnHistorial.Image"), System.Drawing.Image)
        Me.BtnHistorial.Location = New System.Drawing.Point(326, 156)
        Me.BtnHistorial.Name = "BtnHistorial"
        Me.BtnHistorial.Size = New System.Drawing.Size(104, 73)
        Me.BtnHistorial.TabIndex = 175
        Me.BtnHistorial.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(350, 232)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 15)
        Me.Label11.TabIndex = 174
        Me.Label11.Text = "Historial"
        '
        'BtnProveedores
        '
        Me.BtnProveedores.BackColor = System.Drawing.Color.White
        Me.BtnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite
        Me.BtnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon
        Me.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedores.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.ForeColor = System.Drawing.Color.White
        Me.BtnProveedores.Image = CType(resources.GetObject("BtnProveedores.Image"), System.Drawing.Image)
        Me.BtnProveedores.Location = New System.Drawing.Point(184, 156)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(104, 73)
        Me.BtnProveedores.TabIndex = 173
        Me.BtnProveedores.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(192, 232)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 15)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "Proveedores"
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.White
        Me.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.Location = New System.Drawing.Point(31, 156)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(104, 73)
        Me.BtnClientes.TabIndex = 171
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 232)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Clientes"
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.White
        Me.BtnVenta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.BtnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.ForeColor = System.Drawing.Color.White
        Me.BtnVenta.Image = CType(resources.GetObject("BtnVenta.Image"), System.Drawing.Image)
        Me.BtnVenta.Location = New System.Drawing.Point(184, 30)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(104, 73)
        Me.BtnVenta.TabIndex = 169
        Me.BtnVenta.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "Venta Calzados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Registro Calzados"
        '
        'BtnCalzado
        '
        Me.BtnCalzado.BackColor = System.Drawing.Color.White
        Me.BtnCalzado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCalzado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin
        Me.BtnCalzado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.BtnCalzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalzado.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalzado.ForeColor = System.Drawing.Color.White
        Me.BtnCalzado.Image = CType(resources.GetObject("BtnCalzado.Image"), System.Drawing.Image)
        Me.BtnCalzado.Location = New System.Drawing.Point(33, 30)
        Me.BtnCalzado.Name = "BtnCalzado"
        Me.BtnCalzado.Size = New System.Drawing.Size(104, 73)
        Me.BtnCalzado.TabIndex = 166
        Me.BtnCalzado.UseVisualStyleBackColor = False
        '
        'BtnInventario
        '
        Me.BtnInventario.BackColor = System.Drawing.Color.White
        Me.BtnInventario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventario.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.ForeColor = System.Drawing.Color.White
        Me.BtnInventario.Image = CType(resources.GetObject("BtnInventario.Image"), System.Drawing.Image)
        Me.BtnInventario.Location = New System.Drawing.Point(326, 30)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(104, 73)
        Me.BtnInventario.TabIndex = 165
        Me.BtnInventario.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(343, 106)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 15)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "Inventario"
        '
        'PB_Inicial
        '
        Me.PB_Inicial.BackgroundImage = CType(resources.GetObject("PB_Inicial.BackgroundImage"), System.Drawing.Image)
        Me.PB_Inicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_Inicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_Inicial.Location = New System.Drawing.Point(12, 139)
        Me.PB_Inicial.Name = "PB_Inicial"
        Me.PB_Inicial.Size = New System.Drawing.Size(335, 376)
        Me.PB_Inicial.TabIndex = 169
        Me.PB_Inicial.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(162, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(230, 34)
        Me.Label9.TabIndex = 170
        Me.Label9.Text = "MERCADERÍA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(711, 96)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 17)
        Me.Label17.TabIndex = 182
        Me.Label17.Text = "Salir"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(679, 20)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 73)
        Me.BtnSalir.TabIndex = 182
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(11, 524)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(792, 33)
        Me.Label15.TabIndex = 183
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(815, 566)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PB_Inicial)
        Me.Controls.Add(Me.GB_Listado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblTiempo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.GB_Listado.ResumeLayout(False)
        Me.GB_Listado.PerformLayout()
        CType(Me.PB_Inicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblTiempo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GB_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCalzado As System.Windows.Forms.Button
    Friend WithEvents BtnInventario As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PB_Inicial As System.Windows.Forms.PictureBox
    Friend WithEvents BtnVenta As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnTalla As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnColor As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnCategoria As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnHistorial As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnProveedores As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Tiempo As System.Windows.Forms.Timer
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
End Class
