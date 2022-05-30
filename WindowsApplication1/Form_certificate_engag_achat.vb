Imports System.Data
Imports System.Data.SqlClient


Public Class Form_certificate_engag_achat

    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")
    Private Function connection() As SqlConnection
        Throw New NotImplementedException()
    End Function

    Private Sub fillbenific()
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

    Private Sub fillGestionnier()
        connection.Open()
        Dim query = "select * from dbo.Gestionnaire"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Cd_gestionComboBox.DataSource = tbl
        Cd_gestionComboBox.DisplayMember = "Cd_gestion"
        Cd_gestionComboBox.ValueMember = "Cd_gestion"
        connection.Close()

    End Sub





    Private Sub Certificat_engagement_achatBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Certificat_engagement_achatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Certificat_engagement_achatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_certificate_engag_achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Gestionnaire' table. You can move, or remove it, as needed.
        Me.GestionnaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Gestionnaire)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Beneficiaire' table. You can move, or remove it, as needed.
        Me.BeneficiaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Beneficiaire)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Certificat_engagement_achat' table. You can move, or remove it, as needed.
        Me.Certificat_engagement_achatTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Certificat_engagement_achat)
        'TODO: This line of code loads data from table beneficiare to comboBox   
        'fillbenific()
        'TODO: This line of code loads data from table Gestionnier to comboBox   
        ' fillGestionnier()
    End Sub

    Private Sub gestionbtn_Click(sender As Object, e As EventArgs) Handles gestionbtn.Click
        Form_gestionnier.Show()
    End Sub
End Class