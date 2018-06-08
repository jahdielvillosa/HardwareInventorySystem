Imports MySql.Data.MySqlClient

Public Class TableView

    Private Sub TableView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayDate()
    End Sub

    Private Sub displayDate()
        Dim serial As String
        Dim model As String
        Dim product As String
        Dim acessories As String
        Dim problem As String
        Dim Client As String
        Dim Supplier As String
        Dim price As String

        'MysqlConn.Open()

        query = "SELECT * FROM `product` "          'sql string command
        comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
        reader = comm.ExecuteReader                 'execute sql query 

        While reader.Read()
            serial = reader("SerialNumber").ToString()
            model = reader("Model").ToString()
            product = reader("Product").ToString()
            price = reader("Price").ToString()
            problem = ("Problem").ToString()
            ' reader("Card_ID").ToString()
            DataGridView1.Rows.Add(serial, model, product, price, "none")
        End While
        reader.Close()
    End Sub
End Class