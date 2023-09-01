Public Class step3
    Private Sub btn_next3_Click(sender As Object, e As EventArgs) Handles btn_next3.Click
        If txt_createPass.Text IsNot txt_confirmPass.Text Then
            MsgBox("Password does not match")
        End If
        LoginPage.show()
    End Sub

    Private Sub step3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class