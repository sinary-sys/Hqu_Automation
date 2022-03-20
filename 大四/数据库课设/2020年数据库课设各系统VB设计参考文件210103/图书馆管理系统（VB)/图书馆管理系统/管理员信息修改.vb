Public Class 管理员信息修改
    Dim user = 登录界面.TextBox3.Text
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xiugai As String = "update 管理人员信息表 set 姓名= '" + TextBox3.Text + "',性别= '" + TextBox4.Text + "',住址= '" + TextBox5.Text + "',联系电话= '" + TextBox6.Text + "Where 读者编号='" + user + "'"
        Dim mycmd As New SqlClient.SqlCommand(xiugai, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("个人信息已修改")
    End Sub
End Class