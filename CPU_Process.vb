Public Class CPU_Process
    Public arrival_time(), burst_time(), priority_list() As TextBox
    Private Sub Processes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Main.default_task = 0 Then
            burst_time = Create_TextBox(Main.procces_count - 1)
            arrival_time = Create_TextBox(Main.procces_count - 1, loc_x:=120)
        Else
            Display_TextBox(Main.procces_count - 1, burst_time)
            priority_list = Create_TextBox(Main.procces_count - 1, loc_x:=240)
        End If

    End Sub

    Private Function Create_TextBox(txtBox_count As Integer,
                                    Optional loc_x As Integer = 20,
                                    Optional loc_y As Integer = 20,
                                    Optional y_interval As Integer = 20) As TextBox()
        Dim txtBox(txtBox_count)

        For index As Integer = 0 To txtBox_count
            txtBox(index) = New TextBox
            With txtBox(index)
                .Size = New Size(100, 20)
                .Location = New Point(loc_x, loc_y)
                .Text = ""
            End With
            loc_y += y_interval
            Controls.Add(txtBox(index))
        Next
        Return txtBox.Cast(Of TextBox).ToArray()
    End Function

    Private Sub Display_TextBox(txtBox_count As Integer,
                                txtBox_values() As TextBox,
                                Optional loc_x As Integer = 20,
                                Optional loc_y As Integer = 20,
                                Optional y_interval As Integer = 20)
        Dim txtBox(txtBox_count)

        For index As Integer = 0 To txtBox_count
            txtBox(index) = New TextBox
            With txtBox(index)
                .Size = New Size(100, 20)
                .Location = New Point(loc_x, loc_y)
                .Text = txtBox_values(index).Text
            End With
            loc_y += y_interval
            Controls.Add(txtBox(index))
        Next
    End Sub

End Class