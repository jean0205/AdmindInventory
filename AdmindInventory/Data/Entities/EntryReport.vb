Public Class EntryReport

    Public Property datos As DataTable
    Public Property name As String
    Public Property edad As Integer

    Sub getReport()
        Dim dataentry As New StockEntryDB
        datos = dataentry.GetStockEntryHistory
    End Sub


End Class
