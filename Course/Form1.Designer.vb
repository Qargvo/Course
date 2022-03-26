<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_titul
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_exit
        '
        Me.cmd_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd_exit.Location = New System.Drawing.Point(37, 335)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(140, 94)
        Me.cmd_exit.TabIndex = 0
        Me.cmd_exit.Text = "Exit"
        Me.cmd_exit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(454, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 93)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_titul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 478)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmd_exit)
        Me.Name = "frm_titul"
        Me.Text = "Курсовая работа"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents cmd_exit As Button
    Friend WithEvents Button1 As Button
End Class
