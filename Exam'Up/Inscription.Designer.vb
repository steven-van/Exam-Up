<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Txt_Nom = New System.Windows.Forms.TextBox()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Txt_Age = New System.Windows.Forms.TextBox()
        Me.Txt_CP = New System.Windows.Forms.TextBox()
        Me.Txt_Adresse = New System.Windows.Forms.TextBox()
        Me.Txt_Ville = New System.Windows.Forms.TextBox()
        Me.Btn_Abandon = New System.Windows.Forms.Button()
        Me.Btn_Validation = New System.Windows.Forms.Button()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Age = New System.Windows.Forms.Label()
        Me.Label_Adresse = New System.Windows.Forms.Label()
        Me.Label_CP = New System.Windows.Forms.Label()
        Me.Label_Ville = New System.Windows.Forms.Label()
        Me.Scrollbar_Age = New System.Windows.Forms.HScrollBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Logo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Nom
        '
        Me.Txt_Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Txt_Nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Nom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txt_Nom.ForeColor = System.Drawing.Color.Silver
        Me.Txt_Nom.Location = New System.Drawing.Point(260, 70)
        Me.Txt_Nom.MaxLength = 15
        Me.Txt_Nom.Name = "Txt_Nom"
        Me.Txt_Nom.Size = New System.Drawing.Size(270, 27)
        Me.Txt_Nom.TabIndex = 0
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Txt_Prenom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Prenom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txt_Prenom.ForeColor = System.Drawing.Color.Silver
        Me.Txt_Prenom.Location = New System.Drawing.Point(260, 167)
        Me.Txt_Prenom.MaxLength = 20
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(270, 27)
        Me.Txt_Prenom.TabIndex = 1
        '
        'Txt_Age
        '
        Me.Txt_Age.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Txt_Age.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Age.Enabled = False
        Me.Txt_Age.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt_Age.ForeColor = System.Drawing.Color.Silver
        Me.Txt_Age.Location = New System.Drawing.Point(320, 266)
        Me.Txt_Age.Name = "Txt_Age"
        Me.Txt_Age.Size = New System.Drawing.Size(69, 32)
        Me.Txt_Age.TabIndex = 2
        '
        'Txt_CP
        '
        Me.Txt_CP.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Txt_CP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_CP.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txt_CP.ForeColor = System.Drawing.Color.Silver
        Me.Txt_CP.Location = New System.Drawing.Point(603, 167)
        Me.Txt_CP.MaxLength = 5
        Me.Txt_CP.Name = "Txt_CP"
        Me.Txt_CP.Size = New System.Drawing.Size(100, 27)
        Me.Txt_CP.TabIndex = 5
        '
        'Txt_Adresse
        '
        Me.Txt_Adresse.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Txt_Adresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Adresse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txt_Adresse.ForeColor = System.Drawing.Color.Silver
        Me.Txt_Adresse.Location = New System.Drawing.Point(603, 70)
        Me.Txt_Adresse.MaxLength = 30
        Me.Txt_Adresse.Name = "Txt_Adresse"
        Me.Txt_Adresse.Size = New System.Drawing.Size(270, 27)
        Me.Txt_Adresse.TabIndex = 4
        '
        'Txt_Ville
        '
        Me.Txt_Ville.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Txt_Ville.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Ville.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txt_Ville.ForeColor = System.Drawing.Color.Silver
        Me.Txt_Ville.Location = New System.Drawing.Point(603, 312)
        Me.Txt_Ville.MaxLength = 15
        Me.Txt_Ville.Name = "Txt_Ville"
        Me.Txt_Ville.Size = New System.Drawing.Size(175, 27)
        Me.Txt_Ville.TabIndex = 6
        '
        'Btn_Abandon
        '
        Me.Btn_Abandon.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_Abandon.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Abandon.FlatAppearance.BorderSize = 0
        Me.Btn_Abandon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Abandon.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Abandon.ForeColor = System.Drawing.Color.White
        Me.Btn_Abandon.Location = New System.Drawing.Point(356, 466)
        Me.Btn_Abandon.Name = "Btn_Abandon"
        Me.Btn_Abandon.Size = New System.Drawing.Size(174, 62)
        Me.Btn_Abandon.TabIndex = 7
        Me.Btn_Abandon.Text = "Abandon"
        Me.Btn_Abandon.UseVisualStyleBackColor = False
        '
        'Btn_Validation
        '
        Me.Btn_Validation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Btn_Validation.FlatAppearance.BorderSize = 0
        Me.Btn_Validation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Validation.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Validation.ForeColor = System.Drawing.Color.White
        Me.Btn_Validation.Location = New System.Drawing.Point(603, 466)
        Me.Btn_Validation.Name = "Btn_Validation"
        Me.Btn_Validation.Size = New System.Drawing.Size(174, 62)
        Me.Btn_Validation.TabIndex = 8
        Me.Btn_Validation.Text = "Validation"
        Me.Btn_Validation.UseVisualStyleBackColor = False
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Nom.ForeColor = System.Drawing.Color.Silver
        Me.Label_Nom.Location = New System.Drawing.Point(256, 36)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(53, 28)
        Me.Label_Nom.TabIndex = 8
        Me.Label_Nom.Text = "Nom"
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Prenom.ForeColor = System.Drawing.Color.Silver
        Me.Label_Prenom.Location = New System.Drawing.Point(256, 132)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(78, 28)
        Me.Label_Prenom.TabIndex = 9
        Me.Label_Prenom.Text = "Prénom"
        '
        'Label_Age
        '
        Me.Label_Age.AutoSize = True
        Me.Label_Age.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Age.ForeColor = System.Drawing.Color.Silver
        Me.Label_Age.Location = New System.Drawing.Point(256, 272)
        Me.Label_Age.Name = "Label_Age"
        Me.Label_Age.Size = New System.Drawing.Size(46, 28)
        Me.Label_Age.TabIndex = 10
        Me.Label_Age.Text = "Age"
        '
        'Label_Adresse
        '
        Me.Label_Adresse.AutoSize = True
        Me.Label_Adresse.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Adresse.ForeColor = System.Drawing.Color.Silver
        Me.Label_Adresse.Location = New System.Drawing.Point(599, 36)
        Me.Label_Adresse.Name = "Label_Adresse"
        Me.Label_Adresse.Size = New System.Drawing.Size(79, 28)
        Me.Label_Adresse.TabIndex = 11
        Me.Label_Adresse.Text = "Adresse"
        '
        'Label_CP
        '
        Me.Label_CP.AutoSize = True
        Me.Label_CP.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_CP.ForeColor = System.Drawing.Color.Silver
        Me.Label_CP.Location = New System.Drawing.Point(599, 132)
        Me.Label_CP.Name = "Label_CP"
        Me.Label_CP.Size = New System.Drawing.Size(110, 28)
        Me.Label_CP.TabIndex = 12
        Me.Label_CP.Text = "Code Postal"
        '
        'Label_Ville
        '
        Me.Label_Ville.AutoSize = True
        Me.Label_Ville.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Ville.ForeColor = System.Drawing.Color.Silver
        Me.Label_Ville.Location = New System.Drawing.Point(599, 269)
        Me.Label_Ville.Name = "Label_Ville"
        Me.Label_Ville.Size = New System.Drawing.Size(46, 28)
        Me.Label_Ville.TabIndex = 13
        Me.Label_Ville.Text = "Ville"
        '
        'Scrollbar_Age
        '
        Me.Scrollbar_Age.LargeChange = 1
        Me.Scrollbar_Age.Location = New System.Drawing.Point(260, 312)
        Me.Scrollbar_Age.Maximum = 55
        Me.Scrollbar_Age.Minimum = 18
        Me.Scrollbar_Age.Name = "Scrollbar_Age"
        Me.Scrollbar_Age.Size = New System.Drawing.Size(270, 26)
        Me.Scrollbar_Age.TabIndex = 14
        Me.Scrollbar_Age.Value = 18
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label_Logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 589)
        Me.Panel1.TabIndex = 15
        '
        'Label_Logo
        '
        Me.Label_Logo.AutoSize = True
        Me.Label_Logo.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label_Logo.Location = New System.Drawing.Point(12, 36)
        Me.Label_Logo.Name = "Label_Logo"
        Me.Label_Logo.Size = New System.Drawing.Size(175, 50)
        Me.Label_Logo.TabIndex = 5
        Me.Label_Logo.Text = "Exam'Up"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(260, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 1)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(261, 200)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 1)
        Me.Panel3.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(604, 103)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 1)
        Me.Panel4.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(604, 200)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 1)
        Me.Panel5.TabIndex = 17
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(604, 345)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(250, 1)
        Me.Panel6.TabIndex = 17
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(983, 589)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Scrollbar_Age)
        Me.Controls.Add(Me.Label_Ville)
        Me.Controls.Add(Me.Label_CP)
        Me.Controls.Add(Me.Label_Adresse)
        Me.Controls.Add(Me.Label_Age)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.Btn_Validation)
        Me.Controls.Add(Me.Btn_Abandon)
        Me.Controls.Add(Me.Txt_Ville)
        Me.Controls.Add(Me.Txt_Adresse)
        Me.Controls.Add(Me.Txt_CP)
        Me.Controls.Add(Me.Txt_Age)
        Me.Controls.Add(Me.Txt_Prenom)
        Me.Controls.Add(Me.Txt_Nom)
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Nom As TextBox
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Txt_Age As TextBox
    Friend WithEvents Txt_CP As TextBox
    Friend WithEvents Txt_Adresse As TextBox
    Friend WithEvents Txt_Ville As TextBox
    Friend WithEvents Btn_Abandon As Button
    Friend WithEvents Btn_Validation As Button
    Friend WithEvents Label_Nom As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Age As Label
    Friend WithEvents Label_Adresse As Label
    Friend WithEvents Label_CP As Label
    Friend WithEvents Label_Ville As Label
    Friend WithEvents Scrollbar_Age As HScrollBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_Logo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
