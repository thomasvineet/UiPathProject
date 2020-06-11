Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Total= " & Conversion.Val(txt1.Text) + Conversion.Val(txt2.Text))
    End Sub
End Class
