<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
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
        Me.Search1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Student_NOToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Student_NOToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Search1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Student_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_DatabaseDataSet = New WindowsApplication1.Student_DatabaseDataSet()
        Me.Student_DetailsTableAdapter = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.Student_DetailsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager()
        Student_NOLabel = New System.Windows.Forms.Label()
        Student_Full_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NICLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        Telephone_NOLabel = New System.Windows.Forms.Label()
        CType(Me.Student_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Student_DetailsBindingNavigator.SuspendLayout()
        Me.Search1ToolStrip.SuspendLayout()
        CType(Me.Student_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_NOLabel
        '
        Student_NOLabel.AutoSize = True
        Student_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_NOLabel.Location = New System.Drawing.Point(185, 200)
        Student_NOLabel.Name = "Student_NOLabel"
        Student_NOLabel.Size = New System.Drawing.Size(171, 32)
        Student_NOLabel.TabIndex = 1
        Student_NOLabel.Text = "Student NO:"
        '
        'Student_Full_NameLabel
        '
        Student_Full_NameLabel.AutoSize = True
        Student_Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_Full_NameLabel.Location = New System.Drawing.Point(185, 246)
        Student_Full_NameLabel.Name = "Student_Full_NameLabel"
        Student_Full_NameLabel.Size = New System.Drawing.Size(258, 32)
        Student_Full_NameLabel.TabIndex = 3
        Student_Full_NameLabel.Text = "Student Full Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(185, 297)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(127, 32)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'NICLabel
        '
        NICLabel.AutoSize = True
        NICLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NICLabel.Location = New System.Drawing.Point(185, 350)
        NICLabel.Name = "NICLabel"
        NICLabel.Size = New System.Drawing.Size(70, 32)
        NICLabel.TabIndex = 7
        NICLabel.Text = "NIC:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_BirthLabel.Location = New System.Drawing.Point(185, 403)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(186, 32)
        Date_Of_BirthLabel.TabIndex = 9
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'Telephone_NOLabel
        '
        Telephone_NOLabel.AutoSize = True
        Telephone_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone_NOLabel.Location = New System.Drawing.Point(185, 452)
        Telephone_NOLabel.Name = "Telephone_NOLabel"
        Telephone_NOLabel.Size = New System.Drawing.Size(208, 32)
        Telephone_NOLabel.TabIndex = 11
        Telephone_NOLabel.Text = "Telephone NO:"
        '
        'Student_DetailsBindingNavigator
        '
        Me.Student_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Student_DetailsBindingNavigator.BindingSource = Me.Student_DetailsBindingSource
        Me.Student_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Student_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Student_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Student_DetailsBindingNavigatorSaveItem})
        Me.Student_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Student_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Student_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Student_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Student_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Student_DetailsBindingNavigator.Name = "Student_DetailsBindingNavigator"
        Me.Student_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Student_DetailsBindingNavigator.Size = New System.Drawing.Size(1357, 27)
        Me.Student_DetailsBindingNavigator.TabIndex = 0
        Me.Student_DetailsBindingNavigator.Text = "BindingNavigator1"
        Me.Student_DetailsBindingNavigator.Visible = False
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
        Me.Student_NOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_NOTextBox.Location = New System.Drawing.Point(491, 197)
        Me.Student_NOTextBox.Name = "Student_NOTextBox"
        Me.Student_NOTextBox.Size = New System.Drawing.Size(590, 38)
        Me.Student_NOTextBox.TabIndex = 2
        '
        'Student_Full_NameTextBox
        '
        Me.Student_Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Student Full Name", True))
        Me.Student_Full_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_Full_NameTextBox.Location = New System.Drawing.Point(491, 243)
        Me.Student_Full_NameTextBox.Name = "Student_Full_NameTextBox"
        Me.Student_Full_NameTextBox.Size = New System.Drawing.Size(590, 38)
        Me.Student_Full_NameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(491, 294)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(590, 38)
        Me.AddressTextBox.TabIndex = 6
        '
        'NICTextBox
        '
        Me.NICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "NIC", True))
        Me.NICTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NICTextBox.Location = New System.Drawing.Point(491, 347)
        Me.NICTextBox.Name = "NICTextBox"
        Me.NICTextBox.Size = New System.Drawing.Size(590, 38)
        Me.NICTextBox.TabIndex = 8
        '
        'Date_Of_BirthTextBox
        '
        Me.Date_Of_BirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Date Of Birth", True))
        Me.Date_Of_BirthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Of_BirthTextBox.Location = New System.Drawing.Point(491, 400)
        Me.Date_Of_BirthTextBox.Name = "Date_Of_BirthTextBox"
        Me.Date_Of_BirthTextBox.Size = New System.Drawing.Size(590, 38)
        Me.Date_Of_BirthTextBox.TabIndex = 10
        '
        'Telephone_NOTextBox
        '
        Me.Telephone_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DetailsBindingSource, "Telephone NO", True))
        Me.Telephone_NOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone_NOTextBox.Location = New System.Drawing.Point(491, 449)
        Me.Telephone_NOTextBox.Name = "Telephone_NOTextBox"
        Me.Telephone_NOTextBox.Size = New System.Drawing.Size(590, 38)
        Me.Telephone_NOTextBox.TabIndex = 12
        '
        'Search1ToolStrip
        '
        Me.Search1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Search1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Student_NOToolStripLabel, Me.Student_NOToolStripTextBox, Me.Search1ToolStripButton})
        Me.Search1ToolStrip.Location = New System.Drawing.Point(191, 145)
        Me.Search1ToolStrip.Name = "Search1ToolStrip"
        Me.Search1ToolStrip.Size = New System.Drawing.Size(270, 27)
        Me.Search1ToolStrip.TabIndex = 13
        Me.Search1ToolStrip.Text = "Search1ToolStrip"
        '
        'Student_NOToolStripLabel
        '
        Me.Student_NOToolStripLabel.Name = "Student_NOToolStripLabel"
        Me.Student_NOToolStripLabel.Size = New System.Drawing.Size(91, 24)
        Me.Student_NOToolStripLabel.Text = "Student_NO:"
        '
        'Student_NOToolStripTextBox
        '
        Me.Student_NOToolStripTextBox.Name = "Student_NOToolStripTextBox"
        Me.Student_NOToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'Search1ToolStripButton
        '
        Me.Search1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Search1ToolStripButton.Name = "Search1ToolStripButton"
        Me.Search1ToolStripButton.Size = New System.Drawing.Size(65, 24)
        Me.Search1ToolStripButton.Text = "Search1"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(499, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(315, 71)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Exam Results"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Broadway", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 55)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Student Data"
        '
        'Student_DetailsBindingSource
        '
        Me.Student_DetailsBindingSource.DataMember = "Student Details"
        Me.Student_DetailsBindingSource.DataSource = Me.Student_DatabaseDataSet
        '
        'Student_DatabaseDataSet
        '
        Me.Student_DatabaseDataSet.DataSetName = "Student_DatabaseDataSet"
        Me.Student_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1357, 657)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Search1ToolStrip)
        Me.Controls.Add(Student_NOLabel)
        Me.Controls.Add(Me.Student_NOTextBox)
        Me.Controls.Add(Student_Full_NameLabel)
        Me.Controls.Add(Me.Student_Full_NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NICLabel)
        Me.Controls.Add(Me.NICTextBox)
        Me.Controls.Add(Date_Of_BirthLabel)
        Me.Controls.Add(Me.Date_Of_BirthTextBox)
        Me.Controls.Add(Telephone_NOLabel)
        Me.Controls.Add(Me.Telephone_NOTextBox)
        Me.Controls.Add(Me.Student_DetailsBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.Student_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Student_DetailsBindingNavigator.ResumeLayout(False)
        Me.Student_DetailsBindingNavigator.PerformLayout()
        Me.Search1ToolStrip.ResumeLayout(False)
        Me.Search1ToolStrip.PerformLayout()
        CType(Me.Student_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Search1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Student_NOToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Student_NOToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Search1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
