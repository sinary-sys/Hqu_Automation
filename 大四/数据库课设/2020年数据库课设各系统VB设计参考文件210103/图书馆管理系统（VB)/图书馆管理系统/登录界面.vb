
Public Class 登录界面


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked() Then
            Dim sql As String = "select * from 读者信息表 where 读者编号 = '" + Me.TextBox3.Text + "'and 密码 = '" + Me.TextBox4.Text + "'"
            Dim adapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(sql, myconn)
            Dim mydb As New DataSet
            adapter.Fill(mydb, "读者编号")
            If mydb.Tables("读者编号").Rows.Count = 0 Then
                MsgBox("错误")
            ElseIf mydb.Tables("读者编号").Rows.Count = 1 Then
                Me.Hide()
                MsgBox("会员" + TextBox3.Text + "已登录", 0, "欢迎登陆华侨大学图书管理系统")
                读者界面.Show()
            End If
        ElseIf RadioButton2.Checked() Then
            Dim sql As String = "select * from 管理人员信息表 where 工作人员编号 = '" + Me.TextBox3.Text + "'and 管理密码 = '" + Me.TextBox4.Text + "'"
            Dim adapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(sql, myconn)
            Dim mydb As New DataSet
            adapter.Fill(mydb, "工作人员编号")
            If mydb.Tables("工作人员编号").Rows.Count = 0 Then
                MsgBox("错误")
            ElseIf mydb.Tables("工作人员编号").Rows.Count = 1 Then
                Me.Hide()
                MsgBox("管理员" + TextBox4.Text + "已登录", 0, "欢迎登陆华侨大学图书管理系统")
                管理员界面.Show()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

End Class
