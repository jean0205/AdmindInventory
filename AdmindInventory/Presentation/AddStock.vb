Public Class FrmAddStock
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



#Region "Load Information"

    Sub GetItemInformation()
        Dim item As New Item

        item = itemDB.GetItemsById(itemId)
        TextBoxName.Text = item.Name
        TextBoxCategory.Text = item.Category_Name
        TextBoxPresentation.Text = item.Presentation


    End Sub
#End Region


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

End Class