Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim vstup As String
        Dim soucet As Integer = 0

        Console.WriteLine("Zadej ��slo: ")
        vstup = Console.ReadLine

        If Integer.TryParse(vstup, cislo) Then
            For i = 1 To cislo
                soucet = soucet + 1
            Next

            Console.WriteLine($" Sou�et od 1 do {cislo} je {soucet}")
        Else
            Console.WriteLine("Mus�te zadat jen cel� ��sla!")


        End If
    End Sub
End Module
