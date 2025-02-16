<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Student_DatabaseDataSet = New WindowsApplication1.Student_DatabaseDataSet()
        Me.Subject_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Subject_DetailsTableAdapter = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.Subject_DetailsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Student_DetailsTableAdapter = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.Student_DetailsTableAdapter()
        Me.Subject_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Subject_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Student_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Student_Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NICTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NOTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Student_NOLabel = New System.Windows.Forms.Label()
        Student_Full_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NICLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        Telephone_NOLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Subject_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Subject_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Subject_DetailsBindingNavigator.SuspendLayout()
        CType(Me.Student_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student_NOLabel
        '
        Student_NOLabel.AutoSize = True
        Student_NOLabel.Location = New System.Drawing.Point(12, 9)
        Student_NOLabel.Name = "Student_NOLabel"
        Student_NOLabel.Size = New System.Drawing.Size(78, 16)
        Student_NOLabel.TabIndex = 13
        Student_NOLabel.Text = "Student NO:"
        '
        'Student_Full_NameLabel
        '
        Student_Full_NameLabel.AutoSize = True
        Student_Full_NameLabel.Location = New System.Drawing.Point(-7, 48)
        Student_Full_NameLabel.Name = "Student_Full_NameLabel"
        Student_Full_NameLabel.Size = New System.Drawing.Size(119, 16)
        Student_Full_NameLabel.TabIndex = 15
        Student_Full_NameLabel.Text = "Student Full Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 65)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(61, 16)
        AddressLabel.TabIndex = 17
        AddressLabel.Text = "Address:"
        '
        'NICLabel
        '
        NICLabel.AutoSize = True
        NICLabel.Location = New System.Drawing.Point(12, 11)
        NICLabel.Name = "NICLabel"
        NICLabel.Size = New System.Drawing.Size(32, 16)
        NICLabel.TabIndex = 19
        NICLabel.Text = "NIC:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Location = New System.Drawing.Point(12, 39)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(84, 16)
        Date_Of_BirthLabel.TabIndex = 21
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'Telephone_NOLabel
        '
        Telephone_NOLabel.AutoSize = True
        Telephone_NOLabel.Location = New System.Drawing.Point(12, 67)
        Telephone_NOLabel.Name = "Telephone_NOLabel"
        Telephone_NOLabel.Size = New System.Drawing.Size(99, 16)
        Telephone_NOLabel.TabIndex = 23
        Telephone_NOLabel.Text = "Telephone NO:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(531, 152)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 34)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(531, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 34)
        Me.TextBox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(322, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Student No      :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(322, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Student Name :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(531, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 55)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(348, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 55)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(86, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 215)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Student_DatabaseDataSet
        '
        Me.Student_DatabaseDataSet.DataSetName = "Student_DatabaseDataSet"
        Me.Student_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Subject_DetailsBindingSource
        '
        Me.Subject_DetailsBindingSource.DataMember = "Subject Details"
        Me.Subject_DetailsBindingSource.DataSource = Me.Student_DatabaseDataSet
        '
        'Subject_DetailsTableAdapter
        '
        Me.Subject_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NewTableAdapter = Nothing
        Me.TableAdapterManager.Results_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Student_DetailsTableAdapter = Me.Student_DetailsTableAdapter
        Me.TableAdapterManager.Subject_DetailsTableAdapter = Me.Subject_DetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Student_DetailsTableAdapter
        '
        Me.Student_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Subject_DetailsBindingNavigator
        '
        Me.Subject_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Subject_DetailsBindingNavigator.BindingSource = Me.Subject_DetailsBindingSource
        Me.Subject_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Subject_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Subject_DetailsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Subject_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Subject_DetailsBindingNavigatorSaveItem})
        Me.Subject_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Subject_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Subject_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Subject_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Subject_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Subject_DetailsBindingNavigator.Name = "Subject_DetailsBindingNavigator"
        Me.Subject_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Subject_DetailsBindingNavigator.Size = New System.Drawing.Size(906, 27)
        Me.Subject_DetailsBindingNavigator.TabIndex = 13
        Me.Subject_DetailsBindingNavigator.Text = "BindingNavigator1"
        Me.Subject_DetailsBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Subject_DetailsBindingNavigatorSaveItem
        '
        Me.Subject_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Subject_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Subject_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Subject_DetailsBindingNavigatorSaveItem.Name = "Subject_DetailsBindingNavigatorSaveItem"
        Me.Subject_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Subject_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_DetailsBindingSource
        '
        Me.Student_DetailsBindingSource.DataMember = "Student Details"
        Me.Student_DetailsBindingSource.DataSource = Me.Student_DatabaseDataSet
        '
        'Student_DetailsDataGridView
        '
        Me.Student_DetailsDataGridView.AutoGenerateColumns = False
        Me.Student_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Student_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Student_DetailsDataGridView.DataSource = Me.Student_DetailsBindingSource
        Me.Student_DetailsDataGridView.Location = New System.Drawing.Point(207, 16)
        Me.Student_DetailsDataGridView.Name = "Student_DetailsDataGridView"
        Me.Student_DetailsDataGridView.RowHeadersWidth = 51
        Me.Student_DetailsDataGridView.RowTemplate.Height = 24
        Me.Student_DetailsDataGridView.Size = New System.Drawing.Size(55, 10)
        Me.Student_DetailsDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student NO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student NO"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Student Full Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Student Full Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NIC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NIC"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date Of Birth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date Of Birth"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telephone NO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone NO"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Student_NOTextBox
        '
        Me.Student_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Student NO", True))
        Me.Student_NOTextBox.Location = New System.Drawing.Point(146, 6)
        Me.Student_NOTextBox.Name = "Student_NOTextBox"
        Me.Student_NOTextBox.Size = New System.Drawing.Size(10, 22)
        Me.Student_NOTextBox.TabIndex = 14
        '
        'Student_Full_NameTextBox
        '
        Me.Student_Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Student Full Name", True))
        Me.Student_Full_NameTextBox.Location = New System.Drawing.Point(146, 34)
        Me.Student_Full_NameTextBox.Name = "Student_Full_NameTextBox"
        Me.Student_Full_NameTextBox.Size = New System.Drawing.Size(10, 22)
        Me.Student_Full_NameTextBox.TabIndex = 16
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(146, 62)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(10, 22)
        Me.AddressTextBox.TabIndex = 18
        '
        'NICTextBox
        '
        Me.NICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "NIC", True))
        Me.NICTextBox.Location = New System.Drawing.Point(112, 3)
        Me.NICTextBox.Name = "NICTextBox"
        Me.NICTextBox.Size = New System.Drawing.Size(10, 22)
        Me.NICTextBox.TabIndex = 20
        '
        'Date_Of_BirthTextBox
        '
        Me.Date_Of_BirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Date Of Birth", True))
        Me.Date_Of_BirthTextBox.Location = New System.Drawing.Point(112, 34)
        Me.Date_Of_BirthTextBox.Name = "Date_Of_BirthTextBox"
        Me.Date_Of_BirthTextBox.Size = New System.Drawing.Size(10, 22)
        Me.Date_Of_BirthTextBox.TabIndex = 22
        '
        'Telephone_NOTextBox
        '
        Me.Telephone_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Telephone NO", True))
        Me.Telephone_NOTextBox.Location = New System.Drawing.Point(112, 62)
        Me.Telephone_NOTextBox.Name = "Telephone_NOTextBox"
        Me.Telephone_NOTextBox.Size = New System.Drawing.Size(10, 22)
        Me.Telephone_NOTextBox.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 492)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(906, 594)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Student_DetailsDataGridView)
        Me.Controls.Add(Student_NOLabel)
        Me.Controls.Add(Me.Student_NOTextBox)
        Me.Controls.Add(Me.Telephone_NOTextBox)
        Me.Controls.Add(Student_Full_NameLabel)
        Me.Controls.Add(Telephone_NOLabel)
        Me.Controls.Add(Me.Student_Full_NameTextBox)
        Me.Controls.Add(Me.Date_Of_BirthTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Date_Of_BirthLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NICTextBox)
        Me.Controls.Add(NICLabel)
        Me.Controls.Add(Me.Subject_DetailsBindingNavigator)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Subject_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Subject_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Subject_DetailsBindingNavigator.ResumeLayout(False)
        Me.Subject_DetailsBindingNavigator.PerformLayout()
        CType(Me.Student_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Student_DatabaseDataSet As WindowsApplication1.Student_DatabaseDataSet
    Friend WithEvents Subject_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Subject_DetailsTableAdapter As WindowsApplication1.Student_DatabaseDataSetTableAdapters.Subject_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Subject_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Subject_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Student_DetailsTableAdapter As WindowsApplication1.Student_DatabaseDataSetTableAdapters.Student_DetailsTableAdapter
    Friend WithEvents Student_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Student_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NICTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_BirthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
