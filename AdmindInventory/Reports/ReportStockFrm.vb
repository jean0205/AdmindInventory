Imports Microsoft.Reporting.WinForms

Public Class ReportStockFrm




    Dim category As String
    Dim reorder As String
    Dim total As Integer

    Dim stockList As List(Of ReportStock)

    Sub New(category As String, reorder As String, total As Integer, stocklist As List(Of ReportStock))


        Me.category = category
        Me.reorder = reorder
        Me.total = total
        Me.stockList = stocklist

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub







    Private Sub ReportStockFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim categoryP As New ReportParameter("Category", category)
        Dim reorderP As New ReportParameter("Reorder", reorder)
        Dim totalP As New ReportParameter("Total", total)


        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.SetParameters(categoryP)
        ReportViewer1.LocalReport.SetParameters(reorderP)
        ReportViewer1.LocalReport.SetParameters(totalP)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", stockList))


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class