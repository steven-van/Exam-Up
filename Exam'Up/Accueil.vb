Public Class Accueil


    Private Sub Btn_Inscri_Click(sender As Object, e As EventArgs) Handles Btn_Inscri.Click

        Inscription.Show()
        Me.Hide()



    End Sub

    Private Sub Btn_Modif_Click(sender As Object, e As EventArgs) Handles Btn_Modif.Click

        Modification.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Consu_Click(sender As Object, e As EventArgs) Handles Btn_Consu.Click
        Consultation.Show()
        Me.Hide()
    End Sub


End Class