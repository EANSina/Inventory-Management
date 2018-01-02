Imports MySql.Data.MySqlClient
Public Class frmProduct
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
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


    Public Sub Clear()
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
            frmMasageBox.Show()
            ' MessageBox.Show("Data Saved")
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



        'If Me.Text = "frmMain" Then
        '    Me.BackColor = Color.Transparent
        'End If
        lvProduct.Columns.Add("ID", 50)
        lvProduct.Columns.Add("Product Name", 80)
        lvProduct.Columns.Add("Category", 80)
        lvProduct.Columns.Add("Price", 50)
        '   lvProduct()


    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertProduct()
        Clear()

        lvProduct.Columns.Add("ID", 50)
        lvProduct.Columns.Add("Product Name", 80)
        lvProduct.Columns.Add("Category", 80)
        lvProduct.Columns.Add("Price", 50)


    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Me.txtProductID.Text = Me.lvProduct.Items.Count + +1
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = 0
        For i = 0 To Me.lvProduct.Items.Count
            If lvProduct.Items(i).Selected = True Then
                lvProduct.Items(i).Remove()

            End If
        Next
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged

    End Sub
End Class