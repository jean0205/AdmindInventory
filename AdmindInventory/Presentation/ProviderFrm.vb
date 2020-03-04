Public Class ProviderFrm
    Private isNew As Boolean = True
    Private idUpdate As Integer

    Private Sub Provider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProvidersList()

    End Sub


#Region "Buttoms"
    'New provider
    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click

        Dim provider As New ProviderBL


        Try
            Dim name As String = TextBoxName.Text
            Dim address As String = TextBoxAddress.Text
            Dim phone As String = TextBoxPhone.Text
            Dim email As String = TextBoxEmail.Text
            Dim contactPerson As String = TextBox1Contact.Text
            Dim notes As String = TextBoxNotes.Text

            If isNew Then
                provider.InsertProvider(name, address, phone, email, contactPerson, notes)
                MessageBox.Show("Provider successfully created")
                LoadProvidersList()


            Else
                provider.UpdateProvider(idUpdate, name, address, phone, email, contactPerson, notes)
                MessageBox.Show("Provider successfully updated")

                LoadProvidersList()
                isNew = True
            End If

            CleanInterface()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub



    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        idUpdate = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBoxAddress.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBoxPhone.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextBoxEmail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TextBox1Contact.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()

        isNew = False

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim provider As New ProviderBL


        Dim message As String = "Do you want to delete this provider?"
        Dim title As String = "Delete provider"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim result As DialogResult = MessageBox.Show(message, title, buttons)
        If result = DialogResult.Yes Then
            Try
                provider.DeleteProvider(id)
                MessageBox.Show("Provider successfully deleted")
                LoadProvidersList()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


#End Region

#Region "Load Information an clean"
    Sub LoadProvidersList()
        Dim provider As New ProviderBL

        DataGridView1.DataSource = provider.GetProviderList()
        DataGridView1.Columns(0).Visible = False


    End Sub

    Private Sub CleanInterface()
        TextBoxName.Clear()
        TextBoxAddress.Clear()
        TextBoxPhone.Clear()
        TextBoxEmail.Clear()
        TextBox1Contact.Clear()


    End Sub




#End Region
End Class