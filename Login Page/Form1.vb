Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class Form1
    Dim con As New SqlConnection("Data Source=anonymous\SQLEXPRESS;Initial Catalog=COLLEGE_DATABASE;Integrated Security=True")
    Private Sub display()
        con.Open()
        Dim q = "select * from  [dbo].[student]"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(q, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
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

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles s3.ValueChanged

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim con As New SqlConnection("Data Source=anonymous\SQLEXPRESS;Initial Catalog=COLLEGE_DATABASE;Integrated Security=True")
        Try
            con.Open()
            Dim q As String = "
            INSERT INTO [dbo].[student] VALUES('" & s1.Text & "','" & s2.Text & "','" & s3.Text & "','" & s4.Text & "','" & s5.Text & "','" & s6.Text & "') "


            Dim cmd As New SqlCommand(q, con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Data Saved")
            display()
            Reset()
            con.Close()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub txt_Name_TextChanged(sender As Object, e As EventArgs) Handles s1.TextChanged

    End Sub
    Dim key = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        s1.Text = row.Cells(1).Value.ToString
        s2.Text = row.Cells(2).Value.ToString
        s3.Text = row.Cells(3).Value.ToString
        s4.Text = row.Cells(4).Value.ToString
        s5.Text = row.Cells(5).Value.ToString
        s6.Text = row.Cells(6).Value.ToString
        If s1.Text = " " Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
    End Sub
    Private Sub Reset()
        s1.Text = ""
        s2.Text = ""
        s3.Text = ""
        s4.Text = ""
        s5.Text = ""
        s6.Text = ""
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If s1.Text = "" Or s2.Text = "" Or s3.Text = "" Or s4.Text = "" Or s5.Text = "" Or s6.Text = "" Then
            MsgBox("Missing Info...!")
        Else
            Try
                con.Open()
                Dim q = "update  [dbo].[student] set stname ='" & s1.Text & "',stdep ='" & s2.Text & "',dob ='" & s3.Text & "',fees ='" & s4.Text & "',gender ='" & s5.Text & "',phone =" & s6.Text & " where stid =" & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(q, con)
                cmd.ExecuteNonQuery()
                MsgBox("Details Updated Successfully")
                con.Close()
                display()
                Reset()

            Catch ex As Exception
                MsgBox("error")
            End Try
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If key = 0 Then
            MsgBox("Select the student")
        Else
            Try
                con.Open()
                Dim q = "delete from  [dbo].[student] where stid =" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(q, con)
                cmd.ExecuteNonQuery()
                MsgBox("Details Deleted Successfully")
                con.Close()
                display()
                Reset()

            Catch ex As Exception
                MsgBox("error")
            End Try
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Reset()
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub s5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s5.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub noofdue()
        con.Open()
        Dim q = "select * from  [dbo].[student] where fees < 20000 "
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(q, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub NoDueList_Click(sender As Object, e As EventArgs) Handles NoDueList.Click
        noofdue()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        display()
    End Sub
End Class

