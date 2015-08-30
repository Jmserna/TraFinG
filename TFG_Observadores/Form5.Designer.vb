<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LanceActivoTallasTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BotonCambiaLanceEnTallas = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BDpescamedDataSet1 = New TFG_Observadores.BDpescamedDataSet1()
        Me.TallasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallasTableAdapter = New TFG_Observadores.BDpescamedDataSet1TableAdapters.TallasTableAdapter()
        Me.TableAdapterManager = New TFG_Observadores.BDpescamedDataSet1TableAdapters.TableAdapterManager()
        Me.TallasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TallasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TallasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LanceTallaTextBox = New System.Windows.Forms.TextBox()
        Me.EspecieTallaTextBox = New System.Windows.Forms.TextBox()
        Me.FraccionTallaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BotonExportaTallasAExcel = New System.Windows.Forms.Button()
        Me.BotonAceptarCambiosTAllas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonEliminaMuestreo = New System.Windows.Forms.Button()
        CType(Me.BDpescamedDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TallasBindingNavigator.SuspendLayout()
        CType(Me.TallasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Gestión de Tallas"
        '
        'LanceActivoTallasTextBox
        '
        Me.LanceActivoTallasTextBox.Location = New System.Drawing.Point(78, 81)
        Me.LanceActivoTallasTextBox.Name = "LanceActivoTallasTextBox"
        Me.LanceActivoTallasTextBox.Size = New System.Drawing.Size(86, 22)
        Me.LanceActivoTallasTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lance Activo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Especie"
        '
        'BotonCambiaLanceEnTallas
        '
        Me.BotonCambiaLanceEnTallas.Location = New System.Drawing.Point(190, 76)
        Me.BotonCambiaLanceEnTallas.Name = "BotonCambiaLanceEnTallas"
        Me.BotonCambiaLanceEnTallas.Size = New System.Drawing.Size(123, 32)
        Me.BotonCambiaLanceEnTallas.TabIndex = 11
        Me.BotonCambiaLanceEnTallas.Text = "Cambia Lance"
        Me.BotonCambiaLanceEnTallas.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(78, 160)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(406, 712)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'BDpescamedDataSet1
        '
        Me.BDpescamedDataSet1.DataSetName = "BDpescamedDataSet1"
        Me.BDpescamedDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TallasBindingSource
        '
        Me.TallasBindingSource.DataMember = "Tallas"
        Me.TallasBindingSource.DataSource = Me.BDpescamedDataSet1
        '
        'TallasTableAdapter
        '
        Me.TallasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuquesTableAdapter = Nothing
        Me.TableAdapterManager.CTDTableAdapter = Nothing
        Me.TableAdapterManager.EspeciesTableAdapter = Nothing
        Me.TableAdapterManager.FaunisticaTableAdapter = Nothing
        Me.TableAdapterManager.LancesTableAdapter = Nothing
        Me.TableAdapterManager.ObservadoresTableAdapter = Nothing
        Me.TableAdapterManager.TallasTableAdapter = Me.TallasTableAdapter
        Me.TableAdapterManager.TrackingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TFG_Observadores.BDpescamedDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TallasBindingNavigator
        '
        Me.TallasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TallasBindingNavigator.BindingSource = Me.TallasBindingSource
        Me.TallasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TallasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TallasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TallasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TallasBindingNavigatorSaveItem})
        Me.TallasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TallasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TallasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TallasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TallasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TallasBindingNavigator.Name = "TallasBindingNavigator"
        Me.TallasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TallasBindingNavigator.Size = New System.Drawing.Size(1262, 27)
        Me.TallasBindingNavigator.TabIndex = 12
        Me.TallasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TallasBindingNavigatorSaveItem
        '
        Me.TallasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TallasBindingNavigatorSaveItem.Image = CType(resources.GetObject("TallasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TallasBindingNavigatorSaveItem.Name = "TallasBindingNavigatorSaveItem"
        Me.TallasBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.TallasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TallasDataGridView
        '
        Me.TallasDataGridView.AutoGenerateColumns = False
        Me.TallasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TallasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TallasDataGridView.DataSource = Me.TallasBindingSource
        Me.TallasDataGridView.Location = New System.Drawing.Point(530, 205)
        Me.TallasDataGridView.Name = "TallasDataGridView"
        Me.TallasDataGridView.RowTemplate.Height = 24
        Me.TallasDataGridView.Size = New System.Drawing.Size(668, 618)
        Me.TallasDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TT_codLance"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod Lance"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TT_CodEspecie"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cod Especie"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TT_Fraccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fracción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TT_Talla"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Talla"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TT_NumEjemplares"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nº Ejemplares"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'LanceTallaTextBox
        '
        Me.LanceTallaTextBox.Location = New System.Drawing.Point(622, 157)
        Me.LanceTallaTextBox.Name = "LanceTallaTextBox"
        Me.LanceTallaTextBox.ReadOnly = True
        Me.LanceTallaTextBox.Size = New System.Drawing.Size(62, 22)
        Me.LanceTallaTextBox.TabIndex = 13
        '
        'EspecieTallaTextBox
        '
        Me.EspecieTallaTextBox.Location = New System.Drawing.Point(804, 157)
        Me.EspecieTallaTextBox.Name = "EspecieTallaTextBox"
        Me.EspecieTallaTextBox.ReadOnly = True
        Me.EspecieTallaTextBox.Size = New System.Drawing.Size(69, 22)
        Me.EspecieTallaTextBox.TabIndex = 14
        '
        'FraccionTallaTextBox
        '
        Me.FraccionTallaTextBox.Location = New System.Drawing.Point(980, 157)
        Me.FraccionTallaTextBox.Name = "FraccionTallaTextBox"
        Me.FraccionTallaTextBox.ReadOnly = True
        Me.FraccionTallaTextBox.Size = New System.Drawing.Size(37, 22)
        Me.FraccionTallaTextBox.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(527, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Lance Activo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(715, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CodEspecie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(912, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fracción"
        '
        'BotonExportaTallasAExcel
        '
        Me.BotonExportaTallasAExcel.BackgroundImage = CType(resources.GetObject("BotonExportaTallasAExcel.BackgroundImage"), System.Drawing.Image)
        Me.BotonExportaTallasAExcel.Location = New System.Drawing.Point(1152, 145)
        Me.BotonExportaTallasAExcel.Name = "BotonExportaTallasAExcel"
        Me.BotonExportaTallasAExcel.Size = New System.Drawing.Size(46, 46)
        Me.BotonExportaTallasAExcel.TabIndex = 19
        Me.BotonExportaTallasAExcel.UseVisualStyleBackColor = True
        '
        'BotonAceptarCambiosTAllas
        '
        Me.BotonAceptarCambiosTAllas.Location = New System.Drawing.Point(530, 842)
        Me.BotonAceptarCambiosTAllas.Name = "BotonAceptarCambiosTAllas"
        Me.BotonAceptarCambiosTAllas.Size = New System.Drawing.Size(133, 30)
        Me.BotonAceptarCambiosTAllas.TabIndex = 20
        Me.BotonAceptarCambiosTAllas.Text = "Aceptar Cambios"
        Me.BotonAceptarCambiosTAllas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 842)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 30)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Elimina Talla"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonEliminaMuestreo
        '
        Me.BotonEliminaMuestreo.Location = New System.Drawing.Point(829, 842)
        Me.BotonEliminaMuestreo.Name = "BotonEliminaMuestreo"
        Me.BotonEliminaMuestreo.Size = New System.Drawing.Size(133, 30)
        Me.BotonEliminaMuestreo.TabIndex = 22
        Me.BotonEliminaMuestreo.Text = "Elimina Muestreo"
        Me.BotonEliminaMuestreo.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.BotonEliminaMuestreo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BotonAceptarCambiosTAllas)
        Me.Controls.Add(Me.BotonExportaTallasAExcel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FraccionTallaTextBox)
        Me.Controls.Add(Me.EspecieTallaTextBox)
        Me.Controls.Add(Me.LanceTallaTextBox)
        Me.Controls.Add(Me.TallasDataGridView)
        Me.Controls.Add(Me.TallasBindingNavigator)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BotonCambiaLanceEnTallas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LanceActivoTallasTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Tallas"
        CType(Me.BDpescamedDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TallasBindingNavigator.ResumeLayout(False)
        Me.TallasBindingNavigator.PerformLayout()
        CType(Me.TallasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LanceActivoTallasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BotonCambiaLanceEnTallas As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents BDpescamedDataSet1 As TFG_Observadores.BDpescamedDataSet1
    Friend WithEvents TallasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TallasTableAdapter As TFG_Observadores.BDpescamedDataSet1TableAdapters.TallasTableAdapter
    Friend WithEvents TableAdapterManager As TFG_Observadores.BDpescamedDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TallasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TallasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TallasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LanceTallaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EspecieTallaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FraccionTallaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BotonExportaTallasAExcel As System.Windows.Forms.Button
    Friend WithEvents BotonAceptarCambiosTAllas As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BotonEliminaMuestreo As System.Windows.Forms.Button
End Class
