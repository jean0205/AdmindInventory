Public Class Departments
#Region "Variables"
    Dim isNew As Boolean = True
    Dim idUpdate As Integer

#End Region

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()


    End Sub

#Region "Buttons"
    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        Dim name As String = TextBoxName.Text
        Dim description As String = TextBoxDescription.Text

        Dim department As New DepartmentBL
        If isNew Then

            Try
                department.NewDepartments(name, description)
                MessageBox.Show("Department successfully created")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            department.UpdateDepartment(idUpdate, name, description)
            MessageBox.Show("Department successfully updated")
            isNew = True
        End If
        CleanScreen()
        LoadDepartments()

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        idUpdate = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBoxDescription.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        isNew = False

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim department As New DepartmentBL
        Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value.ToString())


        Dim message As String = "Do you want to delete this department?"
        Dim title As String = "Delete Department"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim result As DialogResult = MessageBox.Show(message, title, buttons)
        If result = DialogResult.Yes Then
            Try
                department.DeleteDepartment(id)
                MessageBox.Show("Department successfully deleted")
                LoadDepartments()
            Catch ex As Exception

                MessageBox.Show("The selected Department it is not empty." & ex.Message)
            End Try

            LoadDepartments()

        End If
    End Sub

#End Region



#Region "Load and clean screen"
    'Load department to the datagridview
    Sub LoadDepartments()
        Dim department As New DepartmentBL
        DataGridView1.DataSource = department.GetDepartments()
        DataGridView1.Columns("Id").Visible = False

    End Sub

    'Cleaning text boxes
    Sub CleanScreen()
        TextBoxName.Clear()
        TextBoxDescription.Clear()

    End Sub













#End Region
End Class