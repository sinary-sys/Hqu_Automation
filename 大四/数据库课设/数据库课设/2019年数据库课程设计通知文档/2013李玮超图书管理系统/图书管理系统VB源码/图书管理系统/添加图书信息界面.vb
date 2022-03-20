Imports System.Data.SqlClient
Public Class 添加图书信息界面
    Dim ds As DataSet = New DataSet()
    Public mybind As BindingManagerBase
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub 添加图书信息界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strConnection As New SqlClient.SqlConnection("Data Source =.;Initial Catalog = 图书管理系统;Integrated Security = True;")
        Dim strSql As String = "INSERT INTO 图书(书号,书名,作者,出版社,出版时间,价格,总数量,剩余数量,位置,类型编号) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox8.Text & "','" & TextBox10.Text & "','" & TextBox9.Text & "')"
        Dim myCmd As New SqlClient.SqlCommand(strSql, strConnection)
        strConnection.Open()
        Try
            myCmd.ExecuteNonQuery()
            MsgBox("添加成功")
        Catch ex As Exception
            MsgBox("添加失败，请确认是否输入完整准确")
        End Try
        strConnection.Close()
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class