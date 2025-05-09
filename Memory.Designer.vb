<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMemory
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
        Me.PanelCartes = New System.Windows.Forms.Panel()
        Me.LblTemps = New System.Windows.Forms.Label()
        Me.LblJoueur = New System.Windows.Forms.Label()
        Me.BtnAbandonner = New System.Windows.Forms.Button()
        Me.pbxCarte1 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte3 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte2 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte6 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte7 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte4 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte5 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte9 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte8 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte11 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte10 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte13 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte15 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte14 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte12 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte20 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte19 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte18 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte16 = New System.Windows.Forms.PictureBox()
        Me.pbxCarte17 = New System.Windows.Forms.PictureBox()
        Me.PanelCartes.SuspendLayout()
        CType(Me.pbxCarte1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCarte17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCartes
        '
        Me.PanelCartes.Controls.Add(Me.pbxCarte17)
        Me.PanelCartes.Controls.Add(Me.pbxCarte16)
        Me.PanelCartes.Controls.Add(Me.pbxCarte18)
        Me.PanelCartes.Controls.Add(Me.pbxCarte19)
        Me.PanelCartes.Controls.Add(Me.pbxCarte20)
        Me.PanelCartes.Controls.Add(Me.pbxCarte12)
        Me.PanelCartes.Controls.Add(Me.pbxCarte14)
        Me.PanelCartes.Controls.Add(Me.pbxCarte15)
        Me.PanelCartes.Controls.Add(Me.pbxCarte13)
        Me.PanelCartes.Controls.Add(Me.pbxCarte10)
        Me.PanelCartes.Controls.Add(Me.pbxCarte11)
        Me.PanelCartes.Controls.Add(Me.pbxCarte8)
        Me.PanelCartes.Controls.Add(Me.pbxCarte9)
        Me.PanelCartes.Controls.Add(Me.pbxCarte5)
        Me.PanelCartes.Controls.Add(Me.pbxCarte4)
        Me.PanelCartes.Controls.Add(Me.pbxCarte7)
        Me.PanelCartes.Controls.Add(Me.pbxCarte6)
        Me.PanelCartes.Controls.Add(Me.pbxCarte2)
        Me.PanelCartes.Controls.Add(Me.pbxCarte3)
        Me.PanelCartes.Controls.Add(Me.pbxCarte1)
        Me.PanelCartes.Location = New System.Drawing.Point(48, 78)
        Me.PanelCartes.Name = "PanelCartes"
        Me.PanelCartes.Size = New System.Drawing.Size(740, 343)
        Me.PanelCartes.TabIndex = 0
        '
        'LblTemps
        '
        Me.LblTemps.AutoSize = True
        Me.LblTemps.Location = New System.Drawing.Point(71, 24)
        Me.LblTemps.Name = "LblTemps"
        Me.LblTemps.Size = New System.Drawing.Size(80, 16)
        Me.LblTemps.TabIndex = 1
        Me.LblTemps.Text = "Temps : 60s"
        '
        'LblJoueur
        '
        Me.LblJoueur.AutoSize = True
        Me.LblJoueur.Location = New System.Drawing.Point(254, 24)
        Me.LblJoueur.Name = "LblJoueur"
        Me.LblJoueur.Size = New System.Drawing.Size(54, 16)
        Me.LblJoueur.TabIndex = 2
        Me.LblJoueur.Text = "Joueur :"
        '
        'BtnAbandonner
        '
        Me.BtnAbandonner.Location = New System.Drawing.Point(399, 24)
        Me.BtnAbandonner.Name = "BtnAbandonner"
        Me.BtnAbandonner.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbandonner.TabIndex = 3
        Me.BtnAbandonner.Text = "Abandonner"
        Me.BtnAbandonner.UseVisualStyleBackColor = True
        '
        'pbxCarte1
        '
        Me.pbxCarte1.Location = New System.Drawing.Point(26, 35)
        Me.pbxCarte1.Name = "pbxCarte1"
        Me.pbxCarte1.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte1.TabIndex = 20
        Me.pbxCarte1.TabStop = False
        '
        'pbxCarte3
        '
        Me.pbxCarte3.Location = New System.Drawing.Point(300, 35)
        Me.pbxCarte3.Name = "pbxCarte3"
        Me.pbxCarte3.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte3.TabIndex = 21
        Me.pbxCarte3.TabStop = False
        '
        'pbxCarte2
        '
        Me.pbxCarte2.Location = New System.Drawing.Point(160, 35)
        Me.pbxCarte2.Name = "pbxCarte2"
        Me.pbxCarte2.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte2.TabIndex = 22
        Me.pbxCarte2.TabStop = False
        '
        'pbxCarte6
        '
        Me.pbxCarte6.Location = New System.Drawing.Point(26, 119)
        Me.pbxCarte6.Name = "pbxCarte6"
        Me.pbxCarte6.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte6.TabIndex = 23
        Me.pbxCarte6.TabStop = False
        '
        'pbxCarte7
        '
        Me.pbxCarte7.Location = New System.Drawing.Point(160, 119)
        Me.pbxCarte7.Name = "pbxCarte7"
        Me.pbxCarte7.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte7.TabIndex = 24
        Me.pbxCarte7.TabStop = False
        '
        'pbxCarte4
        '
        Me.pbxCarte4.Location = New System.Drawing.Point(448, 35)
        Me.pbxCarte4.Name = "pbxCarte4"
        Me.pbxCarte4.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte4.TabIndex = 25
        Me.pbxCarte4.TabStop = False
        '
        'pbxCarte5
        '
        Me.pbxCarte5.Location = New System.Drawing.Point(595, 35)
        Me.pbxCarte5.Name = "pbxCarte5"
        Me.pbxCarte5.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte5.TabIndex = 26
        Me.pbxCarte5.TabStop = False
        '
        'pbxCarte9
        '
        Me.pbxCarte9.Location = New System.Drawing.Point(448, 120)
        Me.pbxCarte9.Name = "pbxCarte9"
        Me.pbxCarte9.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte9.TabIndex = 27
        Me.pbxCarte9.TabStop = False
        '
        'pbxCarte8
        '
        Me.pbxCarte8.Location = New System.Drawing.Point(300, 120)
        Me.pbxCarte8.Name = "pbxCarte8"
        Me.pbxCarte8.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte8.TabIndex = 28
        Me.pbxCarte8.TabStop = False
        '
        'pbxCarte11
        '
        Me.pbxCarte11.Location = New System.Drawing.Point(26, 196)
        Me.pbxCarte11.Name = "pbxCarte11"
        Me.pbxCarte11.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte11.TabIndex = 29
        Me.pbxCarte11.TabStop = False
        '
        'pbxCarte10
        '
        Me.pbxCarte10.Location = New System.Drawing.Point(595, 120)
        Me.pbxCarte10.Name = "pbxCarte10"
        Me.pbxCarte10.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte10.TabIndex = 30
        Me.pbxCarte10.TabStop = False
        '
        'pbxCarte13
        '
        Me.pbxCarte13.Location = New System.Drawing.Point(298, 196)
        Me.pbxCarte13.Name = "pbxCarte13"
        Me.pbxCarte13.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte13.TabIndex = 31
        Me.pbxCarte13.TabStop = False
        '
        'pbxCarte15
        '
        Me.pbxCarte15.Location = New System.Drawing.Point(595, 196)
        Me.pbxCarte15.Name = "pbxCarte15"
        Me.pbxCarte15.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte15.TabIndex = 32
        Me.pbxCarte15.TabStop = False
        '
        'pbxCarte14
        '
        Me.pbxCarte14.Location = New System.Drawing.Point(448, 196)
        Me.pbxCarte14.Name = "pbxCarte14"
        Me.pbxCarte14.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte14.TabIndex = 33
        Me.pbxCarte14.TabStop = False
        '
        'pbxCarte12
        '
        Me.pbxCarte12.Location = New System.Drawing.Point(160, 196)
        Me.pbxCarte12.Name = "pbxCarte12"
        Me.pbxCarte12.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte12.TabIndex = 34
        Me.pbxCarte12.TabStop = False
        '
        'pbxCarte20
        '
        Me.pbxCarte20.Location = New System.Drawing.Point(595, 269)
        Me.pbxCarte20.Name = "pbxCarte20"
        Me.pbxCarte20.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte20.TabIndex = 35
        Me.pbxCarte20.TabStop = False
        '
        'pbxCarte19
        '
        Me.pbxCarte19.Location = New System.Drawing.Point(448, 269)
        Me.pbxCarte19.Name = "pbxCarte19"
        Me.pbxCarte19.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte19.TabIndex = 36
        Me.pbxCarte19.TabStop = False
        '
        'pbxCarte18
        '
        Me.pbxCarte18.Location = New System.Drawing.Point(298, 269)
        Me.pbxCarte18.Name = "pbxCarte18"
        Me.pbxCarte18.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte18.TabIndex = 37
        Me.pbxCarte18.TabStop = False
        '
        'pbxCarte16
        '
        Me.pbxCarte16.Location = New System.Drawing.Point(26, 269)
        Me.pbxCarte16.Name = "pbxCarte16"
        Me.pbxCarte16.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte16.TabIndex = 38
        Me.pbxCarte16.TabStop = False
        '
        'pbxCarte17
        '
        Me.pbxCarte17.Location = New System.Drawing.Point(160, 269)
        Me.pbxCarte17.Name = "pbxCarte17"
        Me.pbxCarte17.Size = New System.Drawing.Size(100, 50)
        Me.pbxCarte17.TabIndex = 39
        Me.pbxCarte17.TabStop = False
        '
        'FormMemory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAbandonner)
        Me.Controls.Add(Me.LblJoueur)
        Me.Controls.Add(Me.LblTemps)
        Me.Controls.Add(Me.PanelCartes)
        Me.Name = "FormMemory"
        Me.Text = "Memory"
        Me.PanelCartes.ResumeLayout(False)
        CType(Me.pbxCarte1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCarte17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelCartes As Panel
    Friend WithEvents LblTemps As Label
    Friend WithEvents LblJoueur As Label
    Friend WithEvents BtnAbandonner As Button
    Friend WithEvents pbxCarte1 As PictureBox
    Friend WithEvents pbxCarte17 As PictureBox
    Friend WithEvents pbxCarte16 As PictureBox
    Friend WithEvents pbxCarte18 As PictureBox
    Friend WithEvents pbxCarte19 As PictureBox
    Friend WithEvents pbxCarte20 As PictureBox
    Friend WithEvents pbxCarte12 As PictureBox
    Friend WithEvents pbxCarte14 As PictureBox
    Friend WithEvents pbxCarte15 As PictureBox
    Friend WithEvents pbxCarte13 As PictureBox
    Friend WithEvents pbxCarte10 As PictureBox
    Friend WithEvents pbxCarte11 As PictureBox
    Friend WithEvents pbxCarte8 As PictureBox
    Friend WithEvents pbxCarte9 As PictureBox
    Friend WithEvents pbxCarte5 As PictureBox
    Friend WithEvents pbxCarte4 As PictureBox
    Friend WithEvents pbxCarte7 As PictureBox
    Friend WithEvents pbxCarte6 As PictureBox
    Friend WithEvents pbxCarte2 As PictureBox
    Friend WithEvents pbxCarte3 As PictureBox
End Class
