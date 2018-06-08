
' Returning of Damaged Item 
'   If a purchased item is to be returned by the client
' for any defects are found in the item. The item must be 
' purchased from the store. Using the barcode scanner, the barcode
' of the item is scanned or/and be inputted in the barcode textfield.
' Returining process
' 1. When enter is pressed (or barcode scanner scanned the item) - search the correspoding item 
'    in the database from the products table
' 2. the user will supply/fill out all blanked fields 
' 3. When OK button is pressed or clicked, the system will verify if all textfields are filled out
' 4. If a new user, add a new user in the client table of the database. If not, retrieved old client info
' 5. Acquire client ID from the database using the clientName and clientNumber (phone number)
' 6. update the status of the item in the products table in the databse to "returned item" and its corresponding problem
' 7. add a new transaction entry in the table by the time the item is returned.
'

Imports MySql.Data.MySqlClient

Public Class ReturnDamage

    Dim model, serial, clientID As String
    Dim product, accessory, supplier, warranty, price, datePurchased, problem As String
    Dim qty As Integer = 1
    Dim clientName, clientAddress, clientNumber, clientEmail As String
    Dim clientTypeNew As Boolean = False


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles serialTxtBox.KeyDown

        'when enter key is pressed
        If e.KeyCode = Keys.Enter Then
            serialTxtBox.SelectAll()
            'acquire serial number
            serial = serialTxtBox.Text

            'clear all text boxes
            'clearAll()

            'search the item using its Serial Number
            If searchItem() = True Then

                'display item
                serialTxtBox.Text = serial

            End If
        End If

    End Sub

    'search an item using the searial number given that its 
    'serial is unique, when a record is found in the inventory
    'database, return TRUE. IF not, return FALSE.
    Private Function searchItem() As Boolean
        Dim found As Integer = 0

        Try
            query = "SELECT * FROM `product` WHERE `SerialNumber` LIKE '" & serial & "' " 'sql string command
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 

            'acquire item data
            While reader.Read()
                model = reader("Model").ToString()
                product = reader("Product").ToString()
                accessory = reader("Accessories").ToString()
                supplier = reader("Sup_Name").ToString()
                price = reader("Price").ToString()
                warranty = reader("WarrantyDate_Client").ToString
                found = found + 1
            End While
            reader.Close()

        Catch ex As Exception

            MsgBox(ex.Message) 'display message that item is not found
            Return False
        End Try

        'check the number if fonud items
        If found > 0 Then
            modelTxtBox.Text = model
            productTxtBox.Text = product
            priceTextBox.Text = price
            datePurchasedTextBox.Text = "none"
            supplierTextBox.Text = supplier
            acessoryTextBox.Text = accessory
            warrantyTextBox.Text = warranty.Substring(0, 10) 'acquire only the warranty date and remove the time

            Return True
        Else
            MsgBox(serial & ": Item not found") 'display message that item is not found
            Return False
        End If

    End Function

    'when CANCEL button is clicked
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InventoryMenu.Show()
        Me.Close()
    End Sub

    'when OK button is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check if all textboxes are filled out.
        If checkAlltextboxsIfnotNull() = True Then

            'check if the warranty date is valid for returning item
            checkWarrantyDate()

            'acquire client info
            acquireClientInfo()

            'acquire and update problem from text box 
            updateProduct()

            'add new transaction entry
            addReturnTransaction()

            'show product return successful message
            MsgBox("Product is return successfully")

            'clear text fields except the client text fields
            clearProducFields()
        Else
            MsgBox("Please fill out all the necessary information required.")
        End If

    End Sub

    'check if the warranty date is still valid up to today by 
    'the acquired warranty date of the item and the date today.
    'The date today is subtracted from the warranty date of the item 
    'and if it is greater than 0 or positive, it can still be returned
    Private Sub checkWarrantyDate()
        ' warranty
        'acquire the date today
        Dim today As Date = Date.Today.ToString("yyyy-MM-dd HH:mm:ss")
        Dim Clientwarranty As Date = warranty
        Dim dateDifference As Integer

        'calculate the remaining days until warranty expires
        dateDifference = DateDiff(DateInterval.Day, today, Clientwarranty)

        'check if the item is under warranty
        If dateDifference > -1 Then
            ' MsgBox("Warranty is OK")
        Else
            MsgBox("The Product cannot be returned due to the expiration of item warranty")
        End If

    End Sub

    'get the client informations from the text fields
    'and add a new client into the database
    Private Sub acquireClientInfo()

        clientName = clientNameTextBox.Text
        clientAddress = clientaddressTextBox.Text
        clientNumber = clientNumberTextBox.Text
        clientEmail = clientEmailTextBox.Text
        problem = problemTextBox.Text

        If clientTypeNew = True Then

            Try
                'add new Client
                ' INSERT INTO `hardwaresystem`.`client` (`ClientID`, `Name`, `Address`, `ContactNumber`, `Email`) VALUES (NULL, 'asd', 'asd', 'asd', 'asd');
                query = "INSERT INTO `hardwaresystem`.`client` (`ClientID`, `Name`, `Address`, `ContactNumber`, `Email`) " &
                    " VALUES ('0', '" & clientName & "', '" & clientAddress & "', '" & clientNumber & "', '" & clientEmail & "');" 'sql string command
                comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
                reader = comm.ExecuteReader                 'execute sql query 

                reader.Close()
            Catch ex As Exception

                MsgBox(ex.Message)   'display message that item is not found

            End Try
        Else
            'do not add because the client is an old costumer
        End If


    End Sub

    Private Sub updateProduct()
        ' UPDATE `hardwaresystem`.`product` SET `Problem` = 'broken disk' WHERE `product`.`SerialNumber` = '3';
        Try
            query = " UPDATE `hardwaresystem`.`product` SET `Problem` = '" & problem & "', `itemStatus` = 'returned' WHERE `product`.`SerialNumber` = '" & serial & "'; " 'sql string command
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 

            reader.Close()
        Catch ex As Exception

            MsgBox(ex.Message) 'display message that item is not found

        End Try
    End Sub

    'SELECT * FROM `client` 
    Private Sub getClientID()

        Try
            query = "SELECT * FROM `client` WHERE `Name` LIKE '" & clientName & "' AND `ContactNumber` LIKE '" & clientNumber & "' " 'sql string command
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 

            'acquire item data
            While reader.Read()
                clientID = reader("ClientID").ToString
            End While
            reader.Close()

        Catch ex As Exception
            MsgBox("An error occured @acquiring clientID : " & ex.Message)
        End Try
    End Sub



    'add new transaction entry after returning the item
    Private Sub addReturnTransaction()
        'acquire client ID
        getClientID()

        'acquire date and time today
        Dim today As String = Date.Today.ToString("yyyy-MM-dd ")
        today = today & (DateAndTime.TimeOfDay.ToString("HH:mm:ss"))

        'add new entry into the table
        Try
            'add new Client
            'INSERT INTO `hardwaresystem`.`transaction` (`TransactionID`, `SerialNumber`, `ClientID`, `InVoiceNumber`, `Date`, `Boxes`, `Username`, `TransactionType`) VALUES ('0', '2', '1', '0', '000000', '1', 'admin', 'Return Item');
            query = "INSERT INTO `hardwaresystem`.`transaction` (`TransactionID`, `SerialNumber`," &
                " `ClientID`, `InVoiceNumber`, `Date`, `Boxes`, `TransactionType`) VALUES " &
                "('0', '" & serial & "', '" & clientID & "', '0', '" & today & "', '1',  'Return Item');"
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 

            reader.Close()

        Catch ex As Exception
            MsgBox("An error occured @ adding new transaction : " & ex.Message) 'display message that item is not found
        End Try

    End Sub


    'check every text box if empty, if one text box is empty, return false
    Private Function checkAlltextboxsIfnotNull() As Boolean
        Dim isEmpty As Boolean = True
        If clientNameTextBox.TextLength = 0 Then
            isEmpty = False
        End If
        If clientaddressTextBox.TextLength = 0 Then
            isEmpty = False
        End If
        If clientNumberTextBox.TextLength = 0 Then
            isEmpty = False
        End If
        If clientEmailTextBox.TextLength = 0 Then
            isEmpty = False
        End If
        If problemTextBox.TextLength = 0 Then
            isEmpty = False
        End If
        Return isEmpty
    End Function

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Dim today As String = Date.Today.ToString("yyyy-MM-dd ")
        today = today & (DateAndTime.TimeOfDay.ToString("HH:mm:ss"))
        MsgBox(today)
    End Sub

    Private Sub handleClientType()
        If newClientRadBtn.Checked = True Then
            ' MsgBox("New client")
            clientTypeNew = True
        End If


        If oldClientRadBtn.Checked = True Then
            'MsgBox("OLD client")
            clientTypeNew = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        handleClientType()
        Dim oldclientName As String = clientNameTextBox.Text
        ' if old client will be returning the item, 
        'search the client info using its name
        If clientTypeNew = False Then

            Try
                query = "SELECT * FROM `client` WHERE `Name` LIKE '" & oldclientName & "' " 'sql string command
                comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
                reader = comm.ExecuteReader                 'execute sql query 

                'acquire item data
                While reader.Read()
                    clientNameTextBox.Text = reader("Name").ToString
                    clientaddressTextBox.Text = reader("Address").ToString
                    clientNumberTextBox.Text = reader("ContactNumber").ToString
                    clientEmailTextBox.Text = reader("Email").ToString

                End While
                reader.Close()
                MsgBox("Done Searching")
            Catch ex As Exception
                MsgBox("An error occured @ searching old client: " & ex.Message) 'display message that item is not found
            End Try

        End If

    End Sub

    Private Sub oldClientRadBtn_CheckedChanged(sender As Object, e As EventArgs) Handles oldClientRadBtn.CheckedChanged
        Button3.Show()
    End Sub

    Private Sub newClientRadBtn_CheckedChanged(sender As Object, e As EventArgs) Handles newClientRadBtn.CheckedChanged
        Button3.Hide()
    End Sub

    'opeb the menu frame and close returnDamage frame
    Private Sub InventoryBtn_Click_1(sender As Object, e As EventArgs) Handles InventoryBtn.Click
        InventoryMenu.Show()
        Me.Close()
    End Sub

    Private Sub clearProducFields()

        serialTxtBox.Text = ""
        modelTxtBox.Text = ""
        productTxtBox.Text = ""
        priceTextBox.Text = ""
        datePurchasedTextBox.Text = ""
        supplierTextBox.Text = ""
        acessoryTextBox.Text = ""
        warrantyTextBox.Text = ""
        problemTextBox.Text = ""

    End Sub

End Class