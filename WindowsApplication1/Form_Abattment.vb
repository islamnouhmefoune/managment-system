Public Class Form_Abattment
    Private Sub AbattementBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AbattementBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AbattementBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Droit_propriter_etatDataSet)

    End Sub

    Private Sub Form_Abattment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Droit_propriter_etatDataSet.Abattement' table. You can move, or remove it, as needed.
        Me.AbattementTableAdapter.Fill(Me.Droit_propriter_etatDataSet.Abattement)

    End Sub
End Class