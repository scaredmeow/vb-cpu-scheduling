Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Main
    Public procces_count As Integer = 1
    Public default_task As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim processes_number As String =
        '    InputBox("Please enter the desired number of processes", "CPU Scheduling")

        'MessageBox.Show("You Inputted " & processes_number, "Input",
        '                MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1,
        '                MessageBoxOptions.RightAlign)



        'Dim a As String = "1,2,3,4,5,6,7"
        'Dim arary As String() = a.Split(",")

        'ReDim Preserve arary(6)
        'arary.Append(3)
        'MsgBox(arary(4))



    End Sub
    'Friend Sub MyTextbox_Changed(sender As Object, e As EventArgs)
    'Write code here.
    'End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CPU_Process.Close()
        default_task = 1
        Display_On_MainScreen(CPU_Process)
    End Sub

    Sub Display_On_MainScreen(frm As Form)
        pnlMainScreen.Controls.Clear()
        frm.TopLevel = False
        pnlMainScreen.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        procces_count = InputBox("How many process do you want to enter?", "CPU Scheduling Algorithms")
        CPU_Process.Close()
        default_task = 0
        Display_On_MainScreen(CPU_Process)
        Button1.Enabled = True
    End Sub
End Class
