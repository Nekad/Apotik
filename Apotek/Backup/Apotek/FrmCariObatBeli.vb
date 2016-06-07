Public Class FrmCariObatBeli

    Private Sub FrmCariObatBeli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CariObat(ListView1, TextCari)
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        Try
            With FrmPembelian
                .TextObat.Text = ListView1.SelectedItems(0).SubItems(1).Text
                .TextNama.Text = ListView1.SelectedItems(0).SubItems(2).Text
                .TextKategori.Text = ListView1.SelectedItems(0).SubItems(3).Text
                .TextSatuan.Text = ListView1.SelectedItems(0).SubItems(4).Text
                .TextStock.Text = ListView1.SelectedItems(0).SubItems(5).Text
                .TextBeli.Text = ListView1.SelectedItems(0).SubItems(6).Text
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "peringatan")
        Finally
            FrmPembelian.Enable(True)
            Close()
        End Try
    End Sub

    Private Sub bt_Cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cari.Click
        CariObat(ListView1, TextCari)
    End Sub

    Private Sub TextCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextCari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CariObat(ListView1, TextCari)
        End If
    End Sub
End Class