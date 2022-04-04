<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_birthday
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_now = New System.Windows.Forms.TextBox()
        Me.txt_birth = New System.Windows.Forms.TextBox()
        Me.cmb_dif = New System.Windows.Forms.ComboBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_btirth = New System.Windows.Forms.Label()
        Me.lbl_now = New System.Windows.Forms.Label()
        Me.lbl_dif = New System.Windows.Forms.Label()
        Me.lbl_tittle = New System.Windows.Forms.Label()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_now
        '
        Me.txt_now.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_now.Location = New System.Drawing.Point(167, 133)
        Me.txt_now.Name = "txt_now"
        Me.txt_now.Size = New System.Drawing.Size(153, 29)
        Me.txt_now.TabIndex = 0
        '
        'txt_birth
        '
        Me.txt_birth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_birth.Location = New System.Drawing.Point(167, 88)
        Me.txt_birth.Name = "txt_birth"
        Me.txt_birth.Size = New System.Drawing.Size(153, 29)
        Me.txt_birth.TabIndex = 1
        '
        'cmb_dif
        '
        Me.cmb_dif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmb_dif.FormattingEnabled = True
        Me.cmb_dif.Location = New System.Drawing.Point(167, 179)
        Me.cmb_dif.Name = "cmb_dif"
        Me.cmb_dif.Size = New System.Drawing.Size(153, 32)
        Me.cmb_dif.TabIndex = 2
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(12, 306)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(78, 31)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "Выход"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_btirth
        '
        Me.lbl_btirth.AutoSize = True
        Me.lbl_btirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_btirth.Location = New System.Drawing.Point(8, 88)
        Me.lbl_btirth.Name = "lbl_btirth"
        Me.lbl_btirth.Size = New System.Drawing.Size(153, 24)
        Me.lbl_btirth.TabIndex = 4
        Me.lbl_btirth.Text = "День рождения"
        '
        'lbl_now
        '
        Me.lbl_now.AutoSize = True
        Me.lbl_now.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_now.Location = New System.Drawing.Point(10, 134)
        Me.lbl_now.Name = "lbl_now"
        Me.lbl_now.Size = New System.Drawing.Size(87, 24)
        Me.lbl_now.TabIndex = 5
        Me.lbl_now.Text = "Сегодня"
        '
        'lbl_dif
        '
        Me.lbl_dif.AutoSize = True
        Me.lbl_dif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_dif.Location = New System.Drawing.Point(7, 179)
        Me.lbl_dif.Name = "lbl_dif"
        Me.lbl_dif.Size = New System.Drawing.Size(85, 24)
        Me.lbl_dif.TabIndex = 6
        Me.lbl_dif.Text = "Разница"
        '
        'lbl_tittle
        '
        Me.lbl_tittle.AutoSize = True
        Me.lbl_tittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_tittle.Location = New System.Drawing.Point(445, 88)
        Me.lbl_tittle.Name = "lbl_tittle"
        Me.lbl_tittle.Size = New System.Drawing.Size(103, 24)
        Me.lbl_tittle.TabIndex = 7
        Me.lbl_tittle.Text = "Результат"
        '
        'txt_output
        '
        Me.txt_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_output.Location = New System.Drawing.Point(422, 129)
        Me.txt_output.Name = "txt_output"
        Me.txt_output.Size = New System.Drawing.Size(151, 29)
        Me.txt_output.TabIndex = 8
        Me.txt_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_calc
        '
        Me.btn_calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_calc.Location = New System.Drawing.Point(435, 176)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(127, 31)
        Me.btn_calc.TabIndex = 9
        Me.btn_calc.Text = "Расчитать"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'frm_birthday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 349)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Me.lbl_tittle)
        Me.Controls.Add(Me.lbl_dif)
        Me.Controls.Add(Me.lbl_now)
        Me.Controls.Add(Me.lbl_btirth)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.cmb_dif)
        Me.Controls.Add(Me.txt_birth)
        Me.Controls.Add(Me.txt_now)
        Me.Name = "frm_birthday"
        Me.Text = "День рождения"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_now As TextBox
    Friend WithEvents txt_birth As TextBox
    Friend WithEvents cmb_dif As ComboBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_btirth As Label
    Friend WithEvents lbl_now As Label
    Friend WithEvents lbl_dif As Label
    Friend WithEvents lbl_tittle As Label
    Friend WithEvents txt_output As TextBox
    Friend WithEvents btn_calc As Button
End Class
