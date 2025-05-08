<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceuil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceuil))
        Me.cbNomJoueur = New System.Windows.Forms.ComboBox()
        Me.BtnJouer = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.BtnScores = New System.Windows.Forms.Button()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbNomJoueur
        '
        Me.cbNomJoueur.FormattingEnabled = True
        Me.cbNomJoueur.Location = New System.Drawing.Point(128, 216)
        Me.cbNomJoueur.Name = "cbNomJoueur"
        Me.cbNomJoueur.Size = New System.Drawing.Size(250, 24)
        Me.cbNomJoueur.TabIndex = 1
        '
        'BtnJouer
        '
        Me.BtnJouer.Location = New System.Drawing.Point(119, 268)
        Me.BtnJouer.Name = "BtnJouer"
        Me.BtnJouer.Size = New System.Drawing.Size(141, 50)
        Me.BtnJouer.TabIndex = 2
        Me.BtnJouer.Text = "Jouer"
        Me.BtnJouer.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(449, 268)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(149, 50)
        Me.BtnQuitter.TabIndex = 3
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'BtnScores
        '
        Me.BtnScores.Location = New System.Drawing.Point(281, 268)
        Me.BtnScores.Name = "BtnScores"
        Me.BtnScores.Size = New System.Drawing.Size(142, 50)
        Me.BtnScores.TabIndex = 4
        Me.BtnScores.Text = "Scores"
        Me.BtnScores.UseVisualStyleBackColor = True
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(136, 171)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(100, 16)
        Me.LblNom.TabIndex = 5
        Me.LblNom.Text = "Nom du joueur :"
        '
        'Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblNom)
        Me.Controls.Add(Me.BtnScores)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnJouer)
        Me.Controls.Add(Me.cbNomJoueur)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Acceuil"
        Me.Text = "Acceuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbNomJoueur As ComboBox
    Friend WithEvents BtnJouer As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnScores As Button
    Friend WithEvents LblNom As Label
End Class
