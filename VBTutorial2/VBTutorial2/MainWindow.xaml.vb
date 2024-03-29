﻿Class MainWindow
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

        Dim randInt As Integer = 10
        randInt += 10
        txtOutput &= "10 + 10 = " & randInt & Environment.NewLine

        randInt *= 0.13
        txtOutput &= "20 * .13 = " & randInt & Environment.NewLine

        Dim someString As String = "This is a string"
        txtOutput &= "someString length = " & someString.Length & Environment.NewLine

        txtOutput &= "1st 3 letters = " & someString.Substring(0, 3) & Environment.NewLine

        someString = someString.Replace("string", "sentence")
        txtOutput &= "Changed String = " & someString & Environment.NewLine

        Dim decRandNum As Decimal = 3123.14159
        txtOutput &= "Value = " & String.Format("{0:n3}", decRandNum) & Environment.NewLine

        txtOutput &= "Currency = " & String.Format("{0:c}", decRandNum) & Environment.NewLine

        txtOutput &= "Random = " & String.Format("{0:0000.0}", decRandNum) & Environment.NewLine

        txtOutput &= "is in String = " & InStr(1, someString, "i", CompareMethod.Text) & Environment.NewLine

        'arrays
        Dim arrayEmployees(0 To 2) As String
        arrayEmployees(0) = "Bob"
        arrayEmployees(1) = "Sally"
        arrayEmployees(2) = "Paul"

        Dim strEmployees As String = Join(arrayEmployees, ", ")

        txtOutput &= "Employees = " & strEmployees & Environment.NewLine

        arrayEmployees = Split(strEmployees, ", ")

        'accessing value trough loop
        For i As Integer = 0 To arrayEmployees.Length - 1
            txtOutput &= "Employee = " & arrayEmployees(i) & Environment.NewLine
        Next

        'left right, up low, reverse
        txtOutput &= "Left 3 = " & Strings.Left(someString, 3) & Environment.NewLine
        txtOutput &= "Right 3 = " & Strings.Right(someString, 3) & Environment.NewLine
        txtOutput &= "Uppercase = " & Strings.UCase(someString) & Environment.NewLine
        txtOutput &= "Lowercase = " & Strings.LCase(someString) & Environment.NewLine
        txtOutput &= "Reverse = " & Strings.StrReverse(someString) & Environment.NewLine

        'comparing
        txtOutput &= "Dog Compared to Cat = " & StrComp("Dog", "Cat", CompareMethod.Text) & Environment.NewLine

        txtOutput &= "Trim = " & Trim("   String   ") & Environment.NewLine

        'Dates

        Dim dteCurrent As Date = Now

        txtOutput &= "Day = " & dteCurrent.Day & Environment.NewLine
        txtOutput &= "Day = " & dteCurrent.ToString("dddd") & Environment.NewLine

        txtOutput &= "Month = " & dteCurrent.Month & Environment.NewLine
        txtOutput &= "Month = " & dteCurrent.ToString("MMMM") & Environment.NewLine

        txtOutput &= "Year = " & dteCurrent.Year & Environment.NewLine

        txtOutput &= "Hour  = " & dteCurrent.Hour & Environment.NewLine

        txtOutput &= "Minute = " & dteCurrent.Minute & Environment.NewLine

        txtOutput &= "Second = " & dteCurrent.Second & Environment.NewLine

        Dim dteVerryImportantdate As Date = #06/06/2005#
        txtOutput &= "Important Date to long time string (will be 00:00:00 because i don't define it)= " &
            dteVerryImportantdate.ToLongTimeString &
            Environment.NewLine &
        "Important Date to long date string= " & dteVerryImportantdate.ToLongDateString &
            Environment.NewLine

        ShowMessages()

        txtOutput &= "6 + 5 = " & GetSum(6, 5) & Environment.NewLine

        Dim intVal As Integer = 10

        ChangeVal(intVal)

        txtOutput &= "intVal out of func 1 = " & intVal & Environment.NewLine

        txtOutput &= "1 + 2 + 3 + 4 = " & getSumMore(1, 2, 3, 4) & Environment.NewLine

        TextBox1.Text = txtOutput

    End Sub

    'this is subroutine (it doesn't return a value)
    Private Sub ShowMessages()
        MessageBox.Show("Love You", "Hello Again")
    End Sub

    'this is a function, yes, it's returns a value
    Private Function GetSum(num1 As Integer, num2 As Integer)
        Return num1 + num2
    End Function

    Private Sub ChangeVal(ByRef intval As Integer)
        'ByRef is used to actually passed the variable itself and not the value of the var
        intval = 30
        MessageBox.Show("intVal in Func1 = " & intval & Environment.NewLine)
    End Sub

    ' args* parameter (we don't know how much the parameter is)
    Private Function getSumMore(ByVal ParamArray Numbers() As Integer)
        Dim sum As Integer = 0

        For i As Integer = 0 To Numbers.Length
            sum += i
        Next

        Return sum
    End Function

End Class
