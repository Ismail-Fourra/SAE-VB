Imports System.IO

Public Class FormMemory

    Private imagesCartes As New List(Of Image)()
    Private random As New Random()
    Private cartes As New List(Of PictureBox)()

    Dim tempsRestant As Integer = 60
    Private premierClique As PictureBox = Nothing
    Private deuxiemeClique As PictureBox = Nothing

    Private Sub FormMemory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imagesCartes.Clear()

        ' Ajouter chaque image deux fois
        imagesCartes.Add(My.Resources.Card0)
        imagesCartes.Add(My.Resources.Card0)
        imagesCartes.Add(My.Resources.Card1)
        imagesCartes.Add(My.Resources.Card1)
        imagesCartes.Add(My.Resources.Card2)
        imagesCartes.Add(My.Resources.Card2)
        imagesCartes.Add(My.Resources.Card3)
        imagesCartes.Add(My.Resources.Card3)
        imagesCartes.Add(My.Resources.Card4)
        imagesCartes.Add(My.Resources.Card4)
        imagesCartes.Add(My.Resources.Card5)
        imagesCartes.Add(My.Resources.Card5)
        imagesCartes.Add(My.Resources.Card6)
        imagesCartes.Add(My.Resources.Card6)
        imagesCartes.Add(My.Resources.Card7)
        imagesCartes.Add(My.Resources.Card7)
        imagesCartes.Add(My.Resources.Card8)
        imagesCartes.Add(My.Resources.Card8)
        imagesCartes.Add(My.Resources.Card9)
        imagesCartes.Add(My.Resources.Card9)

        ' Vérifier le nombre d'images
        If imagesCartes.Count <> 20 Then
            MsgBox("Erreur : 20 images doivent être chargées.")
            Exit Sub
        End If

        ' Mélanger les images
        imagesCartes = imagesCartes.OrderBy(Function(x) random.Next()).ToList()

        ' Associer les images aux PictureBox
        For i As Integer = 1 To 20
            Dim picBoxName As String = "pbxCarte" & i.ToString()
            Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

            If picBox IsNot Nothing Then
                Debug.Print("PictureBox trouvée : " & picBox.Name)
                cartes.Add(picBox)
                picBox.Tag = imagesCartes(i - 1)
                picBox.Image = My.Resources.BackCard
                picBox.SizeMode = PictureBoxSizeMode.Zoom
                picBox.Size = New Size(100, 150)
                AddHandler picBox.Click, AddressOf Carte_Click
            Else
                Debug.Print("PictureBox non trouvée : " & picBoxName)
            End If
        Next

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempsRestant -= 1
        LblTemps.Text = "Temps : " & tempsRestant & "s"

        If tempsRestant <= 0 Then
            Timer1.Stop()
            MsgBox("Temps écoulé")
        End If
    End Sub

    Private Sub Carte_Click(sender As Object, e As EventArgs)
        Dim carteCliquee As PictureBox = CType(sender, PictureBox)

        If carteCliquee.Tag Is Nothing OrElse deuxiemeClique IsNot Nothing Then Exit Sub

        carteCliquee.Image = CType(carteCliquee.Tag, Image)

        If premierClique Is Nothing Then
            premierClique = carteCliquee
        Else
            deuxiemeClique = carteCliquee

            If premierClique.Tag.Equals(deuxiemeClique.Tag) Then
                premierClique = Nothing
                deuxiemeClique = Nothing
            Else
                Timer2.Interval = 1000
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        If premierClique IsNot Nothing Then premierClique.Image = My.Resources.BackCard
        If deuxiemeClique IsNot Nothing Then deuxiemeClique.Image = My.Resources.BackCard

        premierClique = Nothing
        deuxiemeClique = Nothing
    End Sub

End Class
