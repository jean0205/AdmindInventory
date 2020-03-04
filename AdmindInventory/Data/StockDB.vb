﻿Imports System.Data.SqlClient

Public Class StockDB

    Dim conString As String = My.Settings.conString
    'Gett stock view
    Function GetStockList() As List(Of Stock)

        Dim stockList As New List(Of Stock)
        Dim query As String = "Select * from StockView"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        Dim stock As New Stock
                        'stock.Id = reader.GetInt32(0)
                        stock.ItemId = reader.GetInt32(0)
                        stock.ItemName = reader.GetString(1)
                        stock.ItemCategory = reader.GetString(2)
                        stock.ItemPresentation = reader.GetString(3)
                        stock.ItemReorder = reader.GetInt32(4)
                        stock.StockRemains = reader.GetInt32(5)
                        stock.TotalCost = reader.GetDecimal(6)
                        stockList.Add(stock)
                    End While

                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return stockList
    End Function

    'get stock filterin by category
    Function GetStockListByCat(ByVal catName As String) As List(Of Stock)

        Dim stockList As New List(Of Stock)
        Dim query As String = "select * from StockView where Cat_Name=@CatName"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@CatName", SqlDbType.NChar).Value = catName
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        Dim stock As New Stock
                        'stock.Id = reader.GetInt32(0)
                        stock.ItemId = reader.GetInt32(0)
                        stock.ItemName = reader.GetString(1)
                        stock.ItemCategory = reader.GetString(2)
                        stock.ItemPresentation = reader.GetString(3)
                        stock.ItemReorder = reader.GetInt32(4)
                        stock.StockRemains = reader.GetInt32(5)
                        stock.TotalCost = reader.GetDecimal(6)
                        stockList.Add(stock)
                    End While

                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return stockList
    End Function

    'get stock filtering by name
    Function GetStockByName(ByVal ItemName As String) As List(Of Stock)
        Dim stockList As New List(Of Stock)
        Dim query As String = "select * from StockView where Item_Name Like '" & ItemName & "%'"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                'command.Parameters.Add("@Item_name", SqlDbType.NChar).Value = ItemName
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        Dim stock As New Stock
                        'stock.Id = reader.GetInt32(0)
                        stock.ItemId = reader.GetInt32(0)
                        stock.ItemName = reader.GetString(1)
                        stock.ItemCategory = reader.GetString(2)
                        stock.ItemPresentation = reader.GetString(3)
                        stock.ItemReorder = reader.GetInt32(4)
                        stock.StockRemains = reader.GetInt32(5)
                        stock.TotalCost = reader.GetDecimal(6)
                        stockList.Add(stock)
                    End While

                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return stockList
    End Function

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


End Class
