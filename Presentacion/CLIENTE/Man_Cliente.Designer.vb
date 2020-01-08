<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Man_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Man_Cliente))
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GB_Registros = New System.Windows.Forms.GroupBox()
        Me.CBOpcion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GB_Ingresar = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GB_Opciones = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Registros.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Ingresar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GB_Opciones.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Location = New System.Drawing.Point(126, 28)
        Me.TxtBuscar.MaxLength = 30
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(325, 23)
        Me.TxtBuscar.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(667, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Sexo"
        '
        'GB_Registros
        '
        Me.GB_Registros.BackColor = System.Drawing.Color.Silver
        Me.GB_Registros.Controls.Add(Me.CBOpcion)
        Me.GB_Registros.Controls.Add(Me.Label8)
        Me.GB_Registros.Controls.Add(Me.TxtBuscar)
        Me.GB_Registros.Controls.Add(Me.Label1)
        Me.GB_Registros.Controls.Add(Me.Dg)
        Me.GB_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Registros.Location = New System.Drawing.Point(14, 160)
        Me.GB_Registros.Name = "GB_Registros"
        Me.GB_Registros.Size = New System.Drawing.Size(803, 264)
        Me.GB_Registros.TabIndex = 94
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
        Me.CBOpcion.Items.AddRange(New Object() {"Todas", "Código", "Cédula", "Nombre"})
        Me.CBOpcion.Location = New System.Drawing.Point(126, 62)
        Me.CBOpcion.Name = "CBOpcion"
        Me.CBOpcion.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcion.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Filtrar :"
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
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.BackgroundColor = System.Drawing.Color.White
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Cedula, Me.Nombres, Me.Telefono, Me.Email, Me.Sexo})
        Me.Dg.Location = New System.Drawing.Point(15, 97)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(776, 161)
        Me.Dg.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        '
        'Nombres
        '
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(408, 60)
        Me.TxtEmail.MaxLength = 30
        Me.TxtEmail.Multiline = True
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(172, 24)
        Me.TxtEmail.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Email :"
        '
        'GB_Ingresar
        '
        Me.GB_Ingresar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.GB_Ingresar.Controls.Add(Me.Panel1)
        Me.GB_Ingresar.Controls.Add(Me.Label7)
        Me.GB_Ingresar.Controls.Add(Me.TxtEmail)
        Me.GB_Ingresar.Controls.Add(Me.Label6)
        Me.GB_Ingresar.Controls.Add(Me.TxtTelefono)
        Me.GB_Ingresar.Controls.Add(Me.TxtNombres)
        Me.GB_Ingresar.Controls.Add(Me.Label5)
        Me.GB_Ingresar.Controls.Add(Me.Label4)
        Me.GB_Ingresar.Controls.Add(Me.TxtCedula)
        Me.GB_Ingresar.Controls.Add(Me.Label3)
        Me.GB_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Ingresar.Location = New System.Drawing.Point(14, 47)
        Me.GB_Ingresar.Name = "GB_Ingresar"
        Me.GB_Ingresar.Size = New System.Drawing.Size(803, 107)
        Me.GB_Ingresar.TabIndex = 96
        Me.GB_Ingresar.TabStop = False
        Me.GB_Ingresar.Text = "Ingresar Datos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.RBMujer)
        Me.Panel1.Controls.Add(Me.RBHombre)
        Me.Panel1.Location = New System.Drawing.Point(638, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 55)
        Me.Panel1.TabIndex = 22
        '
        'RBMujer
        '
        Me.RBMujer.BackColor = System.Drawing.Color.LightPink
        Me.RBMujer.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.RBMujer.Location = New System.Drawing.Point(0, 33)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(112, 22)
        Me.RBMujer.TabIndex = 0
        Me.RBMujer.Text = "Mujer"
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
        Me.RBHombre.Text = "Hombre"
        Me.RBHombre.UseVisualStyleBackColor = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.Location = New System.Drawing.Point(408, 20)
        Me.TxtTelefono.MaxLength = 10
        Me.TxtTelefono.Multiline = True
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(172, 24)
        Me.TxtTelefono.TabIndex = 18
        '
        'TxtNombres
        '
        Me.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombres.Location = New System.Drawing.Point(126, 60)
        Me.TxtNombres.MaxLength = 50
        Me.TxtNombres.Multiline = True
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(172, 24)
        Me.TxtNombres.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(324, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Teléfono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombres :"
        '
        'TxtCedula
        '
        Me.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCedula.Location = New System.Drawing.Point(126, 20)
        Me.TxtCedula.MaxLength = 10
        Me.TxtCedula.Multiline = True
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(172, 24)
        Me.TxtCedula.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cedula :"
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
        Me.BtnModificar.Location = New System.Drawing.Point(455, 26)
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
        Me.GB_Opciones.Location = New System.Drawing.Point(14, 430)
        Me.GB_Opciones.Name = "GB_Opciones"
        Me.GB_Opciones.Size = New System.Drawing.Size(803, 84)
        Me.GB_Opciones.TabIndex = 93
        Me.GB_Opciones.TabStop = False
        Me.GB_Opciones.Text = "Opciones"
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
        Me.BtnEliminar.Location = New System.Drawing.Point(315, 26)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 38)
        Me.BtnEliminar.TabIndex = 82
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = False
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
        Me.BtnGuardar.Location = New System.Drawing.Point(164, 26)
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
        Me.BtnRegresar.Location = New System.Drawing.Point(619, 26)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(131, 38)
        Me.BtnRegresar.TabIndex = 78
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(188, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(442, 33)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "MANTENIMIENTO CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'Man_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(830, 526)
        Me.Controls.Add(Me.GB_Registros)
        Me.Controls.Add(Me.GB_Ingresar)
        Me.Controls.Add(Me.GB_Opciones)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Man_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Man_Cliente"
        Me.GB_Registros.ResumeLayout(False)
        Me.GB_Registros.PerformLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Ingresar.ResumeLayout(False)
        Me.GB_Ingresar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GB_Opciones.ResumeLayout(False)
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GB_Registros As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GB_Ingresar As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents GB_Opciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RBMujer As System.Windows.Forms.RadioButton
    Friend WithEvents RBHombre As System.Windows.Forms.RadioButton
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents CBOpcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
