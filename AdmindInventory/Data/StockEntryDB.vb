Imports System.Data.SqlClient

Public Class StockEntryDB

    Dim conString As String = My.Settings.conString
    'Gett stock view
    Function GetStockEntryList() As List(Of StockEntry)

        Dim stockList As New List(Of StockEntry)
        Dim query As String = "Select * from StockEntry"
        Using connection As New SqlConnection(conString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read
                        Dim stockentry As New StockEntry

                        stockentry.Id = reader.GetInt32(0)
                        stockentry.Item_Id = reader.GetInt32(1)
                        stockentry.InvoiceNo = reader.GetString(2)
                        stockentry.Provider = reader.GetInt32(3)
                        stockentry.Amount = reader.GetInt32(4)
                        stockentry.CostEach = reader.GetDecimal(5)
                        stockentry.CostTotal = reader.GetDecimal(6)
                        stockentry.Recived = reader.GetString(7)
                        stockentry.DateReciv = reader.GetDateTime(8)


                        stockList.Add(stockentry)
                    End While

                Catch ex As Exception
                    Throw ex

                End Try

            End Using
        End Using
        Return stockList
    End Function

    Sub InsertStockEntry(ByVal itemId As Integer, ByVal invoiceNo As String, ByVal providerId As String,
                         ByVal amount As Integer, ByVal costEach As Decimal, ByVal costTotal As Decimal,
                         ByVal recived As String, ByVal daterecived As Date)


        Dim query As String = "Insert INTO StockEntry (Item_Id, InvoiceNo, Provider_Id, Amount, CostEach, CostTotal,
                                Recived, Date) values (@Item_Id, @InvoiceNo, (Select Id from Provider where Name=@Provider_Id), @Amount, @CostEach, @CostTotal, @Recived, @Date)"


        Using Connection As New SqlConnection(conString)

            Using command As New SqlCommand(query, Connection)

                command.Parameters.AddWithValue("@Item_Id", SqlDbType.Int).Value = itemId
                command.Parameters.AddWithValue("@InvoiceNo", SqlDbType.NChar).Value = invoiceNo
                command.Parameters.AddWithValue("@Provider_Id", SqlDbType.NChar).Value = providerId
                command.Parameters.AddWithValue("@Amount", SqlDbType.Int).Value = amount
                command.Parameters.AddWithValue("@CostEach", SqlDbType.Decimal).Value = costEach
                command.Parameters.AddWithValue("@CostTotal", SqlDbType.Decimal).Value = costTotal
                command.Parameters.AddWithValue("@Recived", SqlDbType.NChar).Value = recived
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

End Class
