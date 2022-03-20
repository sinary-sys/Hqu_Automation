Public Class 添加读者信息界面

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnection As New SqlClient.SqlConnection("Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;")
        Dim strSql As String = "INSERT INTO 读者(借书证号,密码,姓名,性别,工作单位) VALUES('" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "')"
        Dim myCmd As New SqlClient.SqlCommand(strSql, strConnection)
        strConnection.Open()
        Try
            myCmd.ExecuteNonQuery()
            MsgBox("添加成功")
        Catch ex As Exception
            MsgBox("添加失败，请确认是否输入完整准确")
        End Try
        strConnection.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub 添加读者信息界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class