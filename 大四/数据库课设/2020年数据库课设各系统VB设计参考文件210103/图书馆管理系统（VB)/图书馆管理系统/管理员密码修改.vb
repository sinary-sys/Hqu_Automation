Public Class 密码修改
    Dim user = 登录界面.TextBox3.Text
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As String = "update 管理人员信息表 set 管理密码 = '" + TextBox1.Text + "' Where 工作人员编号='" + user + "'"
        Dim mycmd As New SqlClient.SqlCommand(password, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("密码已成功修改")
        Me.Hide()
    End Sub
End Class