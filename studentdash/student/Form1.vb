Public Class Form1
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

    Private Sub btn_Fees_MouseEnter(sender As Object, e As EventArgs) Handles btn_Fees.MouseEnter
        btn_Fees.FillColor = Color.Lime
        btn_Fees.ForeColor = Color.White
    End Sub

    Private Sub btn_Fees_MouseLeave(sender As Object, e As EventArgs) Handles btn_Fees.MouseLeave
        btn_Fees.FillColor = Color.White
        btn_Fees.ForeColor = Color.Gray
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles btn_Fees.Click
        Me.Hide()
        fees.Show()
    End Sub

    Private Sub btn_save_MouseEnter(sender As Object, e As EventArgs) Handles btn_save.MouseEnter
        btn_save.FillColor = Color.Black
    End Sub

    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_save.MouseLeave
        btn_save.FillColor = Color.Lime
    End Sub

    Private Sub btn_del_MouseEnter(sender As Object, e As EventArgs) Handles btn_del.MouseEnter
        btn_del.FillColor = Color.Black
    End Sub

    Private Sub btn_del_MouseLeave(sender As Object, e As EventArgs) Handles btn_del.MouseLeave
        btn_del.FillColor = Color.Lime
    End Sub

    Private Sub btn_edit_MouseEnter(sender As Object, e As EventArgs) Handles btn_edit.MouseEnter
        btn_edit.FillColor = Color.Black
    End Sub

    Private Sub btn_edit_MouseLeave(sender As Object, e As EventArgs) Handles btn_edit.MouseLeave
        btn_edit.FillColor = Color.Lime
    End Sub

    Private Sub btn_reset_MouseEnter(sender As Object, e As EventArgs) Handles btn_reset.MouseEnter
        btn_reset.FillColor = Color.Black
    End Sub

    Private Sub btn_reset_MouseLeave(sender As Object, e As EventArgs) Handles btn_reset.MouseLeave
        btn_reset.FillColor = Color.Lime
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
        Me.Close()
        dashboard.Show()
    End Sub
End Class
