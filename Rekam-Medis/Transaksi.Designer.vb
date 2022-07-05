<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.txtkeluhan = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtbiayaobat = New System.Windows.Forms.TextBox()
        Me.txtbiayadokter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttelpdokter = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.dgrekam = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtalamatpasien = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnopasien = New System.Windows.Forms.TextBox()
        Me.txtnamapasien = New System.Windows.Forms.TextBox()
        Me.txtkodedokter = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.txtkodeuser = New System.Windows.Forms.TextBox()
        Me.btntotal = New System.Windows.Forms.Button()
        Me.txtjumlahobat = New System.Windows.Forms.TextBox()
        Me.txthargaobat = New System.Windows.Forms.TextBox()
        Me.txtdiagnosa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtkodeobat = New System.Windows.Forms.TextBox()
        Me.txtnorekam = New System.Windows.Forms.TextBox()
        Me.dgtransaksi = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnamaobat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgrekam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtkeluhan
        '
        Me.txtkeluhan.Location = New System.Drawing.Point(152, 213)
        Me.txtkeluhan.Multiline = True
        Me.txtkeluhan.Name = "txtkeluhan"
        Me.txtkeluhan.Size = New System.Drawing.Size(156, 58)
        Me.txtkeluhan.TabIndex = 152
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtkembali)
        Me.GroupBox3.Controls.Add(Me.txtbayar)
        Me.GroupBox3.Controls.Add(Me.txttotal)
        Me.GroupBox3.Controls.Add(Me.txtbiayaobat)
        Me.GroupBox3.Controls.Add(Me.txtbiayadokter)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(538, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 212)
        Me.GroupBox3.TabIndex = 159
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Biaya-Biaya"
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(93, 168)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(125, 20)
        Me.txtkembali.TabIndex = 29
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(93, 130)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(125, 20)
        Me.txtbayar.TabIndex = 28
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(93, 98)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(125, 20)
        Me.txttotal.TabIndex = 27
        '
        'txtbiayaobat
        '
        Me.txtbiayaobat.Location = New System.Drawing.Point(93, 59)
        Me.txtbiayaobat.Name = "txtbiayaobat"
        Me.txtbiayaobat.Size = New System.Drawing.Size(125, 20)
        Me.txtbiayaobat.TabIndex = 26
        '
        'txtbiayadokter
        '
        Me.txtbiayadokter.Location = New System.Drawing.Point(93, 21)
        Me.txtbiayadokter.Name = "txtbiayadokter"
        Me.txtbiayadokter.Size = New System.Drawing.Size(125, 20)
        Me.txtbiayadokter.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Biaya Dokter"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Biaya Obat"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 101)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Total Biaya"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 133)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Bayar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Kembali"
        '
        'dttanggal
        '
        Me.dttanggal.Location = New System.Drawing.Point(423, 10)
        Me.dttanggal.Name = "dttanggal"
        Me.dttanggal.Size = New System.Drawing.Size(200, 20)
        Me.dttanggal.TabIndex = 158
        Me.dttanggal.Value = New Date(2022, 6, 29, 10, 50, 6, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Nama Dokter"
        '
        'txttelpdokter
        '
        Me.txttelpdokter.Location = New System.Drawing.Point(111, 116)
        Me.txttelpdokter.Name = "txttelpdokter"
        Me.txttelpdokter.Size = New System.Drawing.Size(125, 20)
        Me.txttelpdokter.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Nomor Telepon"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(134, 309)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 13)
        Me.Label22.TabIndex = 173
        Me.Label22.Text = "Nama"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(232, 309)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 174
        Me.Label23.Text = "Password"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(31, 309)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 13)
        Me.Label21.TabIndex = 172
        Me.Label21.Text = "Kode User"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(216, 325)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(84, 20)
        Me.txtpass.TabIndex = 171
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(111, 325)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(84, 20)
        Me.txtnama.TabIndex = 170
        '
        'dgrekam
        '
        Me.dgrekam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrekam.Location = New System.Drawing.Point(29, 483)
        Me.dgrekam.Name = "dgrekam"
        Me.dgrekam.Size = New System.Drawing.Size(762, 118)
        Me.dgrekam.TabIndex = 169
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtalamatpasien)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnopasien)
        Me.GroupBox1.Controls.Add(Me.txtnamapasien)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 156)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pasien"
        '
        'txtalamatpasien
        '
        Me.txtalamatpasien.Location = New System.Drawing.Point(115, 104)
        Me.txtalamatpasien.Multiline = True
        Me.txtalamatpasien.Name = "txtalamatpasien"
        Me.txtalamatpasien.Size = New System.Drawing.Size(156, 37)
        Me.txtalamatpasien.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nomor Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Pasien"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'txtnopasien
        '
        Me.txtnopasien.Location = New System.Drawing.Point(115, 25)
        Me.txtnopasien.Name = "txtnopasien"
        Me.txtnopasien.Size = New System.Drawing.Size(125, 20)
        Me.txtnopasien.TabIndex = 22
        '
        'txtnamapasien
        '
        Me.txtnamapasien.Location = New System.Drawing.Point(115, 65)
        Me.txtnamapasien.Name = "txtnamapasien"
        Me.txtnamapasien.Size = New System.Drawing.Size(156, 20)
        Me.txtnamapasien.TabIndex = 23
        '
        'txtkodedokter
        '
        Me.txtkodedokter.Location = New System.Drawing.Point(111, 29)
        Me.txtkodedokter.Name = "txtkodedokter"
        Me.txtkodedokter.Size = New System.Drawing.Size(125, 20)
        Me.txtkodedokter.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnamadokter)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txttelpdokter)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtkodedokter)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(366, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 162)
        Me.GroupBox2.TabIndex = 157
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Dokter"
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Location = New System.Drawing.Point(111, 72)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(168, 20)
        Me.txtnamadokter.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Kode Dokter"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(485, 209)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(125, 20)
        Me.txtketerangan.TabIndex = 155
        '
        'txtkodeuser
        '
        Me.txtkodeuser.Location = New System.Drawing.Point(29, 325)
        Me.txtkodeuser.Name = "txtkodeuser"
        Me.txtkodeuser.Size = New System.Drawing.Size(65, 20)
        Me.txtkodeuser.TabIndex = 167
        '
        'btntotal
        '
        Me.btntotal.BackgroundImage = CType(resources.GetObject("btntotal.BackgroundImage"), System.Drawing.Image)
        Me.btntotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntotal.Location = New System.Drawing.Point(423, 309)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(57, 51)
        Me.btntotal.TabIndex = 165
        Me.btntotal.Text = "Total"
        Me.btntotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntotal.UseVisualStyleBackColor = True
        '
        'txtjumlahobat
        '
        Me.txtjumlahobat.Location = New System.Drawing.Point(318, 366)
        Me.txtjumlahobat.Name = "txtjumlahobat"
        Me.txtjumlahobat.Size = New System.Drawing.Size(63, 20)
        Me.txtjumlahobat.TabIndex = 161
        '
        'txthargaobat
        '
        Me.txthargaobat.Location = New System.Drawing.Point(216, 366)
        Me.txthargaobat.Name = "txthargaobat"
        Me.txthargaobat.Size = New System.Drawing.Size(84, 20)
        Me.txthargaobat.TabIndex = 160
        '
        'txtdiagnosa
        '
        Me.txtdiagnosa.Location = New System.Drawing.Point(152, 277)
        Me.txtdiagnosa.Name = "txtdiagnosa"
        Me.txtdiagnosa.Size = New System.Drawing.Size(156, 20)
        Me.txtdiagnosa.TabIndex = 153
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(344, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "Tanggal"
        '
        'txtkodeobat
        '
        Me.txtkodeobat.Location = New System.Drawing.Point(29, 366)
        Me.txtkodeobat.Name = "txtkodeobat"
        Me.txtkodeobat.Size = New System.Drawing.Size(65, 20)
        Me.txtkodeobat.TabIndex = 151
        '
        'txtnorekam
        '
        Me.txtnorekam.Location = New System.Drawing.Point(131, 10)
        Me.txtnorekam.Name = "txtnorekam"
        Me.txtnorekam.Size = New System.Drawing.Size(125, 20)
        Me.txtnorekam.TabIndex = 150
        '
        'dgtransaksi
        '
        Me.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtransaksi.Location = New System.Drawing.Point(29, 392)
        Me.dgtransaksi.Name = "dgtransaksi"
        Me.dgtransaksi.Size = New System.Drawing.Size(490, 85)
        Me.dgtransaksi.TabIndex = 166
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(381, 216)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 149
        Me.Label17.Text = "Keterangan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(315, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Jumlah Obat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(222, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "Harga Obat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(120, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Nama Obat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Kode Obat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Diagnosa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Keluhan"
        '
        'txtnamaobat
        '
        Me.txtnamaobat.Location = New System.Drawing.Point(111, 366)
        Me.txtnamaobat.Name = "txtnamaobat"
        Me.txtnamaobat.Size = New System.Drawing.Size(84, 20)
        Me.txtnamaobat.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "No Rekam Medis"
        '
        'btnkeluar
        '
        Me.btnkeluar.BackgroundImage = CType(resources.GetObject("btnkeluar.BackgroundImage"), System.Drawing.Image)
        Me.btnkeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(716, 193)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 56)
        Me.btnkeluar.TabIndex = 178
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImage = CType(resources.GetObject("btnsimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(716, 72)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 56)
        Me.btnsimpan.TabIndex = 177
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.BackgroundImage = CType(resources.GetObject("btntambah.BackgroundImage"), System.Drawing.Image)
        Me.btntambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.Black
        Me.btntambah.Location = New System.Drawing.Point(716, 13)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 56)
        Me.btntambah.TabIndex = 175
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.BackColor = System.Drawing.Color.MintCream
        Me.btncetak.BackgroundImage = CType(resources.GetObject("btncetak.BackgroundImage"), System.Drawing.Image)
        Me.btncetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncetak.ForeColor = System.Drawing.Color.Black
        Me.btncetak.Location = New System.Drawing.Point(716, 134)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 56)
        Me.btncetak.TabIndex = 179
        Me.btncetak.Text = "Cetak"
        Me.btncetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncetak.UseVisualStyleBackColor = False
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(820, 621)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtkeluhan)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dttanggal)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.dgrekam)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.txtkodeuser)
        Me.Controls.Add(Me.btntotal)
        Me.Controls.Add(Me.txtjumlahobat)
        Me.Controls.Add(Me.txthargaobat)
        Me.Controls.Add(Me.txtdiagnosa)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtkodeobat)
        Me.Controls.Add(Me.txtnorekam)
        Me.Controls.Add(Me.dgtransaksi)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnamaobat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgrekam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtkeluhan As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtbiayaobat As TextBox
    Friend WithEvents txtbiayadokter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents dttanggal As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txttelpdokter As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents dgrekam As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtalamatpasien As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnopasien As TextBox
    Friend WithEvents txtnamapasien As TextBox
    Friend WithEvents txtkodedokter As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtnamadokter As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtketerangan As TextBox
    Friend WithEvents txtkodeuser As TextBox
    Friend WithEvents btntotal As Button
    Friend WithEvents txtjumlahobat As TextBox
    Friend WithEvents txthargaobat As TextBox
    Friend WithEvents txtdiagnosa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtkodeobat As TextBox
    Friend WithEvents txtnorekam As TextBox
    Friend WithEvents dgtransaksi As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnamaobat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents btncetak As Button
End Class
