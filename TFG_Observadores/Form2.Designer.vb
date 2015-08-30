<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonTrackings = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonCtd = New System.Windows.Forms.Button()
        Me.ButtonGraficos = New System.Windows.Forms.Button()
        Me.ButtonTallas = New System.Windows.Forms.Button()
        Me.ButtonFaunistica = New System.Windows.Forms.Button()
        Me.ButtonLances = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonTrackings)
        Me.GroupBox1.Controls.Add(Me.ButtonCtd)
        Me.GroupBox1.Controls.Add(Me.ButtonGraficos)
        Me.GroupBox1.Controls.Add(Me.ButtonTallas)
        Me.GroupBox1.Controls.Add(Me.ButtonFaunistica)
        Me.GroupBox1.Controls.Add(Me.ButtonLances)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(132, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(965, 446)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menú Principal"
        '
        'ButtonTrackings
        '
        Me.ButtonTrackings.Location = New System.Drawing.Point(540, 290)
        Me.ButtonTrackings.Name = "ButtonTrackings"
        Me.ButtonTrackings.Size = New System.Drawing.Size(333, 50)
        Me.ButtonTrackings.TabIndex = 7
        Me.ButtonTrackings.Text = "Trackings"
        Me.ButtonTrackings.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonSalir.Location = New System.Drawing.Point(936, 763)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(161, 24)
        Me.ButtonSalir.TabIndex = 6
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonCtd
        '
        Me.ButtonCtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCtd.Location = New System.Drawing.Point(540, 206)
        Me.ButtonCtd.Name = "ButtonCtd"
        Me.ButtonCtd.Size = New System.Drawing.Size(333, 50)
        Me.ButtonCtd.TabIndex = 5
        Me.ButtonCtd.Text = "Parámetros Columna de Agua"
        Me.ButtonCtd.UseVisualStyleBackColor = True
        '
        'ButtonGraficos
        '
        Me.ButtonGraficos.Location = New System.Drawing.Point(540, 116)
        Me.ButtonGraficos.Name = "ButtonGraficos"
        Me.ButtonGraficos.Size = New System.Drawing.Size(333, 50)
        Me.ButtonGraficos.TabIndex = 3
        Me.ButtonGraficos.Text = "Gráficos"
        Me.ButtonGraficos.UseVisualStyleBackColor = True
        '
        'ButtonTallas
        '
        Me.ButtonTallas.Location = New System.Drawing.Point(94, 290)
        Me.ButtonTallas.Name = "ButtonTallas"
        Me.ButtonTallas.Size = New System.Drawing.Size(333, 46)
        Me.ButtonTallas.TabIndex = 2
        Me.ButtonTallas.Text = "Gestión de Tallas"
        Me.ButtonTallas.UseVisualStyleBackColor = True
        '
        'ButtonFaunistica
        '
        Me.ButtonFaunistica.Location = New System.Drawing.Point(94, 207)
        Me.ButtonFaunistica.Name = "ButtonFaunistica"
        Me.ButtonFaunistica.Size = New System.Drawing.Size(333, 46)
        Me.ButtonFaunistica.TabIndex = 1
        Me.ButtonFaunistica.Text = "Gestión de Lista Faunistica"
        Me.ButtonFaunistica.UseVisualStyleBackColor = True
        '
        'ButtonLances
        '
        Me.ButtonLances.Location = New System.Drawing.Point(94, 116)
        Me.ButtonLances.Name = "ButtonLances"
        Me.ButtonLances.Size = New System.Drawing.Size(333, 50)
        Me.ButtonLances.TabIndex = 0
        Me.ButtonLances.Text = "Gestión de Lances de Pesca"
        Me.ButtonLances.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1027, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sistema para la Gestión de Datos de Observadores Científicos en Buques de Pesca C" & _
    "omercial"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonFaunistica As System.Windows.Forms.Button
    Friend WithEvents ButtonLances As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonTrackings As System.Windows.Forms.Button
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Friend WithEvents ButtonCtd As System.Windows.Forms.Button
    Friend WithEvents ButtonGraficos As System.Windows.Forms.Button
    Friend WithEvents ButtonTallas As System.Windows.Forms.Button
End Class
