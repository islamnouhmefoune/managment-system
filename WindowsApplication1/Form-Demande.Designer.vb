<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Demande
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
        Dim Dat_dem_acquLabel As System.Windows.Forms.Label
        Dim N_dem_acquLabel As System.Windows.Forms.Label
        Dim N_rapp_ren_immbLabel As System.Windows.Forms.Label
        Dim Cd_Pv_com_cessLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Demande))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Demande_acquisitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Demande_acquisitionTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Demande_acquisitionTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Demande_acquisitionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Demande_acquisitionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Demande_acquisitionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dat_dem_acquDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_dem_acquTextBox = New System.Windows.Forms.TextBox()
        Me.N_rapp_ren_immbComboBox = New System.Windows.Forms.ComboBox()
        Me.Cd_Pv_com_cessComboBox = New System.Windows.Forms.ComboBox()
        Me.PV_Commession_CessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PV_Commession_CessionTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.PV_Commession_CessionTableAdapter()
        Me.Arrete_cession_bien_etatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Arrete_cession_bien_etatTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Arrete_cession_bien_etatTableAdapter()
        Dat_dem_acquLabel = New System.Windows.Forms.Label()
        N_dem_acquLabel = New System.Windows.Forms.Label()
        N_rapp_ren_immbLabel = New System.Windows.Forms.Label()
        Cd_Pv_com_cessLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Demande_acquisitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Demande_acquisitionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Demande_acquisitionBindingNavigator.SuspendLayout()
        CType(Me.Demande_acquisitionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PV_Commession_CessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arrete_cession_bien_etatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dat_dem_acquLabel
        '
        Dat_dem_acquLabel.AutoSize = True
        Dat_dem_acquLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_dem_acquLabel.ForeColor = System.Drawing.Color.White
        Dat_dem_acquLabel.Location = New System.Drawing.Point(193, 147)
        Dat_dem_acquLabel.Name = "Dat_dem_acquLabel"
        Dat_dem_acquLabel.Size = New System.Drawing.Size(120, 19)
        Dat_dem_acquLabel.TabIndex = 4
        Dat_dem_acquLabel.Text = "تاريخ الطلب الاكتساب"
        '
        'N_dem_acquLabel
        '
        N_dem_acquLabel.AutoSize = True
        N_dem_acquLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_dem_acquLabel.ForeColor = System.Drawing.Color.White
        N_dem_acquLabel.Location = New System.Drawing.Point(201, 50)
        N_dem_acquLabel.Name = "N_dem_acquLabel"
        N_dem_acquLabel.Size = New System.Drawing.Size(112, 19)
        N_dem_acquLabel.TabIndex = 6
        N_dem_acquLabel.Text = "رقـم الطلب الاكتساب"
        '
        'N_rapp_ren_immbLabel
        '
        N_rapp_ren_immbLabel.AutoSize = True
        N_rapp_ren_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_rapp_ren_immbLabel.ForeColor = System.Drawing.Color.White
        N_rapp_ren_immbLabel.Location = New System.Drawing.Point(648, 147)
        N_rapp_ren_immbLabel.Name = "N_rapp_ren_immbLabel"
        N_rapp_ren_immbLabel.Size = New System.Drawing.Size(193, 19)
        N_rapp_ren_immbLabel.TabIndex = 8
        N_rapp_ren_immbLabel.Text = "رقم مقرر التنازل عن الأملاك العقارية"
        '
        'Cd_Pv_com_cessLabel
        '
        Cd_Pv_com_cessLabel.AutoSize = True
        Cd_Pv_com_cessLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_Pv_com_cessLabel.ForeColor = System.Drawing.Color.White
        Cd_Pv_com_cessLabel.Location = New System.Drawing.Point(663, 50)
        Cd_Pv_com_cessLabel.Name = "Cd_Pv_com_cessLabel"
        Cd_Pv_com_cessLabel.Size = New System.Drawing.Size(168, 19)
        Cd_Pv_com_cessLabel.TabIndex = 10
        Cd_Pv_com_cessLabel.Text = "رمز محضر اجتماع لجنة التنازل"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Demande_acquisitionBindingSource
        '
        Me.Demande_acquisitionBindingSource.DataMember = "Demande_acquisition"
        Me.Demande_acquisitionBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Demande_acquisitionTableAdapter
        '
        Me.Demande_acquisitionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Demande_acquisitionTableAdapter = Me.Demande_acquisitionTableAdapter
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
        'Demande_acquisitionBindingNavigator
        '
        Me.Demande_acquisitionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Demande_acquisitionBindingNavigator.BindingSource = Me.Demande_acquisitionBindingSource
        Me.Demande_acquisitionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Demande_acquisitionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Demande_acquisitionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Demande_acquisitionBindingNavigatorSaveItem})
        Me.Demande_acquisitionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Demande_acquisitionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Demande_acquisitionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Demande_acquisitionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Demande_acquisitionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Demande_acquisitionBindingNavigator.Name = "Demande_acquisitionBindingNavigator"
        Me.Demande_acquisitionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Demande_acquisitionBindingNavigator.Size = New System.Drawing.Size(1035, 25)
        Me.Demande_acquisitionBindingNavigator.TabIndex = 0
        Me.Demande_acquisitionBindingNavigator.Text = "BindingNavigator1"
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
        'Demande_acquisitionBindingNavigatorSaveItem
        '
        Me.Demande_acquisitionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Demande_acquisitionBindingNavigatorSaveItem.Image = CType(resources.GetObject("Demande_acquisitionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Demande_acquisitionBindingNavigatorSaveItem.Name = "Demande_acquisitionBindingNavigatorSaveItem"
        Me.Demande_acquisitionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Demande_acquisitionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Demande_acquisitionDataGridView
        '
        Me.Demande_acquisitionDataGridView.AutoGenerateColumns = False
        Me.Demande_acquisitionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Demande_acquisitionDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Demande_acquisitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Demande_acquisitionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Demande_acquisitionDataGridView.DataSource = Me.Demande_acquisitionBindingSource
        Me.Demande_acquisitionDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Demande_acquisitionDataGridView.Location = New System.Drawing.Point(0, 276)
        Me.Demande_acquisitionDataGridView.Name = "Demande_acquisitionDataGridView"
        Me.Demande_acquisitionDataGridView.ReadOnly = True
        Me.Demande_acquisitionDataGridView.Size = New System.Drawing.Size(1035, 220)
        Me.Demande_acquisitionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_dem"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_dem"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_dem_acqu"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_dem_acqu"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "N_dem_acqu"
        Me.DataGridViewTextBoxColumn3.HeaderText = "N_dem_acqu"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "N_rapp_ren_immb"
        Me.DataGridViewTextBoxColumn4.HeaderText = "N_rapp_ren_immb"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cd_Pv_com_cess"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cd_Pv_com_cess"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Dat_dem_acquDateTimePicker
        '
        Me.Dat_dem_acquDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Demande_acquisitionBindingSource, "Dat_dem_acqu", True))
        Me.Dat_dem_acquDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_dem_acquDateTimePicker.Location = New System.Drawing.Point(147, 181)
        Me.Dat_dem_acquDateTimePicker.Name = "Dat_dem_acquDateTimePicker"
        Me.Dat_dem_acquDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_dem_acquDateTimePicker.TabIndex = 5
        '
        'N_dem_acquTextBox
        '
        Me.N_dem_acquTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Demande_acquisitionBindingSource, "N_dem_acqu", True))
        Me.N_dem_acquTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_dem_acquTextBox.Location = New System.Drawing.Point(147, 89)
        Me.N_dem_acquTextBox.Name = "N_dem_acquTextBox"
        Me.N_dem_acquTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_dem_acquTextBox.TabIndex = 7
        '
        'N_rapp_ren_immbComboBox
        '
        Me.N_rapp_ren_immbComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Demande_acquisitionBindingSource, "N_rapp_ren_immb", True))
        Me.N_rapp_ren_immbComboBox.DataSource = Me.Arrete_cession_bien_etatBindingSource
        Me.N_rapp_ren_immbComboBox.DisplayMember = "N_rapp_ren_immb"
        Me.N_rapp_ren_immbComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_rapp_ren_immbComboBox.FormattingEnabled = True
        Me.N_rapp_ren_immbComboBox.Location = New System.Drawing.Point(641, 181)
        Me.N_rapp_ren_immbComboBox.Name = "N_rapp_ren_immbComboBox"
        Me.N_rapp_ren_immbComboBox.Size = New System.Drawing.Size(200, 27)
        Me.N_rapp_ren_immbComboBox.TabIndex = 9
        Me.N_rapp_ren_immbComboBox.ValueMember = "N_rapp_ren_immb"
        '
        'Cd_Pv_com_cessComboBox
        '
        Me.Cd_Pv_com_cessComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Demande_acquisitionBindingSource, "Cd_Pv_com_cess", True))
        Me.Cd_Pv_com_cessComboBox.DataSource = Me.PV_Commession_CessionBindingSource
        Me.Cd_Pv_com_cessComboBox.DisplayMember = "Cd_Pv_com_cess"
        Me.Cd_Pv_com_cessComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_Pv_com_cessComboBox.FormattingEnabled = True
        Me.Cd_Pv_com_cessComboBox.Location = New System.Drawing.Point(641, 89)
        Me.Cd_Pv_com_cessComboBox.Name = "Cd_Pv_com_cessComboBox"
        Me.Cd_Pv_com_cessComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Cd_Pv_com_cessComboBox.TabIndex = 11
        Me.Cd_Pv_com_cessComboBox.ValueMember = "Cd_Pv_com_cess"
        '
        'PV_Commession_CessionBindingSource
        '
        Me.PV_Commession_CessionBindingSource.DataMember = "PV_Commession_Cession"
        Me.PV_Commession_CessionBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'PV_Commession_CessionTableAdapter
        '
        Me.PV_Commession_CessionTableAdapter.ClearBeforeFill = True
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
        'Form_Demande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1035, 496)
        Me.Controls.Add(Dat_dem_acquLabel)
        Me.Controls.Add(Me.Dat_dem_acquDateTimePicker)
        Me.Controls.Add(N_dem_acquLabel)
        Me.Controls.Add(Me.N_dem_acquTextBox)
        Me.Controls.Add(N_rapp_ren_immbLabel)
        Me.Controls.Add(Me.N_rapp_ren_immbComboBox)
        Me.Controls.Add(Cd_Pv_com_cessLabel)
        Me.Controls.Add(Me.Cd_Pv_com_cessComboBox)
        Me.Controls.Add(Me.Demande_acquisitionDataGridView)
        Me.Controls.Add(Me.Demande_acquisitionBindingNavigator)
        Me.Name = "Form_Demande"
        Me.Text = "Form_Demande"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Demande_acquisitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Demande_acquisitionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Demande_acquisitionBindingNavigator.ResumeLayout(False)
        Me.Demande_acquisitionBindingNavigator.PerformLayout()
        CType(Me.Demande_acquisitionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PV_Commession_CessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arrete_cession_bien_etatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Demande_acquisitionBindingSource As BindingSource
    Friend WithEvents Demande_acquisitionTableAdapter As droit_propriter_etatDataSetTableAdapters.Demande_acquisitionTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Demande_acquisitionBindingNavigator As BindingNavigator
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
    Friend WithEvents Demande_acquisitionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Demande_acquisitionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Dat_dem_acquDateTimePicker As DateTimePicker
    Friend WithEvents N_dem_acquTextBox As TextBox
    Friend WithEvents N_rapp_ren_immbComboBox As ComboBox
    Friend WithEvents Cd_Pv_com_cessComboBox As ComboBox
    Friend WithEvents PV_Commession_CessionBindingSource As BindingSource
    Friend WithEvents PV_Commession_CessionTableAdapter As droit_propriter_etatDataSetTableAdapters.PV_Commession_CessionTableAdapter
    Friend WithEvents Arrete_cession_bien_etatBindingSource As BindingSource
    Friend WithEvents Arrete_cession_bien_etatTableAdapter As droit_propriter_etatDataSetTableAdapters.Arrete_cession_bien_etatTableAdapter
End Class
