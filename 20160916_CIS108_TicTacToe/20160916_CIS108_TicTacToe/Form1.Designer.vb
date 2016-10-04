<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnA1 = New System.Windows.Forms.Button()
        Me.btnB1 = New System.Windows.Forms.Button()
        Me.btnC1 = New System.Windows.Forms.Button()
        Me.btnA2 = New System.Windows.Forms.Button()
        Me.btnB2 = New System.Windows.Forms.Button()
        Me.btnA3 = New System.Windows.Forms.Button()
        Me.btnC2 = New System.Windows.Forms.Button()
        Me.btnB3 = New System.Windows.Forms.Button()
        Me.btnC3 = New System.Windows.Forms.Button()
        Me.lblMessageBox = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnA1
        '
        Me.btnA1.Location = New System.Drawing.Point(112, 100)
        Me.btnA1.Name = "btnA1"
        Me.btnA1.Size = New System.Drawing.Size(20, 20)
        Me.btnA1.TabIndex = 0
        Me.btnA1.UseVisualStyleBackColor = True
        '
        'btnB1
        '
        Me.btnB1.Location = New System.Drawing.Point(132, 100)
        Me.btnB1.Name = "btnB1"
        Me.btnB1.Size = New System.Drawing.Size(20, 20)
        Me.btnB1.TabIndex = 1
        Me.btnB1.UseVisualStyleBackColor = True
        '
        'btnC1
        '
        Me.btnC1.Location = New System.Drawing.Point(152, 100)
        Me.btnC1.Name = "btnC1"
        Me.btnC1.Size = New System.Drawing.Size(20, 20)
        Me.btnC1.TabIndex = 2
        Me.btnC1.UseVisualStyleBackColor = True
        '
        'btnA2
        '
        Me.btnA2.Location = New System.Drawing.Point(112, 120)
        Me.btnA2.Name = "btnA2"
        Me.btnA2.Size = New System.Drawing.Size(20, 20)
        Me.btnA2.TabIndex = 3
        Me.btnA2.UseVisualStyleBackColor = True
        '
        'btnB2
        '
        Me.btnB2.Location = New System.Drawing.Point(132, 120)
        Me.btnB2.Name = "btnB2"
        Me.btnB2.Size = New System.Drawing.Size(20, 20)
        Me.btnB2.TabIndex = 4
        Me.btnB2.UseVisualStyleBackColor = True
        '
        'btnA3
        '
        Me.btnA3.Location = New System.Drawing.Point(112, 140)
        Me.btnA3.Name = "btnA3"
        Me.btnA3.Size = New System.Drawing.Size(20, 20)
        Me.btnA3.TabIndex = 6
        Me.btnA3.UseVisualStyleBackColor = True
        '
        'btnC2
        '
        Me.btnC2.Location = New System.Drawing.Point(152, 120)
        Me.btnC2.Name = "btnC2"
        Me.btnC2.Size = New System.Drawing.Size(20, 20)
        Me.btnC2.TabIndex = 5
        Me.btnC2.UseVisualStyleBackColor = True
        '
        'btnB3
        '
        Me.btnB3.Location = New System.Drawing.Point(132, 140)
        Me.btnB3.Name = "btnB3"
        Me.btnB3.Size = New System.Drawing.Size(20, 20)
        Me.btnB3.TabIndex = 7
        Me.btnB3.UseVisualStyleBackColor = True
        '
        'btnC3
        '
        Me.btnC3.Location = New System.Drawing.Point(152, 140)
        Me.btnC3.Name = "btnC3"
        Me.btnC3.Size = New System.Drawing.Size(20, 20)
        Me.btnC3.TabIndex = 8
        Me.btnC3.UseVisualStyleBackColor = True
        '
        'lblMessageBox
        '
        Me.lblMessageBox.AutoSize = True
        Me.lblMessageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageBox.Location = New System.Drawing.Point(22, 19)
        Me.lblMessageBox.MinimumSize = New System.Drawing.Size(240, 50)
        Me.lblMessageBox.Name = "lblMessageBox"
        Me.lblMessageBox.Size = New System.Drawing.Size(240, 50)
        Me.lblMessageBox.TabIndex = 10
        Me.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(105, 207)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayAgain.TabIndex = 11
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'frmTicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblMessageBox)
        Me.Controls.Add(Me.btnC3)
        Me.Controls.Add(Me.btnB3)
        Me.Controls.Add(Me.btnC2)
        Me.Controls.Add(Me.btnA3)
        Me.Controls.Add(Me.btnB2)
        Me.Controls.Add(Me.btnA2)
        Me.Controls.Add(Me.btnC1)
        Me.Controls.Add(Me.btnB1)
        Me.Controls.Add(Me.btnA1)
        Me.Name = "frmTicTacToe"
        Me.Text = "TicTacToe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnA1 As Button
    Friend WithEvents btnB1 As Button
    Friend WithEvents btnC1 As Button
    Friend WithEvents btnA2 As Button
    Friend WithEvents btnB2 As Button
    Friend WithEvents btnA3 As Button
    Friend WithEvents btnC2 As Button
    Friend WithEvents btnB3 As Button
    Friend WithEvents btnC3 As Button
    Friend WithEvents lblMessageBox As Label
    Friend WithEvents btnPlayAgain As Button
End Class
