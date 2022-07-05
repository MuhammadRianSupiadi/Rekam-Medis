Imports MySql.Data.MySqlClient
Public Class User
    Sub Tampil()
        Call OpenConn()
        Call KodeOtomatis()
        Da = New MySqlDataAdapter("select * from user", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "user")
        dguser.DataSource = Ds.Tables("user")

        txtnama.Text = ""
        txtpass.Text = ""


        txtkode.Enabled = False
        txtnama.Enabled = False
        txtpass.Enabled = False

        btntambah.Enabled = True
        btntambah.Text = "Tambah"
        btnupdate.Enabled = True
        btnupdate.Text = "Update"
        btnhapus.Enabled = True
        btnhapus.Text = "Hapus"
        btnkeluar.Text = "Keluar"
    End Sub
    Sub Hidup()
        txtnama.Enabled = True
        txtpass.Enabled = True
    End Sub
    Sub KodeOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select * from user where kd_user in (select max(kd_user) from user) ", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = 0 Then
            txtkode.Text = "KDU001"
            Rd.Close()
        End If
        If Not Rd.HasRows Then
            txtkode.Text = "KDU" + "001"
            Rd.Close()
        Else
            txtkode.Text = Microsoft.VisualBasic.Mid(Rd.Item("kd_user").ToString, 4, 3) + 1
            If Len(txtkode.Text) = 1 Then
                txtkode.Text = "KDU00" & txtkode.Text & ""
            ElseIf Len(txtkode.Text) = 2 Then
                txtkode.Text = "KDU0" & txtkode.Text & ""
            ElseIf Len(txtkode.Text) = 3 Then
                txtkode.Text = "KDU" & txtkode.Text & ""
            End If
            Rd.Close()
        End If
    End Sub
    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If btntambah.Text = "Tambah" Then
            btntambah.Text = "Simpan"
            btnupdate.Enabled = False
            btnhapus.Enabled = False
            btnkeluar.Text = "&Batal"
            Call Hidup()
            txtnama.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtpass.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Insert into user values ( '" & txtkode.Text & "','" & txtnama.Text & "','" & txtpass.Text & "')"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil diinput", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Anda!", MsgBoxStyle.MsgBoxRight, "Pesan")
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
            If txtkode.Text = "" Or txtnama.Text = "" Or txtpass.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "update user Set nama= '" & txtnama.Text & "',password='" & txtpass.Text & "'  Where kd_user= '" & txtkode.Text & "'"
                    Cmd = New MySqlCommand(UpdateData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil diupdate", MsgBoxStyle.MsgBoxRight, "Pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Diupdate...... Periksa Koneksi Anda!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If btnhapus.Text = "Hapus" Then
            btnhapus.Text = "Delete"
            btntambah.Enabled = False
            btnupdate.Enabled = False
            btnkeluar.Text = "&Batal"
            Call Hidup()
            txtnama.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtpass.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Delete from user Where kd_user='" & txtkode.Text & "'"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil dihapus", MsgBoxStyle.MsgBoxRight, "pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal DiHapus...... Periksa Data Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
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
            Cmd = New MySqlCommand("select * from user where kd_user = '" & txtkode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada!")
            Else
                txtnama.Text = Rd.Item("nama_user")
                txtpass.Text = Rd.Item("password")
            End If
        End If
    End Sub

    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpass.Focus()
        End If
    End Sub
    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(13) Then
            btntambah.Focus()
            btnupdate.Focus()
            btnhapus.Focus()
        End If
    End Sub

    Private Sub dguser_Click(sender As Object, e As EventArgs) Handles dguser.Click
        If dguser.RowCount > 0 Then
            Dim i As Integer
            With dguser
                i = .CurrentRow.Index
                txtkode.Text = .Item(0, i).Value
                txtnama.Text = .Item(1, i).Value
                txtpass.Text = .Item(2, i).Value
                txtnama.Focus()
            End With
        End If
    End Sub
End Class