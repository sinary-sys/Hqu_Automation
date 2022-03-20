Imports System.Data.SqlClient
Public Class 会员信息

    Private Sub 返回_Click(sender As Object, e As EventArgs) Handles 返回.Click
        Me.Hide()
    End Sub
    Private Sub 查询_Click(sender As Object, e As EventArgs) Handles 查询.Click
        If 会员编号.Text = "" And 会员用户名.Text = "" And 身份证号.Text = "" Then
            Dim mysql As String = "SELECT * FROM vip"
            Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
            Dim myadapter As New SqlDataAdapter(mysql, myconnection)
            Dim mydataset As New DataSet
            myadapter.Fill(mydataset, "用户信息表")
            DataGridView1.DataSource = mydataset.Tables("用户信息表")
        Else
            Dim mysql As String = "SELECT * FROM vip where 会员编号='" + 会员编号.Text + "'or 会员用户名='" + 会员用户名.Text + "'or 身份证号='" + 身份证号.Text + "'"
            Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
            Dim myadapter As New SqlDataAdapter(mysql, myconnection)
            Dim mydataset As New DataSet
            myadapter.Fill(mydataset, "用户信息表")
            DataGridView1.DataSource = mydataset.Tables("用户信息表")
        End If
    End Sub
    Private Sub 增加用户_Click(sender As Object, e As EventArgs) Handles 增加用户.Click
        Dim mysql As String = "SELECT * FROM vip"
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "用户信息表")
        Dim _row As DataRow = mydataset.Tables("用户信息表").NewRow
        _row(0) = DataGridView1.CurrentRow.Cells(0).Value
        _row(1) = DataGridView1.CurrentRow.Cells(1).Value
        _row(2) = DataGridView1.CurrentRow.Cells(2).Value
        _row(3) = DataGridView1.CurrentRow.Cells(3).Value
        _row(4) = DataGridView1.CurrentRow.Cells(4).Value
        _row(5) = DataGridView1.CurrentRow.Cells(5).Value
        _row(6) = DataGridView1.CurrentRow.Cells(6).Value
        _row(7) = DataGridView1.CurrentRow.Cells(7).Value
        Dim mysql1 As String = "select * from vip where 会员用户名='" & DataGridView1.CurrentRow.Cells(1).Value & "'"
        Dim myadapter1 As New SqlDataAdapter(mysql1, myconnection)
        Dim mydataset1 As New DataSet
        myadapter1.Fill(mydataset1, "用户重复")
        If mydataset1.Tables("用户重复").Rows.Count <= 0 Then
            If (Not IsDBNull(DataGridView1.CurrentRow.Cells(1).Value)) And (Not IsDBNull(DataGridView1.CurrentRow.Cells(0).Value)) Then
                MsgBox("添加用户成功！")
                mydataset.Tables("用户信息表").Rows.Add(_row)
                Dim cmd As SqlCommandBuilder = New SqlCommandBuilder(myadapter)
                myadapter.Update(mydataset, "用户信息表")
            Else
                MsgBox("编号和用户名不能为空！")
            End If
        Else
            MsgBox("重复添加失败！")
        End If
    End Sub
    Private Sub 删除用户_Click(sender As Object, e As EventArgs) Handles 删除用户.Click
        Dim sno As Integer = DataGridView1.CurrentRow.Cells(0).Value
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mycmd As String = "delete from vip where 会员编号='" & sno & "'"
        Dim mycomm As New SqlCommand(mycmd, myconnection)
        myconnection.Open()
        mycomm.ExecuteNonQuery()
        MsgBox("已成功删除")
        myconnection.Close()
        mycmd = "select * from vip"
        Dim da As New SqlDataAdapter(mycmd, myconnection)
        Dim ds As New DataSet
        da.Fill(ds, "用户信息表")
        DataGridView1.DataSource = ds.Tables("用户信息表")
    End Sub
    Private Sub 修改用户_Click(sender As Object, e As EventArgs) Handles 修改用户.Click

        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mycmd As String = "update vip set 会员用户名='" & DataGridView1.CurrentRow.Cells(1).Value & "',会员性别='" & DataGridView1.CurrentRow.Cells(2).Value & "',出生日期='" & DataGridView1.CurrentRow.Cells(3).Value & "',身份证号='" & DataGridView1.CurrentRow.Cells(4).Value & "',注册时间='" & DataGridView1.CurrentRow.Cells(5).Value & "',积分='" & DataGridView1.CurrentRow.Cells(6).Value & "',密码='" & DataGridView1.CurrentRow.Cells(7).Value & "'where 会员编号='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        Dim mycomm As New SqlCommand(mycmd, myconnection)
        myconnection.Open()
        mycomm.ExecuteNonQuery()
        MsgBox("已成功修改！")
        myconnection.Close()
        mycmd = "select * from vip"
        Dim da As New SqlDataAdapter(mycmd, myconnection)
        Dim ds As New DataSet
        da.Fill(ds, "用户信息表")
        DataGridView1.DataSource = ds.Tables("用户信息表")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub
End Class