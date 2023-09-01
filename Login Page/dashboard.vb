Imports System.Data.SqlClient
Public Class dashboard
    Dim con As New SqlConnection("Data Source=anonymous\SQLEXPRESS;Initial Catalog=COLLEGE_DATABASE;Integrated Security=True")
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
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_signout_Click(sender As Object, e As EventArgs) Handles btn_signout.Click
        Me.Close()
        LoginPage.Show()
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

    Private Sub btn_Fees_MouseEnter(sender As Object, e As EventArgs) Handles btn_Fees.MouseEnter
        btn_Fees.FillColor = Color.Lime
        btn_Fees.ForeColor = Color.White
    End Sub

    Private Sub btn_Fees_MouseLeave(sender As Object, e As EventArgs) Handles btn_Fees.MouseLeave
        btn_Fees.FillColor = Color.White
        btn_Fees.ForeColor = Color.Gray
    End Sub

    Private Sub btn_Fees_Click(sender As Object, e As EventArgs) Handles btn_Fees.Click
        fees.Show()
        Me.Hide()
    End Sub
    Private Sub counts()
        Dim sn As Integer
        con.Open()
        Dim q = "select COUNT(*) from [dbo].[student]"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(q, con)
        sn = cmd.ExecuteScalar
        d1.Text = sn
        con.Close()
    End Sub
    Private Sub tteach()
        Dim st As Integer
        con.Open()
        Dim q = "select COUNT(*) from [dbo].[Teacher]"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(q, con)
        st = cmd.ExecuteScalar
        d2.Text = st
        con.Close()
    End Sub
    Private Sub cdep()
        Dim sd As Integer
        con.Open()
        Dim q = "select COUNT(distinct stdep) from [dbo].[student]"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(q, con)
        sd = cmd.ExecuteScalar
        d3.Text = sd
        con.Close()
    End Sub

    Private Sub feescal()
        Dim sf As Integer
        con.Open()
        Dim q = "select sum(Amt) from [dbo].[fees]"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(q, con)
        sf = cmd.ExecuteScalar
        Dim am As String
        am = Convert.ToString(sf)
        d4.Text = "₹ " + am
        con.Close()
    End Sub
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counts()
        feescal()
        tteach()
        cdep()
    End Sub
End Class