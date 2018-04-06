<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Neues_Projekt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Neues_Projekt))
        Me.ProjNameTextBox = New System.Windows.Forms.TextBox()
        Me.CastingLinkTextBox = New System.Windows.Forms.TextBox()
        Me.ProjRoomLinkTextBox = New System.Windows.Forms.TextBox()
        Me.ProjStateLinkTextBox = New System.Windows.Forms.TextBox()
        Me.ProjFolderTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProjLeaderTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MyRoleTextBox = New System.Windows.Forms.TextBox()
        Me.ProjTypeSelect = New System.Windows.Forms.ComboBox()
        Me.MyStateSelect = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProjStateSelect = New System.Windows.Forms.ComboBox()
        Me.CreateProjBtn = New System.Windows.Forms.Button()
        Me.CancleBtn = New System.Windows.Forms.Button()
        Me.ProjStartTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DeadlinePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ProjNameTextBox
        '
        Me.ProjNameTextBox.Location = New System.Drawing.Point(154, 12)
        Me.ProjNameTextBox.Name = "ProjNameTextBox"
        Me.ProjNameTextBox.Size = New System.Drawing.Size(355, 20)
        Me.ProjNameTextBox.TabIndex = 0
        '
        'CastingLinkTextBox
        '
        Me.CastingLinkTextBox.Location = New System.Drawing.Point(154, 360)
        Me.CastingLinkTextBox.Name = "CastingLinkTextBox"
        Me.CastingLinkTextBox.Size = New System.Drawing.Size(355, 20)
        Me.CastingLinkTextBox.TabIndex = 10
        '
        'ProjRoomLinkTextBox
        '
        Me.ProjRoomLinkTextBox.Location = New System.Drawing.Point(154, 386)
        Me.ProjRoomLinkTextBox.Name = "ProjRoomLinkTextBox"
        Me.ProjRoomLinkTextBox.Size = New System.Drawing.Size(355, 20)
        Me.ProjRoomLinkTextBox.TabIndex = 11
        '
        'ProjStateLinkTextBox
        '
        Me.ProjStateLinkTextBox.Location = New System.Drawing.Point(154, 412)
        Me.ProjStateLinkTextBox.Name = "ProjStateLinkTextBox"
        Me.ProjStateLinkTextBox.Size = New System.Drawing.Size(355, 20)
        Me.ProjStateLinkTextBox.TabIndex = 12
        '
        'ProjFolderTextBox
        '
        Me.ProjFolderTextBox.Location = New System.Drawing.Point(154, 92)
        Me.ProjFolderTextBox.Name = "ProjFolderTextBox"
        Me.ProjFolderTextBox.Size = New System.Drawing.Size(213, 20)
        Me.ProjFolderTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Projektname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Link zum Produktionsraum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Link zum Casting"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Link zum Produktionsstatus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Speicherordner-Name"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(154, 277)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(355, 77)
        Me.DescriptionTextBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Beschreibung"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Kommentar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Projektleiter"
        '
        'ProjLeaderTextBox
        '
        Me.ProjLeaderTextBox.Location = New System.Drawing.Point(154, 67)
        Me.ProjLeaderTextBox.Name = "ProjLeaderTextBox"
        Me.ProjLeaderTextBox.Size = New System.Drawing.Size(213, 20)
        Me.ProjLeaderTextBox.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Projektstart"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Deadline"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Rolle"
        '
        'MyRoleTextBox
        '
        Me.MyRoleTextBox.Location = New System.Drawing.Point(154, 225)
        Me.MyRoleTextBox.Name = "MyRoleTextBox"
        Me.MyRoleTextBox.Size = New System.Drawing.Size(213, 20)
        Me.MyRoleTextBox.TabIndex = 7
        '
        'ProjTypeSelect
        '
        Me.ProjTypeSelect.FormattingEnabled = True
        Me.ProjTypeSelect.Items.AddRange(New Object() {"intern", "extern"})
        Me.ProjTypeSelect.Location = New System.Drawing.Point(154, 144)
        Me.ProjTypeSelect.Name = "ProjTypeSelect"
        Me.ProjTypeSelect.Size = New System.Drawing.Size(55, 21)
        Me.ProjTypeSelect.TabIndex = 4
        Me.ProjTypeSelect.Text = "intern"
        '
        'MyStateSelect
        '
        Me.MyStateSelect.FormattingEnabled = True
        Me.MyStateSelect.Items.AddRange(New Object() {"beworben", "Probetakes eingesprochen", "Probetakes hochgeladen", "Absage", "warten", "Takes einsprechen", "Takes abgeschickt", "Abgeschlossen"})
        Me.MyStateSelect.Location = New System.Drawing.Point(154, 198)
        Me.MyStateSelect.Name = "MyStateSelect"
        Me.MyStateSelect.Size = New System.Drawing.Size(213, 21)
        Me.MyStateSelect.TabIndex = 6
        Me.MyStateSelect.Text = "beworben"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Mein Status"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Projekttyp"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Projektstatus"
        '
        'ProjStateSelect
        '
        Me.ProjStateSelect.FormattingEnabled = True
        Me.ProjStateSelect.Items.AddRange(New Object() {"Idee", "Lektorat", "Castingphase", "Einsprechen", "Schnitt", "Abgeschlossen", "Eingefroren", "keine Rolle bekommen"})
        Me.ProjStateSelect.Location = New System.Drawing.Point(154, 171)
        Me.ProjStateSelect.Name = "ProjStateSelect"
        Me.ProjStateSelect.Size = New System.Drawing.Size(213, 21)
        Me.ProjStateSelect.TabIndex = 5
        Me.ProjStateSelect.Text = "Idee"
        '
        'CreateProjBtn
        '
        Me.CreateProjBtn.Location = New System.Drawing.Point(70, 554)
        Me.CreateProjBtn.Name = "CreateProjBtn"
        Me.CreateProjBtn.Size = New System.Drawing.Size(174, 23)
        Me.CreateProjBtn.TabIndex = 14
        Me.CreateProjBtn.Text = "Projekt anlegen"
        Me.CreateProjBtn.UseVisualStyleBackColor = True
        '
        'CancleBtn
        '
        Me.CancleBtn.Location = New System.Drawing.Point(270, 554)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(174, 23)
        Me.CancleBtn.TabIndex = 15
        Me.CancleBtn.Text = "Abbrechen und Schließen"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'ProjStartTimePicker
        '
        Me.ProjStartTimePicker.CustomFormat = "dd.MM.YYYY"
        Me.ProjStartTimePicker.Location = New System.Drawing.Point(154, 118)
        Me.ProjStartTimePicker.Name = "ProjStartTimePicker"
        Me.ProjStartTimePicker.Size = New System.Drawing.Size(213, 20)
        Me.ProjStartTimePicker.TabIndex = 26
        '
        'DeadlinePicker
        '
        Me.DeadlinePicker.CustomFormat = "dd.MM.YYYY"
        Me.DeadlinePicker.Location = New System.Drawing.Point(154, 251)
        Me.DeadlinePicker.Name = "DeadlinePicker"
        Me.DeadlinePicker.Size = New System.Drawing.Size(213, 20)
        Me.DeadlinePicker.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(362, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Projektlogo kann erst nach dem Anlegen des Projektes hinzugefügt werden"
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Location = New System.Drawing.Point(154, 441)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CommentTextBox.Size = New System.Drawing.Size(355, 107)
        Me.CommentTextBox.TabIndex = 67
        '
        'Neues_Projekt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DeadlinePicker)
        Me.Controls.Add(Me.ProjStartTimePicker)
        Me.Controls.Add(Me.CancleBtn)
        Me.Controls.Add(Me.CreateProjBtn)
        Me.Controls.Add(Me.ProjStateSelect)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.MyStateSelect)
        Me.Controls.Add(Me.ProjTypeSelect)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.MyRoleTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProjLeaderTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProjFolderTextBox)
        Me.Controls.Add(Me.ProjStateLinkTextBox)
        Me.Controls.Add(Me.ProjRoomLinkTextBox)
        Me.Controls.Add(Me.CastingLinkTextBox)
        Me.Controls.Add(Me.ProjNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Neues_Projekt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neues Projekt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CastingLinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjRoomLinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjStateLinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProjLeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MyRoleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjTypeSelect As System.Windows.Forms.ComboBox
    Friend WithEvents MyStateSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ProjStateSelect As System.Windows.Forms.ComboBox
    Friend WithEvents CreateProjBtn As System.Windows.Forms.Button
    Friend WithEvents CancleBtn As System.Windows.Forms.Button
    Friend WithEvents ProjStartTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DeadlinePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CommentTextBox As TextBox
End Class
