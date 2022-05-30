<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pv_commisio_cess
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
        Dim Cd_Pv_com_cessLabel As System.Windows.Forms.Label
        Dim Dat_PV_com_cessLabel As System.Windows.Forms.Label
        Dim Cd_comi_reno_immbLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Pv_commisio_cess))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.PV_Commession_CessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PV_Commession_CessionTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.PV_Commession_CessionTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.PV_Commession_CessionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PV_Commession_CessionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PV_Commession_CessionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cd_Pv_com_cessTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_PV_com_cessDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cd_comi_reno_immbComboBox = New System.Windows.Forms.ComboBox()
        Me.pv_commibtn = New System.Windows.Forms.Button()
        Me.Commission_cession_immobiliereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Commission_cession_immobiliereTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Commission_cession_immobiliereTableAdapter()
        Cd_Pv_com_cessLabel = New System.Windows.Forms.Label()
        Dat_PV_com_cessLabel = New System.Windows.Forms.Label()
        Cd_comi_reno_immbLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PV_Commession_CessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PV_Commession_CessionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PV_Commession_CessionBindingNavigator.SuspendLayout()
        CType(Me.PV_Commession_CessionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Commission_cession_immobiliereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cd_Pv_com_cessLabel
        '
        Cd_Pv_com_cessLabel.AutoSize = True
        Cd_Pv_com_cessLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_Pv_com_cessLabel.ForeColor = System.Drawing.Color.White
        Cd_Pv_com_cessLabel.Location = New System.Drawing.Point(122, 53)
        Cd_Pv_com_cessLabel.Name = "Cd_Pv_com_cessLabel"
        Cd_Pv_com_cessLabel.Size = New System.Drawing.Size(168, 19)
        Cd_Pv_com_cessLabel.TabIndex = 2
        Cd_Pv_com_cessLabel.Text = "رمز محضر اجتماع لجنة التنازل"
        '
        'Dat_PV_com_cessLabel
        '
        Dat_PV_com_cessLabel.AutoSize = True
        Dat_PV_com_cessLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_PV_com_cessLabel.ForeColor = System.Drawing.Color.White
        Dat_PV_com_cessLabel.Location = New System.Drawing.Point(724, 53)
        Dat_PV_com_cessLabel.Name = "Dat_PV_com_cessLabel"
        Dat_PV_com_cessLabel.Size = New System.Drawing.Size(175, 19)
        Dat_PV_com_cessLabel.TabIndex = 4
        Dat_PV_com_cessLabel.Text = "تاريخ محضر اجتماع لجنة التنازل"
        '
        'Cd_comi_reno_immbLabel
        '
        Cd_comi_reno_immbLabel.AutoSize = True
        Cd_comi_reno_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_comi_reno_immbLabel.ForeColor = System.Drawing.Color.White
        Cd_comi_reno_immbLabel.Location = New System.Drawing.Point(411, 146)
        Cd_comi_reno_immbLabel.Name = "Cd_comi_reno_immbLabel"
        Cd_comi_reno_immbLabel.Size = New System.Drawing.Size(194, 19)
        Cd_comi_reno_immbLabel.TabIndex = 6
        Cd_comi_reno_immbLabel.Text = "رمز لجنة التنازل عن الاملاك العقارية"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.GestionnaireTableAdapter = Nothing
        Me.TableAdapterManager.LocalTableAdapter = Nothing
        Me.TableAdapterManager.PV_Commession_CessionTableAdapter = Me.PV_Commession_CessionTableAdapter
        Me.TableAdapterManager.QuartierTableAdapter = Nothing
        Me.TableAdapterManager.Rapport_evaluationTableAdapter = Nothing
        Me.TableAdapterManager.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Nothing
        '
        'PV_Commession_CessionBindingNavigator
        '
        Me.PV_Commession_CessionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PV_Commession_CessionBindingNavigator.BindingSource = Me.PV_Commession_CessionBindingSource
        Me.PV_Commession_CessionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PV_Commession_CessionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PV_Commession_CessionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PV_Commession_CessionBindingNavigatorSaveItem})
        Me.PV_Commession_CessionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PV_Commession_CessionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PV_Commession_CessionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PV_Commession_CessionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PV_Commession_CessionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PV_Commession_CessionBindingNavigator.Name = "PV_Commession_CessionBindingNavigator"
        Me.PV_Commession_CessionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PV_Commession_CessionBindingNavigator.Size = New System.Drawing.Size(1034, 25)
        Me.PV_Commession_CessionBindingNavigator.TabIndex = 0
        Me.PV_Commession_CessionBindingNavigator.Text = "BindingNavigator1"
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
        'PV_Commession_CessionBindingNavigatorSaveItem
        '
        Me.PV_Commession_CessionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PV_Commession_CessionBindingNavigatorSaveItem.Image = CType(resources.GetObject("PV_Commession_CessionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PV_Commession_CessionBindingNavigatorSaveItem.Name = "PV_Commession_CessionBindingNavigatorSaveItem"
        Me.PV_Commession_CessionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PV_Commession_CessionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PV_Commession_CessionDataGridView
        '
        Me.PV_Commession_CessionDataGridView.AutoGenerateColumns = False
        Me.PV_Commession_CessionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PV_Commession_CessionDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.PV_Commession_CessionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PV_Commession_CessionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PV_Commession_CessionDataGridView.DataSource = Me.PV_Commession_CessionBindingSource
        Me.PV_Commession_CessionDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PV_Commession_CessionDataGridView.Location = New System.Drawing.Point(0, 289)
        Me.PV_Commession_CessionDataGridView.Name = "PV_Commession_CessionDataGridView"
        Me.PV_Commession_CessionDataGridView.ReadOnly = True
        Me.PV_Commession_CessionDataGridView.Size = New System.Drawing.Size(1034, 220)
        Me.PV_Commession_CessionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_Pv_com_cess"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_Pv_com_cess"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_PV_com_cess"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_PV_com_cess"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cd_comi_reno_immb"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cd_comi_reno_immb"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Cd_Pv_com_cessTextBox
        '
        Me.Cd_Pv_com_cessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PV_Commession_CessionBindingSource, "Cd_Pv_com_cess", True))
        Me.Cd_Pv_com_cessTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_Pv_com_cessTextBox.Location = New System.Drawing.Point(108, 87)
        Me.Cd_Pv_com_cessTextBox.Name = "Cd_Pv_com_cessTextBox"
        Me.Cd_Pv_com_cessTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Cd_Pv_com_cessTextBox.TabIndex = 3
        '
        'Dat_PV_com_cessDateTimePicker
        '
        Me.Dat_PV_com_cessDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PV_Commession_CessionBindingSource, "Dat_PV_com_cess", True))
        Me.Dat_PV_com_cessDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_PV_com_cessDateTimePicker.Location = New System.Drawing.Point(708, 87)
        Me.Dat_PV_com_cessDateTimePicker.Name = "Dat_PV_com_cessDateTimePicker"
        Me.Dat_PV_com_cessDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_PV_com_cessDateTimePicker.TabIndex = 5
        '
        'Cd_comi_reno_immbComboBox
        '
        Me.Cd_comi_reno_immbComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PV_Commession_CessionBindingSource, "Cd_comi_reno_immb", True))
        Me.Cd_comi_reno_immbComboBox.DataSource = Me.Commission_cession_immobiliereBindingSource
        Me.Cd_comi_reno_immbComboBox.DisplayMember = "Cd_comi_reno_immb"
        Me.Cd_comi_reno_immbComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_comi_reno_immbComboBox.FormattingEnabled = True
        Me.Cd_comi_reno_immbComboBox.Location = New System.Drawing.Point(406, 178)
        Me.Cd_comi_reno_immbComboBox.Name = "Cd_comi_reno_immbComboBox"
        Me.Cd_comi_reno_immbComboBox.Size = New System.Drawing.Size(209, 27)
        Me.Cd_comi_reno_immbComboBox.TabIndex = 7
        Me.Cd_comi_reno_immbComboBox.ValueMember = "Cd_comi_reno_immb"
        '
        'pv_commibtn
        '
        Me.pv_commibtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.pv_commibtn.FlatAppearance.BorderSize = 0
        Me.pv_commibtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pv_commibtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pv_commibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pv_commibtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pv_commibtn.ForeColor = System.Drawing.Color.White
        Me.pv_commibtn.Location = New System.Drawing.Point(433, 242)
        Me.pv_commibtn.Name = "pv_commibtn"
        Me.pv_commibtn.Size = New System.Drawing.Size(138, 41)
        Me.pv_commibtn.TabIndex = 9
        Me.pv_commibtn.Text = " طلب الاكتساب"
        Me.pv_commibtn.UseVisualStyleBackColor = False
        '
        'Commission_cession_immobiliereBindingSource
        '
        Me.Commission_cession_immobiliereBindingSource.DataMember = "Commission_cession_immobiliere"
        Me.Commission_cession_immobiliereBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Commission_cession_immobiliereTableAdapter
        '
        Me.Commission_cession_immobiliereTableAdapter.ClearBeforeFill = True
        '
        'Form_Pv_commisio_cess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1034, 509)
        Me.Controls.Add(Me.pv_commibtn)
        Me.Controls.Add(Cd_Pv_com_cessLabel)
        Me.Controls.Add(Me.Cd_Pv_com_cessTextBox)
        Me.Controls.Add(Dat_PV_com_cessLabel)
        Me.Controls.Add(Me.Dat_PV_com_cessDateTimePicker)
        Me.Controls.Add(Cd_comi_reno_immbLabel)
        Me.Controls.Add(Me.Cd_comi_reno_immbComboBox)
        Me.Controls.Add(Me.PV_Commession_CessionDataGridView)
        Me.Controls.Add(Me.PV_Commession_CessionBindingNavigator)
        Me.Name = "Form_Pv_commisio_cess"
        Me.Text = "Form_Pv_commisio_cess"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PV_Commession_CessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PV_Commession_CessionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PV_Commession_CessionBindingNavigator.ResumeLayout(False)
        Me.PV_Commession_CessionBindingNavigator.PerformLayout()
        CType(Me.PV_Commession_CessionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Commission_cession_immobiliereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents PV_Commession_CessionBindingSource As BindingSource
    Friend WithEvents PV_Commession_CessionTableAdapter As droit_propriter_etatDataSetTableAdapters.PV_Commession_CessionTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PV_Commession_CessionBindingNavigator As BindingNavigator
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
    Friend WithEvents PV_Commession_CessionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PV_Commession_CessionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Cd_Pv_com_cessTextBox As TextBox
    Friend WithEvents Dat_PV_com_cessDateTimePicker As DateTimePicker
    Friend WithEvents Cd_comi_reno_immbComboBox As ComboBox
    Friend WithEvents pv_commibtn As Button
    Friend WithEvents Commission_cession_immobiliereBindingSource As BindingSource
    Friend WithEvents Commission_cession_immobiliereTableAdapter As droit_propriter_etatDataSetTableAdapters.Commission_cession_immobiliereTableAdapter
End Class
