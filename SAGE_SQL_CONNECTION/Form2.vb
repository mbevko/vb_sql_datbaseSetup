Public Class Form2

    Public newConnection As String
    Public serverName As String
    Public dataBase As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        serverName = Server_NameComboBox.Text
        dataBase = NameComboBox.Text
        newConnection = $"Data Source={serverName};Initial Catalog={dataBase};Integrated Security=True"

        My.Settings("Local_Connection") = newConnection

        My.Settings.Save()
        'MessageBox.Show(newConnection)

        Form1.Show()
        Me.Hide()



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MFGCOMDataSet1.DATABASE_NAMES' table. You can move, or remove it, as needed.
        Me.DATABASE_NAMESTableAdapter.Fill(Me.MFGCOMDataSet1.DATABASE_NAMES)
        'TODO: This line of code loads data into the 'MFGCOMDataSet.SERVER_NAME' table. You can move, or remove it, as needed.
        Me.SERVER_NAMETableAdapter.Fill(Me.MFGCOMDataSet.SERVER_NAME)

    End Sub

    Private Sub Server_NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Server_NameComboBox.SelectedIndexChanged

    End Sub

End Class