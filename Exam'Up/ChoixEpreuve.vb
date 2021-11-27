Public Class ChoixEpreuve
    Private Sub ChoixEpreuve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label_Nom.Text = "Votre nom : " & Inscription.Txt_Nom.Text
        Me.Label_Prenom.Text = "Votre prénom : " & Inscription.Txt_Prenom.Text
        Me.Combo_Region.Text = Me.Combo_Region.Items(0).ToString

        Timer2.Start()
        Timer2_Tick(sender, e)
        ChoixRestant.Text = "Vous avez " & nbChoixRestant & " choix restants"
        ChoixRestant2.Text = "Vous avez " & nbChoixRestant2 & " choix restants"

    End Sub

    Private nbOptions As Integer = 0
    Private nbChoixRestant As Integer = 4
    Private allChecked As Boolean = False
    Private Sub CB_Ecrit_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Algo.CheckedChanged, CB_BD.CheckedChanged, CB_C.CheckedChanged,
        CB_Droit.CheckedChanged, CB_Exp.CheckedChanged,
        CB_Gestion.CheckedChanged, CB_Java.CheckedChanged,
        CB_Math.CheckedChanged, CB_PW.CheckedChanged, CB_Res.CheckedChanged, CB_Sys.CheckedChanged, CB_VB.CheckedChanged



        If sender.Checked Then


            nbOptions += 1
            nbChoixRestant -= 1

            If nbOptions > 4 Then
                MsgBox("Impossible de selectionner plus de 4 options")
                sender.Checked = False
            End If

        Else
            nbOptions -= 1
            nbChoixRestant += 1

        End If


        For Each chkbox As CheckBox In Panel_Oral.Controls
            If sender.text = chkbox.Text Then
                chkbox.Enabled = Not sender.checked
                Exit For
            End If
        Next

        ChoixRestant.Text = "Vous avez " & nbChoixRestant & " choix restants"

        If nbOptions = 4 Then
            allChecked = True
        Else
            allChecked = False
        End If


    End Sub

    Private tempsImparti As Integer = 90
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tempsImparti -= 1

        Dim Min As Integer = tempsImparti \ 60
        Dim Sec As Integer = tempsImparti Mod 60

        Dim decompte As String
        decompte =
              Format(Min, "00") & ":" &
              Format(Sec, "00")

        Me.Text = Date.Now.ToString() & " " & decompte

        If tempsImparti = 0 Then
            MsgBox("Le temps imparti a été dépassé, retour au formulaire d'accueil")
            Inscription.Close()
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private nbOptions2 As Integer = 0
    Private nbChoixRestant2 As Integer = 3
    Private allChecked2 As Boolean

    Private Sub CB_Oral_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Gestion2.CheckedChanged, CB_Droit2.CheckedChanged, CB_Exp2.CheckedChanged,
        CB_Math2.CheckedChanged, CB_Res2.CheckedChanged, CB_Sys2.CheckedChanged, CB_Anglais.CheckedChanged, CB_Chinois.CheckedChanged, CB_Esp.CheckedChanged


        If sender.Checked Then


            nbOptions2 += 1
            nbChoixRestant2 -= 1

            If nbOptions2 > 3 Then
                MsgBox("Impossible de selectionner plus de 3 options")
                sender.Checked = False
            End If

        Else
            nbOptions2 -= 1
            nbChoixRestant2 += 1

        End If



        For Each chkbox As CheckBox In Panel_Ecrit.Controls
            If sender.text = chkbox.Text Then
                chkbox.Enabled = Not sender.checked
                Exit For
            End If
        Next

        ChoixRestant2.Text = "Vous avez " & nbChoixRestant2 & " choix restants"

        If nbOptions2 = 3 Then
            allChecked2 = True
        Else
            allChecked2 = False
        End If




    End Sub

    Private Sub CB_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Gestion2.CheckedChanged, CB_Droit2.CheckedChanged, CB_Exp2.CheckedChanged,
        CB_Math2.CheckedChanged, CB_Res2.CheckedChanged, CB_Sys2.CheckedChanged,
        CB_Anglais.CheckedChanged, CB_Chinois.CheckedChanged, CB_Esp.CheckedChanged,
        CB_Algo.CheckedChanged, CB_BD.CheckedChanged, CB_C.CheckedChanged,
        CB_Droit.CheckedChanged, CB_Exp.CheckedChanged, CB_Gestion.CheckedChanged,
        CB_Java.CheckedChanged, CB_Math.CheckedChanged, CB_PW.CheckedChanged,
        CB_Res.CheckedChanged, CB_Sys.CheckedChanged, CB_VB.CheckedChanged



        If allChecked = True And allChecked2 = True Then
            GB_Falc.Visible = True

        Else
            GB_Falc.Visible = False
        End If

    End Sub




    Private Sub RB_Oui_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Oui.CheckedChanged

        If RB_Oui.Checked Then

            Combo_Falc.Visible = True
            Panel_Ecrit.Enabled = False
            Panel_Oral.Enabled = False

        Else
            Combo_Falc.Visible = False
            Panel_Ecrit.Enabled = True
            Panel_Oral.Enabled = True
        End If
    End Sub

    Private Sub getUnchecked(ByVal element As Control)
        Dim count As Integer
        count = 0
        If TypeOf element Is CheckBox Then
            If DirectCast(element, CheckBox).Checked = False And Not Combo_Falc.Items.Contains(element.Text) Then
                count += 1 'compte tous les checkbox cochés
                Combo_Falc.Items.Add(element.Text)
            End If
        Else
            For Each childElement In element.Controls
                Me.getUnchecked(childElement)
            Next
        End If
    End Sub


    Private Sub GB_Falc_Enter(sender As Object, e As EventArgs) Handles GB_Falc.Enter

        getUnchecked(Me)


        For Each chkbox As CheckBox In Panel_Ecrit.Controls
            If chkbox.Checked And Combo_Falc.Items.Contains(chkbox.Text) Then
                Combo_Falc.Items.Remove(chkbox.Text)
            End If
        Next

        For Each chkbox2 As CheckBox In Panel_Oral.Controls
            If chkbox2.Checked And Combo_Falc.Items.Contains(chkbox2.Text) Then
                Combo_Falc.Items.Remove(chkbox2.Text)
            End If
        Next



    End Sub

    Private Sub Btn_Validation_Click(sender As Object, e As EventArgs) Handles Btn_Validation.Click
        If Not (nbOptions = 4 And nbOptions2 = 3) Then
            MsgBox("Veuillez choisir 4 épreuves écrites et 3 épreuves orales")
            Exit Sub
        End If


        If RB_Oui.Checked And String.IsNullOrEmpty(Combo_Falc.Text) Then
            MsgBox("Veuillez choisir une épreuve facultative")
            Exit Sub
        End If

        Timer2.Stop()

        Me.Hide()
        Recapitulatif.Show()
    End Sub

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click
        Me.Close()
        Inscription.Show()
        Inscription.Timer1.Start()
    End Sub

    Private Sub Btn_Abandonner_Click(sender As Object, e As EventArgs) Handles Btn_Abandonner.Click
        If MsgBox("Voulez vous quitter l'application ?", vbYesNo, "Confirmation") = MsgBoxResult.Yes Then
            Inscription.Close()
            Me.Close()
            Accueil.Show()
        End If

    End Sub

    Private Sub Label_Nom_Click(sender As Object, e As EventArgs) Handles Label_Nom.Click

    End Sub
End Class