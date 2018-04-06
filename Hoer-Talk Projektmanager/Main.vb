Imports System.IO

Public Class Main

#Region "Variablen"
    Dim User As String
    Dim count As Integer
    Public dir As String
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Updater
        Try 'Versuchen die neueste Version vom Server abzurufen. Falls Server nicht erreichbar wird der Updater übersprungen
            Dim client As New Net.WebClient
            Dim update As String = client.DownloadString("http://scarala-design.de/projektmanager/version.txt")
            Dim Version As String = Replace(My.Application.Info.Version.ToString, ".", "")
            If update > Version Then
                Dim result = MsgBox("Es ist ein Update verfügbar." & vbNewLine & "Möchten Sie dieses Herunterladen und Installieren?", vbYesNo, "Update verfügbar")
                If result = vbYes Then
                    Process.Start(System.AppDomain.CurrentDomain.BaseDirectory & "/Updater.exe") 'Updater.exe starten, um das Update herunterzuladen und zu installieren
                    Application.Exit()
                End If
            End If
        Catch ex As Exception

        End Try

        'Checken ob datenbank existiert, wenn nicht, erstellen
        If Not System.IO.File.Exists("database.db") Then
            SQLite.SQLiteConnection.CreateFile("database.db")
            Dim connect2 As New SQLite.SQLiteConnection()
            Dim command2 As SQLite.SQLiteCommand
            connect2.ConnectionString = "Data Source=database.db;"
            connect2.Open()
            connect2.Close()
            connect2.Open()
            command2 = connect2.CreateCommand
            command2.CommandText = My.Resources.database
            Dim SQLwriter As SQLite.SQLiteDataReader = command2.ExecuteReader()
            command2.Dispose()
            connect2.Close()
        End If
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "SELECT Username,Projektordner FROM Settings"
        Dim SQLreader As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader.Read()
            User = SQLreader(0)
            dir = SQLreader(1)
        End While
        command.Dispose()

        'Datenbankupdate von Version 1.0.0.0 auf 1.0.0.1
        command = connect.CreateCommand
        command.CommandText = "PRAGMA table_info(Projekte);"
        Dim SQLreader3 As SQLite.SQLiteDataReader = command.ExecuteReader()
        Dim ctr As Integer = 0
        While SQLreader3.Read()
            If SQLreader3(1) = "Archiviert" Or SQLreader3(1) = "Logo" Then
                ctr = 1
            End If
        End While
        If ctr = 0 Then
            command = connect.CreateCommand
            command.CommandText = "ALTER TABLE 'Projekte' ADD 'Logo' TEXT;"
            command.ExecuteNonQuery()
            command.Dispose()
            command = connect.CreateCommand
            command.CommandText = "ALTER TABLE 'Projekte' ADD 'Archiviert' INT;"
            command.ExecuteNonQuery()
            command.Dispose()
            command = connect.CreateCommand
            command.CommandText = "Update 'Projekte' SET 'Archiviert' = '0';"
            command.ExecuteNonQuery()
            command.Dispose()
        End If

        'Checken, ob bereits Projekte in der Datenbank sind, wenn nicht, erstellen einer leeren Zeile im DataGridView
        command = connect.CreateCommand
        command.CommandText = "SELECT COUNT(ID) FROM Projekte WHERE Archiviert = 0"
        Dim SQLreader2 As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader2.Read()
            count = SQLreader2(0)
        End While
        command.Dispose()
        connect.Close()
        'Wenn kein Username in Datenbank Settings öffnen
        If User = "" Then
            SearchBox.Enabled = False
            ProjDetailsBtn.Enabled = False
            ProjArchivateBtn.Enabled = False
            NewProjBtn.Enabled = False
            Settings.Show()
        Else
            If Not count = 0 Then
                ListViewUpdate()
            Else
                DataGridView1.Rows.Add("", My.Resources.NoImage, "Noch keine Projekte vorhanden", "", "", "", "", "")
                SearchBox.Enabled = False
                ProjDetailsBtn.Enabled = False
                ProjArchivateBtn.Enabled = False
            End If
        End If
    End Sub

