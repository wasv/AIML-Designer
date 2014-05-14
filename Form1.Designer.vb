<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.butOpen = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.lstQuickText = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.pnlCategories = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'butOpen
        '
        Me.butOpen.Location = New System.Drawing.Point(868, 15)
        Me.butOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.butOpen.Name = "butOpen"
        Me.butOpen.Size = New System.Drawing.Size(100, 28)
        Me.butOpen.TabIndex = 2
        Me.butOpen.Text = "Open"
        Me.butOpen.UseVisualStyleBackColor = True
        '
        'butSave
        '
        Me.butSave.Location = New System.Drawing.Point(976, 15)
        Me.butSave.Margin = New System.Windows.Forms.Padding(4)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(100, 28)
        Me.butSave.TabIndex = 3
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(1084, 13)
        Me.butClose.Margin = New System.Windows.Forms.Padding(4)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(100, 28)
        Me.butClose.TabIndex = 4
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'lstQuickText
        '
        Me.lstQuickText.FormattingEnabled = True
        Me.lstQuickText.ItemHeight = 16
        Me.lstQuickText.Items.AddRange(New Object() {"<star/>", "<sr/>", "<srai></srai>", "<set name=""xxx""></set>", "<get name=""xxx""/>", "<bot name=""name""/>", "<system mode=""sync""></system>"})
        Me.lstQuickText.Location = New System.Drawing.Point(19, 50)
        Me.lstQuickText.Margin = New System.Windows.Forms.Padding(4)
        Me.lstQuickText.Name = "lstQuickText"
        Me.lstQuickText.Size = New System.Drawing.Size(159, 324)
        Me.lstQuickText.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(19, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(159, 32)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Category"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(21, 381)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(159, 29)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Insert Text"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'pnlCategories
        '
        Me.pnlCategories.AutoScroll = True
        Me.pnlCategories.Location = New System.Drawing.Point(186, 50)
        Me.pnlCategories.Name = "pnlCategories"
        Me.pnlCategories.Size = New System.Drawing.Size(1000, 500)
        Me.pnlCategories.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 553)
        Me.Controls.Add(Me.pnlCategories)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstQuickText)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butOpen)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1215, 600)
        Me.MinimumSize = New System.Drawing.Size(1215, 600)
        Me.Name = "Form1"
        Me.Text = "AIML Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butOpen As System.Windows.Forms.Button
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents lstQuickText As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents pnlCategories As System.Windows.Forms.FlowLayoutPanel

End Class
