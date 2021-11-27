Imports System.Text

Public Class Recapitulatif

    Dim numCandidat = 1
    Dim ecrit As String
    Dim oral As String

    Private Function getEpreuvesToString(ByRef panel As Panel) As String
        Dim s As New StringBuilder
        For Each chkbox As CheckBox In panel.Controls

            If chkbox.Checked = True Then
                s.Append(chkbox.Text & ", ")

            End If

        Next

        Return s.ToString()


    End Function



    Private Sub Recapitulatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label_Nom.Text = "Votre nom : " & Inscription.Txt_Nom.Text
        Me.Label_Prenom.Text = "Votre prénom : " & Inscription.Txt_Prenom.Text
        Me.Label_Adresse.Text = "Votre adresse : " & Inscription.Txt_Adresse.Text
        Me.Label_CP.Text = "Votre code postal : " & Inscription.Txt_CP.Text
        Me.Label_Ville.Text = "Votre ville : " & Inscription.Txt_Ville.Text
        Me.Label_Age.Text = "Votre âge : " & Inscription.Txt_Age.Text
        Me.Label_Region.Text = "Votre région : " & ChoixEpreuve.Combo_Region.SelectedItem
        Me.Label_Falc.Text = "Epreuve facultative (incluse dans les épreuves orales) : " & If(ChoixEpreuve.RB_Oui.Checked And ChoixEpreuve.Combo_Falc.SelectedIndex <> -1, ChoixEpreuve.Combo_Falc.SelectedItem, "")


        ecrit = getEpreuvesToString(ChoixEpreuve.Panel_Ecrit)
        oral = getEpreuvesToString(ChoixEpreuve.Panel_Oral) & If(ChoixEpreuve.RB_Oui.Checked And ChoixEpreuve.Combo_Falc.SelectedIndex <> -1, ChoixEpreuve.Combo_Falc.SelectedItem, "")

        Me.Label_Epreuves.Text = "Vos épreuves : " & ecrit & "/" & oral





    End Sub

    Private Sub Btn_Validation_Click(sender As Object, e As EventArgs) Handles Btn_Validation.Click


        Dim c As Candidat

        c.nom = Inscription.Txt_Nom.Text
        c.prenom = Inscription.Txt_Prenom.Text
        c.adresse = Inscription.Txt_Adresse.Text
        c.codepostal = Inscription.Txt_CP.Text
        c.ville = Inscription.Txt_Ville.Text
        c.age = Inscription.Txt_Age.Text
        c.region = ChoixEpreuve.Combo_Region.SelectedItem
        c.tEpreuvesOrales = oral.Split(",")
        c.tEpreuvesEcrites = ecrit.Split(",")



        Module1.Ajout(c)

        MsgBox("Votre inscription a été réalisée, vous êtes le candidat numéro " & Module1.GetNum() - 1)





        Inscription.Close()
        ChoixEpreuve.Close()
        Me.Close()
        Accueil.Show()

    End Sub

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click
        Me.Close()

        ChoixEpreuve.Show()
        ChoixEpreuve.Timer2.Start()
    End Sub

    Private Sub Btn_Abandonner_Click(sender As Object, e As EventArgs) Handles Btn_Abandonner.Click
        If MsgBox("Etes-vous sur de vouloir retourner à l'accueil ?", vbYesNo, "Confirmation") = MsgBoxResult.Yes Then
            Inscription.Close()
            ChoixEpreuve.Close()
            Me.Close()
            Accueil.Show()
        End If

    End Sub

End Class