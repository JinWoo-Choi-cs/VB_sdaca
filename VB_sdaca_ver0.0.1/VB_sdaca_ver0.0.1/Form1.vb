Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rtb1234 As New RichTextBox
        Me.Controls.Add(rtb1234)
        rtb1234.Location = New Point(100, 100)
        rtb1234.Text = rtb1234.Name & "\n"
        rtb1234.Size = New Size(100, 100)
        Dim i As Integer


        For i = 0 To 10
            rtb1234.Text += "i"
        Next i

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class


Public Class Testing
    Public tint As Integer



End Class