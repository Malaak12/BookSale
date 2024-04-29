<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Discount = New Label()
        DiscountedTextBox = New Label()
        QuantityTextBox = New TextBox()
        TitleTextBox = New TextBox()
        PriceTextBox = New TextBox()
        ExtendedPriceTextBox = New TextBox()
        DiscountTextBox = New TextBox()
        DiscountedPriceTextBox = New TextBox()
        CalculateButton = New Button()
        ClearButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(257, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 65)
        Label1.TabIndex = 0
        Label1.Text = "Book Sales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(111, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 32)
        Label2.TabIndex = 1
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(111, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 32)
        Label3.TabIndex = 2
        Label3.Text = "Title"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(111, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 32)
        Label4.TabIndex = 3
        Label4.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(396, 358)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 32)
        Label5.TabIndex = 4
        Label5.Text = "Extended Price"
        ' 
        ' Discount
        ' 
        Discount.AutoSize = True
        Discount.Location = New Point(396, 427)
        Discount.Name = "Discount"
        Discount.Size = New Size(161, 32)
        Discount.TabIndex = 5
        Discount.Text = "15% Discount"
        ' 
        ' DiscountedTextBox
        ' 
        DiscountedTextBox.AutoSize = True
        DiscountedTextBox.Location = New Point(396, 499)
        DiscountedTextBox.Name = "DiscountedTextBox"
        DiscountedTextBox.Size = New Size(193, 32)
        DiscountedTextBox.TabIndex = 6
        DiscountedTextBox.Text = "Discounted Price"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(294, 112)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(154, 39)
        QuantityTextBox.TabIndex = 7
        ' 
        ' TitleTextBox
        ' 
        TitleTextBox.Location = New Point(294, 176)
        TitleTextBox.Name = "TitleTextBox"
        TitleTextBox.Size = New Size(473, 39)
        TitleTextBox.TabIndex = 8
        ' 
        ' PriceTextBox
        ' 
        PriceTextBox.Location = New Point(294, 239)
        PriceTextBox.Name = "PriceTextBox"
        PriceTextBox.Size = New Size(154, 39)
        PriceTextBox.TabIndex = 9
        ' 
        ' ExtendedPriceTextBox
        ' 
        ExtendedPriceTextBox.Location = New Point(593, 358)
        ExtendedPriceTextBox.Name = "ExtendedPriceTextBox"
        ExtendedPriceTextBox.ReadOnly = True
        ExtendedPriceTextBox.Size = New Size(200, 39)
        ExtendedPriceTextBox.TabIndex = 10
        ' 
        ' DiscountTextBox
        ' 
        DiscountTextBox.Location = New Point(593, 427)
        DiscountTextBox.Name = "DiscountTextBox"
        DiscountTextBox.ReadOnly = True
        DiscountTextBox.Size = New Size(200, 39)
        DiscountTextBox.TabIndex = 11
        ' 
        ' DiscountedPriceTextBox
        ' 
        DiscountedPriceTextBox.Location = New Point(593, 499)
        DiscountedPriceTextBox.Name = "DiscountedPriceTextBox"
        DiscountedPriceTextBox.ReadOnly = True
        DiscountedPriceTextBox.Size = New Size(200, 39)
        DiscountedPriceTextBox.TabIndex = 12
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(298, 597)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(150, 46)
        CalculateButton.TabIndex = 13
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(476, 597)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(150, 46)
        ClearButton.TabIndex = 14
        ClearButton.Text = "Clear Sale"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(654, 597)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(150, 46)
        ExitButton.TabIndex = 15
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 687)
        Controls.Add(ExitButton)
        Controls.Add(ClearButton)
        Controls.Add(CalculateButton)
        Controls.Add(DiscountedPriceTextBox)
        Controls.Add(DiscountTextBox)
        Controls.Add(ExtendedPriceTextBox)
        Controls.Add(PriceTextBox)
        Controls.Add(TitleTextBox)
        Controls.Add(QuantityTextBox)
        Controls.Add(DiscountedTextBox)
        Controls.Add(Discount)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "R 'n R for Reading 'n Refreshment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ExtendedPriceTextBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DiscountedPriceTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Discount As Label
    Friend WithEvents DiscountedTextBox As Label
    Friend WithEvents DiscountTextBox As TextBox

End Class
