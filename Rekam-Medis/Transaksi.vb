Imports MySql.Data.MySqlClient
Public Class Transaksi
    Sub Tampil()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from rekam_medis", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "rekam_medis")
        dgrekam.DataSource = Ds.Tables("rekam_medis")
        dgrekam.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Sub Kosong()
        txtnorekam.Text = ""
        txtnopasien.Text = ""
        txtnamapasien.Text = ""
        txtalamatpasien.Text = ""
        txtkodedokter.Text = ""
        txtnamadokter.Text = ""
        txttelpdokter.Text = ""
        txtkeluhan.Text = ""
        txtdiagnosa.Text = ""
        txtketerangan.Text = ""
        txtkodeobat.Text = ""
        txtnamaobat.Text = ""
        txthargaobat.Text = ""
        txtjumlahobat.Text = ""
        txtbiayadokter.Text = ""
        txtbiayaobat.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembali.Text = ""
    End Sub
    Sub Hidup()
        dttanggal.Enabled = True
        txtnorekam.Enabled = True
        txtnopasien.Enabled = True
        txtnamapasien.Enabled = True
        txtalamatpasien.Enabled = True
        txtkodedokter.Enabled = True
        txtnamadokter.Enabled = True
        txttelpdokter.Enabled = True
        txtkeluhan.Enabled = True
        txtdiagnosa.Enabled = True
        txtketerangan.Enabled = True
        txtkodeobat.Enabled = True
        txtnamaobat.Enabled = True
        txthargaobat.Enabled = True
        txtjumlahobat.Enabled = True
        txtbiayadokter.Enabled = True
        txtbiayaobat.Enabled = True
        txttotal.Enabled = True
        txtbayar.Enabled = True
        txtkembali.Enabled = True
    End Sub
    Sub Mati()
        dttanggal.Enabled = False
        txtnorekam.Enabled = False
        txtnopasien.Enabled = False
        txtnamapasien.Enabled = False
        txtalamatpasien.Enabled = False
        txtkodedokter.Enabled = False
        txtnamadokter.Enabled = False
        txttelpdokter.Enabled = False
        txtkeluhan.Enabled = False
        txtdiagnosa.Enabled = False
        txtketerangan.Enabled = False
        txtkodeobat.Enabled = False
        txtnamaobat.Enabled = False
        txthargaobat.Enabled = False
        txtjumlahobat.Enabled = False
        txtbiayadokter.Enabled = False
        txtbiayaobat.Enabled = False
        txttotal.Enabled = False
        txtbayar.Enabled = False
        txtkembali.Enabled = False
    End Sub
    Sub Normal()
        Call Kosong()
        btntambah.Enabled = True
        btntotal.Enabled = True
        btnsimpan.Enabled = True
        btnkeluar.Text = "Keluar"
    End Sub
    Sub KodeOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select no_rekam from rekam_medis order by no_rekam desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            txtnorekam.Text = "RM" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("no_rekam"), 3, 6) = Format(Today, "yyMMdd") Then
                txtnorekam.Text = "RM" + Format(Microsoft.VisualBasic.Right(Rd.Item("no_rekam"), 8) + 1, "00")
            Else
                txtnorekam.Text = "RM" + Format(Today, "yyMMdd") + "01"
            End If
        End If
        Rd.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BuatKolom()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        btnkeluar.Text = "&CANCEL"
        Call Hidup()
        Call Kosong()
        Call KodeOtomatis()
        txtnorekam.Enabled = False
        txtnopasien.Focus()
        dgrekam.Columns.Clear()
        Call BuatKolom()
    End Sub
    Private Sub txtnopasien_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnopasien.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from pasien where no_pasien='" & txtnopasien.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
                txtnopasien.Text = ""
                txtnopasien.Focus()
            Else
                txtnamapasien.Text = Rd.Item("nama_pasien")
                txtalamatpasien.Text = Rd.Item("alamat")
                txtkodedokter.Focus()
                txtnamapasien.Enabled = False
                txtalamatpasien.Enabled = False
            End If
        End If
    End Sub
    Private Sub txtkodedokter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkodedokter.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from dokter where kd_dokter='" & txtkodedokter.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
                txtkodedokter.Text = ""
                txtkodedokter.Focus()
            Else
                txtnamadokter.Text = Rd.Item("nama_dokter")
                txttelpdokter.Text = Rd.Item("telp")
                txtkeluhan.Focus()
                txtnamadokter.Enabled = False
                txttelpdokter.Enabled = False
            End If
        End If
    End Sub
    Private Sub txtkodeobat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkodeobat.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from obat where kd_obat='" & txtkodeobat.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
                txtnamaobat.Text = ""
                txtnamaobat.Focus()
            Else
                txtnamaobat.Text = Rd.Item("nama_obat")
                txthargaobat.Text = Rd.Item("harga")
                txtjumlahobat.Focus()
                txtnamaobat.Enabled = False
                txthargaobat.Enabled = False
            End If
        End If
    End Sub
    Private Sub txtjumlahobat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlahobat.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtjumlahobat.Text = "" Then
                MsgBox("Jumlah Masih Kosong Isakkkkkk !!!")
                txtkodeobat.Focus()
            Else
                dgtransaksi.RowCount = dgtransaksi.RowCount + 1
                dgtransaksi(0, dgtransaksi.RowCount - 2).Value = txtkodeobat.Text
                dgtransaksi(1, dgtransaksi.RowCount - 2).Value = txtnamaobat.Text
                dgtransaksi(2, dgtransaksi.RowCount - 2).Value = txthargaobat.Text
                dgtransaksi(3, dgtransaksi.RowCount - 2).Value = txtjumlahobat.Text
                dgtransaksi(4, dgtransaksi.RowCount - 2).Value = txtjumlahobat.Text * txthargaobat.Text
            End If
            txtkodeobat.Clear()
            txtnamaobat.Clear()
            txthargaobat.Clear()
            txtjumlahobat.Clear()
            btntotal.Focus()
        End If
    End Sub
    Sub BuatKolom()
        dgtransaksi.Columns.Clear()
        dgtransaksi.Columns.Add("Kode", "Kode Obat")
        dgtransaksi.Columns.Add("Nama", "Nama Obat")
        dgtransaksi.Columns.Add("Harga", "Harga Obat")
        dgtransaksi.Columns.Add("Jumlah", "Jumlah Obat")
        dgtransaksi.Columns.Add("Total", "Total Obat")
        dgtransaksi.ReadOnly = True
    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        Dim total As Integer
        For i As Integer = 0 To dgtransaksi.RowCount - 1
            total += dgtransaksi.Item(4, i).Value
        Next
        txtbiayaobat.Text = total.ToString
        txtbiayadokter.Text = 200000
        txttotal.Text = Val(txtbiayadokter.Text) + Val(txtbiayaobat.Text)
        txtbayar.Focus()
    End Sub
    Private Sub txtbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            txtkembali.Text = txtbayar.Text - txttotal.Text
            Call Mati()
        End If
    End Sub
    Private Sub txtkeluhan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkeluhan.KeyPress
        If e.KeyChar = Chr(13) Then
            txtdiagnosa.Focus()
        End If
    End Sub
    Private Sub txtdiagnosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiagnosa.KeyPress
        If e.KeyChar = Chr(13) Then
            txtketerangan.Focus()
        End If
    End Sub
    Private Sub txtketerangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtketerangan.KeyPress
        If e.KeyChar = Chr(13) Then
            txtkodeuser.Focus()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtnopasien.Text = "" Or txtkodedokter.Text = "" Then
            MsgBox("Isik Juluk Semeton Ndak Beng Kosong !!!!")
        Else
            Call OpenConn()
            Dim tglsql As String = Format(Now, "yyyy-MM-dd")
            Dim Baris As Integer = 0
            Dim InputData As String = "insert into rekam_medis(no_rekam,	tgl,	keluhan,	diagnosa,	keterangan,	jumlah_obat,	biaya_dokter,	biaya_obat,	total,	kd_dokter,	no_pasien,	kd_user	) " & " values ('" & txtnorekam.Text & "','" & tglsql & "','" & txtkeluhan.Text & "','" & txtdiagnosa.Text & "','" & txtketerangan.Text & "','" & dgtransaksi.Rows(Baris).Cells(3).Value & "','" & txtbiayadokter.Text & "','" & txtbiayaobat.Text & "','" & txttotal.Text & "','" & txtkodedokter.Text & "','" & txtnopasien.Text & "','" & txtkodeuser.Text & "')"
            Cmd = New MySqlCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Simpan !!!")
            dgtransaksi.Columns.Clear()
            Call Tampil()
            Call Normal()
        End If
    End Sub
    Private Sub txtkodeuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkodeuser.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from user where kd_user='" & txtkodeuser.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
                txtkodeuser.Text = ""
                txtkodeuser.Focus()
            Else
                txtnama.Text = Rd.Item("nama")
                txtpass.Text = Rd.Item("password")
                txtkodeobat.Focus()
                txtnamaobat.Enabled = False
                txthargaobat.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call Normal()
        End If
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        Call OpenConn()
        Rd.Read()
        Laporan_Transaksi.ShowDialog()
    End Sub
End Class