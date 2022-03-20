<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 图书信息报表
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
        Me.图书管理系统DataSet = New 图书管理系统.图书管理系统DataSet()
        Me.BookReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookReportsTableAdapter = New 图书管理系统.图书管理系统DataSetTableAdapters.BookReportsTableAdapter()
        Me.图书管理系统DataSet1 = New 图书管理系统.图书管理系统DataSet1()
        Me.ReaderReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReaderReportsTableAdapter = New 图书管理系统.图书管理系统DataSet1TableAdapters.ReaderReportsTableAdapter()
        CType(Me.图书管理系统DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.图书管理系统DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReaderReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "TBDataSet1"
        ReportDataSource1.Value = Me.BookReportsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "图书管理系统.图书.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-4, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(832, 500)
        Me.ReportViewer1.TabIndex = 0
        '
        '图书管理系统DataSet
        '
        Me.图书管理系统DataSet.DataSetName = "图书管理系统DataSet"
        Me.图书管理系统DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookReportsBindingSource
        '
        Me.BookReportsBindingSource.DataMember = "BookReports"
        Me.BookReportsBindingSource.DataSource = Me.图书管理系统DataSet
        '
        'BookReportsTableAdapter
        '
        Me.BookReportsTableAdapter.ClearBeforeFill = True
        '
        '图书管理系统DataSet1
        '
        Me.图书管理系统DataSet1.DataSetName = "图书管理系统DataSet1"
        Me.图书管理系统DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReaderReportsBindingSource
        '
        Me.ReaderReportsBindingSource.DataMember = "ReaderReports"
        Me.ReaderReportsBindingSource.DataSource = Me.图书管理系统DataSet1
        '
        'ReaderReportsTableAdapter
        '
        Me.ReaderReportsTableAdapter.ClearBeforeFill = True
        '
        '图书信息报表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 495)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "图书信息报表"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "图书信息报表"
        CType(Me.图书管理系统DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.图书管理系统DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReaderReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BookReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 图书管理系统DataSet As 图书管理系统.图书管理系统DataSet
    Friend WithEvents BookReportsTableAdapter As 图书管理系统.图书管理系统DataSetTableAdapters.BookReportsTableAdapter
    Friend WithEvents ReaderReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 图书管理系统DataSet1 As 图书管理系统.图书管理系统DataSet1
    Friend WithEvents ReaderReportsTableAdapter As 图书管理系统.图书管理系统DataSet1TableAdapters.ReaderReportsTableAdapter
End Class
