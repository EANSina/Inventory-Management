Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Private Sub btnSingin_Click(sender As Object, e As EventArgs) Handles btnSingin.Click
        If txtUserName.Text = "admin" And txtPassWord.Text = "admin" Then
            frmMain.Show()
            Me.Hide()
        Else
            txtUserName.Text = ""
            txtPassWord.Text = ""
            Me.txtUserName.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserName.Text = ""
        txtPassWord.Text = ""
        Me.txtUserName.Focus()
    End Sub
End Class