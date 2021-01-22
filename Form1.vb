Imports System.Data.Odbc
Public Class Form1
    Sub datakosong()
        Me.txtid.Focus()
        Me.txtid.Text = ""
        Me.txtjudul.Text = ""
        Me.txtkategori.Text = ""
        Me.txtpenerbit.Text = ""
        Me.txtpengarang.Text = ""
        Me.txttahun.Text = ""
        Me.txtjlh.Text = ""
    End Sub
    Sub buatdata()
        Me.txtjudul.Clear()
        Me.txtkategori.Clear()
        Me.txtpenerbit.Clear()
        Me.txtpengarang.Clear()
        Me.txttahun.Clear()
        Me.txtjlh.Clear()
        Me.txtid.Clear()
        Me.txtid.Focus()
    End Sub
    Sub tampilgrid()
        Call koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_buku", konek)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_buku")
        DataGridView1.DataSource = Ds.Tables("tbl_buku")
        DataGridView1.ReadOnly = True
    End Sub
    'TOMBOL KELUAR'
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    'TOMBOL TAMBAH'
    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call buatdata()
    End Sub
    'FORM CRUD/UTAMA'
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub
    'TOMBOL HAPUS'
    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtid.Text = "" Then
            MsgBox("Silahkan Pilih Data yang Mau di Hapus", vbCritical, "Peringatan")
        Else
            If MessageBox.Show("Anda Yakin Akan Menghapus Data ?", "Peringatan !!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from tbl_buku where idbuku= '" & txtid.Text & "'"
                cmd = New OdbcCommand(hapus, konek)
                cmd.ExecuteNonQuery()
                Call tampilgrid()
                Call datakosong()
            End If
        End If
    End Sub
    'TOMBOL EDIT'
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Call koneksi()
        Dim edit As String = "Update tbl_buku set judul='" & txtjudul.Text & "',kategori='" & txtkategori.Text & "',pengarang='" & txtpengarang.Text & "',penerbit='" & txtpenerbit.Text & "', tahun='" & txttahun.Text & "', jml='" & txtjlh.Text & "' where idbuku='" & txtid.Text & "'"
        cmd = New OdbcCommand(edit, konek)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di Edit", vbInformation, "Pesan")
        Call tampilgrid()
        Call datakosong()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtid.Text = "" Then
            MsgBox("Silahkan Isi Id Buku", vbExclamation, "Pesan")
        ElseIf txtjudul.Text = "" Then
            MsgBox("Silahkan Isi Judul Buku", vbExclamation, "Pesan")
        ElseIf txtkategori.Text = "" Then
            MsgBox("Silahkan Isi Kategori Buku", vbExclamation, "Pesan")
        ElseIf txtpengarang.Text = "" Then
            MsgBox("Silahkan Isi Nama Pengarang", vbExclamation, "Pesan")
        ElseIf txtpenerbit.Text = "" Then
            MsgBox("Silahkan Isi Textbox Penerbit", vbExclamation, "Pesan")
        ElseIf txttahun.Text = "" Then
            MsgBox("Silahkan Isi Tahun Buku", vbExclamation, "Pesan")
        ElseIf txtjlh.Text = "" Then
            MsgBox("Silahkan Isi Jumlah Buku", vbExclamation, "Pesan")
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbl_buku values ('" & txtid.Text & "','" & txtjudul.Text & "','" & txtkategori.Text & "','" & txtpengarang.Text & "','" & txtpenerbit.Text & "','" & txttahun.Text & "','" & txtjlh.Text & "')"
            cmd = New OdbcCommand(simpan, konek)
            cmd.ExecuteNonQuery()
            MsgBox("Data Ditambahkan", vbInformation, "Berhasil")
            Call tampilgrid()
            Call datakosong()
            txtid.Focus()
        End If
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        txtid.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        cmd = New OdbcCommand("Select * from tbl_buku where idbuku='" & txtid.Text & "'", konek)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            txtid.Text = Dr.Item("idbuku")
            txtjudul.Text = Dr.Item("judul")
            txtkategori.Text = Dr.Item("kategori")
            txtpenerbit.Text = Dr.Item("penerbit")
            txtpengarang.Text = Dr.Item("pengarang")
            txttahun.Text = Dr.Item("tahun")
            txtjlh.Text = Dr.Item("jml")
        End If
    End Sub
End Class