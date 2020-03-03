Public Class Categories
#Region "Variables"
    Dim isNew As Boolean = True
    Dim idUpdate As Integer

#End Region

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()

    End Sub


#Region "Buttoms"

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        Dim name As String = TextBoxName.Text
        Dim GLnumber As String = TextBoxGL.Text
        Dim description As String = TextBoxDescription.Text

        Dim category As New CategoryBL
        If isNew Then

            Try
                category.NewCategory(name, GLnumber, description)
                MessageBox.Show("Category successfully created")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            category.UpdateCategory(idUpdate, name, GLnumber, description)
            MessageBox.Show("Category successfully updated")
            isNew = True
        End If
        CleanScreen()
        LoadCategories()

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        idUpdate = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBoxGL.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBoxDescription.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        isNew = False

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim category As New CategoryBL
        Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString())


        Dim message As String = "Do you want to delete this category?"
        Dim title As String = "Delete Category"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim result As DialogResult = MessageBox.Show(message, title, buttons)
        If result = DialogResult.Yes Then
            Try
                category.DeleteCategory(id)
                MessageBox.Show("Category successfully deleted")
                LoadCategories()
            Catch ex As Exception

                MessageBox.Show("The selected Category it is not empty." & ex.Message)
            End Try

            LoadCategories()

        End If





    End Sub

#End Region





#Region "Load and clean screen"
    'Load categories to the datagridview
    Sub LoadCategories()
        Dim category As New CategoryBL
        DataGridView1.DataSource = category.GetCategories()
        DataGridView1.Columns("Id").Visible = False

    End Sub

    'Cleaning text boxes
    Sub CleanScreen()
        TextBoxGL.Clear()
        TextBoxDescription.Clear()
        TextBoxName.Clear()
    End Sub







#End Region
End Class