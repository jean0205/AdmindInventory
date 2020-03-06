﻿Imports System.Data.SqlClient

Public Class StockOutDB
    Dim conString As String = My.Settings.conString

    Sub InsertStockOut(ByVal itemId As Integer, ByVal departmentName As String,
                         ByVal amount As Integer, ByVal dateOut As Date, ByVal person As String, ByVal condition As Integer, ByVal requested As Boolean)


        Dim query As String = "insert into StockDistribution (Item_Id, Departrment_Id, Amount, Date,Person,Condition,Requested )
                                     Values( @Item_Id,(select D.Id from Department D Where d.Name= @Depart_Name), @Amount, @Date, @Person, @Condition, @Requested)"


        Using Connection As New SqlConnection(conString)

            Using command As New SqlCommand(query, Connection)

                command.Parameters.AddWithValue("@Item_Id", SqlDbType.Int).Value = itemId
                command.Parameters.AddWithValue("@Depart_Name", SqlDbType.NChar).Value = departmentName
                command.Parameters.AddWithValue("@Amount", SqlDbType.Int).Value = amount
                command.Parameters.AddWithValue("@Date", SqlDbType.Date).Value = dateOut
                command.Parameters.AddWithValue("@Person", SqlDbType.NChar).Value = person
                command.Parameters.AddWithValue("@Condition", SqlDbType.Int).Value = condition
                command.Parameters.AddWithValue("@Requested", SqlDbType.Bit).Value = requested


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

    Sub UpdateRequestState(ByVal requestid As Integer, ByVal condition As Integer)


        Dim query As String = "update StockDistribution set Condition= @Condition where Id=@Id"


        Using Connection As New SqlConnection(conString)

            Using command As New SqlCommand(query, Connection)

                command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = requestid
                command.Parameters.AddWithValue("@Condition", SqlDbType.Int).Value = condition


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
    'all records'
    Function GetStockOutHystory() As DataTable

        Dim query As String = "select * from StockOutView"
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

    'Filter by name
    Function FilterStockOutByName(ByVal ItemName As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockOutView where Item_Name Like '" & ItemName & "%'"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                'command.Parameters.Add("@Item_name", SqlDbType.NChar).Value = ItemName
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

    'filter by category
    Function FilterStockOutByCategory(ByVal category As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select *from StockOutView where Category=@Category "
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@Category", SqlDbType.NChar).Value = category
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
    'filter by department
    Function FilterStockOutByDepartment(ByVal department As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockOutView where Department=@Department"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@Department", SqlDbType.NChar).Value = department
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

    '

    'filter by date 

    Function FilterStockHistoryByDate(ByVal date1 As Date, ByVal date2 As Date) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockOutView where Date between Cast(@Date1 As Date) and Cast(@Date2 As Date)"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@Date1", SqlDbType.Date).Value = date1
                command.Parameters.Add("@Date2", SqlDbType.Date).Value = date2
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


    'only the pendin request'
    Function GetStockRequest() As DataTable

        Dim query As String = "
                                select so.Id, so.[Item Id], so.[Item Name],so.Category, so.Department, so.Date, so.Person,SO.Amount, s.Stock from StockOutView3 SO
                                full join Stock S on s.Item_id= so.[Item Id]								
                                where so.State='Pending   '"
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



    'Function GetStockRequest() As DataTable

    '    Dim query As String = "
    '                            select so.[Item Id], so.[Item Name],so.Category, so.Department, so.Date, so.Person,SO.Amount, s.Stock from StockOutView2 SO
    '                            full join Stock S on s.Item_id= so.[Item Id]								
    '                            where so.State='Pending   '"
    '    Dim table As New DataTable

    '    Using connection As New SqlConnection(conString)
    '        Dim command As New SqlCommand(query, connection)

    '        Try
    '            connection.Open()
    '            Dim reader As SqlDataReader = command.ExecuteReader()
    '            table.Load(reader)


    '            reader.Close()
    '            connection.Close()

    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Using
    '    Return table

    'End Function

End Class