<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modification
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
        Me.Combo_Modif = New System.Windows.Forms.ComboBox()
        Me.Btn_Retour = New System.Windows.Forms.Button()
        Me.Btn_Modif = New System.Windows.Forms.Button()
        Me.Btn_Suppr = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Logo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Combo_Modif
        '
        Me.Combo_Modif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Modif.FormattingEnabled = True
        Me.Combo_Modif.Location = New System.Drawing.Point(287, 127)
        Me.Combo_Modif.Name = "Combo_Modif"
        Me.Combo_Modif.Size = New System.Drawing.Size(336, 28)
        Me.Combo_Modif.TabIndex = 0
        '
        'Btn_Retour
        '
        Me.Btn_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Retour.FlatAppearance.BorderSize = 0
        Me.Btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Retour.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Retour.ForeColor = System.Drawing.Color.White
        Me.Btn_Retour.Location = New System.Drawing.Point(283, 371)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(338, 42)
        Me.Btn_Retour.TabIndex = 1
        Me.Btn_Retour.Text = "Retour à l'accueil"
        Me.Btn_Retour.UseVisualStyleBackColor = False
        '
        'Btn_Modif
        '
        Me.Btn_Modif.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Btn_Modif.FlatAppearance.BorderSize = 0
        Me.Btn_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modif.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Modif.ForeColor = System.Drawing.Color.White
        Me.Btn_Modif.Location = New System.Drawing.Point(287, 217)
        Me.Btn_Modif.Name = "Btn_Modif"
        Me.Btn_Modif.Size = New System.Drawing.Size(332, 52)
        Me.Btn_Modif.TabIndex = 2
        Me.Btn_Modif.Text = "Modifier l'inscription"
        Me.Btn_Modif.UseVisualStyleBackColor = False
        '
        'Btn_Suppr
        '
        Me.Btn_Suppr.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_Suppr.FlatAppearance.BorderSize = 0
        Me.Btn_Suppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Suppr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Suppr.ForeColor = System.Drawing.Color.White
        Me.Btn_Suppr.Location = New System.Drawing.Point(291, 295)
        Me.Btn_Suppr.Name = "Btn_Suppr"
        Me.Btn_Suppr.Size = New System.Drawing.Size(332, 52)
        Me.Btn_Suppr.TabIndex = 3
        Me.Btn_Suppr.Text = "Supprimer l'inscription"
        Me.Btn_Suppr.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label_Logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 449)
        Me.Panel1.TabIndex = 4
        '
        'Label_Logo
        '
        Me.Label_Logo.AutoSize = True
        Me.Label_Logo.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label_Logo.Location = New System.Drawing.Point(3, 35)
        Me.Label_Logo.Name = "Label_Logo"
        Me.Label_Logo.Size = New System.Drawing.Size(175, 50)
        Me.Label_Logo.TabIndex = 5
        Me.Label_Logo.Text = "Exam'Up"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(262, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Choisissez quelle inscription vous voulez modifier"
        '
        'Modification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Suppr)
        Me.Controls.Add(Me.Btn_Modif)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Controls.Add(Me.Combo_Modif)
        Me.Name = "Modification"
        Me.Text = "Modification"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combo_Modif As ComboBox
    Friend WithEvents Btn_Retour As Button
    Friend WithEvents Btn_Modif As Button
    Friend WithEvents Btn_Suppr As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_Logo As Label
    Friend WithEvents Label1 As Label
End Class
