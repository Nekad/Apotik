Public Class LprPembelian

    Private Sub LprPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyParent(Me)
        With Me
            .ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            .view_pembelianTableAdapter.Fill(.apotekDataSet.view_pembelian)
            .ReportViewer1.RefreshReport()
        End With
    End Sub

    Private Sub ReportViewer1_ReportRefresh(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.ReportRefresh
        With Me
            .ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            .view_pembelianTableAdapter.Fill(.apotekDataSet.view_pembelian)
            .ReportViewer1.RefreshReport()
        End With
    End Sub

    Private Sub bt_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Keluar.Click
        Tutup(Me)
    End Sub
End Class