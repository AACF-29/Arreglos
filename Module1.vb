Module Module1


    Sub main()


        Dim opciones As Integer

        Console.WriteLine("1. Generar y rellenar un arreglo unidimensional, pedir la longitud del arreglo al usuario y debe contener valores pares partiendo desde el 2" & vbCrLf &
                          "2. Generar y rellenar un arreglo unidimensional, los valores a llenar será el resultado de la tabla de multiplicar del que desee el usuario" & vbCrLf &
                          "3. Generar y rellenar una matriz cuadrada de dimensión o longitud dada por el usuario, llenarla con número impares" & vbCrLf &
                          "4. Dada una matriz de dimensiones dadas por el usuario, llenarla con un valor único que daría el usuario y multiplicado por su posición" & vbCrLf &
                          "5. Generar una matriz cuadrada mostrar solo la diagonal principal con elementos 0(DP)" & vbCrLf &
                          "6. Generar una matriz cuadrada mostrar solo la diagonal trasversa con elementos 0 (DT)" & vbCrLf &
                          "7. Generar una matriz cuadrada mostrar solo la diagonal principal y trasversa" & vbCrLf &
                          "8. Generar una matriz cuadrada mostrar solo las puntas de la matriz con elementos 0" & vbCrLf &
                          "9. Generar una matriz cuadrada dibujar un cuadrado con 0" & vbCrLf &
                          "10. Generar una matriz cuadrada NxN(solo valores impares y mayores a 3) y generar el sgte relleno: N=5")

        Console.WriteLine()
        Console.WriteLine("Escriba una opción:")
        Console.WriteLine()

        opciones = Console.ReadLine()

        Select Case opciones

            Case 1
                Dim Tamaño As Integer

                Console.WriteLine("escriba el tamaño de su arreglo")
                Tamaño = Console.ReadLine()

                If Tamaño < 2 Then
                    Do
                        Console.WriteLine("el tamaño del arreglo debe ser mayor a 2")
                        Console.WriteLine("escriba el tamaño de su arreglo")
                        Tamaño = Console.ReadLine()
                    Loop Until Tamaño >= 2
                End If

                Dim arreglo(Tamaño) As Integer
                Dim fill As Integer
                fill = 2

                For i = 1 To arreglo.GetUpperBound(0)

                    arreglo(i) += fill
                    fill += 2

                Next

                For i = 1 To arreglo.GetUpperBound(0)

                    Console.Write(arreglo(i) & " ")

                Next



            Case 2
                Dim mult As Double
                Dim arreglo(10) As Integer

                Console.Write("Escriba el numero de la tabla de multiplicar")
                mult = Console.ReadLine()


                For i = 0 To arreglo.GetUpperBound(0)

                    arreglo(i) = mult * (i)

                Next

                For i = 0 To arreglo.GetUpperBound(0)

                    Console.WriteLine(mult & " x " & i & " = " & arreglo(i))
                Next

            Case 3

                Dim colum As Integer
                Dim filas As Integer



                Console.WriteLine("escribe las filas y columnas de una matriz cuadrada" & vbCrLf)

                Console.Write("Digire la cantidad de filas: ")
                filas = Console.ReadLine()
                Console.Write("Digite la cantidad de columnas: ")
                colum = Console.ReadLine()

                If (filas <> colum) Then
                    Do
                        Console.WriteLine("Vuelva y digite, Recuerde que es un matriz cuadrada por lo cual debe haber la misma cantidad de filas que columnas")

                        Console.Write("escribe la cantidad de filas: ")
                        filas = Console.ReadLine()

                        Console.Write("Digite la cantidad de columnas: ")
                        colum = Console.ReadLine()
                    Loop Until (filas = colum)
                End If

                Dim matriz(filas, colum) As Integer
                Dim relleno As Integer

                relleno = 1

                For i = 0 To matriz.GetUpperBound(0) Step 1
                    For j = 0 To matriz.GetUpperBound(1) Step 1

                        matriz(i, j) = relleno
                        relleno += 2

                        Console.Write(matriz(i, j) & " ")

                    Next
                Next

            Case 4

                Dim Tamaño As Integer
                Dim multiplos As Integer
                Do
                    Console.WriteLine("escribe el tamaño de la matriz")
                    Tamaño = Console.ReadLine()

                    If (Tamaño <= 1) Then
                        Console.WriteLine("La dimensión de la matriz debe ser mayor a 2 o igual a 2")
                    End If

                Loop While (Tamaño <= 1)

                Console.WriteLine("escriba el numero a multiplicar")
                multiplos = Console.ReadLine()

                Dim matriz(Tamaño, Tamaño) As String

                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1
                        matriz(i, j) = multiplos * i & "," & multiplos * j
                    Next
                Next
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1
                        Console.Write(matriz(i, j) & " ")
                    Next
                Next

            Case 5
                Dim matriz(6, 6) As String
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1
                        If (i = j) Then
                            matriz(i, j) = "0"
                        End If
                    Next
                Next
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Case 6
                Dim matriz(3, 3) As String
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1
                        If (i + j = matriz.GetUpperBound(0) - 1) Then
                            matriz(i, j) = " 0 "
                        End If

                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Case 7
                Dim matriz(6, 6) As String
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1

                        If (i = j) Then
                            matriz(i, j) = "0"
                        ElseIf (i + j = matriz.GetUpperBound(0) - 1) Then
                            matriz(i, j) = "0"

                        End If
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Case 8
                Dim matriz(9, 9) As String
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1
                        If (i = 0 Or i = matriz.GetUpperBound(0) - 1) And (j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                            matriz(i, j) = "0"
                        End If
                    Next
                Next
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Case 9
                Dim matriz(3, 3) As String
                For i = 0 To matriz.GetUpperBound(0) - 1
                    For j = 0 To matriz.GetUpperBound(1) - 1

                        If (i = 0 Or i = matriz.GetUpperBound(0) - 1 Or j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                            matriz(i, j) = "0"
                        Else
                            matriz(i, j) = " "
                        End If
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

        End Select
    End Sub
End Module
