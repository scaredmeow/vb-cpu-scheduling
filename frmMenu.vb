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

        For index As Integer = 0 To queueProcess.Count - 1
            MsgBox(queueProcess(index) & ": " & queueTime(index))
        Next
        For index As Integer = 0 To Main.process_count - 1
            MsgBox(Chr(Asc("a") + index) & ": " & Main.completion_time(index) & "-" & Main.turnaround_time(index) & "-" & Main.waiting_time(index))
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


        If current_time < arrival.Min Then
            queueProcess.Add("idle")
            current_time = arrival.Min
            queueTime.Add(current_time)
        End If

        Dim tempBurst, tempArrival, tempIndex As New Integer

        tempBurst = 0
        tempArrival = 0
        tempIndex = 0

        If count_arrival(arrival.Min) = 1 Then
            queueProcess.Add(Chr(Asc("a") + arrival.IndexOf(arrival.Min)))
            current_time += burst(arrival.IndexOf(arrival.Min))
            queueTime.Add(current_time)
            burst(arrival.IndexOf(arrival.Min)) = Nothing
            arrival(arrival.IndexOf(arrival.Min)) = Nothing
        Else
            tempArrival = arrival.Min
            tempBurst = burst.Max
            Dim index As Integer = 0
            For Each i In arrival
                If i = tempArrival And tempBurst > burst(index) Then
                    tempBurst = burst(index)
                    tempIndex = index
                End If
                index += 1
            Next
            queueProcess.Add(Chr(Asc("a") + tempIndex))
            current_time += tempBurst
            queueTime.Add(current_time)
            count_arrival(arrival.Min) -= 1
            arrival(tempIndex) = Nothing
            burst(tempIndex) = Nothing
        End If

        Do While arrival.Any(Function(i) i IsNot Nothing)
            tempBurst = 0
            tempArrival = 0
            tempIndex = 0

            If current_time >= arrival.Min Then
                If count_burst(burst.Min) = 1 Then
                    queueProcess.Add(Chr(Asc("a") + burst.IndexOf(burst.Min)))
                    current_time += burst(burst.IndexOf(burst.Min))
                    queueTime.Add(current_time)
                    arrival(burst.IndexOf(burst.Min)) = Nothing
                    burst(burst.IndexOf(burst.Min)) = Nothing
                Else
                    tempArrival = arrival.Max
                    tempBurst = burst.Min
                    Dim index As Integer = 0
                    For Each i In burst
                        If i = tempBurst And tempArrival > arrival(index) Then
                            tempArrival = arrival(index)
                            tempIndex = index
                        End If
                        index += 1
                    Next
                    queueProcess.Add(Chr(Asc("a") + tempIndex))
                    current_time += burst(tempIndex)
                    queueTime.Add(current_time)

                    count_burst(burst.Min) -= 1
                    arrival(tempIndex) = Nothing
                    burst(tempIndex) = Nothing
                End If
            Else
                queueProcess.Add("idle")
                current_time = arrival.Min
                queueTime.Add(current_time)
            End If
        Loop

        algoCompute()


    End Sub

    Public Sub algo_SRTF(burst As List(Of Integer?), arrival As List(Of Integer?))
        Dim current_time As Integer = 0
        ReDim Main.completion_time(Main.process_count - 1)
        ReDim Main.turnaround_time(Main.process_count - 1)
        ReDim Main.waiting_time(Main.process_count - 1)
        queueTime.Clear()
        queueProcess.Clear()

        Dim tempBurst, tempArrival, tempIndex As New Integer

        Dim count_burst, count_arrival As New Dictionary(Of Integer, Integer)

        count_burst = Dict_Occurences(burst)
        count_arrival = Dict_Occurences(arrival)

        Do While arrival.Any(Function(i) i IsNot Nothing)
            tempBurst = 0
            tempArrival = 0
            tempIndex = 0

            If current_time >= arrival.Min Then

            Else
                queueProcess.Add("idle")
                current_time = arrival.Min
                queueTime.Add(current_time)
            End If

        Loop

        algoCompute()
    End Sub
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnFCFS_Click(sender As Object, e As EventArgs) Handles btnFCFS.Click
        algo_FCFS(Main.burst_time.Select(Function(i) CType(i, Integer?)).ToList(), Main.arrival_time.Select(Function(i) CType(i, Integer?)).ToList())
    End Sub

    Private Sub btnSJF_Click(sender As Object, e As EventArgs) Handles btnSJF.Click
        algo_SJF(Main.burst_time.Select(Function(i) CType(i, Integer?)).ToList(), Main.arrival_time.Select(Function(i) CType(i, Integer?)).ToList())
    End Sub

    Private Sub btnSRTF_Click(sender As Object, e As EventArgs) Handles btnSRTF.Click
        algo_SRTF(Main.burst_time.Select(Function(i) CType(i, Integer?)).ToList(), Main.arrival_time.Select(Function(i) CType(i, Integer?)).ToList())
    End Sub
End Class