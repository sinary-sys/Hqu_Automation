Imports System.Data.SqlClient

Public Class 修改密码

    Private Sub 修改密码_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strConnection As String = "Server=localhost;Database=旅行社信息管理系统;Integrated Security=SSPI"
        Dim myConnection As SqlConnection = New SqlConnection(strConnection)

        Dim dl As New DataSet
        Dim denglu = "select * from 用户表 where 用户名='" + TextBox用户名.Text + "' and 密码='" + TextBox旧密码.Text + "'"
        Dim dengluadpter As New SqlClient.SqlDataAdapter(denglu, myConnection)
        dengluadpter.Fill(dl, "1")
        If dl.Tables("1").Rows.Count = 0 Then
            MsgBox("用户或密码错误！")
        Else

            Dim gx = "update 用户表 set 密码 ='" + TextBox新密码.Text + "'where 用户表.用户名='" + TextBox用户名.Text + "' "
            Dim gxadpter As New SqlClient.SqlCommand(gx, myConnection)
            myConnection.Open()
            Try

                gxadpter.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            myConnection.Close()
            MsgBox("修改成功！")
        End If

    End Sub
End Class