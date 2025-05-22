Imports System.IO
Imports System.Linq

Public Class FormMemory

    Private imagesCartes As New List(Of Image)()
    Private random As New Random()
    Private cartes As New List(Of PictureBox)()

    Private tempsRestant As Integer = 60
    Private cartesRevelees As New List(Of PictureBox)()
    Private cartesTrouvees As New List(Of PictureBox)()
    Private tentativeRatée As Boolean = False
    Private nbCliques As Integer = 0
    Private player As New System.Media.SoundPlayer(My.Resources.Maroc_song1)

    Private Sub FormMemory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imagesCartes.Clear()
        cartes.Clear()
        cartesRevelees.Clear()
        cartesTrouvees.Clear()

        ' Ajouter chaque image quatre fois pour former des carrés
        For i As Integer = 0 To 4
            For j As Integer = 1 To 4
                imagesCartes.Add(CType(My.Resources.ResourceManager.GetObject("Flag" & i), Image))
            Next
        Next

        ' Mélanger les images
        imagesCartes = imagesCartes.OrderBy(Function(x) random.Next()).ToList()

        ' Associer les images aux PictureBox
        For i As Integer = 1 To 20
            Dim picBoxName As String = "pbxCarte" & i.ToString()
            Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

            If picBox IsNot Nothing Then
                cartes.Add(picBox)

                ' Associer une image aléatoire à chaque carte
                Dim img As Image = imagesCartes(i - 1)
                picBox.Tag = img ' <-- stocker l'image directement dans le Tag
                picBox.Image = My.Resources.BackCardFlags
                picBox.SizeMode = PictureBoxSizeMode.Zoom
                picBox.Size = New Size(100, 150)

                AddHandler picBox.Click, AddressOf Carte_Click
            End If
        Next


        ' Initialiser le Timer
        Timer1.Interval = 1000
        Timer1.Start()

        ' Messag de victoire
        If (cartesTrouvees.Count = cartes.Count) Then
            MsgBox("Vous avez gagné !" & vbCr & "Vous avez cliqué " & nbCliques & " fois")
            Timer1.Stop()
            Me.Close()
        End If

    End Sub
    ''Private Sub FormMemory_LoadTest(sender As Object, e As EventArgs) Handles MyBase.Load
    ''    imagesCartes.Clear()
    ''    cartes.Clear()
    ''    cartesRevelees.Clear()
    ''    cartesTrouvees.Clear()

    ''    ' Ajouter chaque image quatre fois pour former des carrés
    ''    For i As Integer = 0 To 4
    ''        For j As Integer = 1 To 4
    ''            imagesCartes.Add(CType(My.Resources.ResourceManager.GetObject("Flag" & i), Image))
    ''        Next
    ''    Next

    ''    ' Mélanger les images
    ''    imagesCartes = imagesCartes.OrderBy(Function(x) random.Next()).ToList()

    ''    ' Associer les images aux PictureBox et les révéler
    ''    For i As Integer = 1 To 20
    ''        Dim picBoxName As String = "pbxCarte" & i.ToString()
    ''        Dim picBox As PictureBox = Me.Controls.Find(picBoxName, True).FirstOrDefault()

    ''        If picBox IsNot Nothing Then
    ''            cartes.Add(picBox)
    ''            picBox.Tag = "Flag" & ((i - 1) \ 4)
    ''            ' Afficher directement la face de la carte
    ''            picBox.Image = imagesCartes(i - 1)
    ''            picBox.SizeMode = PictureBoxSizeMode.Zoom
    ''            picBox.Size = New Size(100, 150)
    ''            AddHandler picBox.Click, AddressOf Carte_Click
    ''            ' Ajouter à la liste des cartes révélées pour le test
    ''            'cartesRevelees.Add(picBox)
    ''        End If
    ''    Next

    ''    ' Initialiser le Timer
    ''    Timer1.Interval = 10000
    ''    Timer1.Start()
    ''End Sub


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
        carteCliquee.Image = CType(carteCliquee.Tag, Image)
        cartesRevelees.Add(carteCliquee)

        ' Si seule, attendre la suivante
        If cartesRevelees.Count = 1 Then Exit Sub

        ' Vérifier correspondance des cartes révélées
        Dim premierImage = CType(cartesRevelees(0).Tag, Image)
        Dim sontIdentiques As Boolean = cartesRevelees.All(Function(c) c.Tag Is premierImage)
        If Not sontIdentiques Then
            tentativeRatée = True
            Timer2.Interval = 500
            Timer2.Start()
        End If

        If cartesRevelees.Count = 4 AndAlso sontIdentiques Then
            For Each carte In cartesRevelees
                carte.Enabled = False
                carte.Image = ToGrayScale(CType(carte.Image, Bitmap))
                cartesTrouvees.Add(carte)
            Next
            cartesRevelees.Clear()
            tentativeRatée = False
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
            ' Redirection vers l'accueil
            Dim accueil As New Acceuil()
            accueil.Show()
            Me.Close() ' Ferme la fenêtre actuelle (le jeu)
        End If
    End Sub
End Class
