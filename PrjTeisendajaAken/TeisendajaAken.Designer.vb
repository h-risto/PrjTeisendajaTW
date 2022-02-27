<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeisendajaAken
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
        Me.cmbTeisendus = New System.Windows.Forms.ComboBox()
        Me.lblSisendYhik = New System.Windows.Forms.Label()
        Me.lblVastusYhik = New System.Windows.Forms.Label()
        Me.txtSisend = New System.Windows.Forms.TextBox()
        Me.txtVastus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbTeisendus
        '
        Me.cmbTeisendus.FormattingEnabled = True
        Me.cmbTeisendus.Location = New System.Drawing.Point(32, 61)
        Me.cmbTeisendus.Name = "cmbTeisendus"
        Me.cmbTeisendus.Size = New System.Drawing.Size(121, 21)
        Me.cmbTeisendus.TabIndex = 0
        '
        'lblSisendYhik
        '
        Me.lblSisendYhik.AutoSize = True
        Me.lblSisendYhik.Location = New System.Drawing.Point(159, 38)
        Me.lblSisendYhik.Name = "lblSisendYhik"
        Me.lblSisendYhik.Size = New System.Drawing.Size(39, 13)
        Me.lblSisendYhik.TabIndex = 1
        Me.lblSisendYhik.Text = "Label1"
        '
        'lblVastusYhik
        '
        Me.lblVastusYhik.AutoSize = True
        Me.lblVastusYhik.Location = New System.Drawing.Point(159, 91)
        Me.lblVastusYhik.Name = "lblVastusYhik"
        Me.lblVastusYhik.Size = New System.Drawing.Size(39, 13)
        Me.lblVastusYhik.TabIndex = 2
        Me.lblVastusYhik.Text = "Label2"
        '
        'txtSisend
        '
        Me.txtSisend.Location = New System.Drawing.Point(32, 35)
        Me.txtSisend.Name = "txtSisend"
        Me.txtSisend.Size = New System.Drawing.Size(121, 20)
        Me.txtSisend.TabIndex = 3
        '
        'txtVastus
        '
        Me.txtVastus.Location = New System.Drawing.Point(32, 88)
        Me.txtVastus.Name = "txtVastus"
        Me.txtVastus.Size = New System.Drawing.Size(121, 20)
        Me.txtVastus.TabIndex = 4
        '
        'TeisendajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 151)
        Me.Controls.Add(Me.txtVastus)
        Me.Controls.Add(Me.txtSisend)
        Me.Controls.Add(Me.lblVastusYhik)
        Me.Controls.Add(Me.lblSisendYhik)
        Me.Controls.Add(Me.cmbTeisendus)
        Me.Name = "TeisendajaAken"
        Me.Text = "Teisendaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTeisendus As ComboBox
    Friend WithEvents lblSisendYhik As Label
    Friend WithEvents lblVastusYhik As Label
    Friend WithEvents txtSisend As TextBox
    Friend WithEvents txtVastus As TextBox
End Class
