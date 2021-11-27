<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recapitulatif
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
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Region = New System.Windows.Forms.Label()
        Me.Label_Epreuves = New System.Windows.Forms.Label()
        Me.Label_Adresse = New System.Windows.Forms.Label()
        Me.Label_CP = New System.Windows.Forms.Label()
        Me.Label_Age = New System.Windows.Forms.Label()
        Me.Label_Ville = New System.Windows.Forms.Label()
        Me.Btn_Validation = New System.Windows.Forms.Button()
        Me.Btn_Retour = New System.Windows.Forms.Button()
        Me.Btn_Abandonner = New System.Windows.Forms.Button()
        Me.Label_Falc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Logo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Nom.ForeColor = System.Drawing.Color.Silver
        Me.Label_Nom.Location = New System.Drawing.Point(228, 55)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(53, 28)
        Me.Label_Nom.TabIndex = 0
        Me.Label_Nom.Text = "Nom"
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Prenom.ForeColor = System.Drawing.Color.Silver
        Me.Label_Prenom.Location = New System.Drawing.Point(228, 114)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(78, 28)
        Me.Label_Prenom.TabIndex = 1
        Me.Label_Prenom.Text = "Prenom"
        '
        'Label_Region
        '
        Me.Label_Region.AutoSize = True
        Me.Label_Region.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Region.ForeColor = System.Drawing.Color.Silver
        Me.Label_Region.Location = New System.Drawing.Point(614, 178)
        Me.Label_Region.Name = "Label_Region"
        Me.Label_Region.Size = New System.Drawing.Size(70, 28)
        Me.Label_Region.TabIndex = 2
        Me.Label_Region.Text = "Region"
        '
        'Label_Epreuves
        '
        Me.Label_Epreuves.AutoSize = True
        Me.Label_Epreuves.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Epreuves.ForeColor = System.Drawing.Color.Silver
        Me.Label_Epreuves.Location = New System.Drawing.Point(195, 395)
        Me.Label_Epreuves.Name = "Label_Epreuves"
        Me.Label_Epreuves.Size = New System.Drawing.Size(88, 28)
        Me.Label_Epreuves.TabIndex = 3
        Me.Label_Epreuves.Text = "Epreuves"
        '
        'Label_Adresse
        '
        Me.Label_Adresse.AutoSize = True
        Me.Label_Adresse.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Adresse.ForeColor = System.Drawing.Color.Silver
        Me.Label_Adresse.Location = New System.Drawing.Point(228, 178)
        Me.Label_Adresse.Name = "Label_Adresse"
        Me.Label_Adresse.Size = New System.Drawing.Size(79, 28)
        Me.Label_Adresse.TabIndex = 4
        Me.Label_Adresse.Text = "Adresse"
        '
        'Label_CP
        '
        Me.Label_CP.AutoSize = True
        Me.Label_CP.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_CP.ForeColor = System.Drawing.Color.Silver
        Me.Label_CP.Location = New System.Drawing.Point(228, 238)
        Me.Label_CP.Name = "Label_CP"
        Me.Label_CP.Size = New System.Drawing.Size(110, 28)
        Me.Label_CP.TabIndex = 5
        Me.Label_CP.Text = "Code Postal"
        '
        'Label_Age
        '
        Me.Label_Age.AutoSize = True
        Me.Label_Age.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Age.ForeColor = System.Drawing.Color.Silver
        Me.Label_Age.Location = New System.Drawing.Point(614, 114)
        Me.Label_Age.Name = "Label_Age"
        Me.Label_Age.Size = New System.Drawing.Size(46, 28)
        Me.Label_Age.TabIndex = 6
        Me.Label_Age.Text = "Age"
        '
        'Label_Ville
        '
        Me.Label_Ville.AutoSize = True
        Me.Label_Ville.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Ville.ForeColor = System.Drawing.Color.Silver
        Me.Label_Ville.Location = New System.Drawing.Point(614, 55)
        Me.Label_Ville.Name = "Label_Ville"
        Me.Label_Ville.Size = New System.Drawing.Size(46, 28)
        Me.Label_Ville.TabIndex = 7
        Me.Label_Ville.Text = "Ville"
        '
        'Btn_Validation
        '
        Me.Btn_Validation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Btn_Validation.FlatAppearance.BorderSize = 0
        Me.Btn_Validation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Validation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Validation.ForeColor = System.Drawing.Color.White
        Me.Btn_Validation.Location = New System.Drawing.Point(882, 55)
        Me.Btn_Validation.Name = "Btn_Validation"
        Me.Btn_Validation.Size = New System.Drawing.Size(194, 77)
        Me.Btn_Validation.TabIndex = 14
        Me.Btn_Validation.Text = "Valider l'inscription"
        Me.Btn_Validation.UseVisualStyleBackColor = False
        '
        'Btn_Retour
        '
        Me.Btn_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Retour.FlatAppearance.BorderSize = 0
        Me.Btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Retour.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Retour.ForeColor = System.Drawing.Color.White
        Me.Btn_Retour.Location = New System.Drawing.Point(882, 271)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(194, 54)
        Me.Btn_Retour.TabIndex = 17
        Me.Btn_Retour.Text = "Retour"
        Me.Btn_Retour.UseVisualStyleBackColor = False
        '
        'Btn_Abandonner
        '
        Me.Btn_Abandonner.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_Abandonner.FlatAppearance.BorderSize = 0
        Me.Btn_Abandonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Abandonner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Abandonner.ForeColor = System.Drawing.Color.White
        Me.Btn_Abandonner.Location = New System.Drawing.Point(882, 152)
        Me.Btn_Abandonner.Name = "Btn_Abandonner"
        Me.Btn_Abandonner.Size = New System.Drawing.Size(194, 82)
        Me.Btn_Abandonner.TabIndex = 18
        Me.Btn_Abandonner.Text = "Abandonner"
        Me.Btn_Abandonner.UseVisualStyleBackColor = False
        '
        'Label_Falc
        '
        Me.Label_Falc.AutoSize = True
        Me.Label_Falc.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Falc.ForeColor = System.Drawing.Color.Silver
        Me.Label_Falc.Location = New System.Drawing.Point(195, 445)
        Me.Label_Falc.Name = "Label_Falc"
        Me.Label_Falc.Size = New System.Drawing.Size(174, 28)
        Me.Label_Falc.TabIndex = 19
        Me.Label_Falc.Text = "Epreuve falcultative"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label_Logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 571)
        Me.Panel1.TabIndex = 20
        '
        'Label_Logo
        '
        Me.Label_Logo.AutoSize = True
        Me.Label_Logo.Font = New System.Drawing.Font("Comic Sans MS", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label_Logo.Location = New System.Drawing.Point(3, 30)
        Me.Label_Logo.Name = "Label_Logo"
        Me.Label_Logo.Size = New System.Drawing.Size(164, 48)
        Me.Label_Logo.TabIndex = 4
        Me.Label_Logo.Text = "Exam'Up"
        '
        'Recapitulatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1174, 571)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label_Falc)
        Me.Controls.Add(Me.Btn_Abandonner)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Controls.Add(Me.Btn_Validation)
        Me.Controls.Add(Me.Label_Ville)
        Me.Controls.Add(Me.Label_Age)
        Me.Controls.Add(Me.Label_CP)
        Me.Controls.Add(Me.Label_Adresse)
        Me.Controls.Add(Me.Label_Epreuves)
        Me.Controls.Add(Me.Label_Region)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Name = "Recapitulatif"
        Me.Text = "Recapitulatif"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Nom As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Region As Label
    Friend WithEvents Label_Epreuves As Label
    Friend WithEvents Label_Adresse As Label
    Friend WithEvents Label_CP As Label
    Friend WithEvents Label_Age As Label
    Friend WithEvents Label_Ville As Label
    Friend WithEvents Btn_Validation As Button
    Friend WithEvents Btn_Retour As Button
    Friend WithEvents Btn_Abandonner As Button
    Friend WithEvents Label_Falc As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_Logo As Label
End Class
