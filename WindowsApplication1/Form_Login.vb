Imports System.Data
Imports System.Data.SqlClient



Public Class Form_Login

    'Dim conn As New SqlConnection("Data Source=ISLAMOUH-PC\SQLSERVER;Initial Catalog=droit_propriter_etat;Integrated Security=True")


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelBTN.Click
        Application.Exit()
    End Sub

    Private Sub loginBTN_Click(sender As Object, e As EventArgs) Handles loginBTN.Click
        If usernametxt.Text = "" Or passwordtxt.Text = "" Or typeCB.SelectedItem = "" Then
            MsgBox("Missing Information!!")
        Else
            Try
                conn = getconnect()
                conn.Open()
                Dim query = "select * from users where username='" & usernametxt.Text & "' and password ='" & MD5(passwordtxt.Text) & "' and type='" & typeCB.SelectedItem & "'"
                Dim cmd As New SqlCommand(query, conn)
                Dim sda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                sda.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    MessageBox.Show("Login success!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    form_dashboard.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Error!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Catch ex As Exception

            End Try


        End If


    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class