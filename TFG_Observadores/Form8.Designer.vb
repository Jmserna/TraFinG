<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LanceActivoGraficos = New System.Windows.Forms.TextBox()
        Me.BotonCambiaLanceGraficos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FraccionGraficosTextBox = New System.Windows.Forms.TextBox()
        Me.EspecieGraficosTextBox = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BotonPintaGrafico = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BotonExportarGraficoABmp = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(431, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gráficos - Distribuciones de Tallas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Lance Activo"
        '
        'LanceActivoGraficos
        '
        Me.LanceActivoGraficos.Location = New System.Drawing.Point(28, 103)
        Me.LanceActivoGraficos.Name = "LanceActivoGraficos"
        Me.LanceActivoGraficos.Size = New System.Drawing.Size(86, 22)
        Me.LanceActivoGraficos.TabIndex = 12
        '
        'BotonCambiaLanceGraficos
        '
        Me.BotonCambiaLanceGraficos.Location = New System.Drawing.Point(133, 99)
        Me.BotonCambiaLanceGraficos.Name = "BotonCambiaLanceGraficos"
        Me.BotonCambiaLanceGraficos.Size = New System.Drawing.Size(139, 31)
        Me.BotonCambiaLanceGraficos.TabIndex = 14
        Me.BotonCambiaLanceGraficos.Text = "Cambia Lance"
        Me.BotonCambiaLanceGraficos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Especies con Talla"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(664, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Fracción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(467, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "CodEspecie"
        '
        'FraccionGraficosTextBox
        '
        Me.FraccionGraficosTextBox.Location = New System.Drawing.Point(732, 140)
        Me.FraccionGraficosTextBox.Name = "FraccionGraficosTextBox"
        Me.FraccionGraficosTextBox.ReadOnly = True
        Me.FraccionGraficosTextBox.Size = New System.Drawing.Size(37, 22)
        Me.FraccionGraficosTextBox.TabIndex = 20
        '
        'EspecieGraficosTextBox
        '
        Me.EspecieGraficosTextBox.Location = New System.Drawing.Point(556, 140)
        Me.EspecieGraficosTextBox.Name = "EspecieGraficosTextBox"
        Me.EspecieGraficosTextBox.ReadOnly = True
        Me.EspecieGraficosTextBox.Size = New System.Drawing.Size(69, 22)
        Me.EspecieGraficosTextBox.TabIndex = 19
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(28, 168)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(406, 271)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Chart1
        '
        Me.Chart1.Location = New System.Drawing.Point(471, 168)
        Me.Chart1.Name = "Chart1"
        Series1.Name = "Series1"
        Series1.XValueMember = "tt_talla"
        Series1.YValueMembers = "tt_numejemplares"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(766, 552)
        Me.Chart1.TabIndex = 23
        Me.Chart1.Text = "Chart1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 470)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(406, 250)
        Me.DataGridView1.TabIndex = 24
        '
        'BotonPintaGrafico
        '
        Me.BotonPintaGrafico.Location = New System.Drawing.Point(295, 99)
        Me.BotonPintaGrafico.Name = "BotonPintaGrafico"
        Me.BotonPintaGrafico.Size = New System.Drawing.Size(139, 31)
        Me.BotonPintaGrafico.TabIndex = 25
        Me.BotonPintaGrafico.Text = "Graficar Muestreo"
        Me.BotonPintaGrafico.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Muestreo"
        '
        'BotonExportarGraficoABmp
        '
        Me.BotonExportarGraficoABmp.Location = New System.Drawing.Point(471, 737)
        Me.BotonExportarGraficoABmp.Name = "BotonExportarGraficoABmp"
        Me.BotonExportarGraficoABmp.Size = New System.Drawing.Size(766, 37)
        Me.BotonExportarGraficoABmp.TabIndex = 27
        Me.BotonExportarGraficoABmp.Text = "Exportar Gráfico de Barras como imagen BMP"
        Me.BotonExportarGraficoABmp.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.BotonExportarGraficoABmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BotonPintaGrafico)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FraccionGraficosTextBox)
        Me.Controls.Add(Me.EspecieGraficosTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BotonCambiaLanceGraficos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LanceActivoGraficos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distribuciones de Tallas"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LanceActivoGraficos As System.Windows.Forms.TextBox
    Friend WithEvents BotonCambiaLanceGraficos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FraccionGraficosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EspecieGraficosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BotonPintaGrafico As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BotonExportarGraficoABmp As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
