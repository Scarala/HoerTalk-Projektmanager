Public Class Projekt_Anzeigen

#Region "Variablen"
    Public archivstate As Integer
    Public projID As String
    Dim folder As String
    Dim casting As String
    Dim prodroom As String
    Dim prodstatus As String
#End Region

#Region "Buttons"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProjBtn.Click
        Projekt_Bearbeiten.editID = projID
        Projekt_Bearbeiten.Show()
        projID = ""
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormCloseBtn.Click
        projID = ""
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProjPathBtn.Click
        If archivstate = 0 Then
            Process.Start("explorer.exe", String.Format("/n, /e, {0}", Main.dir & "\" & folder))
        ElseIf archivstate = 1 Then
            Process.Start("explorer.exe", String.Format("/n, /e, {0}", Main.dir & "\Archiv\" & folder))
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkToCastingBtn.Click
        If Not casting = "" Then
            Process.Start(casting)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkToProjBtn.Click
        If Not prodroom = "" Then
            Process.Start(prodroom)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkToProjStateBtn.Click
        If Not prodstatus = "" Then
            Process.Start(prodstatus)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelProjBtn.Click
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        Dim delID As Integer = projID
        If MsgBox("Wollen Sie das Projekt wirklich löschen?" & vbNewLine & "ALLE PROJEKTDATEN WERDEN GELÖSCHT!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                If archivstate = 0 Then
                    LogoBox.Image = My.Resources.NoImage
                    For i As Integer = 0 To Main.DataGridView1.Rows.Count - 1
                        If Main.DataGridView1.Rows(i).Cells(0).Value.ToString = delID Then
                            Main.DataGridView1.Rows(i).Cells(1).Value = My.Resources.NoImage
                        End If
                    Next
                    MsgBox(Main.dir & "\" & folder)
                    My.Computer.FileSystem.DeleteDirectory(Main.dir & "\" & folder, FileIO.DeleteDirectoryOption.DeleteAllContents)
                ElseIf archivstate = 1 Then
                    LogoBox.Image = My.Resources.NoImage
                    For i As Integer = 0 To Archiv.DataGridView1.Rows.Count - 1
                        If Archiv.DataGridView1.Rows(i).Cells(0).Value.ToString = delID Then
                            Archiv.DataGridView1.Rows(i).Cells(1).Value = My.Resources.NoImage
                        End If
                    Next
                    My.Computer.FileSystem.DeleteDirectory(Main.dir & "\Archiv\" & folder, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            Catch Ex As Exception
            End Try

            connect.Open()
            connect.Close()
            connect.Open()
            command = connect.CreateCommand
            command.CommandText = "DELETE from 'Projekte' WHERE ID = " & delID
            Dim SQLreader As SQLite.SQLiteDataReader = command.ExecuteReader()
            command.Dispose()
            connect.Close() 'Schließen
            Me.Close()
            Archiv.ListViewUpdate()
            Main.ListViewUpdate()
        End If
    End Sub
#End Region

    Private Sub Projekt_Anzeigen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Checken ob archiviertes Projekt
        If archivstate = 1 Then
            EditProjBtn.Visible = False 'Archivierte Projekte können nicht editiert werden
            Label2.Visible = True 'Archiviert-Label anzeigen
        Else
            EditProjBtn.Visible = True
            Label2.Visible = False
        End If
        'Check ende
        Dim connect As New SQLite.SQLiteConnection()
        Dim command As SQLite.SQLiteCommand
        connect.ConnectionString = "Data Source=database.db;"
        connect.Open()
        connect.Close()
        connect.Open()
        command = connect.CreateCommand
        command.CommandText = "SELECT * FROM Projekte WHERE ID=" & projID
        Dim SQLreader As SQLite.SQLiteDataReader = command.ExecuteReader()
        While SQLreader.Read()
            Label15.Text = SQLreader.Item(1)
            Label16.Text = SQLreader.Item(3)
            Label17.Text = SQLreader.Item(14)
            Label18.Text = SQLreader.Item(2)
            Label19.Text = SQLreader.Item(8)
            Label20.Text = SQLreader.Item(12)
            Label21.Text = SQLreader.Item(11)
            Label22.Text = SQLreader.Item(13)
            casting = SQLreader.Item(5)
            prodroom = SQLreader.Item(6)
            prodstatus = SQLreader.Item(7)
            folder = SQLreader.Item(9)
            DecriptionRichTextBox.Text = SQLreader.Item(4)
            CommentRichTextBox.Text = SQLreader.Item(10)
            If Not SQLreader.Item(15).ToString = "NoImage" Then
                If archivstate = 0 Then
                    If System.IO.File.Exists(Main.dir & "\" & folder & "\Sonstiges\" & SQLreader.Item(15)) Then
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(Main.dir & "\" & folder & "\Sonstiges\" & SQLreader.Item(15), IO.FileMode.Open, IO.FileAccess.Read)
                        LogoBox.Image = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                    Else
                        LogoBox.Image = My.Resources.NoImage
                    End If
                ElseIf archivstate = 1 Then
                    If System.IO.File.Exists(Main.dir & "\Archiv\" & folder & "\Sonstiges\" & SQLreader.Item(15)) Then
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(Main.dir & "\Archiv\" & folder & "\Sonstiges\" & SQLreader.Item(15), IO.FileMode.Open, IO.FileAccess.Read)
                        LogoBox.Image = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                    Else
                        LogoBox.Image = My.Resources.NoImage
                    End If
                End If

            Else
                LogoBox.Image = My.Resources.NoImage
            End If
        End While
        ' Linkbuttons deaktivieren wenn kein Link eingetragen
        If casting = "" Then
            LinkToCastingBtn.Enabled = False
        End If
        If prodroom = "" Then
            LinkToProjBtn.Enabled = False
        End If
        If prodstatus = "" Then
            LinkToProjStateBtn.Enabled = False
        End If
        'ende
        command.Dispose()
        connect.Close()
    End Sub

#Region "Links in der Beschreibungs- und Kommentar-RichTextBox klickbar machen"
    Private Sub CommentRichTextBox_LinkClicked(sender As Object, e As System.Windows.Forms.LinkClickedEventArgs) Handles CommentRichTextBox.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub DecriptionRichTextBox_LinkClicked(sender As Object, e As System.Windows.Forms.LinkClickedEventArgs) Handles DecriptionRichTextBox.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub
#End Region

End Class