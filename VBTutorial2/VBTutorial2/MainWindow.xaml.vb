Class MainWindow
    Private Sub btnUpdate_Click(sender As Object, e As RoutedEventArgs) Handles btnUpdate.Click
        Dim txtOutput As String = "Abs(-19) = " & Math.Abs(-19) & Environment.NewLine

        txtOutput &= "Ceiling(4.5) = " & Math.Ceiling(4.5) & Environment.NewLine

        ' 2.718 e raised to the specified power
        txtOutput &= "Exp(1) = " & Math.Exp(1) & Environment.NewLine

        ' Return the natural log
        txtOutput &= "Log(2.718) = " & Math.Log(2.718) & Environment.NewLine

        ' Return base 10 log
        txtOutput &= "Log10(3000) = " & Math.Log10(3000) & Environment.NewLine

        ' Return the larger number
        txtOutput &= "Max(5,4) = " & Math.Max(5, 4) & Environment.NewLine

        ' Return the smaller number
        txtOutput &= "Min(5,4) = " & Math.Min(5, 4) & Environment.NewLine

        ' Return the number to the power of number
        txtOutput &= "Pow(5,2) = " & Math.Pow(5, 2) & Environment.NewLine

        ' Return the sqrt
        txtOutput &= "Sqrt(25) = " & Math.Sqrt(25) & Environment.NewLine

        ' Round a Decimal or Double
        txtOutput &= "Round(4.5) = " & Math.Round(4.5) & Environment.NewLine



        TextBox1.Text = txtOutput
    End Sub
End Class
