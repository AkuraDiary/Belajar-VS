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

        TextBoxOutput.Text = txtOutput

    End Sub
End Class
