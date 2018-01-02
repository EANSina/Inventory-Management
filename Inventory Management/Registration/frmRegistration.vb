Imports MySql.Data.MySqlClient
Public Class frmRegistration
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim READER As MySqlDataReader
        '  Dim sql As String
        Dim publictable As New DataTable
        ConnectDB() 'Call Function Connection
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_registration (username, passwd, fullname, contactNo) values ('" & txtUserName.Text & "','" & txtPassword.Text & "','" & txtFullName.Text & "','" & txtContactNo.Text & "')"
            Dim Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            frmMasageBox.Show()
            ' MessageBox.Show("Data Saved")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtContactNo.Text = ""
        txtFullName.Text = ""
    End Sub
    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtFullName.Text = ""
        txtContactNo.Text = ""
        txtUserName.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class