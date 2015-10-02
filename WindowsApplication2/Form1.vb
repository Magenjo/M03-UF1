Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Op1 As Integer = 0
        Dim Op2 As Integer = 0
        Dim suma As Integer = 0

        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)

        suma = Op1 + Op2

        Label.Text = suma.ToString()

    End Sub
End Class
