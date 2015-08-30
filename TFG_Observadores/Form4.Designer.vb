<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FAunisticaDataGridViewB = New System.Windows.Forms.DataGridView()
        Me.TFCodLanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFCodEspecieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFFraccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFPesoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFNumEjemplarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFPesoMuestreadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFNumEjemplMuestreadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFTallaInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFTallaFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaunisticaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDpescamedDataSet1 = New TFG_Observadores.BDpescamedDataSet1()
        Me.FaunisticaTableAdapter = New TFG_Observadores.BDpescamedDataSet1TableAdapters.FaunisticaTableAdapter()
        Me.LanceActivoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCambiaLAnce = New System.Windows.Forms.Button()
        Me.CheckBoxComercial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDescarte = New System.Windows.Forms.CheckBox()
        Me.BotonCAmbiaFraccion = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PesoComercialTextBox = New System.Windows.Forms.TextBox()
        Me.PesoMuestraDescTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonAbreTallas = New System.Windows.Forms.Button()
        Me.BotonAceptaCambiosFaunistica = New System.Windows.Forms.Button()
        Me.BotonEliminaEspecieEnFaunistica = New System.Windows.Forms.Button()
        CType(Me.FAunisticaDataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaunisticaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDpescamedDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Gestión de Listas Faunísticas"
        '
        'FAunisticaDataGridViewB
        '
        Me.FAunisticaDataGridViewB.AutoGenerateColumns = False
        Me.FAunisticaDataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FAunisticaDataGridViewB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TFCodLanceDataGridViewTextBoxColumn, Me.TFCodEspecieDataGridViewTextBoxColumn, Me.TFFraccionDataGridViewTextBoxColumn, Me.TFPesoTotalDataGridViewTextBoxColumn, Me.TFNumEjemplarDataGridViewTextBoxColumn, Me.TFPesoMuestreadoDataGridViewTextBoxColumn, Me.TFNumEjemplMuestreadosDataGridViewTextBoxColumn, Me.TFTallaInicialDataGridViewTextBoxColumn, Me.TFTallaFinalDataGridViewTextBoxColumn})
        Me.FAunisticaDataGridViewB.DataSource = Me.FaunisticaBindingSource
        Me.FAunisticaDataGridViewB.Location = New System.Drawing.Point(53, 191)
        Me.FAunisticaDataGridViewB.Name = "FAunisticaDataGridViewB"
        Me.FAunisticaDataGridViewB.RowTemplate.Height = 24
        Me.FAunisticaDataGridViewB.Size = New System.Drawing.Size(1158, 577)
        Me.FAunisticaDataGridViewB.TabIndex = 5
        '
        'TFCodLanceDataGridViewTextBoxColumn
        '
        Me.TFCodLanceDataGridViewTextBoxColumn.DataPropertyName = "TF_CodLance"
        Me.TFCodLanceDataGridViewTextBoxColumn.HeaderText = "TF_CodLance"
        Me.TFCodLanceDataGridViewTextBoxColumn.Name = "TFCodLanceDataGridViewTextBoxColumn"
        '
        'TFCodEspecieDataGridViewTextBoxColumn
        '
        Me.TFCodEspecieDataGridViewTextBoxColumn.DataPropertyName = "TF_CodEspecie"
        Me.TFCodEspecieDataGridViewTextBoxColumn.HeaderText = "TF_CodEspecie"
        Me.TFCodEspecieDataGridViewTextBoxColumn.Name = "TFCodEspecieDataGridViewTextBoxColumn"
        '
        'TFFraccionDataGridViewTextBoxColumn
        '
        Me.TFFraccionDataGridViewTextBoxColumn.DataPropertyName = "TF_Fraccion"
        Me.TFFraccionDataGridViewTextBoxColumn.HeaderText = "TF_Fraccion"
        Me.TFFraccionDataGridViewTextBoxColumn.Name = "TFFraccionDataGridViewTextBoxColumn"
        '
        'TFPesoTotalDataGridViewTextBoxColumn
        '
        Me.TFPesoTotalDataGridViewTextBoxColumn.DataPropertyName = "TF_PesoTotal"
        Me.TFPesoTotalDataGridViewTextBoxColumn.HeaderText = "TF_PesoTotal"
        Me.TFPesoTotalDataGridViewTextBoxColumn.Name = "TFPesoTotalDataGridViewTextBoxColumn"
        '
        'TFNumEjemplarDataGridViewTextBoxColumn
        '
        Me.TFNumEjemplarDataGridViewTextBoxColumn.DataPropertyName = "TF_NumEjemplar"
        Me.TFNumEjemplarDataGridViewTextBoxColumn.HeaderText = "TF_NumEjemplar"
        Me.TFNumEjemplarDataGridViewTextBoxColumn.Name = "TFNumEjemplarDataGridViewTextBoxColumn"
        '
        'TFPesoMuestreadoDataGridViewTextBoxColumn
        '
        Me.TFPesoMuestreadoDataGridViewTextBoxColumn.DataPropertyName = "TF_PesoMuestreado"
        Me.TFPesoMuestreadoDataGridViewTextBoxColumn.HeaderText = "TF_PesoMuestreado"
        Me.TFPesoMuestreadoDataGridViewTextBoxColumn.Name = "TFPesoMuestreadoDataGridViewTextBoxColumn"
        '
        'TFNumEjemplMuestreadosDataGridViewTextBoxColumn
        '
        Me.TFNumEjemplMuestreadosDataGridViewTextBoxColumn.DataPropertyName = "TF_NumEjemplMuestreados"
        Me.TFNumEjemplMuestreadosDataGridViewTextBoxColumn.HeaderText = "TF_NumEjemplMuestreados"
        Me.TFNumEjemplMuestreadosDataGridViewTextBoxColumn.Name = "TFNumEjemplMuestreadosDataGridViewTextBoxColumn"
        '
        'TFTallaInicialDataGridViewTextBoxColumn
        '
        Me.TFTallaInicialDataGridViewTextBoxColumn.DataPropertyName = "TF_TallaInicial"
        Me.TFTallaInicialDataGridViewTextBoxColumn.HeaderText = "TF_TallaInicial"
        Me.TFTallaInicialDataGridViewTextBoxColumn.Name = "TFTallaInicialDataGridViewTextBoxColumn"
        '
        'TFTallaFinalDataGridViewTextBoxColumn
        '
        Me.TFTallaFinalDataGridViewTextBoxColumn.DataPropertyName = "TF_TallaFinal"
        Me.TFTallaFinalDataGridViewTextBoxColumn.HeaderText = "TF_TallaFinal"
        Me.TFTallaFinalDataGridViewTextBoxColumn.Name = "TFTallaFinalDataGridViewTextBoxColumn"
        '
        'FaunisticaBindingSource
        '
        Me.FaunisticaBindingSource.DataMember = "Faunistica"
        Me.FaunisticaBindingSource.DataSource = Me.BDpescamedDataSet1
        '
        'BDpescamedDataSet1
        '
        Me.BDpescamedDataSet1.DataSetName = "BDpescamedDataSet1"
        Me.BDpescamedDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FaunisticaTableAdapter
        '
        Me.FaunisticaTableAdapter.ClearBeforeFill = True
        '
        'LanceActivoTextBox
        '
        Me.LanceActivoTextBox.Location = New System.Drawing.Point(53, 140)
        Me.LanceActivoTextBox.Name = "LanceActivoTextBox"
        Me.LanceActivoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LanceActivoTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lance Activo"
        '
        'ButtonCambiaLAnce
        '
        Me.ButtonCambiaLAnce.Location = New System.Drawing.Point(159, 136)
        Me.ButtonCambiaLAnce.Name = "ButtonCambiaLAnce"
        Me.ButtonCambiaLAnce.Size = New System.Drawing.Size(106, 30)
        Me.ButtonCambiaLAnce.TabIndex = 8
        Me.ButtonCambiaLAnce.Text = "Cambia Lance"
        Me.ButtonCambiaLAnce.UseVisualStyleBackColor = True
        '
        'CheckBoxComercial
        '
        Me.CheckBoxComercial.AutoSize = True
        Me.CheckBoxComercial.Checked = True
        Me.CheckBoxComercial.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxComercial.Location = New System.Drawing.Point(15, 22)
        Me.CheckBoxComercial.Name = "CheckBoxComercial"
        Me.CheckBoxComercial.Size = New System.Drawing.Size(92, 21)
        Me.CheckBoxComercial.TabIndex = 9
        Me.CheckBoxComercial.Text = "Comercial"
        Me.CheckBoxComercial.UseVisualStyleBackColor = True
        '
        'CheckBoxDescarte
        '
        Me.CheckBoxDescarte.AutoSize = True
        Me.CheckBoxDescarte.Checked = True
        Me.CheckBoxDescarte.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDescarte.Location = New System.Drawing.Point(113, 22)
        Me.CheckBoxDescarte.Name = "CheckBoxDescarte"
        Me.CheckBoxDescarte.Size = New System.Drawing.Size(87, 21)
        Me.CheckBoxDescarte.TabIndex = 10
        Me.CheckBoxDescarte.Text = "Descarte"
        Me.CheckBoxDescarte.UseVisualStyleBackColor = True
        '
        'BotonCAmbiaFraccion
        '
        Me.BotonCAmbiaFraccion.Location = New System.Drawing.Point(206, 21)
        Me.BotonCAmbiaFraccion.Name = "BotonCAmbiaFraccion"
        Me.BotonCAmbiaFraccion.Size = New System.Drawing.Size(75, 23)
        Me.BotonCAmbiaFraccion.TabIndex = 11
        Me.BotonCAmbiaFraccion.Text = "Cambia"
        Me.BotonCAmbiaFraccion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BotonCAmbiaFraccion)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDescarte)
        Me.GroupBox1.Controls.Add(Me.CheckBoxComercial)
        Me.GroupBox1.Location = New System.Drawing.Point(294, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 60)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "Fracción"
        '
        'PesoComercialTextBox
        '
        Me.PesoComercialTextBox.Location = New System.Drawing.Point(799, 120)
        Me.PesoComercialTextBox.Name = "PesoComercialTextBox"
        Me.PesoComercialTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PesoComercialTextBox.TabIndex = 13
        '
        'PesoMuestraDescTextBox
        '
        Me.PesoMuestraDescTextBox.Location = New System.Drawing.Point(799, 154)
        Me.PesoMuestraDescTextBox.Name = "PesoMuestraDescTextBox"
        Me.PesoMuestraDescTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PesoMuestraDescTextBox.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(682, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Peso Comercial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(637, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Peso Muestra Descarte"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(53, 784)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 49)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonAbreTallas
        '
        Me.BotonAbreTallas.Location = New System.Drawing.Point(119, 784)
        Me.BotonAbreTallas.Name = "BotonAbreTallas"
        Me.BotonAbreTallas.Size = New System.Drawing.Size(111, 49)
        Me.BotonAbreTallas.TabIndex = 19
        Me.BotonAbreTallas.Text = "Tallas"
        Me.BotonAbreTallas.UseVisualStyleBackColor = True
        '
        'BotonAceptaCambiosFaunistica
        '
        Me.BotonAceptaCambiosFaunistica.Location = New System.Drawing.Point(249, 784)
        Me.BotonAceptaCambiosFaunistica.Name = "BotonAceptaCambiosFaunistica"
        Me.BotonAceptaCambiosFaunistica.Size = New System.Drawing.Size(110, 49)
        Me.BotonAceptaCambiosFaunistica.TabIndex = 20
        Me.BotonAceptaCambiosFaunistica.Text = "Aceptar Cambios"
        Me.BotonAceptaCambiosFaunistica.UseVisualStyleBackColor = True
        '
        'BotonEliminaEspecieEnFaunistica
        '
        Me.BotonEliminaEspecieEnFaunistica.ForeColor = System.Drawing.Color.Red
        Me.BotonEliminaEspecieEnFaunistica.Location = New System.Drawing.Point(379, 784)
        Me.BotonEliminaEspecieEnFaunistica.Name = "BotonEliminaEspecieEnFaunistica"
        Me.BotonEliminaEspecieEnFaunistica.Size = New System.Drawing.Size(103, 49)
        Me.BotonEliminaEspecieEnFaunistica.TabIndex = 21
        Me.BotonEliminaEspecieEnFaunistica.Text = "Elimina Especie"
        Me.BotonEliminaEspecieEnFaunistica.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.BotonEliminaEspecieEnFaunistica)
        Me.Controls.Add(Me.BotonAceptaCambiosFaunistica)
        Me.Controls.Add(Me.BotonAbreTallas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PesoMuestraDescTextBox)
        Me.Controls.Add(Me.PesoComercialTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCambiaLAnce)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LanceActivoTextBox)
        Me.Controls.Add(Me.FAunisticaDataGridViewB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Listas Fanísticas"
        CType(Me.FAunisticaDataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaunisticaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDpescamedDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FAunisticaDataGridViewB As System.Windows.Forms.DataGridView
    Friend WithEvents BDpescamedDataSet1 As TFG_Observadores.BDpescamedDataSet1
    Friend WithEvents FaunisticaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FaunisticaTableAdapter As TFG_Observadores.BDpescamedDataSet1TableAdapters.FaunisticaTableAdapter
    Friend WithEvents TFCodLanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFCodEspecieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFFraccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFPesoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFNumEjemplarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFPesoMuestreadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFNumEjemplMuestreadosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFTallaInicialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFTallaFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LanceActivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonCambiaLAnce As System.Windows.Forms.Button
    Friend WithEvents CheckBoxComercial As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDescarte As System.Windows.Forms.CheckBox
    Friend WithEvents BotonCAmbiaFraccion As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PesoComercialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoMuestraDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BotonAbreTallas As System.Windows.Forms.Button
    Friend WithEvents BotonAceptaCambiosFaunistica As System.Windows.Forms.Button
    Friend WithEvents BotonEliminaEspecieEnFaunistica As System.Windows.Forms.Button
End Class
