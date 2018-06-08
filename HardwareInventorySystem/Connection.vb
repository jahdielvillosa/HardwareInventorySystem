
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Module Connection

    'SQL connection variables
    Public MysqlConn As MySqlConnection
    Public comm As MySqlCommand
    Public reader As MySqlDataReader
    Public query As String

    'user status and privelages
    Public user As String = "admin"
    Public sharedSerialNumber As String = ""


    Public Sub connect()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=12345;database=hardwaresystem"
        Try
            MysqlConn.Open()
            '    MsgBox("Connection is OK!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub playClickBtn()
        My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "\simple_resonant_click.wav")
    End Sub

    'Shared serial variable which holds the serial number to be 
    'shared or accessed between frames
    Public Sub setSharedSerial(ByVal serial As String)
        sharedSerialNumber = serial
    End Sub

    Public Function getSharedSerial() As String
        Return sharedSerialNumber
    End Function

End Module
