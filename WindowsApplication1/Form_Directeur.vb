Public Class Form_Directeur
    Private Sub DirecteurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DirecteurBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DirecteurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_Directeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Directeur' table. You can move, or remove it, as needed.
        Me.DirecteurTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Directeur)

    End Sub
End Class