Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rtb1234 As New RichTextBox
        Me.Controls.Add(rtb1234)
        rtb1234.Location = New Point(100, 100)
        rtb1234.Name = "rtb4321"
        rtb1234.Text = rtb1234.Name & vbNewLine
        rtb1234.Size = New Size(1000, 1000)
        rtb1234.ReadOnly = True


        Dim arr(1) As Integer

        arr(0) = 100
        arr(1) = 99

        Dim Labels(5) As Label

        Dim lbl1 As New Label()

        Labels(1) = lbl1


        For i As Integer = 0 To arr.Length - 1
            rtb1234.Text += arr(i) & "  길이 = " & arr.Length & vbNewLine
        Next i

        '    rtb1234.Text += $"{i}" & vbCrLf
        'Next i

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class


Public Class Testing
    Public tint As Integer



End Class