Public Class ProviderBL

    Function GetProviderList() As List(Of ProviderE)
        Dim provider As New ProviderDB
        Dim providerList As New List(Of ProviderE)
        providerList = provider.GetProviderList()
        Return providerList
    End Function

    Sub InsertProvider(ByVal name As String, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal contactPerson As String, ByVal note As String)
        Dim provider As New ProviderDB
        provider.InsertProvider(name, address, phone, email, contactPerson, note)
    End Sub

    Sub UpdateProvider(ByVal id As Integer, ByVal name As String, ByVal address As String, ByVal phone As String, ByVal email As String, ByVal contactPerson As String, ByVal note As String)
        Dim provider As New ProviderDB
        provider.UpdateProvider(id, name, address, phone, email, contactPerson, note)
    End Sub

    Sub DeleteProvider(ByVal id As Integer)
        Dim provider As New ProviderDB
        provider.DeleteProvider(id)
    End Sub

    Function GetProviderByName() As List(Of ProviderE)
        Dim provider As New ProviderDB

        Return provider.GetProviderList()

    End Function

End Class

