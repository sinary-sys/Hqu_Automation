Public Class 读者新增

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newid As String = "INSERT INTO 读者信息表 VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')"
        Dim mycmd As New SqlClient.SqlCommand(newid, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        管理员界面.Show()
    End Sub
End Class