﻿Imports System.Data.SqlClient

Public Class StockDB

    Dim conString As String = My.Settings.conString
    'Gett stock view
    Function GetStockList() As DataTable
        Dim table As New DataTable

        Dim query As String = "Select * from StockViewState"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                'command.Parameters.Add("@Item_name", SqlDbType.varchar).Value = ItemName
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
        End Using
        Return table
    End Function

    'Function GetStockList() As List(Of Stock)

    '    Dim stockList As New List(Of Stock)
    '    Dim query As String = "Select * from StockViewState"
    '    Using connection As New SqlConnection(conString)
    '        Using command As New SqlCommand(query, connection)
    '            Try
    '                connection.Open()
    '                Dim reader As SqlDataReader = command.ExecuteReader()
    '                While reader.Read
    '                    Dim stock As New Stock
    '                    'stock.Id = reader.GetInt32(0)
    '                    stock.ItemId = reader.GetInt32(0)
    '                    stock.Item = reader.GetString(1)
    '                    stock.Category = reader.GetString(2)
    '                    stock.Attribute = reader.GetString(3)
    '                    stock.Reorder = reader.GetInt32(4)
    '                    stock.InStock = reader.GetInt32(5)
    '                    stock.Active = reader.GetBoolean(6)
    '                    stock.Expenses = reader.GetDecimal(7)
    '                    stockList.Add(stock)
    '                End While

    '            Catch ex As Exception
    '                Throw ex

    '            End Try

    '        End Using
    '    End Using
    '    Return stockList
    'End Function

    'get stock filterin by category

    Function GetStockListByCat(ByVal catName As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockViewState where Category=@CatName"

        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@CatName", SqlDbType.VarChar).Value = catName
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
        End Using
        Return table

    End Function

    Function GetStockByName(ByVal ItemName As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockViewState where Item Like '" & ItemName & "%'"

        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                'command.Parameters.Add("@CatName", SqlDbType.VarChar).Value = ItemName
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
        End Using
        Return table

    End Function

    'get stock filtering by name
    'Function GetStockByName(ByVal ItemName As String) As List(Of Stock)
    '    Dim stockList As New List(Of Stock)
    '    Dim query As String = "select * from StockViewState where Item_Name Like '" & ItemName & "%'"
    '    Using connection As New SqlConnection(conString)
    '        Using command As New SqlCommand(query, connection)
    '            'command.Parameters.Add("@Item_name", SqlDbType.varchar).Value = ItemName
    '            Try
    '                connection.Open()
    '                Dim reader As SqlDataReader = command.ExecuteReader()
    '                While reader.Read
    '                    Dim stock As New Stock
    '                    'stock.Id = reader.GetInt32(0)
    '                    stock.ItemId = reader.GetInt32(0)
    '                    stock.Item = reader.GetString(1)
    '                    stock.Category = reader.GetString(2)
    '                    stock.Attribute = reader.GetString(3)
    '                    stock.Reorder = reader.GetInt32(4)
    '                    stock.InStock = reader.GetInt32(5)
    '                    stock.Active = reader.GetBoolean(6)
    '                    stock.Expenses = reader.GetDecimal(7)
    '                    stockList.Add(stock)
    '                End While

    '            Catch ex As Exception
    '                Throw ex

    '            End Try

    '        End Using
    '    End Using
    '    Return stockList
    'End Function

    'Insert Item to stock automatically after created
    Sub InsertItemToStock(ByVal itemId As Integer)

        Dim query As String = "Insert INTO Stock (Item_id, Stock, TotalCost) values (@Item_id, @Stock, @TotalCost)"
        Using Connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, Connection)
                command.Parameters.AddWithValue("@Item_id", SqlDbType.Int).Value = itemId
                command.Parameters.AddWithValue("@Stock", SqlDbType.Int).Value = 0
                command.Parameters.AddWithValue("@TotalCost", SqlDbType.Int).Value = 0.00


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

    'Update stock remains

    Sub UpdateStock(ByVal itemId As Integer, stockAmount As Integer)

        Dim query As String = "Update Stock Set Stock+=@Stock Where Item_id=@Id"
        Using Connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, Connection)
                command.Parameters.AddWithValue("@Stock", SqlDbType.Int).Value = stockAmount
                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = itemId

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


    'Delete Item from stock when is inactive
    Sub DeleteItemInactive(ByVal id As Integer)
        Dim query As String = "Delete From Stock Where Item_id=@Id "
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

    Function GetStockToOrder() As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockViewState where Reorder>=Stock"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                'command.Parameters.Add("@Item_name", SqlDbType.varchar).Value = ItemName
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
        End Using
        Return table
    End Function

    Function GetStockById(id As Integer) As Integer
        Dim stock As Integer

        Dim query As String = "select s.stock from Stock s where Item_id=@Id"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        stock = reader.GetInt32(0)
                    End While



                    reader.Close()
                    connection.Close()
                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return Stock
    End Function

    'get stock item id
    Function GetStockItemId() As List(Of Integer)

        Dim IdList As New List(Of Integer)


        Dim query As String = "select s.Item_id from Stock s "
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)

                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        IdList.Add(reader.GetInt32(0))
                    End While



                    reader.Close()
                    connection.Close()
                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return IdList
    End Function
End Class
