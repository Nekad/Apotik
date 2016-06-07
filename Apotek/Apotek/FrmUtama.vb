Public Class FrmUtama

    Private Sub FrmUtama_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Apa anda ingin keluar ?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Apa anda ingin logout ?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
            MsgBox("Anda telah logout !", MsgBoxStyle.Information, "Peringatan")
            TabControl1.TabPages.Clear()
            FrmLogin.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MsgBox("Apa anda ingin keluar ?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub FrmUtama_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID", True)
        FrmLogin.ShowDialog()




    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        Tampilkan(FrmPegawai)
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles KategoriToolStripMenuItem.Click
        FrmKategori.ShowDialog()
    End Sub

    Private Sub SatuanToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SatuanToolStripMenuItem.Click
        FrmSatuan.ShowDialog()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ObatToolStripMenuItem.Click
        Tampilkan(FrmObat)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        StatusWaktu.Text = Format(Now, "H:mm:ss")
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        Tampilkan(FrmPembelian)
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        Tampilkan(FrmSupplier)
    End Sub

    Private Sub PembelianToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem2.Click
        Tampilkan(LprPembelian)
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged


    End Sub
End Class
