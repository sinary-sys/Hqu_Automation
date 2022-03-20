Imports System.Data.SqlClient

Public Class 注册账号

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim str As String = "select max(会员编号) from vip"
        Dim myadapter As New SqlDataAdapter(str, myconnection)
        Dim mydataset As New DataSet
        mydataset.Clear()
        myadapter.Fill(mydataset, "最大编号")
        If mydataset.Tables("最大编号").Rows(0).IsNull(0) Then
            num = 10000
        Else
            num = mydataset.Tables("最大编号").Rows(0).Item(0) + 1
        End If
        If TextBox_用户名.Text = "" Or TextBox_密码.Text = "" Or TextBox_出生日期.Text = "" Or TextBox_身份证号.Text = "" Then
            TextBox_用户名.Text = ""
            TextBox_密码.Text = ""
            TextBox_出生日期.Text = ""
            TextBox_身份证号.Text = ""
            MsgBox("注册失败！")
        ElseIf Len(TextBox_用户名.Text) > 10 Then
            MsgBox("用户名不能超过10位！")
        ElseIf Len(TextBox_密码.Text) > 15 Then
            MsgBox("密码不能超过15位！")
        ElseIf Len(TextBox_出生日期.Text) <> 8 Then
            MsgBox("出生日期格式为20200110！")
        ElseIf Len(TextBox_身份证号.Text) <> 18 Then
            MsgBox("身份证号为18位！")
        Else
            Dim mysql As String = "insert into vip (会员用户名,密码,会员性别,出生日期,身份证号,注册时间,会员编号,积分) values ('" + TextBox_用户名.Text + "','" + TextBox_密码.Text + "','" + ComboBox_性别.SelectedItem + "','" + TextBox_出生日期.Text + "','" + TextBox_身份证号.Text + "',GETDATE(),'" & num & "','0')"
            Dim mysqlcomm As New SqlCommand(mysql, myconnection)
            myconnection.Open()
            mysqlcomm.ExecuteNonQuery()
            TextBox_用户名.Text = ""
            TextBox_密码.Text = ""
            TextBox_出生日期.Text = ""
            TextBox_身份证号.Text = ""
            MsgBox("注册成功！")
            myconnection.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub 注册账号_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class