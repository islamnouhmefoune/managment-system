<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_attestation
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
        Dim N_cert_locLabel As System.Windows.Forms.Label
        Dim Dat_cert_loc_Label As System.Windows.Forms.Label
        Dim Deb_paiementLabel As System.Windows.Forms.Label
        Dim Fin_paiementLabel As System.Windows.Forms.Label
        Dim Mont_paiementLabel As System.Windows.Forms.Label
        Dim N_bonLabel As System.Windows.Forms.Label
        Dim Dat_bonLabel As System.Windows.Forms.Label
        Dim Cd_beneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_attestation))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Attestation_paiemnet_loyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Attestation_paiemnet_loyerTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Attestation_paiemnet_loyerTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Attestation_paiemnet_loyerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Attestation_paiemnet_loyerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Attestation_paiemnet_loyerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_cert_locTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_cert_loc_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Deb_paiementDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fin_paiementDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Mont_paiementTextBox = New System.Windows.Forms.TextBox()
        Me.N_bonTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_bonDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cd_beneComboBox = New System.Windows.Forms.ComboBox()
        N_cert_locLabel = New System.Windows.Forms.Label()
        Dat_cert_loc_Label = New System.Windows.Forms.Label()
        Deb_paiementLabel = New System.Windows.Forms.Label()
        Fin_paiementLabel = New System.Windows.Forms.Label()
        Mont_paiementLabel = New System.Windows.Forms.Label()
        N_bonLabel = New System.Windows.Forms.Label()
        Dat_bonLabel = New System.Windows.Forms.Label()
        Cd_beneLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Attestation_paiemnet_loyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Attestation_paiemnet_loyerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Attestation_paiemnet_loyerBindingNavigator.SuspendLayout()
        CType(Me.Attestation_paiemnet_loyerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_cert_locLabel
        '
        N_cert_locLabel.AutoSize = True
        N_cert_locLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_cert_locLabel.ForeColor = System.Drawing.Color.White
        N_cert_locLabel.Location = New System.Drawing.Point(327, 53)
        N_cert_locLabel.Name = "N_cert_locLabel"
        N_cert_locLabel.Size = New System.Drawing.Size(136, 19)
        N_cert_locLabel.TabIndex = 2
        N_cert_locLabel.Text = "رقم شهادة استيفاء الإيجار"
        '
        'Dat_cert_loc_Label
        '
        Dat_cert_loc_Label.AutoSize = True
        Dat_cert_loc_Label.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_cert_loc_Label.ForeColor = System.Drawing.Color.White
        Dat_cert_loc_Label.Location = New System.Drawing.Point(316, 106)
        Dat_cert_loc_Label.Name = "Dat_cert_loc_Label"
        Dat_cert_loc_Label.Size = New System.Drawing.Size(147, 19)
        Dat_cert_loc_Label.TabIndex = 4
        Dat_cert_loc_Label.Text = "تاريخ شهادة استيفاء الإيجار"
        '
        'Deb_paiementLabel
        '
        Deb_paiementLabel.AutoSize = True
        Deb_paiementLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deb_paiementLabel.ForeColor = System.Drawing.Color.White
        Deb_paiementLabel.Location = New System.Drawing.Point(393, 157)
        Deb_paiementLabel.Name = "Deb_paiementLabel"
        Deb_paiementLabel.Size = New System.Drawing.Size(70, 19)
        Deb_paiementLabel.TabIndex = 6
        Deb_paiementLabel.Text = "بداية التسديد"
        '
        'Fin_paiementLabel
        '
        Fin_paiementLabel.AutoSize = True
        Fin_paiementLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fin_paiementLabel.ForeColor = System.Drawing.Color.White
        Fin_paiementLabel.Location = New System.Drawing.Point(392, 201)
        Fin_paiementLabel.Name = "Fin_paiementLabel"
        Fin_paiementLabel.Size = New System.Drawing.Size(71, 19)
        Fin_paiementLabel.TabIndex = 8
        Fin_paiementLabel.Text = "نهاية التسديد"
        '
        'Mont_paiementLabel
        '
        Mont_paiementLabel.AutoSize = True
        Mont_paiementLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mont_paiementLabel.ForeColor = System.Drawing.Color.White
        Mont_paiementLabel.Location = New System.Drawing.Point(808, 53)
        Mont_paiementLabel.Name = "Mont_paiementLabel"
        Mont_paiementLabel.Size = New System.Drawing.Size(74, 19)
        Mont_paiementLabel.TabIndex = 10
        Mont_paiementLabel.Text = "المبلغ التسديد"
        '
        'N_bonLabel
        '
        N_bonLabel.AutoSize = True
        N_bonLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_bonLabel.ForeColor = System.Drawing.Color.White
        N_bonLabel.Location = New System.Drawing.Point(823, 106)
        N_bonLabel.Name = "N_bonLabel"
        N_bonLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        N_bonLabel.Size = New System.Drawing.Size(63, 19)
        N_bonLabel.TabIndex = 12
        N_bonLabel.Text = "رقم الوصل"
        '
        'Dat_bonLabel
        '
        Dat_bonLabel.AutoSize = True
        Dat_bonLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_bonLabel.ForeColor = System.Drawing.Color.White
        Dat_bonLabel.Location = New System.Drawing.Point(815, 157)
        Dat_bonLabel.Name = "Dat_bonLabel"
        Dat_bonLabel.Size = New System.Drawing.Size(67, 19)
        Dat_bonLabel.TabIndex = 14
        Dat_bonLabel.Text = "تاريخ وصل"
        '
        'Cd_beneLabel
        '
        Cd_beneLabel.AutoSize = True
        Cd_beneLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_beneLabel.ForeColor = System.Drawing.Color.White
        Cd_beneLabel.Location = New System.Drawing.Point(810, 201)
        Cd_beneLabel.Name = "Cd_beneLabel"
        Cd_beneLabel.Size = New System.Drawing.Size(72, 19)
        Cd_beneLabel.TabIndex = 16
        Cd_beneLabel.Text = "رمز المستفيد"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Attestation_paiemnet_loyerBindingSource
        '
        Me.Attestation_paiemnet_loyerBindingSource.DataMember = "Attestation_paiemnet_loyer"
        Me.Attestation_paiemnet_loyerBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Attestation_paiemnet_loyerTableAdapter
        '
        Me.Attestation_paiemnet_loyerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Nothing
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager.Attestation_paiemnet_loyerTableAdapter = Me.Attestation_paiemnet_loyerTableAdapter
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
        'Attestation_paiemnet_loyerBindingNavigator
        '
        Me.Attestation_paiemnet_loyerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Attestation_paiemnet_loyerBindingNavigator.BindingSource = Me.Attestation_paiemnet_loyerBindingSource
        Me.Attestation_paiemnet_loyerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Attestation_paiemnet_loyerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Attestation_paiemnet_loyerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Attestation_paiemnet_loyerBindingNavigatorSaveItem})
        Me.Attestation_paiemnet_loyerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Attestation_paiemnet_loyerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Attestation_paiemnet_loyerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Attestation_paiemnet_loyerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Attestation_paiemnet_loyerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Attestation_paiemnet_loyerBindingNavigator.Name = "Attestation_paiemnet_loyerBindingNavigator"
        Me.Attestation_paiemnet_loyerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Attestation_paiemnet_loyerBindingNavigator.Size = New System.Drawing.Size(981, 25)
        Me.Attestation_paiemnet_loyerBindingNavigator.TabIndex = 0
        Me.Attestation_paiemnet_loyerBindingNavigator.Text = "BindingNavigator1"
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
        'Attestation_paiemnet_loyerBindingNavigatorSaveItem
        '
        Me.Attestation_paiemnet_loyerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Attestation_paiemnet_loyerBindingNavigatorSaveItem.Image = CType(resources.GetObject("Attestation_paiemnet_loyerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Attestation_paiemnet_loyerBindingNavigatorSaveItem.Name = "Attestation_paiemnet_loyerBindingNavigatorSaveItem"
        Me.Attestation_paiemnet_loyerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Attestation_paiemnet_loyerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Attestation_paiemnet_loyerDataGridView
        '
        Me.Attestation_paiemnet_loyerDataGridView.AutoGenerateColumns = False
        Me.Attestation_paiemnet_loyerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Attestation_paiemnet_loyerDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Attestation_paiemnet_loyerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Attestation_paiemnet_loyerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Attestation_paiemnet_loyerDataGridView.DataSource = Me.Attestation_paiemnet_loyerBindingSource
        Me.Attestation_paiemnet_loyerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Attestation_paiemnet_loyerDataGridView.Location = New System.Drawing.Point(0, 283)
        Me.Attestation_paiemnet_loyerDataGridView.Name = "Attestation_paiemnet_loyerDataGridView"
        Me.Attestation_paiemnet_loyerDataGridView.ReadOnly = True
        Me.Attestation_paiemnet_loyerDataGridView.Size = New System.Drawing.Size(981, 220)
        Me.Attestation_paiemnet_loyerDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "N_cert_loc"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N_cert_loc"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_cert_loc_"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_cert_loc_"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Deb_paiement"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Deb_paiement"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fin_paiement"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fin_paiement"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Mont_paiement"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mont_paiement"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "N_bon"
        Me.DataGridViewTextBoxColumn6.HeaderText = "N_bon"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Dat_bon"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Dat_bon"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cd_bene"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cd_bene"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'N_cert_locTextBox
        '
        Me.N_cert_locTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Attestation_paiemnet_loyerBindingSource, "N_cert_loc", True))
        Me.N_cert_locTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_cert_locTextBox.Location = New System.Drawing.Point(75, 50)
        Me.N_cert_locTextBox.Name = "N_cert_locTextBox"
        Me.N_cert_locTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_cert_locTextBox.TabIndex = 3
        '
        'Dat_cert_loc_DateTimePicker
        '
        Me.Dat_cert_loc_DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Attestation_paiemnet_loyerBindingSource, "Dat_cert_loc_", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Dat_cert_loc_DateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_cert_loc_DateTimePicker.Location = New System.Drawing.Point(75, 100)
        Me.Dat_cert_loc_DateTimePicker.Name = "Dat_cert_loc_DateTimePicker"
        Me.Dat_cert_loc_DateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_cert_loc_DateTimePicker.TabIndex = 5
        '
        'Deb_paiementDateTimePicker
        '
        Me.Deb_paiementDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Attestation_paiemnet_loyerBindingSource, "Deb_paiement", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Deb_paiementDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deb_paiementDateTimePicker.Location = New System.Drawing.Point(75, 151)
        Me.Deb_paiementDateTimePicker.Name = "Deb_paiementDateTimePicker"
        Me.Deb_paiementDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Deb_paiementDateTimePicker.TabIndex = 7
        '
        'Fin_paiementDateTimePicker
        '
        Me.Fin_paiementDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Attestation_paiemnet_loyerBindingSource, "Fin_paiement", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Fin_paiementDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fin_paiementDateTimePicker.Location = New System.Drawing.Point(75, 195)
        Me.Fin_paiementDateTimePicker.Name = "Fin_paiementDateTimePicker"
        Me.Fin_paiementDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Fin_paiementDateTimePicker.TabIndex = 9
        '
        'Mont_paiementTextBox
        '
        Me.Mont_paiementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Attestation_paiemnet_loyerBindingSource, "Mont_paiement", True))
        Me.Mont_paiementTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mont_paiementTextBox.Location = New System.Drawing.Point(499, 50)
        Me.Mont_paiementTextBox.Name = "Mont_paiementTextBox"
        Me.Mont_paiementTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Mont_paiementTextBox.TabIndex = 11
        '
        'N_bonTextBox
        '
        Me.N_bonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Attestation_paiemnet_loyerBindingSource, "N_bon", True))
        Me.N_bonTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_bonTextBox.Location = New System.Drawing.Point(499, 100)
        Me.N_bonTextBox.Name = "N_bonTextBox"
        Me.N_bonTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_bonTextBox.TabIndex = 13
        '
        'Dat_bonDateTimePicker
        '
        Me.Dat_bonDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Attestation_paiemnet_loyerBindingSource, "Dat_bon", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Dat_bonDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_bonDateTimePicker.Location = New System.Drawing.Point(499, 151)
        Me.Dat_bonDateTimePicker.Name = "Dat_bonDateTimePicker"
        Me.Dat_bonDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_bonDateTimePicker.TabIndex = 15
        '
        'Cd_beneComboBox
        '
        Me.Cd_beneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Attestation_paiemnet_loyerBindingSource, "Cd_bene", True))
        Me.Cd_beneComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_beneComboBox.FormattingEnabled = True
        Me.Cd_beneComboBox.Location = New System.Drawing.Point(499, 198)
        Me.Cd_beneComboBox.Name = "Cd_beneComboBox"
        Me.Cd_beneComboBox.Size = New System.Drawing.Size(200, 27)
        Me.Cd_beneComboBox.TabIndex = 17
        '
        'Form_attestation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(981, 503)
        Me.Controls.Add(N_cert_locLabel)
        Me.Controls.Add(Me.N_cert_locTextBox)
        Me.Controls.Add(Dat_cert_loc_Label)
        Me.Controls.Add(Me.Dat_cert_loc_DateTimePicker)
        Me.Controls.Add(Deb_paiementLabel)
        Me.Controls.Add(Me.Deb_paiementDateTimePicker)
        Me.Controls.Add(Fin_paiementLabel)
        Me.Controls.Add(Me.Fin_paiementDateTimePicker)
        Me.Controls.Add(Mont_paiementLabel)
        Me.Controls.Add(Me.Mont_paiementTextBox)
        Me.Controls.Add(N_bonLabel)
        Me.Controls.Add(Me.N_bonTextBox)
        Me.Controls.Add(Dat_bonLabel)
        Me.Controls.Add(Me.Dat_bonDateTimePicker)
        Me.Controls.Add(Cd_beneLabel)
        Me.Controls.Add(Me.Cd_beneComboBox)
        Me.Controls.Add(Me.Attestation_paiemnet_loyerDataGridView)
        Me.Controls.Add(Me.Attestation_paiemnet_loyerBindingNavigator)
        Me.Name = "Form_attestation"
        Me.Text = "Form_attestation"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Attestation_paiemnet_loyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Attestation_paiemnet_loyerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Attestation_paiemnet_loyerBindingNavigator.ResumeLayout(False)
        Me.Attestation_paiemnet_loyerBindingNavigator.PerformLayout()
        CType(Me.Attestation_paiemnet_loyerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Attestation_paiemnet_loyerBindingSource As BindingSource
    Friend WithEvents Attestation_paiemnet_loyerTableAdapter As droit_propriter_etatDataSetTableAdapters.Attestation_paiemnet_loyerTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Attestation_paiemnet_loyerBindingNavigator As BindingNavigator
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
    Friend WithEvents Attestation_paiemnet_loyerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Attestation_paiemnet_loyerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents N_cert_locTextBox As TextBox
    Friend WithEvents Dat_cert_loc_DateTimePicker As DateTimePicker
    Friend WithEvents Deb_paiementDateTimePicker As DateTimePicker
    Friend WithEvents Fin_paiementDateTimePicker As DateTimePicker
    Friend WithEvents Mont_paiementTextBox As TextBox
    Friend WithEvents N_bonTextBox As TextBox
    Friend WithEvents Dat_bonDateTimePicker As DateTimePicker
    Friend WithEvents Cd_beneComboBox As ComboBox
End Class
