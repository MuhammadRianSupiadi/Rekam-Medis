Public Class Menu_Utama
    Private Sub PasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasienToolStripMenuItem.Click
        Pasien.ShowDialog()
    End Sub

    Private Sub DokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokterToolStripMenuItem.Click
        Dokter.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        Obat.ShowDialog()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        User.ShowDialog()
    End Sub

    Private Sub RekamMedisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamMedisToolStripMenuItem.Click
        Transaksi.ShowDialog()
    End Sub
End Class