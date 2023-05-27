Public Class Form1

  Private Sub CalculateSSTFButton_Click(sender As Object, e As EventArgs) Handles CalculateSSTFButton.Click
    'Split input using "," 
    Dim _listOfString As String() = InputTextBox.Text.Split(",")
    Dim _listOfInteger As List(Of Integer) = New List(Of Integer)
    OutputTextBox.Text = ""

    'Covert array of string to array of integers
    For i As Integer = 0 To _listOfString.Length - 1
      _listOfInteger.Add(Convert.ToInt32(_listOfString(i)))
    Next

    Dim currentHeadPosition As Integer = HeadPositionInput.Value
    Dim totalSeekTime As Integer = 0

    'While something is yet to be processed
    While _listOfInteger.Count > 0
      Dim minSeekTime As Integer = Int32.MaxValue
      Dim selectedRequest As Integer = -1

      'For each request calculate the seektime
      'Find the lowest seektime
      For Each request As Integer In _listOfInteger
        'Calculate seek time
        Dim seekTime As Integer = Math.Abs(currentHeadPosition - request)
        If seekTime < minSeekTime Then
          minSeekTime = seekTime
          selectedRequest = request
        End If
      Next

      'Increase total seek time
      totalSeekTime += minSeekTime
      'Set selected request as the current position
      currentHeadPosition = selectedRequest
      'Remove request from the list
      _listOfInteger.Remove(selectedRequest)

      'Output Processing
      OutputTextBox.Text += selectedRequest.ToString
      If _listOfInteger.Count <> 0 Then
        OutputTextBox.Text += " -> "
      End If
    End While

    'Run function to calculate SSTF
    OutputTextBox.Text += Environment.NewLine & Environment.NewLine & "Total Seek Time: " & totalSeekTime
  End Sub
End Class
