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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblJeuMemory = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbNomJoueur
        '
        Me.cbNomJoueur.FormattingEnabled = True
        Me.cbNomJoueur.Location = New System.Drawing.Point(205, 210)
        Me.cbNomJoueur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbNomJoueur.Name = "cbNomJoueur"
        Me.cbNomJoueur.Size = New System.Drawing.Size(157, 21)
        Me.cbNomJoueur.TabIndex = 1
        '
        'BtnJouer
        '
        Me.BtnJouer.BackColor = System.Drawing.Color.Indigo
        Me.BtnJouer.ForeColor = System.Drawing.Color.White
        Me.BtnJouer.Location = New System.Drawing.Point(30, 12)
        Me.BtnJouer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnJouer.Name = "BtnJouer"
        Me.BtnJouer.Size = New System.Drawing.Size(75, 32)
        Me.BtnJouer.TabIndex = 2
        Me.BtnJouer.Text = "Jouer"
        Me.BtnJouer.UseVisualStyleBackColor = False
        '
        'BtnQuitter
        '
        Me.BtnQuitter.BackColor = System.Drawing.Color.Red
        Me.BtnQuitter.ForeColor = System.Drawing.Color.White
        Me.BtnQuitter.Location = New System.Drawing.Point(30, 50)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(156, 30)
        Me.BtnQuitter.TabIndex = 3
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = False
        '
        'BtnScores
        '
        Me.BtnScores.BackColor = System.Drawing.Color.Gray
        Me.BtnScores.ForeColor = System.Drawing.Color.White
        Me.BtnScores.Location = New System.Drawing.Point(110, 12)
        Me.BtnScores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnScores.Name = "BtnScores"
        Me.BtnScores.Size = New System.Drawing.Size(76, 32)
        Me.BtnScores.TabIndex = 4
        Me.BtnScores.Text = "Scores"
        Me.BtnScores.UseVisualStyleBackColor = False
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNom.Location = New System.Drawing.Point(208, 169)
        Me.LblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(134, 21)
        Me.LblNom.TabIndex = 5
        Me.LblNom.Text = "Nom du joueur :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnJouer)
        Me.Panel1.Controls.Add(Me.BtnScores)
        Me.Panel1.Controls.Add(Me.BtnQuitter)
        Me.Panel1.Location = New System.Drawing.Point(175, 262)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 102)
        Me.Panel1.TabIndex = 6
        '
        'lblJeuMemory
        '
        Me.lblJeuMemory.AutoSize = True
        Me.lblJeuMemory.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJeuMemory.ForeColor = System.Drawing.Color.White
        Me.lblJeuMemory.Location = New System.Drawing.Point(140, 65)
        Me.lblJeuMemory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJeuMemory.Name = "lblJeuMemory"
        Me.lblJeuMemory.Size = New System.Drawing.Size(318, 60)
        Me.lblJeuMemory.TabIndex = 7
        Me.lblJeuMemory.Text = "Jeu du Memory"
        '
        'Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(586, 449)
        Me.Controls.Add(Me.lblJeuMemory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblNom)
        Me.Controls.Add(Me.cbNomJoueur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Acceuil"
        Me.Text = "Acceuil"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbNomJoueur As ComboBox
    Friend WithEvents BtnJouer As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnScores As Button
    Friend WithEvents LblNom As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblJeuMemory As Label
End Class
