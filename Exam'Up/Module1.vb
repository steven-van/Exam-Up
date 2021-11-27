Module Module1
    Public Structure Candidat
        Public num, nom, prenom, adresse, codepostal, ville, age, region As String
        Public tEpreuvesOrales() As String
        Public tEpreuvesEcrites() As String
    End Structure



    Dim compteur As Integer = 0
    Function getCompteur() As Integer
        Return compteur
    End Function
    Dim tCandidat(compteur) As Candidat
    Dim num As Integer = 1

    Function GetNum() As Integer
        Return num
    End Function
    Function GetTabCandidat() As Candidat()
        Return tCandidat
    End Function


    Sub Ajout(c As Candidat)
        Dim cdt As New Candidat With {
            .num = GetNum(),
            .nom = c.nom,
            .prenom = c.prenom,
            .adresse = c.adresse,
            .codepostal = c.codepostal,
            .ville = c.ville,
            .age = c.age,
            .region = c.region,
            .tEpreuvesOrales = c.tEpreuvesOrales,
            .tEpreuvesEcrites = c.tEpreuvesEcrites
        }


        If (getCompteur() = tCandidat.Length) Then
            ReDim Preserve tCandidat(compteur + 1)
        End If

        If tCandidat.Contains(c) Then
            tCandidat(c.num) = cdt
        Else
            tCandidat(compteur) = cdt

        End If

        compteur += 1
        num += 1

    End Sub





End Module
