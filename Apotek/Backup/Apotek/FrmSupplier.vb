Public Class FrmSupplier

    Private Sub Enable(ByVal xEnable As Boolean)
        With Me
            .TextSupplier.Enabled = xEnable
            .TextAlamat.Enabled = xEnable
            .TextKota.Enabled = xEnable
            .TextTelp.Enabled = xEnable
            .RadioYa.Enabled = xEnable
            .RadioTidak.Enabled = xEnable
            .bt_Baru.Enabled = Not xEnable
            .bt_Simpan.Enabled = xEnable
            .bt_Batal.Enabled = xEnable
        End With
    End Sub

    Private Sub Bersih()
        With Me
            .TextSupplier.Clear()
            .TextAlamat.Clear()
            .TextKota.Clear()
            .TextTelp.Clear()
            .RadioYa.Checked = False
            .RadioTidak.Checked = False
        End With
    End Sub

    Private Sub FrmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyParent(Me)
        ID_Otomatis("id_supplier", "S", TextID)
        DataSupplier(ListView1, ComboCari, TextCari)
        Call Bersih()
        Call Enable(False)
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView1.MouseClick
        Try
            With Me
                .TextID.Text = ListView1.SelectedItems(0).SubItems(1).Text
                .TextSupplier.Text = ListView1.SelectedItems(0).SubItems(2).Text
                .TextAlamat.Text = ListView1.SelectedItems(0).SubItems(3).Text
                .TextKota.Text = ListView1.SelectedItems(0).SubItems(4).Text
                .TextTelp.Text = ListView1.SelectedItems(0).SubItems(5).Text
                If ListView1.SelectedItems(0).SubItems(6).Text = "Ya" Then
                    .RadioYa.Checked = True
                    .RadioTidak.Checked = False
                ElseIf ListView1.SelectedItems(0).SubItems(6).Text = "Tidak" Then
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
        If TextSupplier.Text = "" Then
            MsgBox("Supplier masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextSupplier.Focus()
            Exit Sub
        ElseIf TextAlamat.Text = "" Then
            MsgBox("Alamat masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextAlamat.Focus()
            Exit Sub
        ElseIf TextKota.Text = "" Then
            MsgBox("Kota masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextKota.Focus()
            Exit Sub
        ElseIf TextTelp.Text = "" Then
            MsgBox("Telepon masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextTelp.Focus()
            Exit Sub
        ElseIf RadioYa.Checked = False And RadioTidak.Checked = False Then
            MsgBox("Pilih status aktif !", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            SimpanSupplier(TextID.Text, TextSupplier.Text, TextAlamat.Text, TextKota.Text, TextTelp.Text, Radio(RadioYa, RadioTidak), FrmUtama.StatusID.Text)
            ID_Otomatis("id_supplier", "S", TextID)
            DataSupplier(ListView1, ComboCari, TextCari)
            Call Bersih()
            Call Enable(False)
        End If
    End Sub

    Private Sub bt_Baru_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Baru.Click
        ID_Otomatis("id_supplier", "S", TextID)
        Call Bersih()
        Call Enable(True)
    End Sub

    Private Sub bt_Batal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Batal.Click
        ID_Otomatis("id_supplier", "S", TextID)
        Call Bersih()
        Call Enable(False)
    End Sub

    Private Sub bt_Tutup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Tutup.Click
        Tutup(Me)
    End Sub

    Private Sub bt_Keluar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Keluar.Click
        Tutup(Me)
    End Sub

    Private Sub bt_Cari_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Cari.Click
        DataSupplier(ListView1, ComboCari, TextCari)
    End Sub

    Private Sub TextTelp_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextTelp.KeyPress
        TextMobile(e, TextTelp)
    End Sub

    Private Sub ComboCari_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboCari.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextCari_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextCari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DataSupplier(ListView1, ComboCari, TextCari)
        End If
    End Sub


End Class