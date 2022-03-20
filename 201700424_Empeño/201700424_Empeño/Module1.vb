Module Module1
    Public matriz(5, 7) As String
    Public contador = 0
    Friend Sub Calcular(nombre As String, dpi As String, direccion As String, aparato As String, plazo As String)
        If contador < 6 Then
            Dim precio As Integer
            Dim descuento As Double
            matriz(contador, 0) = nombre
            matriz(contador, 1) = dpi
            matriz(contador, 2) = direccion
            matriz(contador, 3) = aparato
            Select Case aparato
                Case "Tv"
                    Select Case plazo
                        Case "Largo"
                            precio = 300
                            descuento = Math.Round(precio * 0.05, 2)
                        Case "Corto"
                            precio = 250
                            descuento = Math.Round(precio * 0.015, 2)
                    End Select
                Case "Telefono"
                    Select Case plazo
                        Case "Largo"
                            precio = 600
                            descuento = Math.Round(precio * 0.1, 2)
                        Case "Corto"
                            precio = 550
                            descuento = Math.Round(precio * 0.05, 2)
                    End Select
                Case "Laptop"
                    Select Case plazo
                        Case "Largo"
                            precio = 800
                            descuento = Math.Round(precio * 0.1, 2)
                        Case "Corto"
                            precio = 770
                            descuento = Math.Round(precio * 0.05, 2)
                    End Select
                Case "Refrigeradora"
                    Select Case plazo
                        Case "Largo"
                            precio = 1200
                            descuento = Math.Round(precio * 0.05, 2)
                        Case "Corto"
                            precio = 1000
                            descuento = Math.Round(precio * 0.015, 2)
                    End Select
            End Select
            matriz(contador, 4) = precio
            matriz(contador, 5) = descuento
            matriz(contador, 6) = precio - descuento
            matriz(contador, 7) = plazo
            contador = contador + 1
            MsgBox("Se almacenaron los datos exitosamente")
        Else
            MsgBox("Ya no se aceptan mas datos")
        End If
        MostrarListas()
    End Sub

    Sub MostrarListas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox1.Items.Add("-NOMBRE-")
        Form1.ListBox2.Items.Add("-CUI-")
        Form1.ListBox3.Items.Add("-DIRECCION-")
        Form1.ListBox4.Items.Add("-APARATO-")
        Form1.ListBox5.Items.Add("-PRECIO-")
        Form1.ListBox6.Items.Add("-DESC-")
        Form1.ListBox7.Items.Add("-TOTAL-")
        Form1.ListBox8.Items.Add("-PLAZO-")


        For i As Integer = 0 To contador - 1
            Form1.ListBox1.Items.Add(matriz(i, 0))
            Form1.ListBox2.Items.Add(matriz(i, 1))
            Form1.ListBox3.Items.Add(matriz(i, 2))
            Form1.ListBox4.Items.Add(matriz(i, 3))
            Form1.ListBox5.Items.Add(matriz(i, 4))
            Form1.ListBox6.Items.Add(matriz(i, 5))
            Form1.ListBox7.Items.Add(matriz(i, 6))
            Form1.ListBox8.Items.Add(matriz(i, 7))
        Next
    End Sub
End Module
