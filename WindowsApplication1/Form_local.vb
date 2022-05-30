Imports System.Data
Imports System.Data.SqlClient


Public Class Form_local


    ' Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")

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


    Private Sub fillRapport_evel_immb()
        connection.Open()
        Dim query = "select * from dbo.Rapport_evaluation"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Cd_rapp_eval_immbComboBox.DataSource = tbl
        Cd_rapp_eval_immbComboBox.DisplayMember = "Cd_rapp_eval_immb"
        Cd_rapp_eval_immbComboBox.ValueMember = "Cd_rapp_eval_immb"
        connection.Close()

    End Sub


    Private Sub LocalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LocalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LocalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_local_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Rapport_evaluation' table. You can move, or remove it, as needed.
        Me.Rapport_evaluationTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Rapport_evaluation)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Beneficiaire' table. You can move, or remove it, as needed.
        Me.BeneficiaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Beneficiaire)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Local' table. You can move, or remove it, as needed.
        Me.LocalTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Local)
        'TODO: This line of code loads data from table beneficiare to comboBox   
        'fillBenefic()
        'TODO: This line of code loads data from table rapport_evaluation_immob to comboBox   
        ' fillRapport_evel_immb()
    End Sub

    Private Sub gestionbtn_Click(sender As Object, e As EventArgs) Handles rapp_eval_immbbtn.Click
        Form_Rapport_Evaluation.Show()
    End Sub

    Private Function connection() As SqlConnection
        Throw New NotImplementedException()
    End Function
End Class