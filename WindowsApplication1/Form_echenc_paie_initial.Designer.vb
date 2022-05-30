<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_echenc_paie_initial
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
        Dim N_tab_val_ava_initLabel As System.Windows.Forms.Label
        Dim Dat_tab_val_ava_initLabel As System.Windows.Forms.Label
        Dim Val_ava_initLabel As System.Windows.Forms.Label
        Dim Beneficiaire_cd_beneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_echenc_paie_initial))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Calendrier_valueur_initaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Calendrier_valueur_initaleTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Calendrier_valueur_initaleTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Calendrier_valueur_initaleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Calendrier_valueur_initaleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Calendrier_valueur_initaleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_tab_val_ava_initTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_tab_val_ava_initDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Val_ava_initTextBox = New System.Windows.Forms.TextBox()
        Me.Beneficiaire_cd_beneComboBox = New System.Windows.Forms.ComboBox()
        Me.BeneficiaireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiaireTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter()
        N_tab_val_ava_initLabel = New System.Windows.Forms.Label()
        Dat_tab_val_ava_initLabel = New System.Windows.Forms.Label()
        Val_ava_initLabel = New System.Windows.Forms.Label()
        Beneficiaire_cd_beneLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calendrier_valueur_initaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calendrier_valueur_initaleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Calendrier_valueur_initaleBindingNavigator.SuspendLayout()
        CType(Me.Calendrier_valueur_initaleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_tab_val_ava_initLabel
        '
        N_tab_val_ava_initLabel.AutoSize = True
        N_tab_val_ava_initLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_tab_val_ava_initLabel.ForeColor = System.Drawing.Color.White
        N_tab_val_ava_initLabel.Location = New System.Drawing.Point(324, 81)
        N_tab_val_ava_initLabel.Name = "N_tab_val_ava_initLabel"
        N_tab_val_ava_initLabel.Size = New System.Drawing.Size(191, 19)
        N_tab_val_ava_initLabel.TabIndex = 2
        N_tab_val_ava_initLabel.Text = "رقم جدول الدفع الخاص بقيمة التسبيق"
        '
        'Dat_tab_val_ava_initLabel
        '
        Dat_tab_val_ava_initLabel.AutoSize = True
        Dat_tab_val_ava_initLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_tab_val_ava_initLabel.ForeColor = System.Drawing.Color.White
        Dat_tab_val_ava_initLabel.Location = New System.Drawing.Point(788, 81)
        Dat_tab_val_ava_initLabel.Name = "Dat_tab_val_ava_initLabel"
        Dat_tab_val_ava_initLabel.Size = New System.Drawing.Size(191, 19)
        Dat_tab_val_ava_initLabel.TabIndex = 4
        Dat_tab_val_ava_initLabel.Text = "رقم جدول الدفع الخاص بقيمة التسبيق"
        '
        'Val_ava_initLabel
        '
        Val_ava_initLabel.AutoSize = True
        Val_ava_initLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Val_ava_initLabel.ForeColor = System.Drawing.Color.White
        Val_ava_initLabel.Location = New System.Drawing.Point(406, 170)
        Val_ava_initLabel.Name = "Val_ava_initLabel"
        Val_ava_initLabel.Size = New System.Drawing.Size(109, 19)
        Val_ava_initLabel.TabIndex = 6
        Val_ava_initLabel.Text = "قيمة التسبيق المبدئي"
        '
        'Beneficiaire_cd_beneLabel
        '
        Beneficiaire_cd_beneLabel.AutoSize = True
        Beneficiaire_cd_beneLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Beneficiaire_cd_beneLabel.ForeColor = System.Drawing.Color.White
        Beneficiaire_cd_beneLabel.Location = New System.Drawing.Point(907, 170)
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
        'Calendrier_valueur_initaleBindingSource
        '
        Me.Calendrier_valueur_initaleBindingSource.DataMember = "Calendrier_valueur_initale"
        Me.Calendrier_valueur_initaleBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Calendrier_valueur_initaleTableAdapter
        '
        Me.Calendrier_valueur_initaleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Nothing
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager.Attestation_paiemnet_loyerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiaireTableAdapter = Nothing
        Me.TableAdapterManager.Calendrier_valueur_initaleTableAdapter = Me.Calendrier_valueur_initaleTableAdapter
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
        'Calendrier_valueur_initaleBindingNavigator
        '
        Me.Calendrier_valueur_initaleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Calendrier_valueur_initaleBindingNavigator.BindingSource = Me.Calendrier_valueur_initaleBindingSource
        Me.Calendrier_valueur_initaleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Calendrier_valueur_initaleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Calendrier_valueur_initaleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Calendrier_valueur_initaleBindingNavigatorSaveItem})
        Me.Calendrier_valueur_initaleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Calendrier_valueur_initaleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Calendrier_valueur_initaleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Calendrier_valueur_initaleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Calendrier_valueur_initaleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Calendrier_valueur_initaleBindingNavigator.Name = "Calendrier_valueur_initaleBindingNavigator"
        Me.Calendrier_valueur_initaleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Calendrier_valueur_initaleBindingNavigator.Size = New System.Drawing.Size(1046, 25)
        Me.Calendrier_valueur_initaleBindingNavigator.TabIndex = 0
        Me.Calendrier_valueur_initaleBindingNavigator.Text = "BindingNavigator1"
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
        'Calendrier_valueur_initaleBindingNavigatorSaveItem
        '
        Me.Calendrier_valueur_initaleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Calendrier_valueur_initaleBindingNavigatorSaveItem.Image = CType(resources.GetObject("Calendrier_valueur_initaleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Calendrier_valueur_initaleBindingNavigatorSaveItem.Name = "Calendrier_valueur_initaleBindingNavigatorSaveItem"
        Me.Calendrier_valueur_initaleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Calendrier_valueur_initaleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Calendrier_valueur_initaleDataGridView
        '
        Me.Calendrier_valueur_initaleDataGridView.AutoGenerateColumns = False
        Me.Calendrier_valueur_initaleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Calendrier_valueur_initaleDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Calendrier_valueur_initaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Calendrier_valueur_initaleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Calendrier_valueur_initaleDataGridView.DataSource = Me.Calendrier_valueur_initaleBindingSource
        Me.Calendrier_valueur_initaleDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Calendrier_valueur_initaleDataGridView.Location = New System.Drawing.Point(0, 293)
        Me.Calendrier_valueur_initaleDataGridView.Name = "Calendrier_valueur_initaleDataGridView"
        Me.Calendrier_valueur_initaleDataGridView.ReadOnly = True
        Me.Calendrier_valueur_initaleDataGridView.Size = New System.Drawing.Size(1046, 220)
        Me.Calendrier_valueur_initaleDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_tab_val_ava_init"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_tab_val_ava_init"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_tab_val_ava_init"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_tab_val_ava_init"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Val_ava_init"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Val_ava_init"
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
        'N_tab_val_ava_initTextBox
        '
        Me.N_tab_val_ava_initTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Calendrier_valueur_initaleBindingSource, "N_tab_val_ava_init", True))
        Me.N_tab_val_ava_initTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_tab_val_ava_initTextBox.Location = New System.Drawing.Point(102, 78)
        Me.N_tab_val_ava_initTextBox.Name = "N_tab_val_ava_initTextBox"
        Me.N_tab_val_ava_initTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_tab_val_ava_initTextBox.TabIndex = 3
        '
        'Dat_tab_val_ava_initDateTimePicker
        '
        Me.Dat_tab_val_ava_initDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Calendrier_valueur_initaleBindingSource, "Dat_tab_val_ava_init", True))
        Me.Dat_tab_val_ava_initDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_tab_val_ava_initDateTimePicker.Location = New System.Drawing.Point(561, 78)
        Me.Dat_tab_val_ava_initDateTimePicker.Name = "Dat_tab_val_ava_initDateTimePicker"
        Me.Dat_tab_val_ava_initDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_tab_val_ava_initDateTimePicker.TabIndex = 5
        '
        'Val_ava_initTextBox
        '
        Me.Val_ava_initTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Calendrier_valueur_initaleBindingSource, "Val_ava_init", True))
        Me.Val_ava_initTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Val_ava_initTextBox.Location = New System.Drawing.Point(102, 167)
        Me.Val_ava_initTextBox.Name = "Val_ava_initTextBox"
        Me.Val_ava_initTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Val_ava_initTextBox.TabIndex = 7
        '
        'Beneficiaire_cd_beneComboBox
        '
        Me.Beneficiaire_cd_beneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Calendrier_valueur_initaleBindingSource, "beneficiaire_cd_bene", True))
        Me.Beneficiaire_cd_beneComboBox.DataSource = Me.BeneficiaireBindingSource
        Me.Beneficiaire_cd_beneComboBox.DisplayMember = "Cd_bene"
        Me.Beneficiaire_cd_beneComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beneficiaire_cd_beneComboBox.FormattingEnabled = True
        Me.Beneficiaire_cd_beneComboBox.Location = New System.Drawing.Point(561, 167)
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
        'Form_echenc_paie_initial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1046, 513)
        Me.Controls.Add(Me.Beneficiaire_cd_beneComboBox)
        Me.Controls.Add(N_tab_val_ava_initLabel)
        Me.Controls.Add(Me.N_tab_val_ava_initTextBox)
        Me.Controls.Add(Dat_tab_val_ava_initLabel)
        Me.Controls.Add(Me.Dat_tab_val_ava_initDateTimePicker)
        Me.Controls.Add(Val_ava_initLabel)
        Me.Controls.Add(Me.Val_ava_initTextBox)
        Me.Controls.Add(Beneficiaire_cd_beneLabel)
        Me.Controls.Add(Me.Calendrier_valueur_initaleDataGridView)
        Me.Controls.Add(Me.Calendrier_valueur_initaleBindingNavigator)
        Me.Name = "Form_echenc_paie_initial"
        Me.Text = "Form1"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calendrier_valueur_initaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calendrier_valueur_initaleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Calendrier_valueur_initaleBindingNavigator.ResumeLayout(False)
        Me.Calendrier_valueur_initaleBindingNavigator.PerformLayout()
        CType(Me.Calendrier_valueur_initaleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiaireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Calendrier_valueur_initaleBindingSource As BindingSource
    Friend WithEvents Calendrier_valueur_initaleTableAdapter As droit_propriter_etatDataSetTableAdapters.Calendrier_valueur_initaleTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Calendrier_valueur_initaleBindingNavigator As BindingNavigator
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
    Friend WithEvents Calendrier_valueur_initaleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Calendrier_valueur_initaleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents N_tab_val_ava_initTextBox As TextBox
    Friend WithEvents Dat_tab_val_ava_initDateTimePicker As DateTimePicker
    Friend WithEvents Val_ava_initTextBox As TextBox
    Friend WithEvents Beneficiaire_cd_beneComboBox As ComboBox
    Friend WithEvents BeneficiaireBindingSource As BindingSource
    Friend WithEvents BeneficiaireTableAdapter As droit_propriter_etatDataSetTableAdapters.BeneficiaireTableAdapter
End Class
