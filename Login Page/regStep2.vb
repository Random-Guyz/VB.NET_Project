Public Class regStep2
    Private Sub btn_next2_MouseEnter(sender As Object, e As EventArgs)
        btn_next2.FillColor = Color.Black
    End Sub

    Private Sub btn_next2_MouseLeave(sender As Object, e As EventArgs) Handles btn_next2.MouseLeave
        btn_next2.FillColor = Color.Lime
    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
        If txt_phone.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_next2_Click(sender As Object, e As EventArgs) Handles btn_next2.Click
        If txt_Course.Text = "" And txt_phone.Text = "" And txt_sem.Text = "" Then
            MsgBox("You must fill the form!")
        Else
            Me.Hide()
            step3.Show()
        End If
    End Sub
End Class