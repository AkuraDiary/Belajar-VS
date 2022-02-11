Class MainWindow
    Private Sub btnOk_Click(sender As Object, e As RoutedEventArgs) Handles btnOk.Click
        txtName.Text = "Hello " & txtName.Text
    End Sub

    Private Sub txtMessage_Click(sender As Object, e As RoutedEventArgs) Handles txtMessage.Click
        MessageBox.Show("Hello " & txtName.Text, "Hello " & txtName.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As RoutedEventArgs) Handles btnAddValues.Click
        Try
            ' This is a comment
            Dim firstNum As Integer = CInt(txtAddVal1.Text)
            Dim secondNum As Integer = CInt(txtAddVal2.Text)
            Dim sum = firstNum + secondNum

            txtSumAnswer.Text = CStr(sum)
            'C(convert)[datatypes]
            'CStr -> String
            'CInt -> Int
            'CBool -> Boolean

        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers to sum", "Error")
            Console.WriteLine("An error occured")
        Catch ex As Exception
            MessageBox.Show("An Unknown error Occured")
        End Try
    End Sub

    Private Sub btnDivideValues_Click(sender As Object, e As RoutedEventArgs) Handles btnDivideValues.Click
        Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
        Dim secondNum As Decimal = CDec(txtDivideVal2.Text)
        Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

        txtDivideAnswer.Text = CStr(intSolution)

    End Sub
End Class
