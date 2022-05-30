Public Class Form_Rapport_Evaluation
    Private Sub Rapport_evaluationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Rapport_evaluationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Rapport_evaluationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_Rapport_Evaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Rapport_evaluation' table. You can move, or remove it, as needed.
        Me.Rapport_evaluationTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Rapport_evaluation)

    End Sub
End Class