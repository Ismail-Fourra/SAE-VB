Public Class Acceuil
    Dim joueursConnus As New List(Of String)

    Private Sub Acceuil_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim gradientBrush As New Drawing.Drawing2D.LinearGradientBrush(
            Me.ClientRectangle,
            Color.FromArgb(255, 255, 150),
            Color.FromArgb(255, 100, 100),
            90.0F)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

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

        ' Ouvre le jeu
        Dim f As New FormMemory()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        If MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
           = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
