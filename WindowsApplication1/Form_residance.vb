
Imports System.Data
Imports System.Data.SqlClient




Public Class Form_residance


    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")





    'Private Sub fillQuartier()
    '    conn.Open()
    '    Dim query = "select * from dbo.Quartier"
    '    Dim cmd As New SqlCommand(query, conn)
    '    Dim adapter As New SqlDataAdapter(cmd)
    '    Dim tbl As New DataTable()
    '    adapter.Fill(tbl)
    '    Cd_QuartierComboBox.DataSource = tbl
    '    Cd_QuartierComboBox.DisplayMember = "Cd_Quartier"
    '    Cd_QuartierComboBox.ValueMember = "Cd_Quartier"
    '    conn.Close()

    'End Sub

    Private Sub ResidenceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ResidenceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ResidenceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_residance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Quartier' table. You can move, or remove it, as needed.
        Me.QuartierTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Quartier)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Residence' table. You can move, or remove it, as needed.
        Me.ResidenceTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Residence)

        'TODO: This line of code loads data from table Quartier to comboBox   
        'fillQuartier()

    End Sub
End Class