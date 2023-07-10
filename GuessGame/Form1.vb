Public Class Form1

    'taking the input from user
    Dim a, b As Integer
    Dim c As Integer = 0
    Dim d As Boolean = False

    Dim rn As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'a = InputBox("Enter the number between 1 to 10")
        a = TextBox1.Text


        'generating a random number
        b = rn.Next(0, 10)

        'conditions
        If a = b Then
            PictureBox1.Image = My.Resources.download
            Me.Hide()
            Form2.Show()
            Form2.PictureBox1.Image = My.Resources.download

            'MessageBox.Show("your ans is Right value is " & b)

        Else
            PictureBox1.Image = My.Resources.sad
            Me.Hide()
            Form2.Show()
            Form2.PictureBox1.Image = My.Resources.sad


            'MessageBox.Show("your ans is wrong value is " & b)

        End If


        Form2.TextBox1.Text = c

        c += 1







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()


    End Sub
End Class
