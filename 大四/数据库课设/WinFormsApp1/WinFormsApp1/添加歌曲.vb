Imports System.Data.SqlClient
Public Class 歌曲管理
    Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If 歌曲编号.Text = "" Then
            MsgBox("先填入歌曲编号！", MsgBoxStyle.OkOnly, "信息提示")
        Else
            Dim mysql3 As String = "SELECT * FROM song"
            Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
            Dim myadapter3 As New SqlDataAdapter(mysql3, myconnection)
            Dim mydataset3 As New DataSet
            myadapter3.Fill(mydataset3, "歌曲信息表")
            Dim _row As DataRow = mydataset3.Tables("歌曲信息表").NewRow
            _row(0) = Me.歌曲编号.Text
            _row(1) = Me.名称.Text.ToString
            _row(2) = Me.歌手编号.Text
            _row(3) = Me.歌手姓名.Text.ToString
            _row(4) = Me.语种.Text.ToString
            _row(5) = Me.歌曲类型.Text.ToString
            _row(6) = Me.文件路径.Text.ToString
            _row(7) = Me.歌曲拼写.Text.ToString
            _row(8) = Me.地区.Text.ToString
            mydataset3.Tables("歌曲信息表").Rows.Add(_row)
            Dim cmd As SqlCommandBuilder = New SqlCommandBuilder(myadapter3)
            myadapter3.Update(mydataset3, "歌曲信息表")

            Dim mysql33 As String = "SELECT * FROM 歌曲排行榜"
            Dim myadapter33 As New SqlDataAdapter(mysql33, myconnection)
            Dim mydataset33 As New DataSet
            myadapter33.Fill(mydataset33, "歌曲排行榜")
            Dim _row3 As DataRow = mydataset33.Tables("歌曲排行榜").NewRow
            _row3(0) = CInt(Me.歌曲编号.Text)
            _row3(1) = Me.名称.Text.ToString
            _row3(2) = 0
            _row3(3) = 0
            _row3(4) = 0
            _row3(5) = 0
            mydataset33.Tables("歌曲排行榜").Rows.Add(_row3)
            Dim cmd3 As SqlCommandBuilder = New SqlCommandBuilder(myadapter33)
            myadapter33.Update(mydataset33, "歌曲排行榜")
            MsgBox("添加成功！")

            '歌曲编号.Text = "" : 名称.Text = ""
            '歌手编号.Text = "" : 语种.Text = ""
            '歌手姓名.Text = ""
            '歌曲类型.Text = "" : 文件路径.Text = ""
            '歌曲拼写.Text = "" : 地区.Text = ""
            歌曲表.DataSource = mydataset3.Tables("歌曲信息表")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles 歌曲表.CellContentClick

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If 歌曲编号.Text = "" And 名称.Text = "" Then
            MsgBox("先填入需要删除的歌曲的编号或名称！", MsgBoxStyle.OkOnly, "信息提示")
        ElseIf MsgBox("是否要删除该歌曲信息？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除确认") = MsgBoxResult.Yes Then
            If 歌曲编号.Text <> "" And 名称.Text = "" Then
                Dim mysql4 As String = "DELETE FROM song WHERE 歌曲编号 ='" + 歌曲编号.Text + "' "
                Dim myadapter4 As New SqlDataAdapter(mysql4, myconnection)
                Dim mydataset4 As New DataSet
                myadapter4.Fill(mydataset4, "歌曲信息表")
                Dim mysql44 As String = "DELETE FROM 歌曲排行榜 WHERE 歌曲编号 ='" + 歌曲编号.Text + "'"
                Dim myadapter44 As New SqlDataAdapter(mysql44, myconnection)
                Dim mydataset44 As New DataSet
                myadapter44.Fill(mydataset44, "歌曲排行榜")
                MsgBox("删除成功！")
                歌曲编号.Text = "" : 名称.Text = ""
                Dim mysql3 As String = "SELECT * FROM song"
                Dim myadapter3 As New SqlDataAdapter(mysql3, myconnection)
                Dim mydataset3 As New DataSet
                myadapter3.Fill(mydataset3, "歌曲信息表")
                歌曲表.DataSource = mydataset3.Tables("歌曲信息表")
            ElseIf 歌曲编号.Text = "" And 名称.Text <> "" Then
                Dim mysql4 As String = "DELETE FROM song WHERE 歌曲编号 ='" + 歌曲编号.Text + "'or 名称 ='" + 名称.Text + "' "
                Dim myadapter4 As New SqlDataAdapter(mysql4, myconnection)
                Dim mydataset4 As New DataSet
                myadapter4.Fill(mydataset4, "歌曲信息表")
                Dim mysql44 As String = "DELETE FROM 歌曲排行榜 WHERE 歌曲编号 ='" + 歌曲编号.Text + "' or 名称 ='" + 名称.Text + "'"
                Dim myadapter44 As New SqlDataAdapter(mysql44, myconnection)
                Dim mydataset44 As New DataSet
                myadapter44.Fill(mydataset44, "歌曲排行榜")
                MsgBox("删除成功！")
                歌曲编号.Text = "" : 名称.Text = ""
                Dim mysql3 As String = "SELECT * FROM song"
                Dim myadapter3 As New SqlDataAdapter(mysql3, myconnection)
                Dim mydataset3 As New DataSet
                myadapter3.Fill(mydataset3, "歌曲信息表")
                歌曲表.DataSource = mydataset3.Tables("歌曲信息表")
            ElseIf 歌曲编号.Text <> "" And 名称.Text <> "" Then
                Dim mysql4 As String = "DELETE FROM song WHERE 歌曲编号 ='" + 歌曲编号.Text + "'and 名称 ='" + 名称.Text + "' "
                Dim myadapter4 As New SqlDataAdapter(mysql4, myconnection)
                Dim mydataset4 As New DataSet
                myadapter4.Fill(mydataset4, "歌曲信息表")
                Dim mysql44 As String = "DELETE FROM 歌曲排行榜 WHERE 歌曲编号 ='" + 歌曲编号.Text + "' and 名称 ='" + 名称.Text + "'"
                Dim myadapter44 As New SqlDataAdapter(mysql44, myconnection)
                Dim mydataset44 As New DataSet
                myadapter44.Fill(mydataset44, "歌曲排行榜")
                MsgBox("删除成功！")
                歌曲编号.Text = "" : 名称.Text = ""
                Dim mysql3 As String = "SELECT * FROM song"
                Dim myadapter3 As New SqlDataAdapter(mysql3, myconnection)
                Dim mydataset3 As New DataSet
                myadapter3.Fill(mydataset3, "歌曲信息表")
                歌曲表.DataSource = mydataset3.Tables("歌曲信息表")
            End If

        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mysql3 As String = "SELECT * FROM song"
        Dim myadapter3 As New SqlDataAdapter(mysql3, myconnection)
        Dim mydataset3 As New DataSet
        myadapter3.Fill(mydataset3, "歌曲信息表")
        歌曲表.DataSource = mydataset3.Tables("歌曲信息表")
    End Sub

    Private Sub 歌曲管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql3 As String = "SELECT * FROM song"
        Dim myadapter3 As New SqlDataAdapter(mysql3, myconnection)
        Dim mydataset3 As New DataSet
        myadapter3.Fill(mydataset3, "歌曲信息表")
        歌曲表.DataSource = mydataset3.Tables("歌曲信息表")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mycmd As String = "update song set 名称='" & 歌曲表.CurrentRow.Cells(1).Value & "',歌手编号='" & 歌曲表.CurrentRow.Cells(2).Value & "',歌手姓名='" & 歌曲表.CurrentRow.Cells(3).Value & "',语种='" & 歌曲表.CurrentRow.Cells(4).Value & "',歌曲类型='" & 歌曲表.CurrentRow.Cells(5).Value & "',文件路径='" & 歌曲表.CurrentRow.Cells(6).Value & "',歌曲拼写='" & 歌曲表.CurrentRow.Cells(7).Value & "',地区='" & 歌曲表.CurrentRow.Cells(8).Value & "'where 歌曲编号='" & 歌曲表.CurrentRow.Cells(0).Value & "'"
        Dim mycomm As New SqlCommand(mycmd, myconnection)
        myconnection.Open()
        mycomm.ExecuteNonQuery()
        MsgBox("已成功修改！")
        myconnection.Close()
        mycmd = "select * from song"
        Dim da As New SqlDataAdapter(mycmd, myconnection)
        Dim ds As New DataSet
        da.Fill(ds, "歌曲")
        歌曲表.DataSource = ds.Tables("歌曲")
    End Sub
End Class