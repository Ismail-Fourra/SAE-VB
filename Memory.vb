Imports System.IO

Public Class FormMemory

    Private imagesCartes As New List(Of Image)()
    Private random As New Random()
    Private cartes As New List(Of PictureBox)()

    Dim tempsRestant As Integer = 60 'Nombre magique j'crois

    Private premierClique As PictureBox = Nothing
    Private deuxiemeClique As PictureBox = Nothing


    Private Sub FormMemory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Étape 1 : Charger chaque image deux fois (pour les paires)
        imagesCartes.Clear()
        For i As Integer = 0 To 9 ' Card0 à Card9
            Dim img As Image = CType(My.Resources.ResourceManager.GetObject("Card" & i.ToString()), Image)
            imagesCartes.Add(img)
            imagesCartes.Add(img)
        Next

        ' Étape 2 : Mélanger les images
        imagesCartes = imagesCartes.OrderBy(Function(x) random.Next()).ToList()

        ' Étape 3 : Associer aux 20 PictureBoxes
        For i As Integer = 1 To 20
            Dim picBoxName As String = "pbxCarte" & i.ToString()
            Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

            If picBox IsNot Nothing Then
                cartes.Add(picBox)
                picBox.Tag = imagesCartes(i - 1) ' Stocke l'image réelle dans Tag
                picBox.Image = My.Resources.BackCard ' Affiche le dos au départ
                picBox.SizeMode = PictureBoxSizeMode.Zoom
                picBox.Size = New Size(100, 150)
                AddHandler picBox.Click, AddressOf Carte_Click ' Gère le clic
            End If
        Next

        Timer1.Interval = 1000 ' Maj chaque seconde
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempsRestant -= 1
        LblTemps.Text = "Temps : " & tempsRestant & "s"

        If tempsRestant <= 0 Then
            Timer1.Stop()
            MsgBox("Temps écoule")
        End If
    End Sub


    Private Sub Carte_Click(sender As Object, e As EventArgs)
        Dim carteCliquee As PictureBox = CType(sender, PictureBox)

        ' Si déjà révélée ou deux cartes sélectionnées, on ignore
        If carteCliquee.Image IsNot My.Resources.BackCard OrElse deuxiemeClique IsNot Nothing Then Exit Sub

        ' Affiche l'image réelle
        carteCliquee.Image = CType(carteCliquee.Tag, Image)

        If premierClique Is Nothing Then
            premierClique = carteCliquee
        Else
            deuxiemeClique = carteCliquee

            ' Vérifie si les deux images sont identiques
            If premierClique.Tag.Equals(deuxiemeClique.Tag) Then
                ' Bonne paire, on les laisse affichées
                premierClique = Nothing
                deuxiemeClique = Nothing
            Else
                ' Mauvaise paire, cacher après 1 seconde
                Timer2.Interval = 1000
                Timer2.Start()
            End If
        End If
    End Sub

    ' Remettre les cartes face cachée si non appariées
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        If premierClique IsNot Nothing Then premierClique.Image = My.Resources.BackCard
        If deuxiemeClique IsNot Nothing Then deuxiemeClique.Image = My.Resources.BackCard

        premierClique = Nothing
        deuxiemeClique = Nothing
    End Sub

End Class
