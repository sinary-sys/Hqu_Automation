Imports System.Data.SqlClient
Public Class 管理员管理
    Dim myconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=学生宿舍水电费管理系统;Integrated Security=True")
    Dim mycmd As New SqlCommand
    'Private Sub Label3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label3.Click

    'End Sub

    'Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

    'End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim mysql = "delete from 用户表 where 用户编号 = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已删除")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 用户表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "用户表")
        Me.DataGridView1.DataSource = mydataset.Tables("用户表")
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 用户表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "用户表")
        Me.DataGridView1.DataSource = mydataset.Tables("用户表")
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim mysql As String = "insert into 用户表 values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "')"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已成功插入记录") '直接进行刷新显示
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 用户表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "用户表")
        Me.DataGridView1.DataSource = mydataset.Tables("用户表")
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Dim mysql = " update 用户表 set 用户名 = '" & TextBox2.Text & "'where 用户编号 = '" & TextBox1.Text & "'update 用户表 set 用户等级 = '" & ComboBox1.Text & "'where 用户编号 = '" & TextBox1.Text & "'update 用户表 set 用户密码 = '" & TextBox3.Text & "'where 用户编号 = '" & TextBox1.Text & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("修改完毕")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 用户表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "用户表")
        Me.DataGridView1.DataSource = mydataset.Tables("用户表")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        登录.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 住宿表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "住宿表")
        Me.DataGridView2.DataSource = mydataset.Tables("住宿表")
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        Dim mysql As String = "insert into 住宿表 values('" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已成功插入记录") '直接进行刷新显示
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 住宿表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "住宿表")
        Me.DataGridView2.DataSource = mydataset.Tables("住宿表")
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
        Dim mysql = "delete from 住宿表 where 房号 = '" & DataGridView2.CurrentRow.Cells(0).Value & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已删除")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 住宿表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "住宿表")
        Me.DataGridView2.DataSource = mydataset.Tables("住宿表")
    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        Dim mysql = " update 住宿表 set 班级 = '" & TextBox5.Text & "'where 房号 =  '" & DataGridView2.CurrentRow.Cells(0).Value & "'update 住宿表 set 人数 = '" & TextBox6.Text & "'where 房号 =  '" & DataGridView2.CurrentRow.Cells(0).Value & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("修改完毕")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 住宿表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "住宿表")
        Me.DataGridView2.DataSource = mydataset.Tables("住宿表")
    End Sub

    '    Private Sub Label19_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label19.Click

    '    End Sub

    '    Private Sub Label23_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label23.Click

    '    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 水电定额及单价表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电定额及单价表")
        Me.DataGridView3.DataSource = mydataset.Tables("水电定额及单价表")
    End Sub

    Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button12.Click
        Dim mysql As String = "insert into 水电定额及单价表 values('" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "')"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已成功插入记录") '直接进行刷新显示
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 水电定额及单价表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电定额及单价表")
        Me.DataGridView3.DataSource = mydataset.Tables("水电定额及单价表")
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.Click
        Dim mysql = "delete from 水电定额及单价表 where 收费编号 = '" & DataGridView3.CurrentRow.Cells(0).Value & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已删除")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 水电定额及单价表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电定额及单价表")
        Me.DataGridView3.DataSource = mydataset.Tables("水电定额及单价表")
    End Sub

    Private Sub Button14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
        Dim mysql = " update 水电定额及单价表 set 水定额 = '" & TextBox8.Text & "'where 收费编号 =  '" & DataGridView3.CurrentRow.Cells(0).Value & "'update 水电定额及单价表 set 电定额 = '" & TextBox9.Text & "'where 收费编号 =  '" & DataGridView3.CurrentRow.Cells(0).Value & "'update 水电定额及单价表 set 水价 = '" & TextBox10.Text & "'where 收费编号 =  '" & DataGridView3.CurrentRow.Cells(0).Value & "'update 水电定额及单价表 set 电价 = '" & TextBox11.Text & "'where 收费编号 =  '" & DataGridView3.CurrentRow.Cells(0).Value & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("修改完毕")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 水电定额及单价表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电定额及单价表")
        Me.DataGridView3.DataSource = mydataset.Tables("水电定额及单价表")
    End Sub
    Private Sub Button15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.Click
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 水电费表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电费表")
        Me.DataGridView4.DataSource = mydataset.Tables("水电费表")
    End Sub

    Private Sub Button16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button16.Click
        Dim mysql As String = "insert into 水电费表 values('" & TextBox12.Text & "','" & DateTimePicker1.Value & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "''" & TextBox17.Text & "''" & TextBox18.Text & "')"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已成功插入记录") '直接进行刷新显示
        mycmd.Connection = myconn
        mycmd.CommandText = "select * From 水电费表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电费表")
        Me.DataGridView4.DataSource = mydataset.Tables("水电费表")
    End Sub

    Private Sub Button17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button17.Click
        Dim mysql = "delete from 水电费表 where 房号 = '" & DataGridView4.CurrentRow.Cells(0).Value & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("已删除")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 水电费表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电费表")
        Me.DataGridView4.DataSource = mydataset.Tables("水电费表")
    End Sub

    Private Sub Button18_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button18.Click
        Dim mysql = " update 水电费表 set 日期 = '" & DateTimePicker1.Value & "'where 房号 =  '" & DataGridView4.CurrentRow.Cells(0).Value & "'update 水电费表 set 本次水表 = '" & TextBox14.Text & "'where 房号 =  '" & DataGridView4.CurrentRow.Cells(0).Value & "'update 水电费表 set 上次水表= '" & TextBox15.Text & "'where 房号 =  '" & DataGridView4.CurrentRow.Cells(0).Value & "'update 水电费表 set 本次电表 = '" & TextBox16.Text & "'where 房号 =  '" & DataGridView4.CurrentRow.Cells(0).Value & "'update 水电费表 set 上次电表 = '" & TextBox17.Text & "'where 房号 =  '" & DataGridView4.CurrentRow.Cells(0).Value & "'update 水电费表 set 收费编号 = '" & TextBox18.Text & "'where 房号 =  '" & DataGridView4.CurrentRow.Cells(0).Value & "'"
        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
        MsgBox("修改完毕")
        mycmd.Connection = myconn '直接进行刷新
        mycmd.CommandText = "select * From 水电费表 "
        Dim myadapter As SqlDataAdapter = New SqlDataAdapter(mycmd)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "水电费表")
        Me.DataGridView4.DataSource = mydataset.Tables("水电费表")
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub 管理员管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Me.Hide()
        修改密码.Show()
    End Sub
End Class