Imports MySql.Data.MySqlClient

Public Class EditItemFrame
    Dim serial As String = ""
    Dim description As String = ""
    Dim product As String = ""
    Dim acessories As String = ""
    Dim problem As String = ""
    Dim Client As String = ""
    Dim Supplier As String = ""
    Dim price As String = ""
    Dim qty As String = ""
    Dim DeliveryDate As String = ""
    Dim WarrantyDateSup As String = ""
    Dim WarrantyDateClient As String = ""
    Dim status As String = ""


    Dim selectedItemSerial As String

    Private Sub EditItemFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'acquire serial number
        selectedItemSerial = getSharedSerial()
        serialTxtBox.Text = sharedSerialNumber

        'display item details
        acquireItemInfo()

        'acquire list of valid suppliers 
        getSupplierList()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub acquireItemInfo()
        'SELECT * FROM `product` WHERE `SerialNumber` LIKE '1' 

        'acquire serial number in the text box
        serial = serialTxtBox.Text

        query = "SELECT * FROM `product` WHERE `SerialNumber` LIKE '" & serial & "'  "          'sql string command
        comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
        reader = comm.ExecuteReader                 'execute sql query 

        While reader.Read()
            serial = reader("SerialNumber").ToString()
            product = reader("Product").ToString()
            description = reader("Model").ToString()
            price = reader("Price").ToString()
            qty = reader("Qty").ToString()
            acessories = reader("Accessories").ToString()
            Supplier = reader("Sup_Name").ToString()
            DeliveryDate = reader("DeliveryDate").ToString()
            WarrantyDateSup = reader("WarrantyDate_Supplier").ToString()
            WarrantyDateClient = reader("WarrantyDate_Client").ToString()
            problem = reader("Problem").ToString()
            status = reader("itemStatus").ToString()


            'adds items to the table 
            '  DataGridView1.Rows.Add(serial, model, product, price, problem)
        End While
        reader.Close()

        'update textfields
        serialTxtBox.Text = serial
        productTextBox.Text = product
        descTextBox.Text = description
        priceTextBox.Text = price
        QtyTextBox.Text = qty
        accesTextBox.Text = acessories
        supplierTxtBox.Text = Supplier
        dateAcqTextBox.Text = DeliveryDate
        supWarTextBox.Text = WarrantyDateSup
        clientWarTextBox.Text = WarrantyDateClient
        problemTextBox.Text = problem
        itemstatusTextBox.Text = status
        If status = "returned" Then
            'search returned status of the item using its serial
        End If

    End Sub

    'update product information
    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        'check if all fields are filled out

        'update product
        updateProduct()

        'update the table in the search inventory frame
        Search.displayData()

        'close edit frame
        Me.Close()
    End Sub

    Private Sub updateProduct()

        'update textfields
        product = productTextBox.Text
        description = descTextBox.Text
        price = priceTextBox.Text
        acessories = accesTextBox.Text
        Supplier = supplierTxtBox.Text
        DeliveryDate = dateAcqTextBox.Text
        WarrantyDateSup = supWarTextBox.Text
        WarrantyDateClient = clientWarTextBox.Text
        problem = problemTextBox.Text
        status = itemstatusTextBox.Text
        'acquire serial number in the text box
        serial = serialTxtBox.Text

        'UPDATE `hardwaresystem`.`product` SET `Product` = 'asd1', `Model` = 'asd1', `Accessories` = 'none1', `Price` = '101', `Sup_Name` = 'globe', `DeliveryDate` = '2016-08-31 00:00:01', `WarrantyDate_Supplier` = '2018-08-31 00:00:01', `WarrantyDate_Client` = '2017-08-31 00:00:01', `Problem` = 'none1', `itemStatus` = 'availabl1' WHERE `product`.`SerialNumber` = '4';

        query = "UPDATE `hardwaresystem`.`product` SET `Product` = '" & product & "', " &
            " `Model` = '" & description & "', `Accessories` = '" & acessories & "', `Price` = '" & price & "', " &
            "`Sup_Name` = '" & Supplier & "', `DeliveryDate` = '" & DeliveryDate & "', " &
            "`WarrantyDate_Supplier` = '" & WarrantyDateSup & "', " &
            " `WarrantyDate_Client` = '" & WarrantyDateClient & "', `Problem` = '" & problem & "', " &
            "`itemStatus` = '" & status & "' WHERE `product`.`SerialNumber` = '" & serial & "';"          'sql string command
        comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
        reader = comm.ExecuteReader                 'execute sql query 

        reader.Close()
        MsgBox("Editing of the product is successful")
    End Sub


    'acquire the list of suppliers from the database
    Private Sub getSupplierList()
        Try
            'Find the supplier id using the supplier name 
            query = "SELECT * FROM `supplier`"
            comm = New MySqlCommand(query, MysqlConn)
            reader = comm.ExecuteReader

            'search through the table
            While reader.Read()
                Dim suppliers As String = reader("Sup_Name").ToString()
                supplierTxtBox.Items.Add(suppliers)

            End While

        Catch ex As Exception
            MsgBox("supplier invalid " & ex.Message)
        End Try
        reader.Close()
    End Sub
End Class