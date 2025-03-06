<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AVF02.0A*0C")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QVF", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AVSSJ-21L-2424-00001*19")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QV", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AS00000000D*56")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AS2222222D*64")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AS0222222U*77")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AS3222222D*65")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QS", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AH060*3F")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QH", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AT500*20")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$AT700*22")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QT", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$ACD*21")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("$ACF*21")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QC", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tb_sendMessage = New System.Windows.Forms.TextBox()
        Me.btn_DataSend = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsLabelPort = New System.Windows.Forms.ToolStripLabel()
        Me.tsSplitbtnPort = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnConnect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_log = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ts_LogClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.선택복사CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1866, 1069)
        Me.SplitContainer1.SplitterDistance = 1052
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.ColumnWidth = 600
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.Font = New System.Drawing.Font("굴림", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(1050, 1067)
        Me.ListBox1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(802, 1067)
        Me.SplitContainer2.SplitterDistance = 868
        Me.SplitContainer2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("굴림", 12.0!)
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ItemHeight = 30
        Me.TreeView1.LabelEdit = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Checked = True
        TreeNode1.Name = "노드1"
        TreeNode1.Text = "$AVF02.0A*0C"
        TreeNode2.Checked = True
        TreeNode2.Name = "노드0"
        TreeNode2.Text = "QVF"
        TreeNode3.Checked = True
        TreeNode3.Name = "AV"
        TreeNode3.Text = "$AVSSJ-21L-2424-00001*19"
        TreeNode4.Checked = True
        TreeNode4.Name = "cmdQV"
        TreeNode4.Text = "QV"
        TreeNode5.Checked = True
        TreeNode5.Name = "노드5"
        TreeNode5.Text = "$AS00000000D*56"
        TreeNode6.Name = "노드6"
        TreeNode6.Text = "$AS2222222D*64"
        TreeNode7.Name = "노드7"
        TreeNode7.Text = "$AS0222222U*77"
        TreeNode8.Name = "노드10"
        TreeNode8.Text = "$AS3222222D*65"
        TreeNode9.Checked = True
        TreeNode9.Name = "cmdQS"
        TreeNode9.Text = "QS"
        TreeNode10.Checked = True
        TreeNode10.Name = "노드11"
        TreeNode10.Text = "$AH060*3F"
        TreeNode11.Checked = True
        TreeNode11.Name = "노드2"
        TreeNode11.Text = "QH"
        TreeNode12.Checked = True
        TreeNode12.Name = "노드12"
        TreeNode12.Text = "$AT500*20"
        TreeNode13.Name = "노드13"
        TreeNode13.Text = "$AT700*22"
        TreeNode14.Checked = True
        TreeNode14.Name = "노드3"
        TreeNode14.Text = "QT"
        TreeNode15.Checked = True
        TreeNode15.Name = "노드14"
        TreeNode15.Text = "$ACD*21"
        TreeNode16.Name = "노드15"
        TreeNode16.Text = "$ACF*21"
        TreeNode17.Checked = True
        TreeNode17.Name = "노드8"
        TreeNode17.Text = "QC"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode9, TreeNode11, TreeNode14, TreeNode17})
        Me.TreeView1.Size = New System.Drawing.Size(802, 868)
        Me.TreeView1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.tb_sendMessage)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_DataSend)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(802, 195)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'tb_sendMessage
        '
        Me.tb_sendMessage.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.tb_sendMessage.Location = New System.Drawing.Point(8, 8)
        Me.tb_sendMessage.Name = "tb_sendMessage"
        Me.tb_sendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_sendMessage.Size = New System.Drawing.Size(672, 35)
        Me.tb_sendMessage.TabIndex = 0
        '
        'btn_DataSend
        '
        Me.btn_DataSend.AutoSize = True
        Me.btn_DataSend.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_DataSend.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn_DataSend.Location = New System.Drawing.Point(8, 49)
        Me.btn_DataSend.MinimumSize = New System.Drawing.Size(100, 60)
        Me.btn_DataSend.Name = "btn_DataSend"
        Me.btn_DataSend.Size = New System.Drawing.Size(109, 60)
        Me.btn_DataSend.TabIndex = 1
        Me.btn_DataSend.Text = "Send"
        Me.btn_DataSend.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(10)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLabelPort, Me.tsSplitbtnPort, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.tsBtnConnect, Me.ToolStripSeparator3, Me.ts_log})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1866, 61)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsLabelPort
        '
        Me.tsLabelPort.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.tsLabelPort.Name = "tsLabelPort"
        Me.tsLabelPort.Size = New System.Drawing.Size(45, 25)
        Me.tsLabelPort.Text = "Port"
        Me.tsLabelPort.Visible = False
        '
        'tsSplitbtnPort
        '
        Me.tsSplitbtnPort.AutoSize = False
        Me.tsSplitbtnPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsSplitbtnPort.Image = CType(resources.GetObject("tsSplitbtnPort.Image"), System.Drawing.Image)
        Me.tsSplitbtnPort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSplitbtnPort.Margin = New System.Windows.Forms.Padding(0)
        Me.tsSplitbtnPort.Name = "tsSplitbtnPort"
        Me.tsSplitbtnPort.Size = New System.Drawing.Size(168, 30)
        Me.tsSplitbtnPort.Text = "연결 포트 선택"
        Me.tsSplitbtnPort.ToolTipText = "연결 포트 선택"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 25)
        Me.ToolStripLabel1.Text = "bit rate"
        Me.ToolStripLabel1.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(84, 29)
        Me.ToolStripDropDownButton1.Text = "미지정"
        Me.ToolStripDropDownButton1.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 34)
        Me.ToolStripMenuItem2.Text = "115200"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'tsBtnConnect
        '
        Me.tsBtnConnect.CheckOnClick = True
        Me.tsBtnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBtnConnect.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBtnConnect.Image = CType(resources.GetObject("tsBtnConnect.Image"), System.Drawing.Image)
        Me.tsBtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnConnect.Margin = New System.Windows.Forms.Padding(10, 2, 10, 3)
        Me.tsBtnConnect.Name = "tsBtnConnect"
        Me.tsBtnConnect.Size = New System.Drawing.Size(112, 36)
        Me.tsBtnConnect.Text = "Connect"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ts_log
        '
        Me.ts_log.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_LogClear, Me.선택복사CToolStripMenuItem})
        Me.ts_log.Image = CType(resources.GetObject("ts_log.Image"), System.Drawing.Image)
        Me.ts_log.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_log.Name = "ts_log"
        Me.ts_log.Size = New System.Drawing.Size(90, 29)
        Me.ts_log.Text = "로그"
        '
        'ts_LogClear
        '
        Me.ts_LogClear.Enabled = False
        Me.ts_LogClear.Name = "ts_LogClear"
        Me.ts_LogClear.Size = New System.Drawing.Size(272, 34)
        Me.ts_LogClear.Text = "모두 지우기"
        '
        '선택복사CToolStripMenuItem
        '
        Me.선택복사CToolStripMenuItem.Enabled = False
        Me.선택복사CToolStripMenuItem.Name = "선택복사CToolStripMenuItem"
        Me.선택복사CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.선택복사CToolStripMenuItem.Size = New System.Drawing.Size(272, 34)
        Me.선택복사CToolStripMenuItem.Text = "선택 복사 &C"
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(1866, 1069)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.Size = New System.Drawing.Size(1866, 1130)
        Me.ToolStripContainer3.TabIndex = 4
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'ToolStripContainer3.TopToolStripPanel
        '
        Me.ToolStripContainer3.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1866, 1130)
        Me.Controls.Add(Me.ToolStripContainer3)
        Me.Name = "frmMain"
        Me.Text = "serial Automation Tool"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsLabelPort As ToolStripLabel
    Friend WithEvents tsSplitbtnPort As ToolStripDropDownButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsBtnConnect As ToolStripButton
    Friend WithEvents ToolStripContainer3 As ToolStripContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents tb_sendMessage As TextBox
    Friend WithEvents btn_DataSend As Button
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ts_log As ToolStripDropDownButton
    Friend WithEvents ts_LogClear As ToolStripMenuItem
    Friend WithEvents 선택복사CToolStripMenuItem As ToolStripMenuItem
End Class
