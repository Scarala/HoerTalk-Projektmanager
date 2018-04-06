<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projekt_Bearbeiten
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Projekt_Bearbeiten))
        Me.CancleBtn = New System.Windows.Forms.Button()
        Me.UpdateProjBtn = New System.Windows.Forms.Button()
        Me.ProjStateSelect = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MyStateSelect = New System.Windows.Forms.ComboBox()
        Me.ProjTypeSelect = New System.Windows.Forms.ComboBox()
        Me.MyRoleTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProjLeaderTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProjStateTextBox = New System.Windows.Forms.TextBox()
        Me.ProjRoomTextBox = New System.Windows.Forms.TextBox()
        Me.CastingLinkTextBox = New System.Windows.Forms.TextBox()
        Me.ProjNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DeadlinePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProjStartPicker = New System.Windows.Forms.DateTimePicker()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.SelectLogoBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancleBtn
        '
        Me.CancleBtn.Location = New System.Drawing.Point(367, 528)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(147, 23)
        Me.CancleBtn.TabIndex = 15
        Me.CancleBtn.Text = "Abbrechen und Schließen"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'UpdateProjBtn
        '
        Me.UpdateProjBtn.Location = New System.Drawing.Point(15, 528)
        Me.UpdateProjBtn.Name = "UpdateProjBtn"
        Me.UpdateProjBtn.Size = New System.Drawing.Size(147, 23)
        Me.UpdateProjBtn.TabIndex = 14
        Me.UpdateProjBtn.Text = "Projekt aktualisieren"
        Me.UpdateProjBtn.UseVisualStyleBackColor = True
        '
        'ProjStateSelect
        '
        Me.ProjStateSelect.FormattingEnabled = True
        Me.ProjStateSelect.Items.AddRange(New Object() {"Idee", "Lektorat", "Castingphase", "Einsprechen", "Schnitt", "Abgeschlossen", "Eingefroren", "keine Rolle bekommen"})
        Me.ProjStateSelect.Location = New System.Drawing.Point(154, 145)
        Me.ProjStateSelect.Name = "ProjStateSelect"
        Me.ProjStateSelect.Size = New System.Drawing.Size(213, 21)
        Me.ProjStateSelect.TabIndex = 5
        Me.ProjStateSelect.Text = "Idee"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Projektstatus"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Projekttyp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Mein Status"
        '
        'MyStateSelect
        '
        Me.MyStateSelect.FormattingEnabled = True
        Me.MyStateSelect.Items.AddRange(New Object() {"beworben", "Probetakes eingesprochen", "Probetakes hochgeladen", "Absage", "warten", "Takes einsprechen", "Takes abgeschickt", "Abgeschlossen"})
        Me.MyStateSelect.Location = New System.Drawing.Point(154, 172)
        Me.MyStateSelect.Name = "MyStateSelect"
        Me.MyStateSelect.Size = New System.Drawing.Size(213, 21)
        Me.MyStateSelect.TabIndex = 6
        Me.MyStateSelect.Text = "beworben"
        '
        'ProjTypeSelect
        '
        Me.ProjTypeSelect.FormattingEnabled = True
        Me.ProjTypeSelect.Items.AddRange(New Object() {"intern", "extern"})
        Me.ProjTypeSelect.Location = New System.Drawing.Point(154, 118)
        Me.ProjTypeSelect.Name = "ProjTypeSelect"
        Me.ProjTypeSelect.Size = New System.Drawing.Size(55, 21)
        Me.ProjTypeSelect.TabIndex = 4
        Me.ProjTypeSelect.Text = "intern"
        '
        'MyRoleTextBox
        '
        Me.MyRoleTextBox.Location = New System.Drawing.Point(154, 199)
        Me.MyRoleTextBox.Name = "MyRoleTextBox"
        Me.MyRoleTextBox.Size = New System.Drawing.Size(213, 20)
        Me.MyRoleTextBox.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Deadline"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Projektstart"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Projektleiter"
        '
        'ProjLeaderTextBox
        '
        Me.ProjLeaderTextBox.Location = New System.Drawing.Point(154, 66)
        Me.ProjLeaderTextBox.Name = "ProjLeaderTextBox"
        Me.ProjLeaderTextBox.Size = New System.Drawing.Size(213, 20)
        Me.ProjLeaderTextBox.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Kommentar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Beschreibung"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(154, 251)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(355, 77)
        Me.DescriptionTextBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Link zum Produktionsstatus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Link zum Casting"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Link zum Produktionsraum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Projektname"
        '
        'ProjStateTextBox
        '
        Me.ProjStateTextBox.Location = New System.Drawing.Point(154, 386)
        Me.ProjStateTextBox.Name = "ProjStateTextBox"
        Me.ProjStateTextBox.Size = New System.Drawing.Size(355, 20)
        Me.ProjStateTextBox.TabIndex = 12
        '
        'ProjRoomTextBox
        '
        Me.ProjRoomTextBox.Location = New System.Drawing.Point(154, 360)
        Me.ProjRoomTextBox.Name = "ProjRoomTextBox"
        Me.ProjRoomTextBox.Size = New System.Drawing.Size(355, 20)
        Me.ProjRoomTextBox.TabIndex = 11
        '
        'CastingLinkTextBox
        '
        Me.CastingLinkTextBox.Location = New System.Drawing.Point(154, 334)
        Me.CastingLinkTextBox.Name = "CastingLinkTextBox"
        Me.CastingLinkTextBox.Size = New System.Drawing.Size(355, 20)
        Me.CastingLinkTextBox.TabIndex = 10
        '
        'ProjNameTextBox
        '
        Me.ProjNameTextBox.Location = New System.Drawing.Point(154, 12)
        Me.ProjNameTextBox.Name = "ProjNameTextBox"
        Me.ProjNameTextBox.Size = New System.Drawing.Size(355, 20)
        Me.ProjNameTextBox.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Rolle"
        '
        'DeadlinePicker
        '
        Me.DeadlinePicker.CustomFormat = "dd.MM.YYYY"
        Me.DeadlinePicker.Location = New System.Drawing.Point(154, 225)
        Me.DeadlinePicker.Name = "DeadlinePicker"
        Me.DeadlinePicker.Size = New System.Drawing.Size(213, 20)
        Me.DeadlinePicker.TabIndex = 62
        '
        'ProjStartPicker
        '
        Me.ProjStartPicker.CustomFormat = "dd.MM.YYYY"
        Me.ProjStartPicker.Location = New System.Drawing.Point(154, 92)
        Me.ProjStartPicker.Name = "ProjStartPicker"
        Me.ProjStartPicker.Size = New System.Drawing.Size(213, 20)
        Me.ProjStartPicker.TabIndex = 61
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Location = New System.Drawing.Point(375, 38)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(134, 99)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 64
        Me.LogoPictureBox.TabStop = False
        '
        'SelectLogoBtn
        '
        Me.SelectLogoBtn.Location = New System.Drawing.Point(154, 37)
        Me.SelectLogoBtn.Name = "SelectLogoBtn"
        Me.SelectLogoBtn.Size = New System.Drawing.Size(213, 23)
        Me.SelectLogoBtn.TabIndex = 63
        Me.SelectLogoBtn.Text = "Projektlogo wählen"
        Me.SelectLogoBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Projektlogo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Location = New System.Drawing.Point(154, 415)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CommentTextBox.Size = New System.Drawing.Size(355, 107)
        Me.CommentTextBox.TabIndex = 66
        '
        'Projekt_Bearbeiten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.SelectLogoBtn)
        Me.Controls.Add(Me.DeadlinePicker)
        Me.Controls.Add(Me.ProjStartPicker)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CancleBtn)
        Me.Controls.Add(Me.UpdateProjBtn)
        Me.Controls.Add(Me.ProjStateSelect)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.MyStateSelect)
        Me.Controls.Add(Me.ProjTypeSelect)
        Me.Controls.Add(Me.MyRoleTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProjLeaderTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProjStateTextBox)
        Me.Controls.Add(Me.ProjRoomTextBox)
        Me.Controls.Add(Me.CastingLinkTextBox)
        Me.Controls.Add(Me.ProjNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Projekt_Bearbeiten"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projekt Bearbeiten"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancleBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateProjBtn As System.Windows.Forms.Button
    Friend WithEvents ProjStateSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MyStateSelect As System.Windows.Forms.ComboBox
    Friend WithEvents ProjTypeSelect As System.Windows.Forms.ComboBox
    Friend WithEvents MyRoleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProjLeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProjStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjRoomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CastingLinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DeadlinePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProjStartPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SelectLogoBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CommentTextBox As TextBox
End Class
