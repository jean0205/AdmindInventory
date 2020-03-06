Public Class Report

    Public Property name As String
    Public Property Presentation As String
    Public Property Amount As Integer
    Public Property CostEach As Decimal
    Public Property CostTotal As Decimal
    Public Property Invoice As String
    Public Property Provider As String
    Public Property Posted As String
    Public Property dater As Date










End Class


Public Class Report2

    Public Property Entrylist As List(Of Report)


    Function list() As List(Of Report)
        Dim stockEntry As New StockEntryDB




        For Each row As DataRow In stockEntry.GetStockEntryHistory.Rows
            Dim repo As New Report
            repo.name = row(0)
            repo.Presentation = row(1)
            repo.Amount = row(2)
            repo.CostEach = row(3)
            repo.CostTotal = row(4)
            repo.Invoice = row(5)
            repo.Provider = row(6)
            repo.Posted = row(7)
            repo.dater = row(8)

            Entrylist.Add(repo)


        Next

        Return Entrylist

    End Function








End Class
