<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKategori))
        Me.bt_Cari = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.bt_Simpan = New System.Windows.Forms.ToolStripButton
        Me.bt_Baru = New System.Windows.Forms.ToolStripButton
        Me.bt_Batal = New System.Windows.Forms.ToolStripButton
        Me.TextCari = New System.Windows.Forms.TextBox
        Me.RadioTidak = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextID = New System.Windows.Forms.TextBox
        Me.RadioYa = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextKategori = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label14 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_Cari
        '
        Me.bt_Cari.Location = New System.Drawing.Point(295, 21)
        Me.bt_Cari.Name = "bt_Cari"
        Me.bt_Cari.Size = New System.Drawing.Size(55, 23)
        Me.bt_Cari.TabIndex = 26
        Me.bt_Cari.Text = "Cari"
        Me.bt_Cari.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Batal, Me.bt_Simpan, Me.bt_Baru})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 467)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(408, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bt_Simpan
        '
        Me.bt_Simpan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bt_Simpan.Image = CType(resources.GetObject("bt_Simpan.Image"), System.Drawing.Image)
        Me.bt_Simpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bt_Simpan.Name = "bt_Simpan"
        Me.bt_Simpan.Size = New System.Drawing.Size(67, 22)
        Me.bt_Simpan.Text = "Simpan"
        '
        'bt_Baru
        '
        Me.bt_Baru.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bt_Baru.Image = CType(resources.GetObject("bt_Baru.Image"), System.Drawing.Image)
        Me.bt_Baru.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bt_Baru.Name = "bt_Baru"
        Me.bt_Baru.Size = New System.Drawing.Size(51, 22)
        Me.bt_Baru.Text = "Baru"
        '
        'bt_Batal
        '
        Me.bt_Batal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bt_Batal.Image = CType(resources.GetObject("bt_Batal.Image"), System.Drawing.Image)
        Me.bt_Batal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bt_Batal.Name = "bt_Batal"
        Me.bt_Batal.Size = New System.Drawing.Size(53, 22)
        Me.bt_Batal.Text = "Batal"
        '
        'TextCari
        '
        Me.TextCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCari.Location = New System.Drawing.Point(110, 23)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(179, 21)
        Me.TextCari.TabIndex = 25
        '
        'RadioTidak
        '
        Me.RadioTidak.AutoSize = True
        Me.RadioTidak.Location = New System.Drawing.Point(47, 3)
        Me.RadioTidak.Name = "RadioTidak"
        Me.RadioTidak.Size = New System.Drawing.Size(52, 17)
        Me.RadioTidak.TabIndex = 19
        Me.RadioTidak.Text = "Tidak"
        Me.RadioTidak.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Kategori"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Aktif"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID Kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kategori"
        '
        'TextID
        '
        Me.TextID.Enabled = False
        Me.TextID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(110, 26)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(240, 21)
        Me.TextID.TabIndex = 4
        '
        'RadioYa
        '
        Me.RadioYa.AutoSize = True
        Me.RadioYa.Location = New System.Drawing.Point(3, 3)
        Me.RadioYa.Name = "RadioYa"
        Me.RadioYa.Size = New System.Drawing.Size(38, 17)
        Me.RadioYa.TabIndex = 18
        Me.RadioYa.Text = "Ya"
        Me.RadioYa.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioYa)
        Me.Panel2.Controls.Add(Me.RadioTidak)
        Me.Panel2.Location = New System.Drawing.Point(110, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 23)
        Me.Panel2.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextKategori)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 125)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'TextKategori
        '
        Me.TextKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKategori.Location = New System.Drawing.Point(110, 53)
        Me.TextKategori.Name = "TextKategori"
        Me.TextKategori.Size = New System.Drawing.Size(240, 21)
        Me.TextKategori.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bt_Cari)
        Me.GroupBox2.Controls.Add(Me.TextCari)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 280)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 60)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(372, 213)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(408, 50)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Data Master Kategori"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(408, 492)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmKategori"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Master Kategori"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_Cari As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_Simpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents bt_Baru As System.Windows.Forms.ToolStripButton
    Friend WithEvents bt_Batal As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents RadioTidak As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextID As System.Windows.Forms.TextBox
    Friend WithEvents RadioYa As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextKategori As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
