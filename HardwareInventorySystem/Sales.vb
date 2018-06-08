Imports MySql.Data.MySqlClient

Public Class Sales

    Dim serial As String
    Dim oldSerial As String
    Dim model As String
    Dim product As String
    Dim qty As Integer = 1
    Dim price As Decimal
    Dim newItem As Boolean = False

    'discount
    Dim discount As Decimal = 0
    Dim discountPrice As Decimal = 0

    Dim totalPayment As Double = 0.0
    Dim totalItem As Integer = 0

    Dim currentSelectedRow As Integer = 0


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        SerialTextBox.SelectAll()

        'acquire serial number
        serial = SerialTextBox.Text
        qty = QtyTxtBox.Text

        'clear all text boxes
        clearAll()

        'search the item using its Serial Number
        If searchItem() = True Then

            'add item
            SerialTextBox.Text = serial
            QtyTxtBox.Text = qty
            model = modelTxtBox.Text
            product = ProductTxtBox.Text

            price = PriceTxtBox.Text

            ' add item to the list
            DataGridView1.Rows.Add(serial, model, product, qty, price)

            'update payment
            calculateTotalPayment()

            'select text box
            SerialTextBox.SelectAll()
        End If
    End Sub

    Private Sub SerialTextBox_Click(sender As Object, e As EventArgs) Handles SerialTextBox.Click
        SerialTextBox.SelectAll()
    End Sub

    'press enter
    Private Sub SerialTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialTextBox.KeyDown


        If e.KeyCode = Keys.Enter Then
            SerialTextBox.SelectAll()
            'acquire serial number
            serial = SerialTextBox.Text
            qty = QtyTxtBox.Text
            'clear all text boxes
            clearAll()

            'search the item using its Serial Number
            If searchItem() = True Then

                'add item
                SerialTextBox.Text = serial
                QtyTxtBox.Text = qty
                model = modelTxtBox.Text
                product = ProductTxtBox.Text

                price = PriceTxtBox.Text

                ' add item to the list
                '  DataGridView1.Rows.Add(serial, model, product, qty, price)

                'update payment
                'calculateTotalPayment()

                'select text box
                SerialTextBox.SelectAll()
            End If

        End If

    End Sub

    Private Sub SerialTextBox_LostFocus(sender As Object, e As EventArgs) Handles SerialTextBox.LostFocus
        ' searchItem()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'clearAll() 'clear all text boxes
        '  price = PriceTxtBox.Text
        '  discount = discountTextBox.Text
        '  discount = discount / 100       'acquire the dicount in decimal

        '        discountPrice = price * discount    'acquire the discount value of price
        '        price = price - discountPrice
        '        MsgBox(price)
        verifyFields()
    End Sub


    'clear all text box for new input
    Private Sub clearAll()
        SerialTextBox.Text = ""
        modelTxtBox.Text = ""
        ProductTxtBox.Text = ""
        QtyTxtBox.Text = "1"
        PriceTxtBox.Text = ""
    End Sub

    'search an item using the searial number given that its 
    'serial is unique, when a record is found in the inventory
    'database, return TRUE. IF not, return FALSE.
    Private Function searchItem() As Boolean
        Dim found As Integer = 0

        Try
            query = "SELECT * FROM `product` WHERE `SerialNumber` LIKE '" & serial & "' "          'sql string command
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 

            While reader.Read()
                ' serial = reader("SerialNumber").ToString()
                model = reader("Model").ToString()
                product = reader("Product").ToString()
                price = reader("Price").ToString()
                found = found + 1
            End While
            reader.Close()

        Catch ex As Exception

        End Try

        'check the number if fonud items
        If found > 0 Then
            modelTxtBox.Text = model
            ProductTxtBox.Text = product
            QtyTxtBox.Text = qty
            PriceTxtBox.Text = price
            Return True
        Else
            MsgBox("Item not found") 'display message that item is not found
            Return False
        End If

    End Function

    Private Sub calculateTotalPayment()
        'apply discounted price
        discount = discountTextBox.Text
        discount = discount / 100       'acquire the dicount in decimal

        discountPrice = price * discount    'acquire the discount value of price
        price = price - discountPrice
        ' price = price * ()

        'acquire item price and its quantity
        price = price * qty

        'add from current item price to the total
        totalPayment = totalPayment + price

        'increase count
        totalItem = totalItem + qty

        'update item count on the screen
        itemCountLabel.Text = totalItem

        'update price on the screen
        totalPaymentLabel.Text = totalPayment


    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reset values on load
        totalPayment = 0.0
        totalItem = 0

    End Sub

    'remove the currently selected item
    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        Try
            DataGridView1.Rows.RemoveAt(currentSelectedRow)
        Catch ex As Exception
            MsgBox("unable to remove the selected item.")
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
        InventoryMenu.Show()
    End Sub

    'acquire the row of the selected item in the table 
    'and assign the row to the currentSelectedRow  when 
    'item in the table is clicked or selected
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'get the first column value or serial number of the selected row (item)
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        '  MsgBox(value)
        '  DataGridView1.Rows.RemoveAt(e.RowIndex)
        currentSelectedRow = e.RowIndex
    End Sub

    Private Sub InventoryBtn_Click(sender As Object, e As EventArgs) Handles InventoryBtn.Click
        InventoryMenu.Show()
        Me.Close()
    End Sub

    'reduce the quantity of the product in the database to update
    Private Sub updateProductQTY(ByVal selectedSerial As String, ByVal purchasedQty As Integer)
        'get item Balance Quantity

        'update item balance by deducting purchased quantity

        '  UPDATE `hardwaresystem`.`product` SET `Qty` = '1' WHERE `product`.`SerialNumber` = '10';

        Try
            query = "UPDATE `hardwaresystem`.`product` SET `Qty` = '" & purchasedQty & "' WHERE `product`.`SerialNumber` = '" & selectedSerial & "'; " 'sql string command
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 

            reader.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Function verifyFields()
        Dim allOK As Boolean = True
        Dim temp As Integer
        Dim tempPrice As Decimal
        Dim tempDiscount As Integer

        Try
            temp = QtyTxtBox.Text
            If temp < 0 Then
                allOK = False
                MsgBox("Input QUANTITY is invalid")
            End If
        Catch ex As Exception
            allOK = False
            MsgBox("Input QUANTITY is invalid")
        End Try

        Try
            tempPrice = PriceTxtBox.Text
            If tempPrice < 0 Then
                allOK = False
                MsgBox("Input PRICE is invalid")
            End If
        Catch ex As Exception
            allOK = False
            MsgBox("Input PRICE is invalid")
        End Try

        Try
            tempDiscount = discountTextBox.Text
            If tempDiscount > 100 And tempDiscount < 0 Then
                allOK = False
                MsgBox("Input DISCOUNT is invalid.")
            End If
        Catch ex As Exception
            allOK = False
            MsgBox("Input DISCOUNT is invalid")
        End Try

        Return allOK

    End Function
End Class