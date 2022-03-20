Imports System.Data.SqlClient

Public Class 管理员界面
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase
    Public dtt As DataTable
    Public dtt2 As DataTable
    Public sda As SqlDataAdapter
    Public sda2 As SqlDataAdapter

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSql As String = "SELECT 工号,姓名,性别,电话 FROM 管理员 WHERE 工号='" & 登录界面.TextBox1.Text & "' "
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSql, myConnection)
        Dim number As String

        myCommand.Fill(ds, "管理员")
        mybind = Me.BindingContext(ds, "管理员")
        TextBox1.DataBindings.Add("Text", ds, "管理员.工号")
        TextBox2.DataBindings.Add("Text", ds, "管理员.姓名")
        TextBox3.DataBindings.Add("Text", ds, "管理员.性别")
        TextBox4.DataBindings.Add("Text", ds, "管理员.电话")
        number = 登录界面.TextBox1.Text.ToString
        Select Case number
            Case "1001"
                PictureBox1.ImageLocation = "D:\PictureData\Administrator\zhang.jpg"
            Case "1002"
                PictureBox1.ImageLocation = "D:\PictureData\Administrator\zhou.jpg"
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq2 As String = "SELECT * FROM 图书 WHERE 书号 like '" & TextBox5.Text & "%'" & "and 书名 like '" & TextBox6.Text & "%'" & "and 作者 like '" & TextBox7.Text & "%'"
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

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim intResult As Integer
        Dim strConnection = New SqlConnection("Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;")
        sda = New SqlDataAdapter("SELECT * FROM 图书", strConnection)
        Dim SCB = New SqlCommandBuilder(sda)
        intResult = MessageBox.Show("确认修改", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Try
                sda.Update(dtt)
                dtt.AcceptChanges()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            MsgBox("修改成功")
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        添加图书信息界面.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim BookNumber As String
        Try
            BookNumber = DataGridView1.Item("书号", DataGridView1.CurrentCell.RowIndex).Value
            Dim intResult As Integer
            Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
            Dim mycmd As New SqlCommand
            Dim myconn As New SqlConnection(strConnection)
            Dim strSql As String = "DELETE FROM 图书 WHERE 书号 = '" & BookNumber & "'"
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
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
                MsgBox("删除成功")
            End If
        Catch ex As Exception
            MsgBox("未选择要删除的数据行")
        End Try

    End Sub

    Private Sub TabPage2_Click_1(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox5_Enter_1(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim intResult As Integer
        Dim strConnection = New SqlConnection("Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;")
        sda2 = New SqlDataAdapter("SELECT * FROM 读者", strConnection)
        Dim SCB2 = New SqlCommandBuilder(sda2)
        intResult = MessageBox.Show("确认修改", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Try
                sda2.Update(dtt2)
                dtt2.AcceptChanges()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            MsgBox("修改成功")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
        Dim strSq3 As String = "SELECT * FROM 读者 WHERE 借书证号 like '" & TextBox8.Text & "%'" & "and 姓名 like '" & TextBox9.Text & "%'"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)
        Dim dt As New DataSet
        Dim myCommand As SqlDataAdapter = New SqlDataAdapter(strSq3, myConnection)
        dt.Clear() '清空数据集Dt
        Try
            '根据查询条件填写数据集Dt
            myCommand.Fill(dt, "图书")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Exit Sub
        End Try

        '设置DataGrid1的数据源
        dtt2 = dt.Tables("图书")
        DataGridView2.DataSource = dtt2
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ReaderNumber As String
        Try
            ReaderNumber = DataGridView2.Item("借书证号", DataGridView2.CurrentCell.RowIndex).Value
            Dim intResult As Integer
            Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
            Dim mycmd As New SqlCommand
            Dim myconn As New SqlConnection(strConnection)
            Dim strSql As String = "DELETE FROM 读者 WHERE 借书证号 = '" & ReaderNumber & "'"
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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        添加读者信息界面.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        管理员个人信息修改界面.Show()
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim intResult As Integer
            Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
            Dim mycmd As New SqlCommand
            Dim myconn As New SqlConnection(strConnection)
            Dim BorrowDate As New DateTime
            Dim ShouldReturnDate As New DateTime
            BorrowDate = Now
            ShouldReturnDate = DateAdd(DateInterval.Day, 30, BorrowDate)
            Dim strSql As String = "INSERT INTO 借阅(书号,借书证号,借出日期,应归还日期) VALUES ('" & TextBox10.Text & "', " & TextBox11.Text & ",'" & BorrowDate & "','" & ShouldReturnDate & "')"
            Dim myconnStr As New SqlCommand(strSql, myconn)
            myconn.Open()
            intResult = MessageBox.Show("确认借书", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            If intResult = DialogResult.OK Then
                Try
                    myconnStr.ExecuteScalar()
                    MsgBox("借书成功")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                myconn.Close()
            End If
        Catch ex As Exception
            MsgBox("借书失败")
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim intResult As Integer
            Dim strConnection As String = "Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;"
            Dim mycmd As New SqlCommand
            Dim myconn As New SqlConnection(strConnection)
            Dim ReturnDate As New DateTime
            ReturnDate = Now
            Dim strSql As String = "UPDATE 借阅 SET 归还日期 = '" & ReturnDate & "'" & "WHERE 书号 = '" & TextBox14.Text & "'" & "And 借书证号 = '" & TextBox12.Text & "'"
            Dim myconnStr As New SqlCommand(strSql, myconn)
            myconn.Open()
            intResult = MessageBox.Show("确认还书", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            If intResult = DialogResult.OK Then
                Try
                    myconnStr.ExecuteScalar()
                    MsgBox("还书成功")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                myconn.Close()
            End If
        Catch ex As Exception
            MsgBox("还书失败")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        读者借阅情况查询.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        图书信息报表.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        借阅信息报表.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        读者信息报表.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class