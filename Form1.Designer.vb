<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim TITLELabel As System.Windows.Forms.Label
        Dim FIRSTNAMELabel As System.Windows.Forms.Label
        Dim LASTNAMELabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim PHONE_NUMBERLabel As System.Windows.Forms.Label
        Dim ORDER_IDLabel As System.Windows.Forms.Label
        Dim PRODUCT_IDLabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim ORDER_IDLabel1 As System.Windows.Forms.Label
        Dim CUSTOMER_IDLabel1 As System.Windows.Forms.Label
        Dim DATELabel As System.Windows.Forms.Label
        Dim DISPATCHEDLabel As System.Windows.Forms.Label
        Dim PAIDLabel As System.Windows.Forms.Label
        Dim PRODUCT_IDLabel1 As System.Windows.Forms.Label
        Dim PRODUCT_NAMELabel As System.Windows.Forms.Label
        Dim CATEGORIESLabel As System.Windows.Forms.Label
        Dim SIZELabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim STOCK_LEVELLabel As System.Windows.Forms.Label
        Dim REORDER_LEVELLabel As System.Windows.Forms.Label
        Dim MAX_LEVELLabel As System.Windows.Forms.Label
        Dim ORDER_IDLabel2 As System.Windows.Forms.Label
        Dim PRODUCT_IDLabel2 As System.Windows.Forms.Label
        Dim QUANTITYLabel1 As System.Windows.Forms.Label
        Dim ORDER_IDLabel3 As System.Windows.Forms.Label
        Dim CUSTOMER_IDLabel2 As System.Windows.Forms.Label
        Dim DATELabel1 As System.Windows.Forms.Label
        Dim DISPATCHEDLabel1 As System.Windows.Forms.Label
        Dim PAIDLabel1 As System.Windows.Forms.Label
        Dim PRODUCT_IDLabel3 As System.Windows.Forms.Label
        Dim PRODUCT_NAMELabel1 As System.Windows.Forms.Label
        Dim CATEGORIESLabel1 As System.Windows.Forms.Label
        Dim SIZELabel1 As System.Windows.Forms.Label
        Dim UNIT_PRICELabel1 As System.Windows.Forms.Label
        Dim STOCK_LEVELLabel1 As System.Windows.Forms.Label
        Dim REORDER_LEVELLabel1 As System.Windows.Forms.Label
        Dim MAX_LEVELLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CUSTOMER_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SHOPDataSet = New INVENTORY_SYSTEM.SHOPDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbUsername = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnExist = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CUSTOMER_DETAILSTableAdapter = New INVENTORY_SYSTEM.SHOPDataSetTableAdapters.CUSTOMER_DETAILSTableAdapter()
        Me.TableAdapterManager = New INVENTORY_SYSTEM.SHOPDataSetTableAdapters.TableAdapterManager()
        Me.CUSTOMER_DETAILSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CUSTOMER_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.FIRSTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.LASTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.PHONE_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_CATALOGDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_CATALOGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCT_IDTextBox3 = New System.Windows.Forms.TextBox()
        Me.PRODUCT_NAMETextBox1 = New System.Windows.Forms.TextBox()
        Me.CATEGORIESTextBox1 = New System.Windows.Forms.TextBox()
        Me.SIZETextBox1 = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox1 = New System.Windows.Forms.TextBox()
        Me.STOCK_LEVELTextBox1 = New System.Windows.Forms.TextBox()
        Me.REORDER_LEVELTextBox1 = New System.Windows.Forms.TextBox()
        Me.MAX_LEVELTextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_DETAILSDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDER_IDTextBox2 = New System.Windows.Forms.TextBox()
        Me.PRODUCT_IDTextBox2 = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PRODUCT_ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORDER_IDTextBox3 = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_IDTextBox2 = New System.Windows.Forms.TextBox()
        Me.DATEDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DISPATCHEDCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PAIDCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_ORDERSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ORDER_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DISPATCHEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.PAIDCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.PRODUCT_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.CATEGORIESTextBox = New System.Windows.Forms.TextBox()
        Me.SIZETextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.STOCK_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.REORDER_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.MAX_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT_DETAILSTableAdapter = New INVENTORY_SYSTEM.SHOPDataSetTableAdapters.PRODUCT_DETAILSTableAdapter()
        Me.PRODUCT_ORDERSTableAdapter = New INVENTORY_SYSTEM.SHOPDataSetTableAdapters.PRODUCT_ORDERSTableAdapter()
        Me.PRODUCT_CATALOGTableAdapter = New INVENTORY_SYSTEM.SHOPDataSetTableAdapters.PRODUCT_CATALOGTableAdapter()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        TITLELabel = New System.Windows.Forms.Label()
        FIRSTNAMELabel = New System.Windows.Forms.Label()
        LASTNAMELabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        PHONE_NUMBERLabel = New System.Windows.Forms.Label()
        ORDER_IDLabel = New System.Windows.Forms.Label()
        PRODUCT_IDLabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        ORDER_IDLabel1 = New System.Windows.Forms.Label()
        CUSTOMER_IDLabel1 = New System.Windows.Forms.Label()
        DATELabel = New System.Windows.Forms.Label()
        DISPATCHEDLabel = New System.Windows.Forms.Label()
        PAIDLabel = New System.Windows.Forms.Label()
        PRODUCT_IDLabel1 = New System.Windows.Forms.Label()
        PRODUCT_NAMELabel = New System.Windows.Forms.Label()
        CATEGORIESLabel = New System.Windows.Forms.Label()
        SIZELabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        STOCK_LEVELLabel = New System.Windows.Forms.Label()
        REORDER_LEVELLabel = New System.Windows.Forms.Label()
        MAX_LEVELLabel = New System.Windows.Forms.Label()
        ORDER_IDLabel2 = New System.Windows.Forms.Label()
        PRODUCT_IDLabel2 = New System.Windows.Forms.Label()
        QUANTITYLabel1 = New System.Windows.Forms.Label()
        ORDER_IDLabel3 = New System.Windows.Forms.Label()
        CUSTOMER_IDLabel2 = New System.Windows.Forms.Label()
        DATELabel1 = New System.Windows.Forms.Label()
        DISPATCHEDLabel1 = New System.Windows.Forms.Label()
        PAIDLabel1 = New System.Windows.Forms.Label()
        PRODUCT_IDLabel3 = New System.Windows.Forms.Label()
        PRODUCT_NAMELabel1 = New System.Windows.Forms.Label()
        CATEGORIESLabel1 = New System.Windows.Forms.Label()
        SIZELabel1 = New System.Windows.Forms.Label()
        UNIT_PRICELabel1 = New System.Windows.Forms.Label()
        STOCK_LEVELLabel1 = New System.Windows.Forms.Label()
        REORDER_LEVELLabel1 = New System.Windows.Forms.Label()
        MAX_LEVELLabel1 = New System.Windows.Forms.Label()
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CUSTOMER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUSTOMER_DETAILSBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PRODUCT_CATALOGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_CATALOGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PRODUCT_DETAILSDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PRODUCT_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.PRODUCT_ORDERSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.SuspendLayout()
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(30, 40)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(97, 13)
        CUSTOMER_IDLabel.TabIndex = 0
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Location = New System.Drawing.Point(30, 90)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(46, 13)
        TITLELabel.TabIndex = 2
        TITLELabel.Text = "TITLE:"
        '
        'FIRSTNAMELabel
        '
        FIRSTNAMELabel.AutoSize = True
        FIRSTNAMELabel.Location = New System.Drawing.Point(30, 140)
        FIRSTNAMELabel.Name = "FIRSTNAMELabel"
        FIRSTNAMELabel.Size = New System.Drawing.Size(82, 13)
        FIRSTNAMELabel.TabIndex = 4
        FIRSTNAMELabel.Text = "FIRSTNAME:"
        '
        'LASTNAMELabel
        '
        LASTNAMELabel.AutoSize = True
        LASTNAMELabel.Location = New System.Drawing.Point(30, 190)
        LASTNAMELabel.Name = "LASTNAMELabel"
        LASTNAMELabel.Size = New System.Drawing.Size(77, 13)
        LASTNAMELabel.TabIndex = 6
        LASTNAMELabel.Text = "LASTNAME:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(30, 240)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(70, 13)
        ADDRESSLabel.TabIndex = 8
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'PHONE_NUMBERLabel
        '
        PHONE_NUMBERLabel.AutoSize = True
        PHONE_NUMBERLabel.Location = New System.Drawing.Point(30, 291)
        PHONE_NUMBERLabel.Name = "PHONE_NUMBERLabel"
        PHONE_NUMBERLabel.Size = New System.Drawing.Size(111, 13)
        PHONE_NUMBERLabel.TabIndex = 10
        PHONE_NUMBERLabel.Text = "PHONE NUMBER:"
        '
        'ORDER_IDLabel
        '
        ORDER_IDLabel.AutoSize = True
        ORDER_IDLabel.Location = New System.Drawing.Point(40, 46)
        ORDER_IDLabel.Name = "ORDER_IDLabel"
        ORDER_IDLabel.Size = New System.Drawing.Size(63, 13)
        ORDER_IDLabel.TabIndex = 0
        ORDER_IDLabel.Text = "ORDER ID:"
        '
        'PRODUCT_IDLabel
        '
        PRODUCT_IDLabel.AutoSize = True
        PRODUCT_IDLabel.Location = New System.Drawing.Point(40, 72)
        PRODUCT_IDLabel.Name = "PRODUCT_IDLabel"
        PRODUCT_IDLabel.Size = New System.Drawing.Size(77, 13)
        PRODUCT_IDLabel.TabIndex = 2
        PRODUCT_IDLabel.Text = "PRODUCT ID:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(40, 98)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 4
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'ORDER_IDLabel1
        '
        ORDER_IDLabel1.AutoSize = True
        ORDER_IDLabel1.Location = New System.Drawing.Point(27, 37)
        ORDER_IDLabel1.Name = "ORDER_IDLabel1"
        ORDER_IDLabel1.Size = New System.Drawing.Size(63, 13)
        ORDER_IDLabel1.TabIndex = 0
        ORDER_IDLabel1.Text = "ORDER ID:"
        '
        'CUSTOMER_IDLabel1
        '
        CUSTOMER_IDLabel1.AutoSize = True
        CUSTOMER_IDLabel1.Location = New System.Drawing.Point(27, 63)
        CUSTOMER_IDLabel1.Name = "CUSTOMER_IDLabel1"
        CUSTOMER_IDLabel1.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel1.TabIndex = 2
        CUSTOMER_IDLabel1.Text = "CUSTOMER ID:"
        '
        'DATELabel
        '
        DATELabel.AutoSize = True
        DATELabel.Location = New System.Drawing.Point(27, 90)
        DATELabel.Name = "DATELabel"
        DATELabel.Size = New System.Drawing.Size(39, 13)
        DATELabel.TabIndex = 4
        DATELabel.Text = "DATE:"
        '
        'DISPATCHEDLabel
        '
        DISPATCHEDLabel.AutoSize = True
        DISPATCHEDLabel.Location = New System.Drawing.Point(27, 117)
        DISPATCHEDLabel.Name = "DISPATCHEDLabel"
        DISPATCHEDLabel.Size = New System.Drawing.Size(79, 13)
        DISPATCHEDLabel.TabIndex = 6
        DISPATCHEDLabel.Text = "DISPATCHED:"
        '
        'PAIDLabel
        '
        PAIDLabel.AutoSize = True
        PAIDLabel.Location = New System.Drawing.Point(27, 147)
        PAIDLabel.Name = "PAIDLabel"
        PAIDLabel.Size = New System.Drawing.Size(35, 13)
        PAIDLabel.TabIndex = 8
        PAIDLabel.Text = "PAID:"
        '
        'PRODUCT_IDLabel1
        '
        PRODUCT_IDLabel1.AutoSize = True
        PRODUCT_IDLabel1.Location = New System.Drawing.Point(25, 3)
        PRODUCT_IDLabel1.Name = "PRODUCT_IDLabel1"
        PRODUCT_IDLabel1.Size = New System.Drawing.Size(77, 13)
        PRODUCT_IDLabel1.TabIndex = 0
        PRODUCT_IDLabel1.Text = "PRODUCT ID:"
        '
        'PRODUCT_NAMELabel
        '
        PRODUCT_NAMELabel.AutoSize = True
        PRODUCT_NAMELabel.Location = New System.Drawing.Point(25, 29)
        PRODUCT_NAMELabel.Name = "PRODUCT_NAMELabel"
        PRODUCT_NAMELabel.Size = New System.Drawing.Size(97, 13)
        PRODUCT_NAMELabel.TabIndex = 2
        PRODUCT_NAMELabel.Text = "PRODUCT NAME:"
        '
        'CATEGORIESLabel
        '
        CATEGORIESLabel.AutoSize = True
        CATEGORIESLabel.Location = New System.Drawing.Point(25, 55)
        CATEGORIESLabel.Name = "CATEGORIESLabel"
        CATEGORIESLabel.Size = New System.Drawing.Size(79, 13)
        CATEGORIESLabel.TabIndex = 4
        CATEGORIESLabel.Text = "CATEGORIES:"
        '
        'SIZELabel
        '
        SIZELabel.AutoSize = True
        SIZELabel.Location = New System.Drawing.Point(25, 81)
        SIZELabel.Name = "SIZELabel"
        SIZELabel.Size = New System.Drawing.Size(34, 13)
        SIZELabel.TabIndex = 6
        SIZELabel.Text = "SIZE:"
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(25, 107)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(71, 13)
        UNIT_PRICELabel.TabIndex = 8
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'STOCK_LEVELLabel
        '
        STOCK_LEVELLabel.AutoSize = True
        STOCK_LEVELLabel.Location = New System.Drawing.Point(25, 133)
        STOCK_LEVELLabel.Name = "STOCK_LEVELLabel"
        STOCK_LEVELLabel.Size = New System.Drawing.Size(82, 13)
        STOCK_LEVELLabel.TabIndex = 10
        STOCK_LEVELLabel.Text = "STOCK LEVEL:"
        '
        'REORDER_LEVELLabel
        '
        REORDER_LEVELLabel.AutoSize = True
        REORDER_LEVELLabel.Location = New System.Drawing.Point(25, 159)
        REORDER_LEVELLabel.Name = "REORDER_LEVELLabel"
        REORDER_LEVELLabel.Size = New System.Drawing.Size(100, 13)
        REORDER_LEVELLabel.TabIndex = 12
        REORDER_LEVELLabel.Text = "REORDER LEVEL:"
        '
        'MAX_LEVELLabel
        '
        MAX_LEVELLabel.AutoSize = True
        MAX_LEVELLabel.Location = New System.Drawing.Point(25, 185)
        MAX_LEVELLabel.Name = "MAX_LEVELLabel"
        MAX_LEVELLabel.Size = New System.Drawing.Size(69, 13)
        MAX_LEVELLabel.TabIndex = 14
        MAX_LEVELLabel.Text = "MAX LEVEL:"
        '
        'ORDER_IDLabel2
        '
        ORDER_IDLabel2.AutoSize = True
        ORDER_IDLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ORDER_IDLabel2.Location = New System.Drawing.Point(53, 27)
        ORDER_IDLabel2.Name = "ORDER_IDLabel2"
        ORDER_IDLabel2.Size = New System.Drawing.Size(72, 13)
        ORDER_IDLabel2.TabIndex = 0
        ORDER_IDLabel2.Text = "ORDER ID:"
        '
        'PRODUCT_IDLabel2
        '
        PRODUCT_IDLabel2.AutoSize = True
        PRODUCT_IDLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRODUCT_IDLabel2.Location = New System.Drawing.Point(53, 77)
        PRODUCT_IDLabel2.Name = "PRODUCT_IDLabel2"
        PRODUCT_IDLabel2.Size = New System.Drawing.Size(88, 13)
        PRODUCT_IDLabel2.TabIndex = 2
        PRODUCT_IDLabel2.Text = "PRODUCT ID:"
        '
        'QUANTITYLabel1
        '
        QUANTITYLabel1.AutoSize = True
        QUANTITYLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QUANTITYLabel1.Location = New System.Drawing.Point(53, 127)
        QUANTITYLabel1.Name = "QUANTITYLabel1"
        QUANTITYLabel1.Size = New System.Drawing.Size(74, 13)
        QUANTITYLabel1.TabIndex = 4
        QUANTITYLabel1.Text = "QUANTITY:"
        '
        'ORDER_IDLabel3
        '
        ORDER_IDLabel3.AutoSize = True
        ORDER_IDLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ORDER_IDLabel3.Location = New System.Drawing.Point(36, 15)
        ORDER_IDLabel3.Name = "ORDER_IDLabel3"
        ORDER_IDLabel3.Size = New System.Drawing.Size(72, 13)
        ORDER_IDLabel3.TabIndex = 0
        ORDER_IDLabel3.Text = "ORDER ID:"
        '
        'CUSTOMER_IDLabel2
        '
        CUSTOMER_IDLabel2.AutoSize = True
        CUSTOMER_IDLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CUSTOMER_IDLabel2.Location = New System.Drawing.Point(36, 65)
        CUSTOMER_IDLabel2.Name = "CUSTOMER_IDLabel2"
        CUSTOMER_IDLabel2.Size = New System.Drawing.Size(97, 13)
        CUSTOMER_IDLabel2.TabIndex = 2
        CUSTOMER_IDLabel2.Text = "CUSTOMER ID:"
        '
        'DATELabel1
        '
        DATELabel1.AutoSize = True
        DATELabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATELabel1.Location = New System.Drawing.Point(36, 116)
        DATELabel1.Name = "DATELabel1"
        DATELabel1.Size = New System.Drawing.Size(44, 13)
        DATELabel1.TabIndex = 4
        DATELabel1.Text = "DATE:"
        '
        'DISPATCHEDLabel1
        '
        DISPATCHEDLabel1.AutoSize = True
        DISPATCHEDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DISPATCHEDLabel1.Location = New System.Drawing.Point(36, 167)
        DISPATCHEDLabel1.Name = "DISPATCHEDLabel1"
        DISPATCHEDLabel1.Size = New System.Drawing.Size(90, 13)
        DISPATCHEDLabel1.TabIndex = 6
        DISPATCHEDLabel1.Text = "DISPATCHED:"
        '
        'PAIDLabel1
        '
        PAIDLabel1.AutoSize = True
        PAIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PAIDLabel1.Location = New System.Drawing.Point(36, 215)
        PAIDLabel1.Name = "PAIDLabel1"
        PAIDLabel1.Size = New System.Drawing.Size(40, 13)
        PAIDLabel1.TabIndex = 8
        PAIDLabel1.Text = "PAID:"
        '
        'PRODUCT_IDLabel3
        '
        PRODUCT_IDLabel3.AutoSize = True
        PRODUCT_IDLabel3.Location = New System.Drawing.Point(25, 24)
        PRODUCT_IDLabel3.Name = "PRODUCT_IDLabel3"
        PRODUCT_IDLabel3.Size = New System.Drawing.Size(88, 13)
        PRODUCT_IDLabel3.TabIndex = 0
        PRODUCT_IDLabel3.Text = "PRODUCT ID:"
        '
        'PRODUCT_NAMELabel1
        '
        PRODUCT_NAMELabel1.AutoSize = True
        PRODUCT_NAMELabel1.Location = New System.Drawing.Point(25, 50)
        PRODUCT_NAMELabel1.Name = "PRODUCT_NAMELabel1"
        PRODUCT_NAMELabel1.Size = New System.Drawing.Size(110, 13)
        PRODUCT_NAMELabel1.TabIndex = 2
        PRODUCT_NAMELabel1.Text = "PRODUCT NAME:"
        '
        'CATEGORIESLabel1
        '
        CATEGORIESLabel1.AutoSize = True
        CATEGORIESLabel1.Location = New System.Drawing.Point(25, 76)
        CATEGORIESLabel1.Name = "CATEGORIESLabel1"
        CATEGORIESLabel1.Size = New System.Drawing.Size(90, 13)
        CATEGORIESLabel1.TabIndex = 4
        CATEGORIESLabel1.Text = "CATEGORIES:"
        '
        'SIZELabel1
        '
        SIZELabel1.AutoSize = True
        SIZELabel1.Location = New System.Drawing.Point(25, 102)
        SIZELabel1.Name = "SIZELabel1"
        SIZELabel1.Size = New System.Drawing.Size(39, 13)
        SIZELabel1.TabIndex = 6
        SIZELabel1.Text = "SIZE:"
        '
        'UNIT_PRICELabel1
        '
        UNIT_PRICELabel1.AutoSize = True
        UNIT_PRICELabel1.Location = New System.Drawing.Point(25, 128)
        UNIT_PRICELabel1.Name = "UNIT_PRICELabel1"
        UNIT_PRICELabel1.Size = New System.Drawing.Size(82, 13)
        UNIT_PRICELabel1.TabIndex = 8
        UNIT_PRICELabel1.Text = "UNIT PRICE:"
        '
        'STOCK_LEVELLabel1
        '
        STOCK_LEVELLabel1.AutoSize = True
        STOCK_LEVELLabel1.Location = New System.Drawing.Point(25, 154)
        STOCK_LEVELLabel1.Name = "STOCK_LEVELLabel1"
        STOCK_LEVELLabel1.Size = New System.Drawing.Size(94, 13)
        STOCK_LEVELLabel1.TabIndex = 10
        STOCK_LEVELLabel1.Text = "STOCK LEVEL:"
        '
        'REORDER_LEVELLabel1
        '
        REORDER_LEVELLabel1.AutoSize = True
        REORDER_LEVELLabel1.Location = New System.Drawing.Point(25, 180)
        REORDER_LEVELLabel1.Name = "REORDER_LEVELLabel1"
        REORDER_LEVELLabel1.Size = New System.Drawing.Size(114, 13)
        REORDER_LEVELLabel1.TabIndex = 12
        REORDER_LEVELLabel1.Text = "REORDER LEVEL:"
        '
        'MAX_LEVELLabel1
        '
        MAX_LEVELLabel1.AutoSize = True
        MAX_LEVELLabel1.Location = New System.Drawing.Point(25, 206)
        MAX_LEVELLabel1.Name = "MAX_LEVELLabel1"
        MAX_LEVELLabel1.Size = New System.Drawing.Size(79, 13)
        MAX_LEVELLabel1.TabIndex = 14
        MAX_LEVELLabel1.Text = "MAX LEVEL:"
        '
        'CUSTOMER_DETAILSBindingSource
        '
        Me.CUSTOMER_DETAILSBindingSource.DataMember = "CUSTOMER DETAILS"
        Me.CUSTOMER_DETAILSBindingSource.DataSource = Me.SHOPDataSet
        '
        'SHOPDataSet
        '
        Me.SHOPDataSet.DataSetName = "SHOPDataSet"
        Me.SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbUsername)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.btnExist)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnPassword)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1172, 734)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'cmbUsername
        '
        Me.cmbUsername.FormattingEnabled = True
        Me.cmbUsername.Location = New System.Drawing.Point(308, 137)
        Me.cmbUsername.Name = "cmbUsername"
        Me.cmbUsername.Size = New System.Drawing.Size(189, 21)
        Me.cmbUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(308, 219)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(189, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(308, 175)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(189, 20)
        Me.txtUsername.TabIndex = 2
        '
        'btnExist
        '
        Me.btnExist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExist.Location = New System.Drawing.Point(413, 264)
        Me.btnExist.Name = "btnExist"
        Me.btnExist.Size = New System.Drawing.Size(75, 23)
        Me.btnExist.TabIndex = 1
        Me.btnExist.Text = "Exit"
        Me.btnExist.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(308, 264)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPassword
        '
        Me.btnPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.Location = New System.Drawing.Point(193, 264)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(75, 23)
        Me.btnPassword.TabIndex = 1
        Me.btnPassword.Text = "Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(207, 219)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DEPARTMENT"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(205, 178)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(63, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(819, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STOCK CONTROL LOGIN"
        '
        'CUSTOMER_DETAILSTableAdapter
        '
        Me.CUSTOMER_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMER_DETAILSTableAdapter = Me.CUSTOMER_DETAILSTableAdapter
        Me.TableAdapterManager.PRODUCT_CATALOGTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_ORDERSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = INVENTORY_SYSTEM.SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CUSTOMER_DETAILSBindingNavigator
        '
        Me.CUSTOMER_DETAILSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CUSTOMER_DETAILSBindingNavigator.BindingSource = Me.CUSTOMER_DETAILSBindingSource
        Me.CUSTOMER_DETAILSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUSTOMER_DETAILSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CUSTOMER_DETAILSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CUSTOMER_DETAILSBindingNavigatorSaveItem})
        Me.CUSTOMER_DETAILSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CUSTOMER_DETAILSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CUSTOMER_DETAILSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CUSTOMER_DETAILSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CUSTOMER_DETAILSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CUSTOMER_DETAILSBindingNavigator.Name = "CUSTOMER_DETAILSBindingNavigator"
        Me.CUSTOMER_DETAILSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUSTOMER_DETAILSBindingNavigator.Size = New System.Drawing.Size(1369, 25)
        Me.CUSTOMER_DETAILSBindingNavigator.TabIndex = 2
        Me.CUSTOMER_DETAILSBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'CUSTOMER_DETAILSBindingNavigatorSaveItem
        '
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Image = CType(resources.GetObject("CUSTOMER_DETAILSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Name = "CUSTOMER_DETAILSBindingNavigatorSaveItem"
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CUSTOMER_DETAILSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(220, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(712, 713)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.LightGreen
        Me.TabPage1.Controls.Add(Me.btnClose)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnPrevious)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnNext)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.CUSTOMER_DETAILSDataGridView)
        Me.TabPage1.Controls.Add(CUSTOMER_IDLabel)
        Me.TabPage1.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.TabPage1.Controls.Add(TITLELabel)
        Me.TabPage1.Controls.Add(Me.TITLETextBox)
        Me.TabPage1.Controls.Add(FIRSTNAMELabel)
        Me.TabPage1.Controls.Add(Me.FIRSTNAMETextBox)
        Me.TabPage1.Controls.Add(LASTNAMELabel)
        Me.TabPage1.Controls.Add(Me.LASTNAMETextBox)
        Me.TabPage1.Controls.Add(ADDRESSLabel)
        Me.TabPage1.Controls.Add(Me.ADDRESSTextBox)
        Me.TabPage1.Controls.Add(PHONE_NUMBERLabel)
        Me.TabPage1.Controls.Add(Me.PHONE_NUMBERTextBox)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(704, 685)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CUSTOMER DETAILS"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(396, 140)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "EXIT"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(396, 85)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(546, 140)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 13
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(546, 87)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(546, 41)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(396, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'CUSTOMER_DETAILSDataGridView
        '
        Me.CUSTOMER_DETAILSDataGridView.AutoGenerateColumns = False
        Me.CUSTOMER_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CUSTOMER_DETAILSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CUSTOMER_DETAILSDataGridView.DataSource = Me.CUSTOMER_DETAILSBindingSource
        Me.CUSTOMER_DETAILSDataGridView.Location = New System.Drawing.Point(33, 312)
        Me.CUSTOMER_DETAILSDataGridView.Name = "CUSTOMER_DETAILSDataGridView"
        Me.CUSTOMER_DETAILSDataGridView.Size = New System.Drawing.Size(638, 289)
        Me.CUSTOMER_DETAILSDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TITLE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TITLE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FIRSTNAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FIRSTNAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LASTNAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LASTNAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PHONE NUMBER"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PHONE NUMBER"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(215, 37)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 1
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "TITLE", True))
        Me.TITLETextBox.Location = New System.Drawing.Point(215, 87)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TITLETextBox.TabIndex = 3
        '
        'FIRSTNAMETextBox
        '
        Me.FIRSTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "FIRSTNAME", True))
        Me.FIRSTNAMETextBox.Location = New System.Drawing.Point(215, 137)
        Me.FIRSTNAMETextBox.Name = "FIRSTNAMETextBox"
        Me.FIRSTNAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.FIRSTNAMETextBox.TabIndex = 5
        '
        'LASTNAMETextBox
        '
        Me.LASTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "LASTNAME", True))
        Me.LASTNAMETextBox.Location = New System.Drawing.Point(215, 187)
        Me.LASTNAMETextBox.Name = "LASTNAMETextBox"
        Me.LASTNAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.LASTNAMETextBox.TabIndex = 7
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(215, 233)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ADDRESSTextBox.TabIndex = 9
        '
        'PHONE_NUMBERTextBox
        '
        Me.PHONE_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "PHONE NUMBER", True))
        Me.PHONE_NUMBERTextBox.Location = New System.Drawing.Point(215, 286)
        Me.PHONE_NUMBERTextBox.Name = "PHONE_NUMBERTextBox"
        Me.PHONE_NUMBERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PHONE_NUMBERTextBox.TabIndex = 11
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.Color.LightGreen
        Me.TabPage4.Controls.Add(Me.PRODUCT_CATALOGDataGridView)
        Me.TabPage4.Controls.Add(PRODUCT_IDLabel3)
        Me.TabPage4.Controls.Add(Me.PRODUCT_IDTextBox3)
        Me.TabPage4.Controls.Add(PRODUCT_NAMELabel1)
        Me.TabPage4.Controls.Add(Me.PRODUCT_NAMETextBox1)
        Me.TabPage4.Controls.Add(CATEGORIESLabel1)
        Me.TabPage4.Controls.Add(Me.CATEGORIESTextBox1)
        Me.TabPage4.Controls.Add(SIZELabel1)
        Me.TabPage4.Controls.Add(Me.SIZETextBox1)
        Me.TabPage4.Controls.Add(UNIT_PRICELabel1)
        Me.TabPage4.Controls.Add(Me.UNIT_PRICETextBox1)
        Me.TabPage4.Controls.Add(STOCK_LEVELLabel1)
        Me.TabPage4.Controls.Add(Me.STOCK_LEVELTextBox1)
        Me.TabPage4.Controls.Add(REORDER_LEVELLabel1)
        Me.TabPage4.Controls.Add(Me.REORDER_LEVELTextBox1)
        Me.TabPage4.Controls.Add(MAX_LEVELLabel1)
        Me.TabPage4.Controls.Add(Me.MAX_LEVELTextBox1)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(704, 685)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "PRODUCT CATALOQUE"
        '
        'PRODUCT_CATALOGDataGridView
        '
        Me.PRODUCT_CATALOGDataGridView.AutoGenerateColumns = False
        Me.PRODUCT_CATALOGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_CATALOGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.PRODUCT_CATALOGDataGridView.DataSource = Me.PRODUCT_CATALOGBindingSource
        Me.PRODUCT_CATALOGDataGridView.Location = New System.Drawing.Point(28, 232)
        Me.PRODUCT_CATALOGDataGridView.Name = "PRODUCT_CATALOGDataGridView"
        Me.PRODUCT_CATALOGDataGridView.Size = New System.Drawing.Size(645, 220)
        Me.PRODUCT_CATALOGDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn19.HeaderText = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "PRODUCT NAME"
        Me.DataGridViewTextBoxColumn20.HeaderText = "PRODUCT NAME"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "CATEGORIES"
        Me.DataGridViewTextBoxColumn21.HeaderText = "CATEGORIES"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "SIZE"
        Me.DataGridViewTextBoxColumn22.HeaderText = "SIZE"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn23.HeaderText = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "STOCK LEVEL"
        Me.DataGridViewTextBoxColumn24.HeaderText = "STOCK LEVEL"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "REORDER LEVEL"
        Me.DataGridViewTextBoxColumn25.HeaderText = "REORDER LEVEL"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "MAX LEVEL"
        Me.DataGridViewTextBoxColumn26.HeaderText = "MAX LEVEL"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'PRODUCT_CATALOGBindingSource
        '
        Me.PRODUCT_CATALOGBindingSource.DataMember = "PRODUCT CATALOG"
        Me.PRODUCT_CATALOGBindingSource.DataSource = Me.SHOPDataSet
        '
        'PRODUCT_IDTextBox3
        '
        Me.PRODUCT_IDTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox3.Location = New System.Drawing.Point(145, 21)
        Me.PRODUCT_IDTextBox3.Name = "PRODUCT_IDTextBox3"
        Me.PRODUCT_IDTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox3.TabIndex = 1
        '
        'PRODUCT_NAMETextBox1
        '
        Me.PRODUCT_NAMETextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT NAME", True))
        Me.PRODUCT_NAMETextBox1.Location = New System.Drawing.Point(145, 47)
        Me.PRODUCT_NAMETextBox1.Name = "PRODUCT_NAMETextBox1"
        Me.PRODUCT_NAMETextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_NAMETextBox1.TabIndex = 3
        '
        'CATEGORIESTextBox1
        '
        Me.CATEGORIESTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "CATEGORIES", True))
        Me.CATEGORIESTextBox1.Location = New System.Drawing.Point(145, 73)
        Me.CATEGORIESTextBox1.Name = "CATEGORIESTextBox1"
        Me.CATEGORIESTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CATEGORIESTextBox1.TabIndex = 5
        '
        'SIZETextBox1
        '
        Me.SIZETextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "SIZE", True))
        Me.SIZETextBox1.Location = New System.Drawing.Point(145, 99)
        Me.SIZETextBox1.Name = "SIZETextBox1"
        Me.SIZETextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SIZETextBox1.TabIndex = 7
        '
        'UNIT_PRICETextBox1
        '
        Me.UNIT_PRICETextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox1.Location = New System.Drawing.Point(145, 125)
        Me.UNIT_PRICETextBox1.Name = "UNIT_PRICETextBox1"
        Me.UNIT_PRICETextBox1.Size = New System.Drawing.Size(100, 20)
        Me.UNIT_PRICETextBox1.TabIndex = 9
        '
        'STOCK_LEVELTextBox1
        '
        Me.STOCK_LEVELTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "STOCK LEVEL", True))
        Me.STOCK_LEVELTextBox1.Location = New System.Drawing.Point(145, 151)
        Me.STOCK_LEVELTextBox1.Name = "STOCK_LEVELTextBox1"
        Me.STOCK_LEVELTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.STOCK_LEVELTextBox1.TabIndex = 11
        '
        'REORDER_LEVELTextBox1
        '
        Me.REORDER_LEVELTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "REORDER LEVEL", True))
        Me.REORDER_LEVELTextBox1.Location = New System.Drawing.Point(145, 177)
        Me.REORDER_LEVELTextBox1.Name = "REORDER_LEVELTextBox1"
        Me.REORDER_LEVELTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.REORDER_LEVELTextBox1.TabIndex = 13
        '
        'MAX_LEVELTextBox1
        '
        Me.MAX_LEVELTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "MAX LEVEL", True))
        Me.MAX_LEVELTextBox1.Location = New System.Drawing.Point(145, 203)
        Me.MAX_LEVELTextBox1.Name = "MAX_LEVELTextBox1"
        Me.MAX_LEVELTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MAX_LEVELTextBox1.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.LightGreen
        Me.TabPage2.Controls.Add(Me.PRODUCT_DETAILSDataGridView1)
        Me.TabPage2.Controls.Add(ORDER_IDLabel2)
        Me.TabPage2.Controls.Add(Me.ORDER_IDTextBox2)
        Me.TabPage2.Controls.Add(PRODUCT_IDLabel2)
        Me.TabPage2.Controls.Add(Me.PRODUCT_IDTextBox2)
        Me.TabPage2.Controls.Add(QUANTITYLabel1)
        Me.TabPage2.Controls.Add(Me.QUANTITYTextBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(704, 685)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PRODUCT DETAILS"
        '
        'PRODUCT_DETAILSDataGridView1
        '
        Me.PRODUCT_DETAILSDataGridView1.AutoGenerateColumns = False
        Me.PRODUCT_DETAILSDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_DETAILSDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.PRODUCT_DETAILSDataGridView1.DataSource = Me.PRODUCT_DETAILSBindingSource
        Me.PRODUCT_DETAILSDataGridView1.Location = New System.Drawing.Point(30, 183)
        Me.PRODUCT_DETAILSDataGridView1.Name = "PRODUCT_DETAILSDataGridView1"
        Me.PRODUCT_DETAILSDataGridView1.Size = New System.Drawing.Size(546, 370)
        Me.PRODUCT_DETAILSDataGridView1.TabIndex = 6
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ORDER ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ORDER ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn15.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'PRODUCT_DETAILSBindingSource
        '
        Me.PRODUCT_DETAILSBindingSource.DataMember = "PRODUCT DETAILS"
        Me.PRODUCT_DETAILSBindingSource.DataSource = Me.SHOPDataSet
        '
        'ORDER_IDTextBox2
        '
        Me.ORDER_IDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORDER_IDTextBox2.Location = New System.Drawing.Point(293, 24)
        Me.ORDER_IDTextBox2.Name = "ORDER_IDTextBox2"
        Me.ORDER_IDTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.ORDER_IDTextBox2.TabIndex = 1
        '
        'PRODUCT_IDTextBox2
        '
        Me.PRODUCT_IDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCT_IDTextBox2.Location = New System.Drawing.Point(293, 74)
        Me.PRODUCT_IDTextBox2.Name = "PRODUCT_IDTextBox2"
        Me.PRODUCT_IDTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox2.TabIndex = 3
        '
        'QUANTITYTextBox1
        '
        Me.QUANTITYTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QUANTITYTextBox1.Location = New System.Drawing.Point(293, 124)
        Me.QUANTITYTextBox1.Name = "QUANTITYTextBox1"
        Me.QUANTITYTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.LightGreen
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Controls.Add(ORDER_IDLabel3)
        Me.TabPage3.Controls.Add(Me.ORDER_IDTextBox3)
        Me.TabPage3.Controls.Add(CUSTOMER_IDLabel2)
        Me.TabPage3.Controls.Add(Me.CUSTOMER_IDTextBox2)
        Me.TabPage3.Controls.Add(DATELabel1)
        Me.TabPage3.Controls.Add(Me.DATEDateTimePicker1)
        Me.TabPage3.Controls.Add(DISPATCHEDLabel1)
        Me.TabPage3.Controls.Add(Me.DISPATCHEDCheckBox1)
        Me.TabPage3.Controls.Add(PAIDLabel1)
        Me.TabPage3.Controls.Add(Me.PAIDCheckBox1)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(704, 685)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PRODUCT ORDER"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4})
        Me.DataGridView1.DataSource = Me.PRODUCT_ORDERSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(629, 318)
        Me.DataGridView1.TabIndex = 11
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ORDER ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ORDER ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "DATE"
        Me.DataGridViewTextBoxColumn18.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "PAID"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "PAID"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'PRODUCT_ORDERSBindingSource
        '
        Me.PRODUCT_ORDERSBindingSource.DataMember = "PRODUCT ORDERS"
        Me.PRODUCT_ORDERSBindingSource.DataSource = Me.SHOPDataSet
        '
        'ORDER_IDTextBox3
        '
        Me.ORDER_IDTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERSBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORDER_IDTextBox3.Location = New System.Drawing.Point(301, 12)
        Me.ORDER_IDTextBox3.Name = "ORDER_IDTextBox3"
        Me.ORDER_IDTextBox3.Size = New System.Drawing.Size(200, 20)
        Me.ORDER_IDTextBox3.TabIndex = 1
        '
        'CUSTOMER_IDTextBox2
        '
        Me.CUSTOMER_IDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERSBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMER_IDTextBox2.Location = New System.Drawing.Point(301, 62)
        Me.CUSTOMER_IDTextBox2.Name = "CUSTOMER_IDTextBox2"
        Me.CUSTOMER_IDTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.CUSTOMER_IDTextBox2.TabIndex = 3
        '
        'DATEDateTimePicker1
        '
        Me.DATEDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRODUCT_ORDERSBindingSource, "DATE", True))
        Me.DATEDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATEDateTimePicker1.Location = New System.Drawing.Point(301, 112)
        Me.DATEDateTimePicker1.Name = "DATEDateTimePicker1"
        Me.DATEDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DATEDateTimePicker1.TabIndex = 5
        '
        'DISPATCHEDCheckBox1
        '
        Me.DISPATCHEDCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PRODUCT_ORDERSBindingSource, "DISPATCHED", True))
        Me.DISPATCHEDCheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISPATCHEDCheckBox1.Location = New System.Drawing.Point(301, 162)
        Me.DISPATCHEDCheckBox1.Name = "DISPATCHEDCheckBox1"
        Me.DISPATCHEDCheckBox1.Size = New System.Drawing.Size(200, 24)
        Me.DISPATCHEDCheckBox1.TabIndex = 7
        Me.DISPATCHEDCheckBox1.Text = "CheckBox1"
        Me.DISPATCHEDCheckBox1.UseVisualStyleBackColor = True
        '
        'PAIDCheckBox1
        '
        Me.PAIDCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PRODUCT_ORDERSBindingSource, "PAID", True))
        Me.PAIDCheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAIDCheckBox1.Location = New System.Drawing.Point(301, 210)
        Me.PAIDCheckBox1.Name = "PAIDCheckBox1"
        Me.PAIDCheckBox1.Size = New System.Drawing.Size(200, 24)
        Me.PAIDCheckBox1.TabIndex = 9
        Me.PAIDCheckBox1.Text = "CheckBox1"
        Me.PAIDCheckBox1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(224, 245)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(704, 418)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.PRODUCT_DETAILSDataGridView)
        Me.TabPage5.Controls.Add(ORDER_IDLabel)
        Me.TabPage5.Controls.Add(Me.ORDER_IDTextBox)
        Me.TabPage5.Controls.Add(PRODUCT_IDLabel)
        Me.TabPage5.Controls.Add(Me.PRODUCT_IDTextBox)
        Me.TabPage5.Controls.Add(QUANTITYLabel)
        Me.TabPage5.Controls.Add(Me.QUANTITYTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(696, 392)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "PRODUCT DETAILS"
        '
        'PRODUCT_DETAILSDataGridView
        '
        Me.PRODUCT_DETAILSDataGridView.AutoGenerateColumns = False
        Me.PRODUCT_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_DETAILSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PRODUCT_DETAILSDataGridView.DataSource = Me.PRODUCT_DETAILSBindingSource
        Me.PRODUCT_DETAILSDataGridView.Location = New System.Drawing.Point(43, 148)
        Me.PRODUCT_DETAILSDataGridView.Name = "PRODUCT_DETAILSDataGridView"
        Me.PRODUCT_DETAILSDataGridView.Size = New System.Drawing.Size(380, 220)
        Me.PRODUCT_DETAILSDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ORDER ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ORDER ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ORDER_IDTextBox
        '
        Me.ORDER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox.Location = New System.Drawing.Point(123, 43)
        Me.ORDER_IDTextBox.Name = "ORDER_IDTextBox"
        Me.ORDER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ORDER_IDTextBox.TabIndex = 1
        '
        'PRODUCT_IDTextBox
        '
        Me.PRODUCT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox.Location = New System.Drawing.Point(123, 69)
        Me.PRODUCT_IDTextBox.Name = "PRODUCT_IDTextBox"
        Me.PRODUCT_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox.TabIndex = 3
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(123, 95)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox.TabIndex = 5
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.GreenYellow
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(696, 392)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "PRODUCT ORDER"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.GreenYellow
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(696, 392)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "PRODUCT CATALOQUE"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Controls.Add(Me.TabPage9)
        Me.TabControl3.Location = New System.Drawing.Point(220, 475)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(722, 174)
        Me.TabControl3.TabIndex = 7
        '
        'TabPage8
        '
        Me.TabPage8.AutoScroll = True
        Me.TabPage8.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage8.Controls.Add(Me.PRODUCT_ORDERSDataGridView)
        Me.TabPage8.Controls.Add(ORDER_IDLabel1)
        Me.TabPage8.Controls.Add(Me.ORDER_IDTextBox1)
        Me.TabPage8.Controls.Add(CUSTOMER_IDLabel1)
        Me.TabPage8.Controls.Add(Me.CUSTOMER_IDTextBox1)
        Me.TabPage8.Controls.Add(DATELabel)
        Me.TabPage8.Controls.Add(Me.DATEDateTimePicker)
        Me.TabPage8.Controls.Add(DISPATCHEDLabel)
        Me.TabPage8.Controls.Add(Me.DISPATCHEDCheckBox)
        Me.TabPage8.Controls.Add(PAIDLabel)
        Me.TabPage8.Controls.Add(Me.PAIDCheckBox)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(714, 148)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "PRODUCT ORDER"
        '
        'PRODUCT_ORDERSDataGridView
        '
        Me.PRODUCT_ORDERSDataGridView.AutoGenerateColumns = False
        Me.PRODUCT_ORDERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_ORDERSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.PRODUCT_ORDERSDataGridView.DataSource = Me.PRODUCT_ORDERSBindingSource
        Me.PRODUCT_ORDERSDataGridView.Location = New System.Drawing.Point(30, 170)
        Me.PRODUCT_ORDERSDataGridView.Name = "PRODUCT_ORDERSDataGridView"
        Me.PRODUCT_ORDERSDataGridView.Size = New System.Drawing.Size(533, 220)
        Me.PRODUCT_ORDERSDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ORDER ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ORDER ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DATE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "PAID"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "PAID"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'ORDER_IDTextBox1
        '
        Me.ORDER_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERSBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox1.Location = New System.Drawing.Point(118, 34)
        Me.ORDER_IDTextBox1.Name = "ORDER_IDTextBox1"
        Me.ORDER_IDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.ORDER_IDTextBox1.TabIndex = 1
        '
        'CUSTOMER_IDTextBox1
        '
        Me.CUSTOMER_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERSBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox1.Location = New System.Drawing.Point(118, 60)
        Me.CUSTOMER_IDTextBox1.Name = "CUSTOMER_IDTextBox1"
        Me.CUSTOMER_IDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.CUSTOMER_IDTextBox1.TabIndex = 3
        '
        'DATEDateTimePicker
        '
        Me.DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRODUCT_ORDERSBindingSource, "DATE", True))
        Me.DATEDateTimePicker.Location = New System.Drawing.Point(152, -57)
        Me.DATEDateTimePicker.Name = "DATEDateTimePicker"
        Me.DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATEDateTimePicker.TabIndex = 5
        '
        'DISPATCHEDCheckBox
        '
        Me.DISPATCHEDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PRODUCT_ORDERSBindingSource, "DISPATCHED", True))
        Me.DISPATCHEDCheckBox.Location = New System.Drawing.Point(118, 112)
        Me.DISPATCHEDCheckBox.Name = "DISPATCHEDCheckBox"
        Me.DISPATCHEDCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.DISPATCHEDCheckBox.TabIndex = 7
        Me.DISPATCHEDCheckBox.Text = "CheckBox1"
        Me.DISPATCHEDCheckBox.UseVisualStyleBackColor = True
        '
        'PAIDCheckBox
        '
        Me.PAIDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PRODUCT_ORDERSBindingSource, "PAID", True))
        Me.PAIDCheckBox.Location = New System.Drawing.Point(118, 142)
        Me.PAIDCheckBox.Name = "PAIDCheckBox"
        Me.PAIDCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.PAIDCheckBox.TabIndex = 9
        Me.PAIDCheckBox.Text = "CheckBox1"
        Me.PAIDCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.AutoScroll = True
        Me.TabPage9.BackColor = System.Drawing.Color.Lime
        Me.TabPage9.Controls.Add(PRODUCT_IDLabel1)
        Me.TabPage9.Controls.Add(Me.PRODUCT_IDTextBox1)
        Me.TabPage9.Controls.Add(PRODUCT_NAMELabel)
        Me.TabPage9.Controls.Add(Me.PRODUCT_NAMETextBox)
        Me.TabPage9.Controls.Add(CATEGORIESLabel)
        Me.TabPage9.Controls.Add(Me.CATEGORIESTextBox)
        Me.TabPage9.Controls.Add(SIZELabel)
        Me.TabPage9.Controls.Add(Me.SIZETextBox)
        Me.TabPage9.Controls.Add(UNIT_PRICELabel)
        Me.TabPage9.Controls.Add(Me.UNIT_PRICETextBox)
        Me.TabPage9.Controls.Add(STOCK_LEVELLabel)
        Me.TabPage9.Controls.Add(Me.STOCK_LEVELTextBox)
        Me.TabPage9.Controls.Add(REORDER_LEVELLabel)
        Me.TabPage9.Controls.Add(Me.REORDER_LEVELTextBox)
        Me.TabPage9.Controls.Add(MAX_LEVELLabel)
        Me.TabPage9.Controls.Add(Me.MAX_LEVELTextBox)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(714, 148)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "PRODUCT CATALOGUE"
        '
        'PRODUCT_IDTextBox1
        '
        Me.PRODUCT_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox1.Location = New System.Drawing.Point(131, 0)
        Me.PRODUCT_IDTextBox1.Name = "PRODUCT_IDTextBox1"
        Me.PRODUCT_IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox1.TabIndex = 1
        '
        'PRODUCT_NAMETextBox
        '
        Me.PRODUCT_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT NAME", True))
        Me.PRODUCT_NAMETextBox.Location = New System.Drawing.Point(131, 26)
        Me.PRODUCT_NAMETextBox.Name = "PRODUCT_NAMETextBox"
        Me.PRODUCT_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_NAMETextBox.TabIndex = 3
        '
        'CATEGORIESTextBox
        '
        Me.CATEGORIESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "CATEGORIES", True))
        Me.CATEGORIESTextBox.Location = New System.Drawing.Point(131, 52)
        Me.CATEGORIESTextBox.Name = "CATEGORIESTextBox"
        Me.CATEGORIESTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CATEGORIESTextBox.TabIndex = 5
        '
        'SIZETextBox
        '
        Me.SIZETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "SIZE", True))
        Me.SIZETextBox.Location = New System.Drawing.Point(131, 78)
        Me.SIZETextBox.Name = "SIZETextBox"
        Me.SIZETextBox.Size = New System.Drawing.Size(100, 20)
        Me.SIZETextBox.TabIndex = 7
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(131, 104)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNIT_PRICETextBox.TabIndex = 9
        '
        'STOCK_LEVELTextBox
        '
        Me.STOCK_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "STOCK LEVEL", True))
        Me.STOCK_LEVELTextBox.Location = New System.Drawing.Point(131, 130)
        Me.STOCK_LEVELTextBox.Name = "STOCK_LEVELTextBox"
        Me.STOCK_LEVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.STOCK_LEVELTextBox.TabIndex = 11
        '
        'REORDER_LEVELTextBox
        '
        Me.REORDER_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "REORDER LEVEL", True))
        Me.REORDER_LEVELTextBox.Location = New System.Drawing.Point(131, 156)
        Me.REORDER_LEVELTextBox.Name = "REORDER_LEVELTextBox"
        Me.REORDER_LEVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.REORDER_LEVELTextBox.TabIndex = 13
        '
        'MAX_LEVELTextBox
        '
        Me.MAX_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "MAX LEVEL", True))
        Me.MAX_LEVELTextBox.Location = New System.Drawing.Point(131, 182)
        Me.MAX_LEVELTextBox.Name = "MAX_LEVELTextBox"
        Me.MAX_LEVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MAX_LEVELTextBox.TabIndex = 15
        '
        'PRODUCT_DETAILSTableAdapter
        '
        Me.PRODUCT_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'PRODUCT_ORDERSTableAdapter
        '
        Me.PRODUCT_ORDERSTableAdapter.ClearBeforeFill = True
        '
        'PRODUCT_CATALOGTableAdapter
        '
        Me.PRODUCT_CATALOGTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1369, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.CUSTOMER_DETAILSBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CUSTOMER_DETAILSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CUSTOMER_DETAILSBindingNavigator.ResumeLayout(False)
        Me.CUSTOMER_DETAILSBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PRODUCT_CATALOGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_CATALOGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PRODUCT_DETAILSDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PRODUCT_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.PRODUCT_ORDERSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExist As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPassword As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents SHOPDataSet As SHOPDataSet
    Friend WithEvents CUSTOMER_DETAILSBindingSource As BindingSource
    Friend WithEvents CUSTOMER_DETAILSTableAdapter As SHOPDataSetTableAdapters.CUSTOMER_DETAILSTableAdapter
    Friend WithEvents TableAdapterManager As SHOPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CUSTOMER_DETAILSBindingNavigator As BindingNavigator
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
    Friend WithEvents CUSTOMER_DETAILSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CUSTOMER_IDTextBox As TextBox
    Friend WithEvents TITLETextBox As TextBox
    Friend WithEvents FIRSTNAMETextBox As TextBox
    Friend WithEvents LASTNAMETextBox As TextBox
    Friend WithEvents ADDRESSTextBox As TextBox
    Friend WithEvents PHONE_NUMBERTextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents CUSTOMER_DETAILSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents PRODUCT_DETAILSBindingSource As BindingSource
    Friend WithEvents PRODUCT_DETAILSTableAdapter As SHOPDataSetTableAdapters.PRODUCT_DETAILSTableAdapter
    Friend WithEvents PRODUCT_DETAILSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents ORDER_IDTextBox As TextBox
    Friend WithEvents PRODUCT_IDTextBox As TextBox
    Friend WithEvents QUANTITYTextBox As TextBox
    Friend WithEvents cmbUsername As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents PRODUCT_ORDERSBindingSource As BindingSource
    Friend WithEvents PRODUCT_ORDERSTableAdapter As SHOPDataSetTableAdapters.PRODUCT_ORDERSTableAdapter
    Friend WithEvents PRODUCT_ORDERSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents ORDER_IDTextBox1 As TextBox
    Friend WithEvents CUSTOMER_IDTextBox1 As TextBox
    Friend WithEvents DATEDateTimePicker As DateTimePicker
    Friend WithEvents DISPATCHEDCheckBox As CheckBox
    Friend WithEvents PAIDCheckBox As CheckBox
    Friend WithEvents PRODUCT_CATALOGBindingSource As BindingSource
    Friend WithEvents PRODUCT_CATALOGTableAdapter As SHOPDataSetTableAdapters.PRODUCT_CATALOGTableAdapter
    Friend WithEvents PRODUCT_IDTextBox1 As TextBox
    Friend WithEvents PRODUCT_NAMETextBox As TextBox
    Friend WithEvents CATEGORIESTextBox As TextBox
    Friend WithEvents SIZETextBox As TextBox
    Friend WithEvents UNIT_PRICETextBox As TextBox
    Friend WithEvents STOCK_LEVELTextBox As TextBox
    Friend WithEvents REORDER_LEVELTextBox As TextBox
    Friend WithEvents MAX_LEVELTextBox As TextBox
    Friend WithEvents PRODUCT_DETAILSDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents ORDER_IDTextBox2 As TextBox
    Friend WithEvents PRODUCT_IDTextBox2 As TextBox
    Friend WithEvents QUANTITYTextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents ORDER_IDTextBox3 As TextBox
    Friend WithEvents CUSTOMER_IDTextBox2 As TextBox
    Friend WithEvents DATEDateTimePicker1 As DateTimePicker
    Friend WithEvents DISPATCHEDCheckBox1 As CheckBox
    Friend WithEvents PAIDCheckBox1 As CheckBox
    Friend WithEvents PRODUCT_CATALOGDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_IDTextBox3 As TextBox
    Friend WithEvents PRODUCT_NAMETextBox1 As TextBox
    Friend WithEvents CATEGORIESTextBox1 As TextBox
    Friend WithEvents SIZETextBox1 As TextBox
    Friend WithEvents UNIT_PRICETextBox1 As TextBox
    Friend WithEvents STOCK_LEVELTextBox1 As TextBox
    Friend WithEvents REORDER_LEVELTextBox1 As TextBox
    Friend WithEvents MAX_LEVELTextBox1 As TextBox
End Class
