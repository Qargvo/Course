Public Class frm_main
    Dim input_x(3) As Double 'Введенные значения x1 x2 x3
    Dim x_borders = New Double(2, 1) {{0.4, 0.8}, {0.8, 0.9}, {8, 30}}
    Dim f As Double = 0
    Dim input_x_help = New String(2) {"Скорость вращения барабана, об/мин", "Уровень в ванне вакуум-фильтра, м", "Концентрация вещества, г/л"}

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub InputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        Dim i As Integer
        Dim inp As String
        Dim inp_trans As Double
        Dim flag As Boolean

        For i = 0 To 2 'Цикл ввода x1 x2 x3
            flag = True
            Do
                inp = InputBox("Введите значение " & " между " & CStr(x_borders(i, 0)) & " и " & CStr(x_borders(i, 1)), input_x_help(i))
                If inp = "" Then
                    Return
                End If

                If IsNumeric(inp) Then 'Проверяем правильность ввода x
                    inp_trans = CDbl(inp)
                    If check_border(inp, x_borders(i, 0), x_borders(i, 1)) Then
                        flag = False
                        input_x(i) = inp_trans
                    Else
                        MsgBox("Неверные границы", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical, "Ошибка")
                    End If
                Else
                    MsgBox("Недопустимый тип", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical, "Ошибка")
                End If
            Loop While flag
        Next i
        CalcToolStripMenuItem1.Visible = True
        lbl_out.Text = "x1 = " & CStr(input_x(0)) & vbCrLf & "x2 = " & CStr(input_x(1)) & vbCrLf & "x3 = " & CStr(input_x(2))
    End Sub

    Function check_border(x, a, b) As Boolean 'Функция проверяет находится ли число в отрезке от a до b
        If (x >= a) And (x <= b) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CalcToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalcToolStripMenuItem1.Click
        Dim y As Double
        Dim input_x_norm(3) As Double
        Dim i As Integer
        Dim b0 As Double = 6.5
        Dim b1 As Double = 1.21
        Dim b2 As Double = 2.52
        Dim b3 As Double = 0.78


        For i = 0 To 2
            'Нормирование (Xi - Xcp) / dXi
            input_x_norm(i) = (input_x(i) - ((x_borders(i, 0) + x_borders(i, 1)) / 2)) / ((x_borders(i, 1) - x_borders(i, 0)) / 2)
        Next i
        y = 80 + 2.15 * input_x_norm(0) + 1.45 * input_x_norm(1) - 0.89 * input_x_norm(2)

        If Not check_border(y, 60, 90) Then 'Проверяем Y на нахождение впрределах от 60 до 90
            MsgBox("Влажность осадка " + CStr(y) + " не входит в грницы от 60 до 90 измените входные данные", MsgBoxStyle.Critical, "Ошибка")
            CalcToolStripMenuItem1.Visible = False
            lbl_out.Text = ""
            Return
        End If

        f = b0 + b1 * input_x_norm(0) + b2 * input_x_norm(1) + b3 * input_x_norm(2)
        MsgBox(Format(f, "##0.00") & " кг/м^3", MsgBoxStyle.Information, "Производительность вакуум-фильтра по сухому веществу")
    End Sub

    Private Sub BirthdayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BirthdayToolStripMenuItem.Click
        frm_birthday.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        frm_calculator.Show()
    End Sub

End Class