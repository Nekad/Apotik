Public Class FrmObat

    Private Sub Enable(ByVal xEnable As Boolean)
        With Me
            .TextObat.Enabled = xEnable
            .ComboKategori.Enabled = xEnable
            .ComboSatuan.Enabled = xEnable
            .TextJual.Enabled = xEnable
            .RadioYa.Enabled = xEnable
            .RadioTidak.Enabled = xEnable
            .bt_Baru.Enabled = Not xEnable
            .bt_Simpan.Enabled = xEnable
            .bt_Batal.Enabled = xEnable
        End With
    End Sub

    Private Sub Bersih()
        With Me
            .TextObat.Clear()
            .ComboKategori.SelectedIndex = -1
            .ComboSatuan.SelectedIndex = -1
            .TextBeli.Text = 0
            .TextJual.Text = 0
            .TextStock.Text = 0
            .RadioYa.Checked = False
            .RadioTidak.Checked = False
        End With
    End Sub

    Private Sub FrmObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyParent(Me)
        ID_Otomatis("id_obat", "O", TextID)
        TampilKategori(ComboKategori)
        TampilSatuan(ComboSatuan)
        DataObat(ListView1, ComboCari, TextCari)
        Call Bersih()
        Call Enable(False)
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView1.MouseClick
        Try
            With Me
                .TextID.Text = ListView1.SelectedItems(0).SubItems(1).Text
                .TextObat.Text = ListView1.SelectedItems(0).SubItems(2).Text
                .ComboKategori.Text = ListView1.SelectedItems(0).SubItems(3).Text
                .ComboSatuan.Text = ListView1.SelectedItems(0).SubItems(4).Text
                .TextBeli.Text = Format(CDbl(ListView1.SelectedItems(0).SubItems(5).Text), "##,##0")
                .TextJual.Text = Format(CDbl(ListView1.SelectedItems(0).SubItems(6).Text), "##,##0")
                .TextStock.Text = ListView1.SelectedItems(0).SubItems(7).Text
                If ListView1.SelectedItems(0).SubItems(8).Text = "Ya" Then
                    .RadioYa.Checked = True
                    .RadioTidak.Checked = False
                ElseIf ListView1.SelectedItems(0).SubItems(8).Text = "Tidak" Then
                    .RadioYa.Checked = False
                    .RadioTidak.Checked = True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "peringatan")
        Finally
            Call Enable(True)
        End Try
    End Sub

    Private Sub bt_Simpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Simpan.Click
        If TextObat.Text = "" Then
            MsgBox("Nama obat masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextObat.Focus()
            Exit Sub
        ElseIf ComboKategori.Text = "" Then
            MsgBox("Pilih kategori !", MsgBoxStyle.Exclamation, "Peringatan")
            ComboKategori.Focus()
            Exit Sub
        ElseIf ComboSatuan.Text = "" Then
            MsgBox("Pilih satuan !", MsgBoxStyle.Exclamation, "Peringatan")
            ComboSatuan.Focus()
            Exit Sub
        ElseIf RadioYa.Checked = False And RadioTidak.Checked = False Then
            MsgBox("Pilih status aktif !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            SimpanObat(TextID.Text, TextObat.Text, ComboKategori.SelectedValue, ComboSatuan.SelectedValue, CDbl(TextJual.Text), Radio(RadioYa, RadioTidak), FrmUtama.StatusID.Text)
            ID_Otomatis("id_obat", "O", TextID)
            DataObat(ListView1, ComboCari, TextCari)
            Call Bersih()
            Call Enable(False)
        End If
    End Sub

    Private Sub bt_Baru_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Baru.Click
        ID_Otomatis("id_obat", "O", TextID)
        Call Bersih()
        Call Enable(True)
    End Sub

    Private Sub bt_Batal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Batal.Click
        ID_Otomatis("id_obat", "O", TextID)
        Call Bersih()
        Call Enable(False)
    End Sub

    Private Sub bt_Tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Tutup.Click
        Tutup(Me)
    End Sub

    Private Sub bt_Keluar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Keluar.Click
        Tutup(Me)
    End Sub

    Private Sub bt_Cari_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Cari.Click
        DataObat(ListView1, ComboCari, TextCari)
    End Sub

    Private Sub bt_TbhKategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_TbhKategori.Click
        FrmKategori.ShowDialog()
    End Sub

    Private Sub bt_TbhSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_TbhSatuan.Click
        FrmSatuan.ShowDialog()
    End Sub

    Private Sub TextJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextJual.KeyPress
        TextNumber(e, TextStock)
    End Sub

    Private Sub TextBeli_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBeli.TextChanged
        If TextBeli.TextLength <> 0 Then
            Dim nilai As Double = CDbl(TextBeli.Text)
            TextBeli.Text = Format(Val(nilai), "##,##0")
            TextBeli.SelectionStart = Len(TextBeli.Text)
        Else
            TextBeli.Text = 0
        End If
    End Sub

    Private Sub TextJual_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextJual.TextChanged
        If TextJual.TextLength <> 0 Then
            Dim nilai As Double = CDbl(TextJual.Text)
            TextJual.Text = Format(Val(nilai), "##,##0")
            TextJual.SelectionStart = Len(TextJual.Text)
        Else
            TextJual.Text = 0
        End If
    End Sub

    Private Sub TextStock_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextStock.TextChanged
        If TextStock.TextLength <> 0 Then
            Dim nilai As Double = CDbl(TextStock.Text)
            TextStock.Text = Format(Val(nilai), "##,##0")
            TextStock.SelectionStart = Len(TextStock.Text)
        Else
            TextStock.Text = 0
        End If
    End Sub

    Private Sub ComboKategori_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboKategori.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboSatuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboSatuan.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboCari_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboCari.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextCari_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextCari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DataObat(ListView1, ComboCari, TextCari)
        End If
    End Sub

End Class