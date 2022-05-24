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
        Me.btnstart = New System.Windows.Forms.Button()
        Me.lbl_mainTittle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_exit
        '
        Me.cmd_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd_exit.Location = New System.Drawing.Point(37, 335)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(140, 94)
        Me.cmd_exit.TabIndex = 0
        Me.cmd_exit.Text = "Выход"
        Me.cmd_exit.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnstart.Location = New System.Drawing.Point(578, 335)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(140, 93)
        Me.btnstart.TabIndex = 1
        Me.btnstart.Text = "Начать"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'lbl_mainTittle
        '
        Me.lbl_mainTittle.AutoSize = True
        Me.lbl_mainTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_mainTittle.Location = New System.Drawing.Point(33, 85)
        Me.lbl_mainTittle.Name = "lbl_mainTittle"
        Me.lbl_mainTittle.Size = New System.Drawing.Size(0, 20)
        Me.lbl_mainTittle.TabIndex = 2
        Me.lbl_mainTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_titul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 478)
        Me.Controls.Add(Me.lbl_mainTittle)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.cmd_exit)
        Me.Name = "frm_titul"
        Me.Text = "Курсовая работа"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents cmd_exit As Button
    Friend WithEvents btnstart As Button
    Friend WithEvents lbl_mainTittle As System.Windows.Forms.Label
End Class
