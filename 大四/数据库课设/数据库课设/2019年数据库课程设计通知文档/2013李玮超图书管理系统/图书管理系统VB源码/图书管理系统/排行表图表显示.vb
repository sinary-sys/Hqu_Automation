Imports System.Data.SqlClient
Public Class 排行表图表显示
    Public rankbook As DataTable
    Public rankpeople As DataTable
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub 排行表图表显示_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq2 As String = "SELECT 图书.书名,图书.被借次数 FROM 图书,类型 WHERE 图书.类型编号=类型.类型编号 ORDER BY 被借次数 DESC"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim dt As New DataSet
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSq2, myConnection)
        dt.Clear() '清空数据集Dt
        Try
            '根据查询条件填写数据集Dt
            myCommand.Fill(dt, "图书")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Exit Sub
        End Try
        '设置DataGrid1
        rankbook = dt.Tables("图书")
        Chart1.DataSource = rankbook
        Chart1.DataBind()
        Chart1.Series(0).XValueMember = "书名"
        Chart1.Series(0).YValueMembers = "被借次数"

        Dim strConnection3 As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq3 As String = "SELECT 读者.姓名,读者.借阅次数 FROM 读者 ORDER BY 借阅次数 DESC"
        Dim myConnection3 As SqlConnection = New SqlConnection(strConnection)
        Dim dt3 As New DataSet
        Dim myCommand3 As SqlDataAdapter = New SqlDataAdapter(strSq3, myConnection)
        dt3.Clear()
        Try
            '根据查询条件填写数据集Dt3
            myCommand3.Fill(dt3, "读者")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Exit Sub
        End Try
        '设置DataGrid1的数据源
        rankpeople = dt3.Tables("读者")
        Chart2.DataSource = rankpeople
        Chart2.DataBind()
        Chart2.Series(0).XValueMember = "姓名"
        Chart2.Series(0).YValueMembers = "借阅次数"
    End Sub
End Class