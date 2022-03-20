Public Class 图书删除

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim delete As String = "Delete  From 图书表 Where 图书编号='" + TextBox1.Text + "'"
        Dim mycmd As New SqlClient.SqlCommand(delete, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("该图书已删除")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim inf = "select * from 图书表 where 图书编号 = '" + TextBox1.Text + "'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        Dim infor As New DataSet
        infadpter.Fill(infor, "1")
        DataGridView1.DataSource = infor.Tables("1")
    End Sub
End Class