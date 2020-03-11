Public Class New_Item

#Region "Variables"
    Dim isNew As Boolean = True
    Dim idUpdate As Integer

#End Region

#Region "Objects"
    ' Dim category As New Category
    ' Dim categoryDB As New CategoryDB
    ' Dim itemDB As New ItemDB
#End Region


    Private Sub New_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCategories()
        GetItems()
    End Sub


#Region "Buttoms"
    'New
    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        Dim item As New ItemDB
        Dim stock As New StockBL

        'chequin information completed
        If CheckInformation() Then
            Return
        End If

        Try
            Dim name As String = TextBoxName.Text
            Dim presentation As String = TextBoxPresentation.Text
            Dim description As String = TextBoxDescript.Text
            Dim reorder As Integer = Convert.ToInt32(TextBoxReorder.Text)
            Dim category As String = ComboBoxCat.SelectedItem
            Dim Active As Boolean = RadioButtonActive.Checked
            If isNew Then



                item.NewItem(name, presentation, description, reorder, category, Active)

                MessageBox.Show("Item successfully created.",
                                "Create Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
                GetItems()
                Dim itemId As Integer = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value
                If Active = True Then
                    stock.InsertItemToStock(itemId)
                End If

            Else


                item.UpdateItem(idUpdate, name, presentation, description, reorder, category, Active)

                MessageBox.Show("Item successfully updated.",
                                "Update Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
                Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value
                If Active = True Then
                    stock.InsertItemToStock(itemId)
                End If
                GetItems()
                isNew = True
            End If

            CleanInterface()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try




    End Sub

    'Update
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        idUpdate = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBoxPresentation.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBoxDescript.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextBoxReorder.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        'ComboBoxCat.SelectedItem = ComboBoxCat.FindString(DataGridView1.CurrentRow.Cells(5).Value.ToString().TrimEnd())
        ComboBoxCat.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString().TrimEnd()
        RadioButtonActive.Checked = DataGridView1.CurrentRow.Cells(6).Value
        If RadioButtonActive.Checked = False Then
            RadioButtonInactive.Checked = True
        End If
        isNew = False




    End Sub

    'Delete
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim item As New ItemDB
        Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)

        Dim message As String = "Do you want to delete this item?"
        Dim title As String = "Delete item"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo

        Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                item.DeleteItem(id)
                MessageBox.Show("Item successfully deleted.",
                                "Delection Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
                GetItems()
            Catch ex As Exception
                MessageBox.Show("it is not possible to delete an active item. ", "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub

#End Region




#Region "Helpers"
    'Load categories to show in combobox
    Sub GetCategories()
        ' Dim categoryList As New List(Of Category)
        'Dim category As New CategoryDB

        'ComboBoxCategory.DisplayMember = "Name"
        ' ComboBoxCategory.ValueMember = "Id"

        'ComboBoxCat.DisplayMember = "Name"
        'ComboBoxCat.ValueMember = "Id"

        'categoryList = category.GetCategories()

        Dim category As New CategoryBL
        Dim categoryNames As New List(Of String)


        For Each name As String In category.GetCategoriesNames()
            'ComboBoxCategory.Items.Add(name)
            ComboBoxCat.Items.Add(name)
        Next

    End Sub

    '

    'Load Items to show on datagridview
    Sub GetItems()
        Dim itemList As New List(Of ProviderFrm)
        Dim item As New ItemDB
        DataGridView1.DataSource = item.GetItems()

        DataGridView1.Columns("Id").Visible = False
        PaintDatagrid()
    End Sub


    'Clean interfase textbox
    Sub CleanInterface()
        TextBoxName.Clear()
        TextBoxPresentation.Clear()
        TextBoxDescript.Clear()
        TextBoxReorder.Clear()
        ComboBoxCat.SelectedIndex = -1
        RadioButtonActive.Checked = False
        RadioButtonInactive.Checked = False
    End Sub

    Sub PaintDatagrid()
        Dim x As Integer = 1

        For Each row As DataGridViewRow In DataGridView1.Rows

            x += 1
            If (x Mod 2) <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Beige
            End If



        Next
    End Sub


    Function CheckInformation() As Boolean
        If String.IsNullOrEmpty(TextBoxName.Text) Then
            MessageBox.Show("You must provide the item name.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxDescript.Text) Then
            MessageBox.Show("You must provide the item description.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxPresentation.Text) Then
            MessageBox.Show("You must provide the item presentation.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxReorder.Text) Then
            MessageBox.Show("You must provide the item re-order level.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If ComboBoxCat.SelectedIndex < 0 Then
            MessageBox.Show("You must provide the item category.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)


            Return True
        End If
        Return False
    End Function

#End Region

#Region "Events"
    'Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    If ComboBoxCategory.Text <> "All Categories" Then
    '        Dim category As String
    '        Dim item As New ItemDB

    '        category = ComboBoxCategory.SelectedItem
    '        DataGridView1.DataSource = item.GetItemsByCat(category)



    '    Else
    '        GetItems()
    '    End If


    'End Sub

    Private Sub TextBoxReorder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxReorder.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxName_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyUp

        If String.IsNullOrEmpty(TextBoxName.Text) Then
            GetItems()
            Return

        End If
        Dim item As New ItemDB


        DataGridView1.DataSource = item.GetItemsByName(TextBoxName.Text)
        PaintDatagrid()

    End Sub






#End Region
End Class