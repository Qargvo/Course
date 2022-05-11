<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_calculator
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_mul = New System.Windows.Forms.Button()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.btn_equal = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_input
        '
        Me.txt_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_input.Location = New System.Drawing.Point(30, 33)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(345, 38)
        Me.txt_input.TabIndex = 0
        Me.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_plus
        '
        Me.btn_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_plus.Location = New System.Drawing.Point(58, 102)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(80, 80)
        Me.btn_plus.TabIndex = 1
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'btn_mul
        '
        Me.btn_mul.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_mul.Location = New System.Drawing.Point(162, 102)
        Me.btn_mul.Name = "btn_mul"
        Me.btn_mul.Size = New System.Drawing.Size(80, 80)
        Me.btn_mul.TabIndex = 2
        Me.btn_mul.Text = "х"
        Me.btn_mul.UseVisualStyleBackColor = True
        '
        'btn_minus
        '
        Me.btn_minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_minus.Location = New System.Drawing.Point(58, 201)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(80, 80)
        Me.btn_minus.TabIndex = 3
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_div.Location = New System.Drawing.Point(162, 201)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(80, 80)
        Me.btn_div.TabIndex = 4
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'btn_equal
        '
        Me.btn_equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_equal.Location = New System.Drawing.Point(263, 102)
        Me.btn_equal.Name = "btn_equal"
        Me.btn_equal.Size = New System.Drawing.Size(80, 80)
        Me.btn_equal.TabIndex = 5
        Me.btn_equal.Text = "="
        Me.btn_equal.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(263, 201)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 80)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "C"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'frm_calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 315)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_equal)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_mul)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.txt_input)
        Me.Name = "frm_calculator"
        Me.Text = "Калькулятор"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_input As TextBox
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_mul As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_cancel As Button
End Class
