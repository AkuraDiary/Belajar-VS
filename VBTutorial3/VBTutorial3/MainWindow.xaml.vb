Class MainWindow
    Private Sub BtnUpdate_Click(sender As Object, e As RoutedEventArgs) Handles BtnUpdate.Click
        Dim txtOutput As String = ""

        Dim intAge As Integer = 7

        ' = <> < >
        ' this is single line if statement, not a ternary
        If intAge < 18 Then txtOutput &= "You Can't vote" & Environment.NewLine : 
        txtOutput &= "You can vote in" & 18 - intAge & " years" & Environment.NewLine

        'normal if statement
        If intAge < 5 Then
            txtOutput &= "Too young for school" &
                Environment.NewLine
        ElseIf intAge = 5 Then
            txtOutput &= "Go To Kindergarten" &
                Environment.NewLine

        ElseIf intAge > 5 And intAge < 18 Then
            Dim intGrade = intAge - 5
            txtOutput &= "Go To Grade " & intGrade &
                Environment.NewLine
        Else
            txtOutput &= "Go To College" &
                Environment.NewLine
        End If

        Dim strName As String = "Derek"

        If String.Compare("DEREK", strName, True) = 0 Then
            txtOutput &= "These Strings are equal" &
                Environment.NewLine
        End If

        Select Case intAge
            Case 1, 2, 3, 4
                txtOutput &= "Too young for school" &
                Environment.NewLine
            Case 5
                txtOutput &= "Go To Kindergarten" &
                Environment.NewLine
            Case 6 To 18
                Dim intGrade = intAge - 5
                txtOutput &= "Go To Grade " & intGrade &
                    Environment.NewLine
            Case Else
                txtOutput &= "Go to College" & Environment.NewLine
        End Select

        Dim boolCanVote As Boolean = If(intAge >= 18, True, False) 'ternary operator

        txtOutput &= "Can You Vote : " & boolCanVote & Environment.NewLine

        TextBoxOutput.Text = txtOutput

    End Sub
End Class
