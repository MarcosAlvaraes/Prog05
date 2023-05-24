Public Class Form5

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Show()


    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.White




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Randomize()
        TextBox1.Text = Int((100 - 0 + 1) * Rnd() + 0)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.ForeColor = Color.Red


    End Sub
End Class