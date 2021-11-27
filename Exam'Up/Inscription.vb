Public Class Inscription

    'Autoriser uniquement les caractères alphabétiques pour les Nom,Prenom,Ville
    Private Sub Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nom.KeyPress, Txt_Prenom.KeyPress, Txt_Ville.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsLetter(e.KeyChar) Then e.Handled = True
    End Sub

    'Autoriser uniquement les chiffres pour le Code Postal
    Private Sub Txt_CP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CP.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    'Barre de défilement
    Private Sub Scrollbar_Age_Scroll(sender As Object, e As ScrollEventArgs) Handles Scrollbar_Age.Scroll
        Txt_Age.Text = Scrollbar_Age.Value
    End Sub

    'Lancement du timer pour la date et du compte à rebours lors du chargement du formulaire

    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
        Timer1_Tick(sender, e)
    End Sub

    Private tempsImparti As Integer = 60

    ' Affichage de la date et compte à rebours converti en minute et seconde
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    'Conditions de validation du formulaire 1 lors du click sur le bouton
    Private Sub Btn_Validation_Click(sender As Object, e As EventArgs) Handles Btn_Validation.Click


        If String.IsNullOrEmpty(Txt_Nom.Text) Or
        String.IsNullOrEmpty(Txt_Prenom.Text) Or
        String.IsNullOrEmpty(Txt_Adresse.Text) Or
        String.IsNullOrEmpty(Txt_CP.Text) OrElse
        Txt_CP.Text.Substring(0, 2) = "00" OrElse
        Txt_CP.TextLength <> 5 Or
        String.IsNullOrEmpty(Txt_Ville.Text) Or
        String.IsNullOrEmpty(Txt_Age.Text) Then

            If String.IsNullOrEmpty(Txt_Nom.Text) Then
                Label_Nom.ForeColor = Color.Red
            End If

            If String.IsNullOrEmpty(Txt_Prenom.Text) Then
                Label_Prenom.ForeColor = Color.Red
            End If

            If String.IsNullOrEmpty(Txt_Adresse.Text) Then
                Label_Adresse.ForeColor = Color.Red
            End If

            If String.IsNullOrEmpty(Txt_Ville.Text) Then
                Label_Ville.ForeColor = Color.Red
            End If

            If String.IsNullOrEmpty(Txt_Age.Text) Then
                Label_Age.ForeColor = Color.Red

            End If

            If String.IsNullOrEmpty(Txt_CP.Text) OrElse Txt_CP.Text.Substring(0, 2) = "00" OrElse Txt_CP.TextLength <> 5 Then
                Label_CP.ForeColor = Color.Red
                MsgBox("Le code postal doit contenir 5 caractères, les deux premiers différents de 0")
            End If


            MsgBox("Veuillez remplir tous les champs ")
            Exit Sub

        End If

        Timer1.Stop()

        Me.Hide()
        ChoixEpreuve.Show()
    End Sub

    'Abandon de l'inscription, réinitialisation du formulaire Inscritpion
    Private Sub Btn_Abandon_Click(sender As Object, e As EventArgs) Handles Btn_Abandon.Click
        If MsgBox("Etes-vous sur de vouloir retourner à l'accueil ?", vbYesNo, "Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
            Accueil.Show()
        End If

    End Sub


    ' Mise en majuscule des premières lettres Nom, Prénom et de la Ville au lostfocus
    Private Sub Txt_LostFocus(sender As Object, e As EventArgs) Handles Txt_Nom.LostFocus, Txt_Prenom.LostFocus, Txt_Ville.LostFocus

        If Not sender.Text = String.Empty Then
            sender.Text = sender.Text.Substring(0, 1).ToUpper + sender.Text.Substring(1).ToLower
        End If



    End Sub


End Class
