Public Class DepartmentBL

    Function GetDepartmentsNames() As List(Of String)

        Dim department As New DepartmentDB
        Dim depList As New List(Of Department)
        Dim departmentNames As New List(Of String)
        depList = department.GetDepartments

        For Each name As Department In depList
            departmentNames.Add(name.Name.TrimEnd)
        Next
        Return departmentNames

    End Function

    Function GetDepartments() As List(Of Department)

        Dim department As New DepartmentDB

        Return department.GetDepartments()

    End Function


    Sub NewDepartments(ByVal name As String, ByVal description As String)

        Dim department As New DepartmentDB
        department.NewDepartment(name, description)


    End Sub

    Sub UpdateDepartment(ByVal id As Integer, ByVal name As String, ByVal description As String)

        Dim department As New DepartmentDB
        department.UpdateDepartment(id, name, description)

    End Sub

    Sub DeleteDepartment(ByVal id As Integer)

        Dim department As New DepartmentDB

        department.DeleteDepartment(id)

    End Sub

End Class
