
Public Interface operation
    'Фунция проверки возможности выполнения операции 
    Function validate(a As Double, b As Double) As Boolean
    'Расчет операции
    Function calc(a As Double, b As Double) As Double
    'символ операции
    Function name() As Char

End Interface
