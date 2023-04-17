Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Main
    Public process_count As Integer = 1
    Public default_task As Integer = 0
    Public arrival_time(), burst_time(), priority_list() As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_On_MainScreen(Display_Screen)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CPU_Process.Close()
        default_task = 1
        Display_On_MainScreen(CPU_Process)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Display_Screen.Hide()
        Display_On_MainScreen(Display_Screen)
    End Sub



    Public Sub Display_On_MainScreen(frm As Form)
        pnlMainScreen.Controls.Clear()
        frm.TopLevel = False
        pnlMainScreen.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        process_count = InputBox("How many process do you want to enter?", "CPU Scheduling Algorithms")
        CPU_Process.Close()
        default_task = 0
        Display_On_MainScreen(CPU_Process)
        Button1.Enabled = False
    End Sub
End Class
