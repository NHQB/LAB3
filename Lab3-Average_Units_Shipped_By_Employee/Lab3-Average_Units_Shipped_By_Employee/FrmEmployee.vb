Option Strict On

Public Class FrmEmployee
#Region "Constants and Variables"
    'Constants 
    Private Const Max_Value As Integer = 5000
    Private Const Min_Value As Integer = 1
    Private Const Max_Days As Integer = 7

    'Variables 

    'Declare for element in an arrays 
    Dim employeeNumber As Integer = 0
    Dim currentDay As Integer = 0

    'Decalre for total and average that an employee made in 7 days 
    Dim employeeTotal As Double
    Dim employeeAverage As Double

    'Declare for the overall total and average that the 3 employees made in 7 days 
    Dim total As Double
    Dim average As Double

    'A 2 dimensional array used for employeeArray and dayArray
    Dim averageUnitsShippedArray(2, 6) As Double

    Dim inputPrintArray() As TextBox 'Array refering to txtPrint1, txtPrint2, and txtPrint3
    Dim employeeAverageArray() As TextBox 'Array refering to the average of the 3 employees made in 7 days 

#End Region

#Region "Functions and Subroutines"
    Function validateInput(ByVal input As String) As Boolean
        Dim isValidInput As Boolean = True
        Dim numericInput As Double

        If Double.TryParse(input, averageUnitsShippedArray(employeeNumber, currentDay)) Then
            numericInput = CDbl(input)
            If numericInput >= Min_Value And numericInput <= Max_Value Then
                isValidInput = True
            Else
                isValidInput = False
                MessageBox.Show("Please enter a valid number between " + Min_Value.ToString + " and " + Max_Value.ToString + " !!!")
            End If
        Else
            isValidInput = False
            MessageBox.Show("Input must be numeric !!!")
        End If
        Return isValidInput
    End Function

    Sub SetDefault()
        employeeNumber = 0
        currentDay = 0

        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)

        lblDay.Text = "Day 1"
        btnEnter.Enabled = True

        txtInput.Text = ""
        txtInput.Enabled = True

        txtPrint1.Text = ""
        txtPrint2.Text = ""
        txtPrint3.Text = ""

        txtAverage1.Text = ""
        txtAverage2.Text = ""
        txtAverage3.Text = ""

        txtOverallAverage.Text = ""
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub FrmEmployee(Sender As Object, e As EventArgs) Handles MyBase.Load
        inputPrintArray = {txtPrint1, txtPrint2, txtPrint3}
        employeeAverageArray = {txtAverage1, txtAverage2, txtAverage3}
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As String = txtInput.Text

        If validateInput(userInput) Then
            'Entry is valid
            inputPrintArray(employeeNumber).Text &= averageUnitsShippedArray(employeeNumber, currentDay) & vbCrLf

            'Entry is valid, increment the day 
            currentDay += 1
            lblDay.Text = "Day " & (currentDay + 1)

            'Clear the input textbox for the user to type in a new record 
            txtInput.Clear()

            'If we reached Day 7, calculate for the average
            If currentDay = Max_Days Then
                'Reset the weekly total 
                employeeTotal = 0

                'Accumlate a weekly total 
                For dayCount As Integer = 0 To 6
                    employeeTotal += averageUnitsShippedArray(employeeNumber, dayCount)
                Next

                'Determine and ouput the employee average 
                employeeAverage = employeeTotal / Max_Days
                employeeAverageArray(employeeNumber).Text = "Average: " & Math.Round(employeeAverage, 2)

                'Increment the employeeNumber
                employeeNumber += 1
                If employeeNumber = 1 Then
                    'Set Employee 2 font style to bold and set the Employee 1 font style to normal 
                    lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                    lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Bold)
                ElseIf employeeNumber = 2 Then
                    'Set Employee 3 font style to bold
                    lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
                    lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold)
                End If

                ' Reset the day to 0 
                currentDay = 0
                lblDay.Text = "Day " & (currentDay + 1)

                'If the form has reached to Employee 3, calculate the overall average
                If employeeNumber = 3 Then
                    'Accumulate a overall total for the 3 employees
                    For Each currentDay In averageUnitsShippedArray
                        total += currentDay
                    Next

                    'Determine and ouput the overall average 
                    average = total / averageUnitsShippedArray.Length
                    txtOverallAverage.Text = "Average: " & Math.Round(average, 2)

                    'Disable the input-related control 
                    txtInput.Enabled = False
                    btnEnter.Enabled = False
                    btnReset.Focus()

                    lblDay.Text = "Done"
                End If
            End If
        Else
            txtInput.SelectAll()
            txtInput.Focus()
            'Reset the form if the input was wrong
            SetDefault()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefault()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


#End Region

End Class
