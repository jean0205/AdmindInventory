Public Class StockBL

    Function GetStockList()
        Dim stock As New StockDB
        Return stock.GetStockList()
    End Function

    'get stock filterin by category
    Function GetStockListByCat(ByVal catName As String)
        Dim stock As New StockDB
        Return stock.GetStockListByCat(catName)

    End Function
    Function GetStockByName(ByVal ItemName As String)
        Dim stock As New StockDB
        Return stock.GetStockByName(ItemName)
    End Function

    Sub InsertItemToStock(ByVal itemId As Integer)
        Dim stock As New StockDB
        stock.InsertItemToStock(itemId)
    End Sub

    Sub UpdateStock(ByVal itemId As Integer, stockAmount As Integer)
        Dim stock As New StockDB
        stock.UpdateStock(itemId, stockAmount)
    End Sub

    Sub DeleteItemInactive(ByVal id As Integer)
        Dim stock As New StockDB
        stock.DeleteItemInactive(id)

    End Sub

    Function GetStockToOrder() As DataTable
        Dim stock As New StockDB
        Return stock.GetStockToOrder()
    End Function


End Class
