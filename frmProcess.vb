Public Class frmProcess
    Public arrival_time(), burst_time(), priority_list() As TextBox
    Private Sub Processes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim process_count As Integer = Main.process_count - 1
        Dim loc_x, loc_y, txtLoc_y, y_interval, x_interval, index As New Integer
        Dim lblProcess(Main.process_count)

        loc_x = 20
        loc_y = 40
        txtLoc_y = loc_y
        y_interval = 25
        x_interval = 90

        For index = 0 To process_count
            lblProcess(index) = New Label
            With lblProcess(index)
                .Size = New Size(30, 20)
                .Location = New Point(10, loc_y + 3)
                .Text = (Chr(Asc("a") + index))
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

        Select Case Main.default_task
            Case 0
                arrival_time = Create_TextBox(process_count, loc_x:=loc_x, loc_y:=txtLoc_y, y_interval:=y_interval)
                burst_time = Create_TextBox(process_count, loc_x:=loc_x * 2 + x_interval, loc_y:=txtLoc_y, y_interval:=y_interval)
            Case 1
                arrival_time = Display_TextBox(process_count, Main.arrival_time, loc_x:=loc_x, loc_y:=txtLoc_y, y_interval:=y_interval)
                burst_time = Display_TextBox(process_count, Main.burst_time, loc_x:=loc_x * 2 + x_interval, loc_y:=txtLoc_y, y_interval:=y_interval)
                priority_list = Create_TextBox(process_count, loc_x:=loc_x * 3 + x_interval * 2, loc_y:=txtLoc_y, y_interval:=y_interval)

                Dim lblCPUProcess = New Label
                With lblCPUProcess
                    .Size = New Size(63, 13)
                    .Location = New Point(260, 15)
                    .Text = "CPU Priority"
                End With

                Controls.Add(lblCPUProcess)

        End Select

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case Main.default_task
            Case 0
                ReDim Main.arrival_time(Main.process_count - 1)
                ReDim Main.burst_time(Main.process_count - 1)
                For index As Integer = 0 To Main.process_count - 1
                    If Integer.TryParse(arrival_time(index).Text, Main.arrival_time(index)) And Integer.TryParse(burst_time(index).Text, Main.burst_time(index)) Then
                        If Main.arrival_time(index) < 0 Then
                            MsgBox("Please enter a valid positive arrival time", MsgBoxStyle.Exclamation, "Error")
                            Exit Sub
                        ElseIf Main.burst_time(index) < 0 Then
                            MsgBox("Please enter a valid positive burst time", MsgBoxStyle.Exclamation, "Error")
                            Exit Sub
                        ElseIf Main.burst_time(index) < 1 Then
                            MsgBox("Please enter a non-zero burst time", MsgBoxStyle.Exclamation, "Error")
                            Exit Sub
                        Else
                            Main.arrival_time(index) = arrival_time(index).Text
                            Main.burst_time(index) = burst_time(index).Text
                            Main.Display_On_MainScreen(frmMenu)
                        End If
                    Else
                        MsgBox("Please enter a valid number", MsgBoxStyle.Exclamation, "Error")
                        Exit Sub
                    End If
                Next
            Case 1
                ReDim Preserve Main.arrival_time(Main.process_count - 1)
                ReDim Preserve Main.burst_time(Main.process_count - 1)
                ReDim Main.priority_list(Main.process_count - 1)
                For index As Integer = 0 To Main.process_count - 1
                    Main.arrival_time(index) = arrival_time(index).Text
                    Main.burst_time(index) = burst_time(index).Text
                    Main.priority_list(index) = priority_list(index).Text
                Next
        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case Main.default_task
            Case 0
                Close()

            Case 1
                Close()
        End Select
        Main.Display_On_MainScreen(frmDisplay)

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
                .Size = New Size(100, 20)
                .Location = New Point(loc_x + x_interval, loc_y)
                .Text = txtBox_values(index).ToString
            End With
            loc_y += y_interval
            Controls.Add(txtBox(index))
        Next
        Return txtBox.Cast(Of TextBox).ToArray()
    End Function

End Class