Public Class Form5

    Private Sub Student_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Student_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Student_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_DatabaseDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_DatabaseDataSet.Student_Details' table. You can move, or remove it, as needed.
        Me.Student_DetailsTableAdapter.Fill(Me.Student_DatabaseDataSet.Student_Details)

    End Sub

    Private Sub Search1ToolStripButton_Click(sender As Object, e As EventArgs) Handles Search1ToolStripButton.Click
        Try
            Me.Student_DetailsTableAdapter.Search1(Me.Student_DatabaseDataSet.Student_Details, Student_NOToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Search1ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Search1ToolStrip.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Hide()

    End Sub
End Class