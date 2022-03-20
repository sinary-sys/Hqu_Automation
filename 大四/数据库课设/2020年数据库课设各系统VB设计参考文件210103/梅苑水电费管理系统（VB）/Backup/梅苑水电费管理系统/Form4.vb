Imports System.Data.SqlClient
Public Class 用户注册
    Dim myconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=学生宿舍水电费管理系统;Integrated Security=True")
    Dim mycmd As New SqlCommand
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "学生" Then
            ComboBox1.Text = 2
        Else
            ComboBox1.Text = 1
        End If
        Dim mysql As String = "insert into 用户表 values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "')"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        Me.Close()
        MsgBox("注册成功")
    End Sub
End Class