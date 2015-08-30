<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BotonImportaFicheroCTD = New System.Windows.Forms.Button()
        Me.BotonSalvaCTDenBD = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LanceActivoCTDs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BotonBorraDatosCTD = New System.Windows.Forms.Button()
        Me.BotonExportaCTDaEXCEL = New System.Windows.Forms.Button()
        Me.TextBoxNumeroFilasCTD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CTDs - Parámetros en la columna de agua"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(120, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1031, 701)
        Me.DataGridView1.TabIndex = 7
        '
        'BotonImportaFicheroCTD
        '
        Me.BotonImportaFicheroCTD.Location = New System.Drawing.Point(315, 816)
        Me.BotonImportaFicheroCTD.Name = "BotonImportaFicheroCTD"
        Me.BotonImportaFicheroCTD.Size = New System.Drawing.Size(141, 49)
        Me.BotonImportaFicheroCTD.TabIndex = 8
        Me.BotonImportaFicheroCTD.Text = "Importar fichero CTD"
        Me.BotonImportaFicheroCTD.UseVisualStyleBackColor = True
        '
        'BotonSalvaCTDenBD
        '
        Me.BotonSalvaCTDenBD.Location = New System.Drawing.Point(523, 816)
        Me.BotonSalvaCTDenBD.Name = "BotonSalvaCTDenBD"
        Me.BotonSalvaCTDenBD.Size = New System.Drawing.Size(136, 49)
        Me.BotonSalvaCTDenBD.TabIndex = 9
        Me.BotonSalvaCTDenBD.Text = "Guardar datos CTD"
        Me.BotonSalvaCTDenBD.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LanceActivoCTDs
        '
        Me.LanceActivoCTDs.Location = New System.Drawing.Point(120, 59)
        Me.LanceActivoCTDs.Name = "LanceActivoCTDs"
        Me.LanceActivoCTDs.ReadOnly = True
        Me.LanceActivoCTDs.Size = New System.Drawing.Size(100, 22)
        Me.LanceActivoCTDs.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lance Activo"
        '
        'BotonBorraDatosCTD
        '
        Me.BotonBorraDatosCTD.ForeColor = System.Drawing.Color.Red
        Me.BotonBorraDatosCTD.Location = New System.Drawing.Point(726, 816)
        Me.BotonBorraDatosCTD.Name = "BotonBorraDatosCTD"
        Me.BotonBorraDatosCTD.Size = New System.Drawing.Size(126, 49)
        Me.BotonBorraDatosCTD.TabIndex = 12
        Me.BotonBorraDatosCTD.Text = "Borrar Datos CTD"
        Me.BotonBorraDatosCTD.UseVisualStyleBackColor = True
        '
        'BotonExportaCTDaEXCEL
        '
        Me.BotonExportaCTDaEXCEL.BackgroundImage = CType(resources.GetObject("BotonExportaCTDaEXCEL.BackgroundImage"), System.Drawing.Image)
        Me.BotonExportaCTDaEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BotonExportaCTDaEXCEL.Location = New System.Drawing.Point(919, 816)
        Me.BotonExportaCTDaEXCEL.Name = "BotonExportaCTDaEXCEL"
        Me.BotonExportaCTDaEXCEL.Size = New System.Drawing.Size(54, 49)
        Me.BotonExportaCTDaEXCEL.TabIndex = 13
        Me.BotonExportaCTDaEXCEL.UseVisualStyleBackColor = True
        '
        'TextBoxNumeroFilasCTD
        '
        Me.TextBoxNumeroFilasCTD.Location = New System.Drawing.Point(1088, 66)
        Me.TextBoxNumeroFilasCTD.Name = "TextBoxNumeroFilasCTD"
        Me.TextBoxNumeroFilasCTD.ReadOnly = True
        Me.TextBoxNumeroFilasCTD.Size = New System.Drawing.Size(62, 22)
        Me.TextBoxNumeroFilasCTD.TabIndex = 14
        Me.TextBoxNumeroFilasCTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1022, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nº Filas:"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNumeroFilasCTD)
        Me.Controls.Add(Me.BotonExportaCTDaEXCEL)
        Me.Controls.Add(Me.BotonBorraDatosCTD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LanceActivoCTDs)
        Me.Controls.Add(Me.BotonSalvaCTDenBD)
        Me.Controls.Add(Me.BotonImportaFicheroCTD)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos CTD's"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BotonImportaFicheroCTD As System.Windows.Forms.Button
    Friend WithEvents BotonSalvaCTDenBD As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LanceActivoCTDs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BotonBorraDatosCTD As System.Windows.Forms.Button
    Friend WithEvents BotonExportaCTDaEXCEL As System.Windows.Forms.Button
    Friend WithEvents TextBoxNumeroFilasCTD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
