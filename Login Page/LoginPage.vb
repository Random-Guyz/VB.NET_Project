Public Class LoginPage

    Private Sub btn_sign_Click(sender As Object, e As EventArgs) Handles btn_sign.Click
        Dim usr As String = txt_username.Text
        Dim pass As String = txt_password.Text

        If usr = "Admin" And pass = "1234" Then
            MsgBox("Login Successful")
            Me.Hide()
            dashboard.Show()
        Else
            MsgBox("Username or password incorrect")
        End If

    End Sub

    Private Sub btn_sign_MouseEnter(sender As Object, e As EventArgs) Handles btn_sign.MouseEnter
        btn_sign.FillColor = Color.Black
    End Sub

    Private Sub btn_sign_MouseLeave(sender As Object, e As EventArgs) Handles btn_sign.MouseLeave
        btn_sign.FillColor = Color.Lime
    End Sub


    Private Sub LoginArtwork_Click(sender As Object, e As EventArgs) Handles LoginArtwork.Click

    End Sub


    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txt_password.PasswordChar = "*"
        Else
            txt_password.PasswordChar = ""
        End If
    End Sub
End Class
