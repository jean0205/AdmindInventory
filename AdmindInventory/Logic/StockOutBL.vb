Public Class StockOutBL

    Sub InsertStockOut(ByVal itemId As Integer, ByVal departmentName As String,
                        ByVal amount As Integer, ByVal dateOut As Date, ByVal person As String, ByVal condition As Integer, ByVal requested As Boolean)

        Dim stock As New StockOutDB
        stock.InsertStockOut(itemId, departmentName, amount, dateOut, person, condition, requested)

    End Sub

    Function GetStockOutHystory() As DataTable
        Dim stock As New StockOutDB
        Return stock.GetStockOutHystory()
    End Function

    Function GetStockRequest() As DataTable
        Dim stock As New StockOutDB
        Return stock.GetStockRequest()
    End Function

    Sub UpdateRequestState(ByVal itemId As Integer, ByVal condition As Integer)
        Dim stock As New StockOutDB
        stock.UpdateRequestState(itemId, condition)
    End Sub
End Class
