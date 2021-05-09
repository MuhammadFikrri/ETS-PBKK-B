Public Class Form1

    Private Function Cost_of_Item() As Double
        Dim sum As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            sum = sum + Convert.ToDouble(DataGridView1.Rows(i).Cells(2).Value)
        Next i
        Return sum
    End Function

    Sub AddCost()
        Dim tax, q As Double
        tax = 10.0

        If DataGridView1.Rows.Count > 0 Then
            lblTax.Text = FormatCurrency(((Cost_of_Item() * tax) / 100).ToString("0.00"))
            lblSubTotal.Text = FormatCurrency(Cost_of_Item().ToString("0.00"))
            q = ((Cost_of_Item() * tax) / 100)
            lblTotal.Text = FormatCurrency((Cost_of_Item() + q).ToString("0.00"))
        End If
    End Sub

    Sub Change()
        Dim tax, q, c As Double
        tax = 10.0

        If DataGridView1.Rows.Count > 0 Then
            q = ((Cost_of_Item() * tax) / 100) + Cost_of_Item()
            c = Val(lblCost.Text)

            lblChange.Text = FormatCurrency((c - q).ToString("0.00"))

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Expresso.Click
        Dim CostOfItem As Double = 10000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Expresso" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Expresso", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles CoffeeLatte.Click
        Dim CostOfItem As Double = 18000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Coffee Latte" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Coffee Latte", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles IcedMocha.Click
        Dim CostOfItem As Double = 20000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Iced Mocha" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Iced Mocha", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles MalikaIcedCoffee.Click
        Dim CostOfItem As Double = 23000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Malika Iced Coffee" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Malika Iced Coffee", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles IcedTea.Click
        Dim CostOfItem As Double = 10000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Iced Tea" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Iced Tea", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles IcedMilkTea.Click
        Dim CostOfItem As Double = 19000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Iced Milk Tea" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Iced Milk Tea", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles OreoMilkshake.Click
        Dim CostOfItem As Double = 27500.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Oreo Milkshake" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Oreo Milkshake", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles IceCream.Click
        Dim CostOfItem As Double = 24000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Ice Cream" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Ice Cream", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Tiramisu.Click
        Dim CostOfItem As Double = 15000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Tiramisu" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Tiramisu", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles CheeseCake.Click
        Dim CostOfItem As Double = 20000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Cheese Cake" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Cheese Cake", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles RedVelvet.Click
        Dim CostOfItem As Double = 27000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Red Velvet" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Red Velvet", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles BlackForest.Click
        Dim CostOfItem As Double = 21000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Black Forest" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Black Forest", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles RollCake.Click
        Dim CostOfItem As Double = 16500.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Roll Cake" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Roll Cake", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Macaron.Click
        Dim CostOfItem As Double = 20000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Macaron" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Macaron", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Pudding.Click
        Dim CostOfItem As Double = 25000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Pudding" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Pudding", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles AngelFruit.Click
        Dim CostOfItem As Double = 30000.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Angel Fruit" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * CostOfItem
                AddCost()
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Angel Fruit", "1", CostOfItem)
        AddCost()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        lblCost.Text = "0"
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
        cboPayment.Text = ""
        lblChange.Text = ""
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
    End Sub

    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles Panel3.Click, Btn9.Click, Btn8.Click, Btn7.Click, Btn6.Click, Btn5.Click, Btn4.Click, Btn3.Click, Btn2.Click, Btn1.Click, Btn0.Click, BtnDot.Click
        Dim b As Button = sender

        If (lblCost.Text = "0") Then
            lblCost.Text = ""
            lblCost.Text = b.Text

        ElseIf (b.Text = ",") Then
            If (Not lblCost.Text.Contains(",")) Then
                lblCost.Text = lblCost.Text + b.Text
            End If

        Else
            lblCost.Text = lblCost.Text + b.Text
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        lblCost.Text = "0"
        cboPayment.Text = ""
        lblChange.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPayment.Items.Add("Cash")
        cboPayment.Items.Add("Debit")
        cboPayment.Items.Add("Visa Card")
        cboPayment.Items.Add("Master Card")
    End Sub

    Private Sub Pay_Click(sender As Object, e As EventArgs) Handles Pay.Click
        If (cboPayment.Text = "Cash") Then
            Change()
        Else
            lblChange.Text = "0"
            lblCost.Text = "0"
        End If
    End Sub

    Private Sub RemoveItem_Click(sender As Object, e As EventArgs) Handles RemoveItem.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next

        AddCost()

        If (cboPayment.Text = "Cash") Then
            Change()
        Else
            lblChange.Text = ""
            lblCost.Text = "0"
        End If
    End Sub

    Private bitmap As Bitmap

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = (DataGridView1.RowCount + 1) * DataGridView1.RowTemplate.Height
        Bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

        DataGridView1.Height = height
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 10, 10)
    End Sub
End Class
