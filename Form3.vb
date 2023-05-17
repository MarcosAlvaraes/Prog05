Public Class Form3

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aux As String

        If TextBox3.TextLength <> 0 And TextBox1.TextLength <> 0 And TextBox2.TextLength <> 0 Then
            aux = TextBox3.Text * TextBox1.Text * TextBox2.Text
            TextBox4.Text = aux
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class