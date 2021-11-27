<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoixEpreuve
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
        Me.components = New System.ComponentModel.Container()
        Me.Combo_Region = New System.Windows.Forms.ComboBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Region = New System.Windows.Forms.Label()
        Me.Btn_Validation = New System.Windows.Forms.Button()
        Me.Btn_Abandonner = New System.Windows.Forms.Button()
        Me.CB_Droit2 = New System.Windows.Forms.CheckBox()
        Me.CB_Res2 = New System.Windows.Forms.CheckBox()
        Me.CB_Esp = New System.Windows.Forms.CheckBox()
        Me.CB_Anglais = New System.Windows.Forms.CheckBox()
        Me.CB_Chinois = New System.Windows.Forms.CheckBox()
        Me.CB_Math2 = New System.Windows.Forms.CheckBox()
        Me.CB_Exp2 = New System.Windows.Forms.CheckBox()
        Me.CB_Sys2 = New System.Windows.Forms.CheckBox()
        Me.CB_Gestion2 = New System.Windows.Forms.CheckBox()
        Me.RB_Oui = New System.Windows.Forms.RadioButton()
        Me.Combo_Falc = New System.Windows.Forms.ComboBox()
        Me.RB_Non = New System.Windows.Forms.RadioButton()
        Me.GB_Choix = New System.Windows.Forms.GroupBox()
        Me.ChoixRestant2 = New System.Windows.Forms.Label()
        Me.Panel_Ecrit = New System.Windows.Forms.Panel()
        Me.CB_VB = New System.Windows.Forms.CheckBox()
        Me.CB_Algo = New System.Windows.Forms.CheckBox()
        Me.CB_Math = New System.Windows.Forms.CheckBox()
        Me.CB_Gestion = New System.Windows.Forms.CheckBox()
        Me.CB_Exp = New System.Windows.Forms.CheckBox()
        Me.CB_PW = New System.Windows.Forms.CheckBox()
        Me.CB_Sys = New System.Windows.Forms.CheckBox()
        Me.CB_Res = New System.Windows.Forms.CheckBox()
        Me.CB_Java = New System.Windows.Forms.CheckBox()
        Me.CB_BD = New System.Windows.Forms.CheckBox()
        Me.CB_Droit = New System.Windows.Forms.CheckBox()
        Me.CB_C = New System.Windows.Forms.CheckBox()
        Me.GB_Falc = New System.Windows.Forms.GroupBox()
        Me.Panel_Oral = New System.Windows.Forms.Panel()
        Me.ChoixRestant = New System.Windows.Forms.Label()
        Me.Btn_Retour = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Logo = New System.Windows.Forms.Label()
        Me.GB_Choix.SuspendLayout()
        Me.Panel_Ecrit.SuspendLayout()
        Me.GB_Falc.SuspendLayout()
        Me.Panel_Oral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Combo_Region
        '
        Me.Combo_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Region.FormattingEnabled = True
        Me.Combo_Region.Items.AddRange(New Object() {"Auvergne", "Bordelais", "Bourgogne", "Bretagne ", "Corse", "Nord ", "Normandie ", "Paris", "Poitou ", "Roussillon"})
        Me.Combo_Region.Location = New System.Drawing.Point(657, 132)
        Me.Combo_Region.Name = "Combo_Region"
        Me.Combo_Region.Size = New System.Drawing.Size(228, 28)
        Me.Combo_Region.TabIndex = 0
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Nom.ForeColor = System.Drawing.Color.Silver
        Me.Label_Nom.Location = New System.Drawing.Point(498, 31)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(105, 28)
        Me.Label_Nom.TabIndex = 7
        Me.Label_Nom.Text = "Label_Nom"
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Prenom.ForeColor = System.Drawing.Color.Silver
        Me.Label_Prenom.Location = New System.Drawing.Point(498, 78)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(130, 28)
        Me.Label_Prenom.TabIndex = 8
        Me.Label_Prenom.Text = "Label_Prenom"
        '
        'Label_Region
        '
        Me.Label_Region.AutoSize = True
        Me.Label_Region.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label_Region.ForeColor = System.Drawing.Color.Silver
        Me.Label_Region.Location = New System.Drawing.Point(498, 132)
        Me.Label_Region.Name = "Label_Region"
        Me.Label_Region.Size = New System.Drawing.Size(70, 28)
        Me.Label_Region.TabIndex = 9
        Me.Label_Region.Text = "Region"
        '
        'Btn_Validation
        '
        Me.Btn_Validation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Btn_Validation.FlatAppearance.BorderSize = 0
        Me.Btn_Validation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Validation.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Validation.ForeColor = System.Drawing.Color.White
        Me.Btn_Validation.Location = New System.Drawing.Point(952, 638)
        Me.Btn_Validation.Name = "Btn_Validation"
        Me.Btn_Validation.Size = New System.Drawing.Size(194, 82)
        Me.Btn_Validation.TabIndex = 16
        Me.Btn_Validation.Text = "Valider"
        Me.Btn_Validation.UseVisualStyleBackColor = False
        '
        'Btn_Abandonner
        '
        Me.Btn_Abandonner.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_Abandonner.FlatAppearance.BorderSize = 0
        Me.Btn_Abandonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Abandonner.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Abandonner.ForeColor = System.Drawing.Color.White
        Me.Btn_Abandonner.Location = New System.Drawing.Point(694, 638)
        Me.Btn_Abandonner.Name = "Btn_Abandonner"
        Me.Btn_Abandonner.Size = New System.Drawing.Size(196, 82)
        Me.Btn_Abandonner.TabIndex = 17
        Me.Btn_Abandonner.Text = "Abandonner"
        Me.Btn_Abandonner.UseVisualStyleBackColor = False
        '
        'CB_Droit2
        '
        Me.CB_Droit2.AutoSize = True
        Me.CB_Droit2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Droit2.ForeColor = System.Drawing.Color.Silver
        Me.CB_Droit2.Location = New System.Drawing.Point(236, 18)
        Me.CB_Droit2.Name = "CB_Droit2"
        Me.CB_Droit2.Size = New System.Drawing.Size(79, 32)
        Me.CB_Droit2.TabIndex = 22
        Me.CB_Droit2.Text = "Droit"
        Me.CB_Droit2.UseVisualStyleBackColor = True
        '
        'CB_Res2
        '
        Me.CB_Res2.AutoSize = True
        Me.CB_Res2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Res2.ForeColor = System.Drawing.Color.Silver
        Me.CB_Res2.Location = New System.Drawing.Point(36, 228)
        Me.CB_Res2.Name = "CB_Res2"
        Me.CB_Res2.Size = New System.Drawing.Size(98, 32)
        Me.CB_Res2.TabIndex = 21
        Me.CB_Res2.Text = "Reseau"
        Me.CB_Res2.UseVisualStyleBackColor = True
        '
        'CB_Esp
        '
        Me.CB_Esp.AutoSize = True
        Me.CB_Esp.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Esp.ForeColor = System.Drawing.Color.Silver
        Me.CB_Esp.Location = New System.Drawing.Point(236, 178)
        Me.CB_Esp.Name = "CB_Esp"
        Me.CB_Esp.Size = New System.Drawing.Size(114, 32)
        Me.CB_Esp.TabIndex = 20
        Me.CB_Esp.Text = "Espagnol"
        Me.CB_Esp.UseVisualStyleBackColor = True
        '
        'CB_Anglais
        '
        Me.CB_Anglais.AutoSize = True
        Me.CB_Anglais.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Anglais.ForeColor = System.Drawing.Color.Silver
        Me.CB_Anglais.Location = New System.Drawing.Point(236, 74)
        Me.CB_Anglais.Name = "CB_Anglais"
        Me.CB_Anglais.Size = New System.Drawing.Size(99, 32)
        Me.CB_Anglais.TabIndex = 19
        Me.CB_Anglais.Text = "Anglais"
        Me.CB_Anglais.UseVisualStyleBackColor = True
        '
        'CB_Chinois
        '
        Me.CB_Chinois.AutoSize = True
        Me.CB_Chinois.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Chinois.ForeColor = System.Drawing.Color.Silver
        Me.CB_Chinois.Location = New System.Drawing.Point(236, 125)
        Me.CB_Chinois.Name = "CB_Chinois"
        Me.CB_Chinois.Size = New System.Drawing.Size(99, 32)
        Me.CB_Chinois.TabIndex = 18
        Me.CB_Chinois.Text = "Chinois"
        Me.CB_Chinois.UseVisualStyleBackColor = True
        '
        'CB_Math2
        '
        Me.CB_Math2.AutoSize = True
        Me.CB_Math2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Math2.ForeColor = System.Drawing.Color.Silver
        Me.CB_Math2.Location = New System.Drawing.Point(36, 178)
        Me.CB_Math2.Name = "CB_Math2"
        Me.CB_Math2.Size = New System.Drawing.Size(168, 32)
        Me.CB_Math2.TabIndex = 17
        Me.CB_Math2.Text = "Mathématiques"
        Me.CB_Math2.UseVisualStyleBackColor = True
        '
        'CB_Exp2
        '
        Me.CB_Exp2.AutoSize = True
        Me.CB_Exp2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Exp2.ForeColor = System.Drawing.Color.Silver
        Me.CB_Exp2.Location = New System.Drawing.Point(36, 123)
        Me.CB_Exp2.Name = "CB_Exp2"
        Me.CB_Exp2.Size = New System.Drawing.Size(126, 32)
        Me.CB_Exp2.TabIndex = 16
        Me.CB_Exp2.Text = "Expression"
        Me.CB_Exp2.UseVisualStyleBackColor = True
        '
        'CB_Sys2
        '
        Me.CB_Sys2.AutoSize = True
        Me.CB_Sys2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Sys2.ForeColor = System.Drawing.Color.Silver
        Me.CB_Sys2.Location = New System.Drawing.Point(36, 69)
        Me.CB_Sys2.Name = "CB_Sys2"
        Me.CB_Sys2.Size = New System.Drawing.Size(107, 32)
        Me.CB_Sys2.TabIndex = 15
        Me.CB_Sys2.Text = "Système"
        Me.CB_Sys2.UseVisualStyleBackColor = True
        '
        'CB_Gestion2
        '
        Me.CB_Gestion2.AutoSize = True
        Me.CB_Gestion2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Gestion2.ForeColor = System.Drawing.Color.Silver
        Me.CB_Gestion2.Location = New System.Drawing.Point(36, 18)
        Me.CB_Gestion2.Name = "CB_Gestion2"
        Me.CB_Gestion2.Size = New System.Drawing.Size(101, 32)
        Me.CB_Gestion2.TabIndex = 6
        Me.CB_Gestion2.Text = "Gestion"
        Me.CB_Gestion2.UseVisualStyleBackColor = True
        '
        'RB_Oui
        '
        Me.RB_Oui.AutoSize = True
        Me.RB_Oui.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.RB_Oui.ForeColor = System.Drawing.Color.Silver
        Me.RB_Oui.Location = New System.Drawing.Point(33, 48)
        Me.RB_Oui.Name = "RB_Oui"
        Me.RB_Oui.Size = New System.Drawing.Size(67, 32)
        Me.RB_Oui.TabIndex = 11
        Me.RB_Oui.TabStop = True
        Me.RB_Oui.Text = "Oui"
        Me.RB_Oui.UseVisualStyleBackColor = True
        '
        'Combo_Falc
        '
        Me.Combo_Falc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Falc.FormattingEnabled = True
        Me.Combo_Falc.Location = New System.Drawing.Point(33, 162)
        Me.Combo_Falc.Name = "Combo_Falc"
        Me.Combo_Falc.Size = New System.Drawing.Size(211, 36)
        Me.Combo_Falc.TabIndex = 10
        Me.Combo_Falc.Visible = False
        '
        'RB_Non
        '
        Me.RB_Non.AutoSize = True
        Me.RB_Non.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.RB_Non.ForeColor = System.Drawing.Color.Silver
        Me.RB_Non.Location = New System.Drawing.Point(33, 104)
        Me.RB_Non.Name = "RB_Non"
        Me.RB_Non.Size = New System.Drawing.Size(73, 32)
        Me.RB_Non.TabIndex = 12
        Me.RB_Non.TabStop = True
        Me.RB_Non.Text = "Non"
        Me.RB_Non.UseVisualStyleBackColor = True
        '
        'GB_Choix
        '
        Me.GB_Choix.Controls.Add(Me.ChoixRestant2)
        Me.GB_Choix.Controls.Add(Me.Panel_Ecrit)
        Me.GB_Choix.Controls.Add(Me.GB_Falc)
        Me.GB_Choix.Controls.Add(Me.Panel_Oral)
        Me.GB_Choix.Controls.Add(Me.ChoixRestant)
        Me.GB_Choix.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.GB_Choix.ForeColor = System.Drawing.Color.Silver
        Me.GB_Choix.Location = New System.Drawing.Point(203, 206)
        Me.GB_Choix.Name = "GB_Choix"
        Me.GB_Choix.Size = New System.Drawing.Size(1258, 406)
        Me.GB_Choix.TabIndex = 16
        Me.GB_Choix.TabStop = False
        Me.GB_Choix.Text = "Epreuves"
        '
        'ChoixRestant2
        '
        Me.ChoixRestant2.AutoSize = True
        Me.ChoixRestant2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.ChoixRestant2.ForeColor = System.Drawing.Color.Silver
        Me.ChoixRestant2.Location = New System.Drawing.Point(698, 363)
        Me.ChoixRestant2.Name = "ChoixRestant2"
        Me.ChoixRestant2.Size = New System.Drawing.Size(130, 28)
        Me.ChoixRestant2.TabIndex = 6
        Me.ChoixRestant2.Text = "ChoixRestant2"
        '
        'Panel_Ecrit
        '
        Me.Panel_Ecrit.Controls.Add(Me.CB_VB)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Algo)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Math)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Gestion)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Exp)
        Me.Panel_Ecrit.Controls.Add(Me.CB_PW)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Sys)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Res)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Java)
        Me.Panel_Ecrit.Controls.Add(Me.CB_BD)
        Me.Panel_Ecrit.Controls.Add(Me.CB_Droit)
        Me.Panel_Ecrit.Controls.Add(Me.CB_C)
        Me.Panel_Ecrit.Location = New System.Drawing.Point(56, 38)
        Me.Panel_Ecrit.Name = "Panel_Ecrit"
        Me.Panel_Ecrit.Size = New System.Drawing.Size(466, 322)
        Me.Panel_Ecrit.TabIndex = 16
        '
        'CB_VB
        '
        Me.CB_VB.AutoSize = True
        Me.CB_VB.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_VB.ForeColor = System.Drawing.Color.Silver
        Me.CB_VB.Location = New System.Drawing.Point(282, 268)
        Me.CB_VB.Name = "CB_VB"
        Me.CB_VB.Size = New System.Drawing.Size(99, 32)
        Me.CB_VB.TabIndex = 15
        Me.CB_VB.Text = "VB.NET"
        Me.CB_VB.UseVisualStyleBackColor = True
        '
        'CB_Algo
        '
        Me.CB_Algo.AutoSize = True
        Me.CB_Algo.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Algo.ForeColor = System.Drawing.Color.Silver
        Me.CB_Algo.Location = New System.Drawing.Point(40, 18)
        Me.CB_Algo.Name = "CB_Algo"
        Me.CB_Algo.Size = New System.Drawing.Size(157, 32)
        Me.CB_Algo.TabIndex = 4
        Me.CB_Algo.Text = "Algorithmique"
        Me.CB_Algo.UseVisualStyleBackColor = True
        '
        'CB_Math
        '
        Me.CB_Math.AutoSize = True
        Me.CB_Math.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Math.ForeColor = System.Drawing.Color.Silver
        Me.CB_Math.Location = New System.Drawing.Point(282, 225)
        Me.CB_Math.Name = "CB_Math"
        Me.CB_Math.Size = New System.Drawing.Size(168, 32)
        Me.CB_Math.TabIndex = 14
        Me.CB_Math.Text = "Mathématiques"
        Me.CB_Math.UseVisualStyleBackColor = True
        '
        'CB_Gestion
        '
        Me.CB_Gestion.AutoSize = True
        Me.CB_Gestion.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Gestion.ForeColor = System.Drawing.Color.Silver
        Me.CB_Gestion.Location = New System.Drawing.Point(40, 69)
        Me.CB_Gestion.Name = "CB_Gestion"
        Me.CB_Gestion.Size = New System.Drawing.Size(101, 32)
        Me.CB_Gestion.TabIndex = 5
        Me.CB_Gestion.Text = "Gestion"
        Me.CB_Gestion.UseVisualStyleBackColor = True
        '
        'CB_Exp
        '
        Me.CB_Exp.AutoSize = True
        Me.CB_Exp.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Exp.ForeColor = System.Drawing.Color.Silver
        Me.CB_Exp.Location = New System.Drawing.Point(282, 178)
        Me.CB_Exp.Name = "CB_Exp"
        Me.CB_Exp.Size = New System.Drawing.Size(126, 32)
        Me.CB_Exp.TabIndex = 13
        Me.CB_Exp.Text = "Expression"
        Me.CB_Exp.UseVisualStyleBackColor = True
        '
        'CB_PW
        '
        Me.CB_PW.AutoSize = True
        Me.CB_PW.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_PW.ForeColor = System.Drawing.Color.Silver
        Me.CB_PW.Location = New System.Drawing.Point(40, 123)
        Me.CB_PW.Name = "CB_PW"
        Me.CB_PW.Size = New System.Drawing.Size(212, 32)
        Me.CB_PW.TabIndex = 6
        Me.CB_PW.Text = "Programmation Web"
        Me.CB_PW.UseVisualStyleBackColor = True
        '
        'CB_Sys
        '
        Me.CB_Sys.AutoSize = True
        Me.CB_Sys.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Sys.ForeColor = System.Drawing.Color.Silver
        Me.CB_Sys.Location = New System.Drawing.Point(282, 123)
        Me.CB_Sys.Name = "CB_Sys"
        Me.CB_Sys.Size = New System.Drawing.Size(107, 32)
        Me.CB_Sys.TabIndex = 12
        Me.CB_Sys.Text = "Système"
        Me.CB_Sys.UseVisualStyleBackColor = True
        '
        'CB_Res
        '
        Me.CB_Res.AutoSize = True
        Me.CB_Res.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Res.ForeColor = System.Drawing.Color.Silver
        Me.CB_Res.Location = New System.Drawing.Point(40, 268)
        Me.CB_Res.Name = "CB_Res"
        Me.CB_Res.Size = New System.Drawing.Size(98, 32)
        Me.CB_Res.TabIndex = 7
        Me.CB_Res.Text = "Reseau"
        Me.CB_Res.UseVisualStyleBackColor = True
        '
        'CB_Java
        '
        Me.CB_Java.AutoSize = True
        Me.CB_Java.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Java.ForeColor = System.Drawing.Color.Silver
        Me.CB_Java.Location = New System.Drawing.Point(282, 69)
        Me.CB_Java.Name = "CB_Java"
        Me.CB_Java.Size = New System.Drawing.Size(150, 32)
        Me.CB_Java.TabIndex = 11
        Me.CB_Java.Text = "Langage Java"
        Me.CB_Java.UseVisualStyleBackColor = True
        '
        'CB_BD
        '
        Me.CB_BD.AutoSize = True
        Me.CB_BD.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_BD.ForeColor = System.Drawing.Color.Silver
        Me.CB_BD.Location = New System.Drawing.Point(40, 178)
        Me.CB_BD.Name = "CB_BD"
        Me.CB_BD.Size = New System.Drawing.Size(180, 32)
        Me.CB_BD.TabIndex = 8
        Me.CB_BD.Text = "Base de données"
        Me.CB_BD.UseVisualStyleBackColor = True
        '
        'CB_Droit
        '
        Me.CB_Droit.AutoSize = True
        Me.CB_Droit.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_Droit.ForeColor = System.Drawing.Color.Silver
        Me.CB_Droit.Location = New System.Drawing.Point(282, 18)
        Me.CB_Droit.Name = "CB_Droit"
        Me.CB_Droit.Size = New System.Drawing.Size(79, 32)
        Me.CB_Droit.TabIndex = 10
        Me.CB_Droit.Text = "Droit"
        Me.CB_Droit.UseVisualStyleBackColor = True
        '
        'CB_C
        '
        Me.CB_C.AutoSize = True
        Me.CB_C.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.CB_C.ForeColor = System.Drawing.Color.Silver
        Me.CB_C.Location = New System.Drawing.Point(40, 225)
        Me.CB_C.Name = "CB_C"
        Me.CB_C.Size = New System.Drawing.Size(127, 32)
        Me.CB_C.TabIndex = 9
        Me.CB_C.Text = "Langage C"
        Me.CB_C.UseVisualStyleBackColor = True
        '
        'GB_Falc
        '
        Me.GB_Falc.Controls.Add(Me.RB_Oui)
        Me.GB_Falc.Controls.Add(Me.RB_Non)
        Me.GB_Falc.Controls.Add(Me.Combo_Falc)
        Me.GB_Falc.ForeColor = System.Drawing.Color.Silver
        Me.GB_Falc.Location = New System.Drawing.Point(976, 73)
        Me.GB_Falc.Name = "GB_Falc"
        Me.GB_Falc.Size = New System.Drawing.Size(258, 265)
        Me.GB_Falc.TabIndex = 13
        Me.GB_Falc.TabStop = False
        Me.GB_Falc.Text = "Epreuves facultatives"
        Me.GB_Falc.Visible = False
        '
        'Panel_Oral
        '
        Me.Panel_Oral.Controls.Add(Me.CB_Droit2)
        Me.Panel_Oral.Controls.Add(Me.CB_Gestion2)
        Me.Panel_Oral.Controls.Add(Me.CB_Res2)
        Me.Panel_Oral.Controls.Add(Me.CB_Sys2)
        Me.Panel_Oral.Controls.Add(Me.CB_Esp)
        Me.Panel_Oral.Controls.Add(Me.CB_Exp2)
        Me.Panel_Oral.Controls.Add(Me.CB_Anglais)
        Me.Panel_Oral.Controls.Add(Me.CB_Math2)
        Me.Panel_Oral.Controls.Add(Me.CB_Chinois)
        Me.Panel_Oral.Location = New System.Drawing.Point(577, 38)
        Me.Panel_Oral.Name = "Panel_Oral"
        Me.Panel_Oral.Size = New System.Drawing.Size(366, 322)
        Me.Panel_Oral.TabIndex = 23
        '
        'ChoixRestant
        '
        Me.ChoixRestant.AutoSize = True
        Me.ChoixRestant.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.ChoixRestant.ForeColor = System.Drawing.Color.Silver
        Me.ChoixRestant.Location = New System.Drawing.Point(231, 363)
        Me.ChoixRestant.Name = "ChoixRestant"
        Me.ChoixRestant.Size = New System.Drawing.Size(120, 28)
        Me.ChoixRestant.TabIndex = 5
        Me.ChoixRestant.Text = "ChoixRestant"
        '
        'Btn_Retour
        '
        Me.Btn_Retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Retour.FlatAppearance.BorderSize = 0
        Me.Btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Retour.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Retour.ForeColor = System.Drawing.Color.White
        Me.Btn_Retour.Location = New System.Drawing.Point(448, 638)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(188, 82)
        Me.Btn_Retour.TabIndex = 18
        Me.Btn_Retour.Text = "Retour"
        Me.Btn_Retour.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label_Logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 743)
        Me.Panel1.TabIndex = 24
        '
        'Label_Logo
        '
        Me.Label_Logo.AutoSize = True
        Me.Label_Logo.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label_Logo.Location = New System.Drawing.Point(2, 31)
        Me.Label_Logo.Name = "Label_Logo"
        Me.Label_Logo.Size = New System.Drawing.Size(175, 50)
        Me.Label_Logo.TabIndex = 25
        Me.Label_Logo.Text = "Exam'Up"
        '
        'ChoixEpreuve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1543, 743)
        Me.Controls.Add(Me.GB_Choix)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Controls.Add(Me.Btn_Abandonner)
        Me.Controls.Add(Me.Btn_Validation)
        Me.Controls.Add(Me.Label_Region)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.Combo_Region)
        Me.Name = "ChoixEpreuve"
        Me.Text = "Choix des épreuves"
        Me.GB_Choix.ResumeLayout(False)
        Me.GB_Choix.PerformLayout()
        Me.Panel_Ecrit.ResumeLayout(False)
        Me.Panel_Ecrit.PerformLayout()
        Me.GB_Falc.ResumeLayout(False)
        Me.GB_Falc.PerformLayout()
        Me.Panel_Oral.ResumeLayout(False)
        Me.Panel_Oral.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combo_Region As ComboBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label_Nom As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Region As Label
    Friend WithEvents Btn_Validation As Button
    Friend WithEvents Btn_Abandonner As Button
    Friend WithEvents CB_Droit2 As CheckBox
    Friend WithEvents CB_Res2 As CheckBox
    Friend WithEvents CB_Esp As CheckBox
    Friend WithEvents CB_Anglais As CheckBox
    Friend WithEvents CB_Chinois As CheckBox
    Friend WithEvents CB_Math2 As CheckBox
    Friend WithEvents CB_Exp2 As CheckBox
    Friend WithEvents CB_Sys2 As CheckBox
    Friend WithEvents CB_Gestion2 As CheckBox
    Friend WithEvents RB_Oui As RadioButton
    Friend WithEvents Combo_Falc As ComboBox
    Friend WithEvents RB_Non As RadioButton
    Friend WithEvents GB_Choix As GroupBox
    Friend WithEvents GB_Falc As GroupBox
    Friend WithEvents Panel_Oral As Panel
    Friend WithEvents CB_VB As CheckBox
    Friend WithEvents CB_Algo As CheckBox
    Friend WithEvents CB_Math As CheckBox
    Friend WithEvents CB_Gestion As CheckBox
    Friend WithEvents CB_Exp As CheckBox
    Friend WithEvents CB_PW As CheckBox
    Friend WithEvents CB_Sys As CheckBox
    Friend WithEvents CB_Res As CheckBox
    Friend WithEvents CB_Java As CheckBox
    Friend WithEvents CB_BD As CheckBox
    Friend WithEvents CB_Droit As CheckBox
    Friend WithEvents CB_C As CheckBox
    Friend WithEvents GB_Ecrit As GroupBox
    Friend WithEvents ChoixRestant As Label
    Friend WithEvents ChoixRestant2 As Label
    Friend WithEvents Panel_Ecrit As Panel
    Friend WithEvents Btn_Retour As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_Logo As Label
End Class
