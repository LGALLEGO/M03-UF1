Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim op1 As Integer = 0
        Dim op2 As Integer = 0
        Dim suma As Integer = 0

        op1 = CInt(textbox1.text)
        op2 = CInt(textbox2.text)

        suma = op1 + op2

        label1.text = suma.ToString()



    End Sub
End Class
