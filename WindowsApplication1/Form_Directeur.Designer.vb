<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Directeur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Directeur))
        Dim Cd_direc_Label As System.Windows.Forms.Label
        Dim Nom_direcLabel As System.Windows.Forms.Label
        Dim Pre_direcLabel As System.Windows.Forms.Label
        Dim N_rapp_nomin_direcLabel As System.Windows.Forms.Label
        Dim Dat_rapp_nomin_direcLabel As System.Windows.Forms.Label
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.DirecteurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirecteurTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.DirecteurTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.DirecteurBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DirecteurBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DirecteurDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cd_direc_TextBox = New System.Windows.Forms.TextBox()
        Me.Nom_direcTextBox = New System.Windows.Forms.TextBox()
        Me.Pre_direcTextBox = New System.Windows.Forms.TextBox()
        Me.N_rapp_nomin_direcTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_rapp_nomin_direcDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Cd_direc_Label = New System.Windows.Forms.Label()
        Nom_direcLabel = New System.Windows.Forms.Label()
        Pre_direcLabel = New System.Windows.Forms.Label()
        N_rapp_nomin_direcLabel = New System.Windows.Forms.Label()
        Dat_rapp_nomin_direcLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirecteurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirecteurBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DirecteurBindingNavigator.SuspendLayout()
        CType(Me.DirecteurDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.DirecteurTableAdapter = Me.DirecteurTableAdapter
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
        'DirecteurBindingNavigator
        '
        Me.DirecteurBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DirecteurBindingNavigator.BindingSource = Me.DirecteurBindingSource
        Me.DirecteurBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DirecteurBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DirecteurBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DirecteurBindingNavigatorSaveItem})
        Me.DirecteurBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DirecteurBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DirecteurBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DirecteurBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DirecteurBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DirecteurBindingNavigator.Name = "DirecteurBindingNavigator"
        Me.DirecteurBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DirecteurBindingNavigator.Size = New System.Drawing.Size(994, 25)
        Me.DirecteurBindingNavigator.TabIndex = 0
        Me.DirecteurBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DirecteurBindingNavigatorSaveItem
        '
        Me.DirecteurBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DirecteurBindingNavigatorSaveItem.Image = CType(resources.GetObject("DirecteurBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DirecteurBindingNavigatorSaveItem.Name = "DirecteurBindingNavigatorSaveItem"
        Me.DirecteurBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DirecteurBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DirecteurDataGridView
        '
        Me.DirecteurDataGridView.AutoGenerateColumns = False
        Me.DirecteurDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DirecteurDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DirecteurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DirecteurDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DirecteurDataGridView.DataSource = Me.DirecteurBindingSource
        Me.DirecteurDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DirecteurDataGridView.Location = New System.Drawing.Point(0, 273)
        Me.DirecteurDataGridView.Name = "DirecteurDataGridView"
        Me.DirecteurDataGridView.ReadOnly = True
        Me.DirecteurDataGridView.Size = New System.Drawing.Size(994, 220)
        Me.DirecteurDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_direc_"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_direc_"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_direc"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom_direc"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Pre_direc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pre_direc"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "N_rapp_nomin_direc"
        Me.DataGridViewTextBoxColumn4.HeaderText = "N_rapp_nomin_direc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Dat_rapp_nomin_direc"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dat_rapp_nomin_direc"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Cd_direc_Label
        '
        Cd_direc_Label.AutoSize = True
        Cd_direc_Label.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_direc_Label.ForeColor = System.Drawing.Color.White
        Cd_direc_Label.Location = New System.Drawing.Point(378, 73)
        Cd_direc_Label.Name = "Cd_direc_Label"
        Cd_direc_Label.Size = New System.Drawing.Size(62, 19)
        Cd_direc_Label.TabIndex = 2
        Cd_direc_Label.Text = "رمز المدير"
        '
        'Cd_direc_TextBox
        '
        Me.Cd_direc_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirecteurBindingSource, "Cd_direc_", True))
        Me.Cd_direc_TextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_direc_TextBox.Location = New System.Drawing.Point(130, 70)
        Me.Cd_direc_TextBox.Name = "Cd_direc_TextBox"
        Me.Cd_direc_TextBox.Size = New System.Drawing.Size(200, 27)
        Me.Cd_direc_TextBox.TabIndex = 3
        '
        'Nom_direcLabel
        '
        Nom_direcLabel.AutoSize = True
        Nom_direcLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_direcLabel.ForeColor = System.Drawing.Color.White
        Nom_direcLabel.Location = New System.Drawing.Point(374, 125)
        Nom_direcLabel.Name = "Nom_direcLabel"
        Nom_direcLabel.Size = New System.Drawing.Size(66, 19)
        Nom_direcLabel.TabIndex = 4
        Nom_direcLabel.Text = "لقــب المدير"
        '
        'Nom_direcTextBox
        '
        Me.Nom_direcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirecteurBindingSource, "Nom_direc", True))
        Me.Nom_direcTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_direcTextBox.Location = New System.Drawing.Point(130, 122)
        Me.Nom_direcTextBox.Name = "Nom_direcTextBox"
        Me.Nom_direcTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Nom_direcTextBox.TabIndex = 5
        '
        'Pre_direcLabel
        '
        Pre_direcLabel.AutoSize = True
        Pre_direcLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pre_direcLabel.ForeColor = System.Drawing.Color.White
        Pre_direcLabel.Location = New System.Drawing.Point(879, 73)
        Pre_direcLabel.Name = "Pre_direcLabel"
        Pre_direcLabel.Size = New System.Drawing.Size(63, 19)
        Pre_direcLabel.TabIndex = 6
        Pre_direcLabel.Text = "اسـم المدير"
        '
        'Pre_direcTextBox
        '
        Me.Pre_direcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirecteurBindingSource, "Pre_direc", True))
        Me.Pre_direcTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pre_direcTextBox.Location = New System.Drawing.Point(581, 70)
        Me.Pre_direcTextBox.Name = "Pre_direcTextBox"
        Me.Pre_direcTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Pre_direcTextBox.TabIndex = 7
        '
        'N_rapp_nomin_direcLabel
        '
        N_rapp_nomin_direcLabel.AutoSize = True
        N_rapp_nomin_direcLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_rapp_nomin_direcLabel.ForeColor = System.Drawing.Color.White
        N_rapp_nomin_direcLabel.Location = New System.Drawing.Point(823, 125)
        N_rapp_nomin_direcLabel.Name = "N_rapp_nomin_direcLabel"
        N_rapp_nomin_direcLabel.Size = New System.Drawing.Size(119, 19)
        N_rapp_nomin_direcLabel.TabIndex = 8
        N_rapp_nomin_direcLabel.Text = "رقـم مقرر تعيين المدير"
        '
        'N_rapp_nomin_direcTextBox
        '
        Me.N_rapp_nomin_direcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DirecteurBindingSource, "N_rapp_nomin_direc", True))
        Me.N_rapp_nomin_direcTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_rapp_nomin_direcTextBox.Location = New System.Drawing.Point(581, 122)
        Me.N_rapp_nomin_direcTextBox.Name = "N_rapp_nomin_direcTextBox"
        Me.N_rapp_nomin_direcTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_rapp_nomin_direcTextBox.TabIndex = 9
        '
        'Dat_rapp_nomin_direcLabel
        '
        Dat_rapp_nomin_direcLabel.AutoSize = True
        Dat_rapp_nomin_direcLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_rapp_nomin_direcLabel.ForeColor = System.Drawing.Color.White
        Dat_rapp_nomin_direcLabel.Location = New System.Drawing.Point(554, 192)
        Dat_rapp_nomin_direcLabel.Name = "Dat_rapp_nomin_direcLabel"
        Dat_rapp_nomin_direcLabel.Size = New System.Drawing.Size(127, 19)
        Dat_rapp_nomin_direcLabel.TabIndex = 10
        Dat_rapp_nomin_direcLabel.Text = "تاريخ مقرر تعيين المدير"
        '
        'Dat_rapp_nomin_direcDateTimePicker
        '
        Me.Dat_rapp_nomin_direcDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DirecteurBindingSource, "Dat_rapp_nomin_direc", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Dat_rapp_nomin_direcDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_rapp_nomin_direcDateTimePicker.Location = New System.Drawing.Point(322, 186)
        Me.Dat_rapp_nomin_direcDateTimePicker.Name = "Dat_rapp_nomin_direcDateTimePicker"
        Me.Dat_rapp_nomin_direcDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_rapp_nomin_direcDateTimePicker.TabIndex = 11
        '
        'Form_Directeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 493)
        Me.Controls.Add(Cd_direc_Label)
        Me.Controls.Add(Me.Cd_direc_TextBox)
        Me.Controls.Add(Nom_direcLabel)
        Me.Controls.Add(Me.Nom_direcTextBox)
        Me.Controls.Add(Pre_direcLabel)
        Me.Controls.Add(Me.Pre_direcTextBox)
        Me.Controls.Add(N_rapp_nomin_direcLabel)
        Me.Controls.Add(Me.N_rapp_nomin_direcTextBox)
        Me.Controls.Add(Dat_rapp_nomin_direcLabel)
        Me.Controls.Add(Me.Dat_rapp_nomin_direcDateTimePicker)
        Me.Controls.Add(Me.DirecteurDataGridView)
        Me.Controls.Add(Me.DirecteurBindingNavigator)
        Me.Name = "Form_Directeur"
        Me.Text = "Form_Directeur"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirecteurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirecteurBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DirecteurBindingNavigator.ResumeLayout(False)
        Me.DirecteurBindingNavigator.PerformLayout()
        CType(Me.DirecteurDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents DirecteurBindingSource As BindingSource
    Friend WithEvents DirecteurTableAdapter As droit_propriter_etatDataSetTableAdapters.DirecteurTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DirecteurBindingNavigator As BindingNavigator
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
    Friend WithEvents DirecteurBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DirecteurDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Cd_direc_TextBox As TextBox
    Friend WithEvents Nom_direcTextBox As TextBox
    Friend WithEvents Pre_direcTextBox As TextBox
    Friend WithEvents N_rapp_nomin_direcTextBox As TextBox
    Friend WithEvents Dat_rapp_nomin_direcDateTimePicker As DateTimePicker
End Class
