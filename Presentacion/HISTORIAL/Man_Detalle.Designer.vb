<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Con_Detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Con_Detalle))
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Detalle = New System.Windows.Forms.GroupBox()
        Me.CBOpcionDetalle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscarDetalle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_Detalle = New System.Windows.Forms.DataGridView()
        Me.VenCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenFechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenEstacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_Opciones = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Detalle.SuspendLayout()
        CType(Me.Dg_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(416, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 33)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "DETALLE DE VENTA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GB_Detalle
        '
        Me.GB_Detalle.BackColor = System.Drawing.Color.Silver
        Me.GB_Detalle.Controls.Add(Me.CBOpcionDetalle)
        Me.GB_Detalle.Controls.Add(Me.Label4)
        Me.GB_Detalle.Controls.Add(Me.TxtBuscarDetalle)
        Me.GB_Detalle.Controls.Add(Me.Label1)
        Me.GB_Detalle.Controls.Add(Me.Dg_Detalle)
        Me.GB_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Detalle.Location = New System.Drawing.Point(22, 81)
        Me.GB_Detalle.Name = "GB_Detalle"
        Me.GB_Detalle.Size = New System.Drawing.Size(1094, 341)
        Me.GB_Detalle.TabIndex = 109
        Me.GB_Detalle.TabStop = False
        Me.GB_Detalle.Text = "Registros"
        '
        'CBOpcionDetalle
        '
        Me.CBOpcionDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOpcionDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBOpcionDetalle.FormattingEnabled = True
        Me.CBOpcionDetalle.Items.AddRange(New Object() {"Todas", "Calzado", "Categoria", "Color", "Talla"})
        Me.CBOpcionDetalle.Location = New System.Drawing.Point(126, 62)
        Me.CBOpcionDetalle.Name = "CBOpcionDetalle"
        Me.CBOpcionDetalle.Size = New System.Drawing.Size(130, 23)
        Me.CBOpcionDetalle.TabIndex = 0
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
        'TxtBuscarDetalle
        '
        Me.TxtBuscarDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscarDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarDetalle.Location = New System.Drawing.Point(126, 23)
        Me.TxtBuscarDetalle.MaxLength = 30
        Me.TxtBuscarDetalle.Multiline = True
        Me.TxtBuscarDetalle.Name = "TxtBuscarDetalle"
        Me.TxtBuscarDetalle.Size = New System.Drawing.Size(267, 23)
        Me.TxtBuscarDetalle.TabIndex = 3
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
        'Dg_Detalle
        '
        Me.Dg_Detalle.AllowUserToAddRows = False
        Me.Dg_Detalle.AllowUserToDeleteRows = False
        Me.Dg_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Detalle.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dg_Detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VenCodigo, Me.VenCliente, Me.VenFechaRegistro, Me.VenSubTotal, Me.VenIVA, Me.VenTotal, Me.Cantidad, Me.Precio, Me.VenFecha, Me.VenHora, Me.VenUsuario, Me.VenEstacion, Me.VenTipo})
        Me.Dg_Detalle.Location = New System.Drawing.Point(15, 105)
        Me.Dg_Detalle.Name = "Dg_Detalle"
        Me.Dg_Detalle.ReadOnly = True
        Me.Dg_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Detalle.Size = New System.Drawing.Size(1058, 221)
        Me.Dg_Detalle.TabIndex = 1
        '
        'VenCodigo
        '
        Me.VenCodigo.HeaderText = "Codigo"
        Me.VenCodigo.Name = "VenCodigo"
        Me.VenCodigo.ReadOnly = True
        '
        'VenCliente
        '
        Me.VenCliente.HeaderText = "Calzado"
        Me.VenCliente.Name = "VenCliente"
        Me.VenCliente.ReadOnly = True
        '
        'VenFechaRegistro
        '
        Me.VenFechaRegistro.HeaderText = "Categoria"
        Me.VenFechaRegistro.Name = "VenFechaRegistro"
        Me.VenFechaRegistro.ReadOnly = True
        '
        'VenSubTotal
        '
        Me.VenSubTotal.HeaderText = "Color"
        Me.VenSubTotal.Name = "VenSubTotal"
        Me.VenSubTotal.ReadOnly = True
        '
        'VenIVA
        '
        Me.VenIVA.HeaderText = "Talla"
        Me.VenIVA.Name = "VenIVA"
        Me.VenIVA.ReadOnly = True
        '
        'VenTotal
        '
        Me.VenTotal.HeaderText = "Género"
        Me.VenTotal.Name = "VenTotal"
        Me.VenTotal.ReadOnly = True
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
        'GB_Opciones
        '
        Me.GB_Opciones.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GB_Opciones.Controls.Add(Me.BtnRegresar)
        Me.GB_Opciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Opciones.Location = New System.Drawing.Point(22, 436)
        Me.GB_Opciones.Name = "GB_Opciones"
        Me.GB_Opciones.Size = New System.Drawing.Size(1094, 84)
        Me.GB_Opciones.TabIndex = 110
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
        Me.BtnRegresar.Location = New System.Drawing.Point(510, 21)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(131, 38)
        Me.BtnRegresar.TabIndex = 78
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Con_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1142, 530)
        Me.Controls.Add(Me.GB_Opciones)
        Me.Controls.Add(Me.GB_Detalle)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Con_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Con_Detalle"
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Detalle.ResumeLayout(False)
        Me.GB_Detalle.PerformLayout()
        CType(Me.Dg_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Opciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents GB_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dg_Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Opciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents CBOpcionDetalle As System.Windows.Forms.ComboBox
    Friend WithEvents VenCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenFechaRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenEstacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenTipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
