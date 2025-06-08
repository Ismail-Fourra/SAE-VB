Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable>
Public Class StatistiquesJoueur
    Public Nom As String
    Public MeilleurScore As Integer
    Public TempsCumulé As Integer
    Public TempsMinimum As Integer
    Public NombreParties As Integer
End Class

Module Data
    Private cheminFichier As String = "scores.dat"
    Private stats As New Dictionary(Of String, StatistiquesJoueur)

    ' Charger les données
    Private Sub Charger()
        If File.Exists(cheminFichier) Then
            Using fs As New FileStream(cheminFichier, FileMode.Open)
                Dim bf As New BinaryFormatter()
                stats = CType(bf.Deserialize(fs), Dictionary(Of String, StatistiquesJoueur))
            End Using
        End If
    End Sub

    ' Sauvegarder les données
    Private Sub Sauvegarder()
        Using fs As New FileStream(cheminFichier, FileMode.Create)
            Dim bf As New BinaryFormatter()
            bf.Serialize(fs, stats)
        End Using
    End Sub

    Public Sub EnregistrerScore(nom As String, score As Integer)
        Charger()
        If Not stats.ContainsKey(nom) Then
            stats(nom) = New StatistiquesJoueur With {
                .Nom = nom,
                .MeilleurScore = score,
                .TempsCumulé = score,
                .TempsMinimum = score,
                .NombreParties = 1
            }
        Else
            Dim s = stats(nom)
            s.NombreParties += 1
            s.TempsCumulé += score
            If score < s.TempsMinimum Then s.TempsMinimum = score
            If score > s.MeilleurScore Then s.MeilleurScore = score
        End If
        Sauvegarder()
    End Sub

    Public Function listeStats() As List(Of Tuple(Of String, Integer))
        Charger()
        Return stats.Select(Function(kvp) Tuple.Create(kvp.Key, kvp.Value.MeilleurScore)).OrderBy(Function(t) t.Item2).ToList()
    End Function

    Public Function getScore(nom As String) As Integer
        Charger()
        If stats.ContainsKey(nom) Then Return stats(nom).MeilleurScore
        Return 0
    End Function

    Public Function getTemps(nom As String) As Integer
        Charger()
        If stats.ContainsKey(nom) Then Return stats(nom).TempsMinimum
        Return 0
    End Function

    Public Function getScoreC(nom As String) As Integer
        Charger()
        If stats.ContainsKey(nom) Then Return stats(nom).TempsCumulé
        Return 0
    End Function

    Public Function getNbPartieJ(nom As String) As Integer
        Charger()
        If stats.ContainsKey(nom) Then Return stats(nom).NombreParties
        Return 0
    End Function

    Public Sub SupprimerStats()
        If File.Exists(cheminFichier) Then
            File.Delete(cheminFichier)
        End If
        stats.Clear()
    End Sub
End Module
