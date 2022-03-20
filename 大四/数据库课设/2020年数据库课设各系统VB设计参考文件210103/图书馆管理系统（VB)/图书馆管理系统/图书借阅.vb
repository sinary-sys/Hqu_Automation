
Imports System.Data.SqlClient
Public Class 图书借阅


    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量

    Dim ds As DataSet = New DataSet()
    Dim user = 登录界面.TextBox3.Text

    Dim myDataReader As SqlClient.SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        读者界面.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ds.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        Dim inf = "select * from 图书表 ORDER BY 被借次数 DESC"
        Dim cxadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        cxadpter.Fill(ds, "1")
        DataGridView1.DataSource = ds.Tables("1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ds.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        Dim inf = "select * from 图书表 where 图书编号 Like '%" + RichTextBox1.Text + "%'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        infadpter.Fill(ds, "1")
        DataGridView1.DataSource = ds.Tables("1")
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ds.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        Dim inf = "select * from 图书表 where 图书名称 Like '%" + RichTextBox2.Text + "%'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        infadpter.Fill(ds, "1")
        DataGridView1.DataSource = ds.Tables("1")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ds.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        Dim inf = "select * from 图书表 where 作者 Like '%" + RichTextBox3.Text + "%'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        infadpter.Fill(ds, "1")
        DataGridView1.DataSource = ds.Tables("1")
    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox3.TextChanged

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sql As String = "select * from 借阅信息表 where 读者编号 = '" + 登录界面.TextBox3.Text + "'and 图书编号 = '" + TextBox1.Text + "'"
        Dim adapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(sql, myconn)
        Dim mydb As New DataSet
        adapter.Fill(mydb, "读者编号")
        If mydb.Tables("读者编号").Rows.Count = 1 Then
            MsgBox("您已借阅过此本书，不可重复借阅")
        ElseIf mydb.Tables("读者编号").Rows.Count = 0 Then
            TextBox4.Text = ""
            Dim borrow As String = "update  图书表 SET 在馆册数 = 在馆册数 - 1 Where 图书编号 = '" + TextBox1.Text + "'"
            Dim borro As String = "INSERT INTO 借阅信息表(图书编号,读者编号,借书时间) VALUES ('" + TextBox1.Text + "','" + user + "',getdate())"
            Dim borr As String = "update 借阅信息表 set 应还时间=dateadd(month,1,借书时间)"
            Dim mycmd As New SqlClient.SqlCommand(borrow, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
            Dim mycm As New SqlClient.SqlCommand(borro, myconn)
            myconn.Open()
            Try
                mycm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
            Dim myc As New SqlClient.SqlCommand(borr, myconn)
            myconn.Open()
            Try
                myc.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
            MsgBox("借阅成功")
            Dim r As String = "update 图书表 SET 被借次数 = 被借次数 + 1 Where 图书编号 = '" + TextBox1.Text + "'"
            Dim cmd As New SqlClient.SqlCommand(r, myconn)
            myconn.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
            Dim rx As String = ""
            Dim cmdx As New SqlClient.SqlCommand(rx, myconn)
            myconn.Open()
            Try
                cmdx.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = DataGridView1.CurrentRow.Cells("图书编号").Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells("图书名称").Value
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class