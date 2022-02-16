﻿Public Class Grower

    Public Property GrowerID As Integer
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
    Public Property GrowerFax As String
    Public Property GrowerEmail As String
    Public Property GrowerProspect As String
    Public Property GrowerComment As String

    Public Property Vendors As New Collection
    Public Property Notes As New Collection
    Public Property OtherCrops As New Collection




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
    Public Property GrowerFax As String
    Public Property GrowerEmail As String
    Public Property GrowerComment As String
    Public Property VendorName As String
    Public Property VendorDummy As String
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
Public Class IndexedGrowerListItem
    Public Property CollectionIndex As Integer
    Public Property GrowerName As String

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
    Public Property VendorID As Integer
    Public Property VendorDummy As String
    Public Property CollCommodities As New Collection
End Class


Public Class NonCGI
    Public Property NonCGICropID As Integer
    Public Property UpdatedDate As Date
    Public Property NonCGICommodity As String
    Public Property Status As String
    Public Property SoldTo As String
    Public Property Volume As Integer
    Public Property Location As String

End Class


Public Class Note
    Public Property GrowerId As Integer
    Public Property GrowerNoteId As Integer
    Public Property GrowerNoteSubject As String

    Public Property GrowerNoteMethod As Integer
    Public Property GrowerNoteMethodText As String

    Public Property GrowerNoteText As String

    Public Property GrowerNoteCreationDate As Date
    Public Property GrowerNoteCreatedBy As Integer
    Public Property GrowerNoteCreatedByLogin As String

End Class
Public Class ProspectRec
    Public Property GrowerID As Integer
    Public Property VendorID As Integer
    Public Property GrowerFirstName As String
    Public Property GrowerLastName As String

    Public Property GrowerAddress As String
    Public Property GrowerAddress2 As String
    Public Property GrowerCity As String
    Public Property GrowerState As String
    Public Property GrowerZip As String
    Public Property GrowerCountry As String
    Public Property GrowerPhone1 As String
    Public Property GrowerPhone2 As String
    Public Property GrowerFax As String
    Public Property GrowerEmail As String
    Public Property GrowerComment As String
    Public Property VendorName As String
    Public Property GrowerNoteID As Integer

    Public Property GrowerNoteSubject As String
    Public Property GrowerNoteMethod As Integer
    Public Property GrowerNoteMethodText As String
    Public Property GrowerNoteText As String
    Public Property GrowerNoteCreationDate As DateTime
    Public Property GrowerNoteCreatedBy As Integer
    Public Property GrowerNoteCreatedByLogin As String
    Public Property VendorDummy As String



End Class

Public Class NonCGIRec
    Public Property GrowerID As Integer
    Public Property nonCGIcrop_id As Integer
    Public Property CommodityID As String
    Public Property Status As String
    Public Property Volume As Integer
    Public Property SoldTo As String
    Public Property UpdatedDate As Date
    Public Property Location As String
End Class

Public Class ProspectNotesRec
    Public Property GrowerID As Integer
    Public Property GrowerNoteID As Integer

    Public Property GrowerNoteSubject As String
    Public Property GrowerNoteMethod As Integer
    Public Property GrowerNoteMethodText As String
    Public Property GrowerNoteText As String
    Public Property GrowerNoteCreationDate As DateTime
    Public Property GrowerNoteCreatedBy As Integer
    Public Property GrowerNoteCreatedByLogin As String

End Class
Public Class State
    Public Property StateID As String
    Public Property StateName As String
End Class

Public Class Province
    Public Property ProvinceID As String
    Public Property ProvinceName As String
End Class

Public Class Country
    Public Property CountryID As String
    Public Property CountryName As String
End Class
Public Class NoteListItem
    Public Property CreateDate As String
    Public Property NoteText As String
End Class
Public Class GlobalVariables
    Public Shared bGrowerAdd As Boolean
    Public Shared oFrmBackground As Form
    Public Shared bFirstLoad As Boolean
    Public Shared UserList As New Collection
    Public Shared VendorList As New Collection
    Public Shared ImpLogin As String
    Public Shared UserId As Integer
    Public Shared CurrentUserLogin As String
    Public Shared CurrentUserRole As Integer
    Public Shared CurrentUVDID As Integer
    Public Shared EditedGrower As Boolean
    Public Shared UserFirstName As String
    Public Shared UserLastName As String
    Public Shared UserFacilities As New Collection
    Public Shared UserFacilityIDs As New Collection
    Public Shared CurrentGrowerID As Integer
    Public Shared CurrentGrower As Grower
    Public Shared GrowerFirstName As String
    Public Shared GrowerLastName As String
    Public Shared GrowerAddress1 As String
    Public Shared GrowerCity As String
    Public Shared GrowerState As String
    Public Shared GrowerZip As String
    Public Shared ResetNote As Boolean
    Public Shared ResetGrower As Boolean
    Public Shared BuildComm As Boolean
    Public Shared BuildNonCGI As Boolean
    Public Shared CurrentNoteSubject As String
    Public Shared CurrentNoteText As String
    Public Shared CurrentNoteMethod As Integer
    Public Shared CurrentNoteMethodText As String
    Public Shared CurrentNoteCreationDate As DateTime
    Public Shared oVendorCollection As New Collection
    Public Shared iAddedGrowerID As Integer
    Public Shared iAddedVendorID As Integer
    Public Shared CurrentNonCGIID As Integer
    Public Shared CurrentOtherCropIndex As Integer
    Public Shared sEnv As String
    Public Shared MainLoaded As Boolean
    Public Shared Function DQuot(lsConvStr As String) As String
        Dim lsRetStr As String

        lsRetStr = Replace(lsConvStr, "'", "''")
        DQuot = lsRetStr
    End Function
End Class