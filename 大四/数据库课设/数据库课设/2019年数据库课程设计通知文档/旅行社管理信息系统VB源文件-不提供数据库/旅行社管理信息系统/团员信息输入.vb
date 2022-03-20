'' 导入命名空间
Imports System.Data.SqlClient
Public Class 团员信息输入
    Inherits System.Windows.Forms.Form
    '建立类中可访问的数据集对象()，名为ds,且为全局变量
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase

    Private Sub 团员信息输入_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 建立一个连接字符串
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        ' 建立一个查询命令字符串
        Dim strSql As String = "SELECT 团员编号,姓名,性别,电话,身份证号,通讯地址,团队编号 FROM 团员信息表"
        ' 建立一个数据连接
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        '建立一个数据适配器以便针对数据源执行SELECT 语句来提取出要填入数据集的数据记录
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        ' 将数据填入数据集
        myCommand.Fill(ds, "团员信息表")
        '指定绑定的数据源
        mybind = Me.BindingContext(ds, "团员信息表")
        '将TextBox 控件的Text 属性绑定至数据集ds 内的学生数据表的学号、姓名等字段
        TextBox团员编号.DataBindings.Add("Text", ds, "团员信息表.团员编号")
        TextBox姓名.DataBindings.Add("Text", ds, "团员信息表.姓名")
        TextBox性别.DataBindings.Add("Text", ds, "团员信息表.性别")
        TextBox电话.DataBindings.Add("Text", ds, "团员信息表.电话")
        TextBox身份证号.DataBindings.Add("Text", ds, "团员信息表.身份证号")
        TextBox通讯地址.DataBindings.Add("Text", ds, "团员信息表.通讯地址")
        TextBox团队编号.DataBindings.Add("Text", ds, "团员信息表.团队编号")
    End Sub
End Class