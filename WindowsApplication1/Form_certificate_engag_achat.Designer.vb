<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_certificate_engag_achat
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
        Dim N_Cert_Engag_AchtLabel As System.Windows.Forms.Label
        Dim Date_Cert_Engeg_AchtLabel As System.Windows.Forms.Label
        Dim Beneficiaire_cd_beneLabel As System.Windows.Forms.Label
        Dim Cd_gestionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_certificate_engag_achat))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Certificat_engagement_achatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Certificat_engagement_achatTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Certificat_engagement_achatTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Certificat_engagement_achatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Certificat_engagement_achatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Certificat_engagement_achatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gestionbtn = New System.Windows.Forms.Button()
        Me.N_Cert_Engag_AchtTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Cert_Engeg_AchtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cd_gestionComboBox = New System.Windows.Forms.ComboBox()
        Me.Beneficiaire_cd_beneComboBox = New System.Windows.Forms.ComboBox()
        Me.BeneficiaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter()
        Me.GestionnaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionnaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.GestionnaireTableAdapter()
        N_Cert_Engag_AchtLabel = New System.Windows.Forms.Label()
        Date_Cert_Engeg_AchtLabel = New System.Windows.Forms.Label()
        Beneficiaire_cd_beneLabel = New System.Windows.Forms.Label()
        Cd_gestionLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Certificat_engagement_achatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Certificat_engagement_achatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Certificat_engagement_achatBindingNavigator.SuspendLayout()
        CType(Me.Certificat_engagement_achatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionnaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_Cert_Engag_AchtLabel
        '
        N_Cert_Engag_AchtLabel.AutoSize = True
        N_Cert_Engag_AchtLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        N_Cert_Engag_AchtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_Cert_Engag_AchtLabel.ForeColor = System.Drawing.Color.White
        N_Cert_Engag_AchtLabel.Location = New System.Drawing.Point(165, 54)
        N_Cert_Engag_AchtLabel.Name = "N_Cert_Engag_AchtLabel"
        N_Cert_Engag_AchtLabel.Size = New System.Drawing.Size(147, 20)
        N_Cert_Engag_AchtLabel.TabIndex = 3
        N_Cert_Engag_AchtLabel.Text = "رقم شهادة الالتزام  بالشراء"
        '
        'Date_Cert_Engeg_AchtLabel
        '
        Date_Cert_Engeg_AchtLabel.AutoSize = True
        Date_Cert_Engeg_AchtLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Date_Cert_Engeg_AchtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Cert_Engeg_AchtLabel.ForeColor = System.Drawing.Color.White
        Date_Cert_Engeg_AchtLabel.Location = New System.Drawing.Point(551, 54)
        Date_Cert_Engeg_AchtLabel.Name = "Date_Cert_Engeg_AchtLabel"
        Date_Cert_Engeg_AchtLabel.Size = New System.Drawing.Size(159, 20)
        Date_Cert_Engeg_AchtLabel.TabIndex = 5
        Date_Cert_Engeg_AchtLabel.Text = "تاريخ شهادة الالتزام  بالشراء"
        '
        'Beneficiaire_cd_beneLabel
        '
        Beneficiaire_cd_beneLabel.AutoSize = True
        Beneficiaire_cd_beneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Beneficiaire_cd_beneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Beneficiaire_cd_beneLabel.ForeColor = System.Drawing.Color.White
        Beneficiaire_cd_beneLabel.Location = New System.Drawing.Point(593, 155)
        Beneficiaire_cd_beneLabel.Name = "Beneficiaire_cd_beneLabel"
        Beneficiaire_cd_beneLabel.Size = New System.Drawing.Size(85, 20)
        Beneficiaire_cd_beneLabel.TabIndex = 7
        Beneficiaire_cd_beneLabel.Text = "رمز المتصرف"
        '
        'Cd_gestionLabel
        '
        Cd_gestionLabel.AutoSize = True
        Cd_gestionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Cd_gestionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_gestionLabel.ForeColor = System.Drawing.Color.White
        Cd_gestionLabel.Location = New System.Drawing.Point(192, 155)
        Cd_gestionLabel.Name = "Cd_gestionLabel"
        Cd_gestionLabel.Size = New System.Drawing.Size(73, 20)
        Cd_gestionLabel.TabIndex = 9
        Cd_gestionLabel.Text = "رمز المستفيد"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Certificat_engagement_achatBindingSource
        '
        Me.Certificat_engagement_achatBindingSource.DataMember = "Certificat_engagement_achat"
        Me.Certificat_engagement_achatBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Certificat_engagement_achatTableAdapter
        '
        Me.Certificat_engagement_achatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Nothing
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager.Attestation_paiemnet_loyerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiaireTableAdapter = Nothing
        Me.TableAdapterManager.Calendrier_valueur_initaleTableAdapter = Nothing
        Me.TableAdapterManager.Certificat_engagement_achatTableAdapter = Me.Certificat_engagement_achatTableAdapter
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
        'Certificat_engagement_achatBindingNavigator
        '
        Me.Certificat_engagement_achatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Certificat_engagement_achatBindingNavigator.BindingSource = Me.Certificat_engagement_achatBindingSource
        Me.Certificat_engagement_achatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Certificat_engagement_achatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Certificat_engagement_achatBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Certificat_engagement_achatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Certificat_engagement_achatBindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.Certificat_engagement_achatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Certificat_engagement_achatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Certificat_engagement_achatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Certificat_engagement_achatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Certificat_engagement_achatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Certificat_engagement_achatBindingNavigator.Name = "Certificat_engagement_achatBindingNavigator"
        Me.Certificat_engagement_achatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Certificat_engagement_achatBindingNavigator.Size = New System.Drawing.Size(913, 31)
        Me.Certificat_engagement_achatBindingNavigator.TabIndex = 0
        Me.Certificat_engagement_achatBindingNavigator.Text = "BindingNavigator1"
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
        'Certificat_engagement_achatBindingNavigatorSaveItem
        '
        Me.Certificat_engagement_achatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Certificat_engagement_achatBindingNavigatorSaveItem.Image = CType(resources.GetObject("Certificat_engagement_achatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Certificat_engagement_achatBindingNavigatorSaveItem.Name = "Certificat_engagement_achatBindingNavigatorSaveItem"
        Me.Certificat_engagement_achatBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.Certificat_engagement_achatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'Certificat_engagement_achatDataGridView
        '
        Me.Certificat_engagement_achatDataGridView.AutoGenerateColumns = False
        Me.Certificat_engagement_achatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Certificat_engagement_achatDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Certificat_engagement_achatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Certificat_engagement_achatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Certificat_engagement_achatDataGridView.DataSource = Me.Certificat_engagement_achatBindingSource
        Me.Certificat_engagement_achatDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Certificat_engagement_achatDataGridView.Location = New System.Drawing.Point(0, 308)
        Me.Certificat_engagement_achatDataGridView.Name = "Certificat_engagement_achatDataGridView"
        Me.Certificat_engagement_achatDataGridView.ReadOnly = True
        Me.Certificat_engagement_achatDataGridView.Size = New System.Drawing.Size(913, 205)
        Me.Certificat_engagement_achatDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_Cert_Engag_Acht"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_Cert_Engag_Acht"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date_Cert_Engeg_Acht"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date_Cert_Engeg_Acht"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn3.HeaderText = "beneficiaire_cd_bene"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cd_gestion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cd_gestion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'gestionbtn
        '
        Me.gestionbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.gestionbtn.FlatAppearance.BorderSize = 0
        Me.gestionbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.gestionbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.gestionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gestionbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gestionbtn.ForeColor = System.Drawing.Color.White
        Me.gestionbtn.Location = New System.Drawing.Point(353, 256)
        Me.gestionbtn.Name = "gestionbtn"
        Me.gestionbtn.Size = New System.Drawing.Size(157, 46)
        Me.gestionbtn.TabIndex = 2
        Me.gestionbtn.Text = "المتصرف"
        Me.gestionbtn.UseVisualStyleBackColor = False
        '
        'N_Cert_Engag_AchtTextBox
        '
        Me.N_Cert_Engag_AchtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Certificat_engagement_achatBindingSource, "N_Cert_Engag_Acht", True))
        Me.N_Cert_Engag_AchtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_Cert_Engag_AchtTextBox.Location = New System.Drawing.Point(134, 94)
        Me.N_Cert_Engag_AchtTextBox.Name = "N_Cert_Engag_AchtTextBox"
        Me.N_Cert_Engag_AchtTextBox.Size = New System.Drawing.Size(200, 26)
        Me.N_Cert_Engag_AchtTextBox.TabIndex = 4
        '
        'Date_Cert_Engeg_AchtDateTimePicker
        '
        Me.Date_Cert_Engeg_AchtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Certificat_engagement_achatBindingSource, "Date_Cert_Engeg_Acht", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "21/05/2022", "d"))
        Me.Date_Cert_Engeg_AchtDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Cert_Engeg_AchtDateTimePicker.Location = New System.Drawing.Point(535, 94)
        Me.Date_Cert_Engeg_AchtDateTimePicker.Name = "Date_Cert_Engeg_AchtDateTimePicker"
        Me.Date_Cert_Engeg_AchtDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_Cert_Engeg_AchtDateTimePicker.TabIndex = 6
        '
        'Cd_gestionComboBox
        '
        Me.Cd_gestionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Certificat_engagement_achatBindingSource, "Cd_gestion", True))
        Me.Cd_gestionComboBox.DataSource = Me.GestionnaireBindingSource
        Me.Cd_gestionComboBox.DisplayMember = "Nom_gestion"
        Me.Cd_gestionComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_gestionComboBox.FormattingEnabled = True
        Me.Cd_gestionComboBox.Location = New System.Drawing.Point(535, 192)
        Me.Cd_gestionComboBox.Name = "Cd_gestionComboBox"
        Me.Cd_gestionComboBox.Size = New System.Drawing.Size(200, 28)
        Me.Cd_gestionComboBox.TabIndex = 10
        Me.Cd_gestionComboBox.ValueMember = "Cd_gestion"
        '
        'Beneficiaire_cd_beneComboBox
        '
        Me.Beneficiaire_cd_beneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Certificat_engagement_achatBindingSource, "beneficiaire_cd_bene", True))
        Me.Beneficiaire_cd_beneComboBox.DataSource = Me.BeneficiaireBindingSource
        Me.Beneficiaire_cd_beneComboBox.DisplayMember = "Cd_bene"
        Me.Beneficiaire_cd_beneComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beneficiaire_cd_beneComboBox.FormattingEnabled = True
        Me.Beneficiaire_cd_beneComboBox.Location = New System.Drawing.Point(134, 193)
        Me.Beneficiaire_cd_beneComboBox.Name = "Beneficiaire_cd_beneComboBox"
        Me.Beneficiaire_cd_beneComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Beneficiaire_cd_beneComboBox.TabIndex = 12
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
        'GestionnaireBindingSource
        '
        Me.GestionnaireBindingSource.DataMember = "Gestionnaire"
        Me.GestionnaireBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'GestionnaireTableAdapter
        '
        Me.GestionnaireTableAdapter.ClearBeforeFill = True
        '
        'Form_certificate_engag_achat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 513)
        Me.Controls.Add(Me.Beneficiaire_cd_beneComboBox)
        Me.Controls.Add(N_Cert_Engag_AchtLabel)
        Me.Controls.Add(Me.N_Cert_Engag_AchtTextBox)
        Me.Controls.Add(Date_Cert_Engeg_AchtLabel)
        Me.Controls.Add(Me.Date_Cert_Engeg_AchtDateTimePicker)
        Me.Controls.Add(Beneficiaire_cd_beneLabel)
        Me.Controls.Add(Cd_gestionLabel)
        Me.Controls.Add(Me.Cd_gestionComboBox)
        Me.Controls.Add(Me.gestionbtn)
        Me.Controls.Add(Me.Certificat_engagement_achatDataGridView)
        Me.Controls.Add(Me.Certificat_engagement_achatBindingNavigator)
        Me.Name = "Form_certificate_engag_achat"
        Me.Text = " "
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Certificat_engagement_achatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Certificat_engagement_achatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Certificat_engagement_achatBindingNavigator.ResumeLayout(False)
        Me.Certificat_engagement_achatBindingNavigator.PerformLayout()
        CType(Me.Certificat_engagement_achatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionnaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Certificat_engagement_achatBindingSource As BindingSource
    Friend WithEvents Certificat_engagement_achatTableAdapter As droit_propriter_etatDataSetTableAdapters.Certificat_engagement_achatTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Certificat_engagement_achatBindingNavigator As BindingNavigator
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
    Friend WithEvents Certificat_engagement_achatBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Certificat_engagement_achatDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents gestionbtn As Button
    Friend WithEvents N_Cert_Engag_AchtTextBox As TextBox
    Friend WithEvents Date_Cert_Engeg_AchtDateTimePicker As DateTimePicker
    Friend WithEvents Cd_gestionComboBox As ComboBox
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents Beneficiaire_cd_beneComboBox As ComboBox
    Friend WithEvents BeneficiaireBindingSource As BindingSource
    Friend WithEvents BeneficiaireTableAdapter As droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter
    Friend WithEvents GestionnaireBindingSource As BindingSource
    Friend WithEvents GestionnaireTableAdapter As droit_propriter_etatDataSetTableAdapters.GestionnaireTableAdapter
End Class
