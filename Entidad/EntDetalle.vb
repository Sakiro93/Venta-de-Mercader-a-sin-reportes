Public Class EntDetalle
    Private detID As Integer
    Private detCalID As Integer
    Private detCantidad As Integer
    Private detPrecio As Double
    Sub New()
        Me.detID = 0
        Me.detCalID = 0
        Me.detCantidad = 0
        Me.detPrecio = 0
    End Sub

    Sub New(ByVal detID As Integer, ByVal detCalID As Integer, ByVal detCantidad As Integer, ByVal detPrecio As Double)
        Me.detID = detID
        Me.detCalID = detCalID
        Me.detCantidad = detCantidad
        Me.detPrecio = detPrecio
    End Sub
    Public Property det_ID() As Integer
        Get
            Return Me.detID
        End Get
        Set(ByVal value As Integer)
            Me.detID = value
        End Set
    End Property
    Public Property det_CalID() As Integer
        Get
            Return Me.detCalID
        End Get
        Set(ByVal value As Integer)
            Me.detCalID = value
        End Set
    End Property
    Public Property det_Cantidad() As Integer
        Get
            Return Me.detCantidad
        End Get
        Set(ByVal value As Integer)
            Me.detCantidad = value
        End Set
    End Property
    Public Property det_Precio() As Double
        Get
            Return Me.detPrecio
        End Get
        Set(ByVal value As Double)
            Me.detPrecio = value
        End Set
    End Property
End Class
