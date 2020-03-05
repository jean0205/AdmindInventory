Public Class StockHistory
    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()


    End Sub


#Region "Load data"

    Sub LoadData()
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.GetStockEntryHistory
        DataGridView1.Columns(0).Visible = False


    End Sub
#End Region

End Class