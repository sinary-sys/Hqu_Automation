Public Class 读者界面
    Dim user = 登录界面.TextBox3.Text

    Private Sub 读者界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub 退出_Click(sender As Object, e As EventArgs) Handles 退出.Click
        Me.Hide()
        登录界面.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim book = "select * from 图书表 ORDER BY 被借次数"
        Dim cxadpter As New SqlClient.SqlDataAdapter(book, myconn)
        Dim cxt As New DataSet
        cxadpter.Fill(cxt, "1")
        DataGridView3.DataSource = cxt.Tables("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim arrears = "select 欠款金额 from 读者信息表 where 读者编号='" + user + "'"
        Dim cxadpter As New SqlClient.SqlDataAdapter(arrears, myconn)
        Dim cxt As New DataSet
        cxadpter.Fill(cxt, "1")
        DataGridView1.DataSource = cxt.Tables("1")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim borrow = "select * from 借阅信息表 where 读者编号='" + user + "'"
        Dim cxadpter As New SqlClient.SqlDataAdapter(borrow, myconn)
        Dim cxt As New DataSet
        cxadpter.Fill(cxt, "1")
        DataGridView2.DataSource = cxt.Tables("1")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim jiaona As String = "update 读者信息表 set 欠款金额 = 0 Where 读者编号='" + user + "'"
        Dim mycmd As New SqlClient.SqlCommand(jiaona, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("欠款已缴纳")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inf = "select * from 读者信息表 where 读者编号='" + user + "'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        Dim infor As New DataSet
        infadpter.Fill(infor, "1")
        DataGridView2.DataSource = infor.Tables("1")
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        信息修改.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox3.Text = "" Then
            MsgBox("未输入修改后的密码")
        ElseIf TextBox3.Text <> "" Then
            Dim password As String = "update 读者信息表 set 密码 = '" + TextBox3.Text + "' Where 读者编号='" + user + "'"
            Dim mycmd As New SqlClient.SqlCommand(password, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
            MsgBox("密码已成功修改")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        图书借阅.Show()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim inf = "select * from 借阅信息表 where 读者编号='" + user + "'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        Dim infor As New DataSet
        infadpter.Fill(infor, "1")
        DataGridView4.DataSource = infor.Tables("1")
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        图书归还.Show()
    End Sub
End Class