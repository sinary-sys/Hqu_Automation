Public Class 信息修改
    Dim user = 登录界面.TextBox3.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
        ElseIf TextBox1.Text <> "" Then
            Dim xiugai As String = "update 读者信息表 set 读者姓名= '" + TextBox1.Text + "'Where 读者编号='" + user + "'"
            Dim mycmd As New SqlClient.SqlCommand(xiugai, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
        If TextBox2.Text = "" Then
        ElseIf TextBox2.Text <> "" Then
            Dim xiugai As String = "update 读者信息表 set 读者性别= '" + TextBox2.Text + "'Where 读者编号='" + user + "'"
            Dim mycmd As New SqlClient.SqlCommand(xiugai, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
        If TextBox3.Text = "" Then
        ElseIf TextBox3.Text <> "" Then
            Dim xiugai As String = "update 读者信息表 set 读者年龄= '" + TextBox3.Text + "' Where 读者编号='" + user + "'"
            Dim mycmd As New SqlClient.SqlCommand(xiugai, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
        If TextBox4.Text = "" Then
        ElseIf TextBox4.Text <> "" Then
            Dim xiugai As String = "update 读者信息表 set 联系电话= '" + TextBox4.Text + "' Where 读者编号='" + user + "'"
            Dim mycmd As New SqlClient.SqlCommand(xiugai, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
        If TextBox5.Text = "" Then
        ElseIf TextBox5.Text <> "" Then
            Dim xiugai As String = "update 读者信息表 set 所属单位 = '" + TextBox6.Text + "' Where 读者编号='" + user + "'"
            Dim mycmd As New SqlClient.SqlCommand(xiugai, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
        If TextBox6.Text = "" Then
        ElseIf TextBox6.Text <> "" Then
            Dim xiugai As String = "update 读者信息表 set 读者姓名= '" + TextBox1.Text + "',读者性别= '" + TextBox2.Text + "',读者年龄= '" + TextBox3.Text + "',联系电话= '" + TextBox4.Text + "',联系地址= '" + TextBox5.Text + "',所属单位 = '" + TextBox6.Text + "' Where 读者编号='" + user + "'"
            Dim mycmd As New SqlClient.SqlCommand(xiugai, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
        MsgBox("信息已修改")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        读者界面.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inf = "select 读者姓名,读者性别,读者年龄,联系电话,联系地址,所属单位 from 读者信息表 where 读者编号='" + user + "'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        Dim infor As New DataSet
        infadpter.Fill(infor, "1")
        DataGridView1.DataSource = infor.Tables("1")
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub RichTextBox7_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox7.TextChanged

    End Sub
End Class