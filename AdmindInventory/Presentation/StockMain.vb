Public Class StockMain


#Region "Buttoms"
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
#End Region




    Private Sub StockMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStock()
        LoadCategories()
    End Sub

#Region "Events"

    Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged
        If ComboBoxCategory.SelectedIndex > 0 Then
            Dim stock As New StockBL
            DataGridView1.DataSource = stock.GetStockListByCat(ComboBoxCategory.SelectedItem)
            DataGridView1.Columns(0).Visible = False
            TextBoxName.Clear()

        Else
            LoadStock()
        End If

    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub
    Private Sub TextBoxName_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyUp
        Dim stock As New StockBL

        DataGridView1.DataSource = stock.GetStockByName(TextBoxName.Text)


    End Sub

#End Region

#Region "load data"

    Sub LoadStock()
        Dim stock As New StockBL
        DataGridView1.DataSource = stock.GetStockList()
        DataGridView1.Columns(0).Visible = False

    End Sub

    Sub LoadCategories()
        Dim category As New CategoryBL
        ComboBoxCategory.Items.Add("All Categories")

        For Each name As String In category.GetCategoriesNames()

            ComboBoxCategory.Items.Add(name)

        Next
        ComboBoxCategory.SelectedIndex = 0

    End Sub






#End Region
End Class
