Public Class Modification
    Private Sub Modification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each c As Candidat In Module1.GetTabCandidat

            Combo_Modif.Items.Add("Candidat n°" & c.num & " : " & c.nom & " " & c.prenom)


        Next


    End Sub

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub Btn_Modif_Click(sender As Object, e As EventArgs) Handles Btn_Modif.Click
        For Each cdt As Candidat In Module1.GetTabCandidat
            If Combo_Modif.SelectedIndex = cdt.num - 1 Then
                Dim ins As New Inscription

                ins.Txt_Nom.Text = cdt.nom
                ins.Txt_Prenom.Text = cdt.prenom
                ins.Txt_Adresse.Text = cdt.adresse
                ins.Txt_CP.Text = cdt.codepostal
                ins.Txt_Ville.Text = cdt.ville
                ins.Txt_Age.Text = cdt.age

                Me.Hide()
                ins.Show()



            End If
        Next
    End Sub

    Private Sub Btn_Suppr_Click(sender As Object, e As EventArgs) Handles Btn_Suppr.Click
        For Each cdt As Candidat In Module1.GetTabCandidat
            If Combo_Modif.SelectedIndex = cdt.num - 1 Then
                ''enlever l'élément du tableau tCandidat




            End If
        Next
    End Sub


End Class