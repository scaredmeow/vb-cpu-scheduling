<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.pnlMainScreen = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlButtonScreen = New System.Windows.Forms.Panel()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProcessing = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlButtonScreen.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainScreen
        '
        Me.pnlMainScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMainScreen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMainScreen.Location = New System.Drawing.Point(50, 31)
        Me.pnlMainScreen.Name = "pnlMainScreen"
        Me.pnlMainScreen.Size = New System.Drawing.Size(470, 315)
        Me.pnlMainScreen.TabIndex = 4
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHome.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Location = New System.Drawing.Point(15, 10)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(120, 50)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'pnlButtonScreen
        '
        Me.pnlButtonScreen.BackColor = System.Drawing.Color.Transparent
        Me.pnlButtonScreen.Controls.Add(Me.btnSource)
        Me.pnlButtonScreen.Controls.Add(Me.btnExit)
        Me.pnlButtonScreen.Controls.Add(Me.btnHome)
        Me.pnlButtonScreen.Location = New System.Drawing.Point(388, 388)
        Me.pnlButtonScreen.Name = "pnlButtonScreen"
        Me.pnlButtonScreen.Size = New System.Drawing.Size(150, 190)
        Me.pnlButtonScreen.TabIndex = 7
        '
        'btnSource
        '
        Me.btnSource.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSource.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSource.Location = New System.Drawing.Point(15, 130)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(120, 50)
        Me.btnSource.TabIndex = 8
        Me.btnSource.Text = "Source Code"
        Me.btnSource.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(15, 70)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 50)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblProcessing)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(67, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 49)
        Me.Panel1.TabIndex = 8
        '
        'lblProcessing
        '
        Me.lblProcessing.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessing.Location = New System.Drawing.Point(197, 12)
        Me.lblProcessing.Name = "lblProcessing"
        Me.lblProcessing.Size = New System.Drawing.Size(76, 25)
        Me.lblProcessing.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Currently Processing:"
        Me.Label2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTimer)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(67, 476)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 67)
        Me.Panel2.TabIndex = 9
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(44, 19)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(44, 40)
        Me.lblTimer.TabIndex = 1
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Timer"
        Me.Label1.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(574, 646)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlButtonScreen)
        Me.Controls.Add(Me.pnlMainScreen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CPU Scheduling"
        Me.pnlButtonScreen.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pnlMainScreen As Panel
    Friend WithEvents btnHome As Button
    Public WithEvents pnlButtonScreen As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSource As Button
    Friend WithEvents lblProcessing As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents Label1 As Label
End Class
