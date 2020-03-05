Public Class PendingRequests

    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        GetRequest()

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
        DataGridView1.Columns(0).Visible = False



    End Sub

#Region "Load data"
    Sub GetRequest()
        Dim stockout As New StockOutBL
        DataGridView1.DataSource = stockout.GetStockRequest()








    End Sub
#End Region

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        'buttom approve
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 AndAlso e.ColumnIndex = 8 Then


            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value) Then

                MessageBox.Show("It is not possible to approve this request. Not enough stocks")

                Return


            End If
            If DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value > DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value Then

                MessageBox.Show("It is not possible to approve this request. Not enough stocks")

                Return


            End If


            Try '
                Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value
                Dim condition As Integer = 2
                Dim amoutn As Integer = -(DataGridView1.CurrentRow.Cells(6).Value)

                Dim stockOut As New StockOutBL
                stockOut.UpdateRequestState(itemId, condition)

                Dim stock As New StockBL
                stock.UpdateStock(itemId, amoutn)

                MessageBox.Show("Request Approved")
                GetRequest()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If


        ' buttom refuse
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
          e.RowIndex >= 0 AndAlso e.ColumnIndex = 9 Then

            Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value
            Dim condition As Integer = 3

            Dim stockOut As New StockOutBL
            stockOut.UpdateRequestState(itemId, condition)

            MessageBox.Show("Request Refused")
            GetRequest()
        End If

    End Sub
End Class