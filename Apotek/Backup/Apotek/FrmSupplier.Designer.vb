<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplier))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.bt_Keluar = New System.Windows.Forms.ToolStripButton
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_Baru = New System.Windows.Forms.Button
        Me.bt_Tutup = New System.Windows.Forms.Button
        Me.bt_Batal = New System.Windows.Forms.Button
        Me.bt_Simpan = New System.Windows.Forms.Button
        Me.ComboCari = New System.Windows.Forms.ComboBox
        Me.bt_Cari = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextCari = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextTelp = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RadioYa = New System.Windows.Forms.RadioButton
        Me.RadioTidak = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextKota = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextID = New System.Windows.Forms.TextBox
        Me.TextSupplier = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextAlamat = New System.Windows.Forms.TextBox
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add.png")
        Me.ImageList1.Images.SetKeyName(1, "disk.png")
        Me.ImageList1.Images.SetKeyName(2, "cancel.png")
        Me.ImageList1.Images.SetKeyName(3, "cross.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Keluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(854, 25)
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
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(854, 50)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Data Master Supplier"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.bt_Baru)
        Me.GroupBox2.Controls.Add(Me.bt_Tutup)
        Me.GroupBox2.Controls.Add(Me.bt_Batal)
        Me.GroupBox2.Controls.Add(Me.bt_Simpan)
        Me.GroupBox2.Controls.Add(Me.ComboCari)
        Me.GroupBox2.Controls.Add(Me.bt_Cari)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextCari)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(830, 317)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'bt_Baru
        '
        Me.bt_Baru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Baru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Baru.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Baru.ImageIndex = 0
        Me.bt_Baru.ImageList = Me.ImageList1
        Me.bt_Baru.Location = New System.Drawing.Point(406, 271)
        Me.bt_Baru.Name = "bt_Baru"
        Me.bt_Baru.Size = New System.Drawing.Size(100, 40)
        Me.bt_Baru.TabIndex = 34
        Me.bt_Baru.Text = "Baru"
        Me.bt_Baru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Baru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Baru.UseVisualStyleBackColor = True
        '
        'bt_Tutup
        '
        Me.bt_Tutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Tutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Tutup.ImageIndex = 3
        Me.bt_Tutup.ImageList = Me.ImageList1
        Me.bt_Tutup.Location = New System.Drawing.Point(724, 271)
        Me.bt_Tutup.Name = "bt_Tutup"
        Me.bt_Tutup.Size = New System.Drawing.Size(100, 40)
        Me.bt_Tutup.TabIndex = 33
        Me.bt_Tutup.Text = "Tutup"
        Me.bt_Tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Tutup.UseVisualStyleBackColor = True
        '
        'bt_Batal
        '
        Me.bt_Batal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Batal.ImageIndex = 2
        Me.bt_Batal.ImageList = Me.ImageList1
        Me.bt_Batal.Location = New System.Drawing.Point(618, 271)
        Me.bt_Batal.Name = "bt_Batal"
        Me.bt_Batal.Size = New System.Drawing.Size(100, 40)
        Me.bt_Batal.TabIndex = 32
        Me.bt_Batal.Text = "Batal"
        Me.bt_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Batal.UseVisualStyleBackColor = True
        '
        'bt_Simpan
        '
        Me.bt_Simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Simpan.ImageIndex = 1
        Me.bt_Simpan.ImageList = Me.ImageList1
        Me.bt_Simpan.Location = New System.Drawing.Point(512, 271)
        Me.bt_Simpan.Name = "bt_Simpan"
        Me.bt_Simpan.Size = New System.Drawing.Size(100, 40)
        Me.bt_Simpan.TabIndex = 31
        Me.bt_Simpan.Text = "Simpan"
        Me.bt_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Simpan.UseVisualStyleBackColor = True
        '
        'ComboCari
        '
        Me.ComboCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCari.FormattingEnabled = True
        Me.ComboCari.Items.AddRange(New Object() {"ID Supplier", "Supplier", "Alamat", "Kota"})
        Me.ComboCari.Location = New System.Drawing.Point(132, 23)
        Me.ComboCari.Name = "ComboCari"
        Me.ComboCari.Size = New System.Drawing.Size(100, 21)
        Me.ComboCari.TabIndex = 23
        Me.ComboCari.Text = "ID Supplier"
        '
        'bt_Cari
        '
        Me.bt_Cari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Cari.Location = New System.Drawing.Point(700, 21)
        Me.bt_Cari.Name = "bt_Cari"
        Me.bt_Cari.Size = New System.Drawing.Size(70, 23)
        Me.bt_Cari.TabIndex = 19
        Me.bt_Cari.Text = "Cari"
        Me.bt_Cari.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pencarian Data"
        '
        'TextCari
        '
        Me.TextCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCari.Location = New System.Drawing.Point(238, 23)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(456, 21)
        Me.TextCari.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 61)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(818, 204)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextAlamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextTelp)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextKota)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.TextSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(830, 170)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Telepon"
        '
        'TextTelp
        '
        Me.TextTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTelp.Location = New System.Drawing.Point(530, 63)
        Me.TextTelp.Name = "TextTelp"
        Me.TextTelp.Size = New System.Drawing.Size(240, 21)
        Me.TextTelp.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioYa)
        Me.Panel2.Controls.Add(Me.RadioTidak)
        Me.Panel2.Location = New System.Drawing.Point(530, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 23)
        Me.Panel2.TabIndex = 24
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(427, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Aktif"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(427, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Kota"
        '
        'TextKota
        '
        Me.TextKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKota.Location = New System.Drawing.Point(530, 36)
        Me.TextKota.Name = "TextKota"
        Me.TextKota.Size = New System.Drawing.Size(240, 21)
        Me.TextKota.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID Supplier"
        '
        'TextID
        '
        Me.TextID.Enabled = False
        Me.TextID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(132, 36)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(240, 21)
        Me.TextID.TabIndex = 1
        '
        'TextSupplier
        '
        Me.TextSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSupplier.Location = New System.Drawing.Point(132, 63)
        Me.TextSupplier.Name = "TextSupplier"
        Me.TextSupplier.Size = New System.Drawing.Size(240, 21)
        Me.TextSupplier.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Alamat"
        '
        'TextAlamat
        '
        Me.TextAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAlamat.Location = New System.Drawing.Point(132, 90)
        Me.TextAlamat.Multiline = True
        Me.TextAlamat.Name = "TextAlamat"
        Me.TextAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextAlamat.Size = New System.Drawing.Size(240, 53)
        Me.TextAlamat.TabIndex = 29
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(854, 583)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmSupplier"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Master Supplier"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_Keluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_Baru As System.Windows.Forms.Button
    Friend WithEvents bt_Tutup As System.Windows.Forms.Button
    Friend WithEvents bt_Batal As System.Windows.Forms.Button
    Friend WithEvents bt_Simpan As System.Windows.Forms.Button
    Friend WithEvents ComboCari As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Cari As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextTelp As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioYa As System.Windows.Forms.RadioButton
    Friend WithEvents RadioTidak As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextKota As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextID As System.Windows.Forms.TextBox
    Friend WithEvents TextSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextAlamat As System.Windows.Forms.TextBox
End Class
