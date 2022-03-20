Imports System.Data.SqlClient
Public Class 歌名点歌

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DS As DataSet
        Dim MyConnection As SqlConnection
        Dim MyDataAdapter As SqlDataAdapter

        '连接数据库语句
        MyConnection = New SqlConnection("Data Source=localhost;Initial Catalog=KTV;Integrated Security=True")

        '创建一个dataapater，然后给出存储过程的名字
        MyDataAdapter = New SqlDataAdapter("歌曲检索1", MyConnection)

        '设置命令类型是存储过程
        MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure


        '设置存储过程参数
        MyDataAdapter.SelectCommand.Parameters.Add(New SqlParameter("@gequ", SqlDbType.VarChar, 40))
        '指定存储过程过程参数
        MyDataAdapter.SelectCommand.Parameters("@gequ").Value = Trim(TextBox1.Text)

        '设置存储过程参数 
        ' MyDataAdapter.SelectCommand.Parameters.Add(New SqlParameter("@RowCount", SqlDbType.Int, 4))
        '设置参数是输出参数
        ' MyDataAdapter.SelectCommand.Parameters("@RowCount").Direction = ParameterDirection.Output


        '创建一个新的记录集来保存数据
        DS = New DataSet()
        MyDataAdapter.Fill(DS, "歌名点歌") '返回的行填充到数据集

        '得到返回行数，赋给lblRowCount
        ' lblRowCount.Text = DS.Tables(0).Rows.Count().ToString() & " Rows Found!"
        'lblRowCount.Text = MyDataAdapter.SelectCommand.Parameters(1).Value & " Rows Found!"

        '设定DataGrid控件的数据源
        DataGridView1.DataSource = DS.Tables("歌名点歌").DefaultView

        '关闭dataapater和数据库
        'MyDataAdapter.Dispose() 'Dispose of the DataAdapter.
        'MyConnection.Close() 'Close the connection.
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub 歌名点歌_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("加入已点歌单成功！")
        Dim song As String = "INSERT INTO 已点歌曲.ListBox1.Value VALUS('" & 用户登入界面.TextBox用户名.Text & "','" & DataGridView1.CurrentRow.Cells("歌曲名称").Value.ToString() & "')"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("歌曲收藏成功！")
    End Sub
End Class