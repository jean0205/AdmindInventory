Public Class Budget

    Dim isNew As Boolean = True
    Dim idUpdate As Integer

    Private Sub Budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxYear.Text = Date.Now.Year
        LoadCategories()
        LoadData()

    End Sub




    Sub LoadData()
        Dim category As New CategoryBL
        DataGridView1.DataSource = category.GetbudgetTable
        'DataGridView1.Rows(0).Visible = False

    End Sub

    Sub LoadCategories()
        Dim category As New CategoryBL
        Dim categoryNames As New List(Of String)


        For Each name As String In category.GetCategoriesNames()

            ComboBoxCategory.Items.Add(name)
        Next
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        If CheckInformation() Then
            Return

        End If
        Dim categoryName As String = ComboBoxCategory.SelectedItem

        Dim budget As Decimal = Convert.ToDecimal(TextBoxBudget.Text)

        Dim category As New CategoryBL
        If isNew Then

            Try
                category.InsertBudget(categoryName, budget)
                MessageBox.Show("Category budget successfully created.",
                                "Create Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)

                LoadData()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            category.UpdateBudget(idUpdate, budget)
            MessageBox.Show("Category budget successfully updated.",
                                "Update Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
            isNew = True
            ComboBoxCategory.Enabled = True
            LoadData()
        End If
        CleanScreen()
    End Sub

    Private Sub CleanScreen()
        ComboBoxCategory.SelectedIndex = -1
        TextBoxBudget.Clear()
    End Sub

    Function CheckInformation() As Boolean
        If ComboBoxCategory.SelectedIndex < 0 Then
            MessageBox.Show("You must provide the category name.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxYear.Text) Then
            MessageBox.Show("The system should provide the year.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxBudget.Text) Then
            MessageBox.Show("You must provide the budget for this category",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If

        Return False
    End Function

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        idUpdate = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxBudget.Text = DataGridView1.CurrentRow.Cells(3).Value
        ComboBoxCategory.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value
        ComboBoxCategory.Enabled = False

        isNew = False
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim category As New CategoryBL
        Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value


        Dim message As String = "Do you want to delete this category budget?"
        Dim title As String = "Delete Category Budget"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim result As DialogResult = MessageBox.Show(message, title, buttons)
        If result = DialogResult.Yes Then
            Try
                category.DeleteBudget(id)

                MessageBox.Show("Category budget successfully deleted.",
                                "Delete Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
                LoadData()
            Catch ex As Exception

                MessageBox.Show("The selected Category it is not empty." & ex.Message)

            End Try

            LoadCategories()

        End If
    End Sub
End Class