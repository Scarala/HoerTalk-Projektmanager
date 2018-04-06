Public Class Neues_Projekt

    'Abbrechen Button
    Private Sub CancleBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancleBtn.Click
        Me.Close()
    End Sub

    'Projekt erstellen Button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateProjBtn.Click
        If ProjFolderTextBox.Text = "" Then
            MsgBox("Speicherordner-Name ist ein Pflichtfeld", MsgBoxStyle.OkOnly)
        ElseIf ProjNameTextBox.Text = "" Then
            MsgBox("Projektname ist ein Pflichtfeld", MsgBoxStyle.OkOnly)
        ElseIf IO.Directory.Exists(Main.dir & "\" & ProjFolderTextBox.Text) Then
            MsgBox("Speicherordner-Name existiert bereits", MsgBoxStyle.OkOnly)
        Else
            Dim foldername As String = ProjFolderTextBox.Text.Replace("\", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "").Replace("<", "").Replace(">", "").Replace("|", "")
            Try
                IO.Directory.CreateDirectory(Main.dir & "\" & foldername)
                IO.Directory.CreateDirectory(Main.dir & "\" & foldername & "\Probetakes")
                IO.Directory.CreateDirectory(Main.dir & "\" & foldername & "\Takes")
                IO.Directory.CreateDirectory(Main.dir & "\" & foldername & "\Scripte")
                IO.Directory.CreateDirectory(Main.dir & "\" & foldername & "\Sonstiges")
            Catch ex As Exception
                MsgBox("Projektordner konnten nicht im Pfad '" & Main.dir & "' erstellt werden.")
            End Try
            Dim connect As New SQLite.SQLiteConnection()
            Dim command As SQLite.SQLiteCommand
            connect.ConnectionString = "Data Source=database.db;"
            connect.Open()
            connect.Close()
            connect.Open()
            command = connect.CreateCommand

            command.CommandText = "Insert into Projekte ('Projektname', 'Projektstart', 'Projekttyp', 'Projektleiter', 'Beschreibung', 'LinkCasting', 'LinkProduktion', 'LinkStatus', 'Projektstatus', 'Projektordner', 'Kommentar', 'Rolle', 'MeinStatus', 'Deadline', 'Logo', 'Archiviert') Values('" & ProjNameTextBox.Text & "' , '" & ProjStartTimePicker.Value.Date & "' , '" & ProjTypeSelect.Text & "' , '" & ProjLeaderTextBox.Text & "' , '" & DescriptionTextBox.Text & "' , '" & CastingLinkTextBox.Text & "' , '" & ProjRoomLinkTextBox.Text & "' , '" & ProjStateLinkTextBox.Text & "' , '" & ProjStateSelect.Text & "' , '" & foldername & "' , '" & CommentTextBox.Text & "' , '" & MyRoleTextBox.Text & "' , '" & MyStateSelect.Text & "' , '" & DeadlinePicker.Value.Date & "' ,'NoImage','0')"
            command.ExecuteNonQuery()
            command.Dispose()
            connect.Close()

            Me.Close()
            Main.ListViewUpdate()
        End If
    End Sub

End Class