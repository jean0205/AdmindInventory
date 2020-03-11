Imports Microsoft.Reporting.WinForms

Public Class ReportEntryHistoryFrm

    Dim totalCost As Decimal
    Dim entryList As List(Of ReportStockEntry)
    Dim dateFrom As Date
    Dim dateTo As Date
    Dim Item As String
    Dim invoice As String
    Dim provider As String
    Dim category As String

    Sub New(item As String, datefrom As Date, dateto As Date, totalCost As Decimal, invoice As String, provider As String, entryList As List(Of ReportStockEntry), category As String)

        Me.Item = item
        Me.dateFrom = datefrom
        Me.dateTo = dateto
        Me.totalCost = totalCost
        Me.invoice = invoice
        Me.provider = provider
        Me.entryList = entryList
        Me.category = category


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim totalCostP As New ReportParameter("TotalCost", totalCost)
        Dim itemP As New ReportParameter("Item", Item)
        Dim dateFromP As New ReportParameter("DateFrom", dateFrom)
        Dim dateToP As New ReportParameter("DateTo", dateTo)
        Dim invoiceP As New ReportParameter("Invoice", invoice)
        Dim providerP As New ReportParameter("Provider", provider)
        Dim categoryP As New ReportParameter("Category", category)






        ReportViewer2.LocalReport.DataSources.Clear()

        ReportViewer2.LocalReport.SetParameters(totalCostP)
        ReportViewer2.LocalReport.SetParameters(dateFromP)
        ReportViewer2.LocalReport.SetParameters(dateToP)
        ReportViewer2.LocalReport.SetParameters(itemP)
        ReportViewer2.LocalReport.SetParameters(invoiceP)
        ReportViewer2.LocalReport.SetParameters(providerP)
        ReportViewer2.LocalReport.SetParameters(categoryP)



        ReportViewer2.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", entryList))

        Me.ReportViewer2.RefreshReport()

        Me.ReportViewer2.RefreshReport()
    End Sub

End Class