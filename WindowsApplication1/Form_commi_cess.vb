Public Class Form_commi_cess
    Private Sub Commission_cession_immobiliereBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Commission_cession_immobiliereBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Commission_cession_immobiliereBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_commi_cess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Commission_cession_immobiliere' table. You can move, or remove it, as needed.
        Me.Commission_cession_immobiliereTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Commission_cession_immobiliere)

    End Sub

    Private Sub pv_commibtn_Click(sender As Object, e As EventArgs) Handles pv_commibtn.Click
        Form_Pv_commisio_cess.Show()
    End Sub
End Class