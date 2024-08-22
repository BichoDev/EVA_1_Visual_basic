Public Class form1
    Dim Operacion As String
    Dim valorResultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click
        Concatenar()
        txresultado.Text &= "1"

    End Sub

    Private Sub boton2_Click(sender As Object, e As EventArgs) Handles boton2.Click
        Concatenar()
        txresultado.Text &= "2"
    End Sub

    Private Sub boton3_Click(sender As Object, e As EventArgs) Handles boton3.Click
        Concatenar()
        txresultado.Text &= "3"
    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        Concatenar()
        txresultado.Text &= "4"
    End Sub

    Private Sub boton5_Click(sender As Object, e As EventArgs) Handles boton5.Click
        Concatenar()
        txresultado.Text &= "5"
    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        Concatenar()
        txresultado.Text &= "6"
    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        Concatenar()
        txresultado.Text &= "7"
    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        Concatenar()
        txresultado.Text &= "8"
    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        Concatenar()
        txresultado.Text &= "9"
    End Sub

    Private Sub boton0_Click(sender As Object, e As EventArgs) Handles boton0.Click
        Concatenar()
        txresultado.Text &= "0"
    End Sub

    Private Sub botonpunto_Click(sender As Object, e As EventArgs) Handles botonpunto.Click
        If InStr(txresultado.Text, ".", CompareMethod.Text) = 0 Then
            txresultado.Text &= "."
        End If

    End Sub

    Private Sub botonsuma_Click(sender As Object, e As EventArgs) Handles botonsuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub botonrestar_Click(sender As Object, e As EventArgs) Handles botonrestar.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub botonmultiplicar_Click(sender As Object, e As EventArgs) Handles botonmultiplicar.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub botondivision_Click(sender As Object, e As EventArgs) Handles botondivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub botonborrar_Click(sender As Object, e As EventArgs) Handles botonborrar.Click
        txresultado.Text = "0"
        valor2 = Nothing
        valorResultado = Nothing

    End Sub

    Private Sub botonigual_Click(sender As Object, e As EventArgs) Handles botonigual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        valor2 = Val(txresultado.Text)
        If valorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    valorResultado = valorResultado + valor2
                Case "-"
                    valorResultado -= valor2
                Case "*"
                    valorResultado *= valor2
                Case "/"
                    valorResultado /= valor2
            End Select
            txresultado.Text = valorResultado
        Else
            valorResultado = valor2
        End If
    End Sub
    Public Sub Concatenar()
        If SePresionaOperador = True Then
            txresultado.Text = ""
            SePresionaOperador = False
        ElseIf txresultado.Text = "0" Then
            txresultado.Text = ""
        End If

    End Sub

End Class