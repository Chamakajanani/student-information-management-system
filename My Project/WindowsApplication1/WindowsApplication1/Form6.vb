Public Class Form6

    Private Sub Results_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Results_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Results_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_DatabaseDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_DatabaseDataSet.Results_Details' table. You can move, or remove it, as needed.
        Me.Results_DetailsTableAdapter.Fill(Me.Student_DatabaseDataSet.Results_Details)

    End Sub

    Private Sub _1St_SemesterLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub _2nd_SemesterTextBox_TextChanged(sender As Object, e As EventArgs) Handles _2nd_SemesterTextBox.TextChanged

    End Sub

    Private Sub Subject_StreamTextBox_TextChanged(sender As Object, e As EventArgs) Handles Subject_StreamTextBox.TextChanged

    End Sub

    Private Sub Academic_YearLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SEARCHToolStripButton_Click(sender As Object, e As EventArgs) Handles SEARCHToolStripButton.Click
        Try
            Me.Results_DetailsTableAdapter.SEARCH(Me.Student_DatabaseDataSet.Results_Details, Student_NoToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()

    End Sub
End Class