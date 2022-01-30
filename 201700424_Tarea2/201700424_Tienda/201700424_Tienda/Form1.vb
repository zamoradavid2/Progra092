Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        pagoSinIVA = (Val(txtArroz.Text) * precioArroz) + (Val(txtFrijol.Text) * precioFrijol) + (Val(txtAzucar.Text) * precioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA
        descuento = pagoConIVA * 0.025
        pagoFinal = pagoConIVA - descuento



        Label9.Text = pagoSinIVA
        Label10.Text = valorIVA
        Label11.Text = pagoConIVA
        Label12.Text = descuento
        Label13.Text = pagoFinal
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtArroz.Clear()
        txtAzucar.Clear()
        txtFrijol.Clear()
        Const precioArroz As Double = 2.0
        Const precioFrijol As Double = 1.75
        Const precioAzucar As Double = 2.5
        Const IVA As Double = 0.12

        Dim pagoSinIVA As Double = 0
        Dim valorIVA As Double = 0
        Dim pagoConIVA As Double = 0
        Dim descuento As Double = 0
        Dim pagoFinal As Double = 0

        Label9.Text = 0.00
        Label10.Text = 0.00
        Label11.Text = 0.00
        Label12.Text = 0.00
        Label13.Text = 0.00

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagoFinal As Double = 0
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArroz.KeyPress
        'Código para que solo acepte numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAzucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
