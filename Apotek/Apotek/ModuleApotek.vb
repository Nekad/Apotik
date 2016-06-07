Imports System.Data.SqlClient
Imports VB = Microsoft.VisualBasic

Module ModuleApotek

    Public ConnString As String = "Data Source=.;Initial Catalog=apotek;Integrated Security=True"
    Public Cn As New SqlConnection(ConnString)
    Public SQL As String
    Public Command As SqlCommand
    Public Reader As SqlDataReader
    Public IDKode As String
    Public Nomor As String
    Public No As Integer

    Public Function Tampilkan(ByVal xForm As Form)
        For i As Integer = 0 To FrmUtama.TabControl1.TabPages.Count - 1
            If FrmUtama.TabControl1.TabPages(i).Name = xForm.Name Then
                FrmUtama.TabControl1.SelectedTab = FrmUtama.TabControl1.TabPages(xForm.Name)
                Return xForm
            End If
        Next i

        FrmUtama.TabControl1.TabPages.Add(xForm.Name, xForm.Text)
        FrmUtama.TabControl1.SelectedTab = FrmUtama.TabControl1.TabPages(xForm.Name)
        xForm.TopLevel = False
        xForm.Parent = FrmUtama.TabControl1.TabPages(xForm.Name)
        xForm.Show()
        Return xForm
    End Function

    Public Function MyParent(ByVal xForm As Form)
        With xForm
            .FormBorderStyle = Windows.Forms.BorderStyle.None
            .ControlBox = False
            .Parent = FrmUtama.TabControl1.TabPages(xForm.Name)
            .Height = FrmUtama.TabControl1.TabPages(xForm.Name).Height
            .Width = FrmUtama.TabControl1.TabPages(xForm.Name).Width
        End With
        Return xForm
    End Function

    Public Function Tutup(ByVal xForm As Form)
        xForm.Dispose()
        FrmUtama.TabControl1.TabPages(xForm.Name).Dispose()
        Return xForm
    End Function

    Public Function tanggal(ByVal format As String) As String
        tanggal = String.Format("{0}/{1}/{2}", Right(format, 4), Mid(format, 4, 2), Left(format, 2))
    End Function

    Public Function TextNumber(ByVal e As KeyPressEventArgs, ByVal TextNumeric As TextBox)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then 'NUMBER ONLY
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 8 Then 'BACKSPACE
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 13 Then 'ENTER
            e.Handled = False
        Else
            e.Handled = True
        End If
        Return TextNumeric
    End Function

    Public Function TextMobile(ByVal e As KeyPressEventArgs, ByVal TextNumeric As TextBox)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then 'NUMBER ONLY
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 8 Then 'BACKSPACE
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 13 Then 'ENTER
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 32 Then 'SPACE
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 45 Then '-
            e.Handled = False
        Else
            e.Handled = True
        End If
        Return TextNumeric
    End Function

    Public Function Enable(ByVal xEnable As Boolean, _
                           ByVal xMaster As ToolStripMenuItem, _
                           ByVal xTransaksi As ToolStripMenuItem, _
                           ByVal xPencarian As ToolStripMenuItem, _
                           ByVal xLaporan As ToolStripMenuItem, _
                           ByVal xSistem As ToolStripMenuItem, _
                           ByVal xWaktu As Timer)

        xMaster.Enabled = xEnable
        xTransaksi.Enabled = xEnable
        xPencarian.Enabled = xEnable
        xLaporan.Enabled = xEnable
        xSistem.Enabled = xEnable
        xWaktu.Enabled = xEnable

        Return xEnable
    End Function

    Public Function StatusBersih(ByVal xStatusID As ToolStripStatusLabel, _
                                 ByVal xStatusPegawai As ToolStripStatusLabel, _
                                 ByVal xStatusTanggal As ToolStripStatusLabel, _
                                 ByVal xStatusWaktu As ToolStripStatusLabel)
        xStatusID.Text = "-"
        xStatusPegawai.Text = "-"
        xStatusTanggal.Text = "-"
        xStatusWaktu.Text = "-"

        Return xStatusID
    End Function

    Public Function Radio(ByVal xRB1 As RadioButton, ByVal xRB2 As RadioButton)
        Dim xValue As Byte
        If xRB1.Checked = True Then
            xValue = 1
        ElseIf xRB2.Checked = True Then
            xValue = 0
        End If
        Return xValue
    End Function

