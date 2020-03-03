Public Class CategoryBL


    Function GetCategoriesNames() As List(Of String)

        Dim category As New CategoryDB
        Dim catList As New List(Of Category)
        Dim categoryNames As New List(Of String)
        catList = category.GetCategories()

        For Each name As Category In catList
            categoryNames.Add(name.Name.TrimEnd)
        Next
        Return categoryNames

    End Function

    Function GetCategories() As List(Of Category)

        Dim category As New CategoryDB

        Return category.GetCategories()

    End Function


    Sub NewCategory(ByVal name As String, ByVal GLnumber As String, ByVal description As String)
        Dim category As New CategoryDB
        category.NewCategory(name, GLnumber, description)

    End Sub

    Sub UpdateCategory(ByVal id As Integer, ByVal name As String, ByVal GLnumber As String, ByVal description As String)

        Dim category As New CategoryDB
        category.UpdateCategory(id, name, GLnumber, description)

    End Sub

    Sub DeleteCategory(ByVal id As Integer)

        Dim category As New CategoryDB

        category.Deletecategory(id)

    End Sub

End Class
