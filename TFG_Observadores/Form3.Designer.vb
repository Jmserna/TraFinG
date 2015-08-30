<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim TL_CodLanceLabel As System.Windows.Forms.Label
        Dim TL_NuloLabel As System.Windows.Forms.Label
        Dim TL_CodBarcoLabel As System.Windows.Forms.Label
        Dim TL_FechaLanceLabel As System.Windows.Forms.Label
        Dim TL_NumLanceLabel As System.Windows.Forms.Label
        Dim TL_TipoArteLabel As System.Windows.Forms.Label
        Dim TL_TipoPuertaLabel As System.Windows.Forms.Label
        Dim TL_PesoPuertaLabel As System.Windows.Forms.Label
        Dim TL_FirmesFechaLabel As System.Windows.Forms.Label
        Dim TL_FirmesHoraLabel As System.Windows.Forms.Label
        Dim TL_FirmesLatLabel As System.Windows.Forms.Label
        Dim TL_FirmesLongLabel As System.Windows.Forms.Label
        Dim TL_FirmesProfLabel As System.Windows.Forms.Label
        Dim TL_ViradaFechaLabel As System.Windows.Forms.Label
        Dim TL_ViradaHoraLabel As System.Windows.Forms.Label
        Dim TL_ViradaLatLabel As System.Windows.Forms.Label
        Dim TL_ViradaLongLabel As System.Windows.Forms.Label
        Dim TL_ViradaProfLabel As System.Windows.Forms.Label
        Dim TL_RumboLabel As System.Windows.Forms.Label
        Dim TL_nudosVelocidadLabel As System.Windows.Forms.Label
        Dim TL_EstadoMetereologicoLabel As System.Windows.Forms.Label
        Dim TL_EstadoDeLaMarLabel As System.Windows.Forms.Label
        Dim TL_PesoTotalDescarteLabel As System.Windows.Forms.Label
        Dim TL_PesoTotalComercialLabel As System.Windows.Forms.Label
        Dim TL_CodObservadorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BDpescamedDataSet1 = New TFG_Observadores.BDpescamedDataSet1()
        Me.LancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LancesTableAdapter = New TFG_Observadores.BDpescamedDataSet1TableAdapters.LancesTableAdapter()
        Me.TableAdapterManager = New TFG_Observadores.BDpescamedDataSet1TableAdapters.TableAdapterManager()
        Me.LancesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LancesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TL_CodLanceTextBox = New System.Windows.Forms.TextBox()
        Me.TL_NuloTextBox = New System.Windows.Forms.TextBox()
        Me.TL_CodBarcoTextBox = New System.Windows.Forms.TextBox()
        Me.TL_FechaLanceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TL_NumLanceTextBox = New System.Windows.Forms.TextBox()
        Me.TL_TipoPuertaTextBox = New System.Windows.Forms.TextBox()
        Me.TL_PesoPuertaTextBox = New System.Windows.Forms.TextBox()
        Me.TL_FirmesFechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TL_FirmesProfTextBox = New System.Windows.Forms.TextBox()
        Me.TL_ViradaFechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TL_ViradaProfTextBox = New System.Windows.Forms.TextBox()
        Me.TL_RumboTextBox = New System.Windows.Forms.TextBox()
        Me.TL_nudosVelocidadTextBox = New System.Windows.Forms.TextBox()
        Me.TL_EstadoMetereologicoTextBox = New System.Windows.Forms.TextBox()
        Me.TL_EstadoDeLaMarTextBox = New System.Windows.Forms.TextBox()
        Me.TL_PesoTotalDescarteTextBox = New System.Windows.Forms.TextBox()
        Me.TL_PesoTotalComercialTextBox = New System.Windows.Forms.TextBox()
        Me.TL_CodObservadorTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxFirmesLong = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxFirmesLat = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxHoraFirmes = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxViradaLong = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxViradaLat = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxViradaHora = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TL_TipoArteTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonNextLance = New System.Windows.Forms.Button()
        Me.ButtonPrevioLance = New System.Windows.Forms.Button()
        Me.ButtonLanceUltimo = New System.Windows.Forms.Button()
        Me.ButtonLancePrimero = New System.Windows.Forms.Button()
        Me.ComboBoxTiposArte = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBarcos = New System.Windows.Forms.ComboBox()
        Me.BotonNuevoLance = New System.Windows.Forms.Button()
        Me.FaunisticaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FaunisticaTableAdapter = New TFG_Observadores.BDpescamedDataSet1TableAdapters.FaunisticaTableAdapter()
        Me.FaunisticaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EspeciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EspeciesTableAdapter = New TFG_Observadores.BDpescamedDataSet1TableAdapters.EspeciesTableAdapter()
        Me.BotonActualizaFaunistica = New System.Windows.Forms.Button()
        Me.BotonEliminaEspecieFaunistica = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonAbreFormularioCTD = New System.Windows.Forms.Button()
        Me.BotonAbreFormularioGPS = New System.Windows.Forms.Button()
        Me.BotonAceptaCambios = New System.Windows.Forms.Button()
        Me.BotonBorrarLance = New System.Windows.Forms.Button()
        Me.RefrescaListaFaunistica = New System.Windows.Forms.Button()
        Me.BotonBuscarLance = New System.Windows.Forms.Button()
        Me.BotonIrA = New System.Windows.Forms.Button()
        TL_CodLanceLabel = New System.Windows.Forms.Label()
        TL_NuloLabel = New System.Windows.Forms.Label()
        TL_CodBarcoLabel = New System.Windows.Forms.Label()
        TL_FechaLanceLabel = New System.Windows.Forms.Label()
        TL_NumLanceLabel = New System.Windows.Forms.Label()
        TL_TipoArteLabel = New System.Windows.Forms.Label()
        TL_TipoPuertaLabel = New System.Windows.Forms.Label()
        TL_PesoPuertaLabel = New System.Windows.Forms.Label()
        TL_FirmesFechaLabel = New System.Windows.Forms.Label()
        TL_FirmesHoraLabel = New System.Windows.Forms.Label()
        TL_FirmesLatLabel = New System.Windows.Forms.Label()
        TL_FirmesLongLabel = New System.Windows.Forms.Label()
        TL_FirmesProfLabel = New System.Windows.Forms.Label()
        TL_ViradaFechaLabel = New System.Windows.Forms.Label()
        TL_ViradaHoraLabel = New System.Windows.Forms.Label()
        TL_ViradaLatLabel = New System.Windows.Forms.Label()
        TL_ViradaLongLabel = New System.Windows.Forms.Label()
        TL_ViradaProfLabel = New System.Windows.Forms.Label()
        TL_RumboLabel = New System.Windows.Forms.Label()
        TL_nudosVelocidadLabel = New System.Windows.Forms.Label()
        TL_EstadoMetereologicoLabel = New System.Windows.Forms.Label()
        TL_EstadoDeLaMarLabel = New System.Windows.Forms.Label()
        TL_PesoTotalDescarteLabel = New System.Windows.Forms.Label()
        TL_PesoTotalComercialLabel = New System.Windows.Forms.Label()
        TL_CodObservadorLabel = New System.Windows.Forms.Label()
        CType(Me.BDpescamedDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LancesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LancesBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FaunisticaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaunisticaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspeciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TL_CodLanceLabel
        '
        TL_CodLanceLabel.AutoSize = True
        TL_CodLanceLabel.BackColor = System.Drawing.Color.LightGray
        TL_CodLanceLabel.Location = New System.Drawing.Point(74, 103)
        TL_CodLanceLabel.Name = "TL_CodLanceLabel"
        TL_CodLanceLabel.Size = New System.Drawing.Size(119, 17)
        TL_CodLanceLabel.TabIndex = 4
        TL_CodLanceLabel.Text = "Código de Lance:"
        '
        'TL_NuloLabel
        '
        TL_NuloLabel.AutoSize = True
        TL_NuloLabel.BackColor = System.Drawing.Color.LightGray
        TL_NuloLabel.Location = New System.Drawing.Point(302, 103)
        TL_NuloLabel.Name = "TL_NuloLabel"
        TL_NuloLabel.Size = New System.Drawing.Size(78, 17)
        TL_NuloLabel.TabIndex = 6
        TL_NuloLabel.Text = "Nulo (S/N):"
        '
        'TL_CodBarcoLabel
        '
        TL_CodBarcoLabel.AutoSize = True
        TL_CodBarcoLabel.BackColor = System.Drawing.Color.LightGray
        TL_CodBarcoLabel.Location = New System.Drawing.Point(441, 100)
        TL_CodBarcoLabel.Name = "TL_CodBarcoLabel"
        TL_CodBarcoLabel.Size = New System.Drawing.Size(117, 17)
        TL_CodBarcoLabel.TabIndex = 8
        TL_CodBarcoLabel.Text = "Código de Barco:"
        '
        'TL_FechaLanceLabel
        '
        TL_FechaLanceLabel.AutoSize = True
        TL_FechaLanceLabel.BackColor = System.Drawing.Color.LightGray
        TL_FechaLanceLabel.Location = New System.Drawing.Point(841, 103)
        TL_FechaLanceLabel.Name = "TL_FechaLanceLabel"
        TL_FechaLanceLabel.Size = New System.Drawing.Size(94, 17)
        TL_FechaLanceLabel.TabIndex = 10
        TL_FechaLanceLabel.Text = "Fecha Lance:"
        '
        'TL_NumLanceLabel
        '
        TL_NumLanceLabel.AutoSize = True
        TL_NumLanceLabel.BackColor = System.Drawing.Color.LightGray
        TL_NumLanceLabel.Location = New System.Drawing.Point(1111, 103)
        TL_NumLanceLabel.Name = "TL_NumLanceLabel"
        TL_NumLanceLabel.Size = New System.Drawing.Size(70, 17)
        TL_NumLanceLabel.TabIndex = 12
        TL_NumLanceLabel.Text = "Nº Lance:"
        '
        'TL_TipoArteLabel
        '
        TL_TipoArteLabel.AutoSize = True
        TL_TipoArteLabel.BackColor = System.Drawing.Color.LightGray
        TL_TipoArteLabel.Location = New System.Drawing.Point(74, 136)
        TL_TipoArteLabel.Name = "TL_TipoArteLabel"
        TL_TipoArteLabel.Size = New System.Drawing.Size(91, 17)
        TL_TipoArteLabel.TabIndex = 14
        TL_TipoArteLabel.Text = "TL Tipo Arte:"
        '
        'TL_TipoPuertaLabel
        '
        TL_TipoPuertaLabel.AutoSize = True
        TL_TipoPuertaLabel.BackColor = System.Drawing.Color.LightGray
        TL_TipoPuertaLabel.Location = New System.Drawing.Point(496, 136)
        TL_TipoPuertaLabel.Name = "TL_TipoPuertaLabel"
        TL_TipoPuertaLabel.Size = New System.Drawing.Size(86, 17)
        TL_TipoPuertaLabel.TabIndex = 16
        TL_TipoPuertaLabel.Text = "Tipo Puerta:"
        '
        'TL_PesoPuertaLabel
        '
        TL_PesoPuertaLabel.AutoSize = True
        TL_PesoPuertaLabel.BackColor = System.Drawing.Color.LightGray
        TL_PesoPuertaLabel.Location = New System.Drawing.Point(829, 136)
        TL_PesoPuertaLabel.Name = "TL_PesoPuertaLabel"
        TL_PesoPuertaLabel.Size = New System.Drawing.Size(123, 17)
        TL_PesoPuertaLabel.TabIndex = 18
        TL_PesoPuertaLabel.Text = " Peso Puerta (kg):"
        '
        'TL_FirmesFechaLabel
        '
        TL_FirmesFechaLabel.AutoSize = True
        TL_FirmesFechaLabel.BackColor = System.Drawing.Color.LightGray
        TL_FirmesFechaLabel.Location = New System.Drawing.Point(10, 28)
        TL_FirmesFechaLabel.Name = "TL_FirmesFechaLabel"
        TL_FirmesFechaLabel.Size = New System.Drawing.Size(97, 17)
        TL_FirmesFechaLabel.TabIndex = 20
        TL_FirmesFechaLabel.Text = "Firmes Fecha:"
        '
        'TL_FirmesHoraLabel
        '
        TL_FirmesHoraLabel.AutoSize = True
        TL_FirmesHoraLabel.BackColor = System.Drawing.Color.LightGray
        TL_FirmesHoraLabel.Location = New System.Drawing.Point(10, 55)
        TL_FirmesHoraLabel.Name = "TL_FirmesHoraLabel"
        TL_FirmesHoraLabel.Size = New System.Drawing.Size(89, 17)
        TL_FirmesHoraLabel.TabIndex = 22
        TL_FirmesHoraLabel.Text = "Firmes Hora:"
        '
        'TL_FirmesLatLabel
        '
        TL_FirmesLatLabel.AutoSize = True
        TL_FirmesLatLabel.BackColor = System.Drawing.Color.LightGray
        TL_FirmesLatLabel.Location = New System.Drawing.Point(10, 83)
        TL_FirmesLatLabel.Name = "TL_FirmesLatLabel"
        TL_FirmesLatLabel.Size = New System.Drawing.Size(101, 17)
        TL_FirmesLatLabel.TabIndex = 24
        TL_FirmesLatLabel.Text = "Firmes Latitud:"
        '
        'TL_FirmesLongLabel
        '
        TL_FirmesLongLabel.AutoSize = True
        TL_FirmesLongLabel.BackColor = System.Drawing.Color.LightGray
        TL_FirmesLongLabel.Location = New System.Drawing.Point(10, 111)
        TL_FirmesLongLabel.Name = "TL_FirmesLongLabel"
        TL_FirmesLongLabel.Size = New System.Drawing.Size(113, 17)
        TL_FirmesLongLabel.TabIndex = 26
        TL_FirmesLongLabel.Text = "Firmes Longitud:"
        '
        'TL_FirmesProfLabel
        '
        TL_FirmesProfLabel.AutoSize = True
        TL_FirmesProfLabel.BackColor = System.Drawing.Color.LightGray
        TL_FirmesProfLabel.Location = New System.Drawing.Point(10, 139)
        TL_FirmesProfLabel.Name = "TL_FirmesProfLabel"
        TL_FirmesProfLabel.Size = New System.Drawing.Size(160, 17)
        TL_FirmesProfLabel.TabIndex = 28
        TL_FirmesProfLabel.Text = "Firmes Profundidad (m):"
        '
        'TL_ViradaFechaLabel
        '
        TL_ViradaFechaLabel.AutoSize = True
        TL_ViradaFechaLabel.BackColor = System.Drawing.Color.LightGray
        TL_ViradaFechaLabel.Location = New System.Drawing.Point(14, 19)
        TL_ViradaFechaLabel.Name = "TL_ViradaFechaLabel"
        TL_ViradaFechaLabel.Size = New System.Drawing.Size(96, 17)
        TL_ViradaFechaLabel.TabIndex = 30
        TL_ViradaFechaLabel.Text = "Virada Fecha:"
        '
        'TL_ViradaHoraLabel
        '
        TL_ViradaHoraLabel.AutoSize = True
        TL_ViradaHoraLabel.BackColor = System.Drawing.Color.LightGray
        TL_ViradaHoraLabel.Location = New System.Drawing.Point(14, 46)
        TL_ViradaHoraLabel.Name = "TL_ViradaHoraLabel"
        TL_ViradaHoraLabel.Size = New System.Drawing.Size(88, 17)
        TL_ViradaHoraLabel.TabIndex = 32
        TL_ViradaHoraLabel.Text = "Virada Hora:"
        '
        'TL_ViradaLatLabel
        '
        TL_ViradaLatLabel.AutoSize = True
        TL_ViradaLatLabel.BackColor = System.Drawing.Color.LightGray
        TL_ViradaLatLabel.Location = New System.Drawing.Point(14, 74)
        TL_ViradaLatLabel.Name = "TL_ViradaLatLabel"
        TL_ViradaLatLabel.Size = New System.Drawing.Size(100, 17)
        TL_ViradaLatLabel.TabIndex = 34
        TL_ViradaLatLabel.Text = "Virada Latitud:"
        '
        'TL_ViradaLongLabel
        '
        TL_ViradaLongLabel.AutoSize = True
        TL_ViradaLongLabel.BackColor = System.Drawing.Color.LightGray
        TL_ViradaLongLabel.Location = New System.Drawing.Point(14, 102)
        TL_ViradaLongLabel.Name = "TL_ViradaLongLabel"
        TL_ViradaLongLabel.Size = New System.Drawing.Size(112, 17)
        TL_ViradaLongLabel.TabIndex = 36
        TL_ViradaLongLabel.Text = "Virada Longitud:"
        '
        'TL_ViradaProfLabel
        '
        TL_ViradaProfLabel.AutoSize = True
        TL_ViradaProfLabel.BackColor = System.Drawing.Color.LightGray
        TL_ViradaProfLabel.Location = New System.Drawing.Point(14, 133)
        TL_ViradaProfLabel.Name = "TL_ViradaProfLabel"
        TL_ViradaProfLabel.Size = New System.Drawing.Size(159, 17)
        TL_ViradaProfLabel.TabIndex = 38
        TL_ViradaProfLabel.Text = "Virada Profundidad (m):"
        '
        'TL_RumboLabel
        '
        TL_RumboLabel.AutoSize = True
        TL_RumboLabel.BackColor = System.Drawing.Color.LightGray
        TL_RumboLabel.Location = New System.Drawing.Point(27, 28)
        TL_RumboLabel.Name = "TL_RumboLabel"
        TL_RumboLabel.Size = New System.Drawing.Size(57, 17)
        TL_RumboLabel.TabIndex = 40
        TL_RumboLabel.Text = "Rumbo:"
        '
        'TL_nudosVelocidadLabel
        '
        TL_nudosVelocidadLabel.AutoSize = True
        TL_nudosVelocidadLabel.BackColor = System.Drawing.Color.LightGray
        TL_nudosVelocidadLabel.Location = New System.Drawing.Point(27, 56)
        TL_nudosVelocidadLabel.Name = "TL_nudosVelocidadLabel"
        TL_nudosVelocidadLabel.Size = New System.Drawing.Size(119, 17)
        TL_nudosVelocidadLabel.TabIndex = 42
        TL_nudosVelocidadLabel.Text = "Nudos Velocidad:"
        '
        'TL_EstadoMetereologicoLabel
        '
        TL_EstadoMetereologicoLabel.AutoSize = True
        TL_EstadoMetereologicoLabel.BackColor = System.Drawing.Color.LightGray
        TL_EstadoMetereologicoLabel.Location = New System.Drawing.Point(27, 84)
        TL_EstadoMetereologicoLabel.Name = "TL_EstadoMetereologicoLabel"
        TL_EstadoMetereologicoLabel.Size = New System.Drawing.Size(149, 17)
        TL_EstadoMetereologicoLabel.TabIndex = 44
        TL_EstadoMetereologicoLabel.Text = "Estado Metereologico:"
        '
        'TL_EstadoDeLaMarLabel
        '
        TL_EstadoDeLaMarLabel.AutoSize = True
        TL_EstadoDeLaMarLabel.BackColor = System.Drawing.Color.LightGray
        TL_EstadoDeLaMarLabel.Location = New System.Drawing.Point(27, 112)
        TL_EstadoDeLaMarLabel.Name = "TL_EstadoDeLaMarLabel"
        TL_EstadoDeLaMarLabel.Size = New System.Drawing.Size(126, 17)
        TL_EstadoDeLaMarLabel.TabIndex = 46
        TL_EstadoDeLaMarLabel.Text = "Estado De La Mar:"
        '
        'TL_PesoTotalDescarteLabel
        '
        TL_PesoTotalDescarteLabel.AutoSize = True
        TL_PesoTotalDescarteLabel.BackColor = System.Drawing.Color.LightGray
        TL_PesoTotalDescarteLabel.Location = New System.Drawing.Point(27, 140)
        TL_PesoTotalDescarteLabel.Name = "TL_PesoTotalDescarteLabel"
        TL_PesoTotalDescarteLabel.Size = New System.Drawing.Size(141, 17)
        TL_PesoTotalDescarteLabel.TabIndex = 48
        TL_PesoTotalDescarteLabel.Text = "Peso Total Descarte:"
        '
        'TL_PesoTotalComercialLabel
        '
        TL_PesoTotalComercialLabel.AutoSize = True
        TL_PesoTotalComercialLabel.BackColor = System.Drawing.Color.LightGray
        TL_PesoTotalComercialLabel.Location = New System.Drawing.Point(27, 168)
        TL_PesoTotalComercialLabel.Name = "TL_PesoTotalComercialLabel"
        TL_PesoTotalComercialLabel.Size = New System.Drawing.Size(146, 17)
        TL_PesoTotalComercialLabel.TabIndex = 50
        TL_PesoTotalComercialLabel.Text = "Peso Total Comercial:"
        '
        'TL_CodObservadorLabel
        '
        TL_CodObservadorLabel.AutoSize = True
        TL_CodObservadorLabel.BackColor = System.Drawing.Color.LightGray
        TL_CodObservadorLabel.Location = New System.Drawing.Point(1044, 46)
        TL_CodObservadorLabel.Name = "TL_CodObservadorLabel"
        TL_CodObservadorLabel.Size = New System.Drawing.Size(137, 17)
        TL_CodObservadorLabel.TabIndex = 52
        TL_CodObservadorLabel.Text = "TL Cod Observador:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestión de lances de pesca"
        '
        'BDpescamedDataSet1
        '
        Me.BDpescamedDataSet1.DataSetName = "BDpescamedDataSet1"
        Me.BDpescamedDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LancesBindingSource
        '
        Me.LancesBindingSource.DataMember = "Lances"
        Me.LancesBindingSource.DataSource = Me.BDpescamedDataSet1
        '
        'LancesTableAdapter
        '
        Me.LancesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuquesTableAdapter = Nothing
        Me.TableAdapterManager.CTDTableAdapter = Nothing
        Me.TableAdapterManager.EspeciesTableAdapter = Nothing
        Me.TableAdapterManager.FaunisticaTableAdapter = Nothing
        Me.TableAdapterManager.LancesTableAdapter = Me.LancesTableAdapter
        Me.TableAdapterManager.ObservadoresTableAdapter = Nothing
        Me.TableAdapterManager.TallasTableAdapter = Nothing
        Me.TableAdapterManager.TrackingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TFG_Observadores.BDpescamedDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LancesBindingNavigator
        '
        Me.LancesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LancesBindingNavigator.BindingSource = Me.LancesBindingSource
        Me.LancesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LancesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LancesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.LancesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LancesBindingNavigatorSaveItem})
        Me.LancesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LancesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LancesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LancesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LancesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LancesBindingNavigator.Name = "LancesBindingNavigator"
        Me.LancesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LancesBindingNavigator.Size = New System.Drawing.Size(1262, 27)
        Me.LancesBindingNavigator.TabIndex = 4
        Me.LancesBindingNavigator.Text = "BindingNavigator1"
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
        'LancesBindingNavigatorSaveItem
        '
        Me.LancesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LancesBindingNavigatorSaveItem.Image = CType(resources.GetObject("LancesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LancesBindingNavigatorSaveItem.Name = "LancesBindingNavigatorSaveItem"
        Me.LancesBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.LancesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TL_CodLanceTextBox
        '
        Me.TL_CodLanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_CodLance", True))
        Me.TL_CodLanceTextBox.Location = New System.Drawing.Point(199, 100)
        Me.TL_CodLanceTextBox.Name = "TL_CodLanceTextBox"
        Me.TL_CodLanceTextBox.Size = New System.Drawing.Size(73, 22)
        Me.TL_CodLanceTextBox.TabIndex = 5
        '
        'TL_NuloTextBox
        '
        Me.TL_NuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_Nulo", True))
        Me.TL_NuloTextBox.Location = New System.Drawing.Point(386, 100)
        Me.TL_NuloTextBox.Name = "TL_NuloTextBox"
        Me.TL_NuloTextBox.Size = New System.Drawing.Size(36, 22)
        Me.TL_NuloTextBox.TabIndex = 7
        '
        'TL_CodBarcoTextBox
        '
        Me.TL_CodBarcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_CodBarco", True))
        Me.TL_CodBarcoTextBox.Location = New System.Drawing.Point(564, 97)
        Me.TL_CodBarcoTextBox.Name = "TL_CodBarcoTextBox"
        Me.TL_CodBarcoTextBox.Size = New System.Drawing.Size(53, 22)
        Me.TL_CodBarcoTextBox.TabIndex = 9
        '
        'TL_FechaLanceDateTimePicker
        '
        Me.TL_FechaLanceDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LancesBindingSource, "TL_FechaLance", True))
        Me.TL_FechaLanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TL_FechaLanceDateTimePicker.Location = New System.Drawing.Point(941, 100)
        Me.TL_FechaLanceDateTimePicker.Name = "TL_FechaLanceDateTimePicker"
        Me.TL_FechaLanceDateTimePicker.Size = New System.Drawing.Size(142, 22)
        Me.TL_FechaLanceDateTimePicker.TabIndex = 11
        '
        'TL_NumLanceTextBox
        '
        Me.TL_NumLanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_NumLance", True))
        Me.TL_NumLanceTextBox.Location = New System.Drawing.Point(1189, 100)
        Me.TL_NumLanceTextBox.Name = "TL_NumLanceTextBox"
        Me.TL_NumLanceTextBox.Size = New System.Drawing.Size(44, 22)
        Me.TL_NumLanceTextBox.TabIndex = 13
        '
        'TL_TipoPuertaTextBox
        '
        Me.TL_TipoPuertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_TipoPuerta", True))
        Me.TL_TipoPuertaTextBox.Location = New System.Drawing.Point(588, 133)
        Me.TL_TipoPuertaTextBox.Name = "TL_TipoPuertaTextBox"
        Me.TL_TipoPuertaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TL_TipoPuertaTextBox.TabIndex = 17
        '
        'TL_PesoPuertaTextBox
        '
        Me.TL_PesoPuertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_PesoPuerta", True))
        Me.TL_PesoPuertaTextBox.Location = New System.Drawing.Point(958, 133)
        Me.TL_PesoPuertaTextBox.Name = "TL_PesoPuertaTextBox"
        Me.TL_PesoPuertaTextBox.Size = New System.Drawing.Size(52, 22)
        Me.TL_PesoPuertaTextBox.TabIndex = 19
        '
        'TL_FirmesFechaDateTimePicker
        '
        Me.TL_FirmesFechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LancesBindingSource, "TL_FirmesFecha", True))
        Me.TL_FirmesFechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TL_FirmesFechaDateTimePicker.Location = New System.Drawing.Point(144, 26)
        Me.TL_FirmesFechaDateTimePicker.Name = "TL_FirmesFechaDateTimePicker"
        Me.TL_FirmesFechaDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.TL_FirmesFechaDateTimePicker.TabIndex = 21
        '
        'TL_FirmesProfTextBox
        '
        Me.TL_FirmesProfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_FirmesProf", True))
        Me.TL_FirmesProfTextBox.Location = New System.Drawing.Point(174, 136)
        Me.TL_FirmesProfTextBox.Name = "TL_FirmesProfTextBox"
        Me.TL_FirmesProfTextBox.Size = New System.Drawing.Size(65, 22)
        Me.TL_FirmesProfTextBox.TabIndex = 29
        '
        'TL_ViradaFechaDateTimePicker
        '
        Me.TL_ViradaFechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LancesBindingSource, "TL_ViradaFecha", True))
        Me.TL_ViradaFechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TL_ViradaFechaDateTimePicker.Location = New System.Drawing.Point(151, 15)
        Me.TL_ViradaFechaDateTimePicker.Name = "TL_ViradaFechaDateTimePicker"
        Me.TL_ViradaFechaDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.TL_ViradaFechaDateTimePicker.TabIndex = 31
        '
        'TL_ViradaProfTextBox
        '
        Me.TL_ViradaProfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_ViradaProf", True))
        Me.TL_ViradaProfTextBox.Location = New System.Drawing.Point(179, 130)
        Me.TL_ViradaProfTextBox.Name = "TL_ViradaProfTextBox"
        Me.TL_ViradaProfTextBox.Size = New System.Drawing.Size(39, 22)
        Me.TL_ViradaProfTextBox.TabIndex = 39
        '
        'TL_RumboTextBox
        '
        Me.TL_RumboTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_Rumbo", True))
        Me.TL_RumboTextBox.Location = New System.Drawing.Point(203, 25)
        Me.TL_RumboTextBox.Name = "TL_RumboTextBox"
        Me.TL_RumboTextBox.Size = New System.Drawing.Size(56, 22)
        Me.TL_RumboTextBox.TabIndex = 41
        '
        'TL_nudosVelocidadTextBox
        '
        Me.TL_nudosVelocidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_nudosVelocidad", True))
        Me.TL_nudosVelocidadTextBox.Location = New System.Drawing.Point(203, 53)
        Me.TL_nudosVelocidadTextBox.Name = "TL_nudosVelocidadTextBox"
        Me.TL_nudosVelocidadTextBox.Size = New System.Drawing.Size(56, 22)
        Me.TL_nudosVelocidadTextBox.TabIndex = 43
        '
        'TL_EstadoMetereologicoTextBox
        '
        Me.TL_EstadoMetereologicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_EstadoMetereologico", True))
        Me.TL_EstadoMetereologicoTextBox.Location = New System.Drawing.Point(203, 81)
        Me.TL_EstadoMetereologicoTextBox.Name = "TL_EstadoMetereologicoTextBox"
        Me.TL_EstadoMetereologicoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TL_EstadoMetereologicoTextBox.TabIndex = 45
        '
        'TL_EstadoDeLaMarTextBox
        '
        Me.TL_EstadoDeLaMarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_EstadoDeLaMar", True))
        Me.TL_EstadoDeLaMarTextBox.Location = New System.Drawing.Point(203, 109)
        Me.TL_EstadoDeLaMarTextBox.Name = "TL_EstadoDeLaMarTextBox"
        Me.TL_EstadoDeLaMarTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TL_EstadoDeLaMarTextBox.TabIndex = 47
        '
        'TL_PesoTotalDescarteTextBox
        '
        Me.TL_PesoTotalDescarteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_PesoTotalDescarte", True))
        Me.TL_PesoTotalDescarteTextBox.Location = New System.Drawing.Point(203, 137)
        Me.TL_PesoTotalDescarteTextBox.Name = "TL_PesoTotalDescarteTextBox"
        Me.TL_PesoTotalDescarteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TL_PesoTotalDescarteTextBox.TabIndex = 49
        '
        'TL_PesoTotalComercialTextBox
        '
        Me.TL_PesoTotalComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_PesoTotalComercial", True))
        Me.TL_PesoTotalComercialTextBox.Location = New System.Drawing.Point(203, 165)
        Me.TL_PesoTotalComercialTextBox.Name = "TL_PesoTotalComercialTextBox"
        Me.TL_PesoTotalComercialTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TL_PesoTotalComercialTextBox.TabIndex = 51
        '
        'TL_CodObservadorTextBox
        '
        Me.TL_CodObservadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_CodObservador", True))
        Me.TL_CodObservadorTextBox.Location = New System.Drawing.Point(1189, 41)
        Me.TL_CodObservadorTextBox.Name = "TL_CodObservadorTextBox"
        Me.TL_CodObservadorTextBox.Size = New System.Drawing.Size(61, 22)
        Me.TL_CodObservadorTextBox.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxFirmesLong)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxFirmesLat)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxHoraFirmes)
        Me.GroupBox1.Controls.Add(TL_FirmesFechaLabel)
        Me.GroupBox1.Controls.Add(Me.TL_FirmesFechaDateTimePicker)
        Me.GroupBox1.Controls.Add(TL_FirmesHoraLabel)
        Me.GroupBox1.Controls.Add(TL_FirmesLatLabel)
        Me.GroupBox1.Controls.Add(TL_FirmesLongLabel)
        Me.GroupBox1.Controls.Add(TL_FirmesProfLabel)
        Me.GroupBox1.Controls.Add(Me.TL_FirmesProfTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 205)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FIRMES"
        '
        'MaskedTextBoxFirmesLong
        '
        Me.MaskedTextBoxFirmesLong.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_FirmesLong", True))
        Me.MaskedTextBoxFirmesLong.Location = New System.Drawing.Point(144, 111)
        Me.MaskedTextBoxFirmesLong.Mask = "00º00.000W"
        Me.MaskedTextBoxFirmesLong.Name = "MaskedTextBoxFirmesLong"
        Me.MaskedTextBoxFirmesLong.Size = New System.Drawing.Size(95, 22)
        Me.MaskedTextBoxFirmesLong.TabIndex = 64
        '
        'MaskedTextBoxFirmesLat
        '
        Me.MaskedTextBoxFirmesLat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_FirmesLat", True))
        Me.MaskedTextBoxFirmesLat.Location = New System.Drawing.Point(144, 81)
        Me.MaskedTextBoxFirmesLat.Mask = "00º00.000N"
        Me.MaskedTextBoxFirmesLat.Name = "MaskedTextBoxFirmesLat"
        Me.MaskedTextBoxFirmesLat.Size = New System.Drawing.Size(95, 22)
        Me.MaskedTextBoxFirmesLat.TabIndex = 64
        '
        'MaskedTextBoxHoraFirmes
        '
        Me.MaskedTextBoxHoraFirmes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_FirmesHora", True))
        Me.MaskedTextBoxHoraFirmes.Location = New System.Drawing.Point(144, 53)
        Me.MaskedTextBoxHoraFirmes.Mask = "00:00"
        Me.MaskedTextBoxHoraFirmes.Name = "MaskedTextBoxHoraFirmes"
        Me.MaskedTextBoxHoraFirmes.Size = New System.Drawing.Size(50, 22)
        Me.MaskedTextBoxHoraFirmes.TabIndex = 64
        Me.MaskedTextBoxHoraFirmes.ValidatingType = GetType(Date)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxViradaLong)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxViradaLat)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxViradaHora)
        Me.GroupBox2.Controls.Add(TL_ViradaFechaLabel)
        Me.GroupBox2.Controls.Add(Me.TL_ViradaFechaDateTimePicker)
        Me.GroupBox2.Controls.Add(TL_ViradaHoraLabel)
        Me.GroupBox2.Controls.Add(TL_ViradaLatLabel)
        Me.GroupBox2.Controls.Add(TL_ViradaLongLabel)
        Me.GroupBox2.Controls.Add(TL_ViradaProfLabel)
        Me.GroupBox2.Controls.Add(Me.TL_ViradaProfTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(427, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 205)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VIRADA"
        '
        'MaskedTextBoxViradaLong
        '
        Me.MaskedTextBoxViradaLong.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_ViradaLong", True))
        Me.MaskedTextBoxViradaLong.Location = New System.Drawing.Point(151, 99)
        Me.MaskedTextBoxViradaLong.Mask = "00º00.000W"
        Me.MaskedTextBoxViradaLong.Name = "MaskedTextBoxViradaLong"
        Me.MaskedTextBoxViradaLong.Size = New System.Drawing.Size(93, 22)
        Me.MaskedTextBoxViradaLong.TabIndex = 64
        '
        'MaskedTextBoxViradaLat
        '
        Me.MaskedTextBoxViradaLat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_ViradaLat", True))
        Me.MaskedTextBoxViradaLat.Location = New System.Drawing.Point(151, 71)
        Me.MaskedTextBoxViradaLat.Mask = "00º00.000N"
        Me.MaskedTextBoxViradaLat.Name = "MaskedTextBoxViradaLat"
        Me.MaskedTextBoxViradaLat.Size = New System.Drawing.Size(93, 22)
        Me.MaskedTextBoxViradaLat.TabIndex = 64
        '
        'MaskedTextBoxViradaHora
        '
        Me.MaskedTextBoxViradaHora.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_ViradaHora", True))
        Me.MaskedTextBoxViradaHora.Location = New System.Drawing.Point(151, 43)
        Me.MaskedTextBoxViradaHora.Mask = "00:00"
        Me.MaskedTextBoxViradaHora.Name = "MaskedTextBoxViradaHora"
        Me.MaskedTextBoxViradaHora.Size = New System.Drawing.Size(59, 22)
        Me.MaskedTextBoxViradaHora.TabIndex = 64
        Me.MaskedTextBoxViradaHora.ValidatingType = GetType(Date)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(TL_RumboLabel)
        Me.GroupBox3.Controls.Add(Me.TL_RumboTextBox)
        Me.GroupBox3.Controls.Add(TL_nudosVelocidadLabel)
        Me.GroupBox3.Controls.Add(Me.TL_nudosVelocidadTextBox)
        Me.GroupBox3.Controls.Add(TL_EstadoMetereologicoLabel)
        Me.GroupBox3.Controls.Add(Me.TL_EstadoMetereologicoTextBox)
        Me.GroupBox3.Controls.Add(TL_EstadoDeLaMarLabel)
        Me.GroupBox3.Controls.Add(Me.TL_EstadoDeLaMarTextBox)
        Me.GroupBox3.Controls.Add(TL_PesoTotalDescarteLabel)
        Me.GroupBox3.Controls.Add(Me.TL_PesoTotalDescarteTextBox)
        Me.GroupBox3.Controls.Add(TL_PesoTotalComercialLabel)
        Me.GroupBox3.Controls.Add(Me.TL_PesoTotalComercialTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(824, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(426, 205)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OTROS DATOS"
        '
        'TL_TipoArteTextBox
        '
        Me.TL_TipoArteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LancesBindingSource, "TL_TipoArte", True))
        Me.TL_TipoArteTextBox.Location = New System.Drawing.Point(171, 133)
        Me.TL_TipoArteTextBox.Name = "TL_TipoArteTextBox"
        Me.TL_TipoArteTextBox.Size = New System.Drawing.Size(43, 22)
        Me.TL_TipoArteTextBox.TabIndex = 57
        '
        'ButtonNextLance
        '
        Me.ButtonNextLance.Location = New System.Drawing.Point(220, 419)
        Me.ButtonNextLance.Name = "ButtonNextLance"
        Me.ButtonNextLance.Size = New System.Drawing.Size(60, 27)
        Me.ButtonNextLance.TabIndex = 58
        Me.ButtonNextLance.Text = ">"
        Me.ButtonNextLance.UseVisualStyleBackColor = True
        '
        'ButtonPrevioLance
        '
        Me.ButtonPrevioLance.Location = New System.Drawing.Point(152, 419)
        Me.ButtonPrevioLance.Name = "ButtonPrevioLance"
        Me.ButtonPrevioLance.Size = New System.Drawing.Size(53, 27)
        Me.ButtonPrevioLance.TabIndex = 59
        Me.ButtonPrevioLance.Text = "<"
        Me.ButtonPrevioLance.UseVisualStyleBackColor = True
        '
        'ButtonLanceUltimo
        '
        Me.ButtonLanceUltimo.Location = New System.Drawing.Point(295, 419)
        Me.ButtonLanceUltimo.Name = "ButtonLanceUltimo"
        Me.ButtonLanceUltimo.Size = New System.Drawing.Size(53, 27)
        Me.ButtonLanceUltimo.TabIndex = 60
        Me.ButtonLanceUltimo.Text = ">|"
        Me.ButtonLanceUltimo.UseVisualStyleBackColor = True
        '
        'ButtonLancePrimero
        '
        Me.ButtonLancePrimero.Location = New System.Drawing.Point(77, 419)
        Me.ButtonLancePrimero.Name = "ButtonLancePrimero"
        Me.ButtonLancePrimero.Size = New System.Drawing.Size(60, 27)
        Me.ButtonLancePrimero.TabIndex = 61
        Me.ButtonLancePrimero.Text = "|<"
        Me.ButtonLancePrimero.UseVisualStyleBackColor = True
        '
        'ComboBoxTiposArte
        '
        Me.ComboBoxTiposArte.FormattingEnabled = True
        Me.ComboBoxTiposArte.Location = New System.Drawing.Point(220, 132)
        Me.ComboBoxTiposArte.Name = "ComboBoxTiposArte"
        Me.ComboBoxTiposArte.Size = New System.Drawing.Size(238, 24)
        Me.ComboBoxTiposArte.TabIndex = 62
        '
        'ComboBoxBarcos
        '
        Me.ComboBoxBarcos.FormattingEnabled = True
        Me.ComboBoxBarcos.Location = New System.Drawing.Point(623, 97)
        Me.ComboBoxBarcos.Name = "ComboBoxBarcos"
        Me.ComboBoxBarcos.Size = New System.Drawing.Size(184, 24)
        Me.ComboBoxBarcos.TabIndex = 63
        '
        'BotonNuevoLance
        '
        Me.BotonNuevoLance.Location = New System.Drawing.Point(450, 419)
        Me.BotonNuevoLance.Name = "BotonNuevoLance"
        Me.BotonNuevoLance.Size = New System.Drawing.Size(85, 27)
        Me.BotonNuevoLance.TabIndex = 64
        Me.BotonNuevoLance.Text = "Nuevo"
        Me.BotonNuevoLance.UseVisualStyleBackColor = True
        '
        'FaunisticaBindingSource
        '
        Me.FaunisticaBindingSource.DataMember = "Faunistica"
        Me.FaunisticaBindingSource.DataSource = Me.BDpescamedDataSet1
        '
        'FaunisticaTableAdapter
        '
        Me.FaunisticaTableAdapter.ClearBeforeFill = True
        '
        'FaunisticaDataGridView
        '
        Me.FaunisticaDataGridView.AutoGenerateColumns = False
        Me.FaunisticaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FaunisticaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewComboBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.FaunisticaDataGridView.DataSource = Me.FaunisticaBindingSource
        Me.FaunisticaDataGridView.Location = New System.Drawing.Point(51, 493)
        Me.FaunisticaDataGridView.Name = "FaunisticaDataGridView"
        Me.FaunisticaDataGridView.RowTemplate.Height = 24
        Me.FaunisticaDataGridView.Size = New System.Drawing.Size(1182, 364)
        Me.FaunisticaDataGridView.TabIndex = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TF_CodLance"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TF_CodLance"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "TF_CodEspecie"
        Me.DataGridViewComboBoxColumn2.DataSource = Me.EspeciesBindingSource
        Me.DataGridViewComboBoxColumn2.DisplayMember = "TE_NomCientifico"
        Me.DataGridViewComboBoxColumn2.HeaderText = "TF_CodEspecie"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn2.ValueMember = "TE_CodEspecie"
        '
        'EspeciesBindingSource
        '
        Me.EspeciesBindingSource.DataMember = "Especies"
        Me.EspeciesBindingSource.DataSource = Me.BDpescamedDataSet1
        Me.EspeciesBindingSource.Sort = "TE_nomcientifico"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TF_Fraccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TF_Fraccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TF_PesoTotal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TF_PesoTotal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TF_NumEjemplar"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TF_NumEjemplar"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TF_PesoMuestreado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TF_PesoMuestreado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TF_NumEjemplMuestreados"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TF_NumEjemplMuestreados"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TF_TallaInicial"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TF_TallaInicial"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TF_TallaFinal"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TF_TallaFinal"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PowderBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 22)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Listado faunístico"
        '
        'EspeciesTableAdapter
        '
        Me.EspeciesTableAdapter.ClearBeforeFill = True
        '
        'BotonActualizaFaunistica
        '
        Me.BotonActualizaFaunistica.Location = New System.Drawing.Point(52, 863)
        Me.BotonActualizaFaunistica.Name = "BotonActualizaFaunistica"
        Me.BotonActualizaFaunistica.Size = New System.Drawing.Size(137, 36)
        Me.BotonActualizaFaunistica.TabIndex = 66
        Me.BotonActualizaFaunistica.Text = "Aceptar cambios"
        Me.BotonActualizaFaunistica.UseVisualStyleBackColor = True
        '
        'BotonEliminaEspecieFaunistica
        '
        Me.BotonEliminaEspecieFaunistica.Location = New System.Drawing.Point(205, 864)
        Me.BotonEliminaEspecieFaunistica.Name = "BotonEliminaEspecieFaunistica"
        Me.BotonEliminaEspecieFaunistica.Size = New System.Drawing.Size(155, 35)
        Me.BotonEliminaEspecieFaunistica.TabIndex = 67
        Me.BotonEliminaEspecieFaunistica.Text = "Elimina Especie"
        Me.BotonEliminaEspecieFaunistica.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1044, 864)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 17)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "(ESC) para cancelar edición"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(371, 865)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 34)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Gestión de Faunísticas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonAbreFormularioCTD
        '
        Me.BotonAbreFormularioCTD.Location = New System.Drawing.Point(654, 419)
        Me.BotonAbreFormularioCTD.Name = "BotonAbreFormularioCTD"
        Me.BotonAbreFormularioCTD.Size = New System.Drawing.Size(80, 27)
        Me.BotonAbreFormularioCTD.TabIndex = 70
        Me.BotonAbreFormularioCTD.Text = "CTD"
        Me.BotonAbreFormularioCTD.UseVisualStyleBackColor = True
        '
        'BotonAbreFormularioGPS
        '
        Me.BotonAbreFormularioGPS.Location = New System.Drawing.Point(550, 419)
        Me.BotonAbreFormularioGPS.Name = "BotonAbreFormularioGPS"
        Me.BotonAbreFormularioGPS.Size = New System.Drawing.Size(89, 27)
        Me.BotonAbreFormularioGPS.TabIndex = 71
        Me.BotonAbreFormularioGPS.Text = "GPS"
        Me.BotonAbreFormularioGPS.UseVisualStyleBackColor = True
        '
        'BotonAceptaCambios
        '
        Me.BotonAceptaCambios.Location = New System.Drawing.Point(949, 419)
        Me.BotonAceptaCambios.Name = "BotonAceptaCambios"
        Me.BotonAceptaCambios.Size = New System.Drawing.Size(233, 27)
        Me.BotonAceptaCambios.TabIndex = 72
        Me.BotonAceptaCambios.Text = "Confirmar Cambios"
        Me.BotonAceptaCambios.UseVisualStyleBackColor = True
        '
        'BotonBorrarLance
        '
        Me.BotonBorrarLance.ForeColor = System.Drawing.Color.Red
        Me.BotonBorrarLance.Location = New System.Drawing.Point(749, 419)
        Me.BotonBorrarLance.Name = "BotonBorrarLance"
        Me.BotonBorrarLance.Size = New System.Drawing.Size(85, 27)
        Me.BotonBorrarLance.TabIndex = 73
        Me.BotonBorrarLance.Text = "Borrar"
        Me.BotonBorrarLance.UseVisualStyleBackColor = True
        '
        'RefrescaListaFaunistica
        '
        Me.RefrescaListaFaunistica.Location = New System.Drawing.Point(578, 865)
        Me.RefrescaListaFaunistica.Name = "RefrescaListaFaunistica"
        Me.RefrescaListaFaunistica.Size = New System.Drawing.Size(187, 34)
        Me.RefrescaListaFaunistica.TabIndex = 74
        Me.RefrescaListaFaunistica.Text = "Refresca Lista"
        Me.RefrescaListaFaunistica.UseVisualStyleBackColor = True
        '
        'BotonBuscarLance
        '
        Me.BotonBuscarLance.ForeColor = System.Drawing.Color.Black
        Me.BotonBuscarLance.Location = New System.Drawing.Point(849, 419)
        Me.BotonBuscarLance.Name = "BotonBuscarLance"
        Me.BotonBuscarLance.Size = New System.Drawing.Size(85, 27)
        Me.BotonBuscarLance.TabIndex = 75
        Me.BotonBuscarLance.Text = "Buscar"
        Me.BotonBuscarLance.UseVisualStyleBackColor = True
        '
        'BotonIrA
        '
        Me.BotonIrA.Location = New System.Drawing.Point(363, 419)
        Me.BotonIrA.Name = "BotonIrA"
        Me.BotonIrA.Size = New System.Drawing.Size(72, 27)
        Me.BotonIrA.TabIndex = 76
        Me.BotonIrA.Text = "Ir a "
        Me.BotonIrA.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 915)
        Me.Controls.Add(Me.BotonIrA)
        Me.Controls.Add(Me.BotonBuscarLance)
        Me.Controls.Add(Me.RefrescaListaFaunistica)
        Me.Controls.Add(Me.BotonBorrarLance)
        Me.Controls.Add(Me.BotonAceptaCambios)
        Me.Controls.Add(Me.BotonAbreFormularioGPS)
        Me.Controls.Add(Me.BotonAbreFormularioCTD)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BotonEliminaEspecieFaunistica)
        Me.Controls.Add(Me.BotonActualizaFaunistica)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FaunisticaDataGridView)
        Me.Controls.Add(Me.BotonNuevoLance)
        Me.Controls.Add(Me.ComboBoxBarcos)
        Me.Controls.Add(Me.ComboBoxTiposArte)
        Me.Controls.Add(Me.ButtonLancePrimero)
        Me.Controls.Add(Me.ButtonLanceUltimo)
        Me.Controls.Add(Me.ButtonPrevioLance)
        Me.Controls.Add(Me.ButtonNextLance)
        Me.Controls.Add(Me.TL_TipoArteTextBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(TL_CodLanceLabel)
        Me.Controls.Add(Me.TL_CodLanceTextBox)
        Me.Controls.Add(TL_NuloLabel)
        Me.Controls.Add(Me.TL_NuloTextBox)
        Me.Controls.Add(TL_CodBarcoLabel)
        Me.Controls.Add(Me.TL_CodBarcoTextBox)
        Me.Controls.Add(TL_FechaLanceLabel)
        Me.Controls.Add(Me.TL_FechaLanceDateTimePicker)
        Me.Controls.Add(TL_NumLanceLabel)
        Me.Controls.Add(Me.TL_NumLanceTextBox)
        Me.Controls.Add(TL_TipoArteLabel)
        Me.Controls.Add(TL_TipoPuertaLabel)
        Me.Controls.Add(Me.TL_TipoPuertaTextBox)
        Me.Controls.Add(TL_PesoPuertaLabel)
        Me.Controls.Add(Me.TL_PesoPuertaTextBox)
        Me.Controls.Add(TL_CodObservadorLabel)
        Me.Controls.Add(Me.TL_CodObservadorTextBox)
        Me.Controls.Add(Me.LancesBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de lances de pesca"
        CType(Me.BDpescamedDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LancesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LancesBindingNavigator.ResumeLayout(False)
        Me.LancesBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FaunisticaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaunisticaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspeciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BDpescamedDataSet1 As TFG_Observadores.BDpescamedDataSet1
    Friend WithEvents LancesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LancesTableAdapter As TFG_Observadores.BDpescamedDataSet1TableAdapters.LancesTableAdapter
    Friend WithEvents TableAdapterManager As TFG_Observadores.BDpescamedDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents LancesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LancesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TL_CodLanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_NuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_CodBarcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_FechaLanceDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TL_NumLanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_TipoPuertaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_PesoPuertaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_FirmesFechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TL_FirmesProfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_ViradaFechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TL_ViradaProfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_RumboTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_nudosVelocidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_EstadoMetereologicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_EstadoDeLaMarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_PesoTotalDescarteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_PesoTotalComercialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TL_CodObservadorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TL_TipoArteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNextLance As System.Windows.Forms.Button
    Friend WithEvents ButtonPrevioLance As System.Windows.Forms.Button
    Friend WithEvents ButtonLanceUltimo As System.Windows.Forms.Button
    Friend WithEvents ButtonLancePrimero As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTiposArte As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBarcos As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBoxHoraFirmes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxFirmesLat As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxFirmesLong As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxViradaLat As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxViradaHora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxViradaLong As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BotonNuevoLance As System.Windows.Forms.Button
    Friend WithEvents FaunisticaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FaunisticaTableAdapter As TFG_Observadores.BDpescamedDataSet1TableAdapters.FaunisticaTableAdapter
    Friend WithEvents FaunisticaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EspeciesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EspeciesTableAdapter As TFG_Observadores.BDpescamedDataSet1TableAdapters.EspeciesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BotonActualizaFaunistica As System.Windows.Forms.Button
    Friend WithEvents BotonEliminaEspecieFaunistica As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BotonAbreFormularioCTD As System.Windows.Forms.Button
    Friend WithEvents BotonAbreFormularioGPS As System.Windows.Forms.Button
    Friend WithEvents BotonAceptaCambios As System.Windows.Forms.Button
    Friend WithEvents BotonBorrarLance As System.Windows.Forms.Button
    Friend WithEvents RefrescaListaFaunistica As System.Windows.Forms.Button
    Friend WithEvents BotonBuscarLance As System.Windows.Forms.Button
    Friend WithEvents BotonIrA As System.Windows.Forms.Button
End Class
