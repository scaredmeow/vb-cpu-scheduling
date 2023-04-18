Public Class frmMenu
    Public queueTime As New List(Of Integer)
    Public queueProcess As New List(Of String)

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case Main.default_task
            Case 0
                Close()
            Case 1
                Close()
        End Select
        Main.Display_On_MainScreen(frmDisplay)
    End Sub

    Private Function Dict_Occurences(list_to_check As List(Of Integer?)) As Dictionary(Of Integer, Integer)
        Dim counts As New Dictionary(Of Integer, Integer)

        For Each value In list_to_check
            If counts.ContainsKey(value) Then
                counts(value) += 1
            Else
                counts.Add(value, 1)
            End If
        Next
        Return counts
    End Function

    Private Sub algoCompute()
        For index As Integer = 0 To Main.process_count - 1
            Dim temp As Integer = index
            Dim tempComplete As Integer = queueTime(
                queueProcess.FindLastIndex(Function(value) value = Chr(Asc("a") + temp)))
            Main.completion_time(index) = tempComplete
            Main.turnaround_time(index) = tempComplete - Main.arrival_time(index)
            Main.waiting_time(index) = tempComplete - Main.arrival_time(index) - Main.burst_time(index)
        Next
    End Sub

    Public Sub algo_FCFS(burst As List(Of Integer?), arrival As List(Of Integer?))
        Dim current_time As Integer = 0
        ReDim Main.completion_time(Main.process_count - 1)
        ReDim Main.turnaround_time(Main.process_count - 1)
        ReDim Main.waiting_time(Main.process_count - 1)
        queueTime.Clear()
        queueProcess.Clear()

        Do While arrival.Any(Function(i) i IsNot Nothing)
            If current_time >= arrival.Min Then
                queueProcess.Add(Chr(Asc("a") + arrival.IndexOf(arrival.Min)))
                current_time += burst(arrival.IndexOf(arrival.Min))
                queueTime.Add(current_time)
                arrival(arrival.IndexOf(arrival.Min)) = Nothing
            Else
                queueProcess.Add("idle")
                current_time = arrival.Min
                queueTime.Add(current_time)
            End If
        Loop

        algoCompute()

        For index As Integer = 0 To queueProcess.Count - 1
            MsgBox(queueProcess(index) & ": " & queueTime(index))
        Next
        For index As Integer = 0 To Main.process_count - 1
            MsgBox(Chr(Asc("a") + index) & ": " & Main.completion_time(index) & "-" & Main.turnaround_time(index) & "-" & Main.waiting_time(index))
        Next
    End Sub

    Public Sub algo_SJF(burst As List(Of Integer?), arrival As List(Of Integer?))
        Dim current_time As Integer = 0
        ReDim Main.completion_time(Main.process_count - 1)
        ReDim Main.turnaround_time(Main.process_count - 1)
        ReDim Main.waiting_time(Main.process_count - 1)
        queueTime.Clear()
        queueProcess.Clear()

        Dim count_burst, count_arrival As New Dictionary(Of Integer, Integer)

        count_burst = Dict_Occurences(burst)
        count_arrival = Dict_Occurences(arrival)


        Do While arrival.Any(Function(i) i IsNot Nothing)
            If current_time >= arrival.Min Then

            End If
            If count_burst(burst.Min) = 1 Then
                queueProcess.Add(Chr(Asc("a") + burst.IndexOf(burst.Min)))
                current_time += burst(arrival.IndexOf(arrival.Min))
                queueTime.Add(current_time)
                arrival(arrival.IndexOf(arrival.Min)) = Nothing
            End If
        Loop

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnFCFS_Click(sender As Object, e As EventArgs) Handles btnFCFS.Click
        algo_FCFS(Main.burst_time.Select(Function(i) CType(i, Integer?)).ToList(), Main.arrival_time.Select(Function(i) CType(i, Integer?)).ToList())
    End Sub

    Private Sub btnSJF_Click(sender As Object, e As EventArgs) Handles btnSJF.Click
        algo_SJF(Main.burst_time.Select(Function(i) CType(i, Integer?)).ToList(), Main.arrival_time.Select(Function(i) CType(i, Integer?)).ToList())
    End Sub
End Class