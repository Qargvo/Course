Public Class frm_main
    Dim input_x(3) As Double 'Введенные значения x1 x2 x3
    Dim input_x_flag As Boolean = False
    Dim x_borders = New Double(2, 1) {{0.4, 0.8}, {0.8, 0.9}, {8, 30}}
    Dim f As Double = 0
    Dim f_flag As Boolean = False
    Dim input_x_help = New String(2) {"Скорость вращения барабана, об/мин", "Уровень в ванне вакуум-фильтра, м", "Концентрация вещества, г/л"}
    Dim lastFile As String = ""

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
        CalcToolStripMenuItemF.Visible = True
        input_x_flag = True
        Conclus()
    End Sub

    Function check_border(x, a, b) As Boolean 'Функция проверяет находится ли число в отрезке от a до b
        If (x >= a) And (x <= b) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CalcToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalcToolStripMenuItemF.Click
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
            CalcToolStripMenuItemF.Visible = False
            lbl_out.Text = ""
            Return
        End If
        f_flag = True
        f = b0 + b1 * input_x_norm(0) + b2 * input_x_norm(1) + b3 * input_x_norm(2)
        MsgBox(Format(f, "##0.00") & " кг/м^3", MsgBoxStyle.Information, "Производительность вакуум-фильтра по сухому веществу")
        Conclus()
    End Sub

    Private Sub BirthdayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BirthdayToolStripMenuItem.Click
        frm_birthday.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        frm_calculator.Show()
    End Sub

    Function Conclus() As Integer
        If input_x_flag Then
            lbl_out.Text = input_x_help(0) & vbCrLf & CStr(input_x(0)) & vbCrLf &
            input_x_help(1) & vbCrLf & CStr(input_x(1)) & vbCrLf &
            input_x_help(2) & vbCrLf & CStr(input_x(2))
            ClearToolStripMenuItem.Visible = True
        End If
        If f_flag Then
            lbl_out.Text = lbl_out.Text & vbCrLf & "Производительность вакуум-фильтра по сухому веществу кг/м^3" & vbCrLf & Format(f, "##0.00")
        End If

        Return 0
    End Function

    Private Sub frm_main_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStripMain.Show()
            ContextMenuStripMain.Top = MousePosition.Y
            ContextMenuStripMain.Left = MousePosition.X
        End If
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClearToolStripMenuItem.Visible = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lbl_out.Text = ""
        ClearToolStripMenuItem.Visible = False
    End Sub

    Private Sub OutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutToolStripMenuItem.Click
        Conclus()
    End Sub

    Private Sub СохранитькакToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитькакToolStripMenuItem.Click
        save()
    End Sub
    Function save()
        Dim s As String
        If input_x_flag Then
            s = CStr(input_x(0)) & " " & CStr(input_x(1)) & " " & CStr(input_x(2))
            If f_flag Then
                s = s & CStr(f)
            End If
            SaveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt"
            If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, s, False, System.Text.Encoding.Default)
                lastFile = SaveFileDialog.FileName
            End If
        End If

    End Function

    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        Dim s As String
        If lastFile = "" Then
            save()
        Else
            s = CStr(input_x(0)) & " " & CStr(input_x(1)) & " " & CStr(input_x(2))
            If f_flag Then
                s = s & " " & CStr(f)
            End If
            My.Computer.FileSystem.WriteAllText(lastFile, s, False, System.Text.Encoding.Default)

        End If
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog
        Dim loadArr() As Object
        Dim s As String

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            lastFile = openFileDialog.FileName
            s = My.Computer.FileSystem.ReadAllText(lastFile)
            Try
                loadArr = Split(s, " ")
                For i = 0 To 2
                    input_x(i) = CDbl(loadArr(i))
                    input_x_flag = True
                Next i
                If loadArr.Length() > 3 Then
                    f = CDbl(loadArr(3))
                    f_flag = True
                Else
                    f_flag = False
                End If
                CalcToolStripMenuItemF.Visible = True
                lbl_out.Text = ""
                ClearToolStripMenuItem.Visible = False
            Catch
                MsgBox("Файл поврежден", MsgBoxStyle.Critical, "Ошибка")
            End Try
        End If
    End Sub

    Private Sub lbl_out_MouseClick(sender As Object, e As MouseEventArgs) Handles lbl_out.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStripMain.Show()
            ContextMenuStripMain.Top = MousePosition.Y
            ContextMenuStripMain.Left = MousePosition.X
        End If
    End Sub
End Class