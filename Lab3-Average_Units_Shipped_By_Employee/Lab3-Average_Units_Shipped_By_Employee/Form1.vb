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

    Dim employeeArray(2) As TextBox 'Array that display the element of the txtPrint1, txtPrint2, and txtPrint3
    Dim dayArray(6) As Label 'Array that display the day from day 1 to day 7

#End Region

#Region "Functions and Subroutines"
    Function validateInput(ByVal userInput As String) As Double
        Dim isValidInput As Boolean = True
        Dim isNumeric As Double

        If Double.TryParse(userInput, isNumeric) Then
            isValidInput = True
        Else
            isValidInput = False
        End If
        Return CDbl(isValidInput)
    End Function

    Function averageCalculate(ByVal totalNumber As Double) As Double
        Return totalNumber / Max_Days
    End Function

    Sub SetDefault()
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
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

#End Region

End Class
