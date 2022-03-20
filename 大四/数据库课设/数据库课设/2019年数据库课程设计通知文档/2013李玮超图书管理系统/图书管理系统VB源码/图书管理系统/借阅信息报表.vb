Public Class 借阅信息报表

    Private Sub 借阅信息报表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“图书管理系统DataSet2.BorrowReports”中。您可以根据需要移动或删除它。
        Me.BorrowReportsTableAdapter.Fill(Me.图书管理系统DataSet2.BorrowReports)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class