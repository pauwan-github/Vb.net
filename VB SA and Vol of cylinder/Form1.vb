Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Const Pi As Single = 3.142
            Dim radius, height, surfaceArea, volume As Single
            radius = Val(TextBox1.Text)
            height = Val(TextBox2.Text)
            surfaceArea = (2 * Pi * radius * radius) + (Pi * (2 * radius) * height)
            volume = Pi * radius * radius * height
            TextBox3.Text = surfaceArea
            TextBox4.Text = volume
        End Sub
End Class
