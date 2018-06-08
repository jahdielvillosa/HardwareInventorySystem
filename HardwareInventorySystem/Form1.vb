Public Class Form1
    Dim user As String = "admin"
    Dim pass As String = "user"

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        InventoryMenu.Show()
        Me.Hide()
        If (user = TextBox1.Text And pass = TextBox2.Text) Then

        Else
            '  MessageBox.Show("Invalid user and password. Please Try again.", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'play sound on click
        playClickBtn()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim input As String = MessageBox.Show("Do you want to exit? ", "Exit confirmation", MessageBoxButtons.YesNo)

        If input = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect() 'connect to mysql database

        'hide border frame
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginBtn.PerformClick()
        End If
    End Sub

End Class
