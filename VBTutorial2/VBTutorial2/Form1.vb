Public Class Form1

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim txtOutput As String = "Abs(-19) = " & Math.Abs(-19) & Environment.NewLine
        txtOutput &= "Ceiling(4.5) = " & Math.Ceiling(4.5) & Environment.NewLine
        TextBox1.Text = txtOutput
    End Sub
End Class
