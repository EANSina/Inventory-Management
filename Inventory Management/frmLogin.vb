Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Private Sub btnSigin_Click(sender As Object, e As EventArgs) Handles btnSigin.Click
        If txtUserName.Text = "admin" And txtPwd.Text = "admin" Then
            frmMain.Show()
            Me.Hide()
        Else
            txtUserName.Text = ""
            txtPwd.Text = ""
            Me.txtUserName.Focus()
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserName.Text = ""
        txtPwd.Text = ""
        txtUserName.Focus()
    End Sub
End Class