<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataJsvDataSet = New FacturadorDesktop.DataJsvDataSet()
        Me.SQLFACTURASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLFACTURASTableAdapter = New FacturadorDesktop.DataJsvDataSetTableAdapters.SQLFACTURASTableAdapter()
        CType(Me.DataJsvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLFACTURASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SQLFACTURASBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FacturadorDesktop.rptFactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(571, 440)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataJsvDataSet
        '
        Me.DataJsvDataSet.DataSetName = "DataJsvDataSet"
        Me.DataJsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SQLFACTURASBindingSource
        '
        Me.SQLFACTURASBindingSource.DataMember = "SQLFACTURAS"
        Me.SQLFACTURASBindingSource.DataSource = Me.DataJsvDataSet
        '
        'SQLFACTURASTableAdapter
        '
        Me.SQLFACTURASTableAdapter.ClearBeforeFill = True
        '
        'frmRpFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 440)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRpFactura"
        Me.Text = "frmRpFactura"
        CType(Me.DataJsvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLFACTURASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SQLFACTURASBindingSource As BindingSource
    Friend WithEvents DataJsvDataSet As DataJsvDataSet
    Friend WithEvents SQLFACTURASTableAdapter As DataJsvDataSetTableAdapters.SQLFACTURASTableAdapter
End Class
