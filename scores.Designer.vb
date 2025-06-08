<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxScore = New System.Windows.Forms.ListBox()
        Me.ListBoxTemps = New System.Windows.Forms.ListBox()
        Me.ListBoxTpsCumule = New System.Windows.Forms.ListBox()
        Me.ListBoxNbPartie = New System.Windows.Forms.ListBox()
        Me.CbNom = New System.Windows.Forms.ComboBox()
        Me.BtnStats = New System.Windows.Forms.Button()
        Me.BtnOrdre = New System.Windows.Forms.Button()
        Me.BtnSuppr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.LblTpsCumule = New System.Windows.Forms.Label()
        Me.LblNbPJ = New System.Windows.Forms.Label()
        Me.LblRecherche = New System.Windows.Forms.Label()
        Me.LblTemps = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(109, 347)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(244, 53)
        Me.BtnQuitter.TabIndex = 2
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 16
        Me.ListBoxNom.Location = New System.Drawing.Point(67, 141)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(120, 116)
        Me.ListBoxNom.TabIndex = 3
        '
        'ListBoxScore
        '
        Me.ListBoxScore.FormattingEnabled = True
        Me.ListBoxScore.ItemHeight = 16
        Me.ListBoxScore.Location = New System.Drawing.Point(193, 141)
        Me.ListBoxScore.Name = "ListBoxScore"
        Me.ListBoxScore.Size = New System.Drawing.Size(120, 116)
        Me.ListBoxScore.TabIndex = 4
        '
        'ListBoxTemps
        '
        Me.ListBoxTemps.FormattingEnabled = True
        Me.ListBoxTemps.ItemHeight = 16
        Me.ListBoxTemps.Location = New System.Drawing.Point(319, 141)
        Me.ListBoxTemps.Name = "ListBoxTemps"
        Me.ListBoxTemps.Size = New System.Drawing.Size(120, 116)
        Me.ListBoxTemps.TabIndex = 5
        '
        'ListBoxTpsCumule
        '
        Me.ListBoxTpsCumule.FormattingEnabled = True
        Me.ListBoxTpsCumule.ItemHeight = 16
        Me.ListBoxTpsCumule.Location = New System.Drawing.Point(445, 141)
        Me.ListBoxTpsCumule.Name = "ListBoxTpsCumule"
        Me.ListBoxTpsCumule.Size = New System.Drawing.Size(120, 116)
        Me.ListBoxTpsCumule.TabIndex = 6
        '
        'ListBoxNbPartie
        '
        Me.ListBoxNbPartie.FormattingEnabled = True
        Me.ListBoxNbPartie.ItemHeight = 16
        Me.ListBoxNbPartie.Location = New System.Drawing.Point(571, 141)
        Me.ListBoxNbPartie.Name = "ListBoxNbPartie"
        Me.ListBoxNbPartie.Size = New System.Drawing.Size(118, 116)
        Me.ListBoxNbPartie.TabIndex = 7
        '
        'CbNom
        '
        Me.CbNom.FormattingEnabled = True
        Me.CbNom.Location = New System.Drawing.Point(120, 302)
        Me.CbNom.Name = "CbNom"
        Me.CbNom.Size = New System.Drawing.Size(121, 24)
        Me.CbNom.TabIndex = 8
        '
        'BtnStats
        '
        Me.BtnStats.Location = New System.Drawing.Point(387, 293)
        Me.BtnStats.Name = "BtnStats"
        Me.BtnStats.Size = New System.Drawing.Size(172, 27)
        Me.BtnStats.TabIndex = 9
        Me.BtnStats.Text = "Afficher statistiques"
        Me.BtnStats.UseVisualStyleBackColor = True
        '
        'BtnOrdre
        '
        Me.BtnOrdre.Location = New System.Drawing.Point(387, 326)
        Me.BtnOrdre.Name = "BtnOrdre"
        Me.BtnOrdre.Size = New System.Drawing.Size(172, 27)
        Me.BtnOrdre.TabIndex = 10
        Me.BtnOrdre.Text = "Inverser Ordre Affichage"
        Me.BtnOrdre.UseVisualStyleBackColor = True
        '
        'BtnSuppr
        '
        Me.BtnSuppr.Location = New System.Drawing.Point(387, 359)
        Me.BtnSuppr.Name = "BtnSuppr"
        Me.BtnSuppr.Size = New System.Drawing.Size(165, 29)
        Me.BtnSuppr.TabIndex = 11
        Me.BtnSuppr.Text = "Supprimer stats"
        Me.BtnSuppr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NOM"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(193, 90)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(120, 16)
        Me.lblMax.TabIndex = 14
        Me.lblMax.Text = "SCORE MAXIMUM"
        '
        'LblTpsCumule
        '
        Me.LblTpsCumule.AutoSize = True
        Me.LblTpsCumule.Location = New System.Drawing.Point(452, 90)
        Me.LblTpsCumule.Name = "LblTpsCumule"
        Me.LblTpsCumule.Size = New System.Drawing.Size(113, 16)
        Me.LblTpsCumule.TabIndex = 15
        Me.LblTpsCumule.Text = "TEMPS CUMULE"
        '
        'LblNbPJ
        '
        Me.LblNbPJ.AutoSize = True
        Me.LblNbPJ.Location = New System.Drawing.Point(571, 90)
        Me.LblNbPJ.Name = "LblNbPJ"
        Me.LblNbPJ.Size = New System.Drawing.Size(144, 16)
        Me.LblNbPJ.TabIndex = 16
        Me.LblNbPJ.Text = "NB PARTIES JOUÉES"
        '
        'LblRecherche
        '
        Me.LblRecherche.AutoSize = True
        Me.LblRecherche.Location = New System.Drawing.Point(124, 268)
        Me.LblRecherche.Name = "LblRecherche"
        Me.LblRecherche.Size = New System.Drawing.Size(117, 16)
        Me.LblRecherche.TabIndex = 17
        Me.LblRecherche.Text = "Rechercher joueur"
        '
        'LblTemps
        '
        Me.LblTemps.AutoSize = True
        Me.LblTemps.Location = New System.Drawing.Point(319, 90)
        Me.LblTemps.Name = "LblTemps"
        Me.LblTemps.Size = New System.Drawing.Size(116, 16)
        Me.LblTemps.TabIndex = 18
        Me.LblTemps.Text = "TEMPS MINIMUM"
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAE_VB.My.Resources.Resources.Fond_MemoryFlags
        Me.ClientSize = New System.Drawing.Size(738, 554)
        Me.Controls.Add(Me.LblTemps)
        Me.Controls.Add(Me.LblRecherche)
        Me.Controls.Add(Me.LblNbPJ)
        Me.Controls.Add(Me.LblTpsCumule)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSuppr)
        Me.Controls.Add(Me.BtnOrdre)
        Me.Controls.Add(Me.BtnStats)
        Me.Controls.Add(Me.CbNom)
        Me.Controls.Add(Me.ListBoxNbPartie)
        Me.Controls.Add(Me.ListBoxTpsCumule)
        Me.Controls.Add(Me.ListBoxTemps)
        Me.Controls.Add(Me.ListBoxScore)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Scores"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxScore As ListBox
    Friend WithEvents ListBoxTemps As ListBox
    Friend WithEvents ListBoxTpsCumule As ListBox
    Friend WithEvents ListBoxNbPartie As ListBox
    Friend WithEvents CbNom As ComboBox
    Friend WithEvents BtnStats As Button
    Friend WithEvents BtnOrdre As Button
    Friend WithEvents BtnSuppr As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents LblTpsCumule As Label
    Friend WithEvents LblNbPJ As Label
    Friend WithEvents LblRecherche As Label
    Friend WithEvents LblTemps As Label
End Class
