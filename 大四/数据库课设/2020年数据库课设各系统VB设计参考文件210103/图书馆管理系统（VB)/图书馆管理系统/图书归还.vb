Public Class 图书归还
    Dim user = 登录界面.TextBox3.Text
    Dim borrow As Date
    Dim returnn As Date
    Private Sub 图书归还_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim re As String = "Update 借阅信息表 SET 还书时间 = getdate() Where 图书编号 = '" + TextBox1.Text + "'and 读者编号 = '" + user + "'"
        Dim mycmd As New SqlClient.SqlCommand(re, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        Dim turn As String = "update 图书表 SET 在馆册数 = 在馆册数 + 1 Where 图书编号 = '" + TextBox1.Text + "'"
        Dim mycm As New SqlClient.SqlCommand(turn, myconn)
        myconn.Open()
        Try
            mycm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        Dim borrow = DataGridView1.CurrentRow.Cells("应还时间").Value
        Dim returnn = DataGridView1.CurrentRow.Cells("还书时间").Value
        Dim interval = DateDiff("d", borrow, returnn)
        Dim mon = interval * 0.1
        TextBox3.Text = mon
        If interval > 30 Then
            Dim money As String = "Update 读者信息表 SET 欠款金额 = 欠款金额 + 1 Where 读者编号 = '" + user + "' "
            Dim mmycmd As New SqlClient.SqlCommand(money, myconn)
            myconn.Open()
            Try
                mmycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
            MsgBox("您借阅的图书已欠款" + TextBox3.Text + "元,请及时缴纳欠款")
        End If
        MsgBox("还书成功")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New DataSet
        Dim inf = "select * from 借阅信息表  Where 图书编号 = '" + TextBox1.Text + "'and 读者编号 = '" + user + "'"
        Dim infadpter As New SqlClient.SqlDataAdapter(inf, myconn)
        infadpter.Fill(ds, "1")
        DataGridView1.DataSource = ds.Tables("1")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class