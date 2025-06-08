Imports System.IO
Imports System.Linq

Public Class FormMemory

    Private musicPlayer As System.Media.SoundPlayer


    Private imagesCartes As New List(Of Image)()
    Private random As New Random()
    Private cartes As New List(Of PictureBox)()

    Private tempsRestant As Integer = 120
    Private cartesRevelees As New List(Of PictureBox)()
    Private cartesTrouvees As New List(Of PictureBox)()
    Private tentativeRatée As Boolean = False
    Private nbCliques As Integer = 0
    Private nbCarteAtraitter As Integer
    Private imagesAssociees As New Dictionary(Of PictureBox, Image)()

    Public Property NomJoueur As String

    Private Sub FormMemory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case My.Settings.Theme
            Case "Europe"
                Me.BackgroundImage = My.Resources.Europe_Theme
            Case "SouthAmerican"
                Me.BackgroundImage = My.Resources.South_American_Theme
            Case "Asian"
                Me.BackgroundImage = My.Resources.Asian_Theme
            Case "Sahara"
                Me.BackgroundImage = My.Resources.Sahara_Theme
            Case "African"
                Me.BackgroundImage = My.Resources.African_Theme
            Case Else
                Me.BackgroundImage = Nothing
        End Select

        Me.BackgroundImageLayout = ImageLayout.Stretch

        Select Case My.Settings.Musique
            Case "French Song"
                musicPlayer = New System.Media.SoundPlayer(My.Resources.French_Song)
            Case "American Song"
                musicPlayer = New System.Media.SoundPlayer(My.Resources.American_Song)
            Case "Brasil Song"
                musicPlayer = New System.Media.SoundPlayer(My.Resources.Brasil_Song)
            Case "Moroccan Song"
                musicPlayer = New System.Media.SoundPlayer(My.Resources.Moroccan_Song)
            Case "Spanish Song"
                musicPlayer = New System.Media.SoundPlayer(My.Resources.Spain_Song)
            Case Else
                musicPlayer = Nothing
        End Select

        If musicPlayer IsNot Nothing AndAlso My.Settings.Volume > 0 Then
            musicPlayer.PlayLooping()
        End If


        imagesCartes.Clear()
        cartes.Clear()
        cartesRevelees.Clear()
        cartesTrouvees.Clear()
        imagesAssociees.Clear()
        Timer1.Stop()
        Timer2.Stop()

        lblNomJoueur.Text = NomJoueur

        Dim nomsCartes As New List(Of String)
        Dim nombreCartes As Integer = 0

        'Met la bonne difficulté
        Select Case Acceuil.difficulteChoisie.ToLower()
            Case "simple"
                nombreCartes = 16
                tempsRestant = 60
                nbCarteAtraitter = 2
            Case "moyen"
                nombreCartes = 20
                tempsRestant = 90
                nbCarteAtraitter = 4
            Case "difficile"
                nombreCartes = 32
                tempsRestant = 105
                nbCarteAtraitter = 4

        End Select

        LblTemps.Text = "Temps : " & tempsRestant

        'LoqmanTest, c'est le code de base mais j'essaye
        'For i As Integer = 0 To 4
        'For j As Integer = 1 To 4
        'nomsCartes.Add("Flag" & i)
        'imagesCartes.Add(CType(My.Resources.ResourceManager.GetObject("Flag" & i), Image))
        'Next
        'Next

        ' Mélange via des indices
        'Dim indices As New List(Of Integer)(Enumerable.Range(0, nomsCartes.Count))
        'indices = indices.OrderBy(Function() random.Next()).ToList()

        'Dim nomsMélangés As New List(Of String)
        'Dim imagesMélangées As New List(Of Image)

        'For Each index In indices
        'nomsMélangés.Add(nomsCartes(index))
        'imagesMélangées.Add(imagesCartes(index))
        'Next

        ' Associer les images aux PictureBox
        'For i As Integer = 1 To 20
        'Dim picBoxName As String = "pbxCarte" & i.ToString()
        'Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

        'If picBox IsNot Nothing Then
        'cartes.Add(picBox)
        'picBox.Tag = nomsMélangés(i - 1)
        'imagesAssociees(picBox) = imagesMélangées(i - 1)

        'picBox.Image = My.Resources.BackCardFlags
        'picBox.SizeMode = PictureBoxSizeMode.Zoom
        'picBox.Size = New Size(100, 150)

        'AddHandler picBox.Click, AddressOf Carte_Click
        'End If
        'Next

        ' Nombre de paires = moitié du nombre de cartes
        Dim nombrePaires As Integer = nombreCartes \ nbCarteAtraitter

        imagesCartes.Clear()

        For i As Integer = 0 To nombrePaires - 1
            ' Ajouter deux fois chaque carte pour créer une paire
            For j As Integer = 0 To nbCarteAtraitter - 1

                nomsCartes.Add("Flag" & i)
                imagesCartes.Add(CType(My.Resources.ResourceManager.GetObject("Flag" & i), Image))


            Next
        Next

        ' Mélanger les indices
        Dim indices As New List(Of Integer)(Enumerable.Range(0, nomsCartes.Count))
        indices = indices.OrderBy(Function() random.Next()).ToList()

        Dim nomsMélangés As New List(Of String)
        Dim imagesMélangées As New List(Of Image)

        For Each index In indices
            nomsMélangés.Add(nomsCartes(index))
            imagesMélangées.Add(imagesCartes(index))
        Next

        ' Associer les images aux PictureBox
        For i As Integer = 1 To nombreCartes
            Dim picBoxName As String = "pbxCarte" & i.ToString()
            Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

            If picBox IsNot Nothing Then
                cartes.Add(picBox)
                picBox.Tag = nomsMélangés(i - 1)
                imagesAssociees(picBox) = imagesMélangées(i - 1)

                picBox.Image = My.Resources.BackCardFlags
                picBox.SizeMode = PictureBoxSizeMode.Zoom
                picBox.Size = New Size(100, 150)
                picBox.Enabled = True
                picBox.Visible = True

                AddHandler picBox.Click, AddressOf Carte_Click
            End If
        Next

        ' Cacher les PictureBox non utilisées
        For i As Integer = nombreCartes + 1 To 32
            Dim picBoxName As String = "pbxCarte" & i.ToString()
            Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()
            If picBox IsNot Nothing Then
                picBox.Visible = False
                picBox.Enabled = False
            End If
        Next






        Timer1.Interval = 1000
        Timer1.Start()

        Timer2.Interval = 500  ' Ce timer reste pour le masquage des cartes
        Timer2.Stop()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempsRestant -= 1
        LblTemps.Text = $"Temps : {tempsRestant}s"

        If tempsRestant <= 0 Then
            Timer1.Stop()
            MsgBox("Temps écoulé")
            Me.Close()
            Acceuil.Show()
        End If
    End Sub
    Private Function ToGrayScale(originalImage As Bitmap) As Bitmap
        Dim grayBmp As New Bitmap(originalImage.Width, originalImage.Height)
        For x As Integer = 0 To originalImage.Width - 1
            For y As Integer = 0 To originalImage.Height - 1
                Dim c As Color = originalImage.GetPixel(x, y)
                Dim gray As Integer = CInt((CInt(c.R) + CInt(c.G) + CInt(c.B)) / 3)
                grayBmp.SetPixel(x, y, Color.FromArgb(c.A, gray, gray, gray))
            Next
        Next
        Return grayBmp

    End Function

    Private Sub Carte_Click(sender As Object, e As EventArgs)
        nbCliques += 1
        Dim carteCliquee As PictureBox = CType(sender, PictureBox)

        ' Ignorer si déjà trouvée, en attente de masquage, ou déjà cliquée dans cette tentative
        If cartesTrouvees.Contains(carteCliquee) OrElse tentativeRatée OrElse cartesRevelees.Contains(carteCliquee) Then Exit Sub

        ' Révéler la carte cliquée
        carteCliquee.Image = CType(My.Resources.ResourceManager.GetObject(carteCliquee.Tag.ToString()), Image)
        cartesRevelees.Add(carteCliquee)

        ' Si seule, attendre la suivante
        If cartesRevelees.Count = 1 Then Exit Sub

        ' Vérifier correspondance des cartes révélées
        Dim premierTag = cartesRevelees(0).Tag.ToString()
        Dim sontIdentiques As Boolean = cartesRevelees.All(Function(c) c.Tag.ToString() = premierTag)
        If Not sontIdentiques Then
            tentativeRatée = True
            Timer2.Interval = 500
            Timer2.Start()
        End If

        If cartesRevelees.Count = nbCarteAtraitter AndAlso sontIdentiques Then
            ' ✅ Valider définitivement les cartes
            For Each carte In cartesRevelees
                carte.Enabled = False
                carte.Image = ToGrayScale(CType(carte.Image, Bitmap))
                cartesTrouvees.Add(carte)
            Next
            cartesRevelees.Clear()
            tentativeRatée = False
        End If

        If cartesTrouvees.Count = cartes.Count Then
            Timer1.Stop() ' Arrêter le chrono si gagné

            Dim tempsJoué As Integer = 60 - tempsRestant
            MsgBox("🎉 Réussi en " & tempsJoué & " secondes !")
            GestionScores.EnregistrerScore(NomJoueur, tempsJoué)
            ' Retour à l'accueil
            Me.Close()
            Acceuil.Show()
        End If

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        ' Masquer uniquement les cartes non validées
        For Each carte In cartesRevelees
            If Not cartesTrouvees.Contains(carte) Then carte.Image = My.Resources.BackCardFlags
        Next
        cartesRevelees.Clear()
        tentativeRatée = False
    End Sub

    Private Sub BtnAbandonner_Click(sender As Object, e As EventArgs) Handles BtnAbandonner.Click
        Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir abandonner la partie ?", "Abandonner", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Acceuil.cbNomJoueur.Text = ""
            ' Redirection vers l'accueil
            Acceuil.Show()
            Me.Close()
        End If

        If musicPlayer IsNot Nothing Then
            musicPlayer.Stop()
        End If


    End Sub



    Private Sub FormMemory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        imagesCartes.Clear()
        cartes.Clear()
        cartesRevelees.Clear()
        cartesTrouvees.Clear()
        imagesAssociees.Clear()
        Timer1.Stop()
        Timer2.Stop()

        If musicPlayer IsNot Nothing Then
            musicPlayer.Stop()
        End If

    End Sub
End Class
