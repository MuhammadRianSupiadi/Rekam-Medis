<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Transaksi
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RekammedisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Rekam_Medis.DataSet1()
        Me.rpLporan_transaksi = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RekammedisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RekammedisBindingSource
        '
        Me.RekammedisBindingSource.DataMember = "rekam_medis"
        Me.RekammedisBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpLporan_transaksi
        '
        Me.rpLporan_transaksi.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "rekam_medis"
        ReportDataSource1.Value = Me.RekammedisBindingSource
        ReportDataSource2.Name = "Pasien"
        ReportDataSource2.Value = Me.PasienBindingSource
        Me.rpLporan_transaksi.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpLporan_transaksi.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rpLporan_transaksi.LocalReport.ReportEmbeddedResource = "Rekam_Medis.rpRekam_Medis.rdlc"
        Me.rpLporan_transaksi.Location = New System.Drawing.Point(0, 0)
        Me.rpLporan_transaksi.Name = "rpLporan_transaksi"
        Me.rpLporan_transaksi.ServerReport.BearerToken = Nothing
        Me.rpLporan_transaksi.Size = New System.Drawing.Size(670, 450)
        Me.rpLporan_transaksi.TabIndex = 0
        '
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "pasien"
        Me.PasienBindingSource.DataSource = Me.DataSet1
        '
        'Laporan_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 450)
        Me.Controls.Add(Me.rpLporan_transaksi)
        Me.Name = "Laporan_Transaksi"
        Me.Text = "Laporan_Transaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RekammedisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpLporan_transaksi As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents RekammedisBindingSource As BindingSource
    Friend WithEvents PasienBindingSource As BindingSource
End Class
