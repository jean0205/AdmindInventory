Public Class FrmDistibuteStock

#Region "Variable"

    Dim itemId As Integer
    Dim stockAmount As Integer

#End Region

#Region "Objects"

    Dim itemDB As New ItemDB
#End Region




    Sub New(ByVal itemId As Integer, ByVal stockAmount As Integer)

        Me.itemId = itemId
        Me.stockAmount = stockAmount

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmDistibuteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
        LoadItemInformation()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBoxDepartment.SelectedIndex < 0 Then
            MessageBox.Show("You must select the Department first. ")
            Return
        End If
        If TextBoxAmount.Text.Length = 0 Then
            MessageBox.Show("You must enter some amount. ")
            Return
        End If
        If Convert.ToInt32(TextBoxAmount.Text) = 0 Then
            MessageBox.Show("You must enter some amount other than 0. ")
            Return
        End If

        Try
            Dim departmetName As String = ComboBoxDepartment.SelectedItem
            Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)
            Dim todaysdate As Date = Format(DateTime.Now)
            Dim person As String = Label9.Text
            Dim condition As Integer = 2 'approved
            Dim requested As Boolean = False ' it was not a request

            Dim stockOut As New StockOutBL
            stockOut.InsertStockOut(itemId, departmetName, amount, todaysdate, person, condition, requested)
            Dim stock As New StockBL
            stock.UpdateStock(itemId, -amount)

            MessageBox.Show("The item was correctly distributed to the department: " & ComboBoxDepartment.SelectedItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try











    End Sub




#Region "Load Data"
    Sub LoadDepartments()
        Dim department As New DepartmentBL

        For Each name As String In department.GetDepartmentsNames()
            ComboBoxDepartment.Items.Add(name)
        Next
    End Sub
    Sub LoadItemInformation()
        Dim item As New Item

        item = itemDB.GetItemsById(itemId)
        TextBoxItem.Text = item.Name
        TextBoxDescription.Text = item.Description
        TextBoxPresentation.Text = item.Presentation
        TextBoxInStock.Text = stockAmount.ToString

    End Sub





#End Region
#Region "Events"
    Private Sub TextBoxAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxAmount.KeyUp
        If TextBoxAmount.Text <> String.Empty Then
            Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)
            Dim stock As Integer = Convert.ToInt32(TextBoxInStock.Text)



            If amount > stock Then
                TextBoxAmount.Text = TextBoxAmount.Text.Substring(0, TextBoxAmount.Text.Length - 1)

                MessageBox.Show("The amount you are trying to distribute exceeds stocks.")

            End If
        End If

    End Sub

    Private Sub TextBoxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAmount.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
End Class