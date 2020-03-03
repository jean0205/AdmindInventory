Imports System.Data.SqlClient

Public Class CategoryDB
    Dim conString As String = My.Settings.conString

    'Select all categories
    Function GetCategories() As List(Of Category)
        Dim categoryList As New List(Of Category)
        Dim query As String = "Select C.Id, RTRIM(C.Name), RTRIM(C.GL_Number), RTRIM(C.Description) from Category C"

        Using connection As New SqlConnection(conString)
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim category As New Category
                    category.Id = reader.GetInt32(0)
                    category.Name = reader.GetString(1)
                    category.GLnumber = reader.GetSqlString(2)
                    category.Description = reader.GetString(3)
                    categoryList.Add(category)
                End While

                reader.Close()
                connection.Close()

            Catch ex As Exception
                Throw ex
            End Try
        End Using
        Return categoryList
    End Function

    'Insert New Category
    Sub NewCategory(ByVal name As String, ByVal GLnumber As String, ByVal description As String)
        Dim query As String = "Insert INTO Category (Name, GL_Number, Description) values (@Name, @GL_Number, @Description)"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", SqlDbType.NChar).Value = name
                command.Parameters.AddWithValue("@GL_Number", SqlDbType.NChar).Value = GLnumber
                command.Parameters.AddWithValue("@Description", SqlDbType.NChar).Value = description
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                Catch ex As Exception
                    Throw ex
                End Try

            End Using

        End Using

    End Sub

    'Update Existing Categories
    Sub UpdateCategory(ByVal id As Integer, ByVal name As String, ByVal glnumber As String, ByVal description As String)
        Dim query As String = "Update Category Set Name= @Name, GL_Number=@GL_Number, Description= @Description Where Id=@Id "
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id
                command.Parameters.AddWithValue("@Name", SqlDbType.NChar).Value = name
                command.Parameters.AddWithValue("@GL_Number", SqlDbType.NChar).Value = glnumber
                command.Parameters.AddWithValue("@Description", SqlDbType.NChar).Value = description
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                Catch ex As Exception
                    Throw ex
                End Try

            End Using

        End Using

    End Sub

    'Delete Unnecessary categories
    Sub Deletecategory(ByVal id As Integer)
        Dim query As String = "Delete From Category Where Id=@Id "
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                Catch ex As Exception
                    Throw ex
                End Try
            End Using

        End Using
    End Sub

End Class


