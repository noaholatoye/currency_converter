Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub

    Private Sub ComboBoxUsd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsd.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxGdp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGdp.SelectedIndexChanged

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Fixed exchange rate
        Const gbpRate = 0.76

        'Multiply user input with the current GBP rate
        MessageBox.Show("$" & txtInput.Text & " to British Pound (at the rate of $0.76) = £" & txtInput.Text * gbpRate)
        'The txtInput is the converted user input


    End Sub
End Class
