Imports System.Text
Imports System.Security.Cryptography



Module Module_hash



    Public Function MD5(ByVal password As String) As String
        Dim MoLuCul3 As New Security.Cryptography.MD5CryptoServiceProvider

        Dim ByteSring() As Byte = System.Text.Encoding.ASCII.GetBytes(password)
        ByteSring = MoLuCul3.ComputeHash(ByteSring)

        Dim finalString As String = Nothing

        For Each bt As Byte In ByteSring
            finalString &= bt.ToString("x2")
        Next

        Return finalString
    End Function




End Module
