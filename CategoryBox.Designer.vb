<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCategory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtPattern = New System.Windows.Forms.TextBox()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.lblThat = New System.Windows.Forms.Label()
        Me.txtThat = New System.Windows.Forms.TextBox()
        Me.lblTemplate = New System.Windows.Forms.Label()
        Me.txtTemplate = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPattern
        '
        Me.txtPattern.Location = New System.Drawing.Point(57, 3)
        Me.txtPattern.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPattern.Name = "txtPattern"
        Me.txtPattern.Size = New System.Drawing.Size(294, 20)
        Me.txtPattern.TabIndex = 0
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(3, 6)
        Me.lblPattern.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(41, 13)
        Me.lblPattern.TabIndex = 1
        Me.lblPattern.Text = "Pattern"
        '
        'lblThat
        '
        Me.lblThat.AutoSize = True
        Me.lblThat.Location = New System.Drawing.Point(3, 28)
        Me.lblThat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblThat.Name = "lblThat"
        Me.lblThat.Size = New System.Drawing.Size(29, 13)
        Me.lblThat.TabIndex = 2
        Me.lblThat.Text = "That"
        '
        'txtThat
        '
        Me.txtThat.Location = New System.Drawing.Point(57, 24)
        Me.txtThat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtThat.Name = "txtThat"
        Me.txtThat.Size = New System.Drawing.Size(294, 20)
        Me.txtThat.TabIndex = 3
        '
        'lblTemplate
        '
        Me.lblTemplate.AutoSize = True
        Me.lblTemplate.Location = New System.Drawing.Point(2, 50)
        Me.lblTemplate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTemplate.Name = "lblTemplate"
        Me.lblTemplate.Size = New System.Drawing.Size(51, 13)
        Me.lblTemplate.TabIndex = 4
        Me.lblTemplate.Text = "Template"
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(57, 46)
        Me.txtTemplate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTemplate.Multiline = True
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(294, 71)
        Me.txtTemplate.TabIndex = 5
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(5, 97)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(47, 19)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'usrCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.lblTemplate)
        Me.Controls.Add(Me.txtThat)
        Me.Controls.Add(Me.lblThat)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.txtPattern)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "usrCategory"
        Me.Size = New System.Drawing.Size(352, 122)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPattern As System.Windows.Forms.TextBox
    Friend WithEvents lblPattern As System.Windows.Forms.Label
    Friend WithEvents lblThat As System.Windows.Forms.Label
    Friend WithEvents txtThat As System.Windows.Forms.TextBox
    Friend WithEvents lblTemplate As System.Windows.Forms.Label
    Friend WithEvents txtTemplate As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button

End Class
