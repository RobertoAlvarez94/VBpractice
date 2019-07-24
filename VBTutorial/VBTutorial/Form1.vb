Public Class Form1

    'Intro on how to use design and adding fucntionality to it'
    Private Sub btnMsg_Click(sender As Object, e As EventArgs) Handles btnMsg.Click
        MessageBox.Show("Hello " & txtName.Text,
                        "Hello " & txtName.Text)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        txtName.Text = "Hello " & txtName.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    'event handlers'
    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click
        Try

            'Integer, Long, Decimal, Doubles, Boolean'
            'CInt, CLng, CDec, CDou, CBool'
            Dim firstNum As Integer = CInt(txtAddVal1.Text)
            Dim secondNum As Integer = CInt(txtAddVal2.Text)
            Dim sum = firstNum + secondNum

            txtSomeAnswer.Text = CStr(sum)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers not letters", "Error")
            Console.WriteLine("Error occurred.")
        Catch ex As Exception 'default exception'
            MessageBox.Show("An unknown error occured", "Error")
        End Try

    End Sub

    Private Sub btnDivideValues_Click(sender As Object, e As EventArgs) Handles btnDivideValues.Click
        Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
        Dim secondNum As Decimal = CDec(txtDivideVal2.Text)
        Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

        txtDivisionAnswer.Text = CStr(intSolution)
    End Sub

End Class
