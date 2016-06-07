Public Class FrmPembelian

    Private Sub BersihSemua()
        With Me
            .TextID.Clear()
            .TextSupplier.Clear()
            .TextTelp.Clear()
            .TextObat.Clear()
            .TextNama.Clear()
            .TextKategori.Clear()
            .TextSatuan.Clear()
            .TextStock.Text = 0
            .DateExpired.Value = Now.Date
            .TextBeli.Text = 0
            .TextJumlah.Text = 0
            .TextTotal.Text = Format(0, "Currency")
            .TextDiskon.Text = 0
            .TextGrandTotal.Text = Format(0, "Currency")
            .ListView1.Items.Clear()
        End With
    End Sub

    Private Sub Bersih()
        With Me
            .TextObat.Clear()
            .TextNama.Clear()
            .TextKategori.Clear()
            .TextSatuan.Clear()
            .TextStock.Text = 0
            .DateExpired.Value = Now.Date
            .TextBeli.Text = 0
            .TextJumlah.Text = 0
        End With
    End Sub

    Public Sub Enable(ByVal xEnable As Boolean)
        With Me
            .TextBeli.Enabled = xEnable
            .DateExpired.Enabled = xEnable
            .TextJumlah.Enabled = xEnable
            .bt_Tambah.Enabled = xEnable
            .bt_Kurang.Enabled = xEnable
            .bt_Update.Enabled = xEnable
            .bt_Bersih.Enabled = xEnable
        End With
    End Sub

    Private Sub EnableObat(ByVal xEnable As Boolean)
        With Me
            .TextObat.Enabled = xEnable
            .bt_CariObat.Enabled = xEnable
            .TextDiskon.Enabled = xEnable
        End With
    End Sub


    Private Sub FrmPembelian_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        MyParent(Me)
        NO_Otomatis("faktur_pembelian", "FB", TextFakturBeli)
        DaftarBeli(ListView1)
        Call BersihSemua()
        Call Enable(False)
        Call EnableObat(False)
    End Sub

    Private Sub bt_CariSupplier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_CariSupplier.Click
        FrmCariSupplier.ShowDialog()
    End Sub

    Private Sub TextID_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TextID.Click
        FrmCariSupplier.ShowDialog()
    End Sub

    Private Sub TextID_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextID.KeyPress
        e.Handled = True
        FrmCariSupplier.ShowDialog()
    End Sub

    Private Sub TextID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextID.TextChanged
        If TextID.Text = "" Then
            Call EnableObat(False)
        Else
            Call EnableObat(True)
        End If
    End Sub

    Private Sub bt_CariObat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_CariObat.Click
        FrmCariObatBeli.ShowDialog()
    End Sub

    Private Sub TextObat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TextObat.Click
        FrmCariObatBeli.ShowDialog()
    End Sub

    Private Sub TextObat_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextObat.KeyPress
        e.Handled = True
        FrmCariObatBeli.ShowDialog()
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ListView1.MouseClick
        Try
            With Me
                .TextObat.Text = ListView1.SelectedItems(0).SubItems(1).Text
                .TextNama.Text = ListView1.SelectedItems(0).SubItems(2).Text
                .TextKategori.Text = ListView1.SelectedItems(0).SubItems(3).Text
                .TextSatuan.Text = ListView1.SelectedItems(0).SubItems(4).Text
                .TextStock.Text = Format(CDbl(ListView1.SelectedItems(0).SubItems(5).Text), "##,##0")
                .DateExpired.Value = CDate(ListView1.SelectedItems(0).SubItems(6).Text)
                .TextBeli.Text = Format(CDbl(ListView1.SelectedItems(0).SubItems(7).Text), "##,##0")
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "peringatan")
        Finally
            Call Enable(True)
        End Try
    End Sub

    Private Sub bt_Bersih_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Bersih.Click
        Call Bersih()
        Call Enable(False)
        TextObat.Focus()
    End Sub

    Private Sub bt_Tambah_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Tambah.Click
        Try
            Dim Beli As Boolean = False

            If TextObat.Text = "" Then
                MsgBox("Silahkan masukan ID Obat !", MsgBoxStyle.Exclamation, "Peringatan")
                TextObat.Focus()
                Exit Sub
            ElseIf DateExpired.Value <= Now.Date Then
                MsgBox("Silahkan masukan tanggal expired !", MsgBoxStyle.Exclamation, "Peringatan")
                DateExpired.Focus()
                Exit Sub
            ElseIf TextBeli.Text = 0 Then
                MsgBox("Silahkan masukan harga beli !", MsgBoxStyle.Exclamation, "Peringatan")
                TextBeli.Focus()
                Exit Sub
            ElseIf TextJumlah.Text = 0 Then
                MsgBox("Silahkan masukan jumlah yang ingin di tambah !", MsgBoxStyle.Exclamation, "Peringatan")
                TextJumlah.Focus()
                Exit Sub
            Else
                No = ListView1.Items.Count + 1
                For i As Integer = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(1).Text = TextObat.Text Then
                        ListView1.Items.Item(i).SubItems(0).Text = ListView1.Items.Item(i).SubItems(0).Text
                        ListView1.Items.Item(i).SubItems(2).Text = TextNama.Text
                        ListView1.Items.Item(i).SubItems(3).Text = TextKategori.Text
                        ListView1.Items.Item(i).SubItems(4).Text = TextSatuan.Text
                        ListView1.Items.Item(i).SubItems(5).Text = Format(CDbl(TextStock.Text), "##,##0")
                        ListView1.Items.Item(i).SubItems(6).Text = Format(DateExpired.Value.Date, "dd/MM/yyyy")
                        ListView1.Items.Item(i).SubItems(7).Text = Format(CDbl(TextBeli.Text), "Currency")
                        ListView1.Items.Item(i).SubItems(8).Text = Format(CDbl(ListView1.Items.Item(i).SubItems(8).Text) + CDbl(TextJumlah.Text), "##,##0")
                        ListView1.Items.Item(i).SubItems(9).Text = Format(CDbl(TextBeli.Text) * CDbl(ListView1.Items.Item(i).SubItems(8).Text), "Currency")

                        Dim total As Double
                        For a As Integer = 0 To ListView1.Items.Count - 1
                            total += Format(CDbl(ListView1.Items(a).SubItems(9).Text), "##,##0")
                        Next a

                        Dim disc As Double
                        disc = CDbl(TextDiskon.Text)

                        TextTotal.Text = Format(Val(total), "Currency")
                        TextGrandTotal.Text = Format(Val(total - ((total * disc) / 100)), "Currency")

                        Call Bersih()
                        Call Enable(False)
                        TextObat.Focus()
                        Beli = True
                        Exit Sub
                    Else
                        Beli = False
                    End If
                Next i

                If Beli = False Then
                    Dim myItem As New ListViewItem(No.ToString)
                    With myItem.SubItems
                        .Add(TextObat.Text)
                        .Add(TextNama.Text)
                        .Add(TextKategori.Text)
                        .Add(TextSatuan.Text)
                        .Add(Format(CDbl(TextStock.Text), "##,##0"))
                        .Add(Format(DateExpired.Value.Date, "dd/MM/yyyy"))
                        .Add(Format(CDbl(TextBeli.Text), "Currency"))
                        .Add(Format(CDbl(TextJumlah.Text), "##,##0"))
                        .Add(Format(CDbl(TextBeli.Text) * CDbl(TextJumlah.Text), "Currency"))
                    End With
                    ListView1.Items.Add(myItem)

                    Dim total As Double
                    For a As Integer = 0 To ListView1.Items.Count - 1
                        total += Format(CDbl(ListView1.Items(a).SubItems(9).Text), "##,##0")
                    Next a

                    Dim disc As Double
                    disc = CDbl(TextDiskon.Text)

                    TextTotal.Text = Format(Val(total), "Currency")
                    TextGrandTotal.Text = Format(Val(total - ((total * disc) / 100)), "Currency")

                    Call Bersih()
                    Call Enable(False)
                    TextObat.Focus()
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub bt_Kurang_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Kurang.Click
        Try
            If TextObat.Text = "" Then
                MsgBox("Silahkan masukan ID Buku !", MsgBoxStyle.Exclamation, "Peringatan")
                TextObat.Focus()
                Exit Sub
            ElseIf DateExpired.Value <= Now.Date Then
                MsgBox("Silahkan masukan tanggal expired !", MsgBoxStyle.Exclamation, "Peringatan")
                DateExpired.Focus()
                Exit Sub
            ElseIf TextBeli.Text = 0 Then
                MsgBox("Silahkan masukan harga beli !", MsgBoxStyle.Exclamation, "Peringatan")
                TextBeli.Focus()
                Exit Sub
            ElseIf TextJumlah.Text = 0 Then
                MsgBox("Silahkan masukan jumlah yang ingin di tambah !", MsgBoxStyle.Exclamation, "Peringatan")
                TextJumlah.Focus()
                Exit Sub
            Else
                For i As Integer = 0 To ListView1.Items.Count - 1
                    If TextJumlah.Text > CDbl(ListView1.Items.Item(i).SubItems(8).Text) Then
                        MsgBox("Jumlah yang ingin di kurangi melebihi batas !", MsgBoxStyle.Exclamation, "Peringatan")
                        TextJumlah.Focus()
                        Exit Sub
                    Else
                        If ListView1.Items.Item(i).SubItems(1).Text = TextObat.Text Then
                            ListView1.Items.Item(i).SubItems(0).Text = ListView1.Items.Item(i).SubItems(0).Text
                            ListView1.Items.Item(i).SubItems(2).Text = TextNama.Text
                            ListView1.Items.Item(i).SubItems(3).Text = TextKategori.Text
                            ListView1.Items.Item(i).SubItems(4).Text = TextSatuan.Text
                            ListView1.Items.Item(i).SubItems(5).Text = Format(CDbl(TextStock.Text), "##,##0")
                            ListView1.Items.Item(i).SubItems(6).Text = Format(DateExpired.Value.Date, "dd/MM/yyyy")
                            ListView1.Items.Item(i).SubItems(7).Text = Format(CDbl(TextBeli.Text), "Currency")
                            ListView1.Items.Item(i).SubItems(8).Text = Format(CDbl(ListView1.Items.Item(i).SubItems(8).Text) - CDbl(TextJumlah.Text), "##,##0")
                            ListView1.Items.Item(i).SubItems(9).Text = Format(CDbl(TextBeli.Text) * CDbl(ListView1.Items.Item(i).SubItems(8).Text), "Currency")

                            Dim total As Double
                            For a As Integer = 0 To ListView1.Items.Count - 1
                                total += Format(CDbl(ListView1.Items(a).SubItems(9).Text), "##,##0")
                            Next a

                            Dim disc As Double
                            disc = CDbl(TextDiskon.Text)

                            TextTotal.Text = Format(Val(total), "Currency")
                            TextGrandTotal.Text = Format(Val(total - ((total * disc) / 100)), "Currency")

                            If ListView1.Items.Item(i).SubItems(8).Text <= 0 Then
                                ListView1.Items.Item(i).Remove()
                            End If

                            Call Bersih()
                            Call Enable(False)
                            TextObat.Focus()
                            Exit Sub
                        End If
                    End If
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub bt_Update_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Update.Click
        Try
            Dim Update As Boolean = False

            If TextObat.Text = "" Then
                MsgBox("Silahkan masukan ID Obat yang ingin di update!", MsgBoxStyle.Exclamation, "Peringatan")
                TextObat.Focus()
                Exit Sub
            ElseIf DateExpired.Value <= Now.Date Then
                MsgBox("Silahkan masukan tanggal expired !", MsgBoxStyle.Exclamation, "Peringatan")
                DateExpired.Focus()
                Exit Sub
            ElseIf TextBeli.Text = 0 Then
                MsgBox("Silahkan masukan harga beli !", MsgBoxStyle.Exclamation, "Peringatan")
                TextBeli.Focus()
                Exit Sub
            Else
                For i As Integer = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(1).Text = TextObat.Text Then
                        ListView1.Items.Item(i).SubItems(0).Text = ListView1.Items.Item(i).SubItems(0).Text
                        ListView1.Items.Item(i).SubItems(2).Text = TextNama.Text
                        ListView1.Items.Item(i).SubItems(3).Text = TextKategori.Text
                        ListView1.Items.Item(i).SubItems(4).Text = TextSatuan.Text
                        ListView1.Items.Item(i).SubItems(5).Text = Format(CDbl(TextStock.Text), "##,##0")
                        ListView1.Items.Item(i).SubItems(6).Text = Format(DateExpired.Value.Date, "dd/MM/yyyy")
                        ListView1.Items.Item(i).SubItems(7).Text = Format(CDbl(TextBeli.Text), "Currency")
                        ListView1.Items.Item(i).SubItems(9).Text = Format(CDbl(TextBeli.Text) * CDbl(ListView1.Items.Item(i).SubItems(8).Text), "Currency")

                        Dim total As Double
                        For a As Integer = 0 To ListView1.Items.Count - 1
                            total += Format(CDbl(ListView1.Items(a).SubItems(9).Text), "##,##0")
                        Next a

                        Dim disc As Double
                        disc = CDbl(TextDiskon.Text)

                        TextTotal.Text = Format(Val(total), "Currency")
                        TextGrandTotal.Text = Format(Val(total - ((total * disc) / 100)), "Currency")

                        Call Bersih()
                        Call Enable(False)
                        TextObat.Focus()
                        Update = True
                        Exit Sub
                    Else
                        Update = False
                    End If
                Next i

                If Update = False Then
                    MsgBox("Obat belum ada pada daftar pembelian !", MsgBoxStyle.Exclamation, "Peringatan")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
        End Try
    End Sub

    Private Sub TextDiskon_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextDiskon.KeyPress
        TextNumber(e, TextDiskon)
    End Sub

    Private Sub TextDiskon_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextDiskon.TextChanged
        If TextDiskon.TextLength <> 0 Then
            If TextDiskon.Text <= 100 Then
                Dim nilai As Double = CDbl(TextDiskon.Text)
                TextDiskon.Text = Format(Val(nilai), "##,##0")
                TextDiskon.SelectionStart = Len(TextDiskon.Text)
            Else
                TextDiskon.Text = 100
            End If
        Else
            TextDiskon.Text = 0
        End If
        TextGrandTotal.Text = Format(CDbl(TextTotal.Text) - ((CDbl(TextTotal.Text) * CDbl(TextDiskon.Text)) / 100), "Currency")
    End Sub

    Private Sub TextJumlah_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextJumlah.KeyPress
        TextNumber(e, TextJumlah)
    End Sub

    Private Sub TextJumlah_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextJumlah.TextChanged
        If TextJumlah.TextLength <> 0 Then
            Dim nilai As Double = CDbl(TextJumlah.Text)
            TextJumlah.Text = Format(Val(nilai), "##,##0")
            TextJumlah.SelectionStart = Len(TextJumlah.Text)
        Else
            TextJumlah.Text = 0
        End If
    End Sub

    Private Sub TextBeli_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBeli.KeyPress
        TextNumber(e, TextBeli)
    End Sub

    Private Sub TextBeli_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBeli.TextChanged
        If TextBeli.TextLength <> 0 Then
            Dim nilai As Double = CDbl(TextBeli.Text)
            TextBeli.Text = Format(Val(nilai), "##,##0")
            TextBeli.SelectionStart = Len(TextBeli.Text)
        Else
            TextBeli.Text = 0
        End If
    End Sub

    Private Sub TextStock_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextStock.KeyPress
        TextNumber(e, TextStock)
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

    Private Sub bt_Tutup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Tutup.Click
        Tutup(Me)
    End Sub

    Private Sub bt_Batal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Batal.Click
        Call BersihSemua()
        Call Enable(False)
    End Sub

    Private Sub bt_Simpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Simpan.Click
        If TextID.Text = "" Then
            MsgBox("Pilih ID Supplier !", MsgBoxStyle.Exclamation, "Peringatan")
            TextID.Focus()
            Exit Sub
        ElseIf ListView1.Items.Count = 0 Then
            MsgBox("Daftar Pembelian Obat masih kosong !", MsgBoxStyle.Exclamation, "Peringatan")
            TextObat.Focus()
            Exit Sub
        Else
            Try
                SimpanPembelian(TextFakturBeli.Text, Now.Date, TextID.Text, Format(CDbl(TextDiskon.Text), "##,##0"), Format(CDbl(TextTotal.Text), "##,##0"), Format(CDbl(TextGrandTotal.Text), "##,##0"), FrmUtama.StatusID.Text)
                For i As Integer = 0 To ListView1.Items.Count - 1
                    SimpanDetailPembelian(TextFakturBeli.Text, _
                                          CInt(ListView1.Items.Item(i).SubItems(0).Text.ToString), ListView1.Items.Item(i).SubItems(1).Text.ToString, CDate(ListView1.Items.Item(i).SubItems(6).Text.ToString), Format(CDbl(ListView1.Items.Item(i).SubItems(7).Text.ToString), "##,##0"), CDbl(ListView1.Items.Item(i).SubItems(8).Text.ToString), Format(CDbl(ListView1.Items.Item(i).SubItems(9).Text.ToString), "##,##0"))
                Next i
                MsgBox("Data tersimpan !", MsgBoxStyle.Information, "Peringatan")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan")
            Finally
                NO_Otomatis("faktur_pembelian", "FB", TextFakturBeli)
                DataObat(FrmObat.ListView1, FrmObat.ComboCari, FrmObat.TextCari)
                Call BersihSemua()
                Call Enable(False)
            End Try
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTotal.TextChanged

    End Sub

    Private Sub TextGrandTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextGrandTotal.TextChanged

    End Sub
End Class