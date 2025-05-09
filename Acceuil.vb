Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Acceuil

    Dim joueursConnus As New List(Of String)

    Private Sub Acceuil_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim gradientBrush As New Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(255, 255, 150), Color.FromArgb(255, 100, 100), 90.0F)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub



    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbNomJoueur.Items.Clear()

    End Sub

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        ' Vérifier si le nom du joueur est valide (au moins 3 caractères)
        If cbNomJoueur.Text.Length >= 3 Then
            ' Afficher le message de début de partie
            MessageBox.Show("Nouvelle partie lancée avec le joueur : " & cbNomJoueur.Text)

            ' Ajouter le nom du joueur à la liste s'il est nouveau
            If Not joueursConnus.Contains(cbNomJoueur.Text) Then
                joueursConnus.Add(cbNomJoueur.Text)
                cbNomJoueur.Items.Add(cbNomJoueur.Text)  ' Ajouter à la ComboBox pour une utilisation future
            End If


            Dim FormMemory As New FormMemory()
            FormMemory.Show()
            Me.Hide()
        Else
            MessageBox.Show("Le nom du joueur doit contenir au moins 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
