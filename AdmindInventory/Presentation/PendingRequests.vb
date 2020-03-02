Public Class PendingRequests
    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = "Action"
        btn.Name = "Approve"
        btn.Text = "Approve"
        btn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btn)

        Dim btn2 As New DataGridViewButtonColumn
        btn2.HeaderText = "Action"
        btn2.Name = "Refuse"
        btn2.Text = "Refuse"
        btn2.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btn2)
    End Sub
End Class