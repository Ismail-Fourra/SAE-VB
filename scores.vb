Public Class Scores

    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerScores()
    End Sub
    Private Sub ChargerScores()
        NameListBox.Items.Clear()
        ScoreListBox.Items.Clear()

        ' Lire les scores depuis le fichier
        Dim scores = GestionScores.LireScores()

        ' Trier les scores par temps croissant
        Dim scoresTries = scores.OrderBy(Function(s) s.Item2).ToList()

        ' Afficher dans les ListBox
        For Each s In scoresTries
            NameListBox.Items.Add(s.Item1)
            ScoreListBox.Items.Add(s.Item2.ToString() & "s")
        Next
    End Sub



    Private Sub NameListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameListBox.SelectedIndexChanged
        Dim index As Integer = NameListBox.SelectedIndex
        If index >= 0 AndAlso index < ScoreListBox.Items.Count Then
            ScoreListBox.SelectedIndex = index
        End If
    End Sub

    Private Sub ScoreListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScoreListBox.SelectedIndexChanged
        Dim index As Integer = ScoreListBox.SelectedIndex
        If index >= 0 AndAlso index < NameListBox.Items.Count Then
            NameListBox.SelectedIndex = index
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using brush As New Drawing2D.LinearGradientBrush(Me.ClientRectangle,
                                                         Color.LightSkyBlue,
                                                         Color.SteelBlue,
                                                         Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using
        MyBase.OnPaint(e)
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Hide()
        Acceuil.Show()
    End Sub
End Class