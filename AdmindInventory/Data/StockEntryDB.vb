Imports System.Data.SqlClient

Public Class StockEntryDB

    Dim conString As String = My.Settings.conString
    'Gett stock view
    'Function GetStockEntryList() As List(Of StockEntry)

    '    Dim stockList As New List(Of StockEntry)
    '    Dim query As String = "Select * from StockEntry order by Id desc"
    '    Using connection As New SqlConnection(conString)
    '        Using command As New SqlCommand(query, connection)
    '            Try
    '                connection.Open()
    '                Dim reader As SqlDataReader = command.ExecuteReader()
    '                While reader.Read
    '                    Dim stockentry As New StockEntry

    '                    stockentry.Id = reader.GetInt32(0)
    '                    stockentry.Item_Id = reader.GetInt32(1)
    '                    stockentry.InvoiceNo = reader.GetString(2)
    '                    stockentry.Provider = reader.GetInt32(3)
    '                    stockentry.Amount = reader.GetInt32(4)
    '                    stockentry.CostEach = reader.GetDecimal(5)
    '                    stockentry.CostTotal = reader.GetDecimal(6)
    '                    stockentry.Recived = reader.GetString(7)
    '                    stockentry.DateReciv = reader.GetDateTime(8)


    '                    stockList.Add(stockentry)
    '                End While

    '            Catch ex As Exception
    '                Throw ex

    '            End Try

    '        End Using
    '    End Using
    '    Return stockList
    'End Function

    'filter by Item Name in stockHistoryView

    Function FilterStockHistoryByName(ByVal ItemName As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where Name Like '" & ItemName & "%' order by Id desc"
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

    'filter by invoice #

    Function FilterStockHistoryByInvoice(ByVal invoice As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where InvoiceNo Like '" & invoice & "%' order by Id desc"
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

    'Filter by provider
    Function FilterStockHistoryByProvider(ByVal provider As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where Provider Like '" & provider & "%' order by Id desc"
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

    'Filter stock entry by date range

    Function FilterStockHistoryByDate(ByVal date1 As Date, ByVal date2 As Date) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where Date between Cast(@Date1 As Date) and Cast(@Date2 As Date) order by Id desc"
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


    'Filter by category

    Function FilterStockHistoryCategory(category As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where Category=@Category order by Id desc"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@Category", SqlDbType.VarChar).Value = category

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

    'Filter by category and date

    Function FilterStockHistoryCategoryAndDate(ByVal date1 As Date, ByVal date2 As Date, category As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where Date between Cast(@Date1 As Date) and Cast(@Date2 As Date) and Category=@Category order by Id desc"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.Add("@Date1", SqlDbType.Date).Value = date1
                command.Parameters.Add("@Date2", SqlDbType.Date).Value = date2
                command.Parameters.Add("@Category", SqlDbType.VarChar).Value = category

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


    'Filter by item  and date

    Function FilterStockHistoryItemAndDate(ByVal date1 As Date, ByVal date2 As Date, item As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where Date between Cast(@Date1 As Date) and Cast(@Date2 As Date) and Name=@Name order by Id desc"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.Add("@Date1", SqlDbType.Date).Value = date1
                command.Parameters.Add("@Date2", SqlDbType.Date).Value = date2
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = item

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

    'get stock hystory view
    Function GetStockEntryHistory() As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory order by Id desc"
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

    Sub InsertStockEntry(ByVal itemId As Integer, ByVal invoiceNo As String, ByVal providerId As String,
                         ByVal amount As Integer, ByVal costEach As Decimal, ByVal costTotal As Decimal,
                         ByVal recived As String, ByVal daterecived As Date)


        Dim query As String = "Insert INTO StockEntry (Item_Id, InvoiceNo, Provider_Id, Amount, CostEach, CostTotal,
                                Recived, Date) values (@Item_Id, @InvoiceNo, (Select Id from Provider where Name=@Provider_Id), @Amount, @CostEach, @CostTotal, @Recived, @Date)"


        Using Connection As New SqlConnection(conString)

            Using command As New SqlCommand(query, Connection)

                command.Parameters.AddWithValue("@Item_Id", SqlDbType.Int).Value = itemId
                command.Parameters.AddWithValue("@InvoiceNo", SqlDbType.VarChar).Value = invoiceNo
                command.Parameters.AddWithValue("@Provider_Id", SqlDbType.VarChar).Value = providerId
                command.Parameters.AddWithValue("@Amount", SqlDbType.Int).Value = amount
                command.Parameters.AddWithValue("@CostEach", SqlDbType.Decimal).Value = costEach
                command.Parameters.AddWithValue("@CostTotal", SqlDbType.Decimal).Value = costTotal
                command.Parameters.AddWithValue("@Recived", SqlDbType.VarChar).Value = recived
                command.Parameters.AddWithValue("@Date", SqlDbType.Date).Value = daterecived

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



    'Insertar registros en la tabla item provider para saber el costo de cada item cada vez q se compro con un provider

    Sub InsertItemprovider(ByVal itemId As Integer, ByVal providerId As String,
                         ByVal costEach As Decimal, ByVal daterecived As Date)


        Dim query As String = "insert into Item_Provider(Item_id, Provider_Id, Cost, Date) values(@Item_Id, (select Id from Provider where Name= @Provider_Id), @CostEach, @Date)"


        Using Connection As New SqlConnection(conString)

            Using command As New SqlCommand(query, Connection)

                command.Parameters.AddWithValue("@Item_Id", SqlDbType.Int).Value = itemId
                command.Parameters.AddWithValue("@Provider_Id", SqlDbType.VarChar).Value = providerId
                command.Parameters.AddWithValue("@CostEach", SqlDbType.Decimal).Value = costEach
                command.Parameters.AddWithValue("@Date", SqlDbType.Date).Value = daterecived

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

    'filter by date and provider
    Function FilterStockHistoryByDateAdProvider(ByVal date1 As Date, ByVal date2 As Date, provider As String) As DataTable
        Dim table As New DataTable

        Dim query As String = "select * from StockHistoryCategory where Provider Like '" & provider & "%' and Date between Cast(@Date1 As Date) and Cast(@Date2 As Date) order by Id desc"
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

End Class
