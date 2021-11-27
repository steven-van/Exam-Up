<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Me.Btn_Inscri = New System.Windows.Forms.Button()
        Me.Btn_Modif = New System.Windows.Forms.Button()
        Me.Btn_Consu = New System.Windows.Forms.Button()
        Me.Label_Logo = New System.Windows.Forms.Label()
        Me.Label_I = New System.Windows.Forms.Label()
        Me.Btn_Bilan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Inscri
        '
        Me.Btn_Inscri.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Inscri.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Inscri.FlatAppearance.BorderSize = 0
        Me.Btn_Inscri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Inscri.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inscri.ForeColor = System.Drawing.Color.White
        Me.Btn_Inscri.Location = New System.Drawing.Point(127, 247)
        Me.Btn_Inscri.Name = "Btn_Inscri"
        Me.Btn_Inscri.Size = New System.Drawing.Size(202, 94)
        Me.Btn_Inscri.TabIndex = 0
        Me.Btn_Inscri.Text = "S'inscrire"
        Me.Btn_Inscri.UseVisualStyleBackColor = False
        '
        'Btn_Modif
        '
        Me.Btn_Modif.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Modif.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Modif.FlatAppearance.BorderSize = 0
        Me.Btn_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modif.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modif.ForeColor = System.Drawing.Color.White
        Me.Btn_Modif.Location = New System.Drawing.Point(446, 247)
        Me.Btn_Modif.Name = "Btn_Modif"
        Me.Btn_Modif.Size = New System.Drawing.Size(202, 94)
        Me.Btn_Modif.TabIndex = 1
        Me.Btn_Modif.Text = "Modifier une inscription"
        Me.Btn_Modif.UseVisualStyleBackColor = False
        '
        'Btn_Consu
        '
        Me.Btn_Consu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Consu.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Consu.FlatAppearance.BorderSize = 0
        Me.Btn_Consu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Consu.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Consu.ForeColor = System.Drawing.Color.White
        Me.Btn_Consu.Location = New System.Drawing.Point(446, 405)
        Me.Btn_Consu.Name = "Btn_Consu"
        Me.Btn_Consu.Size = New System.Drawing.Size(202, 95)
        Me.Btn_Consu.TabIndex = 2
        Me.Btn_Consu.Text = "Consulter l'état des inscriptions"
        Me.Btn_Consu.UseVisualStyleBackColor = False
        '
        'Label_Logo
        '
        Me.Label_Logo.AutoSize = True
        Me.Label_Logo.Font = New System.Drawing.Font("Comic Sans MS", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label_Logo.Location = New System.Drawing.Point(240, 86)
        Me.Label_Logo.Name = "Label_Logo"
        Me.Label_Logo.Size = New System.Drawing.Size(271, 78)
        Me.Label_Logo.TabIndex = 3
        Me.Label_Logo.Text = "Exam'Up"
        '
        'Label_I
        '
        Me.Label_I.AutoSize = True
        Me.Label_I.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_I.ForeColor = System.Drawing.Color.Silver
        Me.Label_I.Location = New System.Drawing.Point(314, 164)
        Me.Label_I.Name = "Label_I"
        Me.Label_I.Size = New System.Drawing.Size(118, 25)
        Me.Label_I.TabIndex = 4
        Me.Label_I.Text = "Inscrivez-vous"
        '
        'Btn_Bilan
        '
        Me.Btn_Bilan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Bilan.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Bilan.FlatAppearance.BorderSize = 0
        Me.Btn_Bilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Bilan.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Bilan.ForeColor = System.Drawing.Color.White
        Me.Btn_Bilan.Location = New System.Drawing.Point(127, 406)
        Me.Btn_Bilan.Name = "Btn_Bilan"
        Me.Btn_Bilan.Size = New System.Drawing.Size(202, 94)
        Me.Btn_Bilan.TabIndex = 5
        Me.Btn_Bilan.Text = "Bilan des inscription"
        Me.Btn_Bilan.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 611)
        Me.Controls.Add(Me.Btn_Bilan)
        Me.Controls.Add(Me.Label_I)
        Me.Controls.Add(Me.Label_Logo)
        Me.Controls.Add(Me.Btn_Consu)
        Me.Controls.Add(Me.Btn_Modif)
        Me.Controls.Add(Me.Btn_Inscri)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Inscri As Button
    Friend WithEvents Btn_Modif As Button
    Friend WithEvents Btn_Consu As Button
    Friend WithEvents Label_Logo As Label
    Friend WithEvents Label_I As Label
    Friend WithEvents Btn_Bilan As Button
End Class
