<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultation
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
        Me.Btn_Retour = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Logo = New System.Windows.Forms.Label()
        Me.LB_Consu = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Retour
        '
        Me.Btn_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Retour.FlatAppearance.BorderSize = 0
        Me.Btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Retour.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Retour.ForeColor = System.Drawing.Color.White
        Me.Btn_Retour.Location = New System.Drawing.Point(448, 421)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(338, 42)
        Me.Btn_Retour.TabIndex = 2
        Me.Btn_Retour.Text = "Retour à l'accueil"
        Me.Btn_Retour.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label_Logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 539)
        Me.Panel1.TabIndex = 27
        '
        'Label_Logo
        '
        Me.Label_Logo.AutoSize = True
        Me.Label_Logo.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label_Logo.Location = New System.Drawing.Point(12, 38)
        Me.Label_Logo.Name = "Label_Logo"
        Me.Label_Logo.Size = New System.Drawing.Size(175, 50)
        Me.Label_Logo.TabIndex = 5
        Me.Label_Logo.Text = "Exam'Up"
        '
        'LB_Consu
        '
        Me.LB_Consu.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Consu.FormattingEnabled = True
        Me.LB_Consu.ItemHeight = 21
        Me.LB_Consu.Location = New System.Drawing.Point(250, 38)
        Me.LB_Consu.MultiColumn = True
        Me.LB_Consu.Name = "LB_Consu"
        Me.LB_Consu.Size = New System.Drawing.Size(736, 277)
        Me.LB_Consu.Sorted = True
        Me.LB_Consu.TabIndex = 27
        '
        'Consultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1056, 539)
        Me.Controls.Add(Me.LB_Consu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Name = "Consultation"
        Me.Text = "Consultation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Retour As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LB_Consu As ListBox
    Friend WithEvents Label_Logo As Label
End Class
