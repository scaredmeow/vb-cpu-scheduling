﻿Public Class frmDisplay
    Private input As String
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        input = InputBox("How many process do you want to enter?", "CPU Scheduling Algorithms")

        If Integer.TryParse(input, Main.process_count) Then
            If Main.process_count > 0 Then
                frmProcess.Close()
                Main.default_task = 0
                Main.Display_On_MainScreen(frmProcess)
            Else
                MsgBox("Please enter a number greater than zero (0)", MsgBoxStyle.Exclamation, "Error")
            End If
        Else
            MsgBox("Please enter a valid number", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
End Class