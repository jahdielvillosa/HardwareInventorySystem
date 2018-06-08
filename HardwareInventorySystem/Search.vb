Imports MySql.Data.MySqlClient

Public Class Search
    Dim currentSelectedRow As Integer
    Dim selectedSerial As Object

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayData()
        Dim x As String
        'get value from x
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        AddForm.Show()
    End Sub

    'Acquire the list of items from the database and display each item
    'to the table. 
    Public Sub displayData()
        Dim serial As String
        Dim model As String
        Dim product As String
        Dim acessories As String
        Dim problem As String
        Dim Client As String
        Dim Supplier As String
        Dim price As String
        Dim qty As String

        'clear table
        DataGridView1.MultiSelect = False
        ' clearTable(
        DataGridView1.Rows.Clear()

        query = "SELECT * FROM `product` "          'sql string command
        comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
        reader = comm.ExecuteReader                 'execute sql query 

        While reader.Read()
            serial = reader("SerialNumber").ToString()
            model = reader("Model").ToString()
            product = reader("Product").ToString()
            price = reader("Price").ToString()
            problem = reader("Problem").ToString()
            qty = reader("Qty").ToString()


            'adds items to the table 
            DataGridView1.Rows.Add(serial, product, model, qty, price, problem)
        End While
        reader.Close()

    End Sub

    'remove all rows in the table.
    Private Sub clearTable()
        Dim tableRow As Integer = 0
        tableRow = DataGridView1.RowCount
        MsgBox(tableRow)

        If tableRow > 1 Then

            For i As Integer = 1 To (tableRow) Step i = i + 1
                DataGridView1.Rows.RemoveAt(i) 'remove 1st row
            Next

        End If

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'get the first column value or serial number of the selected row (item)
        Try

            selectedSerial = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            sharedSerialNumber = selectedSerial
        Catch ex As Exception
            MsgBox("Please select only one item/product.")
        End Try
        'MsgBox(value)
        'acquire row index
        ' currentSelectedRow = e.RowIndex
        '  MsgBox(selectedSerial)
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim input As String = MessageBox.Show("Do you really want to delete this item?  This cannot be undone.", "Delete Confirmation", MessageBoxButtons.YesNo)

        If input = 6 Then 'yes
            If user = "admin" Then
                deleteItem(selectedSerial)
            Else
                MsgBox("You dont have the previlage to do this action.")
            End If
        End If
    End Sub

    Private Sub deleteItem(ByVal productSN)
        Try
            'remove from the database
            'DataGridView1.Rows.RemoveAt(currentSelectedRow)
            'acquire value from the database
            'DELETE FROM `hardwaresystem`.`product` WHERE `product`.`SerialNumber` = \'213123123\'"

            query = "DELETE FROM `hardwaresystem`.`product` WHERE `product`.`SerialNumber` = '" & productSN & "'"          'sql string command
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 
            reader.Close()                              'close reader

            'reload table
            displayData()
            MsgBox("delete successful")
        Catch ex As Exception
            MsgBox("unable to remove the selected item.")
        End Try
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        'display edit frame to modify the product selected by the user
        EditItemFrame.Show()
        setSharedSerial(selectedSerial)

    End Sub

    Private Sub InventoryBtn_Click_1(sender As Object, e As EventArgs) Handles InventoryBtn.Click
        Me.Close()
        InventoryMenu.Show()

    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        Me.Close()
        Sales.Show()
    End Sub

End Class