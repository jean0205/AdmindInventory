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

        Try
            Dim name As String = TextBoxName.Text
            Dim presentation As String = TextBoxPresentation.Text
            Dim description As String = TextBoxDescript.Text
            Dim reorder As Integer = Convert.ToInt32(TextBoxReorder.Text)
            Dim category As Category = ComboBoxCat.SelectedItem
            If isNew Then
                item.NewItem(name, presentation, description, reorder, category.Id)
                MessageBox.Show("Item successfully created")
            Else
                item.UpdateItem(idUpdate, name, presentation, description, reorder, category.Id)
                MessageBox.Show("Item successfully updated")
                isNew = True
            End If

            CleanInterface()
            GetItems()

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
        'ComboBoxCat.SelectedItem = ComboBoxCat.FindStringExact(DataGridView1.CurrentRow.Cells(5).Value.ToString())
        ComboBoxCat.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        isNew = False




    End Sub

#End Region




#Region "Helpers"
    'Load categories to show in combobox
    Sub GetCategories()
        Dim categoryList As New List(Of Category)
        Dim category As New CategoryDB

        ComboBoxCategory.DisplayMember = "Name"
        ComboBoxCategory.ValueMember = "Id"

        ComboBoxCat.DisplayMember = "Name"
        ComboBoxCat.ValueMember = "Id"

        categoryList = category.GetCategories()

        For Each item As Category In categoryList
            ComboBoxCategory.Items.Add(item)
            ComboBoxCat.Items.Add(item)
        Next

    End Sub

    '

    'Load Items to show on datagridview
    Sub GetItems()
        Dim itemList As New List(Of Item)
        Dim item As New ItemDB
        DataGridView1.DataSource = item.GetItems()

        DataGridView1.Columns("Id").Visible = False
    End Sub


    'Clean interfase textbox
    Sub CleanInterface()
        TextBoxName.Clear()
        TextBoxPresentation.Clear()
        TextBoxDescript.Clear()
        TextBoxReorder.Clear()
    End Sub


#End Region

#Region "Events"
    Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged

        If ComboBoxCategory.Text <> "All Categories" Then
            Dim category As New Category
            Dim item As New ItemDB

            category = ComboBoxCategory.SelectedItem
            DataGridView1.DataSource = item.GetItemsByCat(category.Id)



        Else
            GetItems()
        End If


    End Sub




#End Region
End Class