Imports MySql.Data.MySqlClient
Public Class Dokter
    Sub Tampil()
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from dokter", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "dokter")
        dgdokter.DataSource = Ds.Tables("dokter")

        txtnama.Text = ""
        txtsip.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""

        txtkode.Enabled = False
        txtnama.Enabled = False
        txtsip.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False

        btntambah.Enabled = True
        btntambah.Text = "Tambah"
        btnupdate.Enabled = True
        btnupdate.Text = "Update"
        btnhapus.Enabled = True
        btnhapus.Text = "Hapus"
        btnkeluar.Text = "Keluar"
    End Sub
    Sub Hidup()
        txtkode.Enabled = True
        txtnama.Enabled = True
        txtsip.Enabled = True
        txtalamat.Enabled = True
        txttelp.Enabled = True
    End Sub
    Private Sub dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btnupdate.Enabled = False
            btnhapus.Enabled = False
            btnkeluar.Text = "&Batal"
            Call Hidup()
            txtkode.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtsip.Text = "" Or txtalamat.Text = "" Or txttelp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Insert into dokter values ( '" & txtkode.Text & "','" & txtnama.Text & "','" & txtsip.Text & "','" & txtalamat.Text & "','" & txttelp.Text & "')"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil diinput", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "Update" Then
            btnupdate.Text = "Ubah"
            btntambah.Enabled = False
            btnhapus.Enabled = False
            btnkeluar.Text = "&Batal"
            Call Hidup()
            txtkode.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtsip.Text = "" Or txtalamat.Text = "" Or txttelp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "update dokter Set nama_dokter= '" & txtnama.Text & "',sip='" & txtsip.Text & "',alamat= '" & txtalamat.Text & "',telp= '" & txttelp.Text & "' Where kd_dokter= '" & txtkode.Text & "'"
                    Cmd = New MySqlCommand(UpdateData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil diupdate", MsgBoxStyle.MsgBoxRight, "Pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If btnhapus.Text = "Hapus" Then
            btnhapus.Text = "DELET"
            btntambah.Enabled = False
            btnupdate.Enabled = False
            btnkeluar.Text = "&Batal"
            Call Hidup()
            txtnama.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtsip.Text = "" Or txtalamat.Text = "" Or txttelp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "delete from dokter Where kd_dokter='" & txtkode.Text & "'"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Dihapus", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call Tampil()
        End If
    End Sub
    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("select * from dokter where kd_dokter = '" & txtkode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada!")
            Else
                txtnama.Text = Rd.Item("nama_obat")
                txtnama.Text = Rd.Item("nama_dokter")
                txtsip.Text = Rd.Item("sip")
                txtalamat.Text = Rd.Item("alamat")
                txttelp.Text = Rd.Item("telp")
            End If
        End If
    End Sub
    Private Sub dgdokter_Click(sender As Object, e As EventArgs) Handles dgdokter.Click
        If dgdokter.RowCount > 0 Then
            Dim i As Integer
            With dgdokter
                i = .CurrentRow.Index
                txtkode.Text = dgdokter.Item(0, i).Value
                txtnama.Text = dgdokter.Item(1, i).Value
                txtsip.Text = dgdokter.Item(2, i).Value
                txtalamat.Text = dgdokter.Item(3, i).Value
                txttelp.Text = dgdokter.Item(4, i).Value
                txtnama.Focus()
            End With
        End If
    End Sub
End Class