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

        ' Prépare la liste des joueurs
        cbNomJoueur.Items.Clear()
    End Sub

    Private Sub BtnJouer_Click(sender As Object, e As EventArgs) Handles BtnJouer.Click
        If cbNomJoueur.Text.Length < 3 Then
            MessageBox.Show("Le nom du joueur doit contenir au moins 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not joueursConnus.Contains(cbNomJoueur.Text) Then
            joueursConnus.Add(cbNomJoueur.Text)
            cbNomJoueur.Items.Add(cbNomJoueur.Text)
        End If

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
