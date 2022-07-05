<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Obat))
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgobat = New System.Windows.Forms.DataGridView()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        CType(Me.dgobat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(174, 156)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(172, 20)
        Me.txtharga.TabIndex = 110
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(174, 81)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(172, 20)
        Me.txtnama.TabIndex = 109
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(174, 120)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(172, 20)
        Me.txtstok.TabIndex = 108
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(174, 39)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(172, 20)
        Me.txtkode.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Nama Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Kode Obat"
        '
        'dgobat
        '
        Me.dgobat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgobat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgobat.Location = New System.Drawing.Point(44, 260)
        Me.dgobat.Name = "dgobat"
        Me.dgobat.Size = New System.Drawing.Size(586, 164)
        Me.dgobat.TabIndex = 102
        '
        'btnkeluar
        '
        Me.btnkeluar.BackgroundImage = CType(resources.GetObject("btnkeluar.BackgroundImage"), System.Drawing.Image)
        Me.btnkeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(537, 157)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(83, 76)
        Me.btnkeluar.TabIndex = 101
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.BackgroundImage = CType(resources.GetObject("btnupdate.BackgroundImage"), System.Drawing.Image)
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(537, 50)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(83, 75)
        Me.btnupdate.TabIndex = 100
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(435, 156)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 76)
        Me.btnDelete.TabIndex = 99
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btninput
        '
        Me.btninput.BackgroundImage = CType(resources.GetObject("btninput.BackgroundImage"), System.Drawing.Image)
        Me.btninput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btninput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btninput.Location = New System.Drawing.Point(435, 50)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(83, 75)
        Me.btninput.TabIndex = 98
        Me.btninput.Text = "INPUT"
        Me.btninput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btninput.UseVisualStyleBackColor = True
        '
        'Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(674, 450)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgobat)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btninput)
        Me.Name = "Obat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obat"
        CType(Me.dgobat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtstok As TextBox
    Friend WithEvents txtkode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgobat As DataGridView
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btninput As Button
End Class
