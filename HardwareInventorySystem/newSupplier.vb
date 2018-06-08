Imports MySql.Data.MySqlClient

Public Class newSupplier

    Private Sub newSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        'check if all fields are filled out
        Dim new_supplier As String = supplierTextBox.Text
        Dim new_email As String = emailTextBox.Text
        Dim new_contact As String = ContactTextBox.Text
        Dim new_address As String = addressTextBox.Text

        If checkfields() = True Then
            'add new supplier
            'INSERT INTO `hardwaresystem`.`supplier` (`Sup_Name`, `Sup_Email`, `Sup_ContactNum`, `Sup_Address`) VALUES ('globe', 'globe@gmail.com', 'none', 'none');
            query = "INSERT INTO `hardwaresystem`.`supplier`" &
                " (`Sup_Name`, `Sup_Email`, `Sup_ContactNum`, `Sup_Address`) " &
                "VALUES ('" & new_supplier & "', '" & new_email & "', '" & new_contact & "', '" & new_address & "'); "          'sql string command
            comm = New MySqlCommand(query, MysqlConn)   'ready command to connection
            reader = comm.ExecuteReader                 'execute sql query 
            reader.Close()

            MsgBox("Adding new supplier is successful")
        Else
            MsgBox("Please fill out all the necessary information given.")
        End If

    End Sub

    'check each text fields if it is empty
    Private Function checkfields() As Boolean
        Dim OKFlag As Boolean = True

        If supplierTextBox.Text = "" Then
            OKFlag = False
        End If
        If addressTextBox.Text = "" Then
            OKFlag = False
        End If
        If ContactTextBox.Text = "" Then
            OKFlag = False
        End If
        If emailTextBox.Text = "" Then
            OKFlag = False
        End If

        Return OKFlag

    End Function
End Class