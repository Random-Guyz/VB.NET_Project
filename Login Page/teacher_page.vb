Imports System.Data.SqlClient

Public Class teacher_page
    Dim con As New SqlConnection("Data Source=anonymous\SQLEXPRESS;Initial Catalog=COLLEGE_DATABASE;Integrated Security=True")
    Private Sub display()
        con.Open()
        Dim q = "select * from  [dbo].[Teacher]"
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
    Private Sub btn_Fees_Click(sender As Object, e As EventArgs) Handles btn_Fees.Click
        fees.Show()
        Me.Close()
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
        Form1.Close()
        Me.Close()
        LoginPage.Show()
    End Sub
    Private Sub btn_student_Click(sender As Object, e As EventArgs) Handles btn_student.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim con As New SqlConnection("Data Source=anonymous\SQLEXPRESS;Initial Catalog=COLLEGE_DATABASE;Integrated Security=True")
        Try
            con.Open()
            Dim q As String = "
            INSERT INTO [dbo].[Teacher] VALUES('" & t1.Text & "','" & t2.Text & "','" & t3.Text & "','" & t4.Text & "','" & t5.Text & "','" & t6.Text & "') "


            Dim cmd As New SqlCommand(q, con)
            cmd.ExecuteNonQuery()
            MsgBox("Teacher Data Saved")
            display()
            Reset()
            con.Close()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    Dim key = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        t1.Text = row.Cells(1).Value.ToString
        t2.Text = row.Cells(2).Value.ToString
        t3.Text = row.Cells(3).Value.ToString
        t4.Text = row.Cells(4).Value.ToString
        t5.Text = row.Cells(5).Value.ToString
        t6.Text = row.Cells(6).Value.ToString
        If t1.Text = " " Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub teacher_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
    End Sub
    Private Sub Reset()
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        t5.Text = ""
        t6.Text = ""
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t5.Text = "" Or t6.Text = "" Then
            MsgBox("Missing Info...!")
        Else
            Try
                con.Open()
                Dim q = "update  [dbo].[Teacher] set Tname = '" & t1.Text & "',Gender = '" & t2.Text & "',Dob = '" & t3.Text & "', Dep = '" & t4.Text & "',TAdd = '" & t5.Text & "', Phone = " & t6.Text & " where Tid = " & key & ""
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
            MsgBox("Select the Teacher")
        Else
            Try
                con.Open()
                Dim q = "delete from  [dbo].[Teacher] where Tid =" & key & ""
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
        Me.Hide()
        dashboard.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_teacher_Click(sender As Object, e As EventArgs) Handles btn_teacher.Click

    End Sub
End Class