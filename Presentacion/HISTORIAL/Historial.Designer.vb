<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historial))
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GB_Opciones = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TC_Historial = New System.Windows.Forms.TabControl()
        Me.Ventas = New System.Windows.Forms.TabPage()
        Me.GB_Ventas = New System.Windows.Forms.GroupBox()
        Me.CBOpcionVenta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscarVentas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_Ventas = New System.Windows.Forms.DataGridView()
        Me.VenCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenFechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenEstacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenAccion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Inventario = New System.Windows.Forms.TabPage()
        Me.GB_Inventario = New System.Windows.Forms.GroupBox()
        Me.CBTipoInventario = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBOpcionInventario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBuscarInventario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dg_Inventario = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCalzado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvFRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvComentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvEstacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calzados = New System.Windows.Forms.TabPage()
        Me.GB_Calzado = New System.Windows.Forms.GroupBox()
        Me.CBTipoCalzado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBOpcionCalzado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBuscarCalzado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dg_Calzado = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clientes = New System.Windows.Forms.TabPage()
        Me.GB_Cliente = New System.Windows.Forms.GroupBox()
        Me.CBTipoCliente = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBOpcionCliente = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Dg_Cliente = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedores = New System.Windows.Forms.TabPage()
        Me.GB_Proveedor = New System.Windows.Forms.GroupBox()
        Me.CBTipoProveedor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBOpcionProveedor = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtBuscarProveedor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Dg_Proveedor = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Opciones.SuspendLayout()
        Me.TC_Historial.SuspendLayout()
        Me.Ventas.SuspendLayout()
        Me.GB_Ventas.SuspendLayout()
        CType(Me.Dg_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inventario.SuspendLayout()
        Me.GB_Inventario.SuspendLayout()
        CType(Me.Dg_Inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Calzados.SuspendLayout()
        Me.GB_Calzado.SuspendLayout()
        CType(Me.Dg_Calzado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clientes.SuspendLayout()
        Me.GB_Cliente.SuspendLayout()
        CType(Me.Dg_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Proveedores.SuspendLayout()
        Me.GB_Proveedor.SuspendLayout()
        CType(Me.Dg_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'GB_Opciones
        '
        Me.GB_Opciones.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GB_Opciones.Controls.Add(Me.BtnRegresar)
        Me.GB_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Opciones.Location = New System.Drawing.Point(12, 434)
        Me.GB_Opciones.Name = "GB_Opciones"
        Me.GB_Opciones.Size = New System.Drawing.Size(1062, 84)
        Me.GB_Opciones.TabIndex = 102
        Me.GB_Opciones.TabStop = False
        Me.GB_Opciones.Text = "Opciones"
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
        Me.BtnRegresar.Location = New System.Drawing.Point(458, 21)
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
        Me.Label2.Location = New System.Drawing.Point(402, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 33)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "HISTORIAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TC_Historial
        '
        Me.TC_Historial.Controls.Add(Me.Ventas)
        Me.TC_Historial.Controls.Add(Me.Inventario)
        Me.TC_Historial.Controls.Add(Me.Calzados)
        Me.TC_Historial.Controls.Add(Me.Clientes)
        Me.TC_Historial.Controls.Add(Me.Proveedores)
        Me.TC_Historial.Location = New System.Drawing.Point(12, 60)
        Me.TC_Historial.Name = "TC_Historial"
        Me.TC_Historial.SelectedIndex = 0
        Me.TC_Historial.Size = New System.Drawing.Size(1066, 368)
        Me.TC_Historial.TabIndex = 105
        '
        'Ventas
        '
        Me.Ventas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Ventas.Controls.Add(Me.GB_Ventas)
        Me.Ventas.Location = New System.Drawing.Point(4, 22)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Padding = New System.Windows.Forms.Padding(3)
        Me.Ventas.Size = New System.Drawing.Size(1058, 342)
        Me.Ventas.TabIndex = 0
        Me.Ventas.Text = "Ventas"
        '
        'GB_Ventas
        '
        Me.GB_Ventas.BackColor = System.Drawing.Color.Silver
        Me.GB_Ventas.Controls.Add(Me.CBOpcionVenta)
        Me.GB_Ventas.Controls.Add(Me.Label4)
        Me.GB_Ventas.Controls.Add(Me.TxtBuscarVentas)
        Me.GB_Ventas.Controls.Add(Me.Label1)
        Me.GB_Ventas.Controls.Add(Me.Dg_Ventas)
        Me.GB_Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Ventas.Location = New System.Drawing.Point(6, 6)
        Me.GB_Ventas.Name = "GB_Ventas"
        Me.GB_Ventas.Size = New System.Drawing.Size(1046, 330)
        Me.GB_Ventas.TabIndex = 83
        Me.GB_Ventas.TabStop = False
        Me.GB_Ventas.Text = "Registros"
        '
        'CBOpcionVenta
        '
        Me.CBOpcionVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOpcionVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOpcionVenta.FormattingEnabled = True
        Me.CBOpcionVenta.Items.AddRange(New Object() {"Todas", "Código", "Cliente"})
        Me.CBOpcionVenta.Location = New System.Drawing.Point(126, 62)
        Me.CBOpcionVenta.Name = "CBOpcionVenta"
        Me.CBOpcionVenta.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcionVenta.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Filtrar :"
        '
        'TxtBuscarVentas
        '
        Me.TxtBuscarVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarVentas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarVentas.Location = New System.Drawing.Point(126, 23)
        Me.TxtBuscarVentas.MaxLength = 30
        Me.TxtBuscarVentas.Multiline = True
        Me.TxtBuscarVentas.Name = "TxtBuscarVentas"
        Me.TxtBuscarVentas.Size = New System.Drawing.Size(267, 23)
        Me.TxtBuscarVentas.TabIndex = 3
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
        'Dg_Ventas
        '
        Me.Dg_Ventas.AllowUserToAddRows = False
        Me.Dg_Ventas.AllowUserToDeleteRows = False
        Me.Dg_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Ventas.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dg_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VenCodigo, Me.VenCliente, Me.VenFechaRegistro, Me.VenSubTotal, Me.VenIVA, Me.VenTotal, Me.VenFecha, Me.VenHora, Me.VenUsuario, Me.VenEstacion, Me.VenTipo, Me.VenAccion})
        Me.Dg_Ventas.Location = New System.Drawing.Point(15, 105)
        Me.Dg_Ventas.Name = "Dg_Ventas"
        Me.Dg_Ventas.ReadOnly = True
        Me.Dg_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Ventas.Size = New System.Drawing.Size(1025, 208)
        Me.Dg_Ventas.TabIndex = 1
        '
        'VenCodigo
        '
        Me.VenCodigo.HeaderText = "Codigo"
        Me.VenCodigo.Name = "VenCodigo"
        Me.VenCodigo.ReadOnly = True
        '
        'VenCliente
        '
        Me.VenCliente.HeaderText = "Cliente"
        Me.VenCliente.Name = "VenCliente"
        Me.VenCliente.ReadOnly = True
        '
        'VenFechaRegistro
        '
        Me.VenFechaRegistro.HeaderText = "Fecha de Registro"
        Me.VenFechaRegistro.Name = "VenFechaRegistro"
        Me.VenFechaRegistro.ReadOnly = True
        '
        'VenSubTotal
        '
        Me.VenSubTotal.HeaderText = "SubTotal"
        Me.VenSubTotal.Name = "VenSubTotal"
        Me.VenSubTotal.ReadOnly = True
        '
        'VenIVA
        '
        Me.VenIVA.HeaderText = "IVA"
        Me.VenIVA.Name = "VenIVA"
        Me.VenIVA.ReadOnly = True
        '
        'VenTotal
        '
        Me.VenTotal.HeaderText = "Total"
        Me.VenTotal.Name = "VenTotal"
        Me.VenTotal.ReadOnly = True
        '
        'VenFecha
        '
        Me.VenFecha.HeaderText = "Fecha"
        Me.VenFecha.Name = "VenFecha"
        Me.VenFecha.ReadOnly = True
        '
        'VenHora
        '
        Me.VenHora.HeaderText = "Hora"
        Me.VenHora.Name = "VenHora"
        Me.VenHora.ReadOnly = True
        '
        'VenUsuario
        '
        Me.VenUsuario.HeaderText = "Usuario"
        Me.VenUsuario.Name = "VenUsuario"
        Me.VenUsuario.ReadOnly = True
        '
        'VenEstacion
        '
        Me.VenEstacion.HeaderText = "Estacion"
        Me.VenEstacion.Name = "VenEstacion"
        Me.VenEstacion.ReadOnly = True
        '
        'VenTipo
        '
        Me.VenTipo.HeaderText = "Tipo"
        Me.VenTipo.Name = "VenTipo"
        Me.VenTipo.ReadOnly = True
        '
        'VenAccion
        '
        Me.VenAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VenAccion.HeaderText = "Accion"
        Me.VenAccion.Name = "VenAccion"
        Me.VenAccion.ReadOnly = True
        Me.VenAccion.Text = "Ver Detalle"
        Me.VenAccion.ToolTipText = "Click para Ver Detalle"
        Me.VenAccion.UseColumnTextForButtonValue = True
        '
        'Inventario
        '
        Me.Inventario.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Inventario.Controls.Add(Me.GB_Inventario)
        Me.Inventario.Location = New System.Drawing.Point(4, 22)
        Me.Inventario.Name = "Inventario"
        Me.Inventario.Padding = New System.Windows.Forms.Padding(3)
        Me.Inventario.Size = New System.Drawing.Size(1058, 342)
        Me.Inventario.TabIndex = 1
        Me.Inventario.Text = "Inventario"
        '
        'GB_Inventario
        '
        Me.GB_Inventario.BackColor = System.Drawing.Color.Silver
        Me.GB_Inventario.Controls.Add(Me.CBTipoInventario)
        Me.GB_Inventario.Controls.Add(Me.Label6)
        Me.GB_Inventario.Controls.Add(Me.CBOpcionInventario)
        Me.GB_Inventario.Controls.Add(Me.Label3)
        Me.GB_Inventario.Controls.Add(Me.TxtBuscarInventario)
        Me.GB_Inventario.Controls.Add(Me.Label5)
        Me.GB_Inventario.Controls.Add(Me.Dg_Inventario)
        Me.GB_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Inventario.Location = New System.Drawing.Point(6, 6)
        Me.GB_Inventario.Name = "GB_Inventario"
        Me.GB_Inventario.Size = New System.Drawing.Size(1046, 330)
        Me.GB_Inventario.TabIndex = 84
        Me.GB_Inventario.TabStop = False
        Me.GB_Inventario.Text = "Registros"
        '
        'CBTipoInventario
        '
        Me.CBTipoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBTipoInventario.FormattingEnabled = True
        Me.CBTipoInventario.Items.AddRange(New Object() {"Todas", "Registradas", "Eliminadas", "Actualizadas"})
        Me.CBTipoInventario.Location = New System.Drawing.Point(559, 62)
        Me.CBTipoInventario.Name = "CBTipoInventario"
        Me.CBTipoInventario.Size = New System.Drawing.Size(130, 23)
        Me.CBTipoInventario.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(445, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Tipo :"
        '
        'CBOpcionInventario
        '
        Me.CBOpcionInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOpcionInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOpcionInventario.FormattingEnabled = True
        Me.CBOpcionInventario.Items.AddRange(New Object() {"Todas", "Código", "Proveedor", "Calzado"})
        Me.CBOpcionInventario.Location = New System.Drawing.Point(126, 62)
        Me.CBOpcionInventario.Name = "CBOpcionInventario"
        Me.CBOpcionInventario.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcionInventario.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Filtrar :"
        '
        'TxtBuscarInventario
        '
        Me.TxtBuscarInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarInventario.Location = New System.Drawing.Point(126, 23)
        Me.TxtBuscarInventario.MaxLength = 30
        Me.TxtBuscarInventario.Multiline = True
        Me.TxtBuscarInventario.Name = "TxtBuscarInventario"
        Me.TxtBuscarInventario.Size = New System.Drawing.Size(267, 23)
        Me.TxtBuscarInventario.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Buscar :"
        '
        'Dg_Inventario
        '
        Me.Dg_Inventario.AllowUserToAddRows = False
        Me.Dg_Inventario.AllowUserToDeleteRows = False
        Me.Dg_Inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Inventario.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Inventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.InvProveedor, Me.InvCalzado, Me.InvFRegistro, Me.InvCantidad, Me.InvComentario, Me.InvFecha, Me.InvHora, Me.InvUsuario, Me.InvEstacion, Me.InvTipo})
        Me.Dg_Inventario.Location = New System.Drawing.Point(15, 105)
        Me.Dg_Inventario.Name = "Dg_Inventario"
        Me.Dg_Inventario.ReadOnly = True
        Me.Dg_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Inventario.Size = New System.Drawing.Size(1025, 208)
        Me.Dg_Inventario.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'InvProveedor
        '
        Me.InvProveedor.HeaderText = "Proveedor"
        Me.InvProveedor.Name = "InvProveedor"
        Me.InvProveedor.ReadOnly = True
        '
        'InvCalzado
        '
        Me.InvCalzado.HeaderText = "Calzado"
        Me.InvCalzado.Name = "InvCalzado"
        Me.InvCalzado.ReadOnly = True
        '
        'InvFRegistro
        '
        Me.InvFRegistro.HeaderText = "Fecha de Registro"
        Me.InvFRegistro.Name = "InvFRegistro"
        Me.InvFRegistro.ReadOnly = True
        '
        'InvCantidad
        '
        Me.InvCantidad.HeaderText = "Cantidad"
        Me.InvCantidad.Name = "InvCantidad"
        Me.InvCantidad.ReadOnly = True
        '
        'InvComentario
        '
        Me.InvComentario.HeaderText = "Comentario"
        Me.InvComentario.Name = "InvComentario"
        Me.InvComentario.ReadOnly = True
        '
        'InvFecha
        '
        Me.InvFecha.HeaderText = "Fecha"
        Me.InvFecha.Name = "InvFecha"
        Me.InvFecha.ReadOnly = True
        '
        'InvHora
        '
        Me.InvHora.HeaderText = "Hora"
        Me.InvHora.Name = "InvHora"
        Me.InvHora.ReadOnly = True
        '
        'InvUsuario
        '
        Me.InvUsuario.HeaderText = "Usuario"
        Me.InvUsuario.Name = "InvUsuario"
        Me.InvUsuario.ReadOnly = True
        '
        'InvEstacion
        '
        Me.InvEstacion.HeaderText = "Estacion"
        Me.InvEstacion.Name = "InvEstacion"
        Me.InvEstacion.ReadOnly = True
        '
        'InvTipo
        '
        Me.InvTipo.HeaderText = "Tipo"
        Me.InvTipo.Name = "InvTipo"
        Me.InvTipo.ReadOnly = True
        '
        'Calzados
        '
        Me.Calzados.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Calzados.Controls.Add(Me.GB_Calzado)
        Me.Calzados.Location = New System.Drawing.Point(4, 22)
        Me.Calzados.Name = "Calzados"
        Me.Calzados.Padding = New System.Windows.Forms.Padding(3)
        Me.Calzados.Size = New System.Drawing.Size(1058, 342)
        Me.Calzados.TabIndex = 2
        Me.Calzados.Text = "Calzados"
        '
        'GB_Calzado
        '
        Me.GB_Calzado.BackColor = System.Drawing.Color.Silver
        Me.GB_Calzado.Controls.Add(Me.CBTipoCalzado)
        Me.GB_Calzado.Controls.Add(Me.Label7)
        Me.GB_Calzado.Controls.Add(Me.CBOpcionCalzado)
        Me.GB_Calzado.Controls.Add(Me.Label8)
        Me.GB_Calzado.Controls.Add(Me.TxtBuscarCalzado)
        Me.GB_Calzado.Controls.Add(Me.Label9)
        Me.GB_Calzado.Controls.Add(Me.Dg_Calzado)
        Me.GB_Calzado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Calzado.Location = New System.Drawing.Point(6, 6)
        Me.GB_Calzado.Name = "GB_Calzado"
        Me.GB_Calzado.Size = New System.Drawing.Size(1046, 330)
        Me.GB_Calzado.TabIndex = 87
        Me.GB_Calzado.TabStop = False
        Me.GB_Calzado.Text = "Registros"
        '
        'CBTipoCalzado
        '
        Me.CBTipoCalzado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipoCalzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBTipoCalzado.FormattingEnabled = True
        Me.CBTipoCalzado.Items.AddRange(New Object() {"Todas", "Registradas", "Eliminadas", "Actualizadas"})
        Me.CBTipoCalzado.Location = New System.Drawing.Point(559, 62)
        Me.CBTipoCalzado.Name = "CBTipoCalzado"
        Me.CBTipoCalzado.Size = New System.Drawing.Size(130, 23)
        Me.CBTipoCalzado.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(445, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 18)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Tipo :"
        '
        'CBOpcionCalzado
        '
        Me.CBOpcionCalzado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOpcionCalzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOpcionCalzado.FormattingEnabled = True
        Me.CBOpcionCalzado.Items.AddRange(New Object() {"Todas", "Código", "Nombre", "Categoria"})
        Me.CBOpcionCalzado.Location = New System.Drawing.Point(126, 62)
        Me.CBOpcionCalzado.Name = "CBOpcionCalzado"
        Me.CBOpcionCalzado.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcionCalzado.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Filtrar :"
        '
        'TxtBuscarCalzado
        '
        Me.TxtBuscarCalzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarCalzado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarCalzado.Location = New System.Drawing.Point(126, 23)
        Me.TxtBuscarCalzado.MaxLength = 30
        Me.TxtBuscarCalzado.Multiline = True
        Me.TxtBuscarCalzado.Name = "TxtBuscarCalzado"
        Me.TxtBuscarCalzado.Size = New System.Drawing.Size(267, 23)
        Me.TxtBuscarCalzado.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Buscar :"
        '
        'Dg_Calzado
        '
        Me.Dg_Calzado.AllowUserToAddRows = False
        Me.Dg_Calzado.AllowUserToDeleteRows = False
        Me.Dg_Calzado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Calzado.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Calzado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg_Calzado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Calzado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.CalPrecio, Me.CalStock, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Dg_Calzado.Location = New System.Drawing.Point(15, 105)
        Me.Dg_Calzado.Name = "Dg_Calzado"
        Me.Dg_Calzado.ReadOnly = True
        Me.Dg_Calzado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Calzado.Size = New System.Drawing.Size(1025, 208)
        Me.Dg_Calzado.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Talla"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Genero"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'CalPrecio
        '
        Me.CalPrecio.HeaderText = "Precio"
        Me.CalPrecio.Name = "CalPrecio"
        Me.CalPrecio.ReadOnly = True
        '
        'CalStock
        '
        Me.CalStock.HeaderText = "Stock"
        Me.CalStock.Name = "CalStock"
        Me.CalStock.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Estacion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Clientes.Controls.Add(Me.GB_Cliente)
        Me.Clientes.Location = New System.Drawing.Point(4, 22)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.Clientes.Size = New System.Drawing.Size(1058, 342)
        Me.Clientes.TabIndex = 3
        Me.Clientes.Text = "Clientes"
        '
        'GB_Cliente
        '
        Me.GB_Cliente.BackColor = System.Drawing.Color.Silver
        Me.GB_Cliente.Controls.Add(Me.CBTipoCliente)
        Me.GB_Cliente.Controls.Add(Me.Label10)
        Me.GB_Cliente.Controls.Add(Me.CBOpcionCliente)
        Me.GB_Cliente.Controls.Add(Me.Label11)
        Me.GB_Cliente.Controls.Add(Me.TxtBuscarCliente)
        Me.GB_Cliente.Controls.Add(Me.Label12)
        Me.GB_Cliente.Controls.Add(Me.Dg_Cliente)
        Me.GB_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Cliente.Location = New System.Drawing.Point(6, 6)
        Me.GB_Cliente.Name = "GB_Cliente"
        Me.GB_Cliente.Size = New System.Drawing.Size(1046, 330)
        Me.GB_Cliente.TabIndex = 88
        Me.GB_Cliente.TabStop = False
        Me.GB_Cliente.Text = "Registros"
        '
        'CBTipoCliente
        '
        Me.CBTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBTipoCliente.FormattingEnabled = True
        Me.CBTipoCliente.Items.AddRange(New Object() {"Todas", "Registradas", "Eliminadas", "Actualizadas"})
        Me.CBTipoCliente.Location = New System.Drawing.Point(559, 62)
        Me.CBTipoCliente.Name = "CBTipoCliente"
        Me.CBTipoCliente.Size = New System.Drawing.Size(130, 23)
        Me.CBTipoCliente.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(445, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 18)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Tipo :"
        '
        'CBOpcionCliente
        '
        Me.CBOpcionCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOpcionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOpcionCliente.FormattingEnabled = True
        Me.CBOpcionCliente.Items.AddRange(New Object() {"Todas", "Código", "Cédula", "Nombres"})
        Me.CBOpcionCliente.Location = New System.Drawing.Point(126, 62)
        Me.CBOpcionCliente.Name = "CBOpcionCliente"
        Me.CBOpcionCliente.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcionCliente.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Filtrar :"
        '
        'TxtBuscarCliente
        '
        Me.TxtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(126, 23)
        Me.TxtBuscarCliente.MaxLength = 30
        Me.TxtBuscarCliente.Multiline = True
        Me.TxtBuscarCliente.Name = "TxtBuscarCliente"
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(267, 23)
        Me.TxtBuscarCliente.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Buscar :"
        '
        'Dg_Cliente
        '
        Me.Dg_Cliente.AllowUserToAddRows = False
        Me.Dg_Cliente.AllowUserToDeleteRows = False
        Me.Dg_Cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Cliente.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.Dg_Cliente.Location = New System.Drawing.Point(15, 105)
        Me.Dg_Cliente.Name = "Dg_Cliente"
        Me.Dg_Cliente.ReadOnly = True
        Me.Dg_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Cliente.Size = New System.Drawing.Size(1025, 208)
        Me.Dg_Cliente.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Estacion"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'Proveedores
        '
        Me.Proveedores.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Proveedores.Controls.Add(Me.GB_Proveedor)
        Me.Proveedores.Location = New System.Drawing.Point(4, 22)
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(1058, 342)
        Me.Proveedores.TabIndex = 4
        Me.Proveedores.Text = "Proveedores"
        '
        'GB_Proveedor
        '
        Me.GB_Proveedor.BackColor = System.Drawing.Color.Silver
        Me.GB_Proveedor.Controls.Add(Me.CBTipoProveedor)
        Me.GB_Proveedor.Controls.Add(Me.Label13)
        Me.GB_Proveedor.Controls.Add(Me.CBOpcionProveedor)
        Me.GB_Proveedor.Controls.Add(Me.Label14)
        Me.GB_Proveedor.Controls.Add(Me.TxtBuscarProveedor)
        Me.GB_Proveedor.Controls.Add(Me.Label15)
        Me.GB_Proveedor.Controls.Add(Me.Dg_Proveedor)
        Me.GB_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Proveedor.Location = New System.Drawing.Point(6, 6)
        Me.GB_Proveedor.Name = "GB_Proveedor"
        Me.GB_Proveedor.Size = New System.Drawing.Size(1046, 330)
        Me.GB_Proveedor.TabIndex = 88
        Me.GB_Proveedor.TabStop = False
        Me.GB_Proveedor.Text = "Registros"
        '
        'CBTipoProveedor
        '
        Me.CBTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBTipoProveedor.FormattingEnabled = True
        Me.CBTipoProveedor.Items.AddRange(New Object() {"Todas", "Registradas", "Eliminadas", "Actualizadas"})
        Me.CBTipoProveedor.Location = New System.Drawing.Point(559, 62)
        Me.CBTipoProveedor.Name = "CBTipoProveedor"
        Me.CBTipoProveedor.Size = New System.Drawing.Size(130, 23)
        Me.CBTipoProveedor.TabIndex = 68
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(445, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 18)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Tipo :"
        '
        'CBOpcionProveedor
        '
        Me.CBOpcionProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOpcionProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOpcionProveedor.FormattingEnabled = True
        Me.CBOpcionProveedor.Items.AddRange(New Object() {"Todas", "Código", "Razon Social", "RUC"})
        Me.CBOpcionProveedor.Location = New System.Drawing.Point(126, 62)
        Me.CBOpcionProveedor.Name = "CBOpcionProveedor"
        Me.CBOpcionProveedor.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcionProveedor.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 18)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Filtrar :"
        '
        'TxtBuscarProveedor
        '
        Me.TxtBuscarProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarProveedor.Location = New System.Drawing.Point(126, 23)
        Me.TxtBuscarProveedor.MaxLength = 30
        Me.TxtBuscarProveedor.Multiline = True
        Me.TxtBuscarProveedor.Name = "TxtBuscarProveedor"
        Me.TxtBuscarProveedor.Size = New System.Drawing.Size(267, 23)
        Me.TxtBuscarProveedor.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Buscar :"
        '
        'Dg_Proveedor
        '
        Me.Dg_Proveedor.AllowUserToAddRows = False
        Me.Dg_Proveedor.AllowUserToDeleteRows = False
        Me.Dg_Proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Proveedor.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Proveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34})
        Me.Dg_Proveedor.Location = New System.Drawing.Point(15, 105)
        Me.Dg_Proveedor.Name = "Dg_Proveedor"
        Me.Dg_Proveedor.ReadOnly = True
        Me.Dg_Proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Proveedor.Size = New System.Drawing.Size(1025, 208)
        Me.Dg_Proveedor.TabIndex = 1
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.HeaderText = "Estacion"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1090, 530)
        Me.Controls.Add(Me.TC_Historial)
        Me.Controls.Add(Me.GB_Opciones)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Historial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial"
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Opciones.ResumeLayout(False)
        Me.TC_Historial.ResumeLayout(False)
        Me.Ventas.ResumeLayout(False)
        Me.GB_Ventas.ResumeLayout(False)
        Me.GB_Ventas.PerformLayout()
        CType(Me.Dg_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inventario.ResumeLayout(False)
        Me.GB_Inventario.ResumeLayout(False)
        Me.GB_Inventario.PerformLayout()
        CType(Me.Dg_Inventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Calzados.ResumeLayout(False)
        Me.GB_Calzado.ResumeLayout(False)
        Me.GB_Calzado.PerformLayout()
        CType(Me.Dg_Calzado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clientes.ResumeLayout(False)
        Me.GB_Cliente.ResumeLayout(False)
        Me.GB_Cliente.PerformLayout()
        CType(Me.Dg_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Proveedores.ResumeLayout(False)
        Me.GB_Proveedor.ResumeLayout(False)
        Me.GB_Proveedor.PerformLayout()
        CType(Me.Dg_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents GB_Opciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TC_Historial As System.Windows.Forms.TabControl
    Friend WithEvents Ventas As System.Windows.Forms.TabPage
    Friend WithEvents Inventario As System.Windows.Forms.TabPage
    Friend WithEvents GB_Ventas As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscarVentas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dg_Ventas As System.Windows.Forms.DataGridView
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents CBOpcionVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VenCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenFechaRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenEstacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenAccion As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GB_Inventario As System.Windows.Forms.GroupBox
    Friend WithEvents CBOpcionInventario As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarInventario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Dg_Inventario As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCalzado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvFRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvComentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvEstacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBTipoInventario As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Clientes As System.Windows.Forms.TabPage
    Friend WithEvents Proveedores As System.Windows.Forms.TabPage
    Friend WithEvents Calzados As System.Windows.Forms.TabPage
    Friend WithEvents GB_Calzado As System.Windows.Forms.GroupBox
    Friend WithEvents CBTipoCalzado As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBOpcionCalzado As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarCalzado As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Dg_Calzado As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GB_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents CBTipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBOpcionCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Dg_Cliente As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Proveedor As System.Windows.Forms.GroupBox
    Friend WithEvents CBTipoProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBOpcionProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Dg_Proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
