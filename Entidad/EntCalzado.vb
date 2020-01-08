Public Class EntCalzado
    Private calID As Integer
    Private calNombre As String
    Private calCatID As Integer
    Private calTalID As Integer
    Private calColID As Integer
    Private calGenero As Boolean
    Private calPrecio As Double
    Private calStock As Integer
    Sub New()
        Me.calID = 0
        Me.calNombre = ""
        Me.calCatID = 0
        Me.calTalID = 0
        Me.calColID = 0
        Me.calGenero = 0
        Me.calPrecio = 0
        Me.calStock = 0
    End Sub
    Sub New(ByVal calID As Integer, ByVal calNombre As String, ByVal calCatID As Integer, ByVal calTalID As Integer, ByVal calColID As Integer,
            ByVal calGenero As Boolean, ByVal calPrecio As Double, ByVal calStock As Integer)
        Me.calID = calID
        Me.calCatID = calCatID
        Me.calTalID = calTalID
        Me.calColID = calColID
        Me.calNombre = calNombre
        Me.calGenero = calGenero
        Me.calPrecio = calPrecio
        Me.calStock = calStock
    End Sub

    Public Property cal_ID() As Integer
        Get
            Return Me.calID
        End Get
        Set(ByVal value As Integer)
            Me.calID = value
        End Set
    End Property
    Public Property cal_CatID() As Integer
        Get
            Return Me.calCatID
        End Get
        Set(ByVal value As Integer)
            Me.calCatID = value
        End Set
    End Property
    Public Property cal_TalID() As Integer
        Get
            Return Me.calTalID
        End Get
        Set(ByVal value As Integer)
            Me.calTalID = value
        End Set
    End Property
    Public Property cal_ColID() As Integer
        Get
            Return Me.calColID
        End Get
        Set(ByVal value As Integer)
            Me.calColID = value
        End Set
    End Property
    Public Property cal_Nombre() As String
        Get
            Return Me.calNombre
        End Get
        Set(ByVal value As String)
            Me.calNombre = value
        End Set
    End Property
    Public Property cal_Genero() As Boolean
        Get
            Return Me.calGenero
        End Get
        Set(ByVal value As Boolean)
            Me.calGenero = value
        End Set
    End Property

    Public Property cal_Precio() As Double
        Get
            Return Me.calPrecio
        End Get
        Set(ByVal value As Double)
            Me.calPrecio = value
        End Set
    End Property

    Public Property cal_Stock() As Integer
        Get
            Return Me.calStock
        End Get
        Set(ByVal value As Integer)
            Me.calStock = value
        End Set
    End Property
End Class
