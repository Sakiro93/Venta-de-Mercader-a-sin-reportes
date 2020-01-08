<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Man_Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Man_Inventario))
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_Registros = New System.Windows.Forms.GroupBox()
        Me.CBOpcion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calzado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GB_Opciones = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GB_Ingresar = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.CBCalzado = New System.Windows.Forms.ComboBox()
        Me.BtnAddProveedor = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBProveedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Registros.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Opciones.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Ingresar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Location = New System.Drawing.Point(126, 20)
        Me.TxtBuscar.MaxLength = 30
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(267, 23)
        Me.TxtBuscar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar :"
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
        Me.GB_Registros.Location = New System.Drawing.Point(16, 166)
        Me.GB_Registros.Name = "GB_Registros"
        Me.GB_Registros.Size = New System.Drawing.Size(768, 262)
        Me.GB_Registros.TabIndex = 82
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
        Me.CBOpcion.Items.AddRange(New Object() {"Todas", "Código", "Proveedor"})
        Me.CBOpcion.Location = New System.Drawing.Point(126, 51)
        Me.CBOpcion.Name = "CBOpcion"
        Me.CBOpcion.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcion.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Filtrar :"
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.BackgroundColor = System.Drawing.Color.White
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Proveedor, Me.Calzado, Me.FechaRegistro, Me.Cantidad, Me.Comentario})
        Me.Dg.Location = New System.Drawing.Point(9, 84)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(753, 172)
        Me.Dg.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'Calzado
        '
        Me.Calzado.HeaderText = "Calzado"
        Me.Calzado.Name = "Calzado"
        Me.Calzado.ReadOnly = True
        '
        'FechaRegistro
        '
        Me.FechaRegistro.HeaderText = "Fecha de Registro"
        Me.FechaRegistro.Name = "FechaRegistro"
        Me.FechaRegistro.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Comentario
        '
        Me.Comentario.HeaderText = "Comentario"
        Me.Comentario.Name = "Comentario"
        Me.Comentario.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(258, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 33)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "INVENTARIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GB_Opciones.Location = New System.Drawing.Point(16, 434)
        Me.GB_Opciones.Name = "GB_Opciones"
        Me.GB_Opciones.Size = New System.Drawing.Size(768, 84)
        Me.GB_Opciones.TabIndex = 81
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
        Me.BtnEliminar.Location = New System.Drawing.Point(297, 26)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(146, 26)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(25, 26)
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
        Me.BtnRegresar.Location = New System.Drawing.Point(601, 26)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(131, 38)
        Me.BtnRegresar.TabIndex = 78
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'GB_Ingresar
        '
        Me.GB_Ingresar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.GB_Ingresar.Controls.Add(Me.Label4)
        Me.GB_Ingresar.Controls.Add(Me.TxtComentario)
        Me.GB_Ingresar.Controls.Add(Me.CBCalzado)
        Me.GB_Ingresar.Controls.Add(Me.BtnAddProveedor)
        Me.GB_Ingresar.Controls.Add(Me.TxtCantidad)
        Me.GB_Ingresar.Controls.Add(Me.Label6)
        Me.GB_Ingresar.Controls.Add(Me.CBProveedor)
        Me.GB_Ingresar.Controls.Add(Me.Label5)
        Me.GB_Ingresar.Controls.Add(Me.Label3)
        Me.GB_Ingresar.Enabled = False
        Me.GB_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Ingresar.Location = New System.Drawing.Point(16, 45)
        Me.GB_Ingresar.Name = "GB_Ingresar"
        Me.GB_Ingresar.Size = New System.Drawing.Size(767, 115)
        Me.GB_Ingresar.TabIndex = 101
        Me.GB_Ingresar.TabStop = False
        Me.GB_Ingresar.Text = "Ingresar Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(548, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Comentario "
        '
        'TxtComentario
        '
        Me.TxtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtComentario.Location = New System.Drawing.Point(437, 60)
        Me.TxtComentario.MaxLength = 100
        Me.TxtComentario.Multiline = True
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(295, 24)
        Me.TxtComentario.TabIndex = 169
        '
        'CBCalzado
        '
        Me.CBCalzado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCalzado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCalzado.FormattingEnabled = True
        Me.CBCalzado.Location = New System.Drawing.Point(126, 59)
        Me.CBCalzado.Name = "CBCalzado"
        Me.CBCalzado.Size = New System.Drawing.Size(267, 23)
        Me.CBCalzado.TabIndex = 168
        '
        'BtnAddProveedor
        '
        Me.BtnAddProveedor.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnAddProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin
        Me.BtnAddProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.BtnAddProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddProveedor.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnAddProveedor.Image = CType(resources.GetObject("BtnAddProveedor.Image"), System.Drawing.Image)
        Me.BtnAddProveedor.Location = New System.Drawing.Point(315, 16)
        Me.BtnAddProveedor.Name = "BtnAddProveedor"
        Me.BtnAddProveedor.Size = New System.Drawing.Size(36, 35)
        Me.BtnAddProveedor.TabIndex = 167
        Me.BtnAddProveedor.UseVisualStyleBackColor = False
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantidad.Location = New System.Drawing.Point(518, 21)
        Me.TxtCantidad.MaxLength = 8
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(161, 24)
        Me.TxtCantidad.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(434, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cantidad :"
        '
        'CBProveedor
        '
        Me.CBProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBProveedor.FormattingEnabled = True
        Me.CBProveedor.Location = New System.Drawing.Point(126, 22)
        Me.CBProveedor.Name = "CBProveedor"
        Me.CBProveedor.Size = New System.Drawing.Size(161, 23)
        Me.CBProveedor.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Calzado :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Proveedor :"
        '
        'Man_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(799, 530)
        Me.Controls.Add(Me.GB_Ingresar)
        Me.Controls.Add(Me.GB_Registros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GB_Opciones)
        Me.MaximizeBox = False
        Me.Name = "Man_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Man_Inventario"
        Me.GB_Registros.ResumeLayout(False)
        Me.GB_Registros.PerformLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Opciones.ResumeLayout(False)
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Ingresar.ResumeLayout(False)
        Me.GB_Ingresar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GB_Registros As System.Windows.Forms.GroupBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents GB_Opciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents GB_Ingresar As System.Windows.Forms.GroupBox
    Friend WithEvents CBCalzado As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddProveedor As System.Windows.Forms.Button
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calzado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtComentario As System.Windows.Forms.TextBox
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents CBOpcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
