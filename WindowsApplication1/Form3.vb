Public Class Form3

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class