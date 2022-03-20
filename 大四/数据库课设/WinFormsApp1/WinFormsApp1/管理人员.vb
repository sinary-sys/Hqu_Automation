Imports System.Data.SqlClient
Public Class 管理人员
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub 管理人员_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As New SqlConnection("Data Source=LAPTOP-JSPLDQ5R;Initial Catalog=KTV;Integrated Security=True")
        Dim mysql As String = "select 编号,管理名 from manager "
        Dim myadapter As New SqlDataAdapter(mysql, myconnection)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "管理员")
        DataGridView1.DataSource = mydataset.Tables("管理员")
    End Sub
End Class