Public Class Form1
    Private Sub btcalculate_Click(sender As Object, e As EventArgs) Handles btcalculate.Click
        ' Declare variables to hold the numbers
        Dim num1, num2, sum As Double

        ' Convert the text from Txtnum1 to a number
        If Double.TryParse(Txtnum1.Text, num1) Then
            ' Convert the text from Txtnum2 to a number
            If Double.TryParse(Txtnum2.Text, num2) Then
                ' Calculate the sum
                sum = num1 + num2
                ' Display the sum
                MessageBox.Show("The sum is: " & sum.ToString())
            Else
                MessageBox.Show("Please enter a valid number in Txtnum2")
            End If
        Else
            MessageBox.Show("Please enter a valid number in Txtnum1")
        End If
    End Sub
End Class
