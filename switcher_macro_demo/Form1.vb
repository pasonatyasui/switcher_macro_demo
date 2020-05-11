Public Class Form1
    Dim b1_color As Color
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        b1_color = Button1.BackColor
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        b1_color = Button1.BackColor
        Button2.BackColor = Color.Red

    End Sub

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        Button2.BackColor = Color.Black

    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        b1_color = Button1.BackColor
        Button3.BackColor = Color.Red

    End Sub

    Private Sub Button3_MouseUp(sender As Object, e As MouseEventArgs) Handles Button3.MouseUp
        Button3.BackColor = Color.Black

    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        b1_color = Button1.BackColor
        Button4.BackColor = Color.Red

    End Sub

    Private Sub Button4_MouseUp(sender As Object, e As MouseEventArgs) Handles Button4.MouseUp
        Button4.BackColor = Color.Black

    End Sub

    Private Sub Button5_MouseDown(sender As Object, e As MouseEventArgs) Handles Button5.MouseDown
        b1_color = Button1.BackColor
        Button5.BackColor = Color.Red

    End Sub

    Private Sub Button5_MouseUp(sender As Object, e As MouseEventArgs) Handles Button5.MouseUp
        Button5.BackColor = Color.Black

    End Sub

    Private Sub Button6_MouseDown(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown
        b1_color = Button1.BackColor
        Button6.BackColor = Color.Red

    End Sub

    Private Sub Button6_MouseUp(sender As Object, e As MouseEventArgs) Handles Button6.MouseUp
        Button6.BackColor = Color.Black

    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        b1_color = Button1.BackColor
        Button7.BackColor = Color.Red

    End Sub

    Private Sub Button7_MouseUp(sender As Object, e As MouseEventArgs) Handles Button7.MouseUp
        Button7.BackColor = Color.Black


    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        b1_color = Button1.BackColor
        Button8.BackColor = Color.Red

    End Sub

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles Button8.MouseUp
        Button8.BackColor = Color.Black

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'テストバージョン


    End Sub
End Class
