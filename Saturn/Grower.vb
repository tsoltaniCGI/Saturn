Public Class Grower

    Public Property GrowerID As Integer
    Public Property GrowerFirstName As String
    Public Property GrowerAddress1 As String
    Public Property GrowerAddress2 As String
    Public Property GrowerCity As String
    Public Property GrowerCounty As String
    Public Property GrowerState As String
    Public Property GrowerCountry As String
    Public Property GrowerZip As String
    Public Property GrowerPhone1 As String
    Public Property GrowerPhone2 As String

    Public Property Vendors As New Collection
    Public Property Notes As New Collection




    Public Sub New()

    End Sub



End Class
Public Class GrowVendCom
    Public Property GrowerID As Integer
    Public Property VendorId As Integer
    Public Property GrowerFirstName As String
    Public Property GrowerLastName As String
    Public Property GrowerAddress1 As String
    Public Property GrowerAddress2 As String
    Public Property GrowerCity As String
    Public Property GrowerCounty As String
    Public Property GrowerState As String
    Public Property GrowerCountry As String
    Public Property GrowerZip As String
    Public Property GrowerPhone1 As String
    Public Property GrowerPhone2 As String
    Public Property VendorName As String
    Public Property CommID As String
    Public Property CommName As String
    Public Property CurrentCropYear As Decimal
    Public Property PreviousCropYear As Decimal

    Public Property Previous2CropYear As Decimal
    Public Property GrowerNoteId As Integer
    Public Property GrowerNoteSubject As String

    Public Property GrowerNoteMethod As Integer
    Public Property GrowerNoteText As String

    Public Property GrowerNoteCreationDate As Date
    Public Property GrowerNoteCreatedBy As Integer



End Class
Public Class Commodity
    Public Property CommID As String
    Public Property CommName As String
    Public Property CurrentCropYear As Decimal
    Public Property PreviousCropYear As Decimal

    Public Property Previous2CropYear As Decimal

End Class
Public Class Vendor
    Public Property VendorName As String
    Public Property VendorID As String
    Public Property CollCommodities As New Collection
End Class

Public Class Note
    Public Property GrowerId As Integer
    Public Property GrowerNoteId As Integer
    Public Property GrowerNoteSubject As String

    Public Property GrowerNoteMethod As Integer

    Public Property GrowerNoteText As String

    Public Property GrowerNoteCreationDate As Date
    Public Property GrowerNoteCreatedBy As Integer

End Class


Public Class GlobalVariables
    Public Shared UserId As Integer
    Public Shared UserFirstName As String
    Public Shared UserLastName As String
    Public Shared UserFacilities As New Collection
    Public Shared UserFacilityIDs As New Collection
    Public Shared CurrentGrowerID As Integer
    Public Shared GrowerFirstName As String
    Public Shared GrowerLastName As String
    Public Shared GrowerAddress1 As String
    Public Shared GrowerCity As String
    Public Shared GrowerState As String
    Public Shared GrowerZip As String
    Public Shared ResetNote As Boolean
    Public Shared CurrentNoteSubject As String
    Public Shared CurrentNoteText As String
    Public Shared CurrentNoteMethod As Integer
    Public Shared oVendorCollection As New Collection
    Public Shared Function DQuot(lsConvStr As String) As String
        Dim lsRetStr As String

        lsRetStr = Replace(lsConvStr, "'", "''")
        DQuot = lsRetStr
    End Function
End Class