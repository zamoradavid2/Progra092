Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Tv")
        ComboBox1.Items.Add("Telefono")
        ComboBox1.Items.Add("Laptop")
        ComboBox1.Items.Add("Refrigeradora")

        ComboBox2.Items.Add("Largo")
        ComboBox2.Items.Add("Corto")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim nombre, dpi, direccion, aparato, plazo As String
        nombre = TextBox1.Text
        dpi = TextBox2.Text
        direccion = TextBox3.Text
        aparato = ComboBox1.Text
        plazo = ComboBox2.Text

        If nombre IsNot "" And dpi IsNot "" And direccion IsNot "" Then
            If aparato IsNot "" And plazo IsNot "" Then
                Module1.Calcular(nombre, dpi, direccion, aparato, plazo)
            Else
                MsgBox("Agregar la informacion del producto")
            End If
        Else
            MsgBox("La informacion del cliente no esta completa")
        End If
    End Sub

    Private Sub LimpiarListboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListboxToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox1.Items.Add("-NOMBRE-")
        ListBox2.Items.Add("-CUI-")
        ListBox3.Items.Add("-DIRECCION-")
        ListBox4.Items.Add("-APARATO-")
        ListBox5.Items.Add("-PRECIO-")
        ListBox6.Items.Add("-DESC-")
        ListBox7.Items.Add("-TOTAL-")
        ListBox8.Items.Add("-PLAZO-")

    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        ReDim matriz(5, 7)
        contador = 0
        MsgBox("La matriz esta lista para su nuevo almacenamiento")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Pregunta = MsgBox("Esta seguro de cerrar el programa", vbYesNo + vbQuestion)
        If Pregunta = vbYes Then
            Application.Exit()
        Else
            MsgBox("Seguir utilizando el programa")
        End If
    End Sub
End Class
