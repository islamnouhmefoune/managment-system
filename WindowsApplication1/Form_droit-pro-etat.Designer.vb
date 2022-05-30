<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_droit_pro_etat
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
        Dim N_tab_vers_droi_prop_etatLabel As System.Windows.Forms.Label
        Dim Dat_tab_vers_droi_prop_etatLabel As System.Windows.Forms.Label
        Dim Droi_prop_etatLabel As System.Windows.Forms.Label
        Dim Beneficiaire_cd_beneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_droit_pro_etat))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Droits_de_propriete_de_etatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Droits_de_propriete_de_etatTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Droits_de_propriete_de_etatTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Droits_de_propriete_de_etatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Droits_de_propriete_de_etatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Droits_de_propriete_de_etatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_tab_vers_droi_prop_etatTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Droi_prop_etatTextBox = New System.Windows.Forms.TextBox()
        Me.Beneficiaire_cd_beneComboBox = New System.Windows.Forms.ComboBox()
        Me.BeneficiaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter()
        N_tab_vers_droi_prop_etatLabel = New System.Windows.Forms.Label()
        Dat_tab_vers_droi_prop_etatLabel = New System.Windows.Forms.Label()
        Droi_prop_etatLabel = New System.Windows.Forms.Label()
        Beneficiaire_cd_beneLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Droits_de_propriete_de_etatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Droits_de_propriete_de_etatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Droits_de_propriete_de_etatBindingNavigator.SuspendLayout()
        CType(Me.Droits_de_propriete_de_etatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_tab_vers_droi_prop_etatLabel
        '
        N_tab_vers_droi_prop_etatLabel.AutoSize = True
        N_tab_vers_droi_prop_etatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_tab_vers_droi_prop_etatLabel.ForeColor = System.Drawing.Color.White
        N_tab_vers_droi_prop_etatLabel.Location = New System.Drawing.Point(326, 93)
        N_tab_vers_droi_prop_etatLabel.Name = "N_tab_vers_droi_prop_etatLabel"
        N_tab_vers_droi_prop_etatLabel.Size = New System.Drawing.Size(220, 19)
        N_tab_vers_droi_prop_etatLabel.TabIndex = 2
        N_tab_vers_droi_prop_etatLabel.Text = "رقم جدول الدفع الخاص بحقوق أملاك الدولة"
        '
        'Dat_tab_vers_droi_prop_etatLabel
        '
        Dat_tab_vers_droi_prop_etatLabel.AutoSize = True
        Dat_tab_vers_droi_prop_etatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_tab_vers_droi_prop_etatLabel.ForeColor = System.Drawing.Color.White
        Dat_tab_vers_droi_prop_etatLabel.Location = New System.Drawing.Point(308, 179)
        Dat_tab_vers_droi_prop_etatLabel.Name = "Dat_tab_vers_droi_prop_etatLabel"
        Dat_tab_vers_droi_prop_etatLabel.Size = New System.Drawing.Size(238, 19)
        Dat_tab_vers_droi_prop_etatLabel.TabIndex = 4
        Dat_tab_vers_droi_prop_etatLabel.Text = "تاريخ الجدول الدفع الخاص بحقوق أملاك الدولة"
        '
        'Droi_prop_etatLabel
        '
        Droi_prop_etatLabel.AutoSize = True
        Droi_prop_etatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Droi_prop_etatLabel.ForeColor = System.Drawing.Color.White
        Droi_prop_etatLabel.Location = New System.Drawing.Point(848, 93)
        Droi_prop_etatLabel.Name = "Droi_prop_etatLabel"
        Droi_prop_etatLabel.Size = New System.Drawing.Size(99, 19)
        Droi_prop_etatLabel.TabIndex = 6
        Droi_prop_etatLabel.Text = "حقوق أملاك الدولة"
        '
        'Beneficiaire_cd_beneLabel
        '
        Beneficiaire_cd_beneLabel.AutoSize = True
        Beneficiaire_cd_beneLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Beneficiaire_cd_beneLabel.ForeColor = System.Drawing.Color.White
        Beneficiaire_cd_beneLabel.Location = New System.Drawing.Point(875, 179)
        Beneficiaire_cd_beneLabel.Name = "Beneficiaire_cd_beneLabel"
        Beneficiaire_cd_beneLabel.Size = New System.Drawing.Size(72, 19)
        Beneficiaire_cd_beneLabel.TabIndex = 8
        Beneficiaire_cd_beneLabel.Text = "رمز المستفيد"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Droits_de_propriete_de_etatBindingSource
        '
        Me.Droits_de_propriete_de_etatBindingSource.DataMember = "Droits_de_propriete_de_etat"
        Me.Droits_de_propriete_de_etatBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Droits_de_propriete_de_etatTableAdapter
        '
        Me.Droits_de_propriete_de_etatTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Droits_de_propriete_de_etatTableAdapter = Me.Droits_de_propriete_de_etatTableAdapter
        Me.TableAdapterManager.Echencer_VersementTableAdapter = Nothing
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
        'Droits_de_propriete_de_etatBindingNavigator
        '
        Me.Droits_de_propriete_de_etatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Droits_de_propriete_de_etatBindingNavigator.BindingSource = Me.Droits_de_propriete_de_etatBindingSource
        Me.Droits_de_propriete_de_etatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Droits_de_propriete_de_etatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Droits_de_propriete_de_etatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Droits_de_propriete_de_etatBindingNavigatorSaveItem})
        Me.Droits_de_propriete_de_etatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Droits_de_propriete_de_etatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Droits_de_propriete_de_etatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Droits_de_propriete_de_etatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Droits_de_propriete_de_etatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Droits_de_propriete_de_etatBindingNavigator.Name = "Droits_de_propriete_de_etatBindingNavigator"
        Me.Droits_de_propriete_de_etatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Droits_de_propriete_de_etatBindingNavigator.Size = New System.Drawing.Size(1036, 25)
        Me.Droits_de_propriete_de_etatBindingNavigator.TabIndex = 0
        Me.Droits_de_propriete_de_etatBindingNavigator.Text = "BindingNavigator1"
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
        'Droits_de_propriete_de_etatBindingNavigatorSaveItem
        '
        Me.Droits_de_propriete_de_etatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Droits_de_propriete_de_etatBindingNavigatorSaveItem.Image = CType(resources.GetObject("Droits_de_propriete_de_etatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Droits_de_propriete_de_etatBindingNavigatorSaveItem.Name = "Droits_de_propriete_de_etatBindingNavigatorSaveItem"
        Me.Droits_de_propriete_de_etatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Droits_de_propriete_de_etatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Droits_de_propriete_de_etatDataGridView
        '
        Me.Droits_de_propriete_de_etatDataGridView.AutoGenerateColumns = False
        Me.Droits_de_propriete_de_etatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Droits_de_propriete_de_etatDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Droits_de_propriete_de_etatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Droits_de_propriete_de_etatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Droits_de_propriete_de_etatDataGridView.DataSource = Me.Droits_de_propriete_de_etatBindingSource
        Me.Droits_de_propriete_de_etatDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Droits_de_propriete_de_etatDataGridView.Location = New System.Drawing.Point(0, 300)
        Me.Droits_de_propriete_de_etatDataGridView.Name = "Droits_de_propriete_de_etatDataGridView"
        Me.Droits_de_propriete_de_etatDataGridView.ReadOnly = True
        Me.Droits_de_propriete_de_etatDataGridView.Size = New System.Drawing.Size(1036, 220)
        Me.Droits_de_propriete_de_etatDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_tab_vers_droi_prop_etat"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Droi_prop_etat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Droi_prop_etat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn4.HeaderText = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'N_tab_vers_droi_prop_etatTextBox
        '
        Me.N_tab_vers_droi_prop_etatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Droits_de_propriete_de_etatBindingSource, "N_tab_vers_droi_prop_etat", True))
        Me.N_tab_vers_droi_prop_etatTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_tab_vers_droi_prop_etatTextBox.Location = New System.Drawing.Point(85, 90)
        Me.N_tab_vers_droi_prop_etatTextBox.Name = "N_tab_vers_droi_prop_etatTextBox"
        Me.N_tab_vers_droi_prop_etatTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_tab_vers_droi_prop_etatTextBox.TabIndex = 3
        '
        'Dat_tab_vers_droi_prop_etatDateTimePicker
        '
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Droits_de_propriete_de_etatBindingSource, "Dat_tab_vers_droi_prop_etat", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker.Location = New System.Drawing.Point(85, 173)
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker.Name = "Dat_tab_vers_droi_prop_etatDateTimePicker"
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_tab_vers_droi_prop_etatDateTimePicker.TabIndex = 5
        '
        'Droi_prop_etatTextBox
        '
        Me.Droi_prop_etatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Droits_de_propriete_de_etatBindingSource, "Droi_prop_etat", True))
        Me.Droi_prop_etatTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Droi_prop_etatTextBox.Location = New System.Drawing.Point(587, 90)
        Me.Droi_prop_etatTextBox.Name = "Droi_prop_etatTextBox"
        Me.Droi_prop_etatTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Droi_prop_etatTextBox.TabIndex = 7
        '
        'Beneficiaire_cd_beneComboBox
        '
        Me.Beneficiaire_cd_beneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Droits_de_propriete_de_etatBindingSource, "beneficiaire_cd_bene", True))
        Me.Beneficiaire_cd_beneComboBox.DataSource = Me.BeneficiaireBindingSource
        Me.Beneficiaire_cd_beneComboBox.DisplayMember = "Cd_bene"
        Me.Beneficiaire_cd_beneComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beneficiaire_cd_beneComboBox.FormattingEnabled = True
        Me.Beneficiaire_cd_beneComboBox.Location = New System.Drawing.Point(587, 176)
        Me.Beneficiaire_cd_beneComboBox.Name = "Beneficiaire_cd_beneComboBox"
        Me.Beneficiaire_cd_beneComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Beneficiaire_cd_beneComboBox.TabIndex = 11
        Me.Beneficiaire_cd_beneComboBox.ValueMember = "Cd_bene"
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
        'Form_droit_pro_etat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1036, 520)
        Me.Controls.Add(Me.Beneficiaire_cd_beneComboBox)
        Me.Controls.Add(N_tab_vers_droi_prop_etatLabel)
        Me.Controls.Add(Me.N_tab_vers_droi_prop_etatTextBox)
        Me.Controls.Add(Dat_tab_vers_droi_prop_etatLabel)
        Me.Controls.Add(Me.Dat_tab_vers_droi_prop_etatDateTimePicker)
        Me.Controls.Add(Droi_prop_etatLabel)
        Me.Controls.Add(Me.Droi_prop_etatTextBox)
        Me.Controls.Add(Beneficiaire_cd_beneLabel)
        Me.Controls.Add(Me.Droits_de_propriete_de_etatDataGridView)
        Me.Controls.Add(Me.Droits_de_propriete_de_etatBindingNavigator)
        Me.Name = "Form_droit_pro_etat"
        Me.Text = "Form_droit_pro_etat"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Droits_de_propriete_de_etatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Droits_de_propriete_de_etatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Droits_de_propriete_de_etatBindingNavigator.ResumeLayout(False)
        Me.Droits_de_propriete_de_etatBindingNavigator.PerformLayout()
        CType(Me.Droits_de_propriete_de_etatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Droits_de_propriete_de_etatBindingSource As BindingSource
    Friend WithEvents Droits_de_propriete_de_etatTableAdapter As droit_propriter_etatDataSetTableAdapters.Droits_de_propriete_de_etatTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Droits_de_propriete_de_etatBindingNavigator As BindingNavigator
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
    Friend WithEvents Droits_de_propriete_de_etatBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Droits_de_propriete_de_etatDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents N_tab_vers_droi_prop_etatTextBox As TextBox
    Friend WithEvents Dat_tab_vers_droi_prop_etatDateTimePicker As DateTimePicker
    Friend WithEvents Droi_prop_etatTextBox As TextBox
    Friend WithEvents Beneficiaire_cd_beneComboBox As ComboBox
    Friend WithEvents BeneficiaireBindingSource As BindingSource
    Friend WithEvents BeneficiaireTableAdapter As droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter
End Class
