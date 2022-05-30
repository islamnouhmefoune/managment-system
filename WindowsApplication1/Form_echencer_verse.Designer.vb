<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_echencer_verse
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
        Dim Num_tab_versLabel As System.Windows.Forms.Label
        Dim Dat_tab_versLabel As System.Windows.Forms.Label
        Dim Mont_loy_retLabel As System.Windows.Forms.Label
        Dim Mont_vers_initLabel As System.Windows.Forms.Label
        Dim Mont_GarLabel As System.Windows.Forms.Label
        Dim Coef_AppliLabel As System.Windows.Forms.Label
        Dim Beneficiaire_cd_beneLabel As System.Windows.Forms.Label
        Dim Abattement_cd_abatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_echencer_verse))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Echencer_VersementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Echencer_VersementTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Echencer_VersementTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Echencer_VersementBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Echencer_VersementBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Echencer_VersementDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_tab_versTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_tab_versDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Mont_loy_retTextBox = New System.Windows.Forms.TextBox()
        Me.Mont_vers_initTextBox = New System.Windows.Forms.TextBox()
        Me.Mont_GarTextBox = New System.Windows.Forms.TextBox()
        Me.Coef_AppliTextBox = New System.Windows.Forms.TextBox()
        Me.abattbtn = New System.Windows.Forms.Button()
        Me.Beneficiaire_cd_beneComboBox = New System.Windows.Forms.ComboBox()
        Me.Abattement_cd_abatComboBox = New System.Windows.Forms.ComboBox()
        Me.BeneficiaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter()
        Me.AbattementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbattementTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.AbattementTableAdapter()
        Num_tab_versLabel = New System.Windows.Forms.Label()
        Dat_tab_versLabel = New System.Windows.Forms.Label()
        Mont_loy_retLabel = New System.Windows.Forms.Label()
        Mont_vers_initLabel = New System.Windows.Forms.Label()
        Mont_GarLabel = New System.Windows.Forms.Label()
        Coef_AppliLabel = New System.Windows.Forms.Label()
        Beneficiaire_cd_beneLabel = New System.Windows.Forms.Label()
        Abattement_cd_abatLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Echencer_VersementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Echencer_VersementBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Echencer_VersementBindingNavigator.SuspendLayout()
        CType(Me.Echencer_VersementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbattementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Num_tab_versLabel
        '
        Num_tab_versLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Num_tab_versLabel.AutoSize = True
        Num_tab_versLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_tab_versLabel.ForeColor = System.Drawing.Color.White
        Num_tab_versLabel.Location = New System.Drawing.Point(341, 66)
        Num_tab_versLabel.Name = "Num_tab_versLabel"
        Num_tab_versLabel.Size = New System.Drawing.Size(83, 19)
        Num_tab_versLabel.TabIndex = 2
        Num_tab_versLabel.Text = "رقم جدول الدفع"
        '
        'Dat_tab_versLabel
        '
        Dat_tab_versLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Dat_tab_versLabel.AutoSize = True
        Dat_tab_versLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_tab_versLabel.ForeColor = System.Drawing.Color.White
        Dat_tab_versLabel.Location = New System.Drawing.Point(319, 111)
        Dat_tab_versLabel.Name = "Dat_tab_versLabel"
        Dat_tab_versLabel.Size = New System.Drawing.Size(105, 19)
        Dat_tab_versLabel.TabIndex = 4
        Dat_tab_versLabel.Text = "تاريخ الجدول الدفع "
        '
        'Mont_loy_retLabel
        '
        Mont_loy_retLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Mont_loy_retLabel.AutoSize = True
        Mont_loy_retLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mont_loy_retLabel.ForeColor = System.Drawing.Color.White
        Mont_loy_retLabel.Location = New System.Drawing.Point(307, 150)
        Mont_loy_retLabel.Name = "Mont_loy_retLabel"
        Mont_loy_retLabel.Size = New System.Drawing.Size(117, 19)
        Mont_loy_retLabel.TabIndex = 6
        Mont_loy_retLabel.Text = "مبلغ الإيجار المخصوم"
        '
        'Mont_vers_initLabel
        '
        Mont_vers_initLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Mont_vers_initLabel.AutoSize = True
        Mont_vers_initLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mont_vers_initLabel.ForeColor = System.Drawing.Color.White
        Mont_vers_initLabel.Location = New System.Drawing.Point(329, 196)
        Mont_vers_initLabel.Name = "Mont_vers_initLabel"
        Mont_vers_initLabel.Size = New System.Drawing.Size(95, 19)
        Mont_vers_initLabel.TabIndex = 8
        Mont_vers_initLabel.Text = "مبلغ الدفع المبدئي"
        '
        'Mont_GarLabel
        '
        Mont_GarLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Mont_GarLabel.AutoSize = True
        Mont_GarLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mont_GarLabel.ForeColor = System.Drawing.Color.White
        Mont_GarLabel.Location = New System.Drawing.Point(850, 66)
        Mont_GarLabel.Name = "Mont_GarLabel"
        Mont_GarLabel.Size = New System.Drawing.Size(71, 19)
        Mont_GarLabel.TabIndex = 10
        Mont_GarLabel.Text = "مبلغ الضمان"
        '
        'Coef_AppliLabel
        '
        Coef_AppliLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Coef_AppliLabel.AutoSize = True
        Coef_AppliLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Coef_AppliLabel.ForeColor = System.Drawing.Color.White
        Coef_AppliLabel.Location = New System.Drawing.Point(836, 111)
        Coef_AppliLabel.Name = "Coef_AppliLabel"
        Coef_AppliLabel.Size = New System.Drawing.Size(85, 19)
        Coef_AppliLabel.TabIndex = 12
        Coef_AppliLabel.Text = "المعامل المطبق"
        '
        'Beneficiaire_cd_beneLabel
        '
        Beneficiaire_cd_beneLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Beneficiaire_cd_beneLabel.AutoSize = True
        Beneficiaire_cd_beneLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Beneficiaire_cd_beneLabel.ForeColor = System.Drawing.Color.White
        Beneficiaire_cd_beneLabel.Location = New System.Drawing.Point(869, 150)
        Beneficiaire_cd_beneLabel.Name = "Beneficiaire_cd_beneLabel"
        Beneficiaire_cd_beneLabel.Size = New System.Drawing.Size(52, 19)
        Beneficiaire_cd_beneLabel.TabIndex = 14
        Beneficiaire_cd_beneLabel.Text = " المستفيد"
        '
        'Abattement_cd_abatLabel
        '
        Abattement_cd_abatLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Abattement_cd_abatLabel.AutoSize = True
        Abattement_cd_abatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Abattement_cd_abatLabel.ForeColor = System.Drawing.Color.White
        Abattement_cd_abatLabel.Location = New System.Drawing.Point(845, 196)
        Abattement_cd_abatLabel.Name = "Abattement_cd_abatLabel"
        Abattement_cd_abatLabel.Size = New System.Drawing.Size(76, 19)
        Abattement_cd_abatLabel.TabIndex = 16
        Abattement_cd_abatLabel.Text = "رمز التخفيض"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Echencer_VersementBindingSource
        '
        Me.Echencer_VersementBindingSource.DataMember = "Echencer_Versement"
        Me.Echencer_VersementBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Echencer_VersementTableAdapter
        '
        Me.Echencer_VersementTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Echencer_VersementTableAdapter = Me.Echencer_VersementTableAdapter
        Me.TableAdapterManager.GestionnaireTableAdapter = Nothing
        Me.TableAdapterManager.LocalTableAdapter = Nothing
        Me.TableAdapterManager.PV_Commession_CessionTableAdapter = Nothing
        Me.TableAdapterManager.QuartierTableAdapter = Nothing
        Me.TableAdapterManager.Rapport_evaluationTableAdapter = Nothing
        Me.TableAdapterManager.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Nothing
        '
        'Echencer_VersementBindingNavigator
        '
        Me.Echencer_VersementBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Echencer_VersementBindingNavigator.BindingSource = Me.Echencer_VersementBindingSource
        Me.Echencer_VersementBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Echencer_VersementBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Echencer_VersementBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Echencer_VersementBindingNavigatorSaveItem})
        Me.Echencer_VersementBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Echencer_VersementBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Echencer_VersementBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Echencer_VersementBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Echencer_VersementBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Echencer_VersementBindingNavigator.Name = "Echencer_VersementBindingNavigator"
        Me.Echencer_VersementBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Echencer_VersementBindingNavigator.Size = New System.Drawing.Size(1014, 25)
        Me.Echencer_VersementBindingNavigator.TabIndex = 0
        Me.Echencer_VersementBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Echencer_VersementBindingNavigatorSaveItem
        '
        Me.Echencer_VersementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Echencer_VersementBindingNavigatorSaveItem.Image = CType(resources.GetObject("Echencer_VersementBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Echencer_VersementBindingNavigatorSaveItem.Name = "Echencer_VersementBindingNavigatorSaveItem"
        Me.Echencer_VersementBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Echencer_VersementBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Echencer_VersementDataGridView
        '
        Me.Echencer_VersementDataGridView.AutoGenerateColumns = False
        Me.Echencer_VersementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Echencer_VersementDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Echencer_VersementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Echencer_VersementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Echencer_VersementDataGridView.DataSource = Me.Echencer_VersementBindingSource
        Me.Echencer_VersementDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Echencer_VersementDataGridView.Location = New System.Drawing.Point(0, 319)
        Me.Echencer_VersementDataGridView.Name = "Echencer_VersementDataGridView"
        Me.Echencer_VersementDataGridView.Size = New System.Drawing.Size(1014, 220)
        Me.Echencer_VersementDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Num_tab_vers"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Num_tab_vers"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_tab_vers"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_tab_vers"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Mont_loy_ret"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Mont_loy_ret"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Mont_vers_init"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mont_vers_init"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Mont_Gar"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mont_Gar"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Coef_Appli"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Coef_Appli"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn7.HeaderText = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "abattement_cd_abat"
        Me.DataGridViewTextBoxColumn8.HeaderText = "abattement_cd_abat"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Num_tab_versTextBox
        '
        Me.Num_tab_versTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Num_tab_versTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Num_tab_vers", True))
        Me.Num_tab_versTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_tab_versTextBox.Location = New System.Drawing.Point(71, 63)
        Me.Num_tab_versTextBox.Name = "Num_tab_versTextBox"
        Me.Num_tab_versTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Num_tab_versTextBox.TabIndex = 3
        '
        'Dat_tab_versDateTimePicker
        '
        Me.Dat_tab_versDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dat_tab_versDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Echencer_VersementBindingSource, "Dat_tab_vers", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Dat_tab_versDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_tab_versDateTimePicker.Location = New System.Drawing.Point(71, 105)
        Me.Dat_tab_versDateTimePicker.Name = "Dat_tab_versDateTimePicker"
        Me.Dat_tab_versDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_tab_versDateTimePicker.TabIndex = 5
        '
        'Mont_loy_retTextBox
        '
        Me.Mont_loy_retTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mont_loy_retTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Mont_loy_ret", True))
        Me.Mont_loy_retTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mont_loy_retTextBox.Location = New System.Drawing.Point(71, 147)
        Me.Mont_loy_retTextBox.Name = "Mont_loy_retTextBox"
        Me.Mont_loy_retTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Mont_loy_retTextBox.TabIndex = 7
        '
        'Mont_vers_initTextBox
        '
        Me.Mont_vers_initTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mont_vers_initTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Mont_vers_init", True))
        Me.Mont_vers_initTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mont_vers_initTextBox.Location = New System.Drawing.Point(71, 193)
        Me.Mont_vers_initTextBox.Name = "Mont_vers_initTextBox"
        Me.Mont_vers_initTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Mont_vers_initTextBox.TabIndex = 9
        '
        'Mont_GarTextBox
        '
        Me.Mont_GarTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mont_GarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Mont_Gar", True))
        Me.Mont_GarTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mont_GarTextBox.Location = New System.Drawing.Point(527, 63)
        Me.Mont_GarTextBox.Name = "Mont_GarTextBox"
        Me.Mont_GarTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Mont_GarTextBox.TabIndex = 11
        '
        'Coef_AppliTextBox
        '
        Me.Coef_AppliTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Coef_AppliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Echencer_VersementBindingSource, "Coef_Appli", True))
        Me.Coef_AppliTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coef_AppliTextBox.Location = New System.Drawing.Point(527, 108)
        Me.Coef_AppliTextBox.Name = "Coef_AppliTextBox"
        Me.Coef_AppliTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Coef_AppliTextBox.TabIndex = 13
        '
        'abattbtn
        '
        Me.abattbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.abattbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.abattbtn.FlatAppearance.BorderSize = 0
        Me.abattbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.abattbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.abattbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abattbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abattbtn.ForeColor = System.Drawing.Color.White
        Me.abattbtn.Location = New System.Drawing.Point(451, 267)
        Me.abattbtn.Name = "abattbtn"
        Me.abattbtn.Size = New System.Drawing.Size(153, 46)
        Me.abattbtn.TabIndex = 18
        Me.abattbtn.Text = "التخفيض"
        Me.abattbtn.UseVisualStyleBackColor = False
        '
        'Beneficiaire_cd_beneComboBox
        '
        Me.Beneficiaire_cd_beneComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Beneficiaire_cd_beneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Echencer_VersementBindingSource, "beneficiaire_cd_bene", True))
        Me.Beneficiaire_cd_beneComboBox.DataSource = Me.BeneficiaireBindingSource
        Me.Beneficiaire_cd_beneComboBox.DisplayMember = "nom_bene"
        Me.Beneficiaire_cd_beneComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beneficiaire_cd_beneComboBox.FormattingEnabled = True
        Me.Beneficiaire_cd_beneComboBox.Location = New System.Drawing.Point(527, 147)
        Me.Beneficiaire_cd_beneComboBox.Name = "Beneficiaire_cd_beneComboBox"
        Me.Beneficiaire_cd_beneComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Beneficiaire_cd_beneComboBox.TabIndex = 20
        Me.Beneficiaire_cd_beneComboBox.ValueMember = "Cd_bene"
        '
        'Abattement_cd_abatComboBox
        '
        Me.Abattement_cd_abatComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Abattement_cd_abatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Echencer_VersementBindingSource, "abattement_cd_abat", True))
        Me.Abattement_cd_abatComboBox.DataSource = Me.AbattementBindingSource
        Me.Abattement_cd_abatComboBox.DisplayMember = "Cd_abat"
        Me.Abattement_cd_abatComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abattement_cd_abatComboBox.FormattingEnabled = True
        Me.Abattement_cd_abatComboBox.Location = New System.Drawing.Point(527, 193)
        Me.Abattement_cd_abatComboBox.Name = "Abattement_cd_abatComboBox"
        Me.Abattement_cd_abatComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Abattement_cd_abatComboBox.TabIndex = 22
        Me.Abattement_cd_abatComboBox.ValueMember = "Cd_abat"
        '
        'BeneficiaireBindingSource
        '
        Me.BeneficiaireBindingSource.DataMember = "Beneficiaire"
        Me.BeneficiaireBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'BeneficiaireTableAdapter
        '
        Me.BeneficiaireTableAdapter.ClearBeforeFill = True
        '
        'AbattementBindingSource
        '
        Me.AbattementBindingSource.DataMember = "Abattement"
        Me.AbattementBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'AbattementTableAdapter
        '
        Me.AbattementTableAdapter.ClearBeforeFill = True
        '
        'Form_echencer_verse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 539)
        Me.Controls.Add(Me.Abattement_cd_abatComboBox)
        Me.Controls.Add(Me.Beneficiaire_cd_beneComboBox)
        Me.Controls.Add(Me.abattbtn)
        Me.Controls.Add(Num_tab_versLabel)
        Me.Controls.Add(Me.Num_tab_versTextBox)
        Me.Controls.Add(Dat_tab_versLabel)
        Me.Controls.Add(Me.Dat_tab_versDateTimePicker)
        Me.Controls.Add(Mont_loy_retLabel)
        Me.Controls.Add(Me.Mont_loy_retTextBox)
        Me.Controls.Add(Mont_vers_initLabel)
        Me.Controls.Add(Me.Mont_vers_initTextBox)
        Me.Controls.Add(Mont_GarLabel)
        Me.Controls.Add(Me.Mont_GarTextBox)
        Me.Controls.Add(Coef_AppliLabel)
        Me.Controls.Add(Me.Coef_AppliTextBox)
        Me.Controls.Add(Beneficiaire_cd_beneLabel)
        Me.Controls.Add(Abattement_cd_abatLabel)
        Me.Controls.Add(Me.Echencer_VersementDataGridView)
        Me.Controls.Add(Me.Echencer_VersementBindingNavigator)
        Me.Name = "Form_echencer_verse"
        Me.Text = "Form_echencer_verse"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Echencer_VersementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Echencer_VersementBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Echencer_VersementBindingNavigator.ResumeLayout(False)
        Me.Echencer_VersementBindingNavigator.PerformLayout()
        CType(Me.Echencer_VersementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbattementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Echencer_VersementBindingSource As BindingSource
    Friend WithEvents Echencer_VersementTableAdapter As droit_propriter_etatDataSetTableAdapters.Echencer_VersementTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Echencer_VersementBindingNavigator As BindingNavigator
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
    Friend WithEvents Echencer_VersementBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Echencer_VersementDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Num_tab_versTextBox As TextBox
    Friend WithEvents Dat_tab_versDateTimePicker As DateTimePicker
    Friend WithEvents Mont_loy_retTextBox As TextBox
    Friend WithEvents Mont_vers_initTextBox As TextBox
    Friend WithEvents Mont_GarTextBox As TextBox
    Friend WithEvents Coef_AppliTextBox As TextBox
    Friend WithEvents abattbtn As Button
    Friend WithEvents Beneficiaire_cd_beneComboBox As ComboBox
    Friend WithEvents Abattement_cd_abatComboBox As ComboBox
    Friend WithEvents BeneficiaireBindingSource As BindingSource
    Friend WithEvents BeneficiaireTableAdapter As droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter
    Friend WithEvents AbattementBindingSource As BindingSource
    Friend WithEvents AbattementTableAdapter As droit_propriter_etatDataSetTableAdapters.AbattementTableAdapter
End Class
