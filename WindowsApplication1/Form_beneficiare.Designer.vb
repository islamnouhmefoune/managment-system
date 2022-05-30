<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_beneficiare
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
        Dim Nom_beneLabel As System.Windows.Forms.Label
        Dim Pre_beneLabel As System.Windows.Forms.Label
        Dim Date_naisLabel As System.Windows.Forms.Label
        Dim Lieu_naisLabel As System.Windows.Forms.Label
        Dim Pre_pere_beneLabel As System.Windows.Forms.Label
        Dim Nom_mere_beneLabel As System.Windows.Forms.Label
        Dim Pre_mere_beneLabel As System.Windows.Forms.Label
        Dim Residence_cd_residenceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_beneficiare))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.BeneficiaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.BeneficiaireBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BeneficiaireBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BeneficiaireDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_beneTextBox = New System.Windows.Forms.TextBox()
        Me.Pre_beneTextBox = New System.Windows.Forms.TextBox()
        Me.Date_naisDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Lieu_naisTextBox = New System.Windows.Forms.TextBox()
        Me.Pre_pere_beneTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_mere_beneTextBox = New System.Windows.Forms.TextBox()
        Me.Pre_mere_beneTextBox = New System.Windows.Forms.TextBox()
        Me.Residence_cd_residenceComboBox = New System.Windows.Forms.ComboBox()
        Me.ResidenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResidenceTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.ResidenceTableAdapter()
        Nom_beneLabel = New System.Windows.Forms.Label()
        Pre_beneLabel = New System.Windows.Forms.Label()
        Date_naisLabel = New System.Windows.Forms.Label()
        Lieu_naisLabel = New System.Windows.Forms.Label()
        Pre_pere_beneLabel = New System.Windows.Forms.Label()
        Nom_mere_beneLabel = New System.Windows.Forms.Label()
        Pre_mere_beneLabel = New System.Windows.Forms.Label()
        Residence_cd_residenceLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BeneficiaireBindingNavigator.SuspendLayout()
        CType(Me.BeneficiaireDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nom_beneLabel
        '
        Nom_beneLabel.AutoSize = True
        Nom_beneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_beneLabel.ForeColor = System.Drawing.Color.White
        Nom_beneLabel.Location = New System.Drawing.Point(319, 54)
        Nom_beneLabel.Name = "Nom_beneLabel"
        Nom_beneLabel.Size = New System.Drawing.Size(79, 20)
        Nom_beneLabel.TabIndex = 4
        Nom_beneLabel.Text = "لقــب المستفيد"
        '
        'Pre_beneLabel
        '
        Pre_beneLabel.AutoSize = True
        Pre_beneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pre_beneLabel.ForeColor = System.Drawing.Color.White
        Pre_beneLabel.Location = New System.Drawing.Point(324, 101)
        Pre_beneLabel.Name = "Pre_beneLabel"
        Pre_beneLabel.Size = New System.Drawing.Size(74, 20)
        Pre_beneLabel.TabIndex = 6
        Pre_beneLabel.Text = "اسـم المستفيد"
        '
        'Date_naisLabel
        '
        Date_naisLabel.AutoSize = True
        Date_naisLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_naisLabel.ForeColor = System.Drawing.Color.White
        Date_naisLabel.Location = New System.Drawing.Point(321, 155)
        Date_naisLabel.Name = "Date_naisLabel"
        Date_naisLabel.Size = New System.Drawing.Size(77, 20)
        Date_naisLabel.TabIndex = 8
        Date_naisLabel.Text = "تاريخ الميلاد "
        '
        'Lieu_naisLabel
        '
        Lieu_naisLabel.AutoSize = True
        Lieu_naisLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lieu_naisLabel.ForeColor = System.Drawing.Color.White
        Lieu_naisLabel.Location = New System.Drawing.Point(327, 205)
        Lieu_naisLabel.Name = "Lieu_naisLabel"
        Lieu_naisLabel.Size = New System.Drawing.Size(71, 20)
        Lieu_naisLabel.TabIndex = 10
        Lieu_naisLabel.Text = "مكان الميلاد "
        '
        'Pre_pere_beneLabel
        '
        Pre_pere_beneLabel.AutoSize = True
        Pre_pere_beneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pre_pere_beneLabel.ForeColor = System.Drawing.Color.White
        Pre_pere_beneLabel.Location = New System.Drawing.Point(731, 54)
        Pre_pere_beneLabel.Name = "Pre_pere_beneLabel"
        Pre_pere_beneLabel.Size = New System.Drawing.Size(55, 20)
        Pre_pere_beneLabel.TabIndex = 12
        Pre_pere_beneLabel.Text = "إسم الأب"
        '
        'Nom_mere_beneLabel
        '
        Nom_mere_beneLabel.AutoSize = True
        Nom_mere_beneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_mere_beneLabel.ForeColor = System.Drawing.Color.White
        Nom_mere_beneLabel.Location = New System.Drawing.Point(736, 98)
        Nom_mere_beneLabel.Name = "Nom_mere_beneLabel"
        Nom_mere_beneLabel.Size = New System.Drawing.Size(50, 20)
        Nom_mere_beneLabel.TabIndex = 14
        Nom_mere_beneLabel.Text = "لقب الأم"
        '
        'Pre_mere_beneLabel
        '
        Pre_mere_beneLabel.AutoSize = True
        Pre_mere_beneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pre_mere_beneLabel.ForeColor = System.Drawing.Color.White
        Pre_mere_beneLabel.Location = New System.Drawing.Point(737, 152)
        Pre_mere_beneLabel.Name = "Pre_mere_beneLabel"
        Pre_mere_beneLabel.Size = New System.Drawing.Size(49, 20)
        Pre_mere_beneLabel.TabIndex = 16
        Pre_mere_beneLabel.Text = "إسم الأم"
        '
        'Residence_cd_residenceLabel
        '
        Residence_cd_residenceLabel.AutoSize = True
        Residence_cd_residenceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Residence_cd_residenceLabel.ForeColor = System.Drawing.Color.White
        Residence_cd_residenceLabel.Location = New System.Drawing.Point(719, 205)
        Residence_cd_residenceLabel.Name = "Residence_cd_residenceLabel"
        Residence_cd_residenceLabel.Size = New System.Drawing.Size(67, 20)
        Residence_cd_residenceLabel.TabIndex = 18
        Residence_cd_residenceLabel.Text = "رمز الإقامة"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Nothing
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager.Attestation_paiemnet_loyerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiaireTableAdapter = Me.BeneficiaireTableAdapter
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
        'BeneficiaireBindingNavigator
        '
        Me.BeneficiaireBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BeneficiaireBindingNavigator.AutoSize = False
        Me.BeneficiaireBindingNavigator.BindingSource = Me.BeneficiaireBindingSource
        Me.BeneficiaireBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BeneficiaireBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BeneficiaireBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BeneficiaireBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BeneficiaireBindingNavigatorSaveItem})
        Me.BeneficiaireBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.BeneficiaireBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BeneficiaireBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BeneficiaireBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BeneficiaireBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BeneficiaireBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BeneficiaireBindingNavigator.Name = "BeneficiaireBindingNavigator"
        Me.BeneficiaireBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BeneficiaireBindingNavigator.Size = New System.Drawing.Size(913, 27)
        Me.BeneficiaireBindingNavigator.TabIndex = 0
        Me.BeneficiaireBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 24)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BeneficiaireBindingNavigatorSaveItem
        '
        Me.BeneficiaireBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BeneficiaireBindingNavigatorSaveItem.Image = CType(resources.GetObject("BeneficiaireBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BeneficiaireBindingNavigatorSaveItem.Name = "BeneficiaireBindingNavigatorSaveItem"
        Me.BeneficiaireBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 24)
        Me.BeneficiaireBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BeneficiaireDataGridView
        '
        Me.BeneficiaireDataGridView.AutoGenerateColumns = False
        Me.BeneficiaireDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BeneficiaireDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.BeneficiaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BeneficiaireDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.BeneficiaireDataGridView.DataSource = Me.BeneficiaireBindingSource
        Me.BeneficiaireDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BeneficiaireDataGridView.Location = New System.Drawing.Point(0, 293)
        Me.BeneficiaireDataGridView.Name = "BeneficiaireDataGridView"
        Me.BeneficiaireDataGridView.ReadOnly = True
        Me.BeneficiaireDataGridView.Size = New System.Drawing.Size(913, 220)
        Me.BeneficiaireDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_bene"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_bene"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom_bene"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom_bene"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "pre_bene"
        Me.DataGridViewTextBoxColumn3.HeaderText = "pre_bene"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date_nais"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date_nais"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "lieu_nais"
        Me.DataGridViewTextBoxColumn5.HeaderText = "lieu_nais"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pre_pere_bene"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pre_pere_bene"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nom_mere_bene"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nom_mere_bene"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Pre_mere_bene"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Pre_mere_bene"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "residence_cd_residence"
        Me.DataGridViewTextBoxColumn9.HeaderText = "residence_cd_residence"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Nom_beneTextBox
        '
        Me.Nom_beneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiaireBindingSource, "nom_bene", True))
        Me.Nom_beneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_beneTextBox.Location = New System.Drawing.Point(60, 51)
        Me.Nom_beneTextBox.Name = "Nom_beneTextBox"
        Me.Nom_beneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Nom_beneTextBox.TabIndex = 5
        '
        'Pre_beneTextBox
        '
        Me.Pre_beneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiaireBindingSource, "pre_bene", True))
        Me.Pre_beneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pre_beneTextBox.Location = New System.Drawing.Point(60, 98)
        Me.Pre_beneTextBox.Name = "Pre_beneTextBox"
        Me.Pre_beneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Pre_beneTextBox.TabIndex = 7
        '
        'Date_naisDateTimePicker
        '
        Me.Date_naisDateTimePicker.Checked = False
        Me.Date_naisDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BeneficiaireBindingSource, "Date_nais", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "21/06/2006", "d"))
        Me.Date_naisDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_naisDateTimePicker.Location = New System.Drawing.Point(60, 150)
        Me.Date_naisDateTimePicker.Name = "Date_naisDateTimePicker"
        Me.Date_naisDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_naisDateTimePicker.TabIndex = 10
        Me.Date_naisDateTimePicker.Value = New Date(2022, 5, 21, 0, 0, 0, 0)
        '
        'Lieu_naisTextBox
        '
        Me.Lieu_naisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiaireBindingSource, "lieu_nais", True))
        Me.Lieu_naisTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lieu_naisTextBox.Location = New System.Drawing.Point(60, 202)
        Me.Lieu_naisTextBox.Name = "Lieu_naisTextBox"
        Me.Lieu_naisTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Lieu_naisTextBox.TabIndex = 11
        '
        'Pre_pere_beneTextBox
        '
        Me.Pre_pere_beneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiaireBindingSource, "pre_pere_bene", True))
        Me.Pre_pere_beneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pre_pere_beneTextBox.Location = New System.Drawing.Point(464, 51)
        Me.Pre_pere_beneTextBox.Name = "Pre_pere_beneTextBox"
        Me.Pre_pere_beneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Pre_pere_beneTextBox.TabIndex = 13
        '
        'Nom_mere_beneTextBox
        '
        Me.Nom_mere_beneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiaireBindingSource, "Nom_mere_bene", True))
        Me.Nom_mere_beneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_mere_beneTextBox.Location = New System.Drawing.Point(464, 98)
        Me.Nom_mere_beneTextBox.Name = "Nom_mere_beneTextBox"
        Me.Nom_mere_beneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Nom_mere_beneTextBox.TabIndex = 15
        '
        'Pre_mere_beneTextBox
        '
        Me.Pre_mere_beneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BeneficiaireBindingSource, "Pre_mere_bene", True))
        Me.Pre_mere_beneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pre_mere_beneTextBox.Location = New System.Drawing.Point(464, 152)
        Me.Pre_mere_beneTextBox.Name = "Pre_mere_beneTextBox"
        Me.Pre_mere_beneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Pre_mere_beneTextBox.TabIndex = 17
        '
        'Residence_cd_residenceComboBox
        '
        Me.Residence_cd_residenceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BeneficiaireBindingSource, "residence_cd_residence", True))
        Me.Residence_cd_residenceComboBox.DataSource = Me.ResidenceBindingSource
        Me.Residence_cd_residenceComboBox.DisplayMember = "Cd_residence"
        Me.Residence_cd_residenceComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Residence_cd_residenceComboBox.FormattingEnabled = True
        Me.Residence_cd_residenceComboBox.Location = New System.Drawing.Point(464, 202)
        Me.Residence_cd_residenceComboBox.Name = "Residence_cd_residenceComboBox"
        Me.Residence_cd_residenceComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Residence_cd_residenceComboBox.TabIndex = 23
        Me.Residence_cd_residenceComboBox.ValueMember = "Cd_residence"
        '
        'ResidenceBindingSource
        '
        Me.ResidenceBindingSource.DataMember = "Residence"
        Me.ResidenceBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'ResidenceTableAdapter
        '
        Me.ResidenceTableAdapter.ClearBeforeFill = True
        '
        'Form_beneficiare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 513)
        Me.Controls.Add(Me.Residence_cd_residenceComboBox)
        Me.Controls.Add(Nom_beneLabel)
        Me.Controls.Add(Me.Nom_beneTextBox)
        Me.Controls.Add(Pre_beneLabel)
        Me.Controls.Add(Me.Pre_beneTextBox)
        Me.Controls.Add(Date_naisLabel)
        Me.Controls.Add(Me.Date_naisDateTimePicker)
        Me.Controls.Add(Lieu_naisLabel)
        Me.Controls.Add(Me.Lieu_naisTextBox)
        Me.Controls.Add(Pre_pere_beneLabel)
        Me.Controls.Add(Me.Pre_pere_beneTextBox)
        Me.Controls.Add(Nom_mere_beneLabel)
        Me.Controls.Add(Me.Nom_mere_beneTextBox)
        Me.Controls.Add(Pre_mere_beneLabel)
        Me.Controls.Add(Me.Pre_mere_beneTextBox)
        Me.Controls.Add(Residence_cd_residenceLabel)
        Me.Controls.Add(Me.BeneficiaireDataGridView)
        Me.Controls.Add(Me.BeneficiaireBindingNavigator)
        Me.Name = "Form_beneficiare"
        Me.Text = "Form_beneficiare"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BeneficiaireBindingNavigator.ResumeLayout(False)
        Me.BeneficiaireBindingNavigator.PerformLayout()
        CType(Me.BeneficiaireDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents BeneficiaireBindingSource As BindingSource
    Friend WithEvents BeneficiaireTableAdapter As droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BeneficiaireBindingNavigator As BindingNavigator
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
    Friend WithEvents BeneficiaireBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BeneficiaireDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Nom_beneTextBox As TextBox
    Friend WithEvents Pre_beneTextBox As TextBox
    Friend WithEvents Date_naisDateTimePicker As DateTimePicker
    Friend WithEvents Lieu_naisTextBox As TextBox
    Friend WithEvents Pre_pere_beneTextBox As TextBox
    Friend WithEvents Nom_mere_beneTextBox As TextBox
    Friend WithEvents Pre_mere_beneTextBox As TextBox
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents Residence_cd_residenceComboBox As ComboBox
    Friend WithEvents ResidenceBindingSource As BindingSource
    Friend WithEvents ResidenceTableAdapter As droit_propriter_etatDataSetTableAdapters.ResidenceTableAdapter
End Class
