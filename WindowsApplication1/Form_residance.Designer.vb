<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_residance
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
        Dim Adr_residenceLabel As System.Windows.Forms.Label
        Dim Cd_QuartierLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_residance))
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.ResidenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResidenceTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.ResidenceTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.ResidenceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ResidenceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ResidenceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adr_residenceTextBox = New System.Windows.Forms.TextBox()
        Me.Cd_QuartierComboBox = New System.Windows.Forms.ComboBox()
        Me.QuartierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuartierTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.QuartierTableAdapter()
        Adr_residenceLabel = New System.Windows.Forms.Label()
        Cd_QuartierLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResidenceBindingNavigator.SuspendLayout()
        CType(Me.ResidenceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuartierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Adr_residenceLabel
        '
        Adr_residenceLabel.AutoSize = True
        Adr_residenceLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Adr_residenceLabel.ForeColor = System.Drawing.Color.White
        Adr_residenceLabel.Location = New System.Drawing.Point(271, 137)
        Adr_residenceLabel.Name = "Adr_residenceLabel"
        Adr_residenceLabel.Size = New System.Drawing.Size(75, 19)
        Adr_residenceLabel.TabIndex = 4
        Adr_residenceLabel.Text = "عنوان الاقامة"
        '
        'Cd_QuartierLabel
        '
        Cd_QuartierLabel.AutoSize = True
        Cd_QuartierLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_QuartierLabel.ForeColor = System.Drawing.Color.White
        Cd_QuartierLabel.Location = New System.Drawing.Point(688, 137)
        Cd_QuartierLabel.Name = "Cd_QuartierLabel"
        Cd_QuartierLabel.Size = New System.Drawing.Size(37, 19)
        Cd_QuartierLabel.TabIndex = 8
        Cd_QuartierLabel.Text = "الحي "
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.PV_Commession_CessionTableAdapter = Nothing
        Me.TableAdapterManager.QuartierTableAdapter = Nothing
        Me.TableAdapterManager.Rapport_evaluationTableAdapter = Nothing
        Me.TableAdapterManager.ResidenceTableAdapter = Me.ResidenceTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Nothing
        '
        'ResidenceBindingNavigator
        '
        Me.ResidenceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ResidenceBindingNavigator.BindingSource = Me.ResidenceBindingSource
        Me.ResidenceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ResidenceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ResidenceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ResidenceBindingNavigatorSaveItem})
        Me.ResidenceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ResidenceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ResidenceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ResidenceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ResidenceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ResidenceBindingNavigator.Name = "ResidenceBindingNavigator"
        Me.ResidenceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ResidenceBindingNavigator.Size = New System.Drawing.Size(1014, 25)
        Me.ResidenceBindingNavigator.TabIndex = 0
        Me.ResidenceBindingNavigator.Text = "BindingNavigator1"
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
        'ResidenceBindingNavigatorSaveItem
        '
        Me.ResidenceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ResidenceBindingNavigatorSaveItem.Image = CType(resources.GetObject("ResidenceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ResidenceBindingNavigatorSaveItem.Name = "ResidenceBindingNavigatorSaveItem"
        Me.ResidenceBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ResidenceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ResidenceDataGridView
        '
        Me.ResidenceDataGridView.AutoGenerateColumns = False
        Me.ResidenceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ResidenceDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.ResidenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResidenceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.ResidenceDataGridView.DataSource = Me.ResidenceBindingSource
        Me.ResidenceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ResidenceDataGridView.Location = New System.Drawing.Point(0, 271)
        Me.ResidenceDataGridView.Name = "ResidenceDataGridView"
        Me.ResidenceDataGridView.ReadOnly = True
        Me.ResidenceDataGridView.Size = New System.Drawing.Size(1014, 220)
        Me.ResidenceDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_residence"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_residence"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Adr_residence"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Adr_residence"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cd_Quartier"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cd_Quartier"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Adr_residenceTextBox
        '
        Me.Adr_residenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResidenceBindingSource, "Adr_residence", True))
        Me.Adr_residenceTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adr_residenceTextBox.Location = New System.Drawing.Point(209, 169)
        Me.Adr_residenceTextBox.Name = "Adr_residenceTextBox"
        Me.Adr_residenceTextBox.Size = New System.Drawing.Size(196, 27)
        Me.Adr_residenceTextBox.TabIndex = 5
        '
        'Cd_QuartierComboBox
        '
        Me.Cd_QuartierComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ResidenceBindingSource, "Cd_Quartier", True))
        Me.Cd_QuartierComboBox.DataSource = Me.QuartierBindingSource
        Me.Cd_QuartierComboBox.DisplayMember = "Nom_Quartier"
        Me.Cd_QuartierComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_QuartierComboBox.FormattingEnabled = True
        Me.Cd_QuartierComboBox.Location = New System.Drawing.Point(617, 170)
        Me.Cd_QuartierComboBox.Name = "Cd_QuartierComboBox"
        Me.Cd_QuartierComboBox.Size = New System.Drawing.Size(196, 27)
        Me.Cd_QuartierComboBox.TabIndex = 9
        Me.Cd_QuartierComboBox.ValueMember = "Cd_Quartier"
        '
        'QuartierBindingSource
        '
        Me.QuartierBindingSource.DataMember = "Quartier"
        Me.QuartierBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'QuartierTableAdapter
        '
        Me.QuartierTableAdapter.ClearBeforeFill = True
        '
        'Form_residance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 491)
        Me.Controls.Add(Adr_residenceLabel)
        Me.Controls.Add(Me.Adr_residenceTextBox)
        Me.Controls.Add(Cd_QuartierLabel)
        Me.Controls.Add(Me.Cd_QuartierComboBox)
        Me.Controls.Add(Me.ResidenceDataGridView)
        Me.Controls.Add(Me.ResidenceBindingNavigator)
        Me.Name = "Form_residance"
        Me.Text = "Form_residance"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResidenceBindingNavigator.ResumeLayout(False)
        Me.ResidenceBindingNavigator.PerformLayout()
        CType(Me.ResidenceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuartierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents ResidenceBindingSource As BindingSource
    Friend WithEvents ResidenceTableAdapter As droit_propriter_etatDataSetTableAdapters.ResidenceTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ResidenceBindingNavigator As BindingNavigator
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
    Friend WithEvents ResidenceBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ResidenceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Adr_residenceTextBox As TextBox
    Friend WithEvents Cd_QuartierComboBox As ComboBox
    Friend WithEvents QuartierBindingSource As BindingSource
    Friend WithEvents QuartierTableAdapter As droit_propriter_etatDataSetTableAdapters.QuartierTableAdapter
End Class
