Public Class Form4

    Private Sub Student_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Student_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Student_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_DatabaseDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_DatabaseDataSet.Results' table. You can move, or remove it, as needed.
        Me.ResultsTableAdapter.Fill(Me.Student_DatabaseDataSet.Results)
        'TODO: This line of code loads data into the 'Student_DatabaseDataSet.Student_Details' table. You can move, or remove it, as needed.
        Me.Student_DetailsTableAdapter.Fill(Me.Student_DatabaseDataSet.Student_Details)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Validate()
        Me.Student_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_DatabaseDataSet)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Validate()
        Me.Student_DetailsBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.Student_DatabaseDataSet)
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.Student_DetailsTableAdapter.Search(Me.Student_DatabaseDataSet.Student_Details, Student_NOToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Student_NOToolStripTextBox_Click(sender As Object, e As EventArgs) Handles Student_NOToolStripTextBox.Click


    End Sub

    Private Sub Student_NOTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Student_NOTextBox1.TextChanged

    End Sub

    Private Sub SearchToolStripButton1_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton1.Click
        Try
            Me.ResultsTableAdapter.Search(Me.Student_DatabaseDataSet.Results, Student_NOToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SearchToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles SearchToolStrip1.ItemClicked

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Student_DetailsBindingNavigator.MovePreviousItem.PerformClick()

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Student_DetailsBindingNavigator.MoveNextItem.PerformClick()
    End Sub
End Class