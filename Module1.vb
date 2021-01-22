Imports System.Data.Odbc
Module Module1
    Public konek As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Dr As OdbcDataReader
    Public Ds As DataSet
    Public cmd As OdbcCommand
    Sub koneksi()
        Try
            konek = New OdbcConnection("DSN=db_buku;MultiActiveResultSets=true")
            If konek.State = ConnectionState.Closed Then
                konek.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Database gagal", vbCritical, "Gagal")
        End Try
    End Sub
End Module
