Imports System.Data
Imports System.Data.SqlClient




Public Class Form_wilaya

    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLEXPRESS;Initial Catalog=droit_propriter_etat;Integrated Security=True")

    'Private Sub fillWilaya()
    '    conn.Open()
    '    Dim query = "select * from dbo.Wilaya"
    '    Dim cmd As New SqlCommand(query, conn)
    '    Dim adapter As New SqlDataAdapter(cmd)
    '    Dim tbl As New DataTable()
    '    adapter.Fill(tbl)
    '    Cd_wilayaComboBox.DataSource = tbl
    '    Cd_wilayaComboBox.DisplayMember = "Cd_wilaya"
    '    Cd_wilayaComboBox.ValueMember = "Cd_wilaya"
    '    conn.Close()

    'End Sub


    'Private Sub fillDaira()
    '    conn.Open()
    '    Dim query = "select * from dbo.Daira"
    '    Dim cmd As New SqlCommand(query, conn)
    '    Dim adapter As New SqlDataAdapter(cmd)
    '    Dim tbl As New DataTable()
    '    adapter.Fill(tbl)
    '    Cd_dairaComboBox.DataSource = tbl
    '    Cd_dairaComboBox.DisplayMember = "Cd_daira"
    '    Cd_dairaComboBox.ValueMember = "Cd_daira"
    '    conn.Close()

    'End Sub


    'Private Sub fillCommune()
    '    conn.Open()
    '    Dim query = "select * from dbo.Commune"
    '    Dim cmd As New SqlCommand(query, conn)
    '    Dim adapter As New SqlDataAdapter(cmd)
    '    Dim tbl As New DataTable()
    '    adapter.Fill(tbl)
    '    Cd_communeComboBox.DataSource = tbl
    '    Cd_communeComboBox.DisplayMember = "Cd_commune"
    '    Cd_communeComboBox.ValueMember = "Cd_commune"
    '    conn.Close()

    'End Sub



    Private Sub WilayaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WilayaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_wilaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Quartier' table. You can move, or remove it, as needed.
        Me.QuartierTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Quartier)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Commune' table. You can move, or remove it, as needed.
        Me.CommuneTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Commune)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Commission_cession_immobiliere' table. You can move, or remove it, as needed.
        Me.DairaTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Daira)
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Wilaya' table. You can move, or remove it, as needed.
        Me.WilayaTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Wilaya)
        'TODO: This line of code loads data from table beneficiare to comboBox   
        ' fillCommune()
        'TODO: This line of code loads data from table Directeur to comboBox   
        'fillDaira()
        'TODO: This line of code loads data from table beneficiare to comboBox   
        'fillWilaya()

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStrip_Wilaya.Click
        Me.Validate()
        Me.WilayaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub SaveToolStripButton1_Click(sender As Object, e As EventArgs) Handles SaveToolStrip_Daira.Click
        Me.Validate()
        Me.DairaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)
    End Sub




    Private Sub SaveToolStripButton3_Click(sender As Object, e As EventArgs) Handles SaveToolStrip_Commune.Click
        Me.Validate()
        Me.CommuneBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)
    End Sub

    Private Sub SaveToolStripButton2_Click(sender As Object, e As EventArgs) Handles SaveToolStrip_Quartier.Click
        Me.Validate()
        Me.QuartierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)
    End Sub
End Class