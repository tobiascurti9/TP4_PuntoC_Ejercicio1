Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim NumeroEntero, Num, Mayor, Menor As Integer
        lstSalida.Items.Add("Ingrese numeros enteros")
        Do
            NumeroEntero = InputBox("Ingresar numeros", "", 0)
            If Num = 0 Then
                Menor = NumeroEntero
            Else
            End If
            If NumeroEntero <> -999 Then
                Num = Num + NumeroEntero
                If NumeroEntero > Mayor Then
                    Mayor = NumeroEntero
                Else
                End If
                If NumeroEntero < Menor Then
                    Menor = NumeroEntero
                Else
                End If
            End If
        Loop Until NumeroEntero = -999
        lstSalida.Items.Add("Suma de numeros ingresados")
    End Sub
End Class
