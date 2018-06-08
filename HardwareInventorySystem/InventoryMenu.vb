Public Class InventoryMenu

    Private Sub InventoryPanelBtn_Click(sender As Object, e As EventArgs) Handles InventoryPanelBtn.Click, PictureBox6.Click, searchLabel.Click
        Search.Show()
        Me.Close()
        'play sound on click
        playClickBtn()
    End Sub

    Private Sub ReportPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles ReportPanel.MouseClick, PictureBox1.Click, reportLabel.Click
        Report.Show()
        Me.Close()
        'play sound on click
        playClickBtn()
    End Sub

    Private Sub returnPanelBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles returnPanelBtn.MouseClick, PictureBox2.MouseClick, returnLabel.Click
        ReturnDamage.Show()
        Me.Close()
        'play sound on click
        playClickBtn()
    End Sub

    Private Sub InventoryPanelBtn_MouseHover(sender As Object, e As EventArgs) Handles InventoryPanelBtn.MouseHover, PictureBox6.MouseHover, searchLabel.Click
        InfoTxtLabel.Text = "Perform actions such as Adding items, Editing items, Deleting items, Printing results and"
        LInfoTxtLabel2.Text = "searching items by Serial Number,Date Purchased, Date Acquired etc. "
    End Sub

    Private Sub InventoryPanelBtn_MouseLeave(sender As Object, e As EventArgs) Handles InventoryPanelBtn.MouseLeave, PictureBox6.MouseLeave
        InfoTxtLabel.Text = " "
        LInfoTxtLabel2.Text = " "
    End Sub


    Private Sub returnPanelBtn_MouseEnter(sender As Object, e As EventArgs) Handles returnPanelBtn.MouseEnter, PictureBox2.MouseEnter, returnLabel.Click

        InfoTxtLabel.Text = "Perform a return action of a defective item purchased in the store."
        LInfoTxtLabel2.Text = ""

    End Sub

    Private Sub returnPanelBtn_MouseLeave(sender As Object, e As EventArgs) Handles returnPanelBtn.MouseLeave, PictureBox2.MouseLeave
        InfoTxtLabel.Text = " "
        LInfoTxtLabel2.Text = " "
    End Sub


    Private Sub ReportPanel_MouseHover(sender As Object, e As EventArgs) Handles ReportPanel.MouseHover, PictureBox1.MouseHover, reportLabel.Click

        InfoTxtLabel.Text = "Generates inventory report or sales based on the selected date and can be printed. "
        LInfoTxtLabel2.Text = ""

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        InfoTxtLabel.Text = " "
        LInfoTxtLabel2.Text = " "
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Sales.Show()
        Me.Close()
        'play sound on click
        playClickBtn()
    End Sub

End Class