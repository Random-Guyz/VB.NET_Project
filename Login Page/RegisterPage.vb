Public Class registerform

    Private Sub link_signin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_signin.LinkClicked
        Me.Close()
        LoginPage.Show()
    End Sub

    Private Sub btn_next1_Click(sender As Object, e As EventArgs) Handles btn_next1.Click
        If txt_firstname.Text = "" And txt_lastname.Text = "" Then
            MsgBox("You must fill the form!")
        Else
            Me.Hide()
            regStep2.Show()

        End If
    End Sub

    Private Sub btn_next1_MouseLeave(sender As Object, e As EventArgs) Handles btn_next1.MouseLeave
        btn_next1.FillColor = Color.Lime
    End Sub

    Private Sub btn_next1_MouseEnter_1(sender As Object, e As EventArgs) Handles btn_next1.MouseEnter
        btn_next1.FillColor = Color.Black
    End Sub

    Private Sub registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class