#Region "DataGridView aus Datenbank aktualisieren"
    Public Sub ListViewUpdate()
        DataGridView1.Rows.Clear()
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "SELECT ID, Projektname, Projektstart, Projekttyp, Projektstatus, MeinStatus, Deadline, Logo, Archiviert, Projektordner FROM Projekte WHERE Archiviert = 0"
        Dim SQLreader3 As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader3.Read()
            If SQLreader3.Item(8).ToString = 0 Then
                Dim DateVal As Date
                DateTime.TryParse(SQLreader3.Item(2), DateVal)
                Dim DateVal2 As Date
                DateTime.TryParse(SQLreader3.Item(6), DateVal2)
                DataGridView1.Rows.Add(SQLreader3.Item(0), My.Resources.NoImage, SQLreader3.Item(1), DateVal, SQLreader3.Item(3), SQLreader3.Item(4), SQLreader3.Item(5), DateVal2)
                If Not SQLreader3.Item(7).ToString = "NoImage" Then
                    If System.IO.File.Exists(dir & "\" & SQLreader3.Item(9) & "\Sonstiges\" & SQLreader3.Item(7)) Then
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(dir & "\" & SQLreader3.Item(9) & "\Sonstiges\" & SQLreader3.Item(7), IO.FileMode.Open, IO.FileAccess.Read)
                        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                    Else
                        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = My.Resources.NoImage
                    End If
                Else
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = My.Resources.NoImage
                End If
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Height = 40
            End If
            Dim compDate As Date
            compDate = Convert.ToDateTime(SQLreader3(6).ToString)
            compDate = compDate.AddDays(-7)
            If Date.Now > compDate And Not (SQLreader3(5) = "Takes abgeschickt" Or SQLreader3(5) = "Abgeschlossen") Then
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(7).Style.BackColor = Color.Orange
            End If
            compDate = compDate.AddDays(7)
            If Date.Now > compDate And Not (SQLreader3(5) = "Takes abgeschickt" Or SQLreader3(5) = "Abgeschlossen") Then
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(7).Style.BackColor = Color.Red
            End If
        End While
        command.Dispose()
        connect.Close()
        If DataGridView1.RowCount = 0 Then
            DataGridView1.Rows.Add("", My.Resources.NoImage, "Noch keine Projekte vorhanden", "", "", "", "", "")
            SearchBox.Enabled = False
            ProjDetailsBtn.Enabled = False
            ProjArchivateBtn.Enabled = False
        Else
            SearchBox.Enabled = True
            ProjDetailsBtn.Enabled = True
            ProjArchivateBtn.Enabled = True
        End If
    End Sub
#End Region

#Region "Buttons"
    'Neues Projekt erstellen
    Private Sub NewProjBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProjBtn.Click
        Neues_Projekt.Show()
    End Sub

    'Projektdetails anzeigen
    Private Sub ProjDetailsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjDetailsBtn.Click
        Projekt_Anzeigen.archivstate = 0
        Projekt_Anzeigen.projID = DataGridView1.CurrentRow.Cells(0).Value
        Projekt_Anzeigen.Show()
    End Sub

    'Projekt archivieren
    Private Sub ProjArchivateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjArchivateBtn.Click
        Dim pID As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "UPDATE Projekte SET Archiviert = 1 WHERE ID = " & pID
        command.ExecuteNonQuery()
        command = connect.CreateCommand
        command.CommandText = "SELECT Projektordner FROM Projekte WHERE ID=" & pID
        Dim SQLreader As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader.Read()
            Try
                My.Computer.FileSystem.MoveDirectory(dir & "\" & SQLreader(0), dir & "\Archiv\" & SQLreader(0))
            Catch Ex As Exception
            End Try
        End While
        command.Dispose()
        connect.Close() 'Schließen
        Archiv.ListViewUpdate()
        ListViewUpdate()
    End Sub

    'Archiv öffnen
    Private Sub ProjArchivOpenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjArchivOpenBtn.Click
        Archiv.Show()
    End Sub
#End Region

#Region "Projekt bei Doppelklick öffnen"
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CellMouseDoubleClick
        If Not DataGridView1.CurrentRow.Cells(2).Value = "Noch keine Projekte vorhanden" Then
            Projekt_Anzeigen.archivstate = 0
            Projekt_Anzeigen.projID = DataGridView1.CurrentRow.Cells(0).Value
            Projekt_Anzeigen.Show()
        End If
    End Sub
#End Region

#Region "Suchfunktion"
    Private Sub SearchBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SearchBox.TextChanged
        DataGridView1.Rows.Clear()
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "SELECT ID, Projektname, Projektstart, Projekttyp, Projektstatus, MeinStatus, Deadline, Logo, Archiviert, Projektordner FROM Projekte Where (Projektname Like '%" & SearchBox.Text & "%') or (Projektstart Like '%" & SearchBox.Text & "%') or (Projekttyp Like '%" & SearchBox.Text & "%') or (Projektstatus Like '%" & SearchBox.Text & "%') or (Deadline Like '%" & SearchBox.Text & "%') or (MeinStatus Like '%" & SearchBox.Text & "%')"
        Dim SQLreader3 As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader3.Read()
            If SQLreader3.Item(8) = 0 Then
                DataGridView1.Rows.Add(SQLreader3.Item(0), My.Resources.NoImage, SQLreader3.Item(1), SQLreader3.Item(2), SQLreader3.Item(3), SQLreader3.Item(4), SQLreader3.Item(5), SQLreader3.Item(6))
                If Not SQLreader3.Item(7).ToString = "NoImage" Then
                    If System.IO.File.Exists(dir & "\" & SQLreader3.Item(9) & "\Sonstiges\" & SQLreader3.Item(7)) Then
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(dir & "\" & SQLreader3.Item(9) & "\Sonstiges\" & SQLreader3.Item(7), IO.FileMode.Open, IO.FileAccess.Read)
                        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                    Else
                        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = My.Resources.NoImage
                    End If
                Else
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = My.Resources.NoImage
                End If
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Height = 40
            End If
        End While
        command.Dispose()
        connect.Close()
    End Sub
#End Region

End Class
