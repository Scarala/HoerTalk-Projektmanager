Public Class Archiv

#Region "Variablen"
    Dim archID As Integer
#End Region

    Private Sub Archiv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListViewUpdate()
    End Sub

#Region "ListView aus Datenbank updaten"
    Public Sub ListViewUpdate()
        DataGridView1.Rows.Clear()
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "SELECT ID, Projektname, Projektstart, Archiviert, Logo, Projektordner FROM Projekte"
        Dim SQLreader3 As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader3.Read()
            If SQLreader3.Item(3).ToString = 1 Then
                Dim DateVal As Date
                DateTime.TryParse(SQLreader3.Item(2), DateVal)
                DataGridView1.Rows.Add(SQLreader3.Item(0), My.Resources.NoImage, SQLreader3.Item(1), DateVal)
                If Not SQLreader3.Item(4).ToString = "NoImage" Then
                    If System.IO.File.Exists(Main.dir & "\Archiv\" & SQLreader3.Item(5) & "\Sonstiges\" & SQLreader3.Item(4)) Then
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(Main.dir & "\Archiv\" & SQLreader3.Item(5) & "\Sonstiges\" & SQLreader3.Item(4), IO.FileMode.Open, IO.FileAccess.Read)
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
        connect.Close() 'Schließen
        If DataGridView1.RowCount = 0 Then
            DataGridView1.Rows.Add("", My.Resources.NoImage, "Noch keine Projekte vorhanden", "")
        End If
    End Sub
#End Region

#Region "Buttons"
    'Fenster schließen
    Private Sub ArchiveCloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveCloseBtn.Click
        Me.Close()
    End Sub

    'Projekt wiederherstellen
    Private Sub RecoverProjBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecoverProjBtn.Click
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "SELECT Projektordner FROM Projekte WHERE ID=" & DataGridView1.CurrentRow.Cells(0).Value
        Dim SQLreader As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader.Read()
            Try
                DataGridView1.CurrentRow.Cells(1).Value.Dispose()
                My.Computer.FileSystem.MoveDirectory(Main.dir & "\Archiv\" & SQLreader(0), Main.dir & "\" & SQLreader(0))
            Catch Ex As Exception
            End Try
        End While
        command = connect.CreateCommand
        command.CommandText = "UPDATE Projekte SET Archiviert = 0 WHERE ID = " & DataGridView1.CurrentRow.Cells(0).Value
        command.ExecuteNonQuery()
        command.Dispose()
        connect.Close() 'Schließen
        ListViewUpdate()
        Main.ListViewUpdate()
    End Sub

    'Archiviertes Projekt anzeigen
    Private Sub ArchivShowProjBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivShowProjBtn.Click
        Projekt_Anzeigen.archivstate = 1
        Projekt_Anzeigen.projID = DataGridView1.CurrentRow.Cells(0).Value
        Projekt_Anzeigen.Show()
    End Sub
#End Region

#Region "Archiv Suchfunktion"
    Private Sub ArchivSearchBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivSearchBox.TextChanged
        DataGridView1.Rows.Clear()
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "SELECT ID, Projektname, Projektstart, Archiviert, Logo, Projektordner FROM Projekte Where (Projektname Like '%" & ArchivSearchBox.Text & "%') or (Projektstart Like '%" & ArchivSearchBox.Text & "%') "
        Dim SQLreader3 As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader3.Read()
            If SQLreader3(3) = 1 Then
                DataGridView1.Rows.Add(SQLreader3.Item(0), My.Resources.NoImage, SQLreader3.Item(1), SQLreader3.Item(2))
                If Not SQLreader3.Item(4).ToString = "NoImage" Then
                    If System.IO.File.Exists(Main.dir & "\Archiv\" & SQLreader3.Item(5) & "\Sonstiges\" & SQLreader3.Item(4)) Then
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(Main.dir & "\Archiv\" & SQLreader3.Item(5) & "\Sonstiges\" & SQLreader3.Item(4), IO.FileMode.Open, IO.FileAccess.Read)
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