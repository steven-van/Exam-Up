Imports System.Text

Public Class Consultation

    Private Function getInitialEcrit(ByRef c As Candidat) As String
        Dim s As New StringBuilder
        For Each element As String In c.tEpreuvesEcrites
            If Trim(element) <> "" Then
                s.Append(element.Substring(0, 4).ToUpper() & ", ")
            End If


        Next

        Return s.ToString()

    End Function

    Private Function getInitialOral(ByRef c As Candidat) As String
        Dim s As New StringBuilder
        For Each element As String In c.tEpreuvesOrales

            s.Append(element.Substring(0, 4).ToUpper() & ", ")

        Next

        Return s.ToString()


    End Function

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click
        Me.Close()
        Accueil.Show()
    End Sub


    Private Sub Consultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each c As Candidat In Module1.GetTabCandidat

            LB_Consu.Items.Add("n°" & c.num & ", " & c.nom & ", " & c.prenom & ", " & getInitialEcrit(c) & ", " & getInitialOral(c))





        Next
    End Sub


End Class