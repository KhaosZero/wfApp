<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuActivator = New System.Windows.Forms.Button()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.cbLoc = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lblApplication = New System.Windows.Forms.Label()
        Me.cbApp = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.staMain = New System.Windows.Forms.StatusStrip()
        Me.prgLoad = New System.Windows.Forms.ToolStripProgressBar()
        CType(Me.conMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conMain.Panel1.SuspendLayout()
        Me.conMain.Panel2.SuspendLayout()
        Me.conMain.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.staMain.SuspendLayout()
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
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(617, 24)
        Me.mnuStrip.TabIndex = 9
        Me.mnuStrip.Text = "MenuStrip1"
        Me.mnuStrip.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuLog})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(147, 22)
        Me.mnuAbout.Text = "&About..."
        '
        'mnuLog
        '
        Me.mnuLog.Name = "mnuLog"
        Me.mnuLog.Size = New System.Drawing.Size(147, 22)
        Me.mnuLog.Text = "&Change Log..."
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
        Me.cbLoc.FormattingEnabled = True
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
        Me.cbType.FormattingEnabled = True
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
        Me.cbApp.FormattingEnabled = True
        Me.cbApp.Location = New System.Drawing.Point(155, 28)
        Me.cbApp.Name = "cbApp"
        Me.cbApp.Size = New System.Drawing.Size(137, 21)
        Me.cbApp.TabIndex = 0
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
        Me.staMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prgLoad})
        Me.staMain.Location = New System.Drawing.Point(0, 306)
        Me.staMain.Name = "staMain"
        Me.staMain.Size = New System.Drawing.Size(617, 22)
        Me.staMain.TabIndex = 7
        Me.staMain.Visible = False
        '
        'prgLoad
        '
        Me.prgLoad.Name = "prgLoad"
        Me.prgLoad.Size = New System.Drawing.Size(100, 16)
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
        Me.staMain.ResumeLayout(False)
        Me.staMain.PerformLayout()
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

End Class
