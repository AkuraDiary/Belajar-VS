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
End Class
