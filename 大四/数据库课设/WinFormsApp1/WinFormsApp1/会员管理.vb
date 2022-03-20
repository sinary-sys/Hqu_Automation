Imports System.Data.SqlClient
Public Class 会员管理
    Private Sub 会员管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_用户名.Text = 登录界面.TextBox_用户名.Text
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select 注册时间 from vip where 会员用户名='" + TextBox_用户名.Text + "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "注册时间")
        TextBox_注册时间.Text = mydataset.Tables("注册时间").Rows(0).Item(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        修改密码.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        登录界面.Show()
        登录界面.TextBox_用户名.Text = ""
        登录界面.TextBox_密码.Text = ""
        用户操作界面.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select 积分 from vip where 会员用户名='" + TextBox_用户名.Text + "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "积分表")
        If mydataset.Tables("积分表").Rows.Count = 0 Then
            MsgBox("用户积分为0", MsgBoxStyle.OkOnly, "信息提示")
        ElseIf Not IsNumeric(mydataset.Tables("积分表").Rows(0).Item(0)) Then
            MsgBox("用户积分为0", MsgBoxStyle.OkOnly, "信息提示")
        Else
            MsgBox("用户积分为 " + mydataset.Tables("积分表").Rows(0).Item(0).ToString + " ", MsgBoxStyle.OkOnly, "积分")
        End If
    End Sub

    Private Sub TextBox_用户名_TextChanged(sender As Object, e As EventArgs) Handles TextBox_用户名.TextChanged

    End Sub
End Class