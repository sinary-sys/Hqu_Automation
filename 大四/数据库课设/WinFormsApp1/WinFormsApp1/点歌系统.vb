Imports System.Data.SqlClient
Public Class 用户操作界面
    Public n As Integer = 0
    Public user As String = 登录界面.user
    Public Sub 按键按下(n As Integer)
        If n = 1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
        If n = 2 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
        If n = 3 Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
        If n = 4 Then
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
        If n = 5 Then
            Button9.Enabled = False
        Else
            Button9.Enabled = True
        End If
        If n = 6 Then
            Button10.Enabled = False
        Else
            Button10.Enabled = True
        End If
        If n = 7 Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If
        If n = 8 Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = 1
        按键按下(n)
        DataGridView1.DataSource = False
        GroupBox1.Visible = True
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        Button7.Visible = True
        Button8.Visible = True
        关键字.Visible = True
        关键字.Text = ""
        Button11.Visible = False
        Button12.Visible = False
        Dim mycmd As New SqlCommand
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select * from song "
        mycmd.Connection = myconnection
        mycmd.CommandText = mysql
        Dim myadapter1 As New SqlDataAdapter(mycmd)
        Dim mydataset1 As New DataSet
        myadapter1.Fill(mydataset1, "歌曲信息表1")
        Me.DataGridView1.DataSource = mydataset1.Tables("歌曲信息表1")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        会员管理.Show()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If n = 1 Then
            If 关键字.Text = "" Then
                MsgBox("请输入关键字进行搜索！", MsgBoxStyle.OkOnly, "信息提示")
            Else
                Dim mycmd As New SqlCommand
                Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
                Dim mysql As String = "select * from song where 歌曲编号 in (select 歌曲编号 from song where 名称 like '%" & 关键字.Text & "%')"
                mycmd.Connection = myconnection
                mycmd.CommandText = mysql
                Dim myadapter1 As New SqlDataAdapter(mycmd)
                Dim mydataset1 As New DataSet
                myadapter1.Fill(mydataset1, "歌曲信息表1")
                Me.DataGridView1.DataSource = mydataset1.Tables("歌曲信息表1")
            End If
        ElseIf n = 2 Then
            If 关键字.Text = "" Then
                MsgBox("请输入关键字进行搜索！", MsgBoxStyle.OkOnly, "信息提示")
            Else
                Dim mycmd As New SqlCommand
                Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
                Dim mysq2 As String = "select * from song where 歌曲编号 like '%" & 关键字.Text & "%'"
                mycmd.Connection = myconnection
                mycmd.CommandText = mysq2
                Dim myadapter2 As New SqlDataAdapter(mycmd)
                Dim mydataset2 As New DataSet
                myadapter2.Fill(mydataset2, "歌曲信息表2")
                Me.DataGridView1.DataSource = mydataset2.Tables("歌曲信息表2")
            End If
        ElseIf n = 3 Then
            If 关键字.Text = "" Then
                MsgBox("请输入关键字进行搜索！", MsgBoxStyle.OkOnly, "信息提示")
            Else
                Dim mycmd As New SqlCommand
                Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
                Dim mysql As String = "select * from song where 歌曲拼写 like '%" & 关键字.Text & "%'"
                mycmd.Connection = myconnection
                mycmd.CommandText = mysql
                Dim myadapter3 As New SqlDataAdapter(mycmd)
                Dim mydataset3 As New DataSet
                myadapter3.Fill(mydataset3, "歌曲信息表3")
                Me.DataGridView1.DataSource = mydataset3.Tables("歌曲信息表3")
            End If
        ElseIf n = 4 Then
            If 关键字.Text = "" Then
                MsgBox("请输入关键字进行搜索！", MsgBoxStyle.OkOnly, "信息提示")
            Else
                Dim mycmd As New SqlCommand
                Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
                Dim mysql As String = "select * from song where 名称 like '%" & 关键字.Text & "%'"
                mycmd.Connection = myconnection
                mycmd.CommandText = mysql
                Dim myadapter4 As New SqlDataAdapter(mycmd)
                Dim mydataset4 As New DataSet
                myadapter4.Fill(mydataset4, "歌曲信息表4")
                Me.DataGridView1.DataSource = mydataset4.Tables("歌曲信息表4")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n = 2
        按键按下(n)
        DataGridView1.DataSource = False
        GroupBox1.Visible = True
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        Button7.Visible = True
        Button8.Visible = True
        关键字.Visible = True
        关键字.Text = ""
        Button11.Visible = False
        Button12.Visible = False
        Dim mycmd As New SqlCommand
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select * from song "
        mycmd.Connection = myconnection
        mycmd.CommandText = mysql
        Dim myadapter1 As New SqlDataAdapter(mycmd)
        Dim mydataset1 As New DataSet
        myadapter1.Fill(mydataset1, "歌曲信息表1")
        Me.DataGridView1.DataSource = mydataset1.Tables("歌曲信息表1")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        n = 3
        按键按下(n)
        DataGridView1.DataSource = False
        GroupBox1.Visible = True
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        Button7.Visible = True
        Button8.Visible = True
        关键字.Visible = True
        关键字.Text = ""
        Button11.Visible = False
        Button12.Visible = False
        Dim mycmd As New SqlCommand
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select * from song "
        mycmd.Connection = myconnection
        mycmd.CommandText = mysql
        Dim myadapter1 As New SqlDataAdapter(mycmd)
        Dim mydataset1 As New DataSet
        myadapter1.Fill(mydataset1, "歌曲信息表1")
        Me.DataGridView1.DataSource = mydataset1.Tables("歌曲信息表1")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        n = 4
        按键按下(n)
        DataGridView1.DataSource = False
        GroupBox1.Visible = True
        DataGridView1.Visible = True
        DataGridView2.Visible = False
        Button7.Visible = True
        Button8.Visible = True
        关键字.Visible = True
        关键字.Text = ""
        Button11.Visible = False
        Button12.Visible = False
        Dim mycmd As New SqlCommand
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select * from song "
        mycmd.Connection = myconnection
        mycmd.CommandText = mysql
        Dim myadapter1 As New SqlDataAdapter(mycmd)
        Dim mydataset1 As New DataSet
        myadapter1.Fill(mydataset1, "歌曲信息表1")
        Me.DataGridView1.DataSource = mydataset1.Tables("歌曲信息表1")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        n = 5
        按键按下(n)
        DataGridView1.DataSource = False
        GroupBox1.Visible = True
        关键字.Text = ""
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        关键字.Visible = False
        Button11.Visible = False
        Button12.Visible = True


        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select * from 我的歌单"
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "我的歌单")
        DataGridView2.DataSource = mydataset.Tables("我的歌单")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        n = 6
        按键按下(n)
        DataGridView1.DataSource = False
        GroupBox1.Visible = True
        关键字.Text = ""
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        关键字.Visible = False
        Button11.Visible = True
        Button12.Visible = False

        DataGridView2.DataSource = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        n = 7
        按键按下(n)
        DataGridView1.DataSource = False
        GroupBox1.Visible = True
        关键字.Text = ""
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        关键字.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select * from 歌曲排行榜"
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "歌曲排行榜")
        DataGridView2.DataSource = mydataset.Tables("歌曲排行榜")

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim song As Integer = 0
        Dim count As Integer = 0
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        If e.RowIndex < DataGridView1.RowCount - 1 Then
            count += 1
            song = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim mysqlG As String = "INSERT INTO 我的歌单 SELECT 歌曲编号,名称 FROM song WHERE 歌曲编号 = '" + CStr(song) + "'"
            Dim myadapterG As New SqlDataAdapter(mysqlG, myconnection)
            Dim mydatasetG As New DataSet
            If MsgBox("是否要添加该歌曲至我的歌单？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "添加确认") = MsgBoxResult.Yes Then
                myadapterG.Fill(mydatasetG, "歌曲信息表")
                MsgBox("已添加'" & DataGridView1.Rows(e.RowIndex).Cells(1).Value & "'至我的歌单")
            End If
            Dim mysqlcount As String = "UPDATE 歌曲排行榜 SET 总点击率 += " & count & " WHERE 歌曲编号 = '" & song & "'"
            Dim myadaptercount As New SqlDataAdapter(mysqlcount, myconnection)
            Dim mydatasetcount As New DataSet
            myadaptercount.Fill(mydatasetcount, "歌曲排行榜")
            Dim mysqlcount1 As String = "UPDATE vip SET 积分 += " & count & " WHERE 会员用户名 = '" & user & "'"
            Dim myadaptercount1 As New SqlDataAdapter(mysqlcount1, myconnection)
            Dim mydatasetcount1 As New DataSet
            myadaptercount1.Fill(mydatasetcount1, "歌曲排行榜")
        End If
    End Sub
    Public Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Dim sno As Integer = DataGridView2.CurrentRow.Cells(0).Value
        DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
            Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
            Dim mycmd As String = "delete from 我的歌单 where 歌曲编号='" & sno & "'"
            Dim mycomm As New SqlCommand(mycmd, myconnection)
            myconnection.Open()
            mycomm.ExecuteNonQuery()
            MsgBox("已成功删除！")
            myconnection.Close()
            mycmd = "select * from 我的歌单"
            Dim da As New SqlDataAdapter(mycmd, myconnection)
            Dim ds As New DataSet
            da.Fill(ds, "我的歌单")
        DataGridView2.DataSource = ds.Tables("我的歌单")
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Dim mycmd As New SqlCommand
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select * from song "
        mycmd.Connection = myconnection
        mycmd.CommandText = mysql
        Dim myadapter1 As New SqlDataAdapter(mycmd)
        Dim mydataset1 As New DataSet
        myadapter1.Fill(mydataset1, "歌曲信息表1")
        Me.DataGridView1.DataSource = mydataset1.Tables("歌曲信息表1")
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class