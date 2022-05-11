Imports Course.plus
Imports Course.Minus
Imports Course.Division
Imports Course.Mult

Public Class frm_calculator

    Dim a As Double
    Dim flg_a As Boolean = False
    Dim b As Double
    Dim flg_b As Boolean = False
    Dim op As Char
    Dim flg_op As Boolean = True
    Dim dict As New Dictionary(Of String, Object)()


    Function calculate(ByVal oper As Char) As Double
        If Not dict(oper).validate(a, b) Then

            MsgBox("Ошибка", MsgBoxStyle.Critical & vbOKOnly)
            cancel()
            Return 0
        End If
        Return dict(oper).calc(a, b)
    End Function

    Function main(ByVal oper As Char) As Integer
        txt_input.Enabled = True
        If Not flg_op Then
            flg_a = False
            flg_b = False
        End If
        Try
            If Not flg_a Then
                a = CDbl(txt_input.Text)
                flg_a = True
                op = oper
                flg_op = True
            Else
                b = CDbl(txt_input.Text)
                flg_b = True
                If flg_b Then
                    a = calculate(op)
                End If
                op = oper
                flg_op = True
            End If
        Catch ex As Exception
            cancel()
        End Try
        txt_input.Text = ""
        Return 1
    End Function
    Function cancel() As Integer
        flg_a = False
        flg_b = False
        flg_op = True
        txt_input.Text = ""
        txt_input.Enabled = True
        Return 1
    End Function

    Private Sub frm_calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dict.Add((New plus).name(), New plus)
        dict.Add((New Minus).name(), New Minus)
        dict.Add((New Mult).name(), New Mult)
        dict.Add((New Division).name(), New Division)
    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        main("+")
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If flg_op Then
            Try
                b = CDbl(txt_input.Text)
                flg_b = True
            Catch ex As Exception
                txt_input.Text = Format(a, "#0.00")
            End Try
        End If
        If flg_a And flg_b Then
            a = calculate(op)
            If Not flg_a Then
                Return
            End If
            txt_input.Enabled = False
            txt_input.Text = Format(a, "#0.00")
            flg_op = False
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        cancel()
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        main("-")
    End Sub

    Private Sub btn_mul_Click(sender As Object, e As EventArgs) Handles btn_mul.Click
        main("*")
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        main("/")
    End Sub
End Class