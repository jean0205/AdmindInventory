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


        If CheckInformation() Then
            Return
        End If

        Dim name As String = TextBoxName.Text
        Dim description As String = TextBoxDescription.Text

        Dim department As New DepartmentBL
        If isNew Then

            Try
                department.NewDepartments(name, description)
                MessageBox.Show("Department successfully created.",
                                "Create Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            department.UpdateDepartment(idUpdate, name, description)
            MessageBox.Show("Department successfully created.",
                                "Update Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
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

                MessageBox.Show("Department successfully deleted.",
                                "Delete Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
                LoadDepartments()
            Catch ex As Exception


                MessageBox.Show("The selected Department it is not empty." & ex.Message,
                                "Delete Error",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button1)
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

    Function CheckInformation() As Boolean
        If String.IsNullOrEmpty(TextBoxName.Text) Then
            MessageBox.Show("You must provide the department name.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If

        If String.IsNullOrEmpty(TextBoxDescription.Text) Then
            MessageBox.Show("You must provide the department description.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If

        Return False
    End Function
End Class