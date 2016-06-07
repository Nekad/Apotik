<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LprPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LprPembelian))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.view_pembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.apotekDataSet = New Apotek.apotekDataSet
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.bt_Keluar = New System.Windows.Forms.ToolStripButton
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.view_pembelianTableAdapter = New Apotek.apotekDataSetTableAdapters.view_pembelianTableAdapter
        CType(Me.view_pembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apotekDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'view_pembelianBindingSource
        '
        Me.view_pembelianBindingSource.DataMember = "view_pembelian"
        Me.view_pembelianBindingSource.DataSource = Me.apotekDataSet
        '
        'apotekDataSet
        '
        Me.apotekDataSet.DataSetName = "apotekDataSet"
        Me.apotekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Keluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1280, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bt_Keluar
        '
        Me.bt_Keluar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bt_Keluar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bt_Keluar.Image = CType(resources.GetObject("bt_Keluar.Image"), System.Drawing.Image)
        Me.bt_Keluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bt_Keluar.Name = "bt_Keluar"
        Me.bt_Keluar.Size = New System.Drawing.Size(23, 22)
        Me.bt_Keluar.Text = "Tutup"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "apotekDataSet_view_pembelian"
        ReportDataSource1.Value = Me.view_pembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Apotek.LprPembalian.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1280, 607)
        Me.ReportViewer1.TabIndex = 10
        '
        'view_pembelianTableAdapter
        '
        Me.view_pembelianTableAdapter.ClearBeforeFill = True
        '
        'LprPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 632)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "LprPembelian"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Laporan Pembelian"
        CType(Me.view_pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apotekDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_Keluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents view_pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotekDataSet As Apotek.apotekDataSet
    Friend WithEvents view_pembelianTableAdapter As Apotek.apotekDataSetTableAdapters.view_pembelianTableAdapter
End Class
