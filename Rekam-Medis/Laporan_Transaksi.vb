Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Laporan_Transaksi
    Dim Rd As MySqlDataReader
    Private Sub Laporan_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Laporan_Transaksi()
        Me.rpLporan_transaksi.RefreshReport()
    End Sub
    Sub Laporan_Transaksi()
        'Laporan_Transaksi
        Call OpenConn()
        rpLporan_transaksi.RefreshReport()
        Dim Laporan_Transaksi As ReportDataSource
        With rpLporan_transaksi.LocalReport
            .ReportPath = ""
            .DataSources.Clear()
        End With
        Da = New MySqlDataAdapter("select * from rekam_medis", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "rekam_medis")
        Laporan_Transaksi = New ReportDataSource("rekam_medis", Ds.Tables("rekam_medis"))
        rpLporan_transaksi.LocalReport.DataSources.Add(Laporan_Transaksi)
        rpLporan_transaksi.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'Laporan_Pasien
        Dim Laporan_Pasien As ReportDataSource
        Da = New MySqlDataAdapter("select * from pasien", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pasien")
        Laporan_Pasien = New ReportDataSource("Pasien", Ds.Tables("pasien"))
        rpLporan_transaksi.LocalReport.DataSources.Add(Laporan_Pasien)
        rpLporan_transaksi.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'Laporan_Dokter
        Dim Laporan_Dokter As ReportDataSource
        Da = New MySqlDataAdapter("select * from dokter", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "dokter")
        Laporan_Dokter = New ReportDataSource("Dokter", Ds.Tables("dokter"))
        rpLporan_transaksi.LocalReport.DataSources.Add(Laporan_Dokter)
        rpLporan_transaksi.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'Laporan_Obat
        Dim Laporan_Obat As ReportDataSource
        Da = New MySqlDataAdapter("select * from obat", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "obat")
        Laporan_Obat = New ReportDataSource("Obat", Ds.Tables("obat"))
        rpLporan_transaksi.LocalReport.DataSources.Add(Laporan_Obat)
        rpLporan_transaksi.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

    End Sub
End Class