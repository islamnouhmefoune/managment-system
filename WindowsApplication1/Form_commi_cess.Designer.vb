<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_commi_cess
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
        Dim Cd_comi_reno_immbLabel As System.Windows.Forms.Label
        Dim N_rapp_cre__reno_immbLabel As System.Windows.Forms.Label
        Dim Dat_rapp_cre_reno_immbLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_commi_cess))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Commission_cession_immobiliereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Commission_cession_immobiliereTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Commission_cession_immobiliereTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Commission_cession_immobiliereBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Commission_cession_immobiliereBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Commission_cession_immobiliereDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cd_comi_reno_immbTextBox = New System.Windows.Forms.TextBox()
        Me.N_rapp_cre__reno_immbTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_rapp_cre_reno_immbDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.pv_commibtn = New System.Windows.Forms.Button()
        Cd_comi_reno_immbLabel = New System.Windows.Forms.Label()
        N_rapp_cre__reno_immbLabel = New System.Windows.Forms.Label()
        Dat_rapp_cre_reno_immbLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Commission_cession_immobiliereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Commission_cession_immobiliereBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Commission_cession_immobiliereBindingNavigator.SuspendLayout()
        CType(Me.Commission_cession_immobiliereDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cd_comi_reno_immbLabel
        '
        Cd_comi_reno_immbLabel.AutoSize = True
        Cd_comi_reno_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_comi_reno_immbLabel.ForeColor = System.Drawing.Color.White
        Cd_comi_reno_immbLabel.Location = New System.Drawing.Point(109, 60)
        Cd_comi_reno_immbLabel.Name = "Cd_comi_reno_immbLabel"
        Cd_comi_reno_immbLabel.Size = New System.Drawing.Size(194, 19)
        Cd_comi_reno_immbLabel.TabIndex = 2
        Cd_comi_reno_immbLabel.Text = "رمز لجنة التنازل عن الاملاك العقارية"
        Cd_comi_reno_immbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Cd_comi_reno_immbLabel.UseMnemonic = False
        '
        'N_rapp_cre__reno_immbLabel
        '
        N_rapp_cre__reno_immbLabel.AutoSize = True
        N_rapp_cre__reno_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_rapp_cre__reno_immbLabel.ForeColor = System.Drawing.Color.White
        N_rapp_cre__reno_immbLabel.Location = New System.Drawing.Point(689, 60)
        N_rapp_cre__reno_immbLabel.Name = "N_rapp_cre__reno_immbLabel"
        N_rapp_cre__reno_immbLabel.Size = New System.Drawing.Size(239, 19)
        N_rapp_cre__reno_immbLabel.TabIndex = 4
        N_rapp_cre__reno_immbLabel.Text = "رقـم مقرر إنشاء لجنة التنازل عن أملاك عقارية"
        '
        'Dat_rapp_cre_reno_immbLabel
        '
        Dat_rapp_cre_reno_immbLabel.AutoSize = True
        Dat_rapp_cre_reno_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_rapp_cre_reno_immbLabel.ForeColor = System.Drawing.Color.White
        Dat_rapp_cre_reno_immbLabel.Location = New System.Drawing.Point(394, 129)
        Dat_rapp_cre_reno_immbLabel.Name = "Dat_rapp_cre_reno_immbLabel"
        Dat_rapp_cre_reno_immbLabel.Size = New System.Drawing.Size(247, 19)
        Dat_rapp_cre_reno_immbLabel.TabIndex = 6
        Dat_rapp_cre_reno_immbLabel.Text = "تاريخ مقرر إنشاء لجنة التنازل عن أملاك عقارية"
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Nothing
        Me.TableAdapterManager.Arrete_cession_bien_etatTableAdapter = Nothing
        Me.TableAdapterManager.Attestation_paiemnet_loyerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeneficiaireTableAdapter = Nothing
        Me.TableAdapterManager.Calendrier_valueur_initaleTableAdapter = Nothing
        Me.TableAdapterManager.Certificat_engagement_achatTableAdapter = Nothing
        Me.TableAdapterManager.Commission_cession_immobiliereTableAdapter = Me.Commission_cession_immobiliereTableAdapter
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
        'Commission_cession_immobiliereBindingNavigator
        '
        Me.Commission_cession_immobiliereBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Commission_cession_immobiliereBindingNavigator.BindingSource = Me.Commission_cession_immobiliereBindingSource
        Me.Commission_cession_immobiliereBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Commission_cession_immobiliereBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Commission_cession_immobiliereBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Commission_cession_immobiliereBindingNavigatorSaveItem})
        Me.Commission_cession_immobiliereBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Commission_cession_immobiliereBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Commission_cession_immobiliereBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Commission_cession_immobiliereBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Commission_cession_immobiliereBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Commission_cession_immobiliereBindingNavigator.Name = "Commission_cession_immobiliereBindingNavigator"
        Me.Commission_cession_immobiliereBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Commission_cession_immobiliereBindingNavigator.Size = New System.Drawing.Size(1055, 25)
        Me.Commission_cession_immobiliereBindingNavigator.TabIndex = 0
        Me.Commission_cession_immobiliereBindingNavigator.Text = "BindingNavigator1"
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
        'Commission_cession_immobiliereBindingNavigatorSaveItem
        '
        Me.Commission_cession_immobiliereBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Commission_cession_immobiliereBindingNavigatorSaveItem.Image = CType(resources.GetObject("Commission_cession_immobiliereBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Commission_cession_immobiliereBindingNavigatorSaveItem.Name = "Commission_cession_immobiliereBindingNavigatorSaveItem"
        Me.Commission_cession_immobiliereBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Commission_cession_immobiliereBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Commission_cession_immobiliereDataGridView
        '
        Me.Commission_cession_immobiliereDataGridView.AutoGenerateColumns = False
        Me.Commission_cession_immobiliereDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Commission_cession_immobiliereDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Commission_cession_immobiliereDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Commission_cession_immobiliereDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Commission_cession_immobiliereDataGridView.DataSource = Me.Commission_cession_immobiliereBindingSource
        Me.Commission_cession_immobiliereDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Commission_cession_immobiliereDataGridView.Location = New System.Drawing.Point(0, 296)
        Me.Commission_cession_immobiliereDataGridView.Name = "Commission_cession_immobiliereDataGridView"
        Me.Commission_cession_immobiliereDataGridView.ReadOnly = True
        Me.Commission_cession_immobiliereDataGridView.Size = New System.Drawing.Size(1055, 220)
        Me.Commission_cession_immobiliereDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_comi_reno_immb"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_comi_reno_immb"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "N_rapp_cre__reno_immb"
        Me.DataGridViewTextBoxColumn2.HeaderText = "N_rapp_cre__reno_immb"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Dat_rapp_cre_reno_immb"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dat_rapp_cre_reno_immb"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Cd_comi_reno_immbTextBox
        '
        Me.Cd_comi_reno_immbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Commission_cession_immobiliereBindingSource, "Cd_comi_reno_immb", True))
        Me.Cd_comi_reno_immbTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_comi_reno_immbTextBox.Location = New System.Drawing.Point(103, 97)
        Me.Cd_comi_reno_immbTextBox.Name = "Cd_comi_reno_immbTextBox"
        Me.Cd_comi_reno_immbTextBox.ReadOnly = True
        Me.Cd_comi_reno_immbTextBox.Size = New System.Drawing.Size(210, 27)
        Me.Cd_comi_reno_immbTextBox.TabIndex = 3
        '
        'N_rapp_cre__reno_immbTextBox
        '
        Me.N_rapp_cre__reno_immbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Commission_cession_immobiliereBindingSource, "N_rapp_cre__reno_immb", True))
        Me.N_rapp_cre__reno_immbTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_rapp_cre__reno_immbTextBox.Location = New System.Drawing.Point(715, 97)
        Me.N_rapp_cre__reno_immbTextBox.Name = "N_rapp_cre__reno_immbTextBox"
        Me.N_rapp_cre__reno_immbTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_rapp_cre__reno_immbTextBox.TabIndex = 5
        '
        'Dat_rapp_cre_reno_immbDateTimePicker
        '
        Me.Dat_rapp_cre_reno_immbDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Commission_cession_immobiliereBindingSource, "Dat_rapp_cre_reno_immb", True))
        Me.Dat_rapp_cre_reno_immbDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_rapp_cre_reno_immbDateTimePicker.Location = New System.Drawing.Point(413, 164)
        Me.Dat_rapp_cre_reno_immbDateTimePicker.Name = "Dat_rapp_cre_reno_immbDateTimePicker"
        Me.Dat_rapp_cre_reno_immbDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_rapp_cre_reno_immbDateTimePicker.TabIndex = 7
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
        Me.pv_commibtn.Location = New System.Drawing.Point(413, 246)
        Me.pv_commibtn.Name = "pv_commibtn"
        Me.pv_commibtn.Size = New System.Drawing.Size(193, 44)
        Me.pv_commibtn.TabIndex = 8
        Me.pv_commibtn.Text = "محضر اجتماع لجنة التنازل"
        Me.pv_commibtn.UseVisualStyleBackColor = False
        '
        'Form_commi_cess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 516)
        Me.Controls.Add(Me.pv_commibtn)
        Me.Controls.Add(Cd_comi_reno_immbLabel)
        Me.Controls.Add(Me.Cd_comi_reno_immbTextBox)
        Me.Controls.Add(N_rapp_cre__reno_immbLabel)
        Me.Controls.Add(Me.N_rapp_cre__reno_immbTextBox)
        Me.Controls.Add(Dat_rapp_cre_reno_immbLabel)
        Me.Controls.Add(Me.Dat_rapp_cre_reno_immbDateTimePicker)
        Me.Controls.Add(Me.Commission_cession_immobiliereDataGridView)
        Me.Controls.Add(Me.Commission_cession_immobiliereBindingNavigator)
        Me.Name = "Form_commi_cess"
        Me.Text = "commi_cess"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Commission_cession_immobiliereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Commission_cession_immobiliereBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Commission_cession_immobiliereBindingNavigator.ResumeLayout(False)
        Me.Commission_cession_immobiliereBindingNavigator.PerformLayout()
        CType(Me.Commission_cession_immobiliereDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Commission_cession_immobiliereBindingSource As BindingSource
    Friend WithEvents Commission_cession_immobiliereTableAdapter As droit_propriter_etatDataSetTableAdapters.Commission_cession_immobiliereTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Commission_cession_immobiliereBindingNavigator As BindingNavigator
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
    Friend WithEvents Commission_cession_immobiliereBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Commission_cession_immobiliereDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Cd_comi_reno_immbTextBox As TextBox
    Friend WithEvents N_rapp_cre__reno_immbTextBox As TextBox
    Friend WithEvents Dat_rapp_cre_reno_immbDateTimePicker As DateTimePicker
    Friend WithEvents pv_commibtn As Button
End Class
