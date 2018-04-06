Imports System.IO
Imports System.IO.Compression

Public Class Updater
    Dim url As String = "http://scarala-design.de/projektmanager/Update.zip"
    Public WithEvents wc As New Net.WebClient
    Dim Version As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(System.AppDomain.CurrentDomain.BaseDirectory & "Hörspiel Projektmanager.exe")
        Version = Replace(myFileVersionInfo.FileVersion, ".", "")
        Try
            Dim client As New Net.WebClient
            Dim update As String = client.DownloadString("http://scarala-design.de/projektmanager/version.txt")
            If update > Version Then
                wc.DownloadFileAsync(New Uri(url), ".\Update.zip")
            Else
                If MsgBox("Kein Update zu installieren!" & vbNewLine & "Programm starten?", MsgBoxStyle.YesNo, "Kein Update") = vbYes Then
                    Process.Start(System.AppDomain.CurrentDomain.BaseDirectory & "Hörspiel Projektmanager.exe")
                    Application.Exit()
                Else
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            MsgBox("Keine Verbindung zum Server möglich")
        End Try
    End Sub

    Private Sub wc_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        Dim startPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Dim zipPath As String = System.AppDomain.CurrentDomain.BaseDirectory & "\Update.zip"
        Dim extractPath As String = System.AppDomain.CurrentDomain.BaseDirectory

        File.Delete(System.AppDomain.CurrentDomain.BaseDirectory & "\Hörspiel Projektmanager.exe")

        ZipFile.ExtractToDirectory(zipPath, extractPath, System.Text.Encoding.GetEncoding(850))

        File.Delete(System.AppDomain.CurrentDomain.BaseDirectory & "\Update.zip")

        If MsgBox("Update erfolgreich installiert!" & vbNewLine & "Programm starten?", MsgBoxStyle.YesNo, "Erfolgreich!") = vbYes Then
            Process.Start(System.AppDomain.CurrentDomain.BaseDirectory & "Hörspiel Projektmanager.exe")
            Application.Exit()
        Else
            Application.Exit()
        End If
    End Sub
    Private Sub wc_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Me.Label3.Text = e.BytesReceived / 1024 & " von " & e.TotalBytesToReceive / 1024 & " KB "
        Me.Label2.Text = e.ProgressPercentage & "%"
    End Sub
End Class
