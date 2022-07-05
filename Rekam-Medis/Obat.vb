Imports MySql.Data.MySqlClient
Public Class Obat
    Sub Tampil()
        Call OpenConn()
        Call KodeOtomatis()
        Da = New MySqlDataAdapter("select * from obat", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "obat")
        dgobat.DataSource = Ds.Tables("obat")

        txtnama.Text = ""
        txtstok.Text = ""
        txtharga.Text = ""

        txtkode.Enabled = False
        txtnama.Enabled = False
        txtstok.Enabled = False
        txtharga.Enabled = False

        btninput.Text = "INPUT"
        btnupdate.Enabled = True
        btnupdate.Text = "UPDATE"
        btnDelete.Enabled = True
        btnDelete.Text = "DELETE"
        btnkeluar.Text = "KELUAR"
    End Sub
    Sub Hidup()
        txtnama.Enabled = True
        txtstok.Enabled = True
        txtharga.Enabled = True
    End Sub
    Sub KodeOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select * from obat where kd_obat in (select max(kd_obat) from obat) ", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = 0 Then
            txtkode.Text = "OBT001"
            Rd.Close()
        End If
        If Not Rd.HasRows Then
            txtkode.Text = "OBT" + "001"
            Rd.Close()
        Else
            txtkode.Text = Microsoft.VisualBasic.Mid(Rd.Item("kd_obat").ToString, 4, 3) + 1
            If Len(txtkode.Text) = 1 Then
                txtkode.Text = "OBT00" & txtkode.Text & ""
            ElseIf Len(txtkode.Text) = 2 Then
                txtkode.Text = "OBT0" & txtkode.Text & ""
            ElseIf Len(txtkode.Text) = 3 Then
                txtkode.Text = "OBT" & txtkode.Text & ""
            End If
            Rd.Close()
        End If
    End Sub
    Private Sub FormCoba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()

    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If btninput.Text = "INPUT" Then
            btninput.Text = "SIMPAN"
            btnupdate.Enabled = False
            btnDelete.Enabled = False
            btnkeluar.Text = "&BATAL"
            Call Hidup()
            txtnama.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtstok.Text = "" Or txtharga.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "Insert into obat values ( '" & txtkode.Text & "','" & txtnama.Text & "','" & txtstok.Text & "','" & txtharga.Text & "')"
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
        If btnupdate.Text = "UPDATE" Then
            btnupdate.Text = "UBAH"
            btninput.Enabled = False
            btnDelete.Enabled = False
            btnkeluar.Text = "&BATAL"
            Call Hidup()
            txtnama.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtstok.Text = "" Or txtharga.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "update obat Set nama_obat= '" & txtnama.Text & "',stok='" & txtstok.Text & "', harga= '" & txtharga.Text & "'Where kd_obat= '" & txtkode.Text & "'"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil diupdate", MsgBoxStyle.MsgBoxRight, "Pesan")
                    Call Tampil()
                Catch ex As Exception
                    MsgBox("Data Gagal Disimpan...... Periksa Koneksi Ada!", MsgBoxStyle.MsgBoxRight, "Pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "DELETE" Then
            btnDelete.Text = "HAPUS"
            btninput.Enabled = False
            btnupdate.Enabled = False
            btnkeluar.Text = "&BATAL"
            Call Hidup()
            txtnama.Focus()
        Else
            If txtkode.Text = "" Or txtnama.Text = "" Or txtstok.Text = "" Or txtharga.Text = "" Then
                MsgBox("Pastikan Semua Sudah Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "delete from obat Where kd_obat='" & txtkode.Text & "'"
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
        If btnkeluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call Tampil()
        End If
    End Sub
    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("select * from obat where kd_obat = '" & txtkode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data Tidak Ada!")
            Else
                txtnama.Text = Rd.Item("nama_obat")
                txtstok.Text = Rd.Item("stok")
                txtharga.Text = Rd.Item("harga")
            End If
        End If
    End Sub

    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtstok.Focus()
        End If
    End Sub

    Private Sub txtstok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstok.KeyPress
        If e.KeyChar = Chr(13) Then
            txtharga.Focus()
        End If
    End Sub

    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If e.KeyChar = Chr(13) Then
            btninput.Focus()
            btnupdate.Focus()
            btnDelete.Focus()
        End If
    End Sub
    Private Sub dgobat_Click(sender As Object, e As EventArgs) Handles dgobat.Click
        If dgobat.RowCount > 0 Then
            Dim i As Integer
            With dgobat
                i = .CurrentRow.Index
                txtkode.Text = .Item(0, i).Value
                txtnama.Text = .Item(1, i).Value
                txtstok.Text = .Item(2, i).Value
                txtharga.Text = .Item(3, i).Value
                txtnama.Focus()
            End With
        End If
    End Sub
End Class