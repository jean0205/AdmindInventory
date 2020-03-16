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
                command.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = name
                command.Parameters.AddWithValue("@GL_Number", SqlDbType.VarChar).Value = GLnumber
                command.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = description
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
                command.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = name
                command.Parameters.AddWithValue("@GL_Number", SqlDbType.VarChar).Value = glnumber
                command.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = description
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


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''category budget
    '''
    Function GetbudgetTable() As DataTable

        Dim query As String = "select B.id, C.Name As " & "Category" & ", B.Year, B.Budget, B.Expenses, B.in_Budget As " & "Available" & " from Budget B
                            inner join Category C on B.Category_Id= c.Id"
        Dim table As New DataTable

        Using connection As New SqlConnection(conString)
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                table.Load(reader)


                reader.Close()
                connection.Close()

            Catch ex As Exception
                Throw ex
            End Try
        End Using
        Return table

    End Function

    Function getBudgetByCategory(ByVal category As String) As DataTable

        Dim query As String = "select B.id, C.Name As " & "Category" & ", B.Year, B.Budget, B.Expenses, B.in_Budget As " & "Available" & " from Budget B
                                    inner join Category C on B.Category_Id= c.Id where Category_Id=(select Id from Category where Name=@Category_Id ) and Year = YEAR(GETDATE())"
        Dim table As New DataTable

        Using connection As New SqlConnection(conString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Category_Id", SqlDbType.VarChar).Value = category
            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                table.Load(reader)


                reader.Close()
                connection.Close()

            Catch ex As Exception
                Throw ex
            End Try
        End Using
        Return table

    End Function



    Sub InsertBudget(ByVal categoryName As String, ByVal budget As Decimal)
        Dim query As String = "Insert INTO Budget (Category_Id, Year, Budget, Expenses) values ((select Id from Category where Name=@Category_Id ),YEAR(GETDATE()), @Budget, @Expenses)"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Category_Id", SqlDbType.Int).Value = categoryName
                ' command.Parameters.AddWithValue("@Year", SqlDbType.Int).Value = year
                command.Parameters.AddWithValue("@Budget", SqlDbType.Decimal).Value = budget
                command.Parameters.AddWithValue("@Expenses", SqlDbType.Decimal).Value = 0.00
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


    Sub UpdateBudget(ByVal id As Integer, ByVal budget As Decimal)
        Dim query As String = "Update  Budget set  Budget=@Budget where Id=@Id"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id
                command.Parameters.AddWithValue("@Budget", SqlDbType.Decimal).Value = budget


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


    Sub updateBudgetExpenses(ByVal expense As Decimal, ByVal categoryName As String)
        Dim query As String = "UPDATE Budget  SET  Expenses += @Expense WHERE Year = YEAR(GETDATE()) and Category_Id=(select Id from Category where Name=@CategoryName) "
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CategoryName", SqlDbType.VarChar).Value = categoryName

                command.Parameters.AddWithValue("@Expense", SqlDbType.Decimal).Value = expense

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

    Sub DeleteBudget(ByVal id As Decimal)
        Dim query As String = "Delete from Budget where Id=@Id "
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


