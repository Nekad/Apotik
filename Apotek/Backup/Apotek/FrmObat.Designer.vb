<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmObat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmObat))
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboKategori = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RadioYa = New System.Windows.Forms.RadioButton
        Me.RadioTidak = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextStock = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.bt_Keluar = New System.Windows.Forms.ToolStripButton
        Me.TextBeli = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextID = New System.Windows.Forms.TextBox
        Me.TextObat = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_Baru = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_Tutup = New System.Windows.Forms.Button
        Me.bt_Batal = New System.Windows.Forms.Button
        Me.bt_Simpan = New System.Windows.Forms.Button
        Me.ComboCari = New System.Windows.Forms.ComboBox
        Me.bt_Cari = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextCari = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bt_TbhSatuan = New System.Windows.Forms.PictureBox
        Me.bt_TbhKategori = New System.Windows.Forms.PictureBox
        Me.ComboSatuan = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextJual = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bt_TbhSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_TbhKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Kategori"
        '
        'ComboKategori
        '
        Me.ComboKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboKategori.FormattingEnabled = True
        Me.ComboKategori.Location = New System.Drawing.Point(132, 90)
        Me.ComboKategori.Name = "ComboKategori"
        Me.ComboKategori.Size = New System.Drawing.Size(218, 21)
        Me.ComboKategori.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioYa)
        Me.Panel2.Controls.Add(Me.RadioTidak)
        Me.Panel2.Location = New System.Drawing.Point(530, 117)
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
        Me.Label10.Location = New System.Drawing.Point(427, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Aktif"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Stock"
        '
        'TextStock
        '
        Me.TextStock.Enabled = False
        Me.TextStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStock.Location = New System.Drawing.Point(530, 90)
        Me.TextStock.Name = "TextStock"
        Me.TextStock.Size = New System.Drawing.Size(99, 21)
        Me.TextStock.TabIndex = 14
        Me.TextStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(427, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Harga Beli"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Keluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(854, 25)
        Me.ToolStrip1.TabIndex = 8
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
        'TextBeli
        '
        Me.TextBeli.Enabled = False
        Me.TextBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBeli.Location = New System.Drawing.Point(530, 36)
        Me.TextBeli.Name = "TextBeli"
        Me.TextBeli.Size = New System.Drawing.Size(240, 21)
        Me.TextBeli.TabIndex = 12
        Me.TextBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID Obat"
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
        'TextObat
        '
        Me.TextObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextObat.Location = New System.Drawing.Point(132, 63)
        Me.TextObat.Name = "TextObat"
        Me.TextObat.Size = New System.Drawing.Size(240, 21)
        Me.TextObat.TabIndex = 2
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
        Me.GroupBox2.TabIndex = 10
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
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add.png")
        Me.ImageList1.Images.SetKeyName(1, "disk.png")
        Me.ImageList1.Images.SetKeyName(2, "cancel.png")
        Me.ImageList1.Images.SetKeyName(3, "cross.png")
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
        Me.ComboCari.Items.AddRange(New Object() {"ID Obat", "Nama Obat", "Kategori", "Satuan"})
        Me.ComboCari.Location = New System.Drawing.Point(132, 23)
        Me.ComboCari.Name = "ComboCari"
        Me.ComboCari.Size = New System.Drawing.Size(100, 21)
        Me.ComboCari.TabIndex = 23
        Me.ComboCari.Text = "ID Obat"
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
        Me.GroupBox1.Controls.Add(Me.bt_TbhSatuan)
        Me.GroupBox1.Controls.Add(Me.bt_TbhKategori)
        Me.GroupBox1.Controls.Add(Me.ComboSatuan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextJual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboKategori)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextStock)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBeli)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.TextObat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(830, 170)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'bt_TbhSatuan
        '
        Me.bt_TbhSatuan.BackColor = System.Drawing.Color.Transparent
        Me.bt_TbhSatuan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_TbhSatuan.Image = CType(resources.GetObject("bt_TbhSatuan.Image"), System.Drawing.Image)
        Me.bt_TbhSatuan.Location = New System.Drawing.Point(238, 119)
        Me.bt_TbhSatuan.Name = "bt_TbhSatuan"
        Me.bt_TbhSatuan.Size = New System.Drawing.Size(16, 16)
        Me.bt_TbhSatuan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bt_TbhSatuan.TabIndex = 31
        Me.bt_TbhSatuan.TabStop = False
        '
        'bt_TbhKategori
        '
        Me.bt_TbhKategori.BackColor = System.Drawing.Color.Transparent
        Me.bt_TbhKategori.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_TbhKategori.Image = CType(resources.GetObject("bt_TbhKategori.Image"), System.Drawing.Image)
        Me.bt_TbhKategori.Location = New System.Drawing.Point(356, 92)
        Me.bt_TbhKategori.Name = "bt_TbhKategori"
        Me.bt_TbhKategori.Size = New System.Drawing.Size(16, 16)
        Me.bt_TbhKategori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bt_TbhKategori.TabIndex = 30
        Me.bt_TbhKategori.TabStop = False
        '
        'ComboSatuan
        '
        Me.ComboSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSatuan.FormattingEnabled = True
        Me.ComboSatuan.Location = New System.Drawing.Point(132, 117)
        Me.ComboSatuan.Name = "ComboSatuan"
        Me.ComboSatuan.Size = New System.Drawing.Size(100, 21)
        Me.ComboSatuan.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Harga Jual"
        '
        'TextJual
        '
        Me.TextJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJual.Location = New System.Drawing.Point(530, 63)
        Me.TextJual.Name = "TextJual"
        Me.TextJual.Size = New System.Drawing.Size(240, 21)
        Me.TextJual.TabIndex = 27
        Me.TextJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(854, 50)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Data Master Obat"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(854, 583)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmObat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Master Obat"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bt_TbhSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_TbhKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioYa As System.Windows.Forms.RadioButton
    Friend WithEvents RadioTidak As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextStock As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_Keluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBeli As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextID As System.Windows.Forms.TextBox
    Friend WithEvents TextObat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboCari As System.Windows.Forms.ComboBox
    Friend WithEvents bt_Cari As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextJual As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bt_Baru As System.Windows.Forms.Button
    Friend WithEvents bt_Tutup As System.Windows.Forms.Button
    Friend WithEvents bt_Batal As System.Windows.Forms.Button
    Friend WithEvents bt_Simpan As System.Windows.Forms.Button
    Friend WithEvents bt_TbhSatuan As System.Windows.Forms.PictureBox
    Friend WithEvents bt_TbhKategori As System.Windows.Forms.PictureBox
End Class
