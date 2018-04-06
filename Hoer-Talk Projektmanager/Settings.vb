Public Class Settings

#Region "Variablen"
    Dim Username As String
    Dim dirpath As String
#End Region

#Region "Buttons"
    Private Sub setpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetPathBtn.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathTextBox.Text = FolderBrowserDialog1.SelectedPath
            dirpath = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If NameTextBox.Text = "" Then
            MsgBox("Bitte Benutzernamen eingeben", MsgBoxStyle.OkOnly)
        ElseIf dirpath = "" Then
            MsgBox("Bitte Projektspeicherpfad wählen", MsgBoxStyle.OkOnly)
        Else
            Try
                IO.Directory.CreateDirectory(dirpath & "\Archiv")
            Catch ex As Exception
                MsgBox("Der Archivordner konnte nicht erstellt werden.")
            End Try
            Dim connect As New SQLite.SQLiteConnection()
            Dim command As SQLite.SQLiteCommand
            connect.ConnectionString = "Data Source=database.db;"
            connect.Open()
            connect.Close()
            connect.Open()
            command = connect.CreateCommand
            command.CommandText = "Insert into Settings (Username, Projektordner) Values('" & NameTextBox.Text & "' , '" & dirpath & "')"
            command.ExecuteNonQuery()
            command.Dispose()
            connect.Close()
            Main.Visible = True
            Main.dir = dirpath
            Main.NewProjBtn.Enabled = True
            Main.ListViewUpdate()
            Me.Close()
        End If
    End Sub
#End Region

#Region "Form bei Aufrufen in den Vordergrund holen"
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Visible = False
        Me.TopMost = True
    End Sub
#End Region

End Class