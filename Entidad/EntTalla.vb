Public Class EntTalla
    Private talID As Integer
    Private talNombre As String
    Sub New()
        Me.talID = 0
        Me.talNombre = ""
    End Sub

    Sub New(ByVal talID As Integer, ByVal talNombre As String)
        Me.talID = talID
        Me.talNombre = talNombre
    End Sub

    Public Property tal_ID() As Integer
        Get
            Return Me.talID
        End Get
        Set(ByVal value As Integer)
            Me.talID = value
        End Set
    End Property

    Public Property tal_Nombre() As String
        Get
            Return Me.talNombre
        End Get
        Set(ByVal value As String)
            Me.talNombre = value
        End Set
    End Property
End Class
