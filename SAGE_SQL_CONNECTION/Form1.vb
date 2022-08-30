Public Class Form1
    Private Sub OEINVHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        'Me.Validate()
        'Me.OEINVHBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.SAMINCDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAMINCDataSet.OEINVH' table. You can move, or remove it, as needed.
        'My.Settings("Local_Connection") = Form2.newConnection

        'Form2.Hide()
        ToolStripLabel1.Text = Form2.dataBase
        Me.OEINVHTableAdapter.Fill(Me.SAMINCDataSet.OEINVH)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Application.Restart()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Me.TableAdapterManager.UpdateAll(Me.SAMINCDataSet)
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub
End Class


