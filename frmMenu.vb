
Public Class frmMenu
    Public queueTime As New List(Of Integer)
    Public queueProcess As New List(Of String)
    Public WithEvents myTimer As New Timer
    Public tickCount As Integer = 0

    Public Sub myTimer_Tick(sender As Object, e As EventArgs) Handles myTimer.Tick
        tickCount += 1
        Main.lblTimer.Text = tickCount
        If queueTime.Contains(tickCount) Then
            Main.lblProcessing.Text = queueProcess(queueTime.IndexOf(tickCount))
        End If

        If tickCount = queueTime(queueTime.Count - 1) Then
            myTimer.Stop()
            Main.lblProcessing.Text = "None"
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case Main.default_task
            Case 0
                Close()
            Case 1
                Close()
        End Select
        Main.Label1.Visible = False
        Main.Label2.Visible = False
        Main.lblProcessing.Visible = False
        Main.lblTimer.Visible = False
        Main.Display_On_MainScreen(frmDisplay)
    End Sub

    Private Function Dict_Occurences(list_to_check As List(Of Integer?)) As Dictionary(Of Integer, Integer)
        Dim counts As New Dictionary(Of Integer, Integer)

        For Each value In list_to_check
            If Not IsNothing(value) Then
                If counts.ContainsKey(value) Then
                    counts(value) += 1
                Else
                    counts.Add(value, 1)
                End If
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



        'For index As Integer = 0 To queueProcess.Count - 1
        '    MsgBox(queueProcess(index) & ": " & queueTime(index))
        'Next
        'For index As Integer = 0 To Main.process_count - 1
        '    MsgBox(Chr(Asc("a") + index) & ": " & Main.completion_time(index) & "-" & Main.turnaround_time(index) & "-" & Main.waiting_time(index))
        'Next
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

        display()

    End Sub

    Sub display()
        frmOutput.Close()
        Main.Display_On_MainScreen(frmOutput)
        frmOutput.Show()
        frmOutput.lblTurnaround.Text = Main.turnaround_time.Average
        frmOutput.lblWaitingTime.Text = Main.waiting_time.Average

        Main.lblTimer.Text = 0
        Main.lblProcessing.Text = "Idle"
        Main.Label1.Visible = True
        Main.Label2.Visible = True
        Main.lblProcessing.Visible = True
        Main.lblTimer.Visible = True
        myTimer.Interval = 1000
        myTimer.Start()
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
            arrival(tempIndex) = Nothing
            burst(tempIndex) = Nothing
        End If
        count_burst = Dict_Occurences(burst)
        count_arrival = Dict_Occurences(arrival)

        Do While arrival.Any(Function(i) i IsNot Nothing)
            tempBurst = 0
            tempArrival = 0
            tempIndex = 0

            Dim curr_min As Integer = burst.Max

            If current_time >= burst.Min Then
                Dim sortedlist As List(Of Integer) = count_burst.Keys.ToList()
                sortedlist.Sort()

                For Each i In sortedlist
                    If arrival(burst.IndexOf(i)) <= current_time And i < curr_min Then
                        curr_min = i
                    End If
                Next

                If count_burst(curr_min) = 1 Then
                    queueProcess.Add(Chr(Asc("a") + burst.IndexOf(curr_min)))
                    current_time += burst(burst.IndexOf(curr_min))
                    queueTime.Add(current_time)
                    arrival(burst.IndexOf(curr_min)) = Nothing
                    burst(burst.IndexOf(curr_min)) = Nothing
                Else
                    tempArrival = arrival.Max
                    tempBurst = curr_min
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
                    arrival(tempIndex) = Nothing
                    burst(tempIndex) = Nothing
                End If
            Else
                queueProcess.Add("idle")
                current_time = arrival.Min
                queueTime.Add(current_time)
            End If
            count_burst = Dict_Occurences(burst)
            count_arrival = Dict_Occurences(arrival)
        Loop
        algoCompute()
        display()
    End Sub
    Public Sub algo_SRTF(burst As List(Of Integer?), arrival As List(Of Integer?))
        Dim current_time As Integer = 0
        ReDim Main.completion_time(Main.process_count - 1)
        ReDim Main.turnaround_time(Main.process_count - 1)
        ReDim Main.waiting_time(Main.process_count - 1)
        queueTime.Clear()
        queueProcess.Clear()

        Dim tempBurst, tempArrival, tempIndex, checkBurst, checkArrival, checkIndex, flagArrival, flagBurst, flagIndex, remainingTime, timeRange, flag As New Integer

        Dim count_burst, count_arrival As New Dictionary(Of Integer, Integer)

        count_burst = Dict_Occurences(burst)
        count_arrival = Dict_Occurences(arrival)

        Do While arrival.Any(Function(i) i IsNot Nothing)
            tempBurst = 0
            tempArrival = 0
            tempIndex = 0
            remainingTime = 0
            Dim curr_min As Integer = burst.Max

            'For index As Integer = 0 To queueProcess.Count - 1
            '    MsgBox(queueProcess(index) & ": " & queueTime(index))
            'Next

            If current_time >= arrival.Min Then
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
                MsgBox(timeRange & ": " & flagBurst & ": " & current_time)

                'If current_time <= tempArrival Then 'if current time is less than the arrival time of the process
                '    timeRange = tempArrival + tempBurst
                'Else
                '    timeRange = tempBurst + current_time
                'End If


                flagIndex = 0
                index = 0
                flagBurst = tempBurst
                flagArrival = tempArrival

                'For Each i In arrival
                '    If i <= timeRange Then
                '        If burst(index) < flagBurst Then
                '            flagBurst = burst(index)
                '            flagArrival = arrival(index)
                '            flagIndex = index
                '        End If
                '    End If
                '    index += 1
                'Next

                checkArrival = arrival.Max
                index = 0
                For Each i In arrival
                    If i < checkArrival And i <> tempArrival Then
                        checkArrival = i
                        checkBurst = burst(index)
                        checkIndex = index
                    End If
                    index += 1
                Next



                If checkArrival > current_time Then
                    remainingTime = tempBurst - (checkArrival - current_time)
                    If remainingTime > checkBurst Then
                        queueProcess.Add(Chr(Asc("a") + tempIndex))
                        current_time += tempBurst - remainingTime
                        queueTime.Add(current_time)
                        burst(tempIndex) = tempBurst - remainingTime
                    Else
                        queueProcess.Add(Chr(Asc("a") + tempIndex))
                        current_time += tempBurst
                        queueTime.Add(current_time)
                        arrival(tempIndex) = Nothing
                        burst(tempIndex) = Nothing
                    End If
                    'ElseIf timeRange - flagBurst < current_time Then
                    '    queueProcess.Add(Chr(Asc("a") + flagIndex))
                    '    current_time += flagBurst
                    '    queueTime.Add(current_time)
                    '    arrival(flagIndex) = Nothing
                    '    burst(flagIndex) = Nothing

                Else

                    Dim sortedlist As List(Of Integer) = count_burst.Keys.ToList()
                    sortedlist.Sort()
                    For Each i In sortedlist
                        If arrival(burst.IndexOf(i)) <= current_time And i < curr_min Then
                            curr_min = i
                        End If
                    Next

                    If count_burst(curr_min) = 1 Then
                        queueProcess.Add(Chr(Asc("a") + burst.IndexOf(curr_min)))
                        current_time += burst(burst.IndexOf(curr_min))
                        queueTime.Add(current_time)
                        arrival(burst.IndexOf(curr_min)) = Nothing
                        burst(burst.IndexOf(curr_min)) = Nothing
                    Else
                        tempArrival = arrival.Max
                        tempBurst = curr_min
                        index = 0
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
                        arrival(tempIndex) = Nothing
                        burst(tempIndex) = Nothing
                    End If
                End If


                'MsgBox(remainingTime & ":  " & tempBurst & ":  " & checkArrival & ":  " & current_time & ": -- " & tempIndex)

                count_burst = Dict_Occurences(burst)
                count_arrival = Dict_Occurences(arrival)
            Else
                queueProcess.Add("idle")
                current_time = arrival.Min
                queueTime.Add(current_time)
            End If
        Loop

        algoCompute()
        display()



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