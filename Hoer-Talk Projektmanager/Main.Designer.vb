<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.NewProjBtn = New System.Windows.Forms.Button()
        Me.ProjDetailsBtn = New System.Windows.Forms.Button()
        Me.ProjArchivateBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Projektname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Projektstart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Projekttyp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Projektstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mein_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deadline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProjArchivOpenBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewProjBtn
        '
        Me.NewProjBtn.Location = New System.Drawing.Point(12, 12)
        Me.NewProjBtn.Name = "NewProjBtn"
        Me.NewProjBtn.Size = New System.Drawing.Size(136, 23)
        Me.NewProjBtn.TabIndex = 0
        Me.NewProjBtn.Text = "Neues Projekt anlegen"
        Me.NewProjBtn.UseVisualStyleBackColor = True
        '
        'ProjDetailsBtn
        '
        Me.ProjDetailsBtn.Location = New System.Drawing.Point(154, 12)
        Me.ProjDetailsBtn.Name = "ProjDetailsBtn"
        Me.ProjDetailsBtn.Size = New System.Drawing.Size(136, 23)
        Me.ProjDetailsBtn.TabIndex = 1
        Me.ProjDetailsBtn.Text = "Projektdetails anzeigen"
        Me.ProjDetailsBtn.UseVisualStyleBackColor = True
        '
        'ProjArchivateBtn
        '
        Me.ProjArchivateBtn.Location = New System.Drawing.Point(296, 12)
        Me.ProjArchivateBtn.Name = "ProjArchivateBtn"
        Me.ProjArchivateBtn.Size = New System.Drawing.Size(136, 23)
        Me.ProjArchivateBtn.TabIndex = 2
        Me.ProjArchivateBtn.Text = "Projekt Archivieren"
        Me.ProjArchivateBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Logo, Me.Projektname, Me.Projektstart, Me.Projekttyp, Me.Projektstatus, Me.Mein_Status, Me.Deadline})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1060, 408)
        Me.DataGridView1.TabIndex = 4
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 30
        '
        'Logo
        '
        Me.Logo.HeaderText = "Logo"
        Me.Logo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Logo.Name = "Logo"
        Me.Logo.ReadOnly = True
        '
        'Projektname
        '
        Me.Projektname.HeaderText = "Projektname"
        Me.Projektname.Name = "Projektname"
        Me.Projektname.ReadOnly = True
        Me.Projektname.Width = 240
        '
        'Projektstart
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Projektstart.DefaultCellStyle = DataGridViewCellStyle1
        Me.Projektstart.HeaderText = "Projektstart"
        Me.Projektstart.Name = "Projektstart"
        Me.Projektstart.ReadOnly = True
        Me.Projektstart.Width = 120
        '
        'Projekttyp
        '
        Me.Projekttyp.HeaderText = "Projekttyp"
        Me.Projekttyp.Name = "Projekttyp"
        Me.Projekttyp.ReadOnly = True
        Me.Projekttyp.Width = 80
        '
        'Projektstatus
        '
        Me.Projektstatus.HeaderText = "Projektstatus"
        Me.Projektstatus.Name = "Projektstatus"
        Me.Projektstatus.ReadOnly = True
        Me.Projektstatus.Width = 150
        '
        'Mein_Status
        '
        Me.Mein_Status.HeaderText = "Mein Status"
        Me.Mein_Status.Name = "Mein_Status"
        Me.Mein_Status.ReadOnly = True
        Me.Mein_Status.Width = 145
        '
        'Deadline
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Deadline.DefaultCellStyle = DataGridViewCellStyle2
        Me.Deadline.HeaderText = "Deadline"
        Me.Deadline.Name = "Deadline"
        Me.Deadline.ReadOnly = True
        Me.Deadline.Width = 120
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(915, 14)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(157, 20)
        Me.SearchBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(871, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Suche"
        '
        'ProjArchivOpenBtn
        '
        Me.ProjArchivOpenBtn.Location = New System.Drawing.Point(438, 12)
        Me.ProjArchivOpenBtn.Name = "ProjArchivOpenBtn"
        Me.ProjArchivOpenBtn.Size = New System.Drawing.Size(136, 23)
        Me.ProjArchivOpenBtn.TabIndex = 7
        Me.ProjArchivOpenBtn.Text = "Archiv anzeigen"
        Me.ProjArchivOpenBtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 461)
        Me.Controls.Add(Me.ProjArchivOpenBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProjArchivateBtn)
        Me.Controls.Add(Me.ProjDetailsBtn)
        Me.Controls.Add(Me.NewProjBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HoerTalk-Projektmanager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewProjBtn As System.Windows.Forms.Button
    Friend WithEvents ProjDetailsBtn As System.Windows.Forms.Button
    Friend WithEvents ProjArchivateBtn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProjArchivOpenBtn As System.Windows.Forms.Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Logo As DataGridViewImageColumn
    Friend WithEvents Projektname As DataGridViewTextBoxColumn
    Friend WithEvents Projektstart As DataGridViewTextBoxColumn
    Friend WithEvents Projekttyp As DataGridViewTextBoxColumn
    Friend WithEvents Projektstatus As DataGridViewTextBoxColumn
    Friend WithEvents Mein_Status As DataGridViewTextBoxColumn
    Friend WithEvents Deadline As DataGridViewTextBoxColumn
End Class
