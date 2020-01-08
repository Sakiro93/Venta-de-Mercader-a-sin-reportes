Public Class EntColor
    Private colID As Integer
    Private colNombre As String
    Sub New()
        Me.colID = 0
        Me.colNombre = ""
    End Sub

    Sub New(ByVal colID As Integer, ByVal colNombre As String)
        Me.colID = colID
        Me.colNombre = colNombre
    End Sub

    Public Property col_ID() As Integer
        Get
            Return Me.colID
        End Get
        Set(ByVal value As Integer)
            Me.colID = value
        End Set
    End Property

    Public Property col_Nombre() As String
        Get
            Return Me.colNombre
        End Get
        Set(ByVal value As String)
            Me.colNombre = value
        End Set
    End Property
End Class
