Imports Microsoft.EntityFrameworkCore
Imports System.Collections.Generic

Public Class DoKUser
    Public Property UserName As String
    Public Property ScreenName As String
    Public Property DateCreated As DateTime
End Class

Public Class DoKUserContext Inherits DbContext