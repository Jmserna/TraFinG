<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonBuscaLances = New System.Windows.Forms.Button()
        Me.TextBoxBarco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxFecha = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxArte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEspecie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxNulo = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BotonLimpiaCamposBusqueda = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar Lances"
        '
        'BotonBuscaLances
        '
        Me.BotonBuscaLances.Location = New System.Drawing.Point(281, 780)
        Me.BotonBuscaLances.Name = "BotonBuscaLances"
        Me.BotonBuscaLances.Size = New System.Drawing.Size(309, 41)
        Me.BotonBuscaLances.TabIndex = 5
        Me.BotonBuscaLances.Text = "Buscar"
        Me.BotonBuscaLances.UseVisualStyleBackColor = True
        '
        'TextBoxBarco
        '
        Me.TextBoxBarco.Location = New System.Drawing.Point(167, 192)
        Me.TextBoxBarco.Name = "TextBoxBarco"
        Me.TextBoxBarco.Size = New System.Drawing.Size(242, 22)
        Me.TextBoxBarco.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Barco"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(736, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha (AAAA/MM/DD)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(520, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nulo"
        '
        'MaskedTextBoxFecha
        '
        Me.MaskedTextBoxFecha.Location = New System.Drawing.Point(889, 192)
        Me.MaskedTextBoxFecha.Mask = "0000/00/00"
        Me.MaskedTextBoxFecha.Name = "MaskedTextBoxFecha"
        Me.MaskedTextBoxFecha.Size = New System.Drawing.Size(81, 22)
        Me.MaskedTextBoxFecha.TabIndex = 12
        '
        'TextBoxArte
        '
        Me.TextBoxArte.Location = New System.Drawing.Point(167, 268)
        Me.TextBoxArte.Name = "TextBoxArte"
        Me.TextBoxArte.Size = New System.Drawing.Size(242, 22)
        Me.TextBoxArte.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Arte"
        '
        'TextBoxEspecie
        '
        Me.TextBoxEspecie.Location = New System.Drawing.Point(563, 268)
        Me.TextBoxEspecie.Name = "TextBoxEspecie"
        Me.TextBoxEspecie.Size = New System.Drawing.Size(307, 22)
        Me.TextBoxEspecie.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Especie"
        '
        'ComboBoxNulo
        '
        Me.ComboBoxNulo.FormattingEnabled = True
        Me.ComboBoxNulo.Items.AddRange(New Object() {"S", "N"})
        Me.ComboBoxNulo.Location = New System.Drawing.Point(563, 191)
        Me.ComboBoxNulo.Name = "ComboBoxNulo"
        Me.ComboBoxNulo.Size = New System.Drawing.Size(69, 24)
        Me.ComboBoxNulo.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(116, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1033, 378)
        Me.DataGridView1.TabIndex = 18
        '
        'BotonLimpiaCamposBusqueda
        '
        Me.BotonLimpiaCamposBusqueda.Location = New System.Drawing.Point(688, 780)
        Me.BotonLimpiaCamposBusqueda.Name = "BotonLimpiaCamposBusqueda"
        Me.BotonLimpiaCamposBusqueda.Size = New System.Drawing.Size(309, 41)
        Me.BotonLimpiaCamposBusqueda.TabIndex = 19
        Me.BotonLimpiaCamposBusqueda.Text = "Limpiar Campos"
        Me.BotonLimpiaCamposBusqueda.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.BotonLimpiaCamposBusqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxNulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxEspecie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxArte)
        Me.Controls.Add(Me.MaskedTextBoxFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBarco)
        Me.Controls.Add(Me.BotonBuscaLances)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar lances"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BotonBuscaLances As System.Windows.Forms.Button
    Friend WithEvents TextBoxBarco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxArte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEspecie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNulo As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BotonLimpiaCamposBusqueda As System.Windows.Forms.Button
End Class
