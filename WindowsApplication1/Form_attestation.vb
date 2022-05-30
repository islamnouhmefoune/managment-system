Imports System.Data
Imports System.Data.SqlClient


Public Class Form_attestation

    Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")

    Private Sub Attestation_paiemnet_loyerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Attestation_paiemnet_loyerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Attestation_paiemnet_loyerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub


    Private Sub fillDirecteur()
        conn.Open()
        Dim query = "select * from dbo.Beneficiaire"
        Dim cmd As New SqlCommand(query, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Cd_beneComboBox.DataSource = tbl
        Cd_beneComboBox.DisplayMember = "Cd_bene"
        Cd_beneComboBox.ValueMember = "Cd_bene"
        conn.Close()

    End Sub



    Private Sub Form_attestation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Attestation_paiemnet_loyer' table. You can move, or remove it, as needed.
        Me.Attestation_paiemnet_loyerTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Attestation_paiemnet_loyer)
        'TODO: This line of code loads data from table beneficiare to comboBox   
        fillDirecteur()
    End Sub
End Class