#Region "DML SQL"

    Public Function Login(ByVal xForm As Form, ByVal xTextUser As TextBox, ByVal xTextPass As TextBox)
        Try
            SQL = String.Format("SELECT * FROM t_pegawai WHERE username ='{0}' AND password ='{1}' AND aktif = 1", xTextUser.Text, xTextPass.Text)
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                MsgBox("Anda telah login !", MsgBoxStyle.Information, "Peringatan")
                xForm.Close()
            Else
                MsgBox("Username atau Password salah atau Pegawai sudah tidak aktif !", MsgBoxStyle.Critical, "Peringatan")
                xTextUser.Focus()
                Return xForm
            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(String.Format("Ada kesalahan dalam login !{0}{1}", vbCrLf, ex.Message), MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xForm
    End Function

    Public Function Status(ByVal xTextUser As TextBox, _
                           ByVal xStatusID As ToolStripStatusLabel, _
                           ByVal xStatusPegawai As ToolStripStatusLabel, _
                           ByVal xStatusTanggal As ToolStripStatusLabel, _
                           ByVal xStatusWaktu As ToolStripStatusLabel)
        Try
            SQL = String.Format("SELECT * FROM t_pegawai WHERE username ='{0}'", xTextUser.Text)
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                xStatusID.Text = Reader.Item("id_pegawai").ToString
                xStatusPegawai.Text = Reader.Item("nama_pegawai").ToString
                xStatusTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
                xStatusWaktu.Text = Format(Now, "H:mm:ss")
            Else
                xStatusID.Text = "-"
                xStatusPegawai.Text = "-"
                xStatusTanggal.Text = "-"
                xStatusWaktu.Text = "-"
            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xTextUser
    End Function

    Public Function ID_Otomatis(ByVal xSP As String, ByVal xID As String, ByVal xText As TextBox)
        Try
            Dim maxString As String = ""
            Dim maxInteger As Integer = 0
            Dim tahun As String = Format(Now, "yyyy")

            Cn.Open()
            Command = New SqlCommand(xSP, Cn) With {.CommandType = CommandType.StoredProcedure}
            Reader = Command.ExecuteReader
            If Reader.Read Then
                If Reader.Item("tahun").ToString = tahun Then
                    maxString = Reader.Item("maksimum").ToString
                Else
                    maxString = 0
                End If
            End If
            Reader.Close()

            maxInteger = VB.Right(maxString, 5)
            maxInteger = maxInteger + 1
            maxString = maxInteger

            If maxString.Length = 1 Then
                IDKode = String.Format(xID & "{0}0000{1}", tahun, maxString)
            ElseIf maxString.Length = 2 Then
                IDKode = String.Format(xID & "{0}000{1}", tahun, maxString)
            ElseIf maxString.Length = 3 Then
                IDKode = String.Format(xID & "{0}00{1}", tahun, maxString)
            ElseIf maxString.Length = 4 Then
                IDKode = String.Format(xID & "{0}0{1}", tahun, maxString)
            ElseIf maxString.Length = 5 Then
                IDKode = String.Format(xID & "{0}{1}", tahun, maxString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try

        xText.Text = IDKode

        Return xText
    End Function

    Public Function NO_Otomatis(ByVal xSP As String, ByVal xNO As String, ByVal xText As TextBox)
        Try
            Dim maxString As String = ""
            Dim maxInteger As Integer = 0
            Dim tahun As String = Format(Now, "yyyy")

            Cn.Open()
            Command = New SqlCommand(xSP, Cn) With {.CommandType = CommandType.StoredProcedure}
            Reader = Command.ExecuteReader
            If Reader.Read Then
                If Reader.Item("tahun").ToString = tahun Then
                    maxString = Reader.Item("maksimum").ToString
                Else
                    maxString = 0
                End If
            End If
            Reader.Close()

            maxInteger = VB.Right(maxString, 14)
            maxInteger = maxInteger + 1
            maxString = maxInteger

            If maxString.Length = 1 Then
                Nomor = String.Format(xNO & "{0}0000000000000{1}", tahun, maxString)
            ElseIf maxString.Length = 2 Then
                Nomor = String.Format(xNO & "{0}000000000000{1}", tahun, maxString)
            ElseIf maxString.Length = 3 Then
                Nomor = String.Format(xNO & "{0}00000000000{1}", tahun, maxString)
            ElseIf maxString.Length = 4 Then
                Nomor = String.Format(xNO & "{0}0000000000{1}", tahun, maxString)
            ElseIf maxString.Length = 5 Then
                Nomor = String.Format(xNO & "{0}000000000{1}", tahun, maxString)
            ElseIf maxString.Length = 6 Then
                Nomor = String.Format(xNO & "{0}00000000{1}", tahun, maxString)
            ElseIf maxString.Length = 7 Then
                Nomor = String.Format(xNO & "{0}0000000{1}", tahun, maxString)
            ElseIf maxString.Length = 8 Then
                Nomor = String.Format(xNO & "{0}000000{1}", tahun, maxString)
            ElseIf maxString.Length = 9 Then
                Nomor = String.Format(xNO & "{0}00000{1}", tahun, maxString)
            ElseIf maxString.Length = 10 Then
                Nomor = String.Format(xNO & "{0}0000{1}", tahun, maxString)
            ElseIf maxString.Length = 11 Then
                Nomor = String.Format(xNO & "{0}000{1}", tahun, maxString)
            ElseIf maxString.Length = 12 Then
                Nomor = String.Format(xNO & "{0}00{1}", tahun, maxString)
            ElseIf maxString.Length = 13 Then
                Nomor = String.Format(xNO & "{0}0{1}", tahun, maxString)
            ElseIf maxString.Length = 14 Then
                Nomor = String.Format(xNO & "{0}{1}", tahun, maxString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try

        xText.Text = Nomor

        Return xText
    End Function

    Public Function SimpanPegawai(ByVal xID As String, _
                                  ByVal xNama As String, _
                                  ByVal xJK As Byte, _
                                  ByVal xAlamat As String, _
                                  ByVal xTelepon As String, _
                                  ByVal xUsername As String, _
                                  ByVal xPassword As String, _
                                  ByVal xAktif As Byte)
        Try
            SQL = String.Format("SELECT * FROM t_pegawai WHERE id_pegawai ='{0}'", xID)
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("update_pegawai", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@nama_pegawai", SqlDbType.VarChar).Value = xNama
                    .Parameters.Add("@jenis_kelamin", SqlDbType.Bit).Value = xJK
                    .Parameters.Add("@alamat", SqlDbType.VarChar).Value = xAlamat
                    .Parameters.Add("@telepon", SqlDbType.VarChar).Value = xTelepon
                    .Parameters.Add("@username", SqlDbType.VarChar).Value = xUsername
                    .Parameters.Add("@password", SqlDbType.VarChar).Value = xPassword
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Update data sukses !", MsgBoxStyle.Information, "Peringatan")
            Else
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("insert_pegawai", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@nama_pegawai", SqlDbType.VarChar).Value = xNama
                    .Parameters.Add("@jenis_kelamin", SqlDbType.Bit).Value = xJK
                    .Parameters.Add("@alamat", SqlDbType.VarChar).Value = xAlamat
                    .Parameters.Add("@telepon", SqlDbType.VarChar).Value = xTelepon
                    .Parameters.Add("@username", SqlDbType.VarChar).Value = xUsername
                    .Parameters.Add("@password", SqlDbType.VarChar).Value = xPassword
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Data tersimpan !", MsgBoxStyle.Information, "Peringatan")
            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(String.Format("Ada kesalahan dalam pengisian data atau Username {0} sudah terdaftar !", xUsername), MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xID
    End Function

    Public Function DataPegawai(ByVal xList As ListView, ByVal xCombo As ComboBox, ByVal xText As TextBox)
        Try
            With xList
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Pegawai", 90, HorizontalAlignment.Left)
                .Columns.Add("Nama Pegawai", 300, HorizontalAlignment.Left)
                .Columns.Add("Jenis Kelamin", 90, HorizontalAlignment.Left)
                .Columns.Add("Alamat", 300, HorizontalAlignment.Left)
                .Columns.Add("Telepon", 110, HorizontalAlignment.Left)
                .Columns.Add("Username", 200, HorizontalAlignment.Left)
                .Columns.Add("Aktif", 80, HorizontalAlignment.Left)
            End With

            If xCombo.Text = "ID Pegawai" Then
                SQL = String.Format("SELECT * FROM t_pegawai WHERE id_pegawai LIKE '%{0}%' ORDER BY id_pegawai ASC", xText.Text)
            ElseIf xCombo.Text = "Nama Pegawai" Then
                SQL = String.Format("SELECT * FROM t_pegawai WHERE nama_pegawai LIKE '%{0}%' ORDER BY id_pegawai ASC", xText.Text)
            ElseIf xCombo.Text = "Alamat" Then
                SQL = String.Format("SELECT * FROM t_pegawai WHERE alamat LIKE '%{0}%' ORDER BY id_pegawai ASC", xText.Text)
            ElseIf xCombo.Text = "Username" Then
                SQL = String.Format("SELECT * FROM t_pegawai WHERE username LIKE '%{0}%' ORDER BY id_pegawai ASC", xText.Text)
            End If
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            No = 0
            If Reader.HasRows Then
                Do While Reader.Read()
                    No = No + 1
                    Dim myItem As New ListViewItem(No & ".")
                    With myItem.SubItems
                        .Add(Reader.Item("id_pegawai").ToString)
                        .Add(Reader.Item("nama_pegawai").ToString)
                        If Reader.Item("jenis_kelamin") = True Then
                            .Add("Laki-Laki")
                        ElseIf Reader.Item("jenis_kelamin") = False Then
                            .Add("Perempuan")
                        End If
                        .Add(Reader.Item("alamat").ToString)
                        .Add(Reader.Item("telepon").ToString)
                        .Add(Reader.Item("username").ToString)
                        If Reader.Item("aktif") = True Then
                            .Add("Ya")
                        ElseIf Reader.Item("aktif") = False Then
                            .Add("Tidak")
                        End If
                        .Add(Reader.Item("password").ToString)
                    End With
                    xList.Items.Add(myItem)
                Loop
            End If
            For Each Item In xList.Items
                If (Item.Index Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.Azure
                End If
            Next
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xList
    End Function

    Public Function SimpanKategori(ByVal xID As String, _
                                   ByVal xKategori As String, _
                                   ByVal xAktif As Byte)
        Try
            SQL = String.Format("SELECT * FROM t_kategori WHERE id_kategori ='{0}'", xID)
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("update_kategori", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_kategori", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@kategori", SqlDbType.VarChar).Value = xKategori
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Update data sukses !", MsgBoxStyle.Information, "Peringatan")
            Else
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("insert_kategori", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_kategori", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@kategori", SqlDbType.VarChar).Value = xKategori
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Data tersimpan !", MsgBoxStyle.Information, "Peringatan")
            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(String.Format("Ada kesalahan dalam pengisian data atau Kategori {0} sudah terdaftar !", xKategori), MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xID
    End Function

    Public Function DataKategori(ByVal xList As ListView, ByVal xText As TextBox)
        Try
            With xList
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Kategori", 90, HorizontalAlignment.Left)
                .Columns.Add("Kategori", 135, HorizontalAlignment.Left)
                .Columns.Add("Aktif", 80, HorizontalAlignment.Left)
            End With

            SQL = String.Format("SELECT * FROM t_kategori WHERE kategori LIKE '%{0}%' ORDER BY id_kategori ASC", xText.Text)
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            No = 0
            If Reader.HasRows Then
                Do While Reader.Read()
                    No = No + 1
                    Dim myItem As New ListViewItem(No & ".")
                    With myItem.SubItems
                        .Add(Reader.Item("id_kategori").ToString)
                        .Add(Reader.Item("kategori").ToString)
                        If Reader.Item("aktif") = True Then
                            .Add("Ya")
                        ElseIf Reader.Item("aktif") = False Then
                            .Add("Tidak")
                        End If
                    End With
                    xList.Items.Add(myItem)
                Loop
            End If
            For Each Item In xList.Items
                If (Item.Index Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.Azure
                End If
            Next
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xList
    End Function

    Public Function TampilKategori(ByVal xCombo As ComboBox)
        Try
            Using da As New SqlDataAdapter("SELECT * FROM t_kategori WHERE aktif = 1 ORDER BY kategori", Cn)
                Using ds As New DataSet()
                    da.Fill(ds, "t_kategori")
                    With xCombo
                        .DataSource = Nothing
                        .Items.Clear()
                        .DataSource = ds.Tables("t_kategori")
                        .DisplayMember = "kategori"
                        .ValueMember = "id_kategori"
                        .SelectedIndex = -1
                    End With
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xCombo
    End Function

    Public Function SimpanSatuan(ByVal xID As String, _
                                 ByVal xSatuan As String, _
                                 ByVal xAktif As Byte)
        Try
            SQL = String.Format("SELECT * FROM t_satuan WHERE id_satuan ='{0}'", xID)
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("update_satuan", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_satuan", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@satuan", SqlDbType.VarChar).Value = xSatuan
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Update data sukses !", MsgBoxStyle.Information, "Peringatan")
            Else
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("insert_satuan", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_satuan", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@satuan", SqlDbType.VarChar).Value = xSatuan
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Data tersimpan !", MsgBoxStyle.Information, "Peringatan")
            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(String.Format("Ada kesalahan dalam pengisian data atau Satuan {0} sudah terdaftar !", xSatuan), MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xID
    End Function

    Public Function DataSatuan(ByVal xList As ListView, ByVal xText As TextBox)
        Try
            With xList
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Satuan", 90, HorizontalAlignment.Left)
                .Columns.Add("Satuan", 135, HorizontalAlignment.Left)
                .Columns.Add("Aktif", 80, HorizontalAlignment.Left)
            End With

            SQL = String.Format("SELECT * FROM t_satuan WHERE satuan LIKE '%{0}%' ORDER BY id_satuan ASC", xText.Text)
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            No = 0
            If Reader.HasRows Then
                Do While Reader.Read()
                    No = No + 1
                    Dim myItem As New ListViewItem(No & ".")
                    With myItem.SubItems
                        .Add(Reader.Item("id_satuan").ToString)
                        .Add(Reader.Item("satuan").ToString)
                        If Reader.Item("aktif") = True Then
                            .Add("Ya")
                        ElseIf Reader.Item("aktif") = False Then
                            .Add("Tidak")
                        End If
                    End With
                    xList.Items.Add(myItem)
                Loop
            End If
            For Each Item In xList.Items
                If (Item.Index Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.Azure
                End If
            Next
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xList
    End Function

    Public Function TampilSatuan(ByVal xCombo As ComboBox)
        Try
            Using da As New SqlDataAdapter("SELECT * FROM t_satuan WHERE aktif = 1 ORDER BY satuan", Cn)
                Using ds As New DataSet()
                    da.Fill(ds, "t_satuan")
                    With xCombo
                        .DataSource = Nothing
                        .Items.Clear()
                        .DataSource = ds.Tables("t_satuan")
                        .DisplayMember = "satuan"
                        .ValueMember = "id_satuan"
                        .SelectedIndex = -1
                    End With
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xCombo
    End Function

    Public Function SimpanObat(ByVal xID As String, _
                               ByVal xObat As String, _
                               ByVal xKategori As String, _
                               ByVal xSatuan As String, _
                               ByVal xJual As String, _
                               ByVal xAktif As Byte, _
                               ByVal xPegawai As String)
        Try
            SQL = String.Format("SELECT * FROM t_obat WHERE id_obat ='{0}'", xID)
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("update_obat", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_obat", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@nama_obat", SqlDbType.VarChar).Value = xObat
                    .Parameters.Add("@id_kategori", SqlDbType.VarChar).Value = xKategori
                    .Parameters.Add("@id_satuan", SqlDbType.VarChar).Value = xSatuan
                    .Parameters.Add("@harga_jual", SqlDbType.Money).Value = xJual
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xPegawai
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Update data sukses !", MsgBoxStyle.Information, "Peringatan")
            Else
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("insert_obat", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_obat", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@nama_obat", SqlDbType.VarChar).Value = xObat
                    .Parameters.Add("@id_kategori", SqlDbType.VarChar).Value = xKategori
                    .Parameters.Add("@id_satuan", SqlDbType.VarChar).Value = xSatuan
                    .Parameters.Add("@harga_jual", SqlDbType.Money).Value = xJual
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xPegawai
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Data tersimpan !", MsgBoxStyle.Information, "Peringatan")
            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(String.Format("Ada kesalahan dalam pengisian data atau Obat {0} sudah terdaftar !", xObat), MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xID
    End Function

    Public Function DataObat(ByVal xList As ListView, ByVal xCombo As ComboBox, ByVal xText As TextBox)
        Try
            With xList
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Obat", 90, HorizontalAlignment.Left)
                .Columns.Add("Nama Obat", 200, HorizontalAlignment.Left)
                .Columns.Add("Kategori", 200, HorizontalAlignment.Left)
                .Columns.Add("Satuan", 100, HorizontalAlignment.Left)
                .Columns.Add("Harga Beli", 200, HorizontalAlignment.Right)
                .Columns.Add("Harga Jual", 200, HorizontalAlignment.Right)
                .Columns.Add("Stock", 100, HorizontalAlignment.Right)
                .Columns.Add("Aktif", 80, HorizontalAlignment.Left)
            End With

            If xCombo.Text = "ID Obat" Then
                SQL = String.Format("SELECT * FROM view_obat WHERE id_obat LIKE '%{0}%' ORDER BY id_obat ASC", xText.Text)
            ElseIf xCombo.Text = "Nama Obat" Then
                SQL = String.Format("SELECT * FROM view_obat WHERE nama_obat LIKE '%{0}%' ORDER BY id_obat ASC", xText.Text)
            ElseIf xCombo.Text = "Kategori" Then
                SQL = String.Format("SELECT * FROM view_obat WHERE kategori LIKE '%{0}%' ORDER BY id_obat ASC", xText.Text)
            ElseIf xCombo.Text = "Satuan" Then
                SQL = String.Format("SELECT * FROM view_obat WHERE satuan LIKE '%{0}%' ORDER BY id_obat ASC", xText.Text)
            End If
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            No = 0
            If Reader.HasRows Then
                Do While Reader.Read()
                    No = No + 1
                    Dim myItem As New ListViewItem(No & ".")
                    With myItem.SubItems
                        .Add(Reader.Item("id_obat").ToString)
                        .Add(Reader.Item("nama_obat").ToString)
                        .Add(Reader.Item("kategori").ToString)
                        .Add(Reader.Item("satuan").ToString)
                        .Add(Format(CDbl(Reader.Item("harga_beli").ToString), "Currency"))
                        .Add(Format(CDbl(Reader.Item("harga_jual").ToString), "Currency"))
                        .Add(Format(CDbl(Reader.Item("stock").ToString), "##,##0"))
                        If Reader.Item("aktif") = True Then
                            .Add("Ya")
                        ElseIf Reader.Item("aktif") = False Then
                            .Add("Tidak")
                        End If
                    End With
                    xList.Items.Add(myItem)
                Loop
            End If
            For Each Item In xList.Items
                If (Item.Index Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.Azure
                End If
            Next
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xList
    End Function

    Public Function CariObat(ByVal xList As ListView, ByVal xText As TextBox)
        Try
            With xList
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Obat", 90, HorizontalAlignment.Left)
                .Columns.Add("Nama Obat", 200, HorizontalAlignment.Left)
            End With

            SQL = String.Format("SELECT * FROM view_obat WHERE nama_obat LIKE '%{0}%' AND aktif = 1 ORDER BY id_obat ASC", xText.Text)
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            No = 0
            If Reader.HasRows Then
                Do While Reader.Read()
                    No = No + 1
                    Dim myItem As New ListViewItem(No & ".")
                    With myItem.SubItems
                        .Add(Reader.Item("id_obat").ToString)
                        .Add(Reader.Item("nama_obat").ToString)
                        .Add(Reader.Item("kategori").ToString)
                        .Add(Reader.Item("satuan").ToString)
                        .Add(Format(CDbl(Reader.Item("stock").ToString), "##,##0"))
                        .Add(Format(CDbl(Reader.Item("harga_beli").ToString), "##,##0"))
                    End With
                    xList.Items.Add(myItem)
                Loop
            End If
            For Each Item In xList.Items
                If (Item.Index Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.Azure
                End If
            Next
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xList
    End Function

    Public Function SimpanSupplier(ByVal xID As String, _
                                   ByVal xSupplier As String, _
                                   ByVal xAlamat As String, _
                                   ByVal xKota As String, _
                                   ByVal xTelepon As String, _
                                   ByVal xAktif As Byte, _
                                   ByVal xPegawai As String)
        Try
            SQL = String.Format("SELECT * FROM t_supplier WHERE id_supplier ='{0}'", xID)
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("update_supplier", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_supplier", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@supplier", SqlDbType.VarChar).Value = xSupplier
                    .Parameters.Add("@alamat", SqlDbType.VarChar).Value = xAlamat
                    .Parameters.Add("@kota", SqlDbType.VarChar).Value = xKota
                    .Parameters.Add("@telepon", SqlDbType.VarChar).Value = xTelepon
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xPegawai
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Update data sukses !", MsgBoxStyle.Information, "Peringatan")
            Else
                Cn.Close()
                Cn.Open()
                Command = New SqlCommand("insert_supplier", Cn)
                With Command
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@id_supplier", SqlDbType.VarChar).Value = xID
                    .Parameters.Add("@supplier", SqlDbType.VarChar).Value = xSupplier
                    .Parameters.Add("@alamat", SqlDbType.VarChar).Value = xAlamat
                    .Parameters.Add("@kota", SqlDbType.VarChar).Value = xKota
                    .Parameters.Add("@telepon", SqlDbType.VarChar).Value = xTelepon
                    .Parameters.Add("@aktif", SqlDbType.Bit).Value = xAktif
                    .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xPegawai
                    .ExecuteNonQuery()
                End With
                Cn.Close()
                MsgBox("Data tersimpan !", MsgBoxStyle.Information, "Peringatan")
            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(String.Format("Ada kesalahan dalam pengisian data atau Supplier {0} sudah terdaftar !", xSupplier), MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xID
    End Function

    Public Function DataSupplier(ByVal xList As ListView, ByVal xCombo As ComboBox, ByVal xText As TextBox)
        Try
            With xList
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Supplier", 90, HorizontalAlignment.Left)
                .Columns.Add("Supplier", 340, HorizontalAlignment.Left)
                .Columns.Add("Alamat", 350, HorizontalAlignment.Left)
                .Columns.Add("Kota", 200, HorizontalAlignment.Left)
                .Columns.Add("Telepon", 110, HorizontalAlignment.Left)
                .Columns.Add("Aktif", 80, HorizontalAlignment.Left)
            End With

            If xCombo.Text = "ID Supplier" Then
                SQL = String.Format("SELECT * FROM t_supplier WHERE id_supplier LIKE '%{0}%' ORDER BY id_supplier ASC", xText.Text)
            ElseIf xCombo.Text = "Supplier" Then
                SQL = String.Format("SELECT * FROM t_supplier WHERE supplier LIKE '%{0}%' ORDER BY id_supplier ASC", xText.Text)
            ElseIf xCombo.Text = "Alamat" Then
                SQL = String.Format("SELECT * FROM t_supplier WHERE alamat LIKE '%{0}%' ORDER BY id_supplier ASC", xText.Text)
            ElseIf xCombo.Text = "Kota" Then
                SQL = String.Format("SELECT * FROM t_supplier WHERE kota LIKE '%{0}%' ORDER BY id_supplier ASC", xText.Text)
            End If
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            No = 0
            If Reader.HasRows Then
                Do While Reader.Read()
                    No = No + 1
                    Dim myItem As New ListViewItem(No & ".")
                    With myItem.SubItems
                        .Add(Reader.Item("id_supplier").ToString)
                        .Add(Reader.Item("supplier").ToString)
                        .Add(Reader.Item("alamat").ToString)
                        .Add(Reader.Item("kota").ToString)
                        .Add(Reader.Item("telepon").ToString)
                        If Reader.Item("aktif") = True Then
                            .Add("Ya")
                        ElseIf Reader.Item("aktif") = False Then
                            .Add("Tidak")
                        End If
                    End With
                    xList.Items.Add(myItem)
                Loop
            End If
            For Each Item In xList.Items
                If (Item.Index Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.Azure
                End If
            Next
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xList
    End Function

    Public Function CariSupplier(ByVal xListview As ListView, ByVal xText As TextBox)
        Try
            With xListview
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Supplier", 90, HorizontalAlignment.Left)
                .Columns.Add("Supplier", 200, HorizontalAlignment.Left)
            End With

            SQL = String.Format("SELECT * FROM t_supplier WHERE supplier LIKE '%{0}%' AND aktif = 1 ORDER BY id_supplier ASC", xText.Text)
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand(SQL, Cn)
            Reader = Command.ExecuteReader
            No = 0
            If Reader.HasRows Then
                Do While Reader.Read()
                    No = No + 1
                    Dim myItem As New ListViewItem(No & ".")
                    With myItem.SubItems
                        .Add(Reader.Item("id_supplier").ToString)
                        .Add(Reader.Item("supplier").ToString)
                        .Add(Reader.Item("telepon").ToString)
                    End With
                    xListview.Items.Add(myItem)
                Loop
            End If
            For Each Item In xListview.Items
                If (Item.Index Mod 2) = 0 Then
                    Item.BackColor = Color.White
                Else
                    Item.BackColor = Color.Azure
                End If
            Next
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xListview
    End Function

    Public Function SimpanPembelian(ByVal xFaktur As String, _
                                    ByVal xTglBeli As Date, _
                                    ByVal xSupplier As String, _
                                    ByVal xDisc As String, _
                                    ByVal xTotal As String, _
                                    ByVal xGrand As String, _
                                    ByVal xPegawai As String)
        Try
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand("insert_pembelian", Cn)
            With Command
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@faktur_pembelian", SqlDbType.VarChar).Value = xFaktur
                .Parameters.Add("@tgl_pembelian", SqlDbType.DateTime).Value = xTglBeli
                .Parameters.Add("@id_supplier", SqlDbType.VarChar).Value = xSupplier
                .Parameters.Add("@disc", SqlDbType.Float).Value = xDisc
                .Parameters.Add("@total", SqlDbType.Money).Value = xTotal
                .Parameters.Add("@grand_total", SqlDbType.Money).Value = xGrand
                .Parameters.Add("@id_pegawai", SqlDbType.VarChar).Value = xPegawai
                .ExecuteNonQuery()
            End With
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xFaktur
    End Function

    Public Function SimpanDetailPembelian(ByVal xFaktur As String, _
                                          ByVal xNomor As String, _
                                          ByVal xObat As String, _
                                          ByVal xExpired As Date, _
                                          ByVal xBeli As String, _
                                          ByVal xJumlah As String, _
                                          ByVal xSubTotal As String)
        Try
            Cn.Close()
            Cn.Open()
            Command = New SqlCommand("insert_detail_pembelian", Cn)
            With Command
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@faktur_pembelian", SqlDbType.VarChar).Value = xFaktur
                .Parameters.Add("@nomor", SqlDbType.Int).Value = xNomor
                .Parameters.Add("@id_obat", SqlDbType.VarChar).Value = xObat
                .Parameters.Add("@tgl_expired", SqlDbType.DateTime).Value = xExpired
                .Parameters.Add("@harga_beli", SqlDbType.Money).Value = xBeli
                .Parameters.Add("@jumlah", SqlDbType.Int).Value = xJumlah
                .Parameters.Add("@sub_total", SqlDbType.Money).Value = xSubTotal
                .ExecuteNonQuery()
            End With
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xFaktur
    End Function

    Public Function DaftarBeli(ByVal xListView As ListView)
        Try
            With xListView
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("No.", 40, HorizontalAlignment.Left)
                .Columns.Add("ID Obat", 90, HorizontalAlignment.Left)
                .Columns.Add("Nama Obat", 200, HorizontalAlignment.Left)
                .Columns.Add("Kategori", 150, HorizontalAlignment.Left)
                .Columns.Add("Satuan", 150, HorizontalAlignment.Left)
                .Columns.Add("Stock", 90, HorizontalAlignment.Right)
                .Columns.Add("Tgl. Expired", 100, HorizontalAlignment.Left)
                .Columns.Add("Harga Beli", 150, HorizontalAlignment.Right)
                .Columns.Add("Jumlah", 90, HorizontalAlignment.Right)
                .Columns.Add("Sub Total", 150, HorizontalAlignment.Right)
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        Finally
            Cn.Close()
        End Try
        Return xListView
    End Function

#End Region

End Module
