<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Abattment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Abattment))
        Dim Cd_abatLabel As System.Windows.Forms.Label
        Dim Duree_versLabel As System.Windows.Forms.Label
        Dim Coef_echLabel As System.Windows.Forms.Label
        Dim Taux_AbatLabel As System.Windows.Forms.Label
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
        Me.AbattementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbattementTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.AbattementTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.AbattementBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AbattementBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AbattementDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cd_abatTextBox = New System.Windows.Forms.TextBox()
        Me.Duree_versTextBox = New System.Windows.Forms.TextBox()
        Me.Coef_echTextBox = New System.Windows.Forms.TextBox()
        Me.Taux_AbatTextBox = New System.Windows.Forms.TextBox()
        Cd_abatLabel = New System.Windows.Forms.Label()
        Duree_versLabel = New System.Windows.Forms.Label()
        Coef_echLabel = New System.Windows.Forms.Label()
        Taux_AbatLabel = New System.Windows.Forms.Label()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbattementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbattementBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbattementBindingNavigator.SuspendLayout()
        CType(Me.AbattementDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AbattementBindingSource
        '
        Me.AbattementBindingSource.DataMember = "Abattement"
        Me.AbattementBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'AbattementTableAdapter
        '
        Me.AbattementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbattementTableAdapter = Me.AbattementTableAdapter
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
        Me.TableAdapterManager.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Nothing
        '
        'AbattementBindingNavigator
        '
        Me.AbattementBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AbattementBindingNavigator.BindingSource = Me.AbattementBindingSource
        Me.AbattementBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AbattementBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AbattementBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AbattementBindingNavigatorSaveItem})
        Me.AbattementBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AbattementBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AbattementBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AbattementBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AbattementBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AbattementBindingNavigator.Name = "AbattementBindingNavigator"
        Me.AbattementBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AbattementBindingNavigator.Size = New System.Drawing.Size(972, 25)
        Me.AbattementBindingNavigator.TabIndex = 0
        Me.AbattementBindingNavigator.Text = "BindingNavigator1"
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
        'AbattementBindingNavigatorSaveItem
        '
        Me.AbattementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbattementBindingNavigatorSaveItem.Image = CType(resources.GetObject("AbattementBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AbattementBindingNavigatorSaveItem.Name = "AbattementBindingNavigatorSaveItem"
        Me.AbattementBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AbattementBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AbattementDataGridView
        '
        Me.AbattementDataGridView.AutoGenerateColumns = False
        Me.AbattementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AbattementDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.AbattementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbattementDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AbattementDataGridView.DataSource = Me.AbattementBindingSource
        Me.AbattementDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AbattementDataGridView.Location = New System.Drawing.Point(0, 268)
        Me.AbattementDataGridView.Name = "AbattementDataGridView"
        Me.AbattementDataGridView.ReadOnly = True
        Me.AbattementDataGridView.Size = New System.Drawing.Size(972, 220)
        Me.AbattementDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_abat"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_abat"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Duree_vers"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Duree_vers"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Coef_ech"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Coef_ech"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Taux_Abat"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Taux_Abat"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Cd_abatLabel
        '
        Cd_abatLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Cd_abatLabel.AutoSize = True
        Cd_abatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_abatLabel.ForeColor = System.Drawing.Color.White
        Cd_abatLabel.Location = New System.Drawing.Point(250, 51)
        Cd_abatLabel.Name = "Cd_abatLabel"
        Cd_abatLabel.Size = New System.Drawing.Size(76, 19)
        Cd_abatLabel.TabIndex = 2
        Cd_abatLabel.Text = "رمز التخفيض"
        '
        'Cd_abatTextBox
        '
        Me.Cd_abatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cd_abatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbattementBindingSource, "Cd_abat", True))
        Me.Cd_abatTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_abatTextBox.Location = New System.Drawing.Point(204, 83)
        Me.Cd_abatTextBox.Name = "Cd_abatTextBox"
        Me.Cd_abatTextBox.Size = New System.Drawing.Size(186, 27)
        Me.Cd_abatTextBox.TabIndex = 3
        '
        'Duree_versLabel
        '
        Duree_versLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Duree_versLabel.AutoSize = True
        Duree_versLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Duree_versLabel.ForeColor = System.Drawing.Color.White
        Duree_versLabel.Location = New System.Drawing.Point(657, 51)
        Duree_versLabel.Name = "Duree_versLabel"
        Duree_versLabel.Size = New System.Drawing.Size(63, 19)
        Duree_versLabel.TabIndex = 4
        Duree_versLabel.Text = "مدة التسديد"
        '
        'Duree_versTextBox
        '
        Me.Duree_versTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Duree_versTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbattementBindingSource, "Duree_vers", True))
        Me.Duree_versTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Duree_versTextBox.Location = New System.Drawing.Point(587, 83)
        Me.Duree_versTextBox.Name = "Duree_versTextBox"
        Me.Duree_versTextBox.Size = New System.Drawing.Size(186, 27)
        Me.Duree_versTextBox.TabIndex = 5
        '
        'Coef_echLabel
        '
        Coef_echLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Coef_echLabel.AutoSize = True
        Coef_echLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Coef_echLabel.ForeColor = System.Drawing.Color.White
        Coef_echLabel.Location = New System.Drawing.Point(256, 149)
        Coef_echLabel.Name = "Coef_echLabel"
        Coef_echLabel.Size = New System.Drawing.Size(70, 19)
        Coef_echLabel.TabIndex = 6
        Coef_echLabel.Text = "قيمة المعامل"
        '
        'Coef_echTextBox
        '
        Me.Coef_echTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Coef_echTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbattementBindingSource, "Coef_ech", True))
        Me.Coef_echTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coef_echTextBox.Location = New System.Drawing.Point(204, 180)
        Me.Coef_echTextBox.Name = "Coef_echTextBox"
        Me.Coef_echTextBox.Size = New System.Drawing.Size(186, 27)
        Me.Coef_echTextBox.TabIndex = 7
        '
        'Taux_AbatLabel
        '
        Taux_AbatLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Taux_AbatLabel.AutoSize = True
        Taux_AbatLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Taux_AbatLabel.ForeColor = System.Drawing.Color.White
        Taux_AbatLabel.Location = New System.Drawing.Point(641, 149)
        Taux_AbatLabel.Name = "Taux_AbatLabel"
        Taux_AbatLabel.Size = New System.Drawing.Size(79, 19)
        Taux_AbatLabel.TabIndex = 8
        Taux_AbatLabel.Text = "نسبة التخفيض"
        '
        'Taux_AbatTextBox
        '
        Me.Taux_AbatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Taux_AbatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbattementBindingSource, "Taux_Abat", True))
        Me.Taux_AbatTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Taux_AbatTextBox.Location = New System.Drawing.Point(587, 180)
        Me.Taux_AbatTextBox.Name = "Taux_AbatTextBox"
        Me.Taux_AbatTextBox.Size = New System.Drawing.Size(186, 27)
        Me.Taux_AbatTextBox.TabIndex = 9
        '
        'Form_Abattment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 488)
        Me.Controls.Add(Cd_abatLabel)
        Me.Controls.Add(Me.Cd_abatTextBox)
        Me.Controls.Add(Duree_versLabel)
        Me.Controls.Add(Me.Duree_versTextBox)
        Me.Controls.Add(Coef_echLabel)
        Me.Controls.Add(Me.Coef_echTextBox)
        Me.Controls.Add(Taux_AbatLabel)
        Me.Controls.Add(Me.Taux_AbatTextBox)
        Me.Controls.Add(Me.AbattementDataGridView)
        Me.Controls.Add(Me.AbattementBindingNavigator)
        Me.Name = "Form_Abattment"
        Me.Text = "Form_Abattment"
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbattementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbattementBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbattementBindingNavigator.ResumeLayout(False)
        Me.AbattementBindingNavigator.PerformLayout()
        CType(Me.AbattementDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents AbattementBindingSource As BindingSource
    Friend WithEvents AbattementTableAdapter As droit_propriter_etatDataSetTableAdapters.AbattementTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AbattementBindingNavigator As BindingNavigator
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
    Friend WithEvents AbattementBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AbattementDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Cd_abatTextBox As TextBox
    Friend WithEvents Duree_versTextBox As TextBox
    Friend WithEvents Coef_echTextBox As TextBox
    Friend WithEvents Taux_AbatTextBox As TextBox
End Class
