Public Class ItemBL
    Dim category As New CategoryDB
    Dim item As New ItemDB


    Function CategoryList() As List(Of Category)
        Dim list As New List(Of String)
    End Function


    Sub ChangeItemState(ByVal id As Integer)
        Dim item As New ItemDB
        item.ChangeItemState(id)
    End Sub

End Class
