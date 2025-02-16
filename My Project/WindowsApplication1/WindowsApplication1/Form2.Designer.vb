<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim NoLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim FnameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Student_DatabaseDataSet = New WindowsApplication1.Student_DatabaseDataSet()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.AdminTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.AdminBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AdminBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.AdminDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        NoLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminBindingNavigator.SuspendLayout()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoLabel
        '
        NoLabel.AutoSize = True
        NoLabel.Location = New System.Drawing.Point(921, 10)
        NoLabel.Name = "NoLabel"
        NoLabel.Size = New System.Drawing.Size(30, 17)
        NoLabel.TabIndex = 8
        NoLabel.Text = "No:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(921, 38)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(83, 17)
        UserNameLabel.TabIndex = 10
        UserNameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(921, 66)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 17)
        PasswordLabel.TabIndex = 12
        PasswordLabel.Text = "Password:"
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.Location = New System.Drawing.Point(921, 94)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(55, 17)
        FnameLabel.TabIndex = 14
        FnameLabel.Text = "Fname:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(483, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(676, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 55)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(478, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(478, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(651, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 34)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(651, 153)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 34)
        Me.TextBox2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(97, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 325)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Student_DatabaseDataSet
        '
        Me.Student_DatabaseDataSet.DataSetName = "Student_DatabaseDataSet"
        Me.Student_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.Student_DatabaseDataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NewTableAdapter = Nothing
        Me.TableAdapterManager.Results_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Student_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Subject_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AdminBindingNavigator
        '
        Me.AdminBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdminBindingNavigator.BindingSource = Me.AdminBindingSource
        Me.AdminBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdminBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdminBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdminBindingNavigatorSaveItem})
        Me.AdminBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdminBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdminBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdminBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdminBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdminBindingNavigator.Name = "AdminBindingNavigator"
        Me.AdminBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdminBindingNavigator.Size = New System.Drawing.Size(1044, 27)
        Me.AdminBindingNavigator.TabIndex = 7
        Me.AdminBindingNavigator.Text = "BindingNavigator1"
        Me.AdminBindingNavigator.Visible = False
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
        'AdminBindingNavigatorSaveItem
        '
        Me.AdminBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdminBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdminBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdminBindingNavigatorSaveItem.Name = "AdminBindingNavigatorSaveItem"
        Me.AdminBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.AdminBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NoTextBox
        '
        Me.NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "No", True))
        Me.NoTextBox.Location = New System.Drawing.Point(931, 10)
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.Size = New System.Drawing.Size(89, 22)
        Me.NoTextBox.TabIndex = 9
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(931, 35)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(89, 22)
        Me.UserNameTextBox.TabIndex = 11
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(931, 63)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(89, 22)
        Me.PasswordTextBox.TabIndex = 13
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(931, 91)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(89, 22)
        Me.FnameTextBox.TabIndex = 15
        '
        'AdminDataGridView
        '
        Me.AdminDataGridView.AutoGenerateColumns = False
        Me.AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AdminDataGridView.DataSource = Me.AdminBindingSource
        Me.AdminDataGridView.Location = New System.Drawing.Point(905, 10)
        Me.AdminDataGridView.Name = "AdminDataGridView"
        Me.AdminDataGridView.RowTemplate.Height = 24
        Me.AdminDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.AdminDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
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
        Me.GroupBox1.Location = New System.Drawing.Point(47, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 409)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1044, 618)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AdminBindingNavigator)
        Me.Controls.Add(Me.AdminDataGridView)
        Me.Controls.Add(Me.NoTextBox)
        Me.Controls.Add(NoLabel)
        Me.Controls.Add(Me.FnameTextBox)
        Me.Controls.Add(FnameLabel)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminBindingNavigator.ResumeLayout(False)
        Me.AdminBindingNavigator.PerformLayout()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Student_DatabaseDataSet As WindowsApplication1.Student_DatabaseDataSet
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminTableAdapter As WindowsApplication1.Student_DatabaseDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Student_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdminBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AdminBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdminDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
