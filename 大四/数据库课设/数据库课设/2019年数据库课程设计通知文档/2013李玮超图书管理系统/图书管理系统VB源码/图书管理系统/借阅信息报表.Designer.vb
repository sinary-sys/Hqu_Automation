<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 借阅信息报表
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.图书管理系统DataSet2 = New 图书管理系统.图书管理系统DataSet2()
        Me.BorrowReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowReportsTableAdapter = New 图书管理系统.图书管理系统DataSet2TableAdapters.BorrowReportsTableAdapter()
        CType(Me.图书管理系统DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "TBDataSet3"
        ReportDataSource1.Value = Me.BorrowReportsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "图书管理系统.借阅信息.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(749, 500)
        Me.ReportViewer1.TabIndex = 0
        '
        '图书管理系统DataSet2
        '
        Me.图书管理系统DataSet2.DataSetName = "图书管理系统DataSet2"
        Me.图书管理系统DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BorrowReportsBindingSource
        '
        Me.BorrowReportsBindingSource.DataMember = "BorrowReports"
        Me.BorrowReportsBindingSource.DataSource = Me.图书管理系统DataSet2
        '
        'BorrowReportsTableAdapter
        '
        Me.BorrowReportsTableAdapter.ClearBeforeFill = True
        '
        '借阅信息报表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 500)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "借阅信息报表"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "借阅信息报表"
        CType(Me.图书管理系统DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BorrowReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 图书管理系统DataSet2 As 图书管理系统.图书管理系统DataSet2
    Friend WithEvents BorrowReportsTableAdapter As 图书管理系统.图书管理系统DataSet2TableAdapters.BorrowReportsTableAdapter
End Class
