Public Class FrmCariSupplier

    Private Sub FrmCariSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CariSupplier(ListView1, TextCari)
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        Try
            With FrmPembelian
                .TextID.Text = ListView1.SelectedItems(0).SubItems(1).Text
                .TextSupplier.Text = ListView1.SelectedItems(0).SubItems(2).Text
                .TextTelp.Text = ListView1.SelectedItems(0).SubItems(3).Text
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "peringatan")
        Finally
            Close()
        End Try
    End Sub

    Private Sub bt_Cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cari.Click
        CariSupplier(ListView1, TextCari)
    End Sub

    Private Sub TextCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextCari.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CariSupplier(ListView1, TextCari)
        End If
    End Sub
End Class