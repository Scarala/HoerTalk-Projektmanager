Public Class Projekt_Bearbeiten

#Region "Variablen"
    Dim file As String
    Public editID As String
    Dim folder As String
#End Region

#Region "Projektdaten aus Datenbank abrufen bei FormLoad"
    Private Sub Projekt_Bearbeiten_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "Select Projektname, Projektstart, Projekttyp, Projektleiter, Beschreibung, LinkCasting, LinkProduktion, LinkStatus, Projektstatus, Kommentar, Rolle, MeinStatus, Deadline, Projektordner, Logo from 'Projekte' WHERE ID = " & editID
        Dim SQLreader As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader.Read()
            ProjNameTextBox.Text = SQLreader(0)
            ProjStartPicker.Text = SQLreader(1)
            ProjTypeSelect.Text = SQLreader(2)
            ProjLeaderTextBox.Text = SQLreader(3)
            DescriptionTextBox.Text = SQLreader(4)
            CastingLinkTextBox.Text = SQLreader(5)
            ProjRoomTextBox.Text = SQLreader(6)
            ProjStateTextBox.Text = SQLreader(7)
            ProjStateSelect.Text = SQLreader(8)
            CommentTextBox.Text = SQLreader(9)
            MyRoleTextBox.Text = SQLreader(10)
            MyStateSelect.Text = SQLreader(11)
            DeadlinePicker.Text = SQLreader(12)
            folder = SQLreader(13)
            file = SQLreader(14).ToString
            If Not file = "NoImage" Then
                If System.IO.File.Exists(Main.dir & "\" & folder & "\Sonstiges\" & file) Then
                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(Main.dir & "\" & folder & "\Sonstiges\" & SQLreader(14), IO.FileMode.Open, IO.FileAccess.Read)
                    LogoPictureBox.Image = System.Drawing.Image.FromStream(fs)
                    fs.Close()
                Else
                    LogoPictureBox.Image = My.Resources.NoImage
                End If
            Else
                LogoPictureBox.Image = My.Resources.NoImage
            End If
        End While
        command.Dispose()
        connect.Close()
    End Sub
#End Region

#Region "Buttons"
    Private Sub CancleBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancleBtn.Click
        Projekt_Anzeigen.projID = editID
        editID = ""
        Projekt_Anzeigen.Show()
        Main.ListViewUpdate()
        Me.Close()
    End Sub

    Private Sub UpdateProjBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateProjBtn.Click
        If ProjNameTextBox.Text = "" Then
            MsgBox("Projektname ist ein Pflichtfeld", MsgBoxStyle.OkOnly)
        Else
            Dim connect As New SQLite.SQLiteConnection()
            Dim command As SQLite.SQLiteCommand
            connect.ConnectionString = "Data Source=database.db;"
            connect.Open()
            connect.Close()
            connect.Open()
            command = connect.CreateCommand
            command.CommandText = "UPDATE Projekte SET Projektname = '" & ProjNameTextBox.Text & "', Projektstart = '" & ProjStartPicker.Value.Date & "', Projekttyp = '" & ProjTypeSelect.Text & "', Projektleiter = '" & ProjLeaderTextBox.Text & "', Beschreibung = '" & DescriptionTextBox.Text & "', LinkCasting = '" & CastingLinkTextBox.Text & "', LinkProduktion = '" & ProjRoomTextBox.Text & "', LinkStatus = '" & ProjStateTextBox.Text & "', Projektstatus = '" & ProjStateSelect.Text & "', Kommentar = '" & CommentTextBox.Text & "', Rolle = '" & MyRoleTextBox.Text & "', MeinStatus = '" & MyStateSelect.Text & "', Deadline = '" & DeadlinePicker.Value.Date & "', Logo = '" & file & "' WHERE ID = " & editID
            command.ExecuteNonQuery()
            command.Dispose()
            connect.Close() 'Schließen
            Main.ListViewUpdate()
            Projekt_Anzeigen.projID = editID
            editID = ""
            Projekt_Anzeigen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub SelectLogoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectLogoBtn.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName
            Dim SourceFile, DestinationFile As String
            SourceFile = file   ' Define source file name.
            DestinationFile = Main.dir & "\" & folder & "\Sonstiges\" & OpenFileDialog1.SafeFileName ' Define target file name.
            FileCopy(SourceFile, DestinationFile)   ' Copy source to target.
            file = OpenFileDialog1.SafeFileName
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(Main.dir & "\" & folder & "\Sonstiges\" & file, IO.FileMode.Open, IO.FileAccess.Read)
            LogoPictureBox.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If
    End Sub
#End Region
End Class