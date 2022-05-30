<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Rapport_Evaluation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Rapport_Evaluation))
        Dim Cd_rapp_eval_immbLabel As System.Windows.Forms.Label
        Dim Dat_rapp_eval_immbLabel As System.Windows.Forms.Label
        Dim N_rappi_eval_immbLabel As System.Windows.Forms.Label
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.Rapport_evaluationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rapport_evaluationTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.Rapport_evaluationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.Rapport_evaluationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Rapport_evaluationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Rapport_evaluationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cd_rapp_eval_immbTextBox = New System.Windows.Forms.TextBox()
        Me.Dat_rapp_eval_immbDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.N_rappi_eval_immbTextBox = New System.Windows.Forms.TextBox()
        Cd_rapp_eval_immbLabel = New System.Windows.Forms.Label()
        Dat_rapp_eval_immbLabel = New System.Windows.Forms.Label()
        N_rappi_eval_immbLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rapport_evaluationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rapport_evaluationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Rapport_evaluationBindingNavigator.SuspendLayout()
        CType(Me.Rapport_evaluationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rapport_evaluationBindingSource
        '
        Me.Rapport_evaluationBindingSource.DataMember = "Rapport_evaluation"
        Me.Rapport_evaluationBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Rapport_evaluationTableAdapter
        '
        Me.Rapport_evaluationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Rapport_evaluationTableAdapter = Me.Rapport_evaluationTableAdapter
        Me.TableAdapterManager.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Nothing
        '
        'Rapport_evaluationBindingNavigator
        '
        Me.Rapport_evaluationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Rapport_evaluationBindingNavigator.BindingSource = Me.Rapport_evaluationBindingSource
        Me.Rapport_evaluationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Rapport_evaluationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Rapport_evaluationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Rapport_evaluationBindingNavigatorSaveItem})
        Me.Rapport_evaluationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Rapport_evaluationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Rapport_evaluationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Rapport_evaluationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Rapport_evaluationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Rapport_evaluationBindingNavigator.Name = "Rapport_evaluationBindingNavigator"
        Me.Rapport_evaluationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Rapport_evaluationBindingNavigator.Size = New System.Drawing.Size(1017, 25)
        Me.Rapport_evaluationBindingNavigator.TabIndex = 0
        Me.Rapport_evaluationBindingNavigator.Text = "BindingNavigator1"
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
        'Rapport_evaluationBindingNavigatorSaveItem
        '
        Me.Rapport_evaluationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rapport_evaluationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Rapport_evaluationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Rapport_evaluationBindingNavigatorSaveItem.Name = "Rapport_evaluationBindingNavigatorSaveItem"
        Me.Rapport_evaluationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Rapport_evaluationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Rapport_evaluationDataGridView
        '
        Me.Rapport_evaluationDataGridView.AutoGenerateColumns = False
        Me.Rapport_evaluationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Rapport_evaluationDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.Rapport_evaluationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rapport_evaluationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Rapport_evaluationDataGridView.DataSource = Me.Rapport_evaluationBindingSource
        Me.Rapport_evaluationDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Rapport_evaluationDataGridView.Location = New System.Drawing.Point(0, 263)
        Me.Rapport_evaluationDataGridView.Name = "Rapport_evaluationDataGridView"
        Me.Rapport_evaluationDataGridView.ReadOnly = True
        Me.Rapport_evaluationDataGridView.Size = New System.Drawing.Size(1017, 218)
        Me.Rapport_evaluationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_rapp_eval_immb"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_rapp_eval_immb"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dat_rapp_eval_immb"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dat_rapp_eval_immb"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "N_rappi_eval_immb"
        Me.DataGridViewTextBoxColumn3.HeaderText = "N_rappi_eval_immb"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Cd_rapp_eval_immbLabel
        '
        Cd_rapp_eval_immbLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Cd_rapp_eval_immbLabel.AutoSize = True
        Cd_rapp_eval_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_rapp_eval_immbLabel.ForeColor = System.Drawing.Color.White
        Cd_rapp_eval_immbLabel.Location = New System.Drawing.Point(161, 67)
        Cd_rapp_eval_immbLabel.Name = "Cd_rapp_eval_immbLabel"
        Cd_rapp_eval_immbLabel.Size = New System.Drawing.Size(124, 19)
        Cd_rapp_eval_immbLabel.TabIndex = 2
        Cd_rapp_eval_immbLabel.Text = "رمز محضر تقييم العقار"
        '
        'Cd_rapp_eval_immbTextBox
        '
        Me.Cd_rapp_eval_immbTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cd_rapp_eval_immbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rapport_evaluationBindingSource, "Cd_rapp_eval_immb", True))
        Me.Cd_rapp_eval_immbTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_rapp_eval_immbTextBox.Location = New System.Drawing.Point(120, 104)
        Me.Cd_rapp_eval_immbTextBox.Name = "Cd_rapp_eval_immbTextBox"
        Me.Cd_rapp_eval_immbTextBox.ReadOnly = True
        Me.Cd_rapp_eval_immbTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Cd_rapp_eval_immbTextBox.TabIndex = 3
        '
        'Dat_rapp_eval_immbLabel
        '
        Dat_rapp_eval_immbLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Dat_rapp_eval_immbLabel.AutoSize = True
        Dat_rapp_eval_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dat_rapp_eval_immbLabel.ForeColor = System.Drawing.Color.White
        Dat_rapp_eval_immbLabel.Location = New System.Drawing.Point(699, 67)
        Dat_rapp_eval_immbLabel.Name = "Dat_rapp_eval_immbLabel"
        Dat_rapp_eval_immbLabel.Size = New System.Drawing.Size(131, 19)
        Dat_rapp_eval_immbLabel.TabIndex = 4
        Dat_rapp_eval_immbLabel.Text = "تاريخ محضر تقييم العقار"
        '
        'Dat_rapp_eval_immbDateTimePicker
        '
        Me.Dat_rapp_eval_immbDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dat_rapp_eval_immbDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Rapport_evaluationBindingSource, "Dat_rapp_eval_immb", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "22/05/2022", "d"))
        Me.Dat_rapp_eval_immbDateTimePicker.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_rapp_eval_immbDateTimePicker.Location = New System.Drawing.Point(669, 104)
        Me.Dat_rapp_eval_immbDateTimePicker.Name = "Dat_rapp_eval_immbDateTimePicker"
        Me.Dat_rapp_eval_immbDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Dat_rapp_eval_immbDateTimePicker.TabIndex = 5
        '
        'N_rappi_eval_immbLabel
        '
        N_rappi_eval_immbLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        N_rappi_eval_immbLabel.AutoSize = True
        N_rappi_eval_immbLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_rappi_eval_immbLabel.ForeColor = System.Drawing.Color.White
        N_rappi_eval_immbLabel.Location = New System.Drawing.Point(448, 134)
        N_rappi_eval_immbLabel.Name = "N_rappi_eval_immbLabel"
        N_rappi_eval_immbLabel.Size = New System.Drawing.Size(124, 19)
        N_rappi_eval_immbLabel.TabIndex = 6
        N_rappi_eval_immbLabel.Text = "رقم محضر تقييم العقار "
        '
        'N_rappi_eval_immbTextBox
        '
        Me.N_rappi_eval_immbTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.N_rappi_eval_immbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rapport_evaluationBindingSource, "N_rappi_eval_immb", True))
        Me.N_rappi_eval_immbTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_rappi_eval_immbTextBox.Location = New System.Drawing.Point(412, 171)
        Me.N_rappi_eval_immbTextBox.Name = "N_rappi_eval_immbTextBox"
        Me.N_rappi_eval_immbTextBox.Size = New System.Drawing.Size(200, 27)
        Me.N_rappi_eval_immbTextBox.TabIndex = 7
        '
        'Form_Rapport_Evaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1017, 481)
        Me.Controls.Add(Cd_rapp_eval_immbLabel)
        Me.Controls.Add(Me.Cd_rapp_eval_immbTextBox)
        Me.Controls.Add(Dat_rapp_eval_immbLabel)
        Me.Controls.Add(Me.Dat_rapp_eval_immbDateTimePicker)
        Me.Controls.Add(N_rappi_eval_immbLabel)
        Me.Controls.Add(Me.N_rappi_eval_immbTextBox)
        Me.Controls.Add(Me.Rapport_evaluationDataGridView)
        Me.Controls.Add(Me.Rapport_evaluationBindingNavigator)
        Me.Name = "Form_Rapport_Evaluation"
        Me.Text = "Form_Rapport_Evaluation"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rapport_evaluationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rapport_evaluationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Rapport_evaluationBindingNavigator.ResumeLayout(False)
        Me.Rapport_evaluationBindingNavigator.PerformLayout()
        CType(Me.Rapport_evaluationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents Rapport_evaluationBindingSource As BindingSource
    Friend WithEvents Rapport_evaluationTableAdapter As droit_propriter_etatDataSetTableAdapters.Rapport_evaluationTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Rapport_evaluationBindingNavigator As BindingNavigator
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
    Friend WithEvents Rapport_evaluationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Rapport_evaluationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Cd_rapp_eval_immbTextBox As TextBox
    Friend WithEvents Dat_rapp_eval_immbDateTimePicker As DateTimePicker
    Friend WithEvents N_rappi_eval_immbTextBox As TextBox
End Class
