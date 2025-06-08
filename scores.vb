Public Class Scores

    Private Croissant As Boolean
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        CbNom.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CbNom.AutoCompleteSource = AutoCompleteSource.ListItems
        BtnOrdre.Text = "Afficher Ordre Croissant"
        Dim stats = listeStats()
        setListeCroissant(True)
    End Sub


    Public Sub setListeCroissant(value As Boolean)
        clearListBox()
        Croissant = value
        Dim stats = listeStats()
        If Croissant Then
            For i As Integer = 0 To stats.Count - 1
                Dim nom As String = stats(i).Item1
                ListBoxNom.Items.Add(nom)
                CbNom.Items.Add(nom)
                ListBoxScore.Items.Add(getScore(nom))
                ListBoxScore.Items.Add(getScoreC(nom))
                ListBoxTemps.Items.Add(getTemps(nom))
                ListBoxNbPartie.Items.Add(getNbPartieJ(nom))
            Next
        Else
            For i As Integer = 0 To stats.Count - 1
                Dim nom As String = stats(stats.Count - 1 - i).Item1
                ListBoxNom.Items.Add(nom)
                ListBoxScore.Items.Add(getScore(nom))
                ListBoxTpsCumule.Items.Add(getScoreC(nom))
                ListBoxTemps.Items.Add(getTemps(nom))
                ListBoxNbPartie.Items.Add(getNbPartieJ(nom))
            Next
        End If

    End Sub


    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged,
            ListBoxScore.SelectedIndexChanged,
            ListBoxTpsCumule.SelectedIndexChanged,
            ListBoxTemps.SelectedIndexChanged,
            ListBoxNbPartie.SelectedIndexChanged,
            CbNom.SelectedIndexChanged

        Dim index As Integer = -1

        ' Récupérer un index cohérent selon le contrôle déclencheur
        If TypeOf sender Is ListBox Then
            index = CType(sender, ListBox).SelectedIndex
        ElseIf TypeOf sender Is ComboBox Then
            index = CType(sender, ComboBox).SelectedIndex
        End If

        ' Sécuriser
        If index < 0 Then Exit Sub
        If index >= ListBoxNom.Items.Count Then Exit Sub

        ' Synchroniser tous les éléments
        ListBoxNom.SelectedIndex = index
        ListBoxScore.SelectedIndex = index
        ListBoxTpsCumule.SelectedIndex = index
        ListBoxTemps.SelectedIndex = index
        ListBoxNbPartie.SelectedIndex = index
        CbNom.SelectedIndex = index
    End Sub


    Public Sub clearListBox()
        ListBoxNom.Items.Clear()
        ListBoxScore.Items.Clear()
        ListBoxTpsCumule.Items.Clear()
        ListBoxTemps.Items.Clear()
        ListBoxNbPartie.Items.Clear()
        CbNom.Items.Clear()
    End Sub

    Private Sub ButtonOrdre_Click(sender As Object, e As EventArgs) Handles BtnOrdre.Click
        clearListBox()
        If Croissant Then
            BtnOrdre.Text = "Afficher Ordre Décroissant"
            setListeCroissant(False)
        Else
            BtnOrdre.Text = "Afficher Ordre Croissant"
            setListeCroissant(True)
        End If
    End Sub

    Private Sub ButtonStats_Click(sender As Object, e As EventArgs) Handles BtnStats.Click
        If Not ListBoxNom.Items.Contains(CbNom.Text) Then
            MsgBox("Veuillez saisir un joueur valide", MsgBoxStyle.Critical, "Joueur indisponible")
        Else
            MsgBox("Nom :" & CbNom.Text & vbCrLf &
                   "Score : " & getScore(CbNom.Text) & vbCrLf &
                   "Temps cumulés : " & getScoreC(CbNom.Text) & vbCrLf &
                   "Temps Minimum : " & getTemps(CbNom.Text) & vbCrLf &
                   "Nombre de parties jouées : " & getNbPartieJ(CbNom.Text), MsgBoxStyle.Information, "Statistiques du joueur")
        End If
    End Sub

    Private Sub ButtonQuit_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Acceuil.Show()
    End Sub

    Private Sub ButtonSuppr_Click(sender As Object, e As EventArgs) Handles BtnSuppr.Click
        Dim reponse = MsgBox("Voulez vous supprimer les statistiques ?",
               MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Suppression des statistiques")
        If reponse = vbYes Then
            Data.SupprimerStats()
            MsgBox("Donnée supprimé")
        End If
        Me.Close()
    End Sub

End Class