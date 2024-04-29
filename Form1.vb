Public Class Form1

    Private Function DISCOUNT_RATE_Decimal() As Decimal
        Return 0.15D
    End Function

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Calculate the price and discount.
        Dim QuantityInteger As Integer
        Dim PriceDecimal, ExtendedPriceDecimal, DiscountDecimal, DiscountedPriceDecimal As Decimal

        ' Convert input values to numeric variables.
        QuantityInteger = Integer.Parse(QuantityTextBox.Text)
        PriceDecimal = Decimal.Parse(PriceTextBox.Text)

        ' Calculate values.
        ExtendedPriceDecimal = QuantityInteger * PriceDecimal
        DiscountDecimal = Decimal.Round((ExtendedPriceDecimal * DISCOUNT_RATE_Decimal()), 2)
        DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal

        ' Format and display answers.
        ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("C")
        DiscountTextBox.Text = DiscountDecimal.ToString("C")
        DiscountedPriceTextBox.Text = DiscountedPriceDecimal.ToString("C")
    End Sub

    Private Sub ClearButton_Click(sender As Object,
                                  e As EventArgs) Handles ClearButton.Click
        ' Clear previous amounts from the form.
        TitleTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        DiscountTextBox.Clear()
        DiscountedPriceTextBox.Clear()
        QuantityTextBox.Clear()
        QuantityTextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Exit the project.
        Me.Close()
    End Sub

    Private Sub DiscountedTextBox_Click(sender As Object, e As EventArgs) Handles DiscountedTextBox.Click

    End Sub

    Private Sub Discount_Click(sender As Object, e As EventArgs) Handles Discount.Click

    End Sub
End Class

