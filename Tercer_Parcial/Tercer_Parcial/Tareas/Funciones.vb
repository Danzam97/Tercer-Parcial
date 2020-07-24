Module Funciones
    Public Function UppercaseFirstLetter(ByVal val As String) As String
        ' Prueba si es nulo o vacio.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        'Convierte la cadena a minuscula.
        val = LCase(val)

        'Convierte a arreglo de caracteres.
        Dim array() As Char = val.ToCharArray

        ' Convierte la primera letra a mayuscula.
        array(0) = Char.ToUpper(array(0))

        ' Retorna el nuevo string.
        Return New String(array)
    End Function

    Public Function LowerCase(ByVal val As String) As String
        ' Prueba si es nulo o vacio.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        'Convierte la cadena a minuscula.
        val = LCase(val)

        'Convierte a arreglo de caracteres.
        Dim array() As Char = val.ToCharArray

        ' Retorna el nuevo string.
        Return New String(array)
    End Function
End Module
