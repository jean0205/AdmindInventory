Public Class StockMain
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAddStock.Click
        Dim addStock As New FrmAddStock
        addStock.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newItem As New New_Item
        newItem.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonDistrStock.Click
        Dim stockDist As New FrmDistibuteStock
        stockDist.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles ButtonMngitems.Click
        Dim newItem As New New_Item
        newItem.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonMngDepart.Click
        Dim departmentF As New Departments
        departmentF.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonMngCat.Click
        Dim categoriesF As New Categories
        categoriesF.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonStockHistory.Click
        Dim stockHistoryFrm As New StockHistory
        stockHistoryFrm.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonDistrbHistory.Click
        Dim distrHistoryFrm As New DistributionHistory
        distrHistoryFrm.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles ButtonPendingReqs.Click
        Dim pendinReqFrm As New PendingRequests
        pendinReqFrm.Show()
    End Sub
End Class
