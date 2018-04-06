<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archiv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Archiv))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Projektname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Projektstart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecoverProjBtn = New System.Windows.Forms.Button()
        Me.ArchiveCloseBtn = New System.Windows.Forms.Button()
        Me.ArchivShowProjBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArchivSearchBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Logo, Me.Projektname, Me.Projektstart})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 32)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(559, 397)
        Me.DataGridView1.TabIndex = 5
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
        'RecoverProjBtn
        '
        Me.RecoverProjBtn.Location = New System.Drawing.Point(12, 436)
        Me.RecoverProjBtn.Name = "RecoverProjBtn"
        Me.RecoverProjBtn.Size = New System.Drawing.Size(160, 23)
        Me.RecoverProjBtn.TabIndex = 6
        Me.RecoverProjBtn.Text = "Projekt widerherstellen"
        Me.RecoverProjBtn.UseVisualStyleBackColor = True
        '
        'ArchiveCloseBtn
        '
        Me.ArchiveCloseBtn.Location = New System.Drawing.Point(411, 436)
        Me.ArchiveCloseBtn.Name = "ArchiveCloseBtn"
        Me.ArchiveCloseBtn.Size = New System.Drawing.Size(160, 23)
        Me.ArchiveCloseBtn.TabIndex = 7
        Me.ArchiveCloseBtn.Text = "Schließen"
        Me.ArchiveCloseBtn.UseVisualStyleBackColor = True
        '
        'ArchivShowProjBtn
        '
        Me.ArchivShowProjBtn.Location = New System.Drawing.Point(214, 436)
        Me.ArchivShowProjBtn.Name = "ArchivShowProjBtn"
        Me.ArchivShowProjBtn.Size = New System.Drawing.Size(160, 23)
        Me.ArchivShowProjBtn.TabIndex = 8
        Me.ArchivShowProjBtn.Text = "Projekt anzeigen"
        Me.ArchivShowProjBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Suche"
        '
        'ArchivSearchBox
        '
        Me.ArchivSearchBox.Location = New System.Drawing.Point(414, 6)
        Me.ArchivSearchBox.Name = "ArchivSearchBox"
        Me.ArchivSearchBox.Size = New System.Drawing.Size(157, 20)
        Me.ArchivSearchBox.TabIndex = 9
        '
        'Archiv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ArchivSearchBox)
        Me.Controls.Add(Me.ArchivShowProjBtn)
        Me.Controls.Add(Me.ArchiveCloseBtn)
        Me.Controls.Add(Me.RecoverProjBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Archiv"
        Me.Text = "Archiv"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RecoverProjBtn As System.Windows.Forms.Button
    Friend WithEvents ArchiveCloseBtn As System.Windows.Forms.Button
    Friend WithEvents ArchivShowProjBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ArchivSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Logo As DataGridViewImageColumn
    Friend WithEvents Projektname As DataGridViewTextBoxColumn
    Friend WithEvents Projektstart As DataGridViewTextBoxColumn
End Class
