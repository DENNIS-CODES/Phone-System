Public Class Form2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim plancost, minscost, textcost, datacost, subtotal, VAT, Total As Decimal


        lblCustomerName.Text = strName
        lblAddress.Text = strAddress
        lblPostCode.Text = strPostcode
        lblMobileNo.Text = strmobileNo
        lblPlanType.Text = strPlantype

        lblMinsUsed.Text = ushMinsused
        lbltextsSent.Text = ushTextsSent
        lblDataUsed.Text = ushDataUsed

        plancost = calc_PlanCost(strPlantype)
        minscost = calc_minscost(ushMinsused)
        textcost = calc_Textscost(ushTextsSent)
        datacost = calc_Datacost(ushDataUsed)

        subtotal = plancost + minscost + textcost + datacost
        VAT = 0.2 * subtotal
        Total = subtotal + VAT

        lblPlanCost.Text = FormatCurrency(plancost, 2)
        lblMinsCost.Text = FormatCurrency(minscost, 2)
        lblTextsCost.Text = FormatCurrency(textcost, 2)
        lblDataCost.Text = FormatCurrency(datacost, 2)
        lblSubTotal.Text = FormatCurrency(subtotal, 2)
        lblVAT.Text = FormatCurrency(VAT, 2)
        lblTotal.Text = FormatCurrency(Total, 2)
        lblDate.Text = Now




    End Sub
End Class