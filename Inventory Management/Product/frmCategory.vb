Imports MySql.Data.MySqlClient
Public Class frmCategory
    Public Property cmd As MySqlCommand
    Public Property dr As MySqlDataReader
    Dim category_id As Integer = 0

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

  
    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click

    End Sub
End Class