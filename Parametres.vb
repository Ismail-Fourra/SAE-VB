Public Class FormParametres

    Private apercuPlayer As New System.Media.SoundPlayer()




    Private Sub FormParametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CbTheme.Items.AddRange(New String() {"Europe", "SouthAmerican", "Asian", "Sahara", "African"})

        ' Charger le thème actuel sauvegardé si disponible
        If Not String.IsNullOrEmpty(My.Settings.Theme) Then
            CbTheme.SelectedItem = My.Settings.Theme
        End If

        CbMusique.Items.AddRange(New String() {"French Song", "Brasil Song", "Moroccan Song", "Spanish Song", "American Song"})

        If Not String.IsNullOrEmpty(My.Settings.Musique) Then
            CbMusique.SelectedItem = My.Settings.Musique
        End If


        ' Charger paramètres sauvegardés
        If Not String.IsNullOrEmpty(My.Settings.Musique) Then
            CbMusique.SelectedItem = My.Settings.Musique
        Else
            CbMusique.SelectedIndex = 0
        End If

        If My.Settings.Volume >= 0 AndAlso My.Settings.Volume <= TrackBarVolume.Maximum Then
            TrackBarVolume.Value = My.Settings.Volume
        Else
            TrackBarVolume.Value = 5 ' valeur par défaut
        End If

        CbEffetsSonores.Checked = My.Settings.EffetsSonores
    End Sub

    Private Sub ComboBoxTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTheme.SelectedIndexChanged
        ' Afficher l'image correspondante dans le PictureBox
        Dim theme As String = CbTheme.SelectedItem.ToString()

        Select Case theme
            Case "Europe"
                PbApercu.Image = My.Resources.Europe_Theme
            Case "SouthAmerican"
                PbApercu.Image = My.Resources.South_American_Theme
            Case "Asian"
                PbApercu.Image = My.Resources.Asian_Theme

            Case "Sahara"
                PbApercu.Image = My.Resources.Sahara_Theme

            Case "African"
                PbApercu.Image = My.Resources.African_Theme
            Case Else
                PbApercu.Image = Nothing
        End Select

        PbApercu.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub BtnApercuMusique_Click(sender As Object, e As EventArgs) Handles BtnApercuMusique.Click
        If apercuPlayer IsNot Nothing Then
            apercuPlayer.Stop()
        End If

        If CbMusique.SelectedItem Is Nothing Then Exit Sub

        Select Case CbMusique.SelectedItem.ToString()
            Case "French Song"
                apercuPlayer = New System.Media.SoundPlayer(My.Resources.French_Song)
            Case "American Song"
                apercuPlayer = New System.Media.SoundPlayer(My.Resources.American_Song)
            Case "Brasil Song"
                apercuPlayer = New System.Media.SoundPlayer(My.Resources.Brasil_Song)
            Case "Moroccan Song"
                apercuPlayer = New System.Media.SoundPlayer(My.Resources.Moroccan_Song)
            Case "Spanish Song"
                apercuPlayer = New System.Media.SoundPlayer(My.Resources.Spain_Song)
            Case Else
                apercuPlayer = Nothing
        End Select

        If apercuPlayer IsNot Nothing Then
            apercuPlayer.Play()
        End If
    End Sub



    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles BtnSauvegarder.Click
        If CbTheme.SelectedItem IsNot Nothing Then
            My.Settings.Theme = CbTheme.SelectedItem.ToString()
            My.Settings.Save()
            MessageBox.Show("🎨 Thème sauvegardé avec succès.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner un thème avant de sauvegarder.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If CbMusique.SelectedItem IsNot Nothing Then
            My.Settings.Musique = CbMusique.SelectedItem.ToString()
        End If

        My.Settings.Volume = TrackBarVolume.Value
        My.Settings.EffetsSonores = CbEffetsSonores.Checked
        My.Settings.Save()

        MessageBox.Show("Paramètres enregistrés avec succès.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Close()
    End Sub


End Class
