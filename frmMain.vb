Public Class Main
    Public process_count As Integer = 1
    Public default_task As Integer = 0
    Public arrival_time(), burst_time(), priority_list(),
        completion_time(), turnaround_time(), waiting_time() As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_On_MainScreen(frmDisplay)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmProcess.Close()
        default_task = 1
        Display_On_MainScreen(frmProcess)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Display_On_MainScreen(frmDisplay)
    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        Dim URL As String = "https://github.com/scaredmeow/vb-cpu-scheduling"
        Dim NewProcess As ProcessStartInfo = New ProcessStartInfo(URL)
        NewProcess.UseShellExecute = True
        Process.Start(NewProcess)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub pnlMainScreen_Paint(sender As Object, e As PaintEventArgs) Handles pnlMainScreen.Paint

    End Sub

    Public Sub Display_On_MainScreen(frm As Form)
        pnlMainScreen.Controls.Clear()
        frm.TopLevel = False
        pnlMainScreen.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs)
        process_count = InputBox("How many process do you want to enter?", "CPU Scheduling Algorithms")
        frmProcess.Close()
        default_task = 0
        Display_On_MainScreen(frmProcess)
    End Sub
End Class
