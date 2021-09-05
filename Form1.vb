' the project is for finding average of 4 numbers inputted by a user

Public Class Form1
    Private Sub AvgBtn_Click(sender As Object, e As EventArgs) Handles AvgBtn.Click
        ' setting the input and casting them to accept only integers
        Dim NumOne As Integer = CInt(TextBox1.Text)
        Dim NumTwo As Integer = CInt(TextBox2.Text)
        Dim NumThree As Integer = CInt(TextBox3.Text)
        Dim NumFour As Integer = CInt(TextBox4.Text)

        ' adding the four numbers 
        Dim Sum As Integer = NumOne + NumTwo + NumThree + NumFour

        ' outputting the average
        TextOutput.Text = CInt(Sum) / CInt(4)


    End Sub

    ' this is the exit button code
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
