Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New FormMemory()
        f.Show()
        Me.Hide()
    End Sub
End Class