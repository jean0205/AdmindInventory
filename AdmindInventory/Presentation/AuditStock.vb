Public Class AuditStock
    Private Sub AuditStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataEntry()
    End Sub



#Region "Get Data"
    Sub LoadDataEntry()

        Dim stockentry As New StockEntryBL
        DataGridView1.DataSource = stockentry.StockEntryAudit
        DataGridView1.Columns(0).Visible = False

        fillCombobox1()

    End Sub
    Sub LoadDataOut()
        Dim stockout As New StockOutBL
        DataGridView2.DataSource = stockout.StockOutAudit
        DataGridView2.Columns(0).Visible = False
        fillCombobox2()

    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected


        If TabControl1.SelectedTab Is TabPage1 Then

            LoadDataEntry()
        Else

            LoadDataOut()
        End If

    End Sub

    Sub fillCombobox1()

        For Each row As DataGridViewRow In DataGridView1.Rows

            If String.IsNullOrEmpty(row.Cells(7).Value) Then
                Return
            End If

            If Not ComboBoxuser1.Items.Contains(row.Cells(7).Value) Then
                ComboBoxuser1.Items.Add(row.Cells(7).Value)
            End If
            If Not ComboBoxstation1.Items.Contains(row.Cells(8).Value) Then
                ComboBoxstation1.Items.Add(row.Cells(8).Value)
            End If
            If Not ComboBoxoperation1.Items.Contains(row.Cells(9).Value) Then
                ComboBoxoperation1.Items.Add(row.Cells(9).Value)
            End If


        Next

    End Sub
    Sub fillCombobox2()

        For Each row As DataGridViewRow In DataGridView2.Rows

            If String.IsNullOrEmpty(row.Cells(8).Value) Then
                Return
            End If

            If Not ComboBoxuser2.Items.Contains(row.Cells(8).Value) Then
                ComboBoxuser2.Items.Add(row.Cells(8).Value)
            End If
            If Not ComboBoxstation2.Items.Contains(row.Cells(9).Value) Then
                ComboBoxstation2.Items.Add(row.Cells(9).Value)
            End If
            If Not ComboBoxoperation2.Items.Contains(row.Cells(10).Value) Then
                ComboBoxoperation2.Items.Add(row.Cells(10).Value)
            End If


        Next

    End Sub

    Private Sub ComboBoxuser1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxuser1.SelectedIndexChanged
        If ComboBoxuser1.SelectedIndex > 0 Then
            Dim stockentry As New StockEntryBL
            DataGridView1.DataSource = stockentry.StockEntryAuditByUser(ComboBoxuser1.SelectedItem)
            ComboBoxoperation1.Text = String.Empty
            ComboBoxstation1.Text = String.Empty
        Else
            LoadDataEntry()


        End If

    End Sub

    Private Sub ComboBoxstation1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxstation1.SelectedIndexChanged

        If ComboBoxstation1.SelectedIndex > 0 Then
            Dim stockentry As New StockEntryBL
            DataGridView1.DataSource = stockentry.StockEntryAuditByStation(ComboBoxstation1.SelectedItem)
            ComboBoxoperation1.Text = String.Empty
            ComboBoxuser1.Text = String.Empty

        Else
            LoadDataEntry()


        End If

    End Sub

    Private Sub ComboBoxoperation1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxoperation1.SelectedIndexChanged
        If ComboBoxoperation1.SelectedIndex > 0 Then
            Dim stockentry As New StockEntryBL
            DataGridView1.DataSource = stockentry.StockEntryAuditByOperation(ComboBoxoperation1.SelectedItem)
            ComboBoxstation1.Text = String.Empty
            ComboBoxuser1.Text = String.Empty

        Else
            LoadDataEntry()


        End If
    End Sub

    Private Sub ComboBoxuser2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxuser2.SelectedIndexChanged
        If ComboBoxuser2.SelectedIndex > 0 Then
            Dim stockout As New StockOutBL
            DataGridView2.DataSource = stockout.StockOutAuditByUser(ComboBoxuser2.SelectedItem)
            ComboBoxoperation2.Text = String.Empty
            ComboBoxstation2.Text = String.Empty
        Else
            LoadDataOut()


        End If

    End Sub

    Private Sub ComboBoxstation2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxstation2.SelectedIndexChanged
        If ComboBoxstation2.SelectedIndex > 0 Then
            Dim stockout As New StockOutBL
            DataGridView2.DataSource = stockout.StockOutAuditByStation(ComboBoxstation2.SelectedItem)
            ComboBoxoperation2.Text = String.Empty
            ComboBoxuser2.Text = String.Empty

        Else
            LoadDataOut()


        End If
    End Sub

    Private Sub ComboBoxoperation2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxoperation2.SelectedIndexChanged
        If ComboBoxoperation2.SelectedIndex > 0 Then
            Dim stockout As New StockOutBL
            DataGridView2.DataSource = stockout.StockOutAuditByOperation(ComboBoxoperation2.SelectedItem)
            ComboBoxstation2.Text = String.Empty
            ComboBoxuser2.Text = String.Empty

        Else
            LoadDataOut()


        End If
    End Sub
#End Region
End Class