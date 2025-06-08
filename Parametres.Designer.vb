<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParametres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParametres))
        Me.GBThème = New System.Windows.Forms.GroupBox()
        Me.BtnApercuTheme = New System.Windows.Forms.Button()
        Me.PbApercu = New System.Windows.Forms.PictureBox()
        Me.CbTheme = New System.Windows.Forms.ComboBox()
        Me.GbMusique = New System.Windows.Forms.GroupBox()
        Me.CbMusique = New System.Windows.Forms.ComboBox()
        Me.BtnApercuMusique = New System.Windows.Forms.Button()
        Me.TrackBarVolume = New System.Windows.Forms.TrackBar()
        Me.LblVolume = New System.Windows.Forms.Label()
        Me.CbEffetsSonores = New System.Windows.Forms.CheckBox()
        Me.BtnSauvegarder = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.GBThème.SuspendLayout()
        CType(Me.PbApercu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMusique.SuspendLayout()
        CType(Me.TrackBarVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBThème
        '
        Me.GBThème.Controls.Add(Me.BtnApercuTheme)
        Me.GBThème.Controls.Add(Me.PbApercu)
        Me.GBThème.Controls.Add(Me.CbTheme)
        Me.GBThème.Location = New System.Drawing.Point(21, 12)
        Me.GBThème.Name = "GBThème"
        Me.GBThème.Size = New System.Drawing.Size(530, 243)
        Me.GBThème.TabIndex = 0
        Me.GBThème.TabStop = False
        Me.GBThème.Text = "Thème Visuel :"
        '
        'BtnApercuTheme
        '
        Me.BtnApercuTheme.Location = New System.Drawing.Point(420, 99)
        Me.BtnApercuTheme.Name = "BtnApercuTheme"
        Me.BtnApercuTheme.Size = New System.Drawing.Size(75, 45)
        Me.BtnApercuTheme.TabIndex = 2
        Me.BtnApercuTheme.Text = "Aperçu"
        Me.BtnApercuTheme.UseVisualStyleBackColor = True
        '
        'PbApercu
        '
        Me.PbApercu.Location = New System.Drawing.Point(190, 51)
        Me.PbApercu.Name = "PbApercu"
        Me.PbApercu.Size = New System.Drawing.Size(213, 137)
        Me.PbApercu.TabIndex = 1
        Me.PbApercu.TabStop = False
        '
        'CbTheme
        '
        Me.CbTheme.FormattingEnabled = True
        Me.CbTheme.Location = New System.Drawing.Point(190, 21)
        Me.CbTheme.Name = "CbTheme"
        Me.CbTheme.Size = New System.Drawing.Size(213, 24)
        Me.CbTheme.TabIndex = 0
        '
        'GbMusique
        '
        Me.GbMusique.Controls.Add(Me.CbMusique)
        Me.GbMusique.Controls.Add(Me.BtnApercuMusique)
        Me.GbMusique.Controls.Add(Me.TrackBarVolume)
        Me.GbMusique.Controls.Add(Me.LblVolume)
        Me.GbMusique.Controls.Add(Me.CbEffetsSonores)
        Me.GbMusique.Location = New System.Drawing.Point(21, 261)
        Me.GbMusique.Name = "GbMusique"
        Me.GbMusique.Size = New System.Drawing.Size(546, 160)
        Me.GbMusique.TabIndex = 1
        Me.GbMusique.TabStop = False
        Me.GbMusique.Text = "Musique de fond :"
        '
        'CbMusique
        '
        Me.CbMusique.FormattingEnabled = True
        Me.CbMusique.Location = New System.Drawing.Point(271, 37)
        Me.CbMusique.Name = "CbMusique"
        Me.CbMusique.Size = New System.Drawing.Size(121, 24)
        Me.CbMusique.TabIndex = 6
        '
        'BtnApercuMusique
        '
        Me.BtnApercuMusique.Location = New System.Drawing.Point(411, 32)
        Me.BtnApercuMusique.Name = "BtnApercuMusique"
        Me.BtnApercuMusique.Size = New System.Drawing.Size(119, 65)
        Me.BtnApercuMusique.TabIndex = 3
        Me.BtnApercuMusique.Text = "Écouter un aperçu"
        Me.BtnApercuMusique.UseVisualStyleBackColor = True
        '
        'TrackBarVolume
        '
        Me.TrackBarVolume.Location = New System.Drawing.Point(156, 103)
        Me.TrackBarVolume.Name = "TrackBarVolume"
        Me.TrackBarVolume.Size = New System.Drawing.Size(339, 56)
        Me.TrackBarVolume.TabIndex = 2
        '
        'LblVolume
        '
        Me.LblVolume.AutoSize = True
        Me.LblVolume.Location = New System.Drawing.Point(22, 112)
        Me.LblVolume.Name = "LblVolume"
        Me.LblVolume.Size = New System.Drawing.Size(108, 16)
        Me.LblVolume.TabIndex = 1
        Me.LblVolume.Text = "Volume géneral :"
        '
        'CbEffetsSonores
        '
        Me.CbEffetsSonores.AutoSize = True
        Me.CbEffetsSonores.Location = New System.Drawing.Point(45, 44)
        Me.CbEffetsSonores.Name = "CbEffetsSonores"
        Me.CbEffetsSonores.Size = New System.Drawing.Size(178, 20)
        Me.CbEffetsSonores.TabIndex = 0
        Me.CbEffetsSonores.Text = "Activer les effets sonores"
        Me.CbEffetsSonores.UseVisualStyleBackColor = True
        '
        'BtnSauvegarder
        '
        Me.BtnSauvegarder.Location = New System.Drawing.Point(55, 450)
        Me.BtnSauvegarder.Name = "BtnSauvegarder"
        Me.BtnSauvegarder.Size = New System.Drawing.Size(218, 32)
        Me.BtnSauvegarder.TabIndex = 4
        Me.BtnSauvegarder.Text = "Sauvegarder les modifications"
        Me.BtnSauvegarder.UseVisualStyleBackColor = True
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(381, 450)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(135, 32)
        Me.BtnRetour.TabIndex = 5
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'FormParametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAE_VB.My.Resources.Resources.Fond_MemoryFlags
        Me.ClientSize = New System.Drawing.Size(600, 513)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnSauvegarder)
        Me.Controls.Add(Me.GbMusique)
        Me.Controls.Add(Me.GBThème)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormParametres"
        Me.Text = "Paramètres"
        Me.GBThème.ResumeLayout(False)
        CType(Me.PbApercu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMusique.ResumeLayout(False)
        Me.GbMusique.PerformLayout()
        CType(Me.TrackBarVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBThème As GroupBox
    Friend WithEvents PbApercu As PictureBox
    Friend WithEvents CbTheme As ComboBox
    Friend WithEvents GbMusique As GroupBox
    Friend WithEvents TrackBarVolume As TrackBar
    Friend WithEvents LblVolume As Label
    Friend WithEvents CbEffetsSonores As CheckBox
    Friend WithEvents BtnApercuTheme As Button
    Friend WithEvents CbMusique As ComboBox
    Friend WithEvents BtnApercuMusique As Button
    Friend WithEvents BtnSauvegarder As Button
    Friend WithEvents BtnRetour As Button
End Class
