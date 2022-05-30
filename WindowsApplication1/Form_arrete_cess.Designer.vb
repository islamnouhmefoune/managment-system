<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_arrete_cess
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
        Dim N_rapp_ren_immbLabel As System.Windows.Forms.Label
        Dim Dat_rapp_ren_immobLabel As System.Windows.Forms.Label
        Dim Cd_direc_Label As System.Windows.Forms.Label
        Dim Beneficiaire_cd_beneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_arrete_cess))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Arrete_cession_bien_etatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Arrete_cession_bien_etatTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Arrete_cession_bien_etatTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Arrete_cession_bien_etatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Arrete_cession_bien_etatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Arrete_cession_bien_etatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_rapp_ren_immbTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_rapp_ren_immobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.directeurbtn = New System.Windows.Forms.Button()
        Me.Cd_direc_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Beneficiaire_cd_beneComboBox = New System.Windows.Forms.ComboBox()
        Me.BeneficiaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter()
        Me.DirecteurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirecteurTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.DirecteurTableAdapter()
        N_rapp_ren_immbLabel = New System.Windows.Forms.Label()
        Dat_rapp_ren_immobLabel = New System.Windows.Forms.Label()
        Cd_direc_Label = New System.Windows.Forms.Label()
        Beneficiaire_cd_beneLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arrete_cession_bien_etatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arrete_cession_bien_etatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Arrete_cession_bien_etatBindingNavigator.SuspendLayout()
        CType(Me.Arrete_cession_bien_etatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirecteurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_rapp_ren_immbLabel
        '
        N_rapp_ren_immbLabel.AutoSize = True
        N_rapp_ren_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_rapp_ren_immbLabel.ForeColor = System.Drawing.Color.White
        N_rapp_ren_immbLabel.Location = New System.Drawing.Point(340, 55)
        N_rapp_ren_immbLabel.Name = "N_rapp_ren_immbLabel"
        N_rapp_ren_immbLabel.Size = New System.Drawing.Size(193, 19)
        N_rapp_ren_immbLabel.TabIndex = 2
        N_rapp_ren_immbLabel.Text = "رقم مقرر التنازل عن الأملاك العقارية"
        '
        'Dat_rapp_ren_immobLabel
        '
        Dat_rapp_ren_immobLabel.AutoSize = True
        Dat_rapp_ren_immobLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_rapp_ren_immobLabel.ForeColor = System.Drawing.Color.White
        Dat_rapp_ren_immobLabel.Location = New System.Drawing.Point(329, 114)
        Dat_rapp_ren_immobLabel.Name = "Dat_rapp_ren_immobLabel"
        Dat_rapp_ren_immobLabel.Size = New System.Drawing.Size(204, 19)
        Dat_rapp_ren_immobLabel.TabIndex = 4
        Dat_rapp_ren_immobLabel.Text = "تاريخ مقرر التنازل عن الأملاك العقارية"
        '
        'Cd_direc_Label
        '
        Cd_direc_Label.AutoSize = True
        Cd_direc_Label.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_direc_Label.ForeColor = System.Drawing.Color.White
        Cd_direc_Label.Location = New System.Drawing.Point(850, 55)
        Cd_direc_Label.Name = "Cd_direc_Label"
        Cd_direc_Label.Size = New System.Drawing.Size(62, 19)
        Cd_direc_Label.TabIndex = 6
        Cd_direc_Label.Text = "رمز المدير"
        '
        'Beneficiaire_cd_beneLabel
        '
        Beneficiaire_cd_beneLabel.AutoSize = True
        Beneficiaire_cd_beneLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Beneficiaire_cd_beneLabel.ForeColor = System.Drawing.Color.White
        Beneficiaire_cd_beneLabel.Location = New System.Drawing.Point(840, 114)
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
        'Arrete_cession_bien_etatBindingSource
        '
        Me.Arrete_cession_bien_etatBindingSource.DataMember = "Arrete_cession_bien_etat"
        Me.Arrete_cession_bien_etatBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Arrete_cession_bien_etatTableAdapter
        '
        Me.Arrete_cession_bien_etatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Nothing
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Me.Arrete_cession_bien_etatTableAdapter
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
        'Arrete_cession_bien_etatBindingNavigator
        '
        Me.Arrete_cession_bien_etatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Arrete_cession_bien_etatBindingNavigator.BindingSource = Me.Arrete_cession_bien_etatBindingSource
        Me.Arrete_cession_bien_etatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Arrete_cession_bien_etatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Arrete_cession_bien_etatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Arrete_cession_bien_etatBindingNavigatorSaveItem})
        Me.Arrete_cession_bien_etatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Arrete_cession_bien_etatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Arrete_cession_bien_etatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Arrete_cession_bien_etatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Arrete_cession_bien_etatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Arrete_cession_bien_etatBindingNavigator.Name = "Arrete_cession_bien_etatBindingNavigator"
        Me.Arrete_cession_bien_etatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Arrete_cession_bien_etatBindingNavigator.Size = New System.Drawing.Size(1028, 25)
        Me.Arrete_cession_bien_etatBindingNavigator.TabIndex = 0
        Me.Arrete_cession_bien_etatBindingNavigator.Text = "BindingNavigator1"
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
        'Arrete_cession_bien_etatBindingNavigatorSaveItem
        '
        Me.Arrete_cession_bien_etatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Arrete_cession_bien_etatBindingNavigatorSaveItem.Image = CType(resources.GetObject("Arrete_cession_bien_etatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Arrete_cession_bien_etatBindingNavigatorSaveItem.Name = "Arrete_cession_bien_etatBindingNavigatorSaveItem"
        Me.Arrete_cession_bien_etatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Arrete_cession_bien_etatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Arrete_cession_bien_etatDataGridView
        '
        Me.Arrete_cession_bien_etatDataGridView.AutoGenerateColumns = False
        Me.Arrete_cession_bien_etatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Arrete_cession_bien_etatDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Arrete_cession_bien_etatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Arrete_cession_bien_etatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Arrete_cession_bien_etatDataGridView.DataSource = Me.Arrete_cession_bien_etatBindingSource
        Me.Arrete_cession_bien_etatDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Arrete_cession_bien_etatDataGridView.Location = New System.Drawing.Point(0, 293)
        Me.Arrete_cession_bien_etatDataGridView.Name = "Arrete_cession_bien_etatDataGridView"
        Me.Arrete_cession_bien_etatDataGridView.ReadOnly = True
        Me.Arrete_cession_bien_etatDataGridView.Size = New System.Drawing.Size(1028, 220)
        Me.Arrete_cession_bien_etatDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_rapp_ren_immb"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_rapp_ren_immb"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_rapp_ren_immob"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_rapp_ren_immob"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cd_direc_"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cd_direc_"
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
        'N_rapp_ren_immbTextBox
        '
        Me.N_rapp_ren_immbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Arrete_cession_bien_etatBindingSource, "N_rapp_ren_immb", True))
        Me.N_rapp_ren_immbTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_rapp_ren_immbTextBox.Location = New System.Drawing.Point(108, 52)
        Me.N_rapp_ren_immbTextBox.Name = "N_rapp_ren_immbTextBox"
        Me.N_rapp_ren_immbTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_rapp_ren_immbTextBox.TabIndex = 3
        '
        'Dat_rapp_ren_immobDateTimePicker
        '
        Me.Dat_rapp_ren_immobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Arrete_cession_bien_etatBindingSource, "Dat_rapp_ren_immob", True))
        Me.Dat_rapp_ren_immobDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_rapp_ren_immobDateTimePicker.Location = New System.Drawing.Point(108, 108)
        Me.Dat_rapp_ren_immobDateTimePicker.Name = "Dat_rapp_ren_immobDateTimePicker"
        Me.Dat_rapp_ren_immobDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_rapp_ren_immobDateTimePicker.TabIndex = 5
        '
        'directeurbtn
        '
        Me.directeurbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.directeurbtn.FlatAppearance.BorderSize = 0
        Me.directeurbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.directeurbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.directeurbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.directeurbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.directeurbtn.ForeColor = System.Drawing.Color.White
        Me.directeurbtn.Location = New System.Drawing.Point(458, 240)
        Me.directeurbtn.Name = "directeurbtn"
        Me.directeurbtn.Size = New System.Drawing.Size(157, 47)
        Me.directeurbtn.TabIndex = 10
        Me.directeurbtn.Text = "المدير"
        Me.directeurbtn.UseVisualStyleBackColor = False
        '
        'Cd_direc_ComboBox
        '
        Me.Cd_direc_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Arrete_cession_bien_etatBindingSource, "Cd_direc_", True))
        Me.Cd_direc_ComboBox.DataSource = Me.DirecteurBindingSource
        Me.Cd_direc_ComboBox.DisplayMember = "Nom_direc"
        Me.Cd_direc_ComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_direc_ComboBox.FormattingEnabled = True
        Me.Cd_direc_ComboBox.Location = New System.Drawing.Point(578, 52)
        Me.Cd_direc_ComboBox.Name = "Cd_direc_ComboBox"
        Me.Cd_direc_ComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Cd_direc_ComboBox.TabIndex = 12
        Me.Cd_direc_ComboBox.ValueMember = "Cd_direc_"
        '
        'Beneficiaire_cd_beneComboBox
        '
        Me.Beneficiaire_cd_beneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Arrete_cession_bien_etatBindingSource, "beneficiaire_cd_bene", True))
        Me.Beneficiaire_cd_beneComboBox.DataSource = Me.BeneficiaireBindingSource
        Me.Beneficiaire_cd_beneComboBox.DisplayMember = "Cd_bene"
        Me.Beneficiaire_cd_beneComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beneficiaire_cd_beneComboBox.FormattingEnabled = True
        Me.Beneficiaire_cd_beneComboBox.Location = New System.Drawing.Point(578, 108)
        Me.Beneficiaire_cd_beneComboBox.Name = "Beneficiaire_cd_beneComboBox"
        Me.Beneficiaire_cd_beneComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Beneficiaire_cd_beneComboBox.TabIndex = 14
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
        'DirecteurBindingSource
        '
        Me.DirecteurBindingSource.DataMember = "Directeur"
        Me.DirecteurBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'DirecteurTableAdapter
        '
        Me.DirecteurTableAdapter.ClearBeforeFill = True
        '
        'Form_arrete_cess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 513)
        Me.Controls.Add(Me.Beneficiaire_cd_beneComboBox)
        Me.Controls.Add(Me.Cd_direc_ComboBox)
        Me.Controls.Add(Me.directeurbtn)
        Me.Controls.Add(N_rapp_ren_immbLabel)
        Me.Controls.Add(Me.N_rapp_ren_immbTextBox)
        Me.Controls.Add(Dat_rapp_ren_immobLabel)
        Me.Controls.Add(Me.Dat_rapp_ren_immobDateTimePicker)
        Me.Controls.Add(Cd_direc_Label)
        Me.Controls.Add(Beneficiaire_cd_beneLabel)
        Me.Controls.Add(Me.Arrete_cession_bien_etatDataGridView)
        Me.Controls.Add(Me.Arrete_cession_bien_etatBindingNavigator)
        Me.Name = "Form_arrete_cess"
        Me.Text = "Form_arrete_cess"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arrete_cession_bien_etatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arrete_cession_bien_etatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Arrete_cession_bien_etatBindingNavigator.ResumeLayout(False)
        Me.Arrete_cession_bien_etatBindingNavigator.PerformLayout()
        CType(Me.Arrete_cession_bien_etatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirecteurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Arrete_cession_bien_etatBindingSource As BindingSource
    Friend WithEvents Arrete_cession_bien_etatTableAdapter As droit_propriter_etatDataSetTableAdapters.Arrete_cession_bien_etatTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Arrete_cession_bien_etatBindingNavigator As BindingNavigator
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
    Friend WithEvents Arrete_cession_bien_etatBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Arrete_cession_bien_etatDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents N_rapp_ren_immbTextBox As TextBox
    Friend WithEvents Dat_rapp_ren_immobDateTimePicker As DateTimePicker
    Friend WithEvents directeurbtn As Button
    Friend WithEvents Cd_direc_ComboBox As ComboBox
    Friend WithEvents Beneficiaire_cd_beneComboBox As ComboBox
    Friend WithEvents BeneficiaireBindingSource As BindingSource
    Friend WithEvents BeneficiaireTableAdapter As droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter
    Friend WithEvents DirecteurBindingSource As BindingSource
    Friend WithEvents DirecteurTableAdapter As droit_propriter_etatDataSetTableAdapters.DirecteurTableAdapter
End Class
