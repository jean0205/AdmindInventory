﻿Public Class FrmAddStock
    Dim itemDB As New ItemDB

    Dim itemId As Integer

    Sub New(ByVal itemId As Integer)

        Me.itemId = itemId


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmAddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetItemInformation()
        ReloadAutocomplete()


    End Sub

#Region "Buttom"
    Private Sub ButtonReestock_Click(sender As Object, e As EventArgs) Handles ButtonReestock.Click

        If CheckInformation() Then
            Return
        End If

        Try



            Dim invoice As String = TextBoxInvoice.Text
            Dim providerName As String = TextBoxprovider.Text
            Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)
            Dim costEach As Decimal = Convert.ToDecimal(TextBoxCost.Text)
            Dim totalCost As Decimal = Convert.ToDecimal(TextBoxTotalCost.Text)
            Dim recibed As String = Label10.Text
            Dim todaysdate As Date = Format(DateTime.Now)



            Dim stockEntry As New StockEntryBL
            stockEntry.InsertStockEntry(itemId, invoice, providerName, amount, costEach, totalCost, recibed, todaysdate)
            stockEntry.InsertItemprovider(itemId, providerName, costEach, todaysdate)


            Dim stock As New StockBL
            stock.UpdateStock(itemId, amount)

            MessageBox.Show("Stock entry saved.",
                                "Entry Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
            CleanInterfaz()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub ButtonNewprov_Click(sender As Object, e As EventArgs) Handles ButtonNewprov.Click
        Dim provider As New ProviderFrm
        provider.ShowDialog()
        ReloadAutocomplete()


    End Sub

#End Region

#Region "Load Information"

    Sub GetItemInformation()
        Dim item As New Item

        item = itemDB.GetItemsById(itemId)
        TextBoxName.Text = item.Name
        TextBoxCategory.Text = item.Category_Name
        TextBoxPresentation.Text = item.Presentation


    End Sub

    Sub CleanInterfaz()
        TextBoxAmount.Clear()
        TextBoxCost.Clear()
        TextBoxTotalCost.Clear()
        TextBoxInvoice.Clear()
        TextBoxprovider.Clear()


    End Sub
#End Region

    Function CheckInformation() As Boolean
        If String.IsNullOrEmpty(TextBoxInvoice.Text) Then
            MessageBox.Show("You must provide the invoice number.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxAmount.Text) Then
            MessageBox.Show("You must provide the item amount.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxprovider.Text) Then
            MessageBox.Show("You must provide the item provider.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If String.IsNullOrEmpty(TextBoxCost.Text) Then
            MessageBox.Show("You must provide the item cost.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If



        Return False

    End Function

#Region "Autocomplete texbox from provider.name"

    Function Autocomplete() As AutoCompleteStringCollection

        Dim providerList As New List(Of ProviderE)
        Dim provider As New ProviderBL
        providerList = provider.GetProviderList

        'Dim dt As DataTable = patientCN.ShowPatients()

        Dim coleccion As New AutoCompleteStringCollection()
        Dim DataCollection As New AutoCompleteStringCollection()

        For Each providerIn As ProviderE In providerList

            coleccion.Add(providerIn.Name)
        Next

        Return coleccion
    End Function

    Sub ReloadAutocomplete()

        TextBoxprovider.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBoxprovider.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBoxprovider.AutoCompleteCustomSource = Autocomplete()
    End Sub

    Private Sub TextBoxAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxAmount.KeyUp
        Try
            If TextBoxAmount.Text.Length > 0 Then
                Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)

                If TextBoxCost.Text.Length > 0 Then
                    Dim costEach As Decimal = Convert.ToDecimal(TextBoxCost.Text)
                    Dim totalCost As Decimal = amount * costEach
                    TextBoxTotalCost.Text = totalCost.ToString("n2")
                End If
            Else
                TextBoxTotalCost.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try





        'Dim number As Decimal = Convert.ToDecimal(TextBoxAmount.Text)
        'TextBoxAmount.Text = number.ToString("n2")
    End Sub

    Private Sub TextBoxCost_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxCost.KeyUp
        Try
            If TextBoxCost.Text.Length > 0 AndAlso TextBoxAmount.Text.Length > 0 Then
                Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)

                If TextBoxAmount.Text.Length > 0 Then
                    Dim costEach As Decimal = Convert.ToDecimal(TextBoxCost.Text)
                    Dim totalCost As Decimal = amount * costEach
                    TextBoxTotalCost.Text = totalCost.ToString("n2")
                End If
            Else
                TextBoxTotalCost.Clear()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBoxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAmount.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBoxCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCost.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


#End Region



End Class