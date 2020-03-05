Public Class DistributionHistory
    Private Sub DistributionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getStockOutHistory()


    End Sub

#Region "Load data to the interfaz"

    Sub getStockOutHistory()
        Dim stockOut As New StockOutBL
        DataGridView1.DataSource = stockOut.GetStockOutHystory

    End Sub
#End Region
End Class