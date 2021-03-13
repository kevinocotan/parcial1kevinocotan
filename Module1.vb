Module Module1

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

            ElseIf (opcion = "2") Then


                For contador = 0 To 14
                    Console.WriteLine("")
                    Console.WriteLine("Inserte un numero en la posicion: " & contador + 1)
                    num(contador) = Integer.Parse(Console.ReadLine())

                Next
                Console.WriteLine("")
                Console.WriteLine("Los datos que se han ingresado son : ")
                Console.WriteLine("")
                For contador = 0 To 14
                    Console.WriteLine("")
                    Console.Write(" {0}", num(contador))
                    Console.WriteLine("")

                Next

                For contador = 0 To 14
                    auxiliar(contador) = 0

                Next

                For contador = 0 To 14
                    numero = num(contador)
                    posicion = contador
                    For contador2 = contador To 14
                        If (num(contador2) = numero) Then auxiliar(posicion) += 1

                    Next

                Next

                mayor = auxiliar(0)
                posicionmayor = 0
                For contador = 0 To 14
                    If auxiliar(contador) > mayor Then
                        posicionmayor = contador
                        mayor = auxiliar(contador)

                    End If

                Next
                Console.WriteLine("")
                Console.WriteLine("La moda es : " & num(posicionmayor))
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("Presione ENTER para volver al MENU")
                Console.WriteLine("")

                Console.ReadLine()


            ElseIf (opcion = "4") Then

                For i As Integer = 0 To valores.Length - 1
                    Console.WriteLine("")
                    Console.WriteLine("Inserte un numero en la posicion: " & i + 1)
                    valores(i) = Console.ReadLine

                Next

                Array.Sort(valores)

                Console.WriteLine("")
                Console.WriteLine("El numero menor es: " & valores(0))
                Console.WriteLine("El numero mayor es: " & valores(valores.Length - 1))
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("Presione ENTER para volver al MENU")
                Console.WriteLine("")

                Console.ReadLine()


            ElseIf (opcion >= 5) Then
                res = 5

            End If

        Loop
    End Sub


End Module
