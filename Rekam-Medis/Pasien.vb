Imports MySql.Data.MySqlClient
Public Class Pasien
    Sub Tampil()
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from pasien", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pasien")
        dgpasien.DataSource = Ds.Tables("pasien")
        dgpasien.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        btntambah.Enabled = True
        btntambah.Text = "Tambah"
        btnupdate.Enabled = True
        btnupdate.Text = "Update"
        btnhapus.Enabled = True
        btnhapus.Text = "Hapus"
        btnkeluar.Text = "Keluar"

        txtno.Enabled = False
        txtnama.Enabled = False
        cbjenkel.Enabled = False
        cbagama.Enabled = False
        txtalamat.Enabled = False
        dtlahir.Enabled = False
        txttelp.Enabled = False

        txtno.Text = ""
        txtnama.Text = ""
        cbjenkel.Text = ""
        cbagama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
    End Sub
    Sub Hidup()
        txtno.Enabled = True
        txtnama.Enabled = True
        cbjenkel.Enabled = True
        cbagama.Enabled = True
        txtalamat.Enabled = True
        dtlahir.Enabled = True
        txttelp.Enabled = True

        txtno.Text = ""
        txtnama.Text = ""
        cbjenkel.Text = ""
        cbagama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
    End Sub
    Private Sub pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btnupdate.Enabled = False
            btnhapus.Enabled = False
            btnkeluar.Text = "&Batal"
            Call Hidup()
            txtno.Focus()
        Else
            If txtno.Text = "" Or txtnama.Text = "" Or cbjenkel.Text = "" Or cbagama.Text = "" Or txtalamat.Text = "" Or dtlahir.Text = "" Or txttelp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim TambahData As String = "Insert into pasien values ( '" & txtno.Text & "','" & txtnama.Text & "','" & cbjenkel.Text & "','" & cbagama.Text & "','" & txtalamat.Text & "','" & Format(dtlahir.Value, "yyyy-MM-dd") & "','" & txttelp.Text & "')"
                    Cmd = New MySqlCommand(TambahData, Conn)
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
            txtnama.Focus()
        Else
            If txtno.Text = "" Or txtnama.Text = "" Or cbjenkel.Text = "" Or cbagama.Text = "" Or txtalamat.Text = "" Or dtlahir.Text = "" Or txttelp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "update pasien Set nama_pasien= '" & txtnama.Text & "',jenis_kelamin='" & cbjenkel.Text & "',agama= '" & cbagama.Text & "',alamat= '" & txtalamat.Text & "',tgl_lahir= '" & Format(dtlahir.Value, "yyyy-MM-dd") & "'Where no_pasien= '" & txtno.Text & "'"
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
            btnhapus.Text = "Delete"
            btntambah.Enabled = False
            btnupdate.Enabled = False
            btnkeluar.Text = "&BATAL"
            Call Hidup()
            txtno.Focus()
        Else
            If txtno.Text = "" Or txtnama.Text = "" Or cbjenkel.Text = "" Or cbagama.Text = "" Or txtalamat.Text = "" Or dtlahir.Text = "" Or txttelp.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim DeleteData As String = "Delete from pasien Where no_pasien='" & txtno.Text & "'"
                    Cmd = New MySqlCommand(DeleteData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Dihapus", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Dihapus...... Periksa Koneksi!", MsgBoxStyle.MsgBoxRight, "Pesan")
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
    Private Sub dgpasien_Click(sender As Object, e As EventArgs) Handles dgpasien.Click
        If dgpasien.RowCount > 0 Then
            Dim i As Integer
            With dgpasien
                i = .CurrentRow.Index
                txtno.Text = dgpasien.Item(0, i).Value
                txtnama.Text = dgpasien.Item(1, i).Value
                cbjenkel.Text = dgpasien.Item(2, i).Value
                cbagama.Text = dgpasien.Item(3, i).Value
                txtalamat.Text = dgpasien.Item(4, i).Value
                dtlahir.Text = dgpasien.Item(5, i).Value
                txttelp.Text = dgpasien.Item(6, i).Value
                txtnama.Focus()
            End With
        End If
    End Sub
    Private Sub txtno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtno.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("select * from pasien where no_pasien = '" & txtno.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada!")
            Else
                txtnama.Text = Rd.Item("nama_pasien")
                cbjenkel.Text = Rd.Item("jenkel")
                cbagama.Text = Rd.Item("agana")
                txtalamat.Text = Rd.Item("alamat")
                dtlahir.Text = Rd.Item("tgl_lahir")
                txttelp.Text = Rd.Item("telp")
            End If
        End If
    End Sub

    Private Sub txtno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnama.Focus()
        End If
    End Sub
    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            cbjenkel.Focus()
        End If
    End Sub
    Private Sub cbjenkel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbjenkel.KeyPress
        If e.KeyChar = Chr(13) Then
            cbagama.Focus()
        End If
    End Sub
    Private Sub cbagama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbagama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtalamat.Focus()
        End If
    End Sub
    Private Sub txtalamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtalamat.KeyPress
        If e.KeyChar = Chr(13) Then
            dtlahir.Focus()
        End If
    End Sub
    Private Sub dtlahir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtlahir.KeyPress
        If e.KeyChar = Chr(13) Then
            txttelp.Focus()
        End If
    End Sub
    Private Sub txttelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelp.KeyPress
        If e.KeyChar = Chr(13) Then
            btntambah.Focus()
            btnupdate.Focus()
            btnhapus.Focus()
        End If
    End Sub
End Class