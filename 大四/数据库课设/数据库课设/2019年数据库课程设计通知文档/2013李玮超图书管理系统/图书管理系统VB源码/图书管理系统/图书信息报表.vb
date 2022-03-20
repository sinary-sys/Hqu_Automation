Imports System.Data.SqlClient
Public Class 图书信息报表

    Private Sub 图书信息报表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“图书管理系统DataSet1.ReaderReports”中。您可以根据需要移动或删除它。
        Me.ReaderReportsTableAdapter.Fill(Me.图书管理系统DataSet1.ReaderReports)
        'TODO:  这行代码将数据加载到表“图书管理系统DataSet.BookReports”中。您可以根据需要移动或删除它。
        Me.BookReportsTableAdapter.Fill(Me.图书管理系统DataSet.BookReports)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class