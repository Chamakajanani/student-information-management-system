Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_DatabaseDataSet.Student_Details' table. You can move, or remove it, as needed.
        Me.Student_DetailsTableAdapter.Fill(Me.Student_DatabaseDataSet.Student_Details)
        'TODO: This line of code loads data into the 'Student_DatabaseDataSet.Subject_Details' table. You can move, or remove it, as needed.
        Me.Subject_DetailsTableAdapter.Fill(Me.Student_DatabaseDataSet.Subject_Details)

    End Sub

    Private Sub Subject_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Subject_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Subject_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_DatabaseDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Invalid user name and password", MsgBoxStyle.OkCancel, "Message")
        ElseIf TextBox1.Text = Student_Full_NameTextBox.Text And TextBox2.Text = Student_NOTextBox.Text Then
            MsgBox("Successfully Logged in!", MsgBoxStyle.OkOnly, "Welcome" + AddressTextBox.Text)
            Form5.Show()
            Me.Hide()


        Else
            MsgBox("Invalid user name and password", MsgBoxStyle.OkCancel, "Message")

        End If
    End Sub

    Private Sub Student_DetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Student_DetailsDataGridView.CellContentClick

    End Sub
End Class