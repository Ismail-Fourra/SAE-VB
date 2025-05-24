Imports System.IO

Public Class GestionScores

    Private Shared cheminFichier As String = "scores.txt"

    ' Méthode pour enregistrer un score
    Public Shared Sub EnregistrerScore(nomJoueur As String, score As Integer)
        Dim ligne As String = $"{nomJoueur};{score}"
        File.AppendAllText(cheminFichier, ligne & Environment.NewLine)
    End Sub

    ' Méthode pour lire tous les scores
    Public Shared Function LireScores() As List(Of Tuple(Of String, Integer))
        Dim listeScores As New List(Of Tuple(Of String, Integer))

        If File.Exists(cheminFichier) Then
            Dim lignes = File.ReadAllLines(cheminFichier)
            For Each ligne In lignes
                Dim parties = ligne.Split(";"c)
                If parties.Length = 2 Then
                    Dim nom = parties(0)
                    Dim scoreVal As Integer
                    If Integer.TryParse(parties(1), scoreVal) Then
                        listeScores.Add(Tuple.Create(nom, scoreVal))
                    End If
                End If
            Next
        End If

        Return listeScores
    End Function

    ' Autres méthodes liées aux scores peuvent être ajoutées ici
End Class
