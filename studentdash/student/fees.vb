Public Class fees
    Private Sub btn_Pay_MouseEnter(sender As Object, e As EventArgs) Handles btn_Pay.MouseEnter
        btn_Pay.FillColor = Color.Black
    End Sub

    Private Sub btn_Pay_MouseLeave(sender As Object, e As EventArgs) Handles btn_Pay.MouseLeave
        btn_Pay.FillColor = Color.Lime
    End Sub

    Private Sub btn_Edit_MouseEnter(sender As Object, e As EventArgs) Handles btn_Edit.MouseEnter
        btn_Edit.FillColor = Color.Black
    End Sub

    Private Sub btn_Edit_MouseLeave(sender As Object, e As EventArgs) Handles btn_Edit.MouseLeave
        btn_Edit.FillColor = Color.Lime
    End Sub

    Private Sub btn_cancel_MouseEnter(sender As Object, e As EventArgs) Handles btn_cancel.MouseEnter
        btn_cancel.FillColor = Color.Black
    End Sub

    Private Sub btn_cancel_MouseLeave(sender As Object, e As EventArgs) Handles btn_cancel.MouseLeave
        btn_cancel.FillColor = Color.Lime
    End Sub

    Private Sub btn_signout_MouseEnter(sender As Object, e As EventArgs) Handles btn_signout.MouseEnter
        btn_signout.FillColor = Color.Black
    End Sub

    Private Sub btn_signout_MouseLeave(sender As Object, e As EventArgs) Handles btn_signout.MouseLeave
        btn_signout.FillColor = Color.Lime
    End Sub

    Private Sub btn_dashboard_MouseEnter(sender As Object, e As EventArgs) Handles btn_dashboard.MouseEnter
        btn_dashboard.FillColor = Color.Lime
        btn_dashboard.ForeColor = Color.White
    End Sub

    Private Sub btn_dashboard_MouseLeave(sender As Object, e As EventArgs) Handles btn_dashboard.MouseLeave
        btn_dashboard.FillColor = Color.White
        btn_dashboard.ForeColor = Color.Gray
    End Sub

    Private Sub btn_student_MouseEnter(sender As Object, e As EventArgs) Handles btn_student.MouseEnter
        btn_student.FillColor = Color.Lime
        btn_student.ForeColor = Color.White
    End Sub

    Private Sub btn_student_MouseLeave(sender As Object, e As EventArgs) Handles btn_student.MouseLeave
        btn_student.FillColor = Color.White
        btn_student.ForeColor = Color.Gray
    End Sub

    Private Sub btn_student_Click(sender As Object, e As EventArgs) Handles btn_student.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btn_signout_Click(sender As Object, e As EventArgs) Handles btn_signout.Click
        dashboard.Close()
    End Sub

    Private Sub btn_teacher_Click(sender As Object, e As EventArgs) Handles btn_teacher.Click
        Me.Hide()
        teacher_page.Show()
    End Sub

    Private Sub btn_teacher_MouseEnter(sender As Object, e As EventArgs) Handles btn_teacher.MouseEnter
        btn_teacher.FillColor = Color.Lime
        btn_teacher.ForeColor = Color.White
    End Sub

    Private Sub btn_teacher_MouseLeave(sender As Object, e As EventArgs) Handles btn_teacher.MouseLeave
        btn_teacher.FillColor = Color.White
        btn_teacher.ForeColor = Color.Gray
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        dashboard.Show()
        Me.Close()
    End Sub
End Class