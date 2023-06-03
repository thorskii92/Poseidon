Public Class frmMetReading

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        ans.Text = Val(t1.Text) \ Val(t2.Text)
        ans2.Text = Val(t1.Text) Mod Val(t2.Text)
        ans3.Text = Val(t1.Text) / Val(t2.Text)
    End Sub
End Class
