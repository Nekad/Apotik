Public Class FrmKategori

    Private Sub Enable(ByVal xEnable As Boolean)
        With Me
            .TextKategori.Enabled = xEnable
            .RadioYa.Enabled = xEnable
            .RadioTidak.Enabled = xEnable
            .bt_Baru.Enabled = Not xEnable
            .bt_Simpan.Enabled = xEnable
            .bt_Batal.Enabled = xEnable
        End With
    End Sub

    Private Sub Bersih()
        With Me
            .TextKategori.Clear()
            .RadioYa.Checked = False
            .RadioTidak.Checked = False
        End With
    End Sub

    Private Sub FrmKategori_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ID_Otomatis("id_kategori", "K", TextID)
        DataKategori(ListView1, TextCari)
        Call Bersih()
        Call Enable(False)
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView1.MouseClick
        Try
            With Me
                .TextID.Text = ListView1.SelectedItems(0).SubItems(1).Text
                .TextKategori.Text = ListView1.SelectedItems(0).SubItems(2).Text
                If ListView1.SelectedItems(0).SubItems(3).Text = "Ya" Then
                    .RadioYa.Checked = True
                    .RadioTidak.Checked = False
                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "Tidak" Then
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
        If TextKategori.Text = "" Then
            MsgBox("Kategori masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextKategori.Focus()
            Exit Sub
        ElseIf RadioYa.Checked = False And RadioTidak.Checked = False Then
            MsgBox("Pilih status aktif !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            SimpanKategori(TextID.Text, TextKategori.Text, Radio(RadioYa, RadioTidak))
            ID_Otomatis("id_kategori", "K", TextID)
            TampilKategori(FrmObat.ComboKategori)
            DataKategori(ListView1, TextCari)
            Call Bersih()
            Call Enable(False)
        End If
    End Sub

    Private Sub bt_Baru_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Baru.Click
        ID_Otomatis("id_kategori", "K", TextID)
        Call Bersih()
        Call Enable(True)
    End Sub

    Private Sub bt_Batal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Batal.Click
        ID_Otomatis("id_kategori", "K", TextID)
        Call Bersih()
        Call Enable(False)
    End Sub

    Private Sub bt_Cari_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Cari.Click
        DataKategori(ListView1, TextCari)
    End Sub

    Private Sub TextCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextCari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DataKategori(ListView1, TextCari)
        End If
    End Sub
End Class