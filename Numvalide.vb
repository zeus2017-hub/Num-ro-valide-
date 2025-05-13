Module Module1

    Sub Main()
        Console.WriteLine("Entrez un numéro de téléphone du Cameroun :")
        Dim numero As String = Console.ReadLine()

        If ValiderNumeroCameroun(numero) Then
            Console.WriteLine("Le numéro de téléphone est valide")
        Else
            Console.WriteLine("Le numéro de téléphone n'est pas valide")
        End If

        Console.ReadKey()
    End Sub

    Function ValiderNumeroCameroun(ByVal numero As String) As Boolean
        ' Les numéros de téléphone du Cameroun commencent par +237 ou 00237
        Dim regex As New regex("^(\+237|00237)[23679]\d{7}$")
        Return regex.IsMatch(numero)
    End Function


End Module
