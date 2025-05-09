Imports System.IO

Public Class FormMemory


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Chemin de l'image
        Dim imagePath As String = Path.Combine(Application.StartupPath, "Images", "BackCard.png")

        MessageBox.Show("Chemin d'accès : " & imagePath)


        ' Parcours des PictureBox dans le Panel
        For i As Integer = 1 To 20
            Dim picBoxName As String = "PictureBox" & i.ToString()
            Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

            If picBox IsNot Nothing AndAlso TypeOf picBox Is PictureBox Then
                picBox.Image = Image.FromFile(imagePath)
                picBox.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Next
    End Sub

End Class
