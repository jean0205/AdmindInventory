Imports System.Data.SqlClient

Public Class DepartmentDB
    Dim conString As String = My.Settings.conString

    'Select all departments
    Function GetDepartments() As List(Of Department)
        Dim departmentList As New List(Of Department)
        Dim query As String = "Select D.Id, RTRIM(D.Name), RTRIM(D.Description) from Department D"

        Using connection As New SqlConnection(conString)
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim department As New Department
                    department.Id = reader.GetInt32(0)
                    department.Name = reader.GetString(1)
                    department.Description = reader.GetString(2)
                    departmentList.Add(department)
                End While

                reader.Close()
                connection.Close()

            Catch ex As Exception
                Throw ex
            End Try
        End Using
        Return departmentList
    End Function

    'Insert New department
    Sub NewCategory(ByVal id As Integer, ByVal name As String, ByVal description As String)
        Dim query As String = "Insert INTO Department (Id, Name, Description) values (@Id, @Name, @Description)"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id
                command.Parameters.AddWithValue("@Id", SqlDbType.NChar).Value = name
                command.Parameters.AddWithValue("@Id", SqlDbType.NChar).Value = description
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                Catch ex As Exception

                End Try
            End Using

        End Using

    End Sub

    'Update Existing Departments
    Sub UpdateCategory(ByVal id As Integer, ByVal name As String, ByVal description As String)
        Dim query As String = "Update Department Set Name= @Name, Description= @Description Where Id=@Id "
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id
                command.Parameters.AddWithValue("@Id", SqlDbType.NChar).Value = name
                command.Parameters.AddWithValue("@Id", SqlDbType.NChar).Value = description
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                Catch ex As Exception

                End Try
            End Using

        End Using

    End Sub

    'Delete Unnecessary departments
    Sub Deletecategory(ByVal id As Integer)
        Dim query As String = "Delete From Department Where Id=@Id "
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                Catch ex As Exception

                End Try
            End Using

        End Using
    End Sub

End Class
