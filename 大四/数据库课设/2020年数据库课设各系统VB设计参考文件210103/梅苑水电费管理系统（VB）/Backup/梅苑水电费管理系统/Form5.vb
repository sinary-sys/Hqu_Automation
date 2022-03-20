Imports System.Data.SqlClient
Public Class 宿舍水电费查询
    Dim myconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=学生宿舍水电费管理系统;Integrated Security=True")
    Dim mycmd As New SqlCommand
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 总表 where 房号= '" & TextBox1.Text & "'"
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "总表")
        Me.DataGridView1.DataSource = mydataset.Tables("总表")

        mycmd.CommandText = "select dbo.计算结果( '" & TextBox1.Text & "') as  '" & TextBox1.Text & "水电费' "
        myadapter.Fill(mydataset, "select dbo.计算结果( '" & TextBox1.Text & "') ")
        Me.DataGridView2.DataSource = mydataset.Tables("select dbo.计算结果( '" & TextBox1.Text & "') ")
     

      
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Hide()
        修改密码.Show()
    End Sub

    Private Sub 宿舍水电费查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class