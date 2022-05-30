<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_gestionnier
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
        Dim Nom_gestionLabel As System.Windows.Forms.Label
        Dim Adr_gestionLabel As System.Windows.Forms.Label
        Dim N_rapp_dec_ventLabel As System.Windows.Forms.Label
        Dim Dat_rapp_dec_ventLabel As System.Windows.Forms.Label
        Dim Aut_sor_rapp_dec_ventLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_gestionnier))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.GestionnaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionnaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.GestionnaireTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.GestionnaireBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GestionnaireBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GestionnaireDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_gestionTextBox = New System.Windows.Forms.TextBox()
        Me.Adr_gestionTextBox = New System.Windows.Forms.TextBox()
        Me.N_rapp_dec_ventTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_rapp_dec_ventDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Aut_sor_rapp_dec_ventTextBox = New System.Windows.Forms.TextBox()
        Nom_gestionLabel = New System.Windows.Forms.Label()
        Adr_gestionLabel = New System.Windows.Forms.Label()
        N_rapp_dec_ventLabel = New System.Windows.Forms.Label()
        Dat_rapp_dec_ventLabel = New System.Windows.Forms.Label()
        Aut_sor_rapp_dec_ventLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionnaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionnaireBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GestionnaireBindingNavigator.SuspendLayout()
        CType(Me.GestionnaireDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nom_gestionLabel
        '
        Nom_gestionLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Nom_gestionLabel.AutoSize = True
        Nom_gestionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_gestionLabel.ForeColor = System.Drawing.Color.White
        Nom_gestionLabel.Location = New System.Drawing.Point(284, 74)
        Nom_gestionLabel.Name = "Nom_gestionLabel"
        Nom_gestionLabel.Size = New System.Drawing.Size(82, 20)
        Nom_gestionLabel.TabIndex = 4
        Nom_gestionLabel.Text = "اسم المتصرف"
        '
        'Adr_gestionLabel
        '
        Adr_gestionLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Adr_gestionLabel.AutoSize = True
        Adr_gestionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Adr_gestionLabel.ForeColor = System.Drawing.Color.White
        Adr_gestionLabel.Location = New System.Drawing.Point(284, 125)
        Adr_gestionLabel.Name = "Adr_gestionLabel"
        Adr_gestionLabel.Size = New System.Drawing.Size(82, 20)
        Adr_gestionLabel.TabIndex = 6
        Adr_gestionLabel.Text = "مقر المتصرف"
        '
        'N_rapp_dec_ventLabel
        '
        N_rapp_dec_ventLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        N_rapp_dec_ventLabel.AutoSize = True
        N_rapp_dec_ventLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_rapp_dec_ventLabel.ForeColor = System.Drawing.Color.White
        N_rapp_dec_ventLabel.Location = New System.Drawing.Point(718, 74)
        N_rapp_dec_ventLabel.Name = "N_rapp_dec_ventLabel"
        N_rapp_dec_ventLabel.Size = New System.Drawing.Size(119, 20)
        N_rapp_dec_ventLabel.TabIndex = 8
        N_rapp_dec_ventLabel.Text = "رقم مقرر شروط البيع"
        '
        'Dat_rapp_dec_ventLabel
        '
        Dat_rapp_dec_ventLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Dat_rapp_dec_ventLabel.AutoSize = True
        Dat_rapp_dec_ventLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_rapp_dec_ventLabel.ForeColor = System.Drawing.Color.White
        Dat_rapp_dec_ventLabel.Location = New System.Drawing.Point(710, 125)
        Dat_rapp_dec_ventLabel.Name = "Dat_rapp_dec_ventLabel"
        Dat_rapp_dec_ventLabel.Size = New System.Drawing.Size(127, 20)
        Dat_rapp_dec_ventLabel.TabIndex = 10
        Dat_rapp_dec_ventLabel.Text = "تاريخ مقررشروط البيع"
        '
        'Aut_sor_rapp_dec_ventLabel
        '
        Aut_sor_rapp_dec_ventLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Aut_sor_rapp_dec_ventLabel.AutoSize = True
        Aut_sor_rapp_dec_ventLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Aut_sor_rapp_dec_ventLabel.ForeColor = System.Drawing.Color.White
        Aut_sor_rapp_dec_ventLabel.Location = New System.Drawing.Point(454, 186)
        Aut_sor_rapp_dec_ventLabel.Name = "Aut_sor_rapp_dec_ventLabel"
        Aut_sor_rapp_dec_ventLabel.Size = New System.Drawing.Size(198, 20)
        Aut_sor_rapp_dec_ventLabel.TabIndex = 12
        Aut_sor_rapp_dec_ventLabel.Text = "السلطات الصادرة للمقرر شروط البيع"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GestionnaireBindingSource
        '
        Me.GestionnaireBindingSource.DataMember = "Gestionnaire"
        Me.GestionnaireBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'GestionnaireTableAdapter
        '
        Me.GestionnaireTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Nothing
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager.Attestation_paiemnet_loyerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiaireTableAdapter = Nothing
        Me.TableAdapterManager.Calendrier_valueur_initaleTableAdapter = Nothing
        Me.TableAdapterManager.Certificat_engagement_achatTableAdapter = Nothing
        Me.TableAdapterManager.Commission_cession_immobiliereTableAdapter = Nothing
        Me.TableAdapterManager.CommuneTableAdapter = Nothing
        Me.TableAdapterManager.DairaTableAdapter = Nothing
        Me.TableAdapterManager.Demande_acquisitionTableAdapter = Nothing
        Me.TableAdapterManager.DirecteurTableAdapter = Nothing
        Me.TableAdapterManager.Droits_de_propriete_de_etatTableAdapter = Nothing
        Me.TableAdapterManager.Echencer_VersementTableAdapter = Nothing
        Me.TableAdapterManager.GestionnaireTableAdapter = Me.GestionnaireTableAdapter
        Me.TableAdapterManager.LocalTableAdapter = Nothing
        Me.TableAdapterManager.PV_Commession_CessionTableAdapter = Nothing
        Me.TableAdapterManager.QuartierTableAdapter = Nothing
        Me.TableAdapterManager.Rapport_evaluationTableAdapter = Nothing
        Me.TableAdapterManager.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Nothing
        '
        'GestionnaireBindingNavigator
        '
        Me.GestionnaireBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GestionnaireBindingNavigator.BindingSource = Me.GestionnaireBindingSource
        Me.GestionnaireBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GestionnaireBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GestionnaireBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.GestionnaireBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GestionnaireBindingNavigatorSaveItem})
        Me.GestionnaireBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GestionnaireBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GestionnaireBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GestionnaireBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GestionnaireBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GestionnaireBindingNavigator.Name = "GestionnaireBindingNavigator"
        Me.GestionnaireBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GestionnaireBindingNavigator.Size = New System.Drawing.Size(913, 31)
        Me.GestionnaireBindingNavigator.TabIndex = 0
        Me.GestionnaireBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'GestionnaireBindingNavigatorSaveItem
        '
        Me.GestionnaireBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GestionnaireBindingNavigatorSaveItem.Image = CType(resources.GetObject("GestionnaireBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GestionnaireBindingNavigatorSaveItem.Name = "GestionnaireBindingNavigatorSaveItem"
        Me.GestionnaireBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.GestionnaireBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GestionnaireDataGridView
        '
        Me.GestionnaireDataGridView.AutoGenerateColumns = False
        Me.GestionnaireDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GestionnaireDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.GestionnaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GestionnaireDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.GestionnaireDataGridView.DataSource = Me.GestionnaireBindingSource
        Me.GestionnaireDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GestionnaireDataGridView.Location = New System.Drawing.Point(0, 269)
        Me.GestionnaireDataGridView.Name = "GestionnaireDataGridView"
        Me.GestionnaireDataGridView.ReadOnly = True
        Me.GestionnaireDataGridView.Size = New System.Drawing.Size(913, 220)
        Me.GestionnaireDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_gestion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_gestion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_gestion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom_gestion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Adr_gestion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Adr_gestion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "N_rapp_dec_vent"
        Me.DataGridViewTextBoxColumn4.HeaderText = "N_rapp_dec_vent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Dat_rapp_dec_vent"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dat_rapp_dec_vent"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Aut_sor_rapp_dec_vent"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Aut_sor_rapp_dec_vent"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Nom_gestionTextBox
        '
        Me.Nom_gestionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Nom_gestionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestionnaireBindingSource, "Nom_gestion", True))
        Me.Nom_gestionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_gestionTextBox.Location = New System.Drawing.Point(52, 71)
        Me.Nom_gestionTextBox.Name = "Nom_gestionTextBox"
        Me.Nom_gestionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Nom_gestionTextBox.TabIndex = 5
        '
        'Adr_gestionTextBox
        '
        Me.Adr_gestionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Adr_gestionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestionnaireBindingSource, "Adr_gestion", True))
        Me.Adr_gestionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adr_gestionTextBox.Location = New System.Drawing.Point(52, 122)
        Me.Adr_gestionTextBox.Name = "Adr_gestionTextBox"
        Me.Adr_gestionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Adr_gestionTextBox.TabIndex = 7
        '
        'N_rapp_dec_ventTextBox
        '
        Me.N_rapp_dec_ventTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.N_rapp_dec_ventTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestionnaireBindingSource, "N_rapp_dec_vent", True))
        Me.N_rapp_dec_ventTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_rapp_dec_ventTextBox.Location = New System.Drawing.Point(479, 71)
        Me.N_rapp_dec_ventTextBox.Name = "N_rapp_dec_ventTextBox"
        Me.N_rapp_dec_ventTextBox.Size = New System.Drawing.Size(200, 26)
        Me.N_rapp_dec_ventTextBox.TabIndex = 9
        '
        'Dat_rapp_dec_ventDateTimePicker
        '
        Me.Dat_rapp_dec_ventDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dat_rapp_dec_ventDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GestionnaireBindingSource, "Dat_rapp_dec_vent", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "21/05/2022", "d"))
        Me.Dat_rapp_dec_ventDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_rapp_dec_ventDateTimePicker.Location = New System.Drawing.Point(479, 120)
        Me.Dat_rapp_dec_ventDateTimePicker.Name = "Dat_rapp_dec_ventDateTimePicker"
        Me.Dat_rapp_dec_ventDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Dat_rapp_dec_ventDateTimePicker.TabIndex = 10
        '
        'Aut_sor_rapp_dec_ventTextBox
        '
        Me.Aut_sor_rapp_dec_ventTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Aut_sor_rapp_dec_ventTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestionnaireBindingSource, "Aut_sor_rapp_dec_vent", True))
        Me.Aut_sor_rapp_dec_ventTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aut_sor_rapp_dec_ventTextBox.Location = New System.Drawing.Point(208, 183)
        Me.Aut_sor_rapp_dec_ventTextBox.Name = "Aut_sor_rapp_dec_ventTextBox"
        Me.Aut_sor_rapp_dec_ventTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Aut_sor_rapp_dec_ventTextBox.TabIndex = 13
        '
        'Form_gestionnier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 489)
        Me.Controls.Add(Nom_gestionLabel)
        Me.Controls.Add(Me.Nom_gestionTextBox)
        Me.Controls.Add(Adr_gestionLabel)
        Me.Controls.Add(Me.Adr_gestionTextBox)
        Me.Controls.Add(N_rapp_dec_ventLabel)
        Me.Controls.Add(Me.N_rapp_dec_ventTextBox)
        Me.Controls.Add(Dat_rapp_dec_ventLabel)
        Me.Controls.Add(Me.Dat_rapp_dec_ventDateTimePicker)
        Me.Controls.Add(Aut_sor_rapp_dec_ventLabel)
        Me.Controls.Add(Me.Aut_sor_rapp_dec_ventTextBox)
        Me.Controls.Add(Me.GestionnaireDataGridView)
        Me.Controls.Add(Me.GestionnaireBindingNavigator)
        Me.Name = "Form_gestionnier"
        Me.Text = "Form_gestionnier"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionnaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionnaireBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GestionnaireBindingNavigator.ResumeLayout(False)
        Me.GestionnaireBindingNavigator.PerformLayout()
        CType(Me.GestionnaireDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents GestionnaireBindingSource As BindingSource
    Friend WithEvents GestionnaireTableAdapter As droit_propriter_etatDataSetTableAdapters.GestionnaireTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GestionnaireBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GestionnaireBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GestionnaireDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Nom_gestionTextBox As TextBox
    Friend WithEvents Adr_gestionTextBox As TextBox
    Friend WithEvents N_rapp_dec_ventTextBox As TextBox
    Friend WithEvents Dat_rapp_dec_ventDateTimePicker As DateTimePicker
    Friend WithEvents Aut_sor_rapp_dec_ventTextBox As TextBox
End Class
