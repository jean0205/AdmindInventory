Imports System.Data.SqlClient

Public Class ProviderDB
    Dim conString As String = My.Settings.conString
    'Gett providers view
    Function GetProviderList() As List(Of ProviderE)

        Dim providerList As New List(Of ProviderE)
        Dim query As String = "Select * from Provider"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        Dim provider As New ProviderE

                        provider.Id = reader.GetInt32(0)
                        provider.Name = reader.GetString(1)



                        If IsDBNull(reader.Item(2)) = False Then
                            provider.Address = reader.GetString(2)
                        End If

                        If IsDBNull(reader.Item(3)) = False Then
                            provider.Phone = reader.GetString(3)
                        End If

                        If IsDBNull(reader.Item(4)) = False Then
                            provider.Email = reader.GetString(4)
                        End If
                        If IsDBNull(reader.Item(5)) = False Then
                            provider.ContactPerson = reader.GetString(5)
                        End If
                        If IsDBNull(reader.Item(6)) = False Then
                            provider.Notes = reader.GetString(6)
                        End If
                        providerList.Add(provider)

                    End While

                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return providerList
    End Function

    'Insert New provider
    Sub InsertProvider(ByVal name As String, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal contactPerson As String, ByVal note As String)

        Dim query As String = "Insert INTO Provider (Name, Address, Phone, Email, Contact_Person, Notes) values (@Name, @Address, @Phone, @Email, @Contact_Person, @Notes)"
        Using Connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, Connection)

                command.Parameters.AddWithValue("@Name", SqlDbType.NChar).Value = name
                command.Parameters.AddWithValue("@Address", SqlDbType.NChar).Value = address
                command.Parameters.AddWithValue("@Phone", SqlDbType.NChar).Value = phone
                command.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email
                command.Parameters.AddWithValue("@Contact_Person", SqlDbType.NChar).Value = contactPerson
                command.Parameters.AddWithValue("@Notes", SqlDbType.NVarChar).Value = note

                Try
                    Connection.Open()
                    command.ExecuteNonQuery()
                    Connection.Close()
                Catch ex As Exception
                    Throw ex
                End Try
            End Using

        End Using



    End Sub
    'Udate providers
    Sub UpdateProvider(ByVal Id As Integer, ByVal name As String, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal contactPerson As String, ByVal note As String)

        Dim query As String = "Update Provider set Name= @Name, Address= @Address, Phone= @Phone, Email= @Email, Contact_Person= @Contact_Person, Notes= @Notes Where Id= @Id  "
        Using Connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, Connection)

                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Id
                command.Parameters.AddWithValue("@Name", SqlDbType.NChar).Value = name
                command.Parameters.AddWithValue("@Address", SqlDbType.NChar).Value = address
                command.Parameters.AddWithValue("@Phone", SqlDbType.NChar).Value = phone
                command.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email
                command.Parameters.AddWithValue("@Contact_Person", SqlDbType.NChar).Value = contactPerson
                command.Parameters.AddWithValue("@Notes", SqlDbType.NVarChar).Value = note

                Try
                    Connection.Open()
                    command.ExecuteNonQuery()
                    Connection.Close()
                Catch ex As Exception
                    Throw ex
                End Try
            End Using

        End Using


    End Sub

    'delete providers
    Sub DeleteProvider(ByVal id As Integer)
        Dim query As String = "Delete From Provider Where Id=@Id "
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


    Function GetProviderByName(ByVal providerName As String) As List(Of ProviderE)
        Dim providerList As New List(Of ProviderE)

        Dim query As String = "select * from Provider where Name Like '" & providerName & "%'"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        Dim provider As New ProviderE

                        provider.Id = reader.GetInt32(0)
                        provider.Name = reader.GetString(1)



                        If IsDBNull(reader.Item(2)) = False Then
                            provider.Address = reader.GetString(2)
                        End If

                        If IsDBNull(reader.Item(3)) = False Then
                            provider.Phone = reader.GetString(3)
                        End If

                        If IsDBNull(reader.Item(4)) = False Then
                            provider.Email = reader.GetString(4)
                        End If
                        If IsDBNull(reader.Item(5)) = False Then
                            provider.ContactPerson = reader.GetString(5)
                        End If
                        If IsDBNull(reader.Item(6)) = False Then
                            provider.Notes = reader.GetString(6)
                        End If
                        providerList.Add(provider)

                    End While

                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return providerList
    End Function
    'Get providers name

    Function GetProviderNames() As List(Of ProviderE)

        Dim providerList As New List(Of ProviderE)
        Dim query As String = "Select Name from Provider"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        Dim provider As New ProviderE


                        provider.Name = reader.GetString(1)



                        providerList.Add(provider)

                    End While

                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return providerList
    End Function
End Class
