Imports System.Data
Imports System.Data.SqlClient


Public Class Form_beneficiare

    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")

    Private Sub fillResidance()
        connection.Open()
        Dim query = "select * from dbo.Residence"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Residence_cd_residenceComboBox.DataSource = tbl
        Residence_cd_residenceComboBox.DisplayMember = "Cd_residence"
        Residence_cd_residenceComboBox.ValueMember = "Cd_residence"
        connection.Close()

    End Sub



    Private Sub BeneficiaireBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BeneficiaireBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BeneficiaireBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_beneficiare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Residence' table. You can move, or remove it, as needed.
        Me.ResidenceTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Residence)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Beneficiaire' table. You can move, or remove it, as needed.
        Me.BeneficiaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Beneficiaire)
        'TODO: This line of code loads data from table Residance to comboBox   
        '  fillResidance()
    End Sub
    Private Function connection() As SqlConnection
        Throw New NotImplementedException()
    End Function

End Class