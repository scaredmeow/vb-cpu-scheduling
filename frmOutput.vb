Public Class frmOutput
    Public arrival_time(), burst_time(), priority_list() As TextBox
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case Main.default_task
            Case 0
                Close()
            Case 1
                Close()
        End Select
        Main.Display_On_MainScreen(frmMenu)
        frmMenu.myTimer.Stop()
    End Sub

    Private Sub frmOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim process_count As Integer = Main.process_count - 1
        Dim loc_x, loc_y, txtLoc_y, y_interval, x_interval, index As New Integer
        Dim lblProcess(Main.process_count)

        loc_x = 20
        loc_y = 40
        txtLoc_y = loc_y
        y_interval = 25
        x_interval = 30

        For index = 0 To process_count
            lblProcess(index) = New Label
            With lblProcess(index)
                .Size = New Size(30, 20)
                .Location = New Point(10, loc_y + 3)
                .Text = (index + 1).ToString
            End With
            loc_y += y_interval
            Controls.Add(lblProcess(index))
        Next

        lblProcess(index) = New Label
        With lblProcess(index)
            .Size = New Size(20, 30)
            .Location = New Point(10, loc_y)
            .Text = ""
        End With

        Controls.Add(lblProcess(index))

        arrival_time = Display_TextBox(process_count, Main.arrival_time, loc_x:=loc_x, loc_y:=txtLoc_y, y_interval:=y_interval)
        burst_time = Display_TextBox(process_count, Main.burst_time, loc_x:=loc_x * 2.5 + x_interval, loc_y:=txtLoc_y, y_interval:=y_interval)
        burst_time = Display_TextBox(process_count, Main.completion_time, loc_x:=loc_x * 6 + x_interval, loc_y:=txtLoc_y, y_interval:=y_interval)
        burst_time = Display_TextBox(process_count, Main.turnaround_time, loc_x:=loc_x * 10 + x_interval, loc_y:=txtLoc_y, y_interval:=y_interval)
        burst_time = Display_TextBox(process_count, Main.waiting_time, loc_x:=loc_x * 14 + x_interval, loc_y:=txtLoc_y, y_interval:=y_interval)
    End Sub

    Private Function Create_TextBox(txtBox_count As Integer,
                                Optional loc_x As Integer = 20,
                                Optional loc_y As Integer = 20,
                                Optional y_interval As Integer = 20,
                                Optional x_interval As Integer = 20) As TextBox()
        Dim txtBox(txtBox_count)

        For index As Integer = 0 To txtBox_count
            txtBox(index) = New TextBox
            With txtBox(index)
                .Size = New Size(100, 20)
                .Location = New Point(loc_x + x_interval, loc_y)
                .Text = ""
            End With
            loc_y += y_interval
            Controls.Add(txtBox(index))
        Next
        Return txtBox.Cast(Of TextBox).ToArray()
    End Function

    Private Function Display_TextBox(txtBox_count As Integer,
                                txtBox_values() As Integer,
                                Optional loc_x As Integer = 20,
                                Optional loc_y As Integer = 20,
                                Optional y_interval As Integer = 20,
                                Optional x_interval As Integer = 20) As TextBox()
        Dim txtBox(txtBox_count)

        For index As Integer = 0 To txtBox_count
            txtBox(index) = New TextBox
            With txtBox(index)
                .Size = New Size(40, 20)
                .Location = New Point(loc_x + x_interval, loc_y)
                .Text = txtBox_values(index).ToString
            End With
            loc_y += y_interval
            Controls.Add(txtBox(index))
        Next
        Return txtBox.Cast(Of TextBox).ToArray()
    End Function
End Class