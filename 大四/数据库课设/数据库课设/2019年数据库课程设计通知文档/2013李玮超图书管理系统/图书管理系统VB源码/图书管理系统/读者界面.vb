Imports System.Data.SqlClient
Public Class 读者界面
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase
    Public dtt As DataTable
    Public bookrank As DataTable
    Public peoplerank As DataTable
    Public NowBorrowData As DataTable
    Public HistoryBorrowData As DataTable
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub 读者界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSql As String = "SELECT 借书证号,姓名,性别,工作单位,借阅次数 FROM 读者 WHERE 借书证号='" & 登录界面.TextBox1.Text & "' "
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        Dim number As String

        myCommand.Fill(ds, "读者")
        mybind = Me.BindingContext(ds, "读者")
        TextBox1.DataBindings.Add("Text", ds, "读者.借书证号")
        TextBox2.DataBindings.Add("Text", ds, "读者.姓名")
        TextBox3.DataBindings.Add("Text", ds, "读者.性别")
        TextBox4.DataBindings.Add("Text", ds, "读者.工作单位")
        TextBox8.DataBindings.Add("Text", ds, "读者.借阅次数")
        number = 登录界面.TextBox1.Text.ToString
        Select Case number
            Case "1615311032"
                PictureBox1.ImageLocation = "D:\PictureData\user\1615311032.jpg"
            Case "1615322013"
                PictureBox1.ImageLocation = "D:\PictureData\user\1615322013.jpg"
            Case "1615322020"
                PictureBox1.ImageLocation = "D:\PictureData\user\1615322020.jpg"
            Case "1615322030"
                PictureBox1.ImageLocation = "D:\PictureData\user\1615322030.jpg"
            Case "1615322049"
                PictureBox1.ImageLocation = "D:\PictureData\user\1615322040.jpg"
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq2 As String = "SELECT 图书.*,类型.类型名 FROM 图书,类型 WHERE 图书.类型编号=类型.类型编号 AND 书号 like '" & TextBox5.Text & "%'" & "and 书名 like '" & TextBox6.Text & "%'" & "and 作者 like '" & TextBox7.Text & "%'" & "and 类型名 like '" & TextBox9.Text & "%'"
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

        '设置DataGrid1的数据源
        dtt = dt.Tables("图书")
        DataGridView1.DataSource = dtt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        读者个人信息修改界面.Show()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq2 As String = "SELECT 图书.*,类型.类型名 FROM 图书,类型 WHERE 图书.类型编号=类型.类型编号 ORDER BY 被借次数 DESC"
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
        '设置DataGrid1的数据源
        bookrank = dt.Tables("图书")
        DataGridView3.DataSource = bookrank

        Dim strConnection3 As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq3 As String = "SELECT 读者.姓名,读者.性别,读者.工作单位,读者.借阅次数 FROM 读者 ORDER BY 借阅次数 DESC"
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
        peoplerank = dt3.Tables("读者")
        DataGridView4.DataSource = peoplerank
    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        排行表图表显示.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq2 As String = "SELECT 图书.书号,图书.书名,图书.作者,图书.出版社,图书.出版时间,借阅.借出日期,借阅.应归还日期 FROM 图书,借阅 WHERE 借书证号 = '" & TextBox1.Text & "'AND 图书.书号=借阅.书号 AND 归还日期 is NULL "
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

        '设置DataGrid1的数据源
        NowBorrowData = dt.Tables("图书")
        DataGridView2.DataSource = NowBorrowData
        DataGridView2.Columns("借出日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
        DataGridView2.Columns("应归还日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"


        Dim strConnection3 As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq3 As String = "SELECT 图书.书号,图书.书名,图书.作者,图书.出版社,图书.出版时间,借阅.借出日期,借阅.归还日期 FROM 图书,借阅 WHERE 借书证号 = '" & TextBox1.Text & "' AND 图书.书号=借阅.书号 "
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
        HistoryBorrowData = dt3.Tables("读者")
        DataGridView5.DataSource = HistoryBorrowData
        DataGridView5.Columns("借出日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
        DataGridView5.Columns("归还日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub
End Class