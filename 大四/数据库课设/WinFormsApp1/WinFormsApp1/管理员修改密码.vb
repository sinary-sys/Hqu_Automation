Imports System.Data.SqlClient
Public Class 管理员修改密码
    Dim n As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")

        Dim mysql As String = "select * from manager where 管理名='" + TextBox_用户名.Text + "'and 密码='" + TextBox_旧密码.Text + "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "密码更改1")
        If mydataset.Tables("密码更改1").Rows.Count = 0 Then
            n += 1
            If n < 3 Then
                MsgBox("用户名或密码错误！", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息提示")
                TextBox_用户名.Text = ""
                TextBox_旧密码.Text = ""
                TextBox_新密码.Text = ""
                TextBox_用户名.Focus()
            Else
                MsgBox("已修改失败3次！退出系统", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "信息提示")

                End
            End If

        Else
            Dim sqlcomm As String = "update manager set 密码='" + TextBox_新密码.Text + "'where 管理名='" + TextBox_用户名.Text + "'"
            Dim mysqlcomm As New SqlCommand(sqlcomm, myconnection)
            myconnection.Open()
            mysqlcomm.ExecuteNonQuery()
            myconnection.Close()
            TextBox_用户名.Text = ""
            TextBox_旧密码.Text = ""
            TextBox_新密码.Text = ""
            MsgBox("修改成功！")
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class