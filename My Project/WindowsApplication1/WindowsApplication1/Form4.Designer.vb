<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Student_NOLabel As System.Windows.Forms.Label
        Dim Student_Full_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim NICLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim Telephone_NOLabel As System.Windows.Forms.Label
        Dim Student_NOLabel1 As System.Windows.Forms.Label
        Dim Student_Full_NameLabel1 As System.Windows.Forms.Label
        Dim Subject_StreamLabel As System.Windows.Forms.Label
        Dim Subject_NOLabel As System.Windows.Forms.Label
        Dim Subject_NameLabel As System.Windows.Forms.Label
        Dim Academic_YearLabel As System.Windows.Forms.Label
        Dim _1St_SemesterLabel As System.Windows.Forms.Label
        Dim _2nd_SemesterLabel As System.Windows.Forms.Label
        Dim _3rd_SemesterLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Student_DatabaseDataSet = New WindowsApplication1.Student_DatabaseDataSet()
        Me.Student_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_DetailsTableAdapter = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.Student_DetailsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Student_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Student_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Student_Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NICTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NOTextBox = New System.Windows.Forms.TextBox()
        Me.ResultsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultsTableAdapter = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.ResultsTableAdapter()
        Me.Student_NOTextBox1 = New System.Windows.Forms.TextBox()
        Me.Student_Full_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Subject_StreamTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Academic_YearTextBox = New System.Windows.Forms.TextBox()
        Me._1St_SemesterTextBox = New System.Windows.Forms.TextBox()
        Me._2nd_SemesterTextBox = New System.Windows.Forms.TextBox()
        Me._3rd_SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Student_NOToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Student_NOToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Student_NOToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Student_NOToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResultsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Student_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Student_NOLabel = New System.Windows.Forms.Label()
        Student_Full_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NICLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        Telephone_NOLabel = New System.Windows.Forms.Label()
        Student_NOLabel1 = New System.Windows.Forms.Label()
        Student_Full_NameLabel1 = New System.Windows.Forms.Label()
        Subject_StreamLabel = New System.Windows.Forms.Label()
        Subject_NOLabel = New System.Windows.Forms.Label()
        Subject_NameLabel = New System.Windows.Forms.Label()
        Academic_YearLabel = New System.Windows.Forms.Label()
        _1St_SemesterLabel = New System.Windows.Forms.Label()
        _2nd_SemesterLabel = New System.Windows.Forms.Label()
        _3rd_SemesterLabel = New System.Windows.Forms.Label()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Student_DetailsBindingNavigator.SuspendLayout()
        CType(Me.ResultsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SearchToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SearchToolStrip.SuspendLayout()
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Student_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_NOLabel
        '
        Student_NOLabel.AutoSize = True
        Student_NOLabel.Location = New System.Drawing.Point(88, 97)
        Student_NOLabel.Name = "Student_NOLabel"
        Student_NOLabel.Size = New System.Drawing.Size(86, 17)
        Student_NOLabel.TabIndex = 1
        Student_NOLabel.Text = "Student NO:"
        '
        'Student_Full_NameLabel
        '
        Student_Full_NameLabel.AutoSize = True
        Student_Full_NameLabel.Location = New System.Drawing.Point(88, 125)
        Student_Full_NameLabel.Name = "Student_Full_NameLabel"
        Student_Full_NameLabel.Size = New System.Drawing.Size(128, 17)
        Student_Full_NameLabel.TabIndex = 3
        Student_Full_NameLabel.Text = "Student Full Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(88, 153)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'NICLabel
        '
        NICLabel.AutoSize = True
        NICLabel.Location = New System.Drawing.Point(88, 181)
        NICLabel.Name = "NICLabel"
        NICLabel.Size = New System.Drawing.Size(34, 17)
        NICLabel.TabIndex = 7
        NICLabel.Text = "NIC:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Location = New System.Drawing.Point(88, 209)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(94, 17)
        Date_Of_BirthLabel.TabIndex = 9
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'Telephone_NOLabel
        '
        Telephone_NOLabel.AutoSize = True
        Telephone_NOLabel.Location = New System.Drawing.Point(88, 237)
        Telephone_NOLabel.Name = "Telephone_NOLabel"
        Telephone_NOLabel.Size = New System.Drawing.Size(105, 17)
        Telephone_NOLabel.TabIndex = 11
        Telephone_NOLabel.Text = "Telephone NO:"
        '
        'Student_NOLabel1
        '
        Student_NOLabel1.AutoSize = True
        Student_NOLabel1.Location = New System.Drawing.Point(82, 67)
        Student_NOLabel1.Name = "Student_NOLabel1"
        Student_NOLabel1.Size = New System.Drawing.Size(86, 17)
        Student_NOLabel1.TabIndex = 13
        Student_NOLabel1.Text = "Student NO:"
        '
        'Student_Full_NameLabel1
        '
        Student_Full_NameLabel1.AutoSize = True
        Student_Full_NameLabel1.Location = New System.Drawing.Point(82, 95)
        Student_Full_NameLabel1.Name = "Student_Full_NameLabel1"
        Student_Full_NameLabel1.Size = New System.Drawing.Size(128, 17)
        Student_Full_NameLabel1.TabIndex = 15
        Student_Full_NameLabel1.Text = "Student Full Name:"
        '
        'Subject_StreamLabel
        '
        Subject_StreamLabel.AutoSize = True
        Subject_StreamLabel.Location = New System.Drawing.Point(82, 123)
        Subject_StreamLabel.Name = "Subject_StreamLabel"
        Subject_StreamLabel.Size = New System.Drawing.Size(108, 17)
        Subject_StreamLabel.TabIndex = 17
        Subject_StreamLabel.Text = "Subject Stream:"
        '
        'Subject_NOLabel
        '
        Subject_NOLabel.AutoSize = True
        Subject_NOLabel.Location = New System.Drawing.Point(82, 151)
        Subject_NOLabel.Name = "Subject_NOLabel"
        Subject_NOLabel.Size = New System.Drawing.Size(84, 17)
        Subject_NOLabel.TabIndex = 19
        Subject_NOLabel.Text = "Subject NO:"
        '
        'Subject_NameLabel
        '
        Subject_NameLabel.AutoSize = True
        Subject_NameLabel.Location = New System.Drawing.Point(82, 179)
        Subject_NameLabel.Name = "Subject_NameLabel"
        Subject_NameLabel.Size = New System.Drawing.Size(100, 17)
        Subject_NameLabel.TabIndex = 21
        Subject_NameLabel.Text = "Subject Name:"
        '
        'Academic_YearLabel
        '
        Academic_YearLabel.AutoSize = True
        Academic_YearLabel.Location = New System.Drawing.Point(82, 207)
        Academic_YearLabel.Name = "Academic_YearLabel"
        Academic_YearLabel.Size = New System.Drawing.Size(107, 17)
        Academic_YearLabel.TabIndex = 23
        Academic_YearLabel.Text = "Academic Year:"
        '
        '_1St_SemesterLabel
        '
        _1St_SemesterLabel.AutoSize = True
        _1St_SemesterLabel.Location = New System.Drawing.Point(82, 235)
        _1St_SemesterLabel.Name = "_1St_SemesterLabel"
        _1St_SemesterLabel.Size = New System.Drawing.Size(97, 17)
        _1St_SemesterLabel.TabIndex = 25
        _1St_SemesterLabel.Text = "1St Semester:"
        '
        '_2nd_SemesterLabel
        '
        _2nd_SemesterLabel.AutoSize = True
        _2nd_SemesterLabel.Location = New System.Drawing.Point(82, 263)
        _2nd_SemesterLabel.Name = "_2nd_SemesterLabel"
        _2nd_SemesterLabel.Size = New System.Drawing.Size(100, 17)
        _2nd_SemesterLabel.TabIndex = 27
        _2nd_SemesterLabel.Text = "2nd Semester:"
        '
        '_3rd_SemesterLabel
        '
        _3rd_SemesterLabel.AutoSize = True
        _3rd_SemesterLabel.Location = New System.Drawing.Point(82, 291)
        _3rd_SemesterLabel.Name = "_3rd_SemesterLabel"
        _3rd_SemesterLabel.Size = New System.Drawing.Size(97, 17)
        _3rd_SemesterLabel.TabIndex = 29
        _3rd_SemesterLabel.Text = "3rd Semester:"
        '
        'Student_DatabaseDataSet
        '
        Me.Student_DatabaseDataSet.DataSetName = "Student_DatabaseDataSet"
        Me.Student_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_DetailsBindingSource
        '
        Me.Student_DetailsBindingSource.DataMember = "Student Details"
        Me.Student_DetailsBindingSource.DataSource = Me.Student_DatabaseDataSet
        '
        'Student_DetailsTableAdapter
        '
        Me.Student_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NewTableAdapter = Nothing
        Me.TableAdapterManager.Results_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Student_DetailsTableAdapter = Me.Student_DetailsTableAdapter
        Me.TableAdapterManager.Subject_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Student_DetailsBindingNavigator
        '
        Me.Student_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Student_DetailsBindingNavigator.BindingSource = Me.Student_DetailsBindingSource
        Me.Student_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Student_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Student_DetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Student_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Student_DetailsBindingNavigatorSaveItem})
        Me.Student_DetailsBindingNavigator.Location = New System.Drawing.Point(41, 134)
        Me.Student_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Student_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Student_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Student_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Student_DetailsBindingNavigator.Name = "Student_DetailsBindingNavigator"
        Me.Student_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Student_DetailsBindingNavigator.Size = New System.Drawing.Size(288, 27)
        Me.Student_DetailsBindingNavigator.TabIndex = 0
        Me.Student_DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Student_DetailsBindingNavigatorSaveItem
        '
        Me.Student_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Student_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Student_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Student_DetailsBindingNavigatorSaveItem.Name = "Student_DetailsBindingNavigatorSaveItem"
        Me.Student_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Student_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_NOTextBox
        '
        Me.Student_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Student NO", True))
        Me.Student_NOTextBox.Location = New System.Drawing.Point(222, 94)
        Me.Student_NOTextBox.Name = "Student_NOTextBox"
        Me.Student_NOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Student_NOTextBox.TabIndex = 2
        '
        'Student_Full_NameTextBox
        '
        Me.Student_Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Student Full Name", True))
        Me.Student_Full_NameTextBox.Location = New System.Drawing.Point(222, 122)
        Me.Student_Full_NameTextBox.Name = "Student_Full_NameTextBox"
        Me.Student_Full_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Student_Full_NameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(222, 150)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 6
        '
        'NICTextBox
        '
        Me.NICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "NIC", True))
        Me.NICTextBox.Location = New System.Drawing.Point(222, 178)
        Me.NICTextBox.Name = "NICTextBox"
        Me.NICTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NICTextBox.TabIndex = 8
        '
        'Date_Of_BirthTextBox
        '
        Me.Date_Of_BirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Date Of Birth", True))
        Me.Date_Of_BirthTextBox.Location = New System.Drawing.Point(222, 206)
        Me.Date_Of_BirthTextBox.Name = "Date_Of_BirthTextBox"
        Me.Date_Of_BirthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Date_Of_BirthTextBox.TabIndex = 10
        '
        'Telephone_NOTextBox
        '
        Me.Telephone_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Telephone NO", True))
        Me.Telephone_NOTextBox.Location = New System.Drawing.Point(222, 234)
        Me.Telephone_NOTextBox.Name = "Telephone_NOTextBox"
        Me.Telephone_NOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Telephone_NOTextBox.TabIndex = 12
        '
        'ResultsBindingSource
        '
        Me.ResultsBindingSource.DataMember = "Results"
        Me.ResultsBindingSource.DataSource = Me.Student_DatabaseDataSet
        '
        'ResultsTableAdapter
        '
        Me.ResultsTableAdapter.ClearBeforeFill = True
        '
        'Student_NOTextBox1
        '
        Me.Student_NOTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "Student NO", True))
        Me.Student_NOTextBox1.Location = New System.Drawing.Point(223, 64)
        Me.Student_NOTextBox1.Name = "Student_NOTextBox1"
        Me.Student_NOTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Student_NOTextBox1.TabIndex = 14
        '
        'Student_Full_NameTextBox1
        '
        Me.Student_Full_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "Student Full Name", True))
        Me.Student_Full_NameTextBox1.Location = New System.Drawing.Point(223, 92)
        Me.Student_Full_NameTextBox1.Name = "Student_Full_NameTextBox1"
        Me.Student_Full_NameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Student_Full_NameTextBox1.TabIndex = 16
        '
        'Subject_StreamTextBox
        '
        Me.Subject_StreamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "Subject Stream", True))
        Me.Subject_StreamTextBox.Location = New System.Drawing.Point(223, 120)
        Me.Subject_StreamTextBox.Name = "Subject_StreamTextBox"
        Me.Subject_StreamTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject_StreamTextBox.TabIndex = 18
        '
        'Subject_NOTextBox
        '
        Me.Subject_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "Subject NO", True))
        Me.Subject_NOTextBox.Location = New System.Drawing.Point(223, 148)
        Me.Subject_NOTextBox.Name = "Subject_NOTextBox"
        Me.Subject_NOTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject_NOTextBox.TabIndex = 20
        '
        'Subject_NameTextBox
        '
        Me.Subject_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "Subject Name", True))
        Me.Subject_NameTextBox.Location = New System.Drawing.Point(223, 176)
        Me.Subject_NameTextBox.Name = "Subject_NameTextBox"
        Me.Subject_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Subject_NameTextBox.TabIndex = 22
        '
        'Academic_YearTextBox
        '
        Me.Academic_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "Academic Year", True))
        Me.Academic_YearTextBox.Location = New System.Drawing.Point(223, 204)
        Me.Academic_YearTextBox.Name = "Academic_YearTextBox"
        Me.Academic_YearTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Academic_YearTextBox.TabIndex = 24
        '
        '_1St_SemesterTextBox
        '
        Me._1St_SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "1St Semester", True))
        Me._1St_SemesterTextBox.Location = New System.Drawing.Point(223, 232)
        Me._1St_SemesterTextBox.Name = "_1St_SemesterTextBox"
        Me._1St_SemesterTextBox.Size = New System.Drawing.Size(100, 22)
        Me._1St_SemesterTextBox.TabIndex = 26
        '
        '_2nd_SemesterTextBox
        '
        Me._2nd_SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "2nd Semester", True))
        Me._2nd_SemesterTextBox.Location = New System.Drawing.Point(223, 260)
        Me._2nd_SemesterTextBox.Name = "_2nd_SemesterTextBox"
        Me._2nd_SemesterTextBox.Size = New System.Drawing.Size(100, 22)
        Me._2nd_SemesterTextBox.TabIndex = 28
        '
        '_3rd_SemesterTextBox
        '
        Me._3rd_SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ResultsBindingSource, "3rd Semester", True))
        Me._3rd_SemesterTextBox.Location = New System.Drawing.Point(223, 288)
        Me._3rd_SemesterTextBox.Name = "_3rd_SemesterTextBox"
        Me._3rd_SemesterTextBox.Size = New System.Drawing.Size(100, 22)
        Me._3rd_SemesterTextBox.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.SearchToolStrip1)
        Me.GroupBox1.Controls.Add(Student_NOLabel1)
        Me.GroupBox1.Controls.Add(Me.Student_NOTextBox1)
        Me.GroupBox1.Controls.Add(Student_Full_NameLabel1)
        Me.GroupBox1.Controls.Add(Me.Student_Full_NameTextBox1)
        Me.GroupBox1.Controls.Add(Subject_StreamLabel)
        Me.GroupBox1.Controls.Add(Me.Subject_StreamTextBox)
        Me.GroupBox1.Controls.Add(Subject_NOLabel)
        Me.GroupBox1.Controls.Add(Me.Subject_NOTextBox)
        Me.GroupBox1.Controls.Add(Subject_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Subject_NameTextBox)
        Me.GroupBox1.Controls.Add(Academic_YearLabel)
        Me.GroupBox1.Controls.Add(Me.Academic_YearTextBox)
        Me.GroupBox1.Controls.Add(_1St_SemesterLabel)
        Me.GroupBox1.Controls.Add(Me._1St_SemesterTextBox)
        Me.GroupBox1.Controls.Add(_2nd_SemesterLabel)
        Me.GroupBox1.Controls.Add(Me._2nd_SemesterTextBox)
        Me.GroupBox1.Controls.Add(_3rd_SemesterLabel)
        Me.GroupBox1.Controls.Add(Me._3rd_SemesterTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 590)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 325)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result Info"
        '
        'SearchToolStrip1
        '
        Me.SearchToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.SearchToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Student_NOToolStripLabel1, Me.Student_NOToolStripTextBox1, Me.SearchToolStripButton1})
        Me.SearchToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.SearchToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.SearchToolStrip1.Name = "SearchToolStrip1"
        Me.SearchToolStrip1.Size = New System.Drawing.Size(262, 27)
        Me.SearchToolStrip1.TabIndex = 0
        Me.SearchToolStrip1.Text = "SearchToolStrip1"
        '
        'Student_NOToolStripLabel1
        '
        Me.Student_NOToolStripLabel1.Name = "Student_NOToolStripLabel1"
        Me.Student_NOToolStripLabel1.Size = New System.Drawing.Size(91, 24)
        Me.Student_NOToolStripLabel1.Text = "Student_NO:"
        '
        'Student_NOToolStripTextBox1
        '
        Me.Student_NOToolStripTextBox1.Name = "Student_NOToolStripTextBox1"
        Me.Student_NOToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'SearchToolStripButton1
        '
        Me.SearchToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton1.Name = "SearchToolStripButton1"
        Me.SearchToolStripButton1.Size = New System.Drawing.Size(57, 24)
        Me.SearchToolStripButton1.Text = "Search"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchToolStrip)
        Me.GroupBox2.Controls.Add(Student_NOLabel)
        Me.GroupBox2.Controls.Add(Me.Student_NOTextBox)
        Me.GroupBox2.Controls.Add(Student_Full_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Student_Full_NameTextBox)
        Me.GroupBox2.Controls.Add(AddressLabel)
        Me.GroupBox2.Controls.Add(Me.AddressTextBox)
        Me.GroupBox2.Controls.Add(NICLabel)
        Me.GroupBox2.Controls.Add(Me.NICTextBox)
        Me.GroupBox2.Controls.Add(Date_Of_BirthLabel)
        Me.GroupBox2.Controls.Add(Me.Date_Of_BirthTextBox)
        Me.GroupBox2.Controls.Add(Telephone_NOLabel)
        Me.GroupBox2.Controls.Add(Me.Telephone_NOTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 330)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Info"
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Student_NOToolStripLabel, Me.Student_NOToolStripTextBox, Me.SearchToolStripButton})
        Me.SearchToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.SearchToolStrip.Location = New System.Drawing.Point(3, 34)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(251, 27)
        Me.SearchToolStrip.TabIndex = 44
        Me.SearchToolStrip.Text = "SearchToolStrip"
        '
        'Student_NOToolStripLabel
        '
        Me.Student_NOToolStripLabel.Name = "Student_NOToolStripLabel"
        Me.Student_NOToolStripLabel.Size = New System.Drawing.Size(91, 20)
        Me.Student_NOToolStripLabel.Text = "Student_NO:"
        '
        'Student_NOToolStripTextBox
        '
        Me.Student_NOToolStripTextBox.Name = "Student_NOToolStripTextBox"
        Me.Student_NOToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(57, 24)
        Me.SearchToolStripButton.Text = "Search"
        '
        'ResultsDataGridView
        '
        Me.ResultsDataGridView.AutoGenerateColumns = False
        Me.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ResultsDataGridView.DataSource = Me.ResultsBindingSource
        Me.ResultsDataGridView.Location = New System.Drawing.Point(570, 575)
        Me.ResultsDataGridView.Name = "ResultsDataGridView"
        Me.ResultsDataGridView.RowTemplate.Height = 24
        Me.ResultsDataGridView.Size = New System.Drawing.Size(1288, 302)
        Me.ResultsDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student NO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Student Full Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Student Full Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Subject Stream"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Subject Stream"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Subject NO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subject NO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Subject Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subject Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Academic Year"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Academic Year"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "1St Semester"
        Me.DataGridViewTextBoxColumn7.HeaderText = "1St Semester"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "2nd Semester"
        Me.DataGridViewTextBoxColumn8.HeaderText = "2nd Semester"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "3rd Semester"
        Me.DataGridViewTextBoxColumn9.HeaderText = "3rd Semester"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(61, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 48)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(167, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 48)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(61, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 48)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(167, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 48)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(111, 152)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 48)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Location = New System.Drawing.Point(1470, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 220)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(412, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(722, 45)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Student Information Management"
        '
        'Student_DetailsDataGridView
        '
        Me.Student_DetailsDataGridView.AutoGenerateColumns = False
        Me.Student_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Student_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Student_DetailsDataGridView.DataSource = Me.Student_DetailsBindingSource
        Me.Student_DetailsDataGridView.Location = New System.Drawing.Point(489, 154)
        Me.Student_DetailsDataGridView.Name = "Student_DetailsDataGridView"
        Me.Student_DetailsDataGridView.RowTemplate.Height = 24
        Me.Student_DetailsDataGridView.Size = New System.Drawing.Size(760, 362)
        Me.Student_DetailsDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Student NO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Student NO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Student Full Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Student Full Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NIC"
        Me.DataGridViewTextBoxColumn13.HeaderText = "NIC"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Date Of Birth"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Date Of Birth"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Telephone NO"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Telephone NO"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1906, 1040)
        Me.Controls.Add(Me.Student_DetailsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ResultsDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Student_DetailsBindingNavigator)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Student_DetailsBindingNavigator.ResumeLayout(False)
        Me.Student_DetailsBindingNavigator.PerformLayout()
        CType(Me.ResultsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SearchToolStrip1.ResumeLayout(False)
        Me.SearchToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Student_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Student_DatabaseDataSet As WindowsApplication1.Student_DatabaseDataSet
    Friend WithEvents Student_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_DetailsTableAdapter As WindowsApplication1.Student_DatabaseDataSetTableAdapters.Student_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Student_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Student_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Student_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NICTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_BirthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResultsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResultsTableAdapter As WindowsApplication1.Student_DatabaseDataSetTableAdapters.ResultsTableAdapter
    Friend WithEvents Student_NOTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Student_Full_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Subject_StreamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Academic_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _1St_SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _2nd_SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _3rd_SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ResultsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Student_NOToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Student_NOToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Student_NOToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Student_NOToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Student_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
