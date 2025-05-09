Imports System.IO

Public Class FormMemory


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 20
            Dim picBoxName As String = "pbxCarte" & i.ToString()
            Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

            If picBox IsNot Nothing AndAlso TypeOf picBox Is PictureBox Then
                picBox.Image = My.Resources.BackCard
                picBox.SizeMode = PictureBoxSizeMode.StretchImage
                picBox.SizeMode = PictureBoxSizeMode.Zoom
                picBox.Size = New Size(100, 150) ' Exemple : 100px de large, 150px de haut

            End If
        Next


    End Sub

End Class
