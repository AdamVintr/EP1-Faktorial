Imports System

Module Program
    Sub Main(args As String())
        Dim vstup As String
        Dim soucet As Integer = 0
        Dim cislo As Integer
        Do
            Console.WriteLine(" Zadej èíslo: ")
            vstup = Console.ReadLine
            If vstup > 0 Then
                If vstup < 10 Then
                    If Integer.TryParse(vstup, cislo) Then
                        For i = 1 To cislo
                            soucet = soucet + i
                        Next
                        Console.WriteLine($"Souèet 1 do {cislo} je {soucet}")

                    End If
        Loop
    End Sub
End Module
