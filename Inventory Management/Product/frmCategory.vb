Imports MySql.Data.MySqlClient
Public Class frmCategory
    Public Property cmd As MySqlCommand
    Public Property dr As MySqlDataReader

    Sub CategoryRecord()


        '  Dim sql As String
        Dim publictable As New DataTable
        ConnectDB() 'Call Function Connection
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_category (ct_name) values ('" & txtCategoryname.Text & "')"

            cmd = New MySqlCommand(Query, MysqlConn)
            dr = cmd.ExecuteReader


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CategoryRecord()
        Me.txtCategoryname.Text = " "
        txtCategoryname.Focus()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ''  Dim i As Integer = 0
        ' For i = 0 To Me.txtCategoryname.v



    End Sub
End Class