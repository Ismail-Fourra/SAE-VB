﻿Public Class Acceuil
    Dim joueursConnus As New List(Of String)
    Friend difficulteChoisie As String = ""

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbNomJoueur.Items.Clear()
        BtnJouer.Enabled = False ' Grise le bouton au démarrage
    End Sub

    Private Sub cbNomJoueur_TextChanged(sender As Object, e As EventArgs) Handles cbNomJoueur.TextChanged
        ' Active/désactive le bouton Jouer automatiquement
        BtnJouer.Enabled = cbNomJoueur.Text.Length >= 3
    End Sub

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        ' Vérification finale au clic
        If cbNomJoueur.Text.Length < 3 Then
            MessageBox.Show("Le nom du joueur doit contenir au moins 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ajout du joueur à la liste s’il est nouveau
        If Not joueursConnus.Contains(cbNomJoueur.Text) Then
            joueursConnus.Add(cbNomJoueur.Text)
            cbNomJoueur.Items.Add(cbNomJoueur.Text)
        End If

        If rbFacile.Checked Then
            difficulteChoisie = "Simple"
        ElseIf rbMoyen.Checked Then
            difficulteChoisie = "Moyen"
        ElseIf rbDifficile.Checked Then
            difficulteChoisie = "Difficile"
        End If


        ' Ouvre le jeu
        Dim f As New FormMemory()
        f.NomJoueur = cbNomJoueur.Text
        f.Owner = Me
        f.Show()

        Me.Hide()

    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        If MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
           = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnScores_Click(sender As Object, e As EventArgs) Handles BtnScores.Click
        Scores.Show()
        Me.Hide()
    End Sub

    Private Sub btnParametres_Click(sender As Object, e As EventArgs) Handles BtnParamètres.Click
        Dim paramètres As New FormParametres()
        paramètres.ShowDialog() ' Affiche le formulaire en modal
    End Sub
End Class
