﻿Public Class StockOutBL

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

    Function FilterStockOutByName(ByVal ItemName As String) As DataTable
        Dim stock As New StockOutDB
        Return stock.FilterStockOutByName(ItemName)
    End Function
    Function FilterStockOutByCategory(ByVal category As String) As DataTable

        Dim stock As New StockOutDB
        Return stock.FilterStockOutByCategory(category)

    End Function
    Function FilterStockOutByDepartment(ByVal department As String) As DataTable

        Dim stock As New StockOutDB
        Return stock.FilterStockOutByDepartment(department)

    End Function
    Function FilterStockHistoryByDate(ByVal date1 As Date, ByVal date2 As Date) As DataTable

        Dim stock As New StockOutDB
        Return stock.FilterStockHistoryByDate(date1, date2)

    End Function
End Class