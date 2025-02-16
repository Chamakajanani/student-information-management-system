<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim Student_NoLabel As System.Windows.Forms.Label
        Dim Subject_NOLabel As System.Windows.Forms.Label
        Dim Academic_YearLabel As System.Windows.Forms.Label
        Dim Subject_StreamLabel As System.Windows.Forms.Label
        Dim _1St_SemesterLabel As System.Windows.Forms.Label
        Dim _2nd_SemesterLabel As System.Windows.Forms.Label
        Dim _3rd_SemesterLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Student_DatabaseDataSet = New WindowsApplication1.Student_DatabaseDataSet()
        Me.Results_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Results_DetailsTableAdapter = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.Results_DetailsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Results_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Results_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Academic_YearTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_StreamTextBox = New System.Windows.Forms.TextBox()
        Me._1St_SemesterTextBox = New System.Windows.Forms.TextBox()
        Me._2nd_SemesterTextBox = New System.Windows.Forms.TextBox()
        Me._3rd_SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.SEARCHToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Student_NoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Student_NoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SEARCHToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Student_NoLabel = New System.Windows.Forms.Label()
        Subject_NOLabel = New System.Windows.Forms.Label()
        Academic_YearLabel = New System.Windows.Forms.Label()
        Subject_StreamLabel = New System.Windows.Forms.Label()
        _1St_SemesterLabel = New System.Windows.Forms.Label()
        _2nd_SemesterLabel = New System.Windows.Forms.Label()
        _3rd_SemesterLabel = New System.Windows.Forms.Label()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Results_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Results_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Results_DetailsBindingNavigator.SuspendLayout()
        Me.SEARCHToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student_NoLabel
        '
        Student_NoLabel.AutoSize = True
        Student_NoLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Student_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_NoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Student_NoLabel.Location = New System.Drawing.Point(387, 185)
        Student_NoLabel.Name = "Student_NoLabel"
        Student_NoLabel.Size = New System.Drawing.Size(165, 32)
        Student_NoLabel.TabIndex = 1
        Student_NoLabel.Text = "Student No:"
        '
        'Subject_NOLabel
        '
        Subject_NOLabel.AutoSize = True
        Subject_NOLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Subject_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject_NOLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Subject_NOLabel.Location = New System.Drawing.Point(384, 229)
        Subject_NOLabel.Name = "Subject_NOLabel"
        Subject_NOLabel.Size = New System.Drawing.Size(168, 32)
        Subject_NOLabel.TabIndex = 3
        Subject_NOLabel.Text = "Subject NO:"
        '
        'Academic_YearLabel
        '
        Academic_YearLabel.AutoSize = True
        Academic_YearLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Academic_YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Academic_YearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Academic_YearLabel.Location = New System.Drawing.Point(384, 273)
        Academic_YearLabel.Name = "Academic_YearLabel"
        Academic_YearLabel.Size = New System.Drawing.Size(215, 32)
        Academic_YearLabel.TabIndex = 5
        Academic_YearLabel.Text = "Academic Year:"
        AddHandler Academic_YearLabel.Click, AddressOf Me.Academic_YearLabel_Click
        '
        'Subject_StreamLabel
        '
        Subject_StreamLabel.AutoSize = True
        Subject_StreamLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Subject_StreamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Subject_StreamLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Subject_StreamLabel.Location = New System.Drawing.Point(381, 317)
        Subject_StreamLabel.Name = "Subject_StreamLabel"
        Subject_StreamLabel.Size = New System.Drawing.Size(217, 32)
        Subject_StreamLabel.TabIndex = 7
        Subject_StreamLabel.Text = "Subject Stream:"
        '
        '_1St_SemesterLabel
        '
        _1St_SemesterLabel.AutoSize = True
        _1St_SemesterLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        _1St_SemesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _1St_SemesterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        _1St_SemesterLabel.Location = New System.Drawing.Point(381, 361)
        _1St_SemesterLabel.Name = "_1St_SemesterLabel"
        _1St_SemesterLabel.Size = New System.Drawing.Size(194, 32)
        _1St_SemesterLabel.TabIndex = 9
        _1St_SemesterLabel.Text = "1St Semester:"
        AddHandler _1St_SemesterLabel.Click, AddressOf Me._1St_SemesterLabel_Click
        '
        '_2nd_SemesterLabel
        '
        _2nd_SemesterLabel.AutoSize = True
        _2nd_SemesterLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        _2nd_SemesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _2nd_SemesterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        _2nd_SemesterLabel.Location = New System.Drawing.Point(379, 405)
        _2nd_SemesterLabel.Name = "_2nd_SemesterLabel"
        _2nd_SemesterLabel.Size = New System.Drawing.Size(199, 32)
        _2nd_SemesterLabel.TabIndex = 11
        _2nd_SemesterLabel.Text = "2nd Semester:"
        '
        '_3rd_SemesterLabel
        '
        _3rd_SemesterLabel.AutoSize = True
        _3rd_SemesterLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        _3rd_SemesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _3rd_SemesterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        _3rd_SemesterLabel.Location = New System.Drawing.Point(381, 449)
        _3rd_SemesterLabel.Name = "_3rd_SemesterLabel"
        _3rd_SemesterLabel.Size = New System.Drawing.Size(192, 32)
        _3rd_SemesterLabel.TabIndex = 13
        _3rd_SemesterLabel.Text = "3rd Semester:"
        '
        'Student_DatabaseDataSet
        '
        Me.Student_DatabaseDataSet.DataSetName = "Student_DatabaseDataSet"
        Me.Student_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Results_DetailsBindingSource
        '
        Me.Results_DetailsBindingSource.DataMember = "Results Details"
        Me.Results_DetailsBindingSource.DataSource = Me.Student_DatabaseDataSet
        '
        'Results_DetailsTableAdapter
        '
        Me.Results_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NewTableAdapter = Nothing
        Me.TableAdapterManager.Results_DetailsTableAdapter = Me.Results_DetailsTableAdapter
        Me.TableAdapterManager.Student_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Subject_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Results_DetailsBindingNavigator
        '
        Me.Results_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Results_DetailsBindingNavigator.BindingSource = Me.Results_DetailsBindingSource
        Me.Results_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Results_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Results_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Results_DetailsBindingNavigatorSaveItem})
        Me.Results_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Results_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Results_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Results_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Results_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Results_DetailsBindingNavigator.Name = "Results_DetailsBindingNavigator"
        Me.Results_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Results_DetailsBindingNavigator.Size = New System.Drawing.Size(1330, 27)
        Me.Results_DetailsBindingNavigator.TabIndex = 0
        Me.Results_DetailsBindingNavigator.Text = "BindingNavigator1"
        Me.Results_DetailsBindingNavigator.Visible = False
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
        'Results_DetailsBindingNavigatorSaveItem
        '
        Me.Results_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Results_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Results_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Results_DetailsBindingNavigatorSaveItem.Name = "Results_DetailsBindingNavigatorSaveItem"
        Me.Results_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Results_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_NoTextBox
        '
        Me.Student_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Results_DetailsBindingSource, "Student No", True))
        Me.Student_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_NoTextBox.Location = New System.Drawing.Point(633, 179)
        Me.Student_NoTextBox.Name = "Student_NoTextBox"
        Me.Student_NoTextBox.Size = New System.Drawing.Size(440, 38)
        Me.Student_NoTextBox.TabIndex = 2
        '
        'Subject_NOTextBox
        '
        Me.Subject_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Results_DetailsBindingSource, "Subject NO", True))
        Me.Subject_NOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject_NOTextBox.Location = New System.Drawing.Point(633, 223)
        Me.Subject_NOTextBox.Name = "Subject_NOTextBox"
        Me.Subject_NOTextBox.Size = New System.Drawing.Size(440, 38)
        Me.Subject_NOTextBox.TabIndex = 4
        '
        'Academic_YearTextBox
        '
        Me.Academic_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Results_DetailsBindingSource, "Academic Year", True))
        Me.Academic_YearTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Academic_YearTextBox.Location = New System.Drawing.Point(633, 267)
        Me.Academic_YearTextBox.Name = "Academic_YearTextBox"
        Me.Academic_YearTextBox.Size = New System.Drawing.Size(440, 38)
        Me.Academic_YearTextBox.TabIndex = 6
        '
        'Subject_StreamTextBox
        '
        Me.Subject_StreamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Results_DetailsBindingSource, "Subject Stream", True))
        Me.Subject_StreamTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject_StreamTextBox.Location = New System.Drawing.Point(633, 311)
        Me.Subject_StreamTextBox.Name = "Subject_StreamTextBox"
        Me.Subject_StreamTextBox.Size = New System.Drawing.Size(440, 38)
        Me.Subject_StreamTextBox.TabIndex = 8
        '
        '_1St_SemesterTextBox
        '
        Me._1St_SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Results_DetailsBindingSource, "1St Semester", True))
        Me._1St_SemesterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._1St_SemesterTextBox.Location = New System.Drawing.Point(633, 355)
        Me._1St_SemesterTextBox.Name = "_1St_SemesterTextBox"
        Me._1St_SemesterTextBox.Size = New System.Drawing.Size(440, 38)
        Me._1St_SemesterTextBox.TabIndex = 10
        '
        '_2nd_SemesterTextBox
        '
        Me._2nd_SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Results_DetailsBindingSource, "2nd Semester", True))
        Me._2nd_SemesterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._2nd_SemesterTextBox.Location = New System.Drawing.Point(633, 399)
        Me._2nd_SemesterTextBox.Name = "_2nd_SemesterTextBox"
        Me._2nd_SemesterTextBox.Size = New System.Drawing.Size(440, 38)
        Me._2nd_SemesterTextBox.TabIndex = 12
        '
        '_3rd_SemesterTextBox
        '
        Me._3rd_SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Results_DetailsBindingSource, "3rd Semester", True))
        Me._3rd_SemesterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._3rd_SemesterTextBox.Location = New System.Drawing.Point(633, 443)
        Me._3rd_SemesterTextBox.Name = "_3rd_SemesterTextBox"
        Me._3rd_SemesterTextBox.Size = New System.Drawing.Size(440, 38)
        Me._3rd_SemesterTextBox.TabIndex = 14
        '
        'SEARCHToolStrip
        '
        Me.SEARCHToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SEARCHToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Student_NoToolStripLabel, Me.Student_NoToolStripTextBox, Me.SEARCHToolStripButton})
        Me.SEARCHToolStrip.Location = New System.Drawing.Point(350, 124)
        Me.SEARCHToolStrip.Name = "SEARCHToolStrip"
        Me.SEARCHToolStrip.Size = New System.Drawing.Size(271, 27)
        Me.SEARCHToolStrip.TabIndex = 15
        Me.SEARCHToolStrip.Text = "SEARCHToolStrip"
        '
        'Student_NoToolStripLabel
        '
        Me.Student_NoToolStripLabel.Name = "Student_NoToolStripLabel"
        Me.Student_NoToolStripLabel.Size = New System.Drawing.Size(89, 24)
        Me.Student_NoToolStripLabel.Text = "Student_No:"
        '
        'Student_NoToolStripTextBox
        '
        Me.Student_NoToolStripTextBox.Name = "Student_NoToolStripTextBox"
        Me.Student_NoToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'SEARCHToolStripButton
        '
        Me.SEARCHToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SEARCHToolStripButton.Name = "SEARCHToolStripButton"
        Me.SEARCHToolStripButton.Size = New System.Drawing.Size(68, 24)
        Me.SEARCHToolStripButton.Text = "SEARCH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Buxton Sketch", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(630, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 59)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Exam Results"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(655, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 38)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1330, 610)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SEARCHToolStrip)
        Me.Controls.Add(Student_NoLabel)
        Me.Controls.Add(Me.Student_NoTextBox)
        Me.Controls.Add(Subject_NOLabel)
        Me.Controls.Add(Me.Subject_NOTextBox)
        Me.Controls.Add(Academic_YearLabel)
        Me.Controls.Add(Me.Academic_YearTextBox)
        Me.Controls.Add(Subject_StreamLabel)
        Me.Controls.Add(Me.Subject_StreamTextBox)
        Me.Controls.Add(_1St_SemesterLabel)
        Me.Controls.Add(Me._1St_SemesterTextBox)
        Me.Controls.Add(_2nd_SemesterLabel)
        Me.Controls.Add(Me._2nd_SemesterTextBox)
        Me.Controls.Add(_3rd_SemesterLabel)
        Me.Controls.Add(Me._3rd_SemesterTextBox)
        Me.Controls.Add(Me.Results_DetailsBindingNavigator)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Results_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Results_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Results_DetailsBindingNavigator.ResumeLayout(False)
        Me.Results_DetailsBindingNavigator.PerformLayout()
        Me.SEARCHToolStrip.ResumeLayout(False)
        Me.SEARCHToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Student_DatabaseDataSet As WindowsApplication1.Student_DatabaseDataSet
    Friend WithEvents Results_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Results_DetailsTableAdapter As WindowsApplication1.Student_DatabaseDataSetTableAdapters.Results_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Results_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Results_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Student_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Academic_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_StreamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _1St_SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _2nd_SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _3rd_SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SEARCHToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Student_NoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Student_NoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SEARCHToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
