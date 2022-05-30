
Imports System.Data
Imports System.Data.SqlClient


Module Module_Connection
    Public conn As SqlConnection
    Public Function getconnect()
        conn = New SqlConnection("Data Source=ISLAMOUH-PC\SQLSERVER;Initial Catalog=droit_propriter_etat;Integrated Security=True")
        Return conn
    End Function
End Module
