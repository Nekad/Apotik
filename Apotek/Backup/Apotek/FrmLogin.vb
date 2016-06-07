Public Class FrmLogin

    Private Sub bt_login_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_login.Click
        If TextUser.Text = "" Then
            MsgBox("Username tidak boleh kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextUser.Focus()
            Exit Sub
        ElseIf TextPass.Text = "" Then
            MsgBox("Password tidak boleh kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextPass.Focus()
            Exit Sub
        Else
            Login(Me, TextUser, TextPass)
        End If
    End Sub

    Private Sub FrmLogin_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Enable(True, FrmUtama.MasterToolStripMenuItem, FrmUtama.TransaksiToolStripMenuItem, FrmUtama.PencarianToolStripMenuItem, FrmUtama.LaporanToolStripMenuItem, FrmUtama.SistemToolStripMenuItem, FrmUtama.Timer1)
        Status(TextUser, FrmUtama.StatusID, FrmUtama.StatusPegawai, FrmUtama.StatusTanggal, FrmUtama.StatusWaktu)
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Enable(False, FrmUtama.MasterToolStripMenuItem, FrmUtama.TransaksiToolStripMenuItem, FrmUtama.PencarianToolStripMenuItem, FrmUtama.LaporanToolStripMenuItem, FrmUtama.SistemToolStripMenuItem, FrmUtama.Timer1)
        StatusBersih(FrmUtama.StatusID, FrmUtama.StatusPegawai, FrmUtama.StatusTanggal, FrmUtama.StatusWaktu)
        TextUser.Clear()
        TextPass.Clear()
    End Sub

    Private Sub TextUser_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextUser.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Enter
            If TextUser.Text = "" Then
                MsgBox("Username tidak boleh kosong !", MsgBoxStyle.Exclamation, "Perhatian")
                TextUser.Focus()
                Exit Sub
            ElseIf TextPass.Text = "" Then
                MsgBox("Password tidak boleh kosong !", MsgBoxStyle.Exclamation, "Perhatian")
                TextPass.Focus()
                Exit Sub
            Else
                Login(Me, TextUser, TextPass)
            End If
        End If
    End Sub

    Private Sub TextPass_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextPass.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Enter
            If TextUser.Text = "" Then
                MsgBox("Username tidak boleh kosong !", MsgBoxStyle.Exclamation, "Perhatian")
                TextUser.Focus()
                Exit Sub
            ElseIf TextPass.Text = "" Then
                MsgBox("Password tidak boleh kosong !", MsgBoxStyle.Exclamation, "Perhatian")
                TextPass.Focus()
                Exit Sub
            Else
                Login(Me, TextUser, TextPass)
            End If
        End If
    End Sub

    Private Sub bt_keluar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_keluar.Click
        If MsgBox("Apa anda ingin keluar ?", MsgBoxStyle.YesNo, "Peringatan") = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    
End Class