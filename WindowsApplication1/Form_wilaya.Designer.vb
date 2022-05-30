<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_wilaya
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
        Dim Cd_wilayaLabel As System.Windows.Forms.Label
        Dim Nom_wilayaLabel As System.Windows.Forms.Label
        Dim Nom_dairaLabel As System.Windows.Forms.Label
        Dim Cd_wilayaLabel1 As System.Windows.Forms.Label
        Dim Nom_communeLabel As System.Windows.Forms.Label
        Dim Cd_dairaLabel As System.Windows.Forms.Label
        Dim Nom_QuartierLabel As System.Windows.Forms.Label
        Dim Cd_communeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_wilaya))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.WilayaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Droit_propriter_etatDataSet = New WindowsApplication1.droit_propriter_etatDataSet()
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
        Me.SaveToolStrip_Wilaya = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Cd_wilayaTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_wilayaTextBox = New System.Windows.Forms.TextBox()
        Me.WilayaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cd_wilayaComboBox = New System.Windows.Forms.ComboBox()
        Me.DairaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStrip_Daira = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Nom_dairaTextBox = New System.Windows.Forms.TextBox()
        Me.DairaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem3 = New System.Windows.Forms.ToolStripButton()
        Me.QuartierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem3 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem3 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStrip_Quartier = New System.Windows.Forms.ToolStripButton()
        Me.Nom_QuartierTextBox = New System.Windows.Forms.TextBox()
        Me.Cd_communeComboBox = New System.Windows.Forms.ComboBox()
        Me.QuartierDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Cd_dairaComboBox = New System.Windows.Forms.ComboBox()
        Me.CommuneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStrip_Commune = New System.Windows.Forms.ToolStripButton()
        Me.Nom_communeTextBox = New System.Windows.Forms.TextBox()
        Me.CommuneDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WilayaTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.WilayaTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager()
        Me.CommuneTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.CommuneTableAdapter()
        Me.DairaTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.DairaTableAdapter()
        Me.QuartierTableAdapter = New WindowsApplication1.droit_propriter_etatDataSetTableAdapters.QuartierTableAdapter()
        Me.WilayaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DairaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommuneBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Cd_wilayaLabel = New System.Windows.Forms.Label()
        Nom_wilayaLabel = New System.Windows.Forms.Label()
        Nom_dairaLabel = New System.Windows.Forms.Label()
        Cd_wilayaLabel1 = New System.Windows.Forms.Label()
        Nom_communeLabel = New System.Windows.Forms.Label()
        Cd_dairaLabel = New System.Windows.Forms.Label()
        Nom_QuartierLabel = New System.Windows.Forms.Label()
        Cd_communeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.WilayaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WilayaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DairaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.DairaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        CType(Me.QuartierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuartierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.CommuneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.CommuneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WilayaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DairaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommuneBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cd_wilayaLabel
        '
        Cd_wilayaLabel.AutoSize = True
        Cd_wilayaLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_wilayaLabel.ForeColor = System.Drawing.Color.White
        Cd_wilayaLabel.Location = New System.Drawing.Point(119, 51)
        Cd_wilayaLabel.Name = "Cd_wilayaLabel"
        Cd_wilayaLabel.Size = New System.Drawing.Size(64, 19)
        Cd_wilayaLabel.TabIndex = 1
        Cd_wilayaLabel.Text = "رمز الولاية"
        '
        'Nom_wilayaLabel
        '
        Nom_wilayaLabel.AutoSize = True
        Nom_wilayaLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_wilayaLabel.ForeColor = System.Drawing.Color.White
        Nom_wilayaLabel.Location = New System.Drawing.Point(339, 51)
        Nom_wilayaLabel.Name = "Nom_wilayaLabel"
        Nom_wilayaLabel.Size = New System.Drawing.Size(62, 19)
        Nom_wilayaLabel.TabIndex = 3
        Nom_wilayaLabel.Text = "إسم الولاية"
        '
        'Nom_dairaLabel
        '
        Nom_dairaLabel.AutoSize = True
        Nom_dairaLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_dairaLabel.ForeColor = System.Drawing.Color.White
        Nom_dairaLabel.Location = New System.Drawing.Point(118, 51)
        Nom_dairaLabel.Name = "Nom_dairaLabel"
        Nom_dairaLabel.Size = New System.Drawing.Size(63, 19)
        Nom_dairaLabel.TabIndex = 3
        Nom_dairaLabel.Text = "إسم الدائرة"
        '
        'Cd_wilayaLabel1
        '
        Cd_wilayaLabel1.AutoSize = True
        Cd_wilayaLabel1.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_wilayaLabel1.ForeColor = System.Drawing.Color.White
        Cd_wilayaLabel1.Location = New System.Drawing.Point(346, 51)
        Cd_wilayaLabel1.Name = "Cd_wilayaLabel1"
        Cd_wilayaLabel1.Size = New System.Drawing.Size(44, 19)
        Cd_wilayaLabel1.TabIndex = 5
        Cd_wilayaLabel1.Text = " الولاية"
        '
        'Nom_communeLabel
        '
        Nom_communeLabel.AutoSize = True
        Nom_communeLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_communeLabel.ForeColor = System.Drawing.Color.White
        Nom_communeLabel.Location = New System.Drawing.Point(123, 53)
        Nom_communeLabel.Name = "Nom_communeLabel"
        Nom_communeLabel.Size = New System.Drawing.Size(60, 19)
        Nom_communeLabel.TabIndex = 3
        Nom_communeLabel.Text = "إسم البلدية"
        '
        'Cd_dairaLabel
        '
        Cd_dairaLabel.AutoSize = True
        Cd_dairaLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_dairaLabel.ForeColor = System.Drawing.Color.White
        Cd_dairaLabel.Location = New System.Drawing.Point(350, 53)
        Cd_dairaLabel.Name = "Cd_dairaLabel"
        Cd_dairaLabel.Size = New System.Drawing.Size(45, 19)
        Cd_dairaLabel.TabIndex = 5
        Cd_dairaLabel.Text = " الدائرة"
        '
        'Nom_QuartierLabel
        '
        Nom_QuartierLabel.AutoSize = True
        Nom_QuartierLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_QuartierLabel.ForeColor = System.Drawing.Color.White
        Nom_QuartierLabel.Location = New System.Drawing.Point(118, 53)
        Nom_QuartierLabel.Name = "Nom_QuartierLabel"
        Nom_QuartierLabel.Size = New System.Drawing.Size(55, 19)
        Nom_QuartierLabel.TabIndex = 3
        Nom_QuartierLabel.Text = "إسم الحي"
        '
        'Cd_communeLabel
        '
        Cd_communeLabel.AutoSize = True
        Cd_communeLabel.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cd_communeLabel.ForeColor = System.Drawing.Color.White
        Cd_communeLabel.Location = New System.Drawing.Point(348, 53)
        Cd_communeLabel.Name = "Cd_communeLabel"
        Cd_communeLabel.Size = New System.Drawing.Size(42, 19)
        Cd_communeLabel.TabIndex = 5
        Cd_communeLabel.Text = " البلدية"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Cd_wilayaLabel)
        Me.Panel1.Controls.Add(Me.Cd_wilayaTextBox)
        Me.Panel1.Controls.Add(Nom_wilayaLabel)
        Me.Panel1.Controls.Add(Me.Nom_wilayaTextBox)
        Me.Panel1.Controls.Add(Me.WilayaDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 309)
        Me.Panel1.TabIndex = 0
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.WilayaBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStrip_Wilaya, Me.toolStripSeparator})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(520, 25)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'WilayaBindingSource
        '
        Me.WilayaBindingSource.DataMember = "Wilaya"
        Me.WilayaBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Droit_propriter_etatDataSet
        '
        Me.Droit_propriter_etatDataSet.DataSetName = "droit_propriter_etatDataSet"
        Me.Droit_propriter_etatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SaveToolStrip_Wilaya
        '
        Me.SaveToolStrip_Wilaya.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStrip_Wilaya.Image = CType(resources.GetObject("SaveToolStrip_Wilaya.Image"), System.Drawing.Image)
        Me.SaveToolStrip_Wilaya.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStrip_Wilaya.Name = "SaveToolStrip_Wilaya"
        Me.SaveToolStrip_Wilaya.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStrip_Wilaya.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'Cd_wilayaTextBox
        '
        Me.Cd_wilayaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WilayaBindingSource, "Cd_wilaya", True))
        Me.Cd_wilayaTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_wilayaTextBox.Location = New System.Drawing.Point(63, 90)
        Me.Cd_wilayaTextBox.Name = "Cd_wilayaTextBox"
        Me.Cd_wilayaTextBox.Size = New System.Drawing.Size(174, 27)
        Me.Cd_wilayaTextBox.TabIndex = 2
        '
        'Nom_wilayaTextBox
        '
        Me.Nom_wilayaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WilayaBindingSource, "Nom_wilaya", True))
        Me.Nom_wilayaTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_wilayaTextBox.Location = New System.Drawing.Point(294, 90)
        Me.Nom_wilayaTextBox.Name = "Nom_wilayaTextBox"
        Me.Nom_wilayaTextBox.Size = New System.Drawing.Size(174, 27)
        Me.Nom_wilayaTextBox.TabIndex = 4
        '
        'WilayaDataGridView
        '
        Me.WilayaDataGridView.AutoGenerateColumns = False
        Me.WilayaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.WilayaDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.WilayaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WilayaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.WilayaDataGridView.DataSource = Me.WilayaBindingSource
        Me.WilayaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WilayaDataGridView.Location = New System.Drawing.Point(0, 177)
        Me.WilayaDataGridView.Name = "WilayaDataGridView"
        Me.WilayaDataGridView.ReadOnly = True
        Me.WilayaDataGridView.Size = New System.Drawing.Size(520, 132)
        Me.WilayaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cd_wilaya"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cd_wilaya"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_wilaya"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom_wilaya"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Cd_wilayaComboBox)
        Me.Panel2.Controls.Add(Me.BindingNavigator2)
        Me.Panel2.Controls.Add(Nom_dairaLabel)
        Me.Panel2.Controls.Add(Me.Nom_dairaTextBox)
        Me.Panel2.Controls.Add(Cd_wilayaLabel1)
        Me.Panel2.Controls.Add(Me.DairaDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(549, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 309)
        Me.Panel2.TabIndex = 1
        '
        'Cd_wilayaComboBox
        '
        Me.Cd_wilayaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DairaBindingSource, "Cd_wilaya", True))
        Me.Cd_wilayaComboBox.DataSource = Me.WilayaBindingSource1
        Me.Cd_wilayaComboBox.DisplayMember = "Nom_wilaya"
        Me.Cd_wilayaComboBox.FormattingEnabled = True
        Me.Cd_wilayaComboBox.Location = New System.Drawing.Point(320, 90)
        Me.Cd_wilayaComboBox.Name = "Cd_wilayaComboBox"
        Me.Cd_wilayaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cd_wilayaComboBox.TabIndex = 9
        Me.Cd_wilayaComboBox.ValueMember = "Cd_wilaya"
        '
        'DairaBindingSource
        '
        Me.DairaBindingSource.DataMember = "Daira"
        Me.DairaBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator2.BindingSource = Me.DairaBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStrip_Daira, Me.toolStripSeparator1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(528, 25)
        Me.BindingNavigator2.TabIndex = 7
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStrip_Daira
        '
        Me.SaveToolStrip_Daira.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStrip_Daira.Image = CType(resources.GetObject("SaveToolStrip_Daira.Image"), System.Drawing.Image)
        Me.SaveToolStrip_Daira.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStrip_Daira.Name = "SaveToolStrip_Daira"
        Me.SaveToolStrip_Daira.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStrip_Daira.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Nom_dairaTextBox
        '
        Me.Nom_dairaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DairaBindingSource, "Nom_daira", True))
        Me.Nom_dairaTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_dairaTextBox.Location = New System.Drawing.Point(72, 90)
        Me.Nom_dairaTextBox.Name = "Nom_dairaTextBox"
        Me.Nom_dairaTextBox.Size = New System.Drawing.Size(166, 27)
        Me.Nom_dairaTextBox.TabIndex = 4
        '
        'DairaDataGridView
        '
        Me.DairaDataGridView.AutoGenerateColumns = False
        Me.DairaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DairaDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DairaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DairaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DairaDataGridView.DataSource = Me.DairaBindingSource
        Me.DairaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DairaDataGridView.Location = New System.Drawing.Point(0, 177)
        Me.DairaDataGridView.Name = "DairaDataGridView"
        Me.DairaDataGridView.ReadOnly = True
        Me.DairaDataGridView.Size = New System.Drawing.Size(528, 132)
        Me.DairaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cd_daira"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cd_daira"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nom_daira"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nom_daira"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cd_wilaya"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cd_wilaya"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.BindingNavigator4)
        Me.Panel3.Controls.Add(Nom_QuartierLabel)
        Me.Panel3.Controls.Add(Me.Nom_QuartierTextBox)
        Me.Panel3.Controls.Add(Cd_communeLabel)
        Me.Panel3.Controls.Add(Me.Cd_communeComboBox)
        Me.Panel3.Controls.Add(Me.QuartierDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(549, 330)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(528, 309)
        Me.Panel3.TabIndex = 2
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Me.BindingNavigatorAddNewItem3
        Me.BindingNavigator4.BindingSource = Me.QuartierBindingSource
        Me.BindingNavigator4.CountItem = Me.BindingNavigatorCountItem3
        Me.BindingNavigator4.DeleteItem = Me.BindingNavigatorDeleteItem3
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem3, Me.BindingNavigatorMovePreviousItem3, Me.BindingNavigatorSeparator9, Me.BindingNavigatorPositionItem3, Me.BindingNavigatorCountItem3, Me.BindingNavigatorSeparator10, Me.BindingNavigatorMoveNextItem3, Me.BindingNavigatorMoveLastItem3, Me.BindingNavigatorSeparator11, Me.BindingNavigatorAddNewItem3, Me.BindingNavigatorDeleteItem3, Me.SaveToolStrip_Quartier})
        Me.BindingNavigator4.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator4.MoveFirstItem = Me.BindingNavigatorMoveFirstItem3
        Me.BindingNavigator4.MoveLastItem = Me.BindingNavigatorMoveLastItem3
        Me.BindingNavigator4.MoveNextItem = Me.BindingNavigatorMoveNextItem3
        Me.BindingNavigator4.MovePreviousItem = Me.BindingNavigatorMovePreviousItem3
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.BindingNavigatorPositionItem3
        Me.BindingNavigator4.Size = New System.Drawing.Size(528, 25)
        Me.BindingNavigator4.TabIndex = 7
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'BindingNavigatorAddNewItem3
        '
        Me.BindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem3.Image = CType(resources.GetObject("BindingNavigatorAddNewItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem3.Name = "BindingNavigatorAddNewItem3"
        Me.BindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem3.Text = "Add new"
        '
        'QuartierBindingSource
        '
        Me.QuartierBindingSource.DataMember = "Quartier"
        Me.QuartierBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'BindingNavigatorCountItem3
        '
        Me.BindingNavigatorCountItem3.Name = "BindingNavigatorCountItem3"
        Me.BindingNavigatorCountItem3.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem3.Text = "of {0}"
        Me.BindingNavigatorCountItem3.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem3
        '
        Me.BindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem3.Image = CType(resources.GetObject("BindingNavigatorDeleteItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem3.Name = "BindingNavigatorDeleteItem3"
        Me.BindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem3.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem3
        '
        Me.BindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem3.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem3.Name = "BindingNavigatorMoveFirstItem3"
        Me.BindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem3.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem3
        '
        Me.BindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem3.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem3.Name = "BindingNavigatorMovePreviousItem3"
        Me.BindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem3.Text = "Move previous"
        '
        'BindingNavigatorSeparator9
        '
        Me.BindingNavigatorSeparator9.Name = "BindingNavigatorSeparator9"
        Me.BindingNavigatorSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem3
        '
        Me.BindingNavigatorPositionItem3.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem3.AutoSize = False
        Me.BindingNavigatorPositionItem3.Name = "BindingNavigatorPositionItem3"
        Me.BindingNavigatorPositionItem3.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem3.Text = "0"
        Me.BindingNavigatorPositionItem3.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator10
        '
        Me.BindingNavigatorSeparator10.Name = "BindingNavigatorSeparator10"
        Me.BindingNavigatorSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem3
        '
        Me.BindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem3.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem3.Name = "BindingNavigatorMoveNextItem3"
        Me.BindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem3.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem3
        '
        Me.BindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem3.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem3.Name = "BindingNavigatorMoveLastItem3"
        Me.BindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem3.Text = "Move last"
        '
        'BindingNavigatorSeparator11
        '
        Me.BindingNavigatorSeparator11.Name = "BindingNavigatorSeparator11"
        Me.BindingNavigatorSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStrip_Quartier
        '
        Me.SaveToolStrip_Quartier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStrip_Quartier.Image = CType(resources.GetObject("SaveToolStrip_Quartier.Image"), System.Drawing.Image)
        Me.SaveToolStrip_Quartier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStrip_Quartier.Name = "SaveToolStrip_Quartier"
        Me.SaveToolStrip_Quartier.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStrip_Quartier.Text = "&Save"
        '
        'Nom_QuartierTextBox
        '
        Me.Nom_QuartierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuartierBindingSource, "Nom_Quartier", True))
        Me.Nom_QuartierTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_QuartierTextBox.Location = New System.Drawing.Point(72, 92)
        Me.Nom_QuartierTextBox.Name = "Nom_QuartierTextBox"
        Me.Nom_QuartierTextBox.Size = New System.Drawing.Size(166, 27)
        Me.Nom_QuartierTextBox.TabIndex = 4
        '
        'Cd_communeComboBox
        '
        Me.Cd_communeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.QuartierBindingSource, "Cd_commune", True))
        Me.Cd_communeComboBox.DataSource = Me.CommuneBindingSource1
        Me.Cd_communeComboBox.DisplayMember = "Nom_commune"
        Me.Cd_communeComboBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cd_communeComboBox.FormattingEnabled = True
        Me.Cd_communeComboBox.Location = New System.Drawing.Point(307, 92)
        Me.Cd_communeComboBox.Name = "Cd_communeComboBox"
        Me.Cd_communeComboBox.Size = New System.Drawing.Size(166, 27)
        Me.Cd_communeComboBox.TabIndex = 6
        Me.Cd_communeComboBox.ValueMember = "Cd_commune"
        '
        'QuartierDataGridView
        '
        Me.QuartierDataGridView.AutoGenerateColumns = False
        Me.QuartierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.QuartierDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.QuartierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QuartierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.QuartierDataGridView.DataSource = Me.QuartierBindingSource
        Me.QuartierDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.QuartierDataGridView.Location = New System.Drawing.Point(0, 162)
        Me.QuartierDataGridView.Name = "QuartierDataGridView"
        Me.QuartierDataGridView.ReadOnly = True
        Me.QuartierDataGridView.Size = New System.Drawing.Size(528, 147)
        Me.QuartierDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cd_Quartier"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cd_Quartier"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Nom_Quartier"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nom_Quartier"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cd_commune"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cd_commune"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Controls.Add(Me.Cd_dairaComboBox)
        Me.Panel4.Controls.Add(Me.BindingNavigator3)
        Me.Panel4.Controls.Add(Nom_communeLabel)
        Me.Panel4.Controls.Add(Me.Nom_communeTextBox)
        Me.Panel4.Controls.Add(Cd_dairaLabel)
        Me.Panel4.Controls.Add(Me.CommuneDataGridView)
        Me.Panel4.Location = New System.Drawing.Point(0, 330)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(520, 309)
        Me.Panel4.TabIndex = 3
        '
        'Cd_dairaComboBox
        '
        Me.Cd_dairaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CommuneBindingSource, "Cd_daira", True))
        Me.Cd_dairaComboBox.DataSource = Me.DairaBindingSource1
        Me.Cd_dairaComboBox.DisplayMember = "Nom_daira"
        Me.Cd_dairaComboBox.FormattingEnabled = True
        Me.Cd_dairaComboBox.Location = New System.Drawing.Point(332, 97)
        Me.Cd_dairaComboBox.Name = "Cd_dairaComboBox"
        Me.Cd_dairaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cd_dairaComboBox.TabIndex = 8
        Me.Cd_dairaComboBox.ValueMember = "Cd_daira"
        '
        'CommuneBindingSource
        '
        Me.CommuneBindingSource.DataMember = "Commune"
        Me.CommuneBindingSource.DataSource = Me.Droit_propriter_etatDataSet
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.BindingNavigator3.BindingSource = Me.CommuneBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator3.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2, Me.SaveToolStrip_Commune})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator3.Size = New System.Drawing.Size(520, 25)
        Me.BindingNavigator3.TabIndex = 7
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem2.Text = "Add new"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem2.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStrip_Commune
        '
        Me.SaveToolStrip_Commune.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStrip_Commune.Image = CType(resources.GetObject("SaveToolStrip_Commune.Image"), System.Drawing.Image)
        Me.SaveToolStrip_Commune.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStrip_Commune.Name = "SaveToolStrip_Commune"
        Me.SaveToolStrip_Commune.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStrip_Commune.Text = "&Save"
        '
        'Nom_communeTextBox
        '
        Me.Nom_communeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommuneBindingSource, "Nom_commune", True))
        Me.Nom_communeTextBox.Font = New System.Drawing.Font("Nina", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_communeTextBox.ForeColor = System.Drawing.Color.Black
        Me.Nom_communeTextBox.Location = New System.Drawing.Point(63, 92)
        Me.Nom_communeTextBox.Name = "Nom_communeTextBox"
        Me.Nom_communeTextBox.Size = New System.Drawing.Size(174, 27)
        Me.Nom_communeTextBox.TabIndex = 4
        '
        'CommuneDataGridView
        '
        Me.CommuneDataGridView.AutoGenerateColumns = False
        Me.CommuneDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CommuneDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.CommuneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CommuneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CommuneDataGridView.DataSource = Me.CommuneBindingSource
        Me.CommuneDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CommuneDataGridView.Location = New System.Drawing.Point(0, 162)
        Me.CommuneDataGridView.Name = "CommuneDataGridView"
        Me.CommuneDataGridView.ReadOnly = True
        Me.CommuneDataGridView.Size = New System.Drawing.Size(520, 147)
        Me.CommuneDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cd_commune"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cd_commune"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nom_commune"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nom_commune"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cd_daira"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cd_daira"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'WilayaTableAdapter
        '
        Me.WilayaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CommuneTableAdapter = Me.CommuneTableAdapter
        Me.TableAdapterManager.DairaTableAdapter = Me.DairaTableAdapter
        Me.TableAdapterManager.Demande_acquisitionTableAdapter = Nothing
        Me.TableAdapterManager.DirecteurTableAdapter = Nothing
        Me.TableAdapterManager.Droits_de_propriete_de_etatTableAdapter = Nothing
        Me.TableAdapterManager.Echencer_VersementTableAdapter = Nothing
        Me.TableAdapterManager.GestionnaireTableAdapter = Nothing
        Me.TableAdapterManager.LocalTableAdapter = Nothing
        Me.TableAdapterManager.PV_Commession_CessionTableAdapter = Nothing
        Me.TableAdapterManager.QuartierTableAdapter = Me.QuartierTableAdapter
        Me.TableAdapterManager.Rapport_evaluationTableAdapter = Nothing
        Me.TableAdapterManager.ResidenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.droit_propriter_etatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.WilayaTableAdapter = Me.WilayaTableAdapter
        '
        'CommuneTableAdapter
        '
        Me.CommuneTableAdapter.ClearBeforeFill = True
        '
        'DairaTableAdapter
        '
        Me.DairaTableAdapter.ClearBeforeFill = True
        '
        'QuartierTableAdapter
        '
        Me.QuartierTableAdapter.ClearBeforeFill = True
        '
        'WilayaBindingSource1
        '
        Me.WilayaBindingSource1.DataMember = "Wilaya"
        Me.WilayaBindingSource1.DataSource = Me.Droit_propriter_etatDataSet
        '
        'DairaBindingSource1
        '
        Me.DairaBindingSource1.DataMember = "Daira"
        Me.DairaBindingSource1.DataSource = Me.Droit_propriter_etatDataSet
        '
        'CommuneBindingSource1
        '
        Me.CommuneBindingSource1.DataMember = "Commune"
        Me.CommuneBindingSource1.DataSource = Me.Droit_propriter_etatDataSet
        '
        'Form_wilaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1077, 639)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_wilaya"
        Me.Text = "Form_wilaya"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.WilayaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Droit_propriter_etatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WilayaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DairaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.DairaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        CType(Me.QuartierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuartierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.CommuneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.CommuneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WilayaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DairaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommuneBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Droit_propriter_etatDataSet As droit_propriter_etatDataSet
    Friend WithEvents WilayaBindingSource As BindingSource
    Friend WithEvents WilayaTableAdapter As droit_propriter_etatDataSetTableAdapters.WilayaTableAdapter
    Friend WithEvents TableAdapterManager As droit_propriter_etatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cd_wilayaTextBox As TextBox
    Friend WithEvents Nom_wilayaTextBox As TextBox
    Friend WithEvents WilayaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DairaTableAdapter As droit_propriter_etatDataSetTableAdapters.DairaTableAdapter
    Friend WithEvents DairaBindingSource As BindingSource
    Friend WithEvents Nom_dairaTextBox As TextBox
    Friend WithEvents DairaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents CommuneTableAdapter As droit_propriter_etatDataSetTableAdapters.CommuneTableAdapter
    Friend WithEvents CommuneBindingSource As BindingSource
    Friend WithEvents Nom_communeTextBox As TextBox
    Friend WithEvents CommuneDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents QuartierTableAdapter As droit_propriter_etatDataSetTableAdapters.QuartierTableAdapter
    Friend WithEvents QuartierBindingSource As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents BindingNavigator4 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem3 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator9 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem3 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator10 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator11 As ToolStripSeparator
    Friend WithEvents Nom_QuartierTextBox As TextBox
    Friend WithEvents Cd_communeComboBox As ComboBox
    Friend WithEvents QuartierDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As ToolStripSeparator
    Friend WithEvents SaveToolStrip_Wilaya As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStrip_Daira As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveToolStrip_Quartier As ToolStripButton
    Friend WithEvents SaveToolStrip_Commune As ToolStripButton
    Friend WithEvents Cd_wilayaComboBox As ComboBox
    Friend WithEvents Cd_dairaComboBox As ComboBox
    Friend WithEvents WilayaBindingSource1 As BindingSource
    Friend WithEvents CommuneBindingSource1 As BindingSource
    Friend WithEvents DairaBindingSource1 As BindingSource
End Class
