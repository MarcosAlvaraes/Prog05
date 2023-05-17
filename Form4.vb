Public Class Form4
    Private Sub soma1_Click(sender As Object, e As EventArgs) Handles soma1.Click
        Dim soma, v1, v2 As Single

        v1 = Val(TextBox1.Text)
        v2 = Val(TextBox2.Text)
        soma = v1 + v2
        TextBox3.Text = soma


    End Sub

    Private Sub multi_Click(sender As Object, e As EventArgs) Handles multi.Click
        Dim multi, v1, v2 As Single

        v1 = Val(TextBox1.Text)
        v2 = Val(TextBox2.Text)
        multi = v1 * v2
        TextBox3.Text = multi

    End Sub

    Private Sub subtra_Click(sender As Object, e As EventArgs) Handles subtra.Click
        Dim subtra, v1, v2 As Single

        v1 = Val(TextBox1.Text)
        v2 = Val(TextBox2.Text)
        subtra = v1 - v2
        TextBox3.Text = subtra
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        Dim div, v1, v2 As Single

        v1 = Val(TextBox1.Text)
        v2 = Val(TextBox2.Text)
        div = v1 / v2
        TextBox3.Text = div
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class