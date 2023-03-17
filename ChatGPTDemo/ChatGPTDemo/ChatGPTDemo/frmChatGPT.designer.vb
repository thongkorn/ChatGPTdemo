<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChatGPT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChatGPT))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaxTokens = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.cmbTemperature = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.btnClearAnswer = New System.Windows.Forms.Button()
        Me.chkEnter = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Max Tokens"
        '
        'txtMaxTokens
        '
        Me.txtMaxTokens.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMaxTokens.Location = New System.Drawing.Point(261, 18)
        Me.txtMaxTokens.MaxLength = 4
        Me.txtMaxTokens.Name = "txtMaxTokens"
        Me.txtMaxTokens.Size = New System.Drawing.Size(53, 26)
        Me.txtMaxTokens.TabIndex = 1
        Me.txtMaxTokens.Text = "2048"
        Me.txtMaxTokens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Randomness"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "User ID"
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(600, 19)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(100, 26)
        Me.txtUserID.TabIndex = 3
        Me.txtUserID.Text = "1"
        '
        'txtAnswer
        '
        Me.txtAnswer.AcceptsReturn = True
        Me.txtAnswer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAnswer.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txtAnswer.Location = New System.Drawing.Point(3, 19)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAnswer.Size = New System.Drawing.Size(995, 276)
        Me.txtAnswer.TabIndex = 0
        Me.txtAnswer.TabStop = False
        '
        'txtQuestion
        '
        Me.txtQuestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuestion.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txtQuestion.Location = New System.Drawing.Point(3, 19)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(992, 116)
        Me.txtQuestion.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.Crimson
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(870, 541)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(130, 34)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send  F8"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'cmbTemperature
        '
        Me.cmbTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTemperature.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbTemperature.FormattingEnabled = True
        Me.cmbTemperature.IntegralHeight = False
        Me.cmbTemperature.ItemHeight = 18
        Me.cmbTemperature.Location = New System.Drawing.Point(101, 18)
        Me.cmbTemperature.Name = "cmbTemperature"
        Me.cmbTemperature.Size = New System.Drawing.Size(64, 26)
        Me.cmbTemperature.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(325, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Model"
        '
        'cmbModel
        '
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(377, 18)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(152, 26)
        Me.cmbModel.TabIndex = 2
        '
        'btnClearAnswer
        '
        Me.btnClearAnswer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearAnswer.BackColor = System.Drawing.Color.SeaGreen
        Me.btnClearAnswer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearAnswer.FlatAppearance.BorderSize = 0
        Me.btnClearAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAnswer.ForeColor = System.Drawing.Color.White
        Me.btnClearAnswer.Location = New System.Drawing.Point(870, 352)
        Me.btnClearAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClearAnswer.Name = "btnClearAnswer"
        Me.btnClearAnswer.Size = New System.Drawing.Size(130, 34)
        Me.btnClearAnswer.TabIndex = 6
        Me.btnClearAnswer.Text = "Clear Answer"
        Me.btnClearAnswer.UseVisualStyleBackColor = False
        '
        'chkEnter
        '
        Me.chkEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkEnter.AutoSize = True
        Me.chkEnter.Checked = True
        Me.chkEnter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnter.Location = New System.Drawing.Point(7, 377)
        Me.chkEnter.Name = "chkEnter"
        Me.chkEnter.Size = New System.Drawing.Size(219, 22)
        Me.chkEnter.TabIndex = 7
        Me.chkEnter.Text = "Press Enter to send question."
        Me.chkEnter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtAnswer)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1001, 298)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Answer "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtQuestion)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 396)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(998, 138)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Question "
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.txtUserID)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtMaxTokens)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbTemperature)
        Me.GroupBox3.Controls.Add(Me.cmbModel)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1001, 52)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " API Setup "
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gold
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(868, 12)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Program F10"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmChatGPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 578)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkEnter)
        Me.Controls.Add(Me.btnClearAnswer)
        Me.Controls.Add(Me.btnSend)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(876, 612)
        Me.Name = "frmChatGPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat GPT Demo with VB.Net (2017) - Modified by : Thongkorn Tubtimkrob"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaxTokens As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents cmbTemperature As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents btnClearAnswer As Button
    Friend WithEvents chkEnter As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
End Class
