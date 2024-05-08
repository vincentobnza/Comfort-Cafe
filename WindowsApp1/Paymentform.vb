Imports System.Drawing.Printing

Public Class Paymentform


    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click




        If Val(moneyPayment.Text) < Val(amount.Text) Then
            MessageBox.Show("Insufficient Amount of Money", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            moneyPayment.Text = ""
        Else
            MessageBox.Show("Payment successful", "Yeyyyy!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Thank you for ordering in Comfort Cafe!", "Yeyyyy!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim moneyBalance = Val(moneyPayment.Text) - Val(amount.Text)
            balance.Text = moneyBalance & ".00"
            moneyPayment.Text = ""
            amount.Text = "0.00"
            Form1.totalAmountOfItem.Text = "0.00"
            Form1.GunaDataGridView1.Rows.Clear()
        End If






    End Sub





End Class