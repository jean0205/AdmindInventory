﻿Imports System.Data.SqlClient

Public Class ItemDB
    Dim conString As String = My.Settings.conString
    'Get item list
    Function GetItems() As List(Of Item)
        Dim itemsList As New List(Of Item)
        Dim query As String = "Select I.Id,I.Name, I.Presentation, I.Description,I.Reorder, C.Name from Item I
                                Inner Join Category C on C.Id=I.Category_Id"

        Using connection As New SqlConnection(conString)
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim item As New Item

                    item.Id = reader.GetInt32(0)
                    item.Name = reader.GetString(1)
                    item.Presentation = reader.GetString(2)
                    item.Description = reader.GetString(3)
                    item.Reorder = reader.GetInt32(4)
                    item.Category_Name = reader.GetString(5)

                    itemsList.Add(item)
                End While

                reader.Close()
                connection.Close()

            Catch ex As Exception
                Throw ex
            End Try
        End Using
        Return itemsList
    End Function

    'Get item list by category
    Function GetItemsByCat(ByVal id As Integer) As List(Of Item)
        Dim itemsList As New List(Of Item)
        Dim query As String = "Select I.Id, I.Name, I.Presentation, I.Description, I.Reorder, C.Name from Item I
                                Inner Join Category C on C.Id=I.Category_Id
                                where I.Category_Id=@Id"

        Using connection As New SqlConnection(conString)


            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id

                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim item As New Item

                        item.Id = reader.GetInt32(0)
                        item.Name = reader.GetString(1)
                        item.Presentation = reader.GetString(2)
                        item.Description = reader.GetString(3)
                        item.Reorder = reader.GetInt32(4)
                        item.Category_Name = reader.GetString(5)

                        itemsList.Add(item)
                    End While

                    reader.Close()
                    connection.Close()

                Catch ex As Exception
                    Throw ex
                End Try
            End Using
        End Using
        Return itemsList
    End Function

    'Insert Item
    Sub NewItem(ByVal name As String, ByVal presentation As String, ByVal description As String, ByVal reorder As Integer, ByVal categoryId As Integer)

        Dim query As String = "Insert INTO Item (Name, Presentation, Description, Reorder, Category_Id) values (@Name, @Presentation, @Description, @Reorder, @Category_Id)"
        Using Connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, Connection)
                'command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id
                command.Parameters.AddWithValue("@Name", SqlDbType.Int).Value = name
                command.Parameters.AddWithValue("@Presentation", SqlDbType.Int).Value = presentation
                command.Parameters.AddWithValue("@Description", SqlDbType.Int).Value = description
                command.Parameters.AddWithValue("@Reorder", SqlDbType.Int).Value = reorder
                command.Parameters.AddWithValue("@Category_Id", SqlDbType.Int).Value = categoryId

                Try
                    Connection.Open()
                    command.ExecuteNonQuery()
                    Connection.Close()
                Catch ex As Exception

                End Try
            End Using

        End Using



    End Sub

    'Update Item
    Sub UpdateItem(ByVal id As Integer, ByVal name As String, ByVal presentation As String, ByVal description As String, ByVal reorder As Integer, ByVal categoryId As Integer)

        Dim query As String = "Update Item set Name= @Name, Presentation= @Presentation, Description= @Description, Reorder= @Reorder, Category_Id= @Category_Id) where Id= @Id"
        Using Connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, Connection)
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id
                command.Parameters.AddWithValue("@Name", SqlDbType.Int).Value = name
                command.Parameters.AddWithValue("@Presentation", SqlDbType.Int).Value = presentation
                command.Parameters.AddWithValue("@Description", SqlDbType.Int).Value = description
                command.Parameters.AddWithValue("@Reorder", SqlDbType.Int).Value = reorder
                command.Parameters.AddWithValue("@Category_Id", SqlDbType.Int).Value = categoryId

                Try
                    Connection.Open()
                    command.ExecuteNonQuery()
                    Connection.Close()
                Catch ex As Exception

                End Try
            End Using

        End Using



    End Sub

    'Delete Item
    Sub DeleteItem(ByVal id As Integer)
        Dim query As String = "Delete From Item Where Id=@Id "
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