Imports System.Data
Imports System.Data.SqlClient


Public Class Form_Pv_commisio_cess

    ' Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")
    Private Function connection() As SqlConnection
        Throw New NotImplementedException()
    End Function
    Private Sub fillCommission_cession_immobiliere()
        connection.Open()
        Dim query = "select * from dbo.Commission_cession_immobiliere"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Cd_comi_reno_immbComboBox.DataSource = tbl
        Cd_comi_reno_immbComboBox.DisplayMember = "Cd_comi_reno_immb"
        Cd_comi_reno_immbComboBox.ValueMember = "Cd_comi_reno_immb"
        connection.Close()

    End Sub


    Private Sub PV_Commession_CessionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PV_Commession_CessionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PV_Commession_CessionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_Pv_commisio_cess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Commission_cession_immobiliere' table. You can move, or remove it, as needed.
        Me.Commission_cession_immobiliereTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Commission_cession_immobiliere)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.PV_Commession_Cession' table. You can move, or remove it, as needed.
        Me.PV_Commession_CessionTableAdapter.Fill(Me.Droit_propriter_etatDataSet.PV_Commession_Cession)
        'TODO: This line of code loads data from table Commission_cession_immobiliere to comboBox   
        ' fillCommission_cession_immobiliere()
    End Sub

    Private Sub pv_commibtn_Click(sender As Object, e As EventArgs) Handles pv_commibtn.Click
        Form_Demande.Show()
    End Sub
End Class