<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paymentform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paymentform))
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.moneyPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.amount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.balance = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(480, 154)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(243, 45)
        Me.Label49.TabIndex = 2
        Me.Label49.Text = "Order Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(389, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Optimizing Financial Transactions: Total Payment Calculation"
        '
        'moneyPayment
        '
        Me.moneyPayment.BorderColor = System.Drawing.Color.LightGray
        Me.moneyPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.moneyPayment.DefaultText = ""
        Me.moneyPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.moneyPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.moneyPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.moneyPayment.DisabledState.Parent = Me.moneyPayment
        Me.moneyPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.moneyPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.moneyPayment.FocusedState.Parent = Me.moneyPayment
        Me.moneyPayment.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneyPayment.ForeColor = System.Drawing.Color.DimGray
        Me.moneyPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.moneyPayment.HoverState.Parent = Me.moneyPayment
        Me.moneyPayment.Location = New System.Drawing.Point(427, 308)
        Me.moneyPayment.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.moneyPayment.Name = "moneyPayment"
        Me.moneyPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.moneyPayment.PlaceholderForeColor = System.Drawing.Color.White
        Me.moneyPayment.PlaceholderText = "Enter your payment here"
        Me.moneyPayment.SelectedText = ""
        Me.moneyPayment.ShadowDecoration.Parent = Me.moneyPayment
        Me.moneyPayment.Size = New System.Drawing.Size(339, 65)
        Me.moneyPayment.TabIndex = 4
        Me.moneyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.moneyPayment.TextOffset = New System.Drawing.Point(10, 0)
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.amount.Location = New System.Drawing.Point(479, 66)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(243, 55)
        Me.amount.TabIndex = 5
        Me.amount.Text = "0.00"
        Me.amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Balance:"
        '
        'balance
        '
        Me.balance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balance.ForeColor = System.Drawing.Color.Black
        Me.balance.Location = New System.Drawing.Point(141, 30)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(184, 26)
        Me.balance.TabIndex = 7
        Me.balance.Text = "0.00"
        Me.balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(427, 385)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(339, 67)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "Calculate"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.balance)
        Me.Guna2Panel1.Location = New System.Drawing.Point(427, 469)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(339, 83)
        Me.Guna2Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(425, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Enter your money here"
        '
        'PictureBox11
        '
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = Global.WindowsApp1.My.Resources.Resources.arrow
        Me.PictureBox11.Location = New System.Drawing.Point(20, 18)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 10
        Me.PictureBox11.TabStop = False
        '
        'Paymentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 701)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.moneyPayment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label49)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Paymentform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comfort Cafe"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label49 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents moneyPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents amount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents balance As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label2 As Label
End Class
