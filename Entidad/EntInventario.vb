Public Class EntInventario
    Private invID As Integer
    Private invProID As Integer
    Private invCalID As Integer
    Private invFRegistro As Date
    Private invCantidad As Integer
    Private invComentario As String
    Sub New()
        Me.invID = 0
        Me.invProID = 0
        Me.invCalID = 0
        Me.invFRegistro = Date.Now
        Me.invCantidad = 0
        Me.invComentario = ""
    End Sub
    Sub New(ByVal invID As Integer, ByVal invProID As Integer, ByVal invCalID As Integer, ByVal invFRegistro As Date,
            ByVal invCantidad As Integer, ByVal invComentario As String)
        Me.invID = invID
        Me.invProID = invProID
        Me.invCalID = invCalID
        Me.invFRegistro = invFRegistro
        Me.invCantidad = invCantidad
        Me.invComentario = invComentario
    End Sub

    Public Property inv_ID() As Integer
        Get
            Return Me.invID
        End Get
        Set(ByVal value As Integer)
            Me.invID = value
        End Set
    End Property

    Public Property inv_ProID() As Integer
        Get
            Return Me.invProID
        End Get
        Set(ByVal value As Integer)
            Me.invProID = value
        End Set
    End Property

    Public Property inv_CalID() As Integer
        Get
            Return Me.invCalID
        End Get
        Set(ByVal value As Integer)
            Me.invCalID = value
        End Set
    End Property

    Public Property inv_FRegistro() As Date
        Get
            Return Me.invFRegistro
        End Get
        Set(ByVal value As Date)
            Me.invFRegistro = value
        End Set
    End Property

    Public Property inv_Cantidad() As Integer
        Get
            Return Me.invCantidad
        End Get
        Set(ByVal value As Integer)
            Me.invCantidad = value
        End Set
    End Property

    Public Property inv_Comentario() As String
        Get
            Return Me.invComentario
        End Get
        Set(ByVal value As String)
            Me.invComentario = value
        End Set
    End Property

End Class
