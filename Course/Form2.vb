Public Class frm_main
    Dim input_x(3) As Integer

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Dim inp As String
        Dim error_string As String
        Dim error_flag As Boolean
        Dim i As Integer

        error_string = ""
        error_flag = False



        For i = 0 To 2
            inp = pnl_input.Controls(i).Text
            If validate_as_num(inp) Then
                input_x(i) = Val(inp)
            Else
                error_string += "X" + CStr(i + 1) + " "
                error_flag = True
            End If
        Next i

        If error_flag Then
            error_string = "Неверный тип значения " + error_string
            MsgBox(error_string, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
        End If
    End Sub

    Public Function validate_as_num(a) As Boolean
        If IsNumeric(a) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class