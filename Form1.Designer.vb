<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtkategori = New System.Windows.Forms.TextBox()
        Me.txtpengarang = New System.Windows.Forms.TextBox()
        Me.txtpenerbit = New System.Windows.Forms.TextBox()
        Me.txttahun = New System.Windows.Forms.TextBox()
        Me.txtjlh = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(619, 239)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(146, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BELAJAR CRUD DI VISUAL BASIC.NET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID BUKU :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "JUDUL :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "KATEGORI :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PENGARANG :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PENERBIT :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TAHUN :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "JUMLAH :"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(113, 39)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(107, 23)
        Me.txtid.TabIndex = 9
        '
        'txtjudul
        '
        Me.txtjudul.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjudul.Location = New System.Drawing.Point(113, 65)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(250, 23)
        Me.txtjudul.TabIndex = 10
        '
        'txtkategori
        '
        Me.txtkategori.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkategori.Location = New System.Drawing.Point(113, 94)
        Me.txtkategori.Name = "txtkategori"
        Me.txtkategori.Size = New System.Drawing.Size(250, 23)
        Me.txtkategori.TabIndex = 11
        '
        'txtpengarang
        '
        Me.txtpengarang.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpengarang.Location = New System.Drawing.Point(113, 122)
        Me.txtpengarang.Name = "txtpengarang"
        Me.txtpengarang.Size = New System.Drawing.Size(250, 23)
        Me.txtpengarang.TabIndex = 12
        '
        'txtpenerbit
        '
        Me.txtpenerbit.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpenerbit.Location = New System.Drawing.Point(113, 149)
        Me.txtpenerbit.Name = "txtpenerbit"
        Me.txtpenerbit.Size = New System.Drawing.Size(250, 23)
        Me.txtpenerbit.TabIndex = 13
        '
        'txttahun
        '
        Me.txttahun.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttahun.Location = New System.Drawing.Point(113, 176)
        Me.txttahun.Name = "txttahun"
        Me.txttahun.Size = New System.Drawing.Size(81, 23)
        Me.txttahun.TabIndex = 14
        '
        'txtjlh
        '
        Me.txtjlh.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjlh.Location = New System.Drawing.Point(113, 205)
        Me.txtjlh.Name = "txtjlh"
        Me.txtjlh.Size = New System.Drawing.Size(81, 23)
        Me.txtjlh.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.btnhapus)
        Me.GroupBox1.Controls.Add(Me.btnedit)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.btntambah)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto Mono", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(369, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 180)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Button5
        '
        Me.Button5.AutoEllipsis = True
        Me.Button5.BackColor = System.Drawing.Color.GreenYellow
        Me.Button5.Location = New System.Drawing.Point(24, 123)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(223, 35)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "&KELUAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.GreenYellow
        Me.btnhapus.Location = New System.Drawing.Point(147, 77)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(100, 35)
        Me.btnhapus.TabIndex = 3
        Me.btnhapus.Text = "&HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.GreenYellow
        Me.btnedit.Location = New System.Drawing.Point(24, 77)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 35)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "&EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.GreenYellow
        Me.btnsimpan.Location = New System.Drawing.Point(147, 26)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(100, 35)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "&SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.GreenYellow
        Me.btntambah.Location = New System.Drawing.Point(24, 27)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(100, 35)
        Me.btntambah.TabIndex = 0
        Me.btntambah.Text = "&TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(643, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtjlh)
        Me.Controls.Add(Me.txttahun)
        Me.Controls.Add(Me.txtpenerbit)
        Me.Controls.Add(Me.txtpengarang)
        Me.Controls.Add(Me.txtkategori)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtjudul As System.Windows.Forms.TextBox
    Friend WithEvents txtkategori As System.Windows.Forms.TextBox
    Friend WithEvents txtpengarang As System.Windows.Forms.TextBox
    Friend WithEvents txtpenerbit As System.Windows.Forms.TextBox
    Friend WithEvents txttahun As System.Windows.Forms.TextBox
    Friend WithEvents txtjlh As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
