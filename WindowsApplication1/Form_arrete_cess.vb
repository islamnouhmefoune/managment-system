Imports System.Data
Imports System.Data.SqlClient




Public Class Form_arrete_cess

    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")

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


    Private Sub fillDirecteur()
        connection.Open()
        Dim query = "select * from dbo.Directeur"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Cd_direc_ComboBox.DataSource = tbl
        Cd_direc_ComboBox.DisplayMember = "Cd_direc_"
        Cd_direc_ComboBox.ValueMember = "Cd_direc_"
        connection.Close()

    End Sub

    Private Sub Arrete_cession_bien_etatBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Arrete_cession_bien_etatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Arrete_cession_bien_etatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_arrete_cess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Directeur' table. You can move, or remove it, as needed.
        Me.DirecteurTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Directeur)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Beneficiaire' table. You can move, or remove it, as needed.
        Me.BeneficiaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Beneficiaire)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Arrete_cession_bien_etat' table. You can move, or remove it, as needed.
        Me.Arrete_cession_bien_etatTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Arrete_cession_bien_etat)

        'TODO: This line of code loads data from table beneficiare to comboBox   
        'fillBenefic()
        'TODO: This line of code loads data from table Directeur to comboBox   
        'fillDirecteur()




    End Sub


    Private Function connection() As SqlConnection
        Throw New NotImplementedException()
    End Function

    Private Sub directeurbtn_Click(sender As Object, e As EventArgs) Handles directeurbtn.Click
        Form_Directeur.Show()
    End Sub
End Class