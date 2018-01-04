Imports MySql.Data.MySqlClient
Public Class frmProduct
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim product_id As Integer = 0
 
    Sub Category()
        Dim categorys As String = "SELECT * FROM tbl_category"
        Dim cmdcategorys As New MySqlCommand(categorys, MysqlConn)
        Dim dacategorys As MySqlDataAdapter = New MySqlDataAdapter(cmdcategorys)
        Dim dtcategorys As New DataTable("category")
        dacategorys.Fill(dtcategorys)
        If dtcategorys.Rows.Count > 0 Then
            cboCategory.DataSource = dtcategorys
            cboCategory.ValueMember = "ct_id" 'The ID of the row
            cboCategory.DisplayMember = "ct_name" 'What is displayed
        End If
    End Sub
    Sub Clear()
        Me.txtProductID.Text = ""
        Me.txtProductName.Text = ""
        Me.cboCategory.Text = ""
        Me.txtPrice.Text = ""
    End Sub
    Sub InsertProduct()
        Dim READER As MySqlDataReader
        '  Dim sql As String
        Dim publictable As New DataTable
        ConnectDB() 'Call Function Connection
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO tbl_product (pd_name, price, ct_id) values ('" & txtProductName.Text & "','" & txtPrice.Text & "','" & cboCategory.SelectedValue & "')"
            Dim Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            MessageBox.Show("Your Data Have Been Saved")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        Category()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertProduct()
        Clear()
    End Sub
    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Clear()
        Me.txtProductID.Focus()
    End Sub
End Class