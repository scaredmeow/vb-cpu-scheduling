<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFCFS = New System.Windows.Forms.Button()
        Me.btnSJF = New System.Windows.Forms.Button()
        Me.btnSRTF = New System.Windows.Forms.Button()
        Me.btnPS = New System.Windows.Forms.Button()
        Me.btnRR = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(420, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 62)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To start simulating please select an appropriate algorithm to show in the screen"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFCFS
        '
        Me.btnFCFS.BackColor = System.Drawing.Color.AliceBlue
        Me.btnFCFS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFCFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFCFS.Location = New System.Drawing.Point(145, 125)
        Me.btnFCFS.Name = "btnFCFS"
        Me.btnFCFS.Size = New System.Drawing.Size(180, 23)
        Me.btnFCFS.TabIndex = 4
        Me.btnFCFS.Text = "First Come First Serve"
        Me.btnFCFS.UseVisualStyleBackColor = False
        '
        'btnSJF
        '
        Me.btnSJF.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSJF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSJF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSJF.Location = New System.Drawing.Point(145, 154)
        Me.btnSJF.Name = "btnSJF"
        Me.btnSJF.Size = New System.Drawing.Size(180, 23)
        Me.btnSJF.TabIndex = 5
        Me.btnSJF.Text = "Shortest Job First"
        Me.btnSJF.UseVisualStyleBackColor = False
        '
        'btnSRTF
        '
        Me.btnSRTF.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSRTF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSRTF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSRTF.Location = New System.Drawing.Point(145, 183)
        Me.btnSRTF.Name = "btnSRTF"
        Me.btnSRTF.Size = New System.Drawing.Size(180, 23)
        Me.btnSRTF.TabIndex = 6
        Me.btnSRTF.Text = "Shortest Remaining Time First"
        Me.btnSRTF.UseVisualStyleBackColor = False
        '
        'btnPS
        '
        Me.btnPS.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPS.Enabled = False
        Me.btnPS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPS.Location = New System.Drawing.Point(145, 212)
        Me.btnPS.Name = "btnPS"
        Me.btnPS.Size = New System.Drawing.Size(180, 23)
        Me.btnPS.TabIndex = 7
        Me.btnPS.Text = "Priority Scheduling"
        Me.btnPS.UseVisualStyleBackColor = False
        '
        'btnRR
        '
        Me.btnRR.BackColor = System.Drawing.Color.AliceBlue
        Me.btnRR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRR.Enabled = False
        Me.btnRR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRR.Location = New System.Drawing.Point(145, 241)
        Me.btnRR.Name = "btnRR"
        Me.btnRR.Size = New System.Drawing.Size(180, 23)
        Me.btnRR.TabIndex = 8
        Me.btnRR.Text = "Round Robin"
        Me.btnRR.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.AliceBlue
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Location = New System.Drawing.Point(145, 270)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(180, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit Processes"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(470, 315)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRR)
        Me.Controls.Add(Me.btnPS)
        Me.Controls.Add(Me.btnSRTF)
        Me.Controls.Add(Me.btnSJF)
        Me.Controls.Add(Me.btnFCFS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFCFS As Button
    Friend WithEvents btnSJF As Button
    Friend WithEvents btnSRTF As Button
    Friend WithEvents btnPS As Button
    Friend WithEvents btnRR As Button
    Friend WithEvents btnEdit As Button
End Class
