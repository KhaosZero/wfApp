﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.conMain = New System.Windows.Forms.SplitContainer()
        Me.lblKeyword = New System.Windows.Forms.Label()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuActivator = New System.Windows.Forms.Button()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.cbLoc = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lblApplication = New System.Windows.Forms.Label()
        Me.cbApp = New System.Windows.Forms.ComboBox()
        Me.lstInput = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.staMain = New System.Windows.Forms.StatusStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.prgLoad = New System.Windows.Forms.ToolStripProgressBar()
        Me.lstI = New System.Windows.Forms.ListBox()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.conMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conMain.Panel1.SuspendLayout()
        Me.conMain.Panel2.SuspendLayout()
        Me.conMain.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'conMain
        '
        Me.conMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.conMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.conMain.Location = New System.Drawing.Point(0, 0)
        Me.conMain.Name = "conMain"
        Me.conMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'conMain.Panel1
        '
        Me.conMain.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.conMain.Panel1.Controls.Add(Me.lblKeyword)
        Me.conMain.Panel1.Controls.Add(Me.mnuStrip)
        Me.conMain.Panel1.Controls.Add(Me.MenuActivator)
        Me.conMain.Panel1.Controls.Add(Me.txtKeyword)
        Me.conMain.Panel1.Controls.Add(Me.lblLocation)
        Me.conMain.Panel1.Controls.Add(Me.cbLoc)
        Me.conMain.Panel1.Controls.Add(Me.lblType)
        Me.conMain.Panel1.Controls.Add(Me.cbType)
        Me.conMain.Panel1.Controls.Add(Me.lblApplication)
        Me.conMain.Panel1.Controls.Add(Me.cbApp)
        '
        'conMain.Panel2
        '
        Me.conMain.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.conMain.Panel2.Controls.Add(Me.lstInput)
        Me.conMain.Panel2.Controls.Add(Me.Button1)
        Me.conMain.Panel2.Controls.Add(Me.staMain)
        Me.conMain.Size = New System.Drawing.Size(617, 392)
        Me.conMain.SplitterDistance = 62
        Me.conMain.TabIndex = 0
        '
        'lblKeyword
        '
        Me.lblKeyword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKeyword.AutoSize = True
        Me.lblKeyword.Location = New System.Drawing.Point(12, 12)
        Me.lblKeyword.Name = "lblKeyword"
        Me.lblKeyword.Size = New System.Drawing.Size(48, 13)
        Me.lblKeyword.TabIndex = 6
        Me.lblKeyword.Text = "Keyword"
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(617, 24)
        Me.mnuStrip.TabIndex = 9
        Me.mnuStrip.Text = "MenuStrip1"
        Me.mnuStrip.Visible = False
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem2, Me.ChangelogToolStripMenuItem1})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem2
        '
        Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
        Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(132, 22)
        Me.AboutToolStripMenuItem2.Text = "&About"
        '
        'ChangelogToolStripMenuItem1
        '
        Me.ChangelogToolStripMenuItem1.Name = "ChangelogToolStripMenuItem1"
        Me.ChangelogToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.ChangelogToolStripMenuItem1.Text = "&Changelog"
        '
        'MenuActivator
        '
        Me.MenuActivator.BackColor = System.Drawing.Color.Transparent
        Me.MenuActivator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuActivator.ForeColor = System.Drawing.SystemColors.Control
        Me.MenuActivator.Location = New System.Drawing.Point(0, 0)
        Me.MenuActivator.Name = "MenuActivator"
        Me.MenuActivator.Size = New System.Drawing.Size(12, 13)
        Me.MenuActivator.TabIndex = 9
        Me.MenuActivator.UseVisualStyleBackColor = False
        '
        'txtKeyword
        '
        Me.txtKeyword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyword.Enabled = False
        Me.txtKeyword.Location = New System.Drawing.Point(12, 28)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(114, 20)
        Me.txtKeyword.TabIndex = 1
        '
        'lblLocation
        '
        Me.lblLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(461, 12)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 5
        Me.lblLocation.Text = "Location"
        '
        'cbLoc
        '
        Me.cbLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbLoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLoc.FormattingEnabled = True
        Me.cbLoc.Items.AddRange(New Object() {"Edmonton Zone"})
        Me.cbLoc.Location = New System.Drawing.Point(464, 28)
        Me.cbLoc.Name = "cbLoc"
        Me.cbLoc.Size = New System.Drawing.Size(142, 21)
        Me.cbLoc.TabIndex = 4
        '
        'lblType
        '
        Me.lblType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(307, 12)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 3
        Me.lblType.Text = "Type"
        '
        'cbType
        '
        Me.cbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Employee", "Community"})
        Me.cbType.Location = New System.Drawing.Point(310, 28)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(137, 21)
        Me.cbType.TabIndex = 2
        '
        'lblApplication
        '
        Me.lblApplication.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApplication.AutoSize = True
        Me.lblApplication.Location = New System.Drawing.Point(154, 12)
        Me.lblApplication.Name = "lblApplication"
        Me.lblApplication.Size = New System.Drawing.Size(59, 13)
        Me.lblApplication.TabIndex = 1
        Me.lblApplication.Text = "Application"
        '
        'cbApp
        '
        Me.cbApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbApp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbApp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbApp.FormattingEnabled = True
        Me.cbApp.Items.AddRange(New Object() {"Netcare"})
        Me.cbApp.Location = New System.Drawing.Point(155, 28)
        Me.cbApp.Name = "cbApp"
        Me.cbApp.Size = New System.Drawing.Size(137, 21)
        Me.cbApp.TabIndex = 0
        '
        'lstInput
        '
        Me.lstInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstInput.FormattingEnabled = True
        Me.lstInput.Location = New System.Drawing.Point(5, 44)
        Me.lstInput.Name = "lstInput"
        Me.lstInput.Size = New System.Drawing.Size(608, 277)
        Me.lstInput.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(483, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Best Test Ever"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'staMain
        '
        Me.staMain.Location = New System.Drawing.Point(0, 306)
        Me.staMain.Name = "staMain"
        Me.staMain.Size = New System.Drawing.Size(617, 22)
        Me.staMain.TabIndex = 7
        Me.staMain.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "&About..."
        '
        'mnuLog
        '
        Me.mnuLog.Name = "mnuLog"
        Me.mnuLog.Size = New System.Drawing.Size(152, 22)
        Me.mnuLog.Text = "&Change Log..."
        '
        'prgLoad
        '
        Me.prgLoad.Name = "prgLoad"
        Me.prgLoad.Size = New System.Drawing.Size(100, 16)
        '
        'lstI
        '
        Me.lstI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstI.FormattingEnabled = True
        Me.lstI.Location = New System.Drawing.Point(5, 44)
        Me.lstI.Name = "lstI"
        Me.lstI.Size = New System.Drawing.Size(608, 277)
        Me.lstI.TabIndex = 10
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ChangeLogToolStripMenuItem
        '
        Me.ChangeLogToolStripMenuItem.Name = "ChangeLogToolStripMenuItem"
        Me.ChangeLogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChangeLogToolStripMenuItem.Text = "&Changelog..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 392)
        Me.Controls.Add(Me.conMain)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmMain"
        Me.Text = "Database Search"
        Me.conMain.Panel1.ResumeLayout(False)
        Me.conMain.Panel1.PerformLayout()
        Me.conMain.Panel2.ResumeLayout(False)
        Me.conMain.Panel2.PerformLayout()
        CType(Me.conMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conMain.ResumeLayout(False)
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents conMain As System.Windows.Forms.SplitContainer
    Friend WithEvents cbApp As System.Windows.Forms.ComboBox
    Friend WithEvents lblApplication As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents cbLoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblKeyword As System.Windows.Forms.Label
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents staMain As System.Windows.Forms.StatusStrip
    Friend WithEvents prgLoad As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuActivator As System.Windows.Forms.Button
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstInput As System.Windows.Forms.ListBox
    Friend WithEvents lstI As System.Windows.Forms.ListBox
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
