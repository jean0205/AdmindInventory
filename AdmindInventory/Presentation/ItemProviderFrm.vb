Public Class ItemProviderFrm
    Dim itemId As Integer


    Sub New(ByVal itemId As Integer)

        Me.itemId = itemId

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ItemProviderFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As New ItemDB
        DataGridView1.DataSource = item.GetProvidersPerItem(itemId)
        DataGridView1.Columns(0).Visible = False

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim provider As New ProviderFrm
        provider.ShowDialog()

    End Sub
End Class