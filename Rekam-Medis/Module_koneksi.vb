Imports MySql.Data.MySqlClient
Module Module_koneksi
    Public Conn As MySqlConnection
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Rd As MySqlDataReader
    Public Cmd As MySqlCommand
    Public myDB As String
    Sub OpenConn()
        myDB = ("server=localhost;port=3306;user id=root;password=;database=medical")
        Conn = New MySqlConnection(myDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
