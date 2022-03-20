Imports System.Data.SqlClient
Public Class 读者借阅情况查询
    Public NowBorrowData As DataTable
    Public HistoryBorrowData As DataTable
    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 读者借阅情况查询_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq2 As String = "SELECT 图书.书号,图书.书名,图书.作者,图书.出版社,图书.出版时间,借阅.借出日期,借阅.应归还日期 FROM 图书,借阅 WHERE 借书证号 = '" & TextBox5.Text & "'AND 图书.书号=借阅.书号 AND 归还日期 is NULL "
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

        '设置DataGrid2的数据源
        NowBorrowData = dt.Tables("图书")
        DataGridView2.DataSource = NowBorrowData
        DataGridView2.Columns("借出日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
        DataGridView2.Columns("应归还日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"


        Dim strConnection3 As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq3 As String = "SELECT 图书.书号,图书.书名,图书.作者,图书.出版社,图书.出版时间,借阅.借出日期,借阅.归还日期 FROM 图书,借阅 WHERE 借书证号 = '" & TextBox5.Text & "' AND 图书.书号=借阅.书号 "
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
        '设置DataGrid5的数据源
        HistoryBorrowData = dt3.Tables("读者")
        DataGridView5.DataSource = HistoryBorrowData
        DataGridView5.Columns("借出日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
        DataGridView5.Columns("归还日期").DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BookNumber As String
        Dim BorrowDate As DateTime
        Dim ShouldReturnDate As DateTime

        Dim intResult As Integer
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim mycmd As New SqlCommand
        Dim myconn As New SqlConnection(strConnection)
        myconn.Open()
        '定义查询删除的过程
        intResult = MessageBox.Show("确认修改", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Try
                For i = 0 To DataGridView2.RowCount - 1
                    BookNumber = DataGridView2.Rows(i).Cells(0).Value
                    BorrowDate = DataGridView2.Rows(i).Cells(5).Value
                    ShouldReturnDate = DataGridView2.Rows(i).Cells(6).Value
                    Dim strSql As String = "UPDATE 借阅 SET 借出日期 = '" & BorrowDate & "', 应归还日期 = '" & ShouldReturnDate & "' WHERE 借书证号 = '" & TextBox5.Text & "' AND 书号 = '" & BookNumber & "'"
                    Dim myconnStr As New SqlCommand(strSql, myconn)
                    myconnStr.ExecuteScalar()
                Next i
                MsgBox("修改成功")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BookNumber As String
        Dim BorrowDate As DateTime
        Try
            BookNumber = DataGridView2.Item("书号", DataGridView2.CurrentCell.RowIndex).Value
            BorrowDate = DataGridView2.Item("借出日期", DataGridView2.CurrentCell.RowIndex).Value
            Dim intResult As Integer
            Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
            Dim mycmd As New SqlCommand
            Dim myconn As New SqlConnection(strConnection)
            Dim strSql As String = "DELETE FROM 借阅 WHERE 借书证号 = '" & TextBox5.Text & "' AND 书号 = '" & BookNumber & "' AND 借出日期 = '" & BorrowDate & "'"
            Dim myconnStr As New SqlCommand(strSql, myconn)
            myconn.Open()
            '定义查询删除的过程
            intResult = MessageBox.Show("确认删除", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            If intResult = DialogResult.OK Then
                Try
                    myconnStr.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                myconn.Close()
                DataGridView2.Rows.RemoveAt(DataGridView2.CurrentCell.RowIndex)
                MsgBox("删除成功")
            End If
        Catch ex As Exception
            MsgBox("未选择要删除的数据行")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim BookNumber As String
        Dim BorrowDate As DateTime
        Try
            BookNumber = DataGridView5.Item("书号", DataGridView5.CurrentCell.RowIndex).Value
            BorrowDate = DataGridView5.Item("借出日期", DataGridView5.CurrentCell.RowIndex).Value
            Dim intResult As Integer
            Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
            Dim mycmd As New SqlCommand
            Dim myconn As New SqlConnection(strConnection)
            Dim strSql As String = "DELETE FROM 借阅 WHERE 借书证号 = '" & TextBox5.Text & "' AND 书号 = '" & BookNumber & "' AND 借出日期 = '" & BorrowDate & "'"
            Dim myconnStr As New SqlCommand(strSql, myconn)
            myconn.Open()
            '定义查询删除的过程
            intResult = MessageBox.Show("确认删除", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            If intResult = DialogResult.OK Then
                Try
                    myconnStr.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                myconn.Close()
                DataGridView5.Rows.RemoveAt(DataGridView5.CurrentCell.RowIndex)
                MsgBox("删除成功")
            End If
        Catch ex As Exception
            MsgBox("未选择要删除的数据行")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim BookNumber As String
        Dim BorrowDate As DateTime
        Dim ReturnDate As DateTime

        Dim intResult As Integer
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim mycmd As New SqlCommand
        Dim myconn As New SqlConnection(strConnection)
        myconn.Open()
        '定义查询删除的过程
        intResult = MessageBox.Show("确认修改", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Try
                For i = 0 To DataGridView5.RowCount - 1
                    BookNumber = DataGridView5.Rows(i).Cells(0).Value
                    BorrowDate = DataGridView5.Rows(i).Cells(5).Value
                    ReturnDate = DataGridView5.Rows(i).Cells(6).Value
                    Dim strSql As String = "UPDATE 借阅 SET 借出日期 = '" & BorrowDate & "', 归还日期 = '" & ReturnDate & "' WHERE 借书证号 = '" & TextBox5.Text & "' AND 书号 = '" & BookNumber & "'"
                    Dim myconnStr As New SqlCommand(strSql, myconn)
                    myconnStr.ExecuteScalar()
                Next i
                MsgBox("修改成功")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()
        End If
    End Sub
End Class