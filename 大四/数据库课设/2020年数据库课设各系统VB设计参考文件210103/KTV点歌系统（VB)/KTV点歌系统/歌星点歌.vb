Imports System.Data.SqlClient

Public Class 歌星点歌
    Inherits System.Windows.Forms.Form
  
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DS As DataSet
        Dim MyConnection As SqlConnection
        Dim MyDataAdapter As SqlDataAdapter

        '连接数据库语句
        MyConnection = New SqlConnection("Data Source=localhost;Initial Catalog=KTV;Integrated Security=True")

        '创建一个dataapater，然后给出存储过程的名字
        MyDataAdapter = New SqlDataAdapter("歌手检索1", MyConnection)

        '设置命令类型是存储过程
        MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure


        '设置存储过程参数
        MyDataAdapter.SelectCommand.Parameters.Add(New SqlParameter("@geshou", SqlDbType.VarChar, 40))
        '指定存储过程过程参数
        MyDataAdapter.SelectCommand.Parameters("@geshou").Value = Trim(TextBox1.Text)

        '设置存储过程参数 
        'MyDataAdapter.SelectCommand.Parameters.Add(New SqlParameter("@RowCount", SqlDbType.Int, 4))
        '设置参数是输出参数
        ' MyDataAdapter.SelectCommand.Parameters("@RowCount").Direction = ParameterDirection.Output


        '创建一个新的记录集来保存数据
        DS = New DataSet()
        MyDataAdapter.Fill(DS, "歌手点歌") '返回的行填充到数据集

        '得到返回行数，赋给lblRowCount
        ' lblRowCount.Text = DS.Tables(0).Rows.Count().ToString() & " Rows Found!"
        'lblRowCount.Text = MyDataAdapter.SelectCommand.Parameters(1).Value & " Rows Found!"

        '设定DataGrid控件的数据源
        DataGridView1.DataSource = DS.Tables("歌手点歌").DefaultView

        '关闭dataapater和数据库
        'MyDataAdapter.Dispose() 'Dispose of the DataAdapter.
        'MyConnection.Close() 'Close the connection.


    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
