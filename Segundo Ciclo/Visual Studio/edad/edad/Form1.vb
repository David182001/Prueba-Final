Public Class Form1
    Dim edad As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        edad = TextBox1.Text

        If edad < 18 Then
            MsgBox("Menor de edad")
        Else
            MsgBox("Mayor de edad")
        End If
    End Sub
End Class
