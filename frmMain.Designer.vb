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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlButtonScreen.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(67, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 49)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(67, 476)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 67)
        Me.Panel2.TabIndex = 9
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
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pnlMainScreen As Panel
    Friend WithEvents btnHome As Button
    Public WithEvents pnlButtonScreen As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSource As Button
End Class
