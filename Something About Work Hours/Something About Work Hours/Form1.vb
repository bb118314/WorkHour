Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const intNUM_DAYS As Integer = 5 ' Number of Days
        Dim intCount As Integer = 1 ' Counts Loops
        Dim decSales As Decimal = 0 ' Holds daily sales
        Dim decTotal As Decimal = 0 ' Holds total sales
        Dim strInput As String      ' Holds string input
        Do While intCount <= intNUM_DAYS
            strInput = InputBox("Enter the sales for day " & intCount.ToString())
            If Decimal.TryParse(strInput, decSales) Then
                decTotal += decSales

                intCount += 1
            Else                ' Error Message
                MessageBox.Show("Enter a numeric value")
            End If
        Loop

        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
