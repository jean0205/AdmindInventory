Public Class ReportStructure

End Class

Public Class ReportStockEntry

    Public Property Item_Name As String

    Public Property Item_Presentationd As String

    Public Property Amount As Integer

    Public Property CostEach As Decimal

    Public Property CostTotal As Decimal

    Public Property InvoiceNo As String

    Public Property Provider As String

    Public Property Recived As String

    Public Property DateReciv As String




End Class

Public Class ReportStockOut
    Public Property Item_Name As String

    Public Property Category As String

    Public Property GL As String

    Public Property Department As String

    Public Property Amount As Integer


    Public Property DateRevic As String

    Public Property State As String

    Public Property Person As String

    Public Property Requested As Boolean

End Class

Public Class ReportStock

    Public Property ItemName As String
    Public Property ItemCategory As String
    Public Property ItemPresentation As String
    Public Property ItemReorder As Integer
    Public Property StockRemains As Integer

End Class

