Imports System.IO
Imports System.Security.AccessControl

Public Class Form1
    Private Sub cmd_open_Click(sender As Object, e As EventArgs) Handles cmd_open.Click
        If fb_open.ShowDialog = DialogResult.OK Then
            txt_path.Text = fb_open.SelectedPath
        End If
    End Sub

    Private Sub cmd_lock_Click(sender As Object, e As EventArgs) Handles cmd_lock.Click
        If Not txt_path.Text = Nothing Then
            Dim fs As FileSystemSecurity = File.GetAccessControl(txt_path.Text)

            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))

            File.SetAccessControl(txt_path.Text, fs)
            MsgBox("Locked")
        End If
    End Sub

    Private Sub cmd_unlock_Click(sender As Object, e As EventArgs) Handles cmd_unlock.Click
        If Not txt_path.Text = Nothing Then
            Dim fs As FileSystemSecurity = File.GetAccessControl(txt_path.Text)

            fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))

            File.SetAccessControl(txt_path.Text, fs)
            MsgBox("Unlocked")
        End If
    End Sub
End Class
