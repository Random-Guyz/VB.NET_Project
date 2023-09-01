Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class fees
    Dim con As New SqlConnection("Data Source=anonymous\SQLEXPRESS;Initial Catalog=COLLEGE_DATABASE;Integrated Security=True")
    Private Sub fillst()
        con.Open()
        Dim q As String = "select * from  [dbo].[student]"
        Dim cmd As New SqlCommand(q, con)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adp.Fill(tbl)
        f1.DataSource = tbl
        f1.DisplayMember = "stid"
        f1.ValueMember = "stid"
        con.Close()

    End Sub

    Private Sub display()
        con.Open()
        Dim q = "select * from  [dbo].[fees]"
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

    Private Sub btn_Pay_MouseEnter(sender As Object, e As EventArgs) Handles btn_Pay.MouseEnter
        btn_Pay.FillColor = Color.Black
    End Sub

    Private Sub btn_Pay_MouseLeave(sender As Object, e As EventArgs) Handles btn_Pay.MouseLeave
        btn_Pay.FillColor = Color.Lime
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
        Me.Close()
        LoginPage.Show()
    End Sub

    Private Sub btn_teacher_Click(sender As Object, e As EventArgs) Handles btn_teacher.Click
        Me.Close()
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

    Private Sub dateTime_ValueChanged(sender As Object, e As EventArgs) Handles f4.ValueChanged

    End Sub

    Private Sub txt_StdId_TextChanged(sender As Object, e As EventArgs) Handles f2.TextChanged

    End Sub

    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles f3.TextChanged

    End Sub

    Private Sub f1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub getstname()
        con.Open()
        Dim q As String = "select * from [dbo].[student] where stid = '" & f1.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(q, con)

        Dim dt As New DataTable
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read
            f2.Text = dr(1).ToString()
        End While
        con.Close()
    End Sub
    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        Dim con As New SqlConnection("Data Source=anonymous\SQLEXPRESS;Initial Catalog=COLLEGE_DATABASE;Integrated Security=True")
        Try
            con.Open()
            Dim q As String = "
            INSERT INTO [dbo].[fees] VALUES('" & f1.Text & "','" & f2.Text & "','" & f3.Text & "','" & f4.Text & "') "


            Dim cmd As New SqlCommand(q, con)
            cmd.ExecuteNonQuery()
            MsgBox("Fees Paid Successfully")
            display()
            upstd()
            con.Close()

            Reset()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    Dim key = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        f1.Text = row.Cells(1).Value.ToString
        f2.Text = row.Cells(2).Value.ToString
        f3.Text = row.Cells(3).Value.ToString
        f4.Text = row.Cells(4).Value.ToString

        If f1.Text = " " Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
        fillst()
    End Sub
    Private Sub Reset()
        f1.Text = ""
        f2.Text = ""
        f3.Text = ""
        f4.Text = ""
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Reset()
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub upstd()
        Try
            con.Open()
            Dim am As Integer = f3.Text

            Dim qry = "update [dbo].[student] set fees =" & f3.Text & " where stid = " & f1.SelectedValue.ToString() & ""
            Dim cmd As New SqlCommand(qry, con)
            cmd.ExecuteNonQuery()
            MsgBox("student data updated")
            con.Close()
            display()
            Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub f1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles f1.SelectedIndexChanged

    End Sub

    Private Sub f1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles f1.SelectionChangeCommitted
        getstname()
        Label3.Hide()

    End Sub
End Class