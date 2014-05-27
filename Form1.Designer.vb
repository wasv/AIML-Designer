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
        Me.butQuickSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butOpen
        '
        Me.butOpen.Location = New System.Drawing.Point(570, 11)
        Me.butOpen.Name = "butOpen"
        Me.butOpen.Size = New System.Drawing.Size(75, 23)
        Me.butOpen.TabIndex = 2
        Me.butOpen.Text = "Open"
        Me.butOpen.UseVisualStyleBackColor = True
        '
        'butSave
        '
        Me.butSave.Location = New System.Drawing.Point(651, 11)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(75, 23)
        Me.butSave.TabIndex = 3
        Me.butSave.Text = "Save As..."
        Me.butSave.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(813, 11)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(75, 23)
        Me.butClose.TabIndex = 4
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'lstQuickText
        '
        Me.lstQuickText.FormattingEnabled = True
        Me.lstQuickText.Items.AddRange(New Object() {"<star/>", "<sr/>", "<srai></srai>", "<set name=""xxx""></set>", "<get name=""xxx""/>", "<bot name=""name""/>", "<system mode=""sync""></system>", "<think></think>", "<condition></condition>", "<li></li>", "<li name=""xxx"" value=""xxx""></li>", "<li value=""xxx""></li>"})
        Me.lstQuickText.Location = New System.Drawing.Point(14, 41)
        Me.lstQuickText.Name = "lstQuickText"
        Me.lstQuickText.Size = New System.Drawing.Size(120, 264)
        Me.lstQuickText.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(14, 9)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 26)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Category"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(16, 310)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(119, 24)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Insert Text"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'pnlCategories
        '
        Me.pnlCategories.AutoScroll = True
        Me.pnlCategories.Location = New System.Drawing.Point(140, 41)
        Me.pnlCategories.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlCategories.Name = "pnlCategories"
        Me.pnlCategories.Size = New System.Drawing.Size(750, 406)
        Me.pnlCategories.TabIndex = 10
        '
        'butQuickSave
        '
        Me.butQuickSave.Location = New System.Drawing.Point(732, 11)
        Me.butQuickSave.Name = "butQuickSave"
        Me.butQuickSave.Size = New System.Drawing.Size(75, 23)
        Me.butQuickSave.TabIndex = 11
        Me.butQuickSave.Text = "Save"
        Me.butQuickSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 457)
        Me.Controls.Add(Me.butQuickSave)
        Me.Controls.Add(Me.pnlCategories)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstQuickText)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butOpen)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(915, 495)
        Me.MinimumSize = New System.Drawing.Size(915, 495)
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
    Friend WithEvents butQuickSave As System.Windows.Forms.Button

End Class
