Public Class form_dashboard
    Private Sub Beneficiairebtn_Click(sender As Object, e As EventArgs) Handles Beneficiairebtn.Click
        Form_beneficiare.Show()
    End Sub

    Private Sub localbtn_Click(sender As Object, e As EventArgs) Handles localbtn.Click
        Form_local.Show()
    End Sub

    Private Sub engag_achabtn_Click(sender As Object, e As EventArgs) Handles engag_achabtn.Click
        Form_certificate_engag_achat.Show()
    End Sub

    Private Sub attes_paie_loyerbtn_Click(sender As Object, e As EventArgs) Handles attes_paie_loyerbtn.Click
        Form_attestation.Show()
    End Sub

    Private Sub Residancebtn_Click(sender As Object, e As EventArgs) Handles Residancebtn.Click
        Form_residance.Show()
    End Sub

    Private Sub wilayabtn_Click(sender As Object, e As EventArgs) Handles wilayabtn.Click
        Form_wilaya.Show()
    End Sub

    Private Sub echen_versbtn_Click(sender As Object, e As EventArgs) Handles echen_versbtn.Click
        Form_echencer_verse.Show()
    End Sub

    Private Sub echn_val_inbtn_Click(sender As Object, e As EventArgs) Handles echn_val_inbtn.Click
        Form_echenc_paie_initial.Show()
    End Sub

    Private Sub echn_droit_probtn_Click(sender As Object, e As EventArgs) Handles echn_droit_probtn.Click
        Form_droit_pro_etat.Show()
    End Sub

    Private Sub commi_cessbtn_Click(sender As Object, e As EventArgs) Handles commi_cessbtn.Click
        Form_commi_cess.Show()
    End Sub

    Private Sub arrete_cessbtn_Click(sender As Object, e As EventArgs) Handles arrete_cessbtn.Click
        Form_arrete_cess.Show()
    End Sub
End Class
