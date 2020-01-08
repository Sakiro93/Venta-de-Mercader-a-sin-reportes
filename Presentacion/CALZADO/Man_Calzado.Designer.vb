<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Man_Calzado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Man_Calzado))
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GB_Ingresar = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBColor = New System.Windows.Forms.ComboBox()
        Me.CBTalla = New System.Windows.Forms.ComboBox()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_Registros = New System.Windows.Forms.GroupBox()
        Me.CBOpcion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GB_Opciones = New System.Windows.Forms.GroupBox()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Ingresar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Registros.SuspendLayout()
        Me.GB_Opciones.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Location = New System.Drawing.Point(102, 28)
        Me.TxtBuscar.MaxLength = 30
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(325, 23)
        Me.TxtBuscar.TabIndex = 3
        '
        'GB_Ingresar
        '
        Me.GB_Ingresar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.GB_Ingresar.Controls.Add(Me.Panel1)
        Me.GB_Ingresar.Controls.Add(Me.Label7)
        Me.GB_Ingresar.Controls.Add(Me.CBColor)
        Me.GB_Ingresar.Controls.Add(Me.CBTalla)
        Me.GB_Ingresar.Controls.Add(Me.CBCategoria)
        Me.GB_Ingresar.Controls.Add(Me.TxtStock)
        Me.GB_Ingresar.Controls.Add(Me.TxtPrecio)
        Me.GB_Ingresar.Controls.Add(Me.Label9)
        Me.GB_Ingresar.Controls.Add(Me.Label8)
        Me.GB_Ingresar.Controls.Add(Me.Label6)
        Me.GB_Ingresar.Controls.Add(Me.Label5)
        Me.GB_Ingresar.Controls.Add(Me.Label4)
        Me.GB_Ingresar.Controls.Add(Me.TxtNombre)
        Me.GB_Ingresar.Controls.Add(Me.Label3)
        Me.GB_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Ingresar.Location = New System.Drawing.Point(15, 45)
        Me.GB_Ingresar.Name = "GB_Ingresar"
        Me.GB_Ingresar.Size = New System.Drawing.Size(768, 107)
        Me.GB_Ingresar.TabIndex = 88
        Me.GB_Ingresar.TabStop = False
        Me.GB_Ingresar.Text = "Ingresar Datos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.RBMujer)
        Me.Panel1.Controls.Add(Me.RBHombre)
        Me.Panel1.Location = New System.Drawing.Point(620, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 55)
        Me.Panel1.TabIndex = 24
        '
        'RBMujer
        '
        Me.RBMujer.BackColor = System.Drawing.Color.LightPink
        Me.RBMujer.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.RBMujer.Location = New System.Drawing.Point(0, 33)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(112, 22)
        Me.RBMujer.TabIndex = 0
        Me.RBMujer.Text = "Femenino"
        Me.RBMujer.UseVisualStyleBackColor = False
        '
        'RBHombre
        '
        Me.RBHombre.BackColor = System.Drawing.Color.CornflowerBlue
        Me.RBHombre.Checked = True
        Me.RBHombre.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.RBHombre.Location = New System.Drawing.Point(0, 0)
        Me.RBHombre.Name = "RBHombre"
        Me.RBHombre.Size = New System.Drawing.Size(112, 24)
        Me.RBHombre.TabIndex = 1
        Me.RBHombre.TabStop = True
        Me.RBHombre.Text = "Masculino"
        Me.RBHombre.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(642, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Genero"
        '
        'CBColor
        '
        Me.CBColor.FormattingEnabled = True
        Me.CBColor.Location = New System.Drawing.Point(338, 57)
        Me.CBColor.Name = "CBColor"
        Me.CBColor.Size = New System.Drawing.Size(89, 23)
        Me.CBColor.TabIndex = 15
        '
        'CBTalla
        '
        Me.CBTalla.FormattingEnabled = True
        Me.CBTalla.Location = New System.Drawing.Point(338, 18)
        Me.CBTalla.Name = "CBTalla"
        Me.CBTalla.Size = New System.Drawing.Size(89, 23)
        Me.CBTalla.TabIndex = 14
        '
        'CBCategoria
        '
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Location = New System.Drawing.Point(102, 60)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(121, 23)
        Me.CBCategoria.TabIndex = 13
        '
        'TxtStock
        '
        Me.TxtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStock.Location = New System.Drawing.Point(509, 17)
        Me.TxtStock.MaxLength = 8
        Me.TxtStock.Multiline = True
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(92, 24)
        Me.TxtStock.TabIndex = 6
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecio.Location = New System.Drawing.Point(509, 59)
        Me.TxtPrecio.MaxLength = 8
        Me.TxtPrecio.Multiline = True
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(92, 24)
        Me.TxtPrecio.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(445, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Stock :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(445, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Precio :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Color :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Talla :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Categoría :"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(102, 20)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(172, 24)
        Me.TxtNombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(189, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(464, 33)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "MANTENIMIENTO CALZADO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.BackgroundColor = System.Drawing.Color.White
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Categoria, Me.Talla, Me.Color, Me.Genero, Me.Precio, Me.Stock})
        Me.Dg.Location = New System.Drawing.Point(10, 95)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(750, 165)
        Me.Dg.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Nombre"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Talla
        '
        Me.Talla.HeaderText = "Talla"
        Me.Talla.Name = "Talla"
        Me.Talla.ReadOnly = True
        '
        'Color
        '
        Me.Color.HeaderText = "Color"
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        '
        'Genero
        '
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'GB_Registros
        '
        Me.GB_Registros.BackColor = System.Drawing.Color.Silver
        Me.GB_Registros.Controls.Add(Me.CBOpcion)
        Me.GB_Registros.Controls.Add(Me.Label10)
        Me.GB_Registros.Controls.Add(Me.TxtBuscar)
        Me.GB_Registros.Controls.Add(Me.Label1)
        Me.GB_Registros.Controls.Add(Me.Dg)
        Me.GB_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Registros.Location = New System.Drawing.Point(15, 158)
        Me.GB_Registros.Name = "GB_Registros"
        Me.GB_Registros.Size = New System.Drawing.Size(768, 266)
        Me.GB_Registros.TabIndex = 86
        Me.GB_Registros.TabStop = False
        Me.GB_Registros.Text = "Registros"
        '
        'CBOpcion
        '
        Me.CBOpcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBOpcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOpcion.FormattingEnabled = True
        Me.CBOpcion.Items.AddRange(New Object() {"Todas", "Código", "Nombre"})
        Me.CBOpcion.Location = New System.Drawing.Point(102, 58)
        Me.CBOpcion.Name = "CBOpcion"
        Me.CBOpcion.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcion.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Filtrar :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar :"
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
        Me.BtnRegresar.Location = New System.Drawing.Point(601, 26)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(131, 38)
        Me.BtnRegresar.TabIndex = 78
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = False
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
        Me.BtnNuevo.Location = New System.Drawing.Point(25, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(97, 38)
        Me.BtnNuevo.TabIndex = 80
        Me.BtnNuevo.Text = "NUEVO"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = False
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
        Me.BtnGuardar.Location = New System.Drawing.Point(146, 26)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(123, 38)
        Me.BtnGuardar.TabIndex = 81
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Tomato
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(297, 26)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 38)
        Me.BtnEliminar.TabIndex = 82
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(437, 26)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(131, 38)
        Me.BtnModificar.TabIndex = 83
        Me.BtnModificar.Text = "MODIFICAR"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'GB_Opciones
        '
        Me.GB_Opciones.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GB_Opciones.Controls.Add(Me.BtnModificar)
        Me.GB_Opciones.Controls.Add(Me.BtnEliminar)
        Me.GB_Opciones.Controls.Add(Me.BtnGuardar)
        Me.GB_Opciones.Controls.Add(Me.BtnNuevo)
        Me.GB_Opciones.Controls.Add(Me.BtnRegresar)
        Me.GB_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Opciones.Location = New System.Drawing.Point(15, 430)
        Me.GB_Opciones.Name = "GB_Opciones"
        Me.GB_Opciones.Size = New System.Drawing.Size(768, 84)
        Me.GB_Opciones.TabIndex = 85
        Me.GB_Opciones.TabStop = False
        Me.GB_Opciones.Text = "Opciones"
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'Man_Calzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(799, 526)
        Me.Controls.Add(Me.GB_Ingresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GB_Opciones)
        Me.Controls.Add(Me.GB_Registros)
        Me.MaximizeBox = False
        Me.Name = "Man_Calzado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Man_Calzado"
        Me.GB_Ingresar.ResumeLayout(False)
        Me.GB_Ingresar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Registros.ResumeLayout(False)
        Me.GB_Registros.PerformLayout()
        Me.GB_Opciones.ResumeLayout(False)
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GB_Ingresar As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Registros As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBColor As System.Windows.Forms.ComboBox
    Friend WithEvents CBTalla As System.Windows.Forms.ComboBox
    Friend WithEvents CBCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents GB_Opciones As System.Windows.Forms.GroupBox
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Talla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents CBOpcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RBMujer As System.Windows.Forms.RadioButton
    Friend WithEvents RBHombre As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
