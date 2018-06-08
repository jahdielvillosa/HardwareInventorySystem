Imports MySql.Data.MySqlClient

Public Class AddForm

    Private Sub addnewItem()

        Dim serial As String = SerialTxtBox.Text
        Dim model As String = ModelTxtBox.Text
        Dim product As String = BrandTxtBox.Text
        Dim invoice As String = InvoiceTxtBox.Text
        Dim price As String = CostTxtBox.Text
        Dim qty As String = QtytextBox.Text
        Dim PONum As String = PONumTxtBox.Text
        Dim accessory As String = accessoryTxtBox.Text

        Dim supName As String

        supName = SupplierTxtBox.Text

        'acquire warranty dates
        Dim datetoday As String = DeliveryDatePicker.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")

        Dim tempdate As Date = datetoday
        Dim acquiredDate As String = DeliveryDatePicker.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")
        Dim warrantyClientDate As String = DateAdd(DateInterval.Year, 1, tempdate).ToString("yyyy-MM-dd HH:mm:ss") 'warranty date for client
        Dim warrantySupplierDate As String = DateAdd(DateInterval.Year, 2, tempdate).ToString("yyyy-MM-dd HH:mm:ss") 'warranty date for supplier

        'update the database and add a new item
        Try
            query = "INSERT INTO `hardwaresystem`.`product` " &
                "(`SerialNumber`,  `Product`, `Model`, `Accessories`, `Qty`, `Price`, `Sup_Name`, `DeliveryDate`, `WarrantyDate_Supplier`, " &
                "`WarrantyDate_Client`, `Problem`,`itemStatus`, `isObsolete`)" &
                " VALUES ('" & serial & "',  '" & product & "','" & model & "', '" & accessory & "','" & qty & "', '" & price & "','" & supName & "', '" & acquiredDate & "', '" & warrantySupplierDate & "', " &
                "'" & warrantyClientDate & "', 'none', 'available', '0');"

            comm = New MySqlCommand(query, MysqlConn)
            reader = comm.ExecuteReader
            MsgBox("A new item is successfully added")
            reader.Close()

        Catch ex As Exception
            MsgBox("adding new item error : " & ex.Message)
        End Try

    End Sub

    'unsued function
    Private Function checkSupplier(ByVal SupplierName As String) As Integer
        Dim supplierID As Integer = 0

        Console.WriteLine(SupplierName)
        Try
            'Find the supplier id using the supplier name 
            query = "SELECT * FROM `supplier` WHERE `Sup_Name` LIKE '" & SupplierName & "' "
            comm = New MySqlCommand(query, MysqlConn)
            reader = comm.ExecuteReader

            'search through the table
            While reader.Read()
                supplierID = reader("SupplierID").ToString()
            End While

        Catch ex As Exception
            MsgBox("supplier invalid " & ex.Message)
        End Try

        'close the reader
        reader.Close()

        Return supplierID
    End Function

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        addnewItem()

        'reload table
        Search.displayData()

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
                SupplierTxtBox.Items.Add(suppliers)

            End While

        Catch ex As Exception
            MsgBox("supplier invalid " & ex.Message)
        End Try
        reader.Close()
    End Sub

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSupplierList()

        'remove border
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newSupplier.Show()

    End Sub

    'cancel button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

End Class