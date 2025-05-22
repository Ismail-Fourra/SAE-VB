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
        Me.NameListBox = New System.Windows.Forms.ListBox()
        Me.ScoreListBox = New System.Windows.Forms.ListBox()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameListBox
        '
        Me.NameListBox.FormattingEnabled = True
        Me.NameListBox.Location = New System.Drawing.Point(138, 73)
        Me.NameListBox.Name = "NameListBox"
        Me.NameListBox.Size = New System.Drawing.Size(158, 147)
        Me.NameListBox.TabIndex = 0
        '
        'ScoreListBox
        '
        Me.ScoreListBox.FormattingEnabled = True
        Me.ScoreListBox.Location = New System.Drawing.Point(490, 73)
        Me.ScoreListBox.Name = "ScoreListBox"
        Me.ScoreListBox.Size = New System.Drawing.Size(158, 147)
        Me.ScoreListBox.TabIndex = 1
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(283, 319)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(183, 43)
        Me.BtnQuitter.TabIndex = 2
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.ScoreListBox)
        Me.Controls.Add(Me.NameListBox)
        Me.Name = "Scores"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameListBox As ListBox
    Friend WithEvents ScoreListBox As ListBox
    Friend WithEvents BtnQuitter As Button
End Class
