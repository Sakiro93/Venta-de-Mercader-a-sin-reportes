Public Class EntVenta
        Private venID As Integer
        Private venCliID As Integer
        Private venFRegistro As Date
        Private venSubTotal As Double
        Private venIVA As Double
        Private venTotal As Double
        Sub New()
            Me.venID = 0
            Me.venCliID = 0
            Me.venFRegistro = Date.Now
            Me.venSubTotal = 0
            Me.venIVA = 0
            Me.venTotal = 0
        End Sub
        Sub New(ByVal venID As Integer, ByVal venCliID As Integer, ByVal venFRegistro As Date, ByVal venSubTotal As Double, ByVal venIVA As Double, ByVal venTotal As Double)
            Me.venID = venID
            Me.venCliID = venCliID
            Me.venFRegistro = venFRegistro
        Me.venSubTotal = venSubTotal
            Me.venIVA = venIVA
        Me.venTotal = venTotal
        End Sub
        Public Property ven_ID() As Integer
            Get
                Return Me.venID
            End Get
            Set(ByVal value As Integer)
                Me.venID = value
            End Set
        End Property
        Public Property ven_CliID() As Integer
            Get
                Return Me.venCliID
            End Get
            Set(ByVal value As Integer)
                Me.venCliID = value
            End Set
    End Property
        Public Property ven_FRegistro() As Date
            Get
                Return Me.venFRegistro
            End Get
            Set(ByVal value As Date)
                Me.venFRegistro = value
            End Set
    End Property
        Public Property ven_SubTotal() As Double
            Get
                Return Me.venSubTotal
            End Get
            Set(ByVal value As Double)
                Me.venSubTotal = value
            End Set
    End Property

    Public Property ven_IVA() As Double
        Get
            Return Me.venIVA
        End Get
        Set(ByVal value As Double)
            Me.venIVA = value
        End Set
    End Property
        Public Property ven_Total() As Double
            Get
                Return Me.venTotal
            End Get
            Set(ByVal value As Double)
                Me.venTotal = value
            End Set
    End Property
End Class
