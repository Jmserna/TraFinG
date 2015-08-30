<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LanceActivoTrackings = New System.Windows.Forms.TextBox()
        Me.DataGridViewTrackings = New System.Windows.Forms.DataGridView()
        Me.BotonImportarGPS = New System.Windows.Forms.Button()
        Me.BotonSalvarGPS = New System.Windows.Forms.Button()
        Me.BotonBorrarGPS = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BotonExportaGPSaExCEL = New System.Windows.Forms.Button()
        Me.TextBoxNumeroREg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewTrackings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Trackings - Posiciones GPS del Lance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Lance Activo"
        '
        'LanceActivoTrackings
        '
        Me.LanceActivoTrackings.Location = New System.Drawing.Point(38, 80)
        Me.LanceActivoTrackings.Name = "LanceActivoTrackings"
        Me.LanceActivoTrackings.ReadOnly = True
        Me.LanceActivoTrackings.Size = New System.Drawing.Size(100, 22)
        Me.LanceActivoTrackings.TabIndex = 12
        '
        'DataGridViewTrackings
        '
        Me.DataGridViewTrackings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTrackings.Location = New System.Drawing.Point(38, 139)
        Me.DataGridViewTrackings.Name = "DataGridViewTrackings"
        Me.DataGridViewTrackings.RowTemplate.Height = 24
        Me.DataGridViewTrackings.Size = New System.Drawing.Size(1186, 603)
        Me.DataGridViewTrackings.TabIndex = 14
        '
        'BotonImportarGPS
        '
        Me.BotonImportarGPS.Location = New System.Drawing.Point(271, 770)
        Me.BotonImportarGPS.Name = "BotonImportarGPS"
        Me.BotonImportarGPS.Size = New System.Drawing.Size(137, 43)
        Me.BotonImportarGPS.TabIndex = 15
        Me.BotonImportarGPS.Text = "Importar Fichero GPS"
        Me.BotonImportarGPS.UseVisualStyleBackColor = True
        '
        'BotonSalvarGPS
        '
        Me.BotonSalvarGPS.Location = New System.Drawing.Point(493, 770)
        Me.BotonSalvarGPS.Name = "BotonSalvarGPS"
        Me.BotonSalvarGPS.Size = New System.Drawing.Size(137, 43)
        Me.BotonSalvarGPS.TabIndex = 16
        Me.BotonSalvarGPS.Text = "Guardar Datos GPS"
        Me.BotonSalvarGPS.UseVisualStyleBackColor = True
        '
        'BotonBorrarGPS
        '
        Me.BotonBorrarGPS.ForeColor = System.Drawing.Color.Red
        Me.BotonBorrarGPS.Location = New System.Drawing.Point(715, 770)
        Me.BotonBorrarGPS.Name = "BotonBorrarGPS"
        Me.BotonBorrarGPS.Size = New System.Drawing.Size(137, 43)
        Me.BotonBorrarGPS.TabIndex = 17
        Me.BotonBorrarGPS.Text = "Borrar Datos GPS"
        Me.BotonBorrarGPS.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BotonExportaGPSaExCEL
        '
        Me.BotonExportaGPSaExCEL.BackgroundImage = CType(resources.GetObject("BotonExportaGPSaExCEL.BackgroundImage"), System.Drawing.Image)
        Me.BotonExportaGPSaExCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BotonExportaGPSaExCEL.Location = New System.Drawing.Point(937, 770)
        Me.BotonExportaGPSaExCEL.Name = "BotonExportaGPSaExCEL"
        Me.BotonExportaGPSaExCEL.Size = New System.Drawing.Size(49, 43)
        Me.BotonExportaGPSaExCEL.TabIndex = 18
        Me.BotonExportaGPSaExCEL.UseVisualStyleBackColor = True
        '
        'TextBoxNumeroREg
        '
        Me.TextBoxNumeroREg.Location = New System.Drawing.Point(1161, 111)
        Me.TextBoxNumeroREg.Name = "TextBoxNumeroREg"
        Me.TextBoxNumeroREg.ReadOnly = True
        Me.TextBoxNumeroREg.Size = New System.Drawing.Size(63, 22)
        Me.TextBoxNumeroREg.TabIndex = 19
        Me.TextBoxNumeroREg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1095, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nº Filas:"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNumeroREg)
        Me.Controls.Add(Me.BotonExportaGPSaExCEL)
        Me.Controls.Add(Me.BotonBorrarGPS)
        Me.Controls.Add(Me.BotonSalvarGPS)
        Me.Controls.Add(Me.BotonImportarGPS)
        Me.Controls.Add(Me.DataGridViewTrackings)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LanceActivoTrackings)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trackings GPS"
        CType(Me.DataGridViewTrackings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LanceActivoTrackings As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTrackings As System.Windows.Forms.DataGridView
    Friend WithEvents BotonImportarGPS As System.Windows.Forms.Button
    Friend WithEvents BotonSalvarGPS As System.Windows.Forms.Button
    Friend WithEvents BotonBorrarGPS As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BotonExportaGPSaExCEL As System.Windows.Forms.Button
    Friend WithEvents TextBoxNumeroREg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
