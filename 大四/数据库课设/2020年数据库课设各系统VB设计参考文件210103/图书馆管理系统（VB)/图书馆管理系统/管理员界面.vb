Public Class 管理员界面

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cx = "select 读者编号,读者姓名,读者性别,读者年龄,联系电话,联系地址,所属单位,欠款金额,借阅次数 from 读者信息表"
        Dim cxadpter As New SqlClient.SqlDataAdapter(cx, myconn)
        Dim cxt As New DataSet
        cxadpter.Fill(cxt, "1")
        DataGridView1.DataSource = cxt.Tables("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cx = "select * from 借阅信息表"
        Dim cxadpter As New SqlClient.SqlDataAdapter(cx, myconn)
        Dim cxt As New DataSet
        cxadpter.Fill(cxt, "1")
        DataGridView1.DataSource = cxt.Tables("1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        登录界面.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        管理员信息修改.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        密码修改.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        图书新增.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        图书删除.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cx = "select * from 图书表"
        Dim cxadpter As New SqlClient.SqlDataAdapter(cx, myconn)
        Dim cxt As New DataSet
        cxadpter.Fill(cxt, "1")
        DataGridView1.DataSource = cxt.Tables("1")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        读者新增.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim cx = "select 读者编号,读者姓名,借阅次数 from 读者信息表 ORDER BY 借阅次数 DESC"
        Dim cxadpter As New SqlClient.SqlDataAdapter(cx, myconn)
        Dim cxt As New DataSet
        cxadpter.Fill(cxt, "1")
        DataGridView1.DataSource = cxt.Tables("1")
    End Sub
End Class