<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fb_open = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmd_open = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.cmd_lock = New System.Windows.Forms.Button()
        Me.cmd_unlock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_open
        '
        Me.cmd_open.Location = New System.Drawing.Point(292, 14)
        Me.cmd_open.Name = "cmd_open"
        Me.cmd_open.Size = New System.Drawing.Size(73, 24)
        Me.cmd_open.TabIndex = 0
        Me.cmd_open.Text = "Open"
        Me.cmd_open.UseVisualStyleBackColor = True
        '
        'txt_path
        '
        Me.txt_path.Location = New System.Drawing.Point(12, 16)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(274, 20)
        Me.txt_path.TabIndex = 1
        '
        'cmd_lock
        '
        Me.cmd_lock.Location = New System.Drawing.Point(12, 53)
        Me.cmd_lock.Name = "cmd_lock"
        Me.cmd_lock.Size = New System.Drawing.Size(160, 25)
        Me.cmd_lock.TabIndex = 2
        Me.cmd_lock.Text = "Lock"
        Me.cmd_lock.UseVisualStyleBackColor = True
        '
        'cmd_unlock
        '
        Me.cmd_unlock.Location = New System.Drawing.Point(205, 53)
        Me.cmd_unlock.Name = "cmd_unlock"
        Me.cmd_unlock.Size = New System.Drawing.Size(160, 25)
        Me.cmd_unlock.TabIndex = 2
        Me.cmd_unlock.Text = "Unlock"
        Me.cmd_unlock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 94)
        Me.Controls.Add(Me.cmd_unlock)
        Me.Controls.Add(Me.cmd_lock)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.cmd_open)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Folder Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fb_open As FolderBrowserDialog
    Friend WithEvents cmd_open As Button
    Friend WithEvents txt_path As TextBox
    Friend WithEvents cmd_lock As Button
    Friend WithEvents cmd_unlock As Button
End Class
