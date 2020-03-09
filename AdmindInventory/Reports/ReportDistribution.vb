Imports Microsoft.Reporting.WinForms

Public Class ReportDistribution



    Dim outList As List(Of ReportStockOut)
    Dim dateFrom As Date
    Dim dateTo As Date
    Dim Item As String
    Dim category As String
    Dim department As String


    Sub New(item As String, datefrom As Date, dateto As Date, category As String, department As String, outList As List(Of ReportStockOut))

        Me.Item = item
        Me.dateFrom = datefrom
        Me.dateTo = dateto

        Me.category = category
        Me.department = department
        Me.outList = outList


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ReportDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim itemP As New ReportParameter("Item", Item)
        Dim dateFromP As New ReportParameter("DateFrom", dateFrom)
        Dim dateToP As New ReportParameter("DateTo", dateTo)
        Dim categoryP As New ReportParameter("Category", category)
        Dim departmentP As New ReportParameter("Department", department)






        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.SetParameters(itemP)
        ReportViewer1.LocalReport.SetParameters(dateFromP)
        ReportViewer1.LocalReport.SetParameters(dateToP)
        ReportViewer1.LocalReport.SetParameters(categoryP)
        ReportViewer1.LocalReport.SetParameters(departmentP)



        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", outList))

        Me.ReportViewer1.RefreshReport()


    End Sub
End Class