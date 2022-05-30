Public Class Form_gestionnier
    Private Sub GestionnaireBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GestionnaireBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GestionnaireBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_gestionnier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Gestionnaire' table. You can move, or remove it, as needed.
        Me.GestionnaireTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Gestionnaire)

    End Sub
End Class