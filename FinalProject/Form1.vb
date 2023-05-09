Public Class Form1

    'Constants are the value of one USD to ARS/AUD/SVE
    Const _decARG As Decimal = 227.64
    Const _decAUS As Decimal = 1.47
    Const _decSVE As Decimal = 10.17

    'Textbox string input and what it will be converted to
    Dim strInp As String = ""
    Dim decInp As Decimal = 0D




    'Checks textbox input; also ensures something is in the textbox for btnConv to be enabled
    Private Sub tbxInput_TextChanged(sender As Object, e As EventArgs) Handles tbxInput.TextChanged
        btnClear.Enabled = True
        If (tbxInput.TextLength > 0) Then
            btnConv.Enabled = True
        End If
    End Sub




    'Conversion Subs
    Private Sub ComputeARG()
        Dim decResult As Decimal = 0D
        decResult = (decInp * _decARG)

        lblResult.Text = decInp.ToString("N2") + " USD" & vbCrLf & "is equal to" & vbCrLf & decResult.ToString("N2") + " ARS"
        lblResult.Visible = True

    End Sub

    Private Sub ComputeAUS()
        Dim decResult As Decimal = 0D
        decResult = (decInp * _decAUS)

        lblResult.Text = decInp.ToString("N2") + " USD" & vbCrLf & "is equal to" & vbCrLf & decResult.ToString("N2") + " AUD"
        lblResult.Visible = True

    End Sub

    Private Sub ComputeSVE()
        Dim decResult As Decimal = 0D
        decResult = (decInp * _decSVE)

        lblResult.Text = decInp.ToString("N2") + " USD" & vbCrLf & "is equal to" & vbCrLf & decResult.ToString("N2") + " SEK"
        lblResult.Visible = True

    End Sub




    'Validation function from the Karaoke project for Try/Catch and input validation
    Private Function ValidateInput() As Boolean
        Dim blnValid As Boolean = False

        Try
            decInp = Convert.ToDecimal(tbxInput.Text)

            If decInp > 0D Then
                blnValid = True
                Return blnValid
            End If

        Catch Exception As FormatException
            MsgBox("Please enter a valid amount.", , "Real Numbers, Please!")
        Catch Exception As SystemException
            MsgBox("Sorry, that doesn't seem right. Please enter a valid value.", , "Unknown Error")
        End Try
        tbxInput.Focus()
        tbxInput.Clear()

        Return blnValid
    End Function




    'City images change based on which country is selected; Argentina is Buenos Aires, Australia is Brisbane, and Sweden is Stockholm
    Private Sub rdiARG_CheckedChanged(sender As Object, e As EventArgs) Handles rdiARG.CheckedChanged
        picCity.Image = My.Resources.buenosaires
        btnClear.Enabled = True
    End Sub

    Private Sub rdiAUD_CheckedChanged(sender As Object, e As EventArgs) Handles rdiAUD.CheckedChanged
        picCity.Image = My.Resources.brisbane
        btnClear.Enabled = True
    End Sub

    Private Sub rdiSEK_CheckedChanged(sender As Object, e As EventArgs) Handles rdiSEK.CheckedChanged
        picCity.Image = My.Resources.stockholm
        btnClear.Enabled = True
    End Sub




    'Upon form loading, performs a click on btnClear to clear everything and make a "default" appearance.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdiARG.PerformClick()
        tbxInput.Text = ""
        btnClear.Enabled = False
        lblResult.Visible = False
        btnConv.Enabled = False
    End Sub




    'Upon button click, tries the input validation function; if it passes,
    'whichever currency is converted to is based on which button is pressed.
    'Otherwise, clears the form.
    Private Sub btnConv_Click(sender As Object, e As EventArgs) Handles btnConv.Click
        Dim boolPossible As Boolean
        boolPossible = ValidateInput()

        If (boolPossible) Then
            decInp = Convert.ToDecimal(tbxInput.Text)

            If (rdiARG.Checked) Then
                ComputeARG()

            ElseIf (rdiAUD.Checked) Then
                ComputeAUS()
            Else
                ComputeSVE()

            End If


        Else
            btnClear.PerformClick()
        End If

    End Sub
End Class
