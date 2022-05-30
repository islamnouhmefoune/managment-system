Imports System.Data
Imports System.Data.SqlClient





Public Class Form_droit_pro_etat

    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")
    Private Function connection() As SqlConnection
        Throw New NotImplementedException()
    End Function
    Private Sub fillBenefic()
        connection.Open()
        Dim query = "select * from dbo.Beneficiaire"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Beneficiaire_cd_beneComboBox.DataSource = tbl
        Beneficiaire_cd_beneComboBox.DisplayMember = "Cd_bene"
        Beneficiaire_cd_beneComboBox.ValueMember = "Cd_bene"
        connection.Close()

    End Sub


    Private Sub Droits_de_propriete_de_etatBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Droits_de_propriete_de_etatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Droits_de_propriete_de_etatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_droit_pro_etat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Beneficiaire' table. You can move, or remove it, as needed.
        Me.BeneficiaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Beneficiaire)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Droits_de_propriete_de_etat' table. You can move, or remove it, as needed.
        Me.Droits_de_propriete_de_etatTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Droits_de_propriete_de_etat)
        'TODO: This line of code loads data from table beneficiare to comboBox   
        'fillBenefic()
    End Sub
End Class