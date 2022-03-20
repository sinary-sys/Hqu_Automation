Imports System.Data.SqlClient
Public Class 歌曲编号点歌
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ds.Clear()    '清空数据集Dt
        Dim strConnection As String = "Data Source=localhost;Initial Catalog=KTV;Integrated Security=True"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim sqlstr As String  '定义存放sql语句的字符串
        sqlstr = " select * From 歌曲 Where 歌曲编号 like '" & _
           TextBox1.Text & "%'" & " "
        'sql语句
        '创建adapter实例，并指定要执行的sql语句文本
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(sqlstr, myConnection)


        Try
            '根据查询条件填写数据集Dt
            myCommand.Fill(Me.ds, "数字点歌")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        '设置DataGrid1的数据源
        DataGridView1.DataSource = ds.Tables("数字点歌")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class