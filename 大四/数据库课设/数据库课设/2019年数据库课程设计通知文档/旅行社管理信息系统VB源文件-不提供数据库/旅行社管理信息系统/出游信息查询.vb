
'' 导入命名空间
Imports System.Data.SqlClient
Public Class 出游信息查询
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase

    Private Sub 出游信息查询_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 建立一个连接字符串
        'Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' 建立一个查询命令字符串
        ' Dim strSql As String = "SELECT 团队编号,路线编号,出发日期,返程日期 FROM 出游表"
        ' 建立一个数据连接
        'Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        'Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        ' 将数据填入数据集
        'myCommand.Fill(ds, "出游表")
        '指定绑定的数据源
        'mybind = Me.BindingContext(ds, "出游表")
        '将TextBox 控件的Text 属性绑定至数据集ds 内的学生数据表的学号、姓名等字段
        'TextBox团队编号.DataBindings.Add("Text", ds, "出游表.团队编号")
        'TextBox路线编号.DataBindings.Add("Text", ds, "出游表.路线编号")
        'TextBox出发日期.DataBindings.Add("Text", ds, "出游表.出发日期")
        'TextBox返程日期.DataBindings.Add("Text", ds, "出游表.返程日期")
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ds.Clear()    '清空数据集Dt
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim sqlstr As String  '定义存放sql语句的字符串
        sqlstr = " select * From 出游表 Where 团队编号 like '" & _
           TextBox团队编号.Text & "%'" & " and 路线编号 like '" & _
            TextBox路线编号.Text & "%'" 'sql语句
        '创建adapter实例，并指定要执行的sql语句文本
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(sqlstr, myConnection)


        Try
            '根据查询条件填写数据集Dt
            myCommand.Fill(Me.ds, "出游表")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        '设置DataGrid1的数据源
        DataGridView1.DataSource = ds.Tables("出游表")



    End Sub

End Class