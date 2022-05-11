Public Class Mult
    Implements operation

    Public Function calc(a As Double, b As Double) As Double Implements operation.calc
        Return a * b
    End Function

    Public Function name() As Char Implements operation.name
        Return "*"
    End Function

    Public Function validate(a As Double, b As Double) As Boolean Implements operation.validate
        Return True
    End Function
End Class
