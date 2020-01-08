Public Class EntCategoria
    Private catID As Integer
    Private catDescripcion As String
    Sub New()
        Me.catID = 0
        Me.catDescripcion = ""
    End Sub

    Sub New(ByVal catID As Integer, ByVal catDescripcion As String)
        Me.catID = catID
        Me.catDescripcion = catDescripcion
    End Sub

    Public Property cat_ID() As Integer
        Get
            Return Me.catID
        End Get
        Set(ByVal value As Integer)
            Me.catID = value
        End Set
    End Property

    Public Property cat_Descripcion() As String
        Get
            Return Me.catDescripcion
        End Get
        Set(ByVal value As String)
            Me.catDescripcion = value
        End Set
    End Property
End Class
