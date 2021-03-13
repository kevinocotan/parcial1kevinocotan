Module Module1

    Sub Main()

        Sub Main()
        Dim valores(14) As Integer 'agregar en numeros 14'
        Dim media As Double = 0
        Dim suma As Integer = 0
        Dim opcion As Integer
        Dim res As Integer = 1
        Dim num(0 To 14) As Integer
        Dim auxiliar(0 To 14) As Integer
        Dim posicion As Integer = 0
        Dim numero As Integer = 0
        Dim contador2 As Integer = 0
        Dim mayor As Integer = 0
        Dim posicionmayor As Integer = 0

        Do While (res < 5)

            Console.WriteLine("")
            Console.WriteLine(" --------- MENU -------------- ")
            Console.WriteLine(" 1.- Calcular la MEDIA ARITMETICA ")
            Console.WriteLine(" 2.- Calcular la MODA ")
            Console.WriteLine(" 3.- Calcular la MEDIANA ")
            Console.WriteLine(" 4.- Calcular el NUMERO MENOR Y MAYOR")
            Console.WriteLine(" 5.- Salir ")
            Console.WriteLine("")

            opcion = Console.ReadLine()

            If (opcion = "1") Then

                For i As Integer = 0 To valores.Length - 1
                    Console.WriteLine("")
                    Console.WriteLine("Inserte un numero en la posicion: " & i + 1)
                    valores(i) = Console.ReadLine

                    suma += valores(i)

                Next

                media = suma / valores.Length

                Console.WriteLine("")
                Console.WriteLine("La media aritmetica es: = " & media)
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("Presione ENTER para volver al MENU")
                Console.WriteLine("")

                Console.ReadLine()




            End If


    End Sub

End Module
