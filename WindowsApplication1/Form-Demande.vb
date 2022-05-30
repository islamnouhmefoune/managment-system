Imports System.Data
Imports System.Data.SqlClient



Public Class Form_Demande


    ' Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")

    Private Sub fillPV_Commession_Cession()
        connection.Open()
        Dim query = "select * from dbo.PV_Commession_Cession"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Cd_Pv_com_cessComboBox.DataSource = tbl
        Cd_Pv_com_cessComboBox.DisplayMember = "Cd_Pv_com_cess"
        Cd_Pv_com_cessComboBox.ValueMember = "Cd_Pv_com_cess"
        connection.Close()

    End Sub


    Private Sub fillArrete_cession_bien_etat()
        connection.Open()
        Dim query = "select * from dbo.Arrete_cession_bien_etat"
        Dim cmd As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        N_rapp_ren_immbComboBox.DataSource = tbl
        N_rapp_ren_immbComboBox.DisplayMember = "N_rapp_ren_immb"
        N_rapp_ren_immbComboBox.ValueMember = "N_rapp_ren_immb"
        connection.Close()

    End Sub


    Private Sub Demande_acquisitionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Demande_acquisitionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Demande_acquisitionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_Demande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Arrete_cession_bien_etat' table. You can move, or remove it, as needed.
        Me.Arrete_cession_bien_etatTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Arrete_cession_bien_etat)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.PV_Commession_Cession' table. You can move, or remove it, as needed.
        Me.PV_Commession_CessionTableAdapter.Fill(Me.Droit_propriter_etatDataSet.PV_Commession_Cession)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Demande_acquisition' table. You can move, or remove it, as needed.
        Me.Demande_acquisitionTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Demande_acquisition)
        'TODO: This line of code loads data from table Arrete_cession_bien_etat to comboBox   
        'fillArrete_cession_bien_etat()
        'TODO: This line of code loads data from table PV_Commession_Cession to comboBox   
        ' fillPV_Commession_Cession()
    End Sub


    Private Function connection() As SqlConnection
        Throw New NotImplementedException()
    End Function
End Class