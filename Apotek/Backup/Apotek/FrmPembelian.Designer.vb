<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPembelian))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.bt_Keluar = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt_Update = New System.Windows.Forms.Button
        Me.bt_Tutup = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bt_Batal = New System.Windows.Forms.Button
        Me.bt_Simpan = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBeli = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.DateExpired = New System.Windows.Forms.DateTimePicker
        Me.bt_CariObat = New System.Windows.Forms.PictureBox
        Me.TextSatuan = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextTotal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextDiskon = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextGrandTotal = New System.Windows.Forms.TextBox
        Me.bt_Bersih = New System.Windows.Forms.Button
        Me.TextKategori = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.bt_Kurang = New System.Windows.Forms.Button
        Me.bt_Tambah = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextNama = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextStock = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextJumlah = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextObat = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bt_CariSupplier = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextTelp = New System.Windows.Forms.TextBox
        Me.TextSupplier = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextFakturBeli = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.bt_CariObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bt_CariSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_Keluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1284, 25)
        Me.ToolStrip1.TabIndex = 7
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.bt_Update)
        Me.GroupBox2.Controls.Add(Me.bt_Tutup)
        Me.GroupBox2.Controls.Add(Me.bt_Batal)
        Me.GroupBox2.Controls.Add(Me.bt_Simpan)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.TextBeli)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.DateExpired)
        Me.GroupBox2.Controls.Add(Me.bt_CariObat)
        Me.GroupBox2.Controls.Add(Me.TextSatuan)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextTotal)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextDiskon)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextGrandTotal)
        Me.GroupBox2.Controls.Add(Me.bt_Bersih)
        Me.GroupBox2.Controls.Add(Me.TextKategori)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.bt_Kurang)
        Me.GroupBox2.Controls.Add(Me.bt_Tambah)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextNama)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextStock)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextJumlah)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextObat)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1260, 421)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'bt_Update
        '
        Me.bt_Update.Location = New System.Drawing.Point(1154, 40)
        Me.bt_Update.Name = "bt_Update"
        Me.bt_Update.Size = New System.Drawing.Size(30, 23)
        Me.bt_Update.TabIndex = 40
        Me.bt_Update.Text = "U"
        Me.bt_Update.UseVisualStyleBackColor = True
        '
        'bt_Tutup
        '
        Me.bt_Tutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Tutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Tutup.ImageIndex = 3
        Me.bt_Tutup.ImageList = Me.ImageList1
        Me.bt_Tutup.Location = New System.Drawing.Point(218, 375)
        Me.bt_Tutup.Name = "bt_Tutup"
        Me.bt_Tutup.Size = New System.Drawing.Size(100, 40)
        Me.bt_Tutup.TabIndex = 39
        Me.bt_Tutup.Text = "Tutup"
        Me.bt_Tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Tutup.UseVisualStyleBackColor = True
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
        'bt_Batal
        '
        Me.bt_Batal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Batal.ImageIndex = 2
        Me.bt_Batal.ImageList = Me.ImageList1
        Me.bt_Batal.Location = New System.Drawing.Point(112, 375)
        Me.bt_Batal.Name = "bt_Batal"
        Me.bt_Batal.Size = New System.Drawing.Size(100, 40)
        Me.bt_Batal.TabIndex = 38
        Me.bt_Batal.Text = "Batal"
        Me.bt_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Batal.UseVisualStyleBackColor = True
        '
        'bt_Simpan
        '
        Me.bt_Simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Simpan.ImageIndex = 1
        Me.bt_Simpan.ImageList = Me.ImageList1
        Me.bt_Simpan.Location = New System.Drawing.Point(6, 375)
        Me.bt_Simpan.Name = "bt_Simpan"
        Me.bt_Simpan.Size = New System.Drawing.Size(100, 40)
        Me.bt_Simpan.TabIndex = 37
        Me.bt_Simpan.Text = "Simpan"
        Me.bt_Simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_Simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bt_Simpan.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1229, 354)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 24)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "%"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(852, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Harga Beli Satuan"
        '
        'TextBeli
        '
        Me.TextBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBeli.Location = New System.Drawing.Point(855, 42)
        Me.TextBeli.Name = "TextBeli"
        Me.TextBeli.Size = New System.Drawing.Size(150, 21)
        Me.TextBeli.TabIndex = 34
        Me.TextBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(696, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Tgl. Expired"
        '
        'DateExpired
        '
        Me.DateExpired.CustomFormat = "dd MMMM yyyy"
        Me.DateExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateExpired.Location = New System.Drawing.Point(699, 42)
        Me.DateExpired.Name = "DateExpired"
        Me.DateExpired.Size = New System.Drawing.Size(150, 21)
        Me.DateExpired.TabIndex = 32
        '
        'bt_CariObat
        '
        Me.bt_CariObat.BackColor = System.Drawing.Color.Transparent
        Me.bt_CariObat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_CariObat.Image = CType(resources.GetObject("bt_CariObat.Image"), System.Drawing.Image)
        Me.bt_CariObat.Location = New System.Drawing.Point(188, 44)
        Me.bt_CariObat.Name = "bt_CariObat"
        Me.bt_CariObat.Size = New System.Drawing.Size(16, 16)
        Me.bt_CariObat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bt_CariObat.TabIndex = 31
        Me.bt_CariObat.TabStop = False
        '
        'TextSatuan
        '
        Me.TextSatuan.Enabled = False
        Me.TextSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSatuan.Location = New System.Drawing.Point(522, 42)
        Me.TextSatuan.Name = "TextSatuan"
        Me.TextSatuan.Size = New System.Drawing.Size(100, 21)
        Me.TextSatuan.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(519, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Satuan"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(640, 319)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 24)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Total"
        '
        'TextTotal
        '
        Me.TextTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTotal.Enabled = False
        Me.TextTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotal.Location = New System.Drawing.Point(754, 316)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(500, 29)
        Me.TextTotal.TabIndex = 22
        Me.TextTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(640, 354)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 24)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Diskon"
        '
        'TextDiskon
        '
        Me.TextDiskon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDiskon.Location = New System.Drawing.Point(1073, 351)
        Me.TextDiskon.Name = "TextDiskon"
        Me.TextDiskon.Size = New System.Drawing.Size(150, 29)
        Me.TextDiskon.TabIndex = 20
        Me.TextDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(640, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 24)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Grand Total"
        '
        'TextGrandTotal
        '
        Me.TextGrandTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextGrandTotal.Enabled = False
        Me.TextGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextGrandTotal.Location = New System.Drawing.Point(754, 386)
        Me.TextGrandTotal.Name = "TextGrandTotal"
        Me.TextGrandTotal.Size = New System.Drawing.Size(500, 29)
        Me.TextGrandTotal.TabIndex = 18
        Me.TextGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bt_Bersih
        '
        Me.bt_Bersih.Location = New System.Drawing.Point(1190, 40)
        Me.bt_Bersih.Name = "bt_Bersih"
        Me.bt_Bersih.Size = New System.Drawing.Size(30, 23)
        Me.bt_Bersih.TabIndex = 17
        Me.bt_Bersih.Text = "C"
        Me.bt_Bersih.UseVisualStyleBackColor = True
        '
        'TextKategori
        '
        Me.TextKategori.Enabled = False
        Me.TextKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKategori.Location = New System.Drawing.Point(366, 42)
        Me.TextKategori.Name = "TextKategori"
        Me.TextKategori.Size = New System.Drawing.Size(150, 21)
        Me.TextKategori.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Kategori"
        '
        'bt_Kurang
        '
        Me.bt_Kurang.Location = New System.Drawing.Point(1118, 40)
        Me.bt_Kurang.Name = "bt_Kurang"
        Me.bt_Kurang.Size = New System.Drawing.Size(30, 23)
        Me.bt_Kurang.TabIndex = 14
        Me.bt_Kurang.Text = "-"
        Me.bt_Kurang.UseVisualStyleBackColor = True
        '
        'bt_Tambah
        '
        Me.bt_Tambah.Location = New System.Drawing.Point(1082, 40)
        Me.bt_Tambah.Name = "bt_Tambah"
        Me.bt_Tambah.Size = New System.Drawing.Size(30, 23)
        Me.bt_Tambah.TabIndex = 13
        Me.bt_Tambah.Text = "+"
        Me.bt_Tambah.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(625, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Stock"
        '
        'TextNama
        '
        Me.TextNama.Enabled = False
        Me.TextNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNama.Location = New System.Drawing.Point(210, 42)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(150, 21)
        Me.TextNama.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1008, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jumlah"
        '
        'TextStock
        '
        Me.TextStock.Enabled = False
        Me.TextStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStock.Location = New System.Drawing.Point(628, 42)
        Me.TextStock.Name = "TextStock"
        Me.TextStock.Size = New System.Drawing.Size(65, 21)
        Me.TextStock.TabIndex = 9
        Me.TextStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama Obat"
        '
        'TextJumlah
        '
        Me.TextJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJumlah.Location = New System.Drawing.Point(1011, 42)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(65, 21)
        Me.TextJumlah.TabIndex = 7
        Me.TextJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID Obat"
        '
        'TextObat
        '
        Me.TextObat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextObat.Location = New System.Drawing.Point(32, 42)
        Me.TextObat.Name = "TextObat"
        Me.TextObat.Size = New System.Drawing.Size(150, 21)
        Me.TextObat.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 82)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(1248, 228)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.bt_CariSupplier)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextTelp)
        Me.GroupBox1.Controls.Add(Me.TextSupplier)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextFakturBeli)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1260, 115)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'bt_CariSupplier
        '
        Me.bt_CariSupplier.BackColor = System.Drawing.Color.Transparent
        Me.bt_CariSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_CariSupplier.Image = CType(resources.GetObject("bt_CariSupplier.Image"), System.Drawing.Image)
        Me.bt_CariSupplier.Location = New System.Drawing.Point(356, 65)
        Me.bt_CariSupplier.Name = "bt_CariSupplier"
        Me.bt_CariSupplier.Size = New System.Drawing.Size(16, 16)
        Me.bt_CariSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bt_CariSupplier.TabIndex = 34
        Me.bt_CariSupplier.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(427, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Telepon"
        '
        'TextTelp
        '
        Me.TextTelp.Enabled = False
        Me.TextTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTelp.Location = New System.Drawing.Point(530, 63)
        Me.TextTelp.Name = "TextTelp"
        Me.TextTelp.Size = New System.Drawing.Size(240, 21)
        Me.TextTelp.TabIndex = 35
        '
        'TextSupplier
        '
        Me.TextSupplier.Enabled = False
        Me.TextSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSupplier.Location = New System.Drawing.Point(530, 36)
        Me.TextSupplier.Name = "TextSupplier"
        Me.TextSupplier.Size = New System.Drawing.Size(240, 21)
        Me.TextSupplier.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Supplier"
        '
        'TextID
        '
        Me.TextID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(132, 63)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(218, 21)
        Me.TextID.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Faktur Pembelian"
        '
        'TextFakturBeli
        '
        Me.TextFakturBeli.Enabled = False
        Me.TextFakturBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFakturBeli.Location = New System.Drawing.Point(132, 36)
        Me.TextFakturBeli.Name = "TextFakturBeli"
        Me.TextFakturBeli.Size = New System.Drawing.Size(240, 21)
        Me.TextFakturBeli.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1284, 50)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Transaksi Pembelian Obat"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 632)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmPembelian"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Transaksi Pembelian"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.bt_CariObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bt_CariSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents bt_Bersih As System.Windows.Forms.Button
    Friend WithEvents TextKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_Kurang As System.Windows.Forms.Button
    Friend WithEvents bt_Tambah As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextStock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextObat As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextFakturBeli As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextDiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextTelp As System.Windows.Forms.TextBox
    Friend WithEvents bt_Keluar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateExpired As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_CariObat As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents bt_CariSupplier As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBeli As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents bt_Tutup As System.Windows.Forms.Button
    Friend WithEvents bt_Batal As System.Windows.Forms.Button
    Friend WithEvents bt_Simpan As System.Windows.Forms.Button
    Friend WithEvents bt_Update As System.Windows.Forms.Button
End Class
