Public Class Form1


    Public totalAmount As Decimal = 0










    Public Function ComputeTotal(quantity As Integer, price As Integer) As Decimal
        Dim total As Decimal = quantity * price
        totalAmount += total
        totalAmountOfItem.Text = totalAmount.ToString("0.00") ' Update the total amount label
        Return total
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        snacksPanel.BringToFront()
        GunaDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown
        teaPanel.Location = New Point(137, 154)

        GunaDataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(GunaDataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)





    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Dim itemName As String = "Americano"
        Dim price As Integer = 50

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub UpdateTotalAmount()
        totalAmount = 0

        ' Calculate the total amount from the DataGridView
        For Each row As DataGridViewRow In GunaDataGridView1.Rows
            If row.Cells.Count >= 3 AndAlso Not String.IsNullOrEmpty(row.Cells(2).Value?.ToString()) Then
                totalAmount += CDec(row.Cells(2).Value)
            End If
        Next

        ' Initialize the add-ons prices



        totalAmountOfItem.Text = totalAmount.ToString()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        Dim itemName As String = "Expresso"
        Dim price As Integer = 60

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        GunaDataGridView1.Rows.Clear()
        totalAmountOfItem.Text = "0.00"
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Dim itemName As String = "Cappucino"
        Dim price As Integer = 65

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        Dim itemName As String = "Latte"
        Dim price As Integer = 65

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Dim itemName As String = "Mocha"
        Dim price As Integer = 75

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        Dim itemName As String = "Macchiato"
        Dim price As Integer = 70

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Guna2PictureBox20_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox20.Click
        Dim itemName As String = "Choco Cake"
        Dim price As Integer = 50

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Guna2PictureBox17_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox17.Click
        Dim itemName As String = "Croissant"
        Dim price As Integer = 60

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Guna2PictureBox19_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox19.Click
        Dim itemName As String = "Muffin"
        Dim price As Integer = 100

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Guna2PictureBox18_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox18.Click
        Dim itemName As String = "Toasted"
        Dim price As Integer = 60

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Guna2PictureBox16_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox16.Click
        Dim itemName As String = "Fries"
        Dim price As Integer = 50

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Guna2PictureBox15_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox15.Click
        Dim itemName As String = "Honey Tea"
        Dim price As Integer = 50

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2PictureBox12_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox12.Click
        Dim itemName As String = "Green Tea"
        Dim price As Integer = 80

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2PictureBox14_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox14.Click
        Dim itemName As String = "Black Tea"
        Dim price As Integer = 50

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub Guna2PictureBox11_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox11.Click
        Dim itemName As String = "Matcha"
        Dim price As Integer = 60

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()

            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Guna2PictureBox10_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox10.Click
        Dim itemName As String = "Vanilla"
        Dim price As Integer = 75

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row

                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If

        End If
    End Sub

    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox7.Click
        Dim itemName As String = "C & C"
        Dim price As Integer = 60

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Guna2PictureBox13_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox13.Click
        Dim itemName As String = "Jasmine Tea"
        Dim price As Integer = 75

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2PictureBox8_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox8.Click
        Dim itemName As String = "Hazelnut"
        Dim price As Integer = 65

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox9.Click
        Dim itemName As String = "Caramel"
        Dim price As Integer = 85

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub





    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Category.Text = "Hot Drinks"
        hotDrinksPanel.Show()
        icedCoffeePanel.Hide()
        teaPanel.Hide()
        snacksPanel.Hide()
        addOnsPanel.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Category.Text = "Iced Coffee"
        icedCoffeePanel.Show()
        hotDrinksPanel.Hide()
        teaPanel.Hide()
        snacksPanel.Hide()
        addOnsPanel.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Category.Text = "Tea"
        teaPanel.Show()
        icedCoffeePanel.Hide()
        hotDrinksPanel.Hide()
        snacksPanel.Hide()
        addOnsPanel.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        Category.Text = "Snacks"
        snacksPanel.Show()
        hotDrinksPanel.Hide()
        teaPanel.Hide()
        icedCoffeePanel.Hide()
        addOnsPanel.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        addOnsPanel.Show()
        Category.Text = "Add Ons"
        snacksPanel.Hide()
        hotDrinksPanel.Hide()
        teaPanel.Hide()
        icedCoffeePanel.Hide()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim itemName As String = "Vanilla"
        Dim price As Integer = 25

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim itemName As String = "Caramel"
        Dim price As Integer = 25

        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim itemName As String = "Caramel"
        Dim price As Integer = 25


        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim itemName As String = "Espresso"
        Dim price As Integer = 50



        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim itemName As String = "Oat"
        Dim price As Integer = 25



        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim itemName As String = "Almond"
        Dim price As Integer = 25



        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim itemName As String = "Soy"
        Dim price As Integer = 25



        If GunaDataGridView1.Columns.Count >= 3 Then
            Dim existingRow As DataGridViewRow = GunaDataGridView1.Rows.Cast(Of DataGridViewRow).
                                                 FirstOrDefault(Function(r) r.Cells(0).Value?.ToString() = itemName)

            If existingRow Is Nothing Then
                ' Item not found, add a new row
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(GunaDataGridView1)
                newRow.Cells(0).Value = itemName
                newRow.Cells(1).Value = 1
                Dim total As Decimal = ComputeTotal(1, price)
                newRow.Cells(2).Value = total.ToString("0.00")
                GunaDataGridView1.Rows.Add(newRow)
                UpdateTotalAmount()
            Else
                ' Item found, update the existing row
                Dim currentQuantity As Integer = If(existingRow.Cells(1).Value Is Nothing, 1, CInt(existingRow.Cells(1).Value) + 1)
                existingRow.Cells(1).Value = currentQuantity
                Dim total As Decimal = ComputeTotal(currentQuantity, price)
                existingRow.Cells(2).Value = total.ToString("0.00")
                UpdateTotalAmount()
            End If
        Else
            MessageBox.Show("The DataGridView doesn't have enough columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click


        Dim result As DialogResult = MessageBox.Show("Proceed to payment?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If totalAmountOfItem.Text = "0.00" Then
                MessageBox.Show("Please make a purchase first before doing this.", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Paymentform.amount.Text = totalAmountOfItem.Text
                Me.Hide()
                Paymentform.Show()
            End If
        ElseIf result = DialogResult.No Then
            Me.Show()
        End If

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to logout?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Paymentform.Close()
            login.Close()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class