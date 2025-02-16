Public Class Form2

    Private Sub AdminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_DatabaseDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_DatabaseDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.Student_DatabaseDataSet.Admin)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Invalid user name and password", MsgBoxStyle.OkCancel, "Message")
        ElseIf TextBox1.Text = UserNameTextBox.Text And TextBox2.Text = PasswordTextBox.Text Then
            MsgBox("Successfully Logged in!", MsgBoxStyle.OkOnly, "Welcome" + FnameTextBox.Text)
            Form4.Show()
            Me.Hide()


        Else
            MsgBox("Invalid user name and password", MsgBoxStyle.OkCancel, "Message")

        End If
    End Sub

    Private Sub AdminDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class