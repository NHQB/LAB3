<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtPrint1 = New System.Windows.Forms.TextBox()
        Me.txtPrint2 = New System.Windows.Forms.TextBox()
        Me.txtPrint3 = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.txtAverage1 = New System.Windows.Forms.TextBox()
        Me.txtAverage2 = New System.Windows.Forms.TextBox()
        Me.txtAverage3 = New System.Windows.Forms.TextBox()
        Me.txtOverallAverage = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(12, 18)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 17)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.ToolTip.SetToolTip(Me.lblDay, "Display the day of the data")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(12, 55)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(48, 17)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units: "
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(69, 52)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 22)
        Me.txtInput.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.txtInput, "Type in the amount of units had been shipped")
        '
        'txtPrint1
        '
        Me.txtPrint1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPrint1.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPrint1.Location = New System.Drawing.Point(29, 126)
        Me.txtPrint1.Multiline = True
        Me.txtPrint1.Name = "txtPrint1"
        Me.txtPrint1.ReadOnly = True
        Me.txtPrint1.Size = New System.Drawing.Size(140, 115)
        Me.txtPrint1.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.txtPrint1, "Display the units shipped by the employee")
        '
        'txtPrint2
        '
        Me.txtPrint2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPrint2.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPrint2.Location = New System.Drawing.Point(197, 126)
        Me.txtPrint2.Multiline = True
        Me.txtPrint2.Name = "txtPrint2"
        Me.txtPrint2.ReadOnly = True
        Me.txtPrint2.Size = New System.Drawing.Size(141, 115)
        Me.txtPrint2.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.txtPrint2, "Display the units shipped by the employee")
        '
        'txtPrint3
        '
        Me.txtPrint3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPrint3.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPrint3.Location = New System.Drawing.Point(364, 126)
        Me.txtPrint3.Multiline = True
        Me.txtPrint3.Name = "txtPrint3"
        Me.txtPrint3.ReadOnly = True
        Me.txtPrint3.Size = New System.Drawing.Size(139, 115)
        Me.txtPrint3.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.txtPrint3, "Display the units shipped by the employee")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(53, 106)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee1.TabIndex = 6
        Me.lblEmployee1.Text = "Employee 1"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(221, 106)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee2.TabIndex = 7
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(388, 106)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployee3.TabIndex = 8
        Me.lblEmployee3.Text = "Employee 3"
        '
        'txtAverage1
        '
        Me.txtAverage1.Cursor = System.Windows.Forms.Cursors.No
        Me.txtAverage1.Location = New System.Drawing.Point(29, 247)
        Me.txtAverage1.Name = "txtAverage1"
        Me.txtAverage1.ReadOnly = True
        Me.txtAverage1.Size = New System.Drawing.Size(140, 22)
        Me.txtAverage1.TabIndex = 9
        Me.txtAverage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.txtAverage1, "Display the average units shipped by the employee")
        '
        'txtAverage2
        '
        Me.txtAverage2.Cursor = System.Windows.Forms.Cursors.No
        Me.txtAverage2.Location = New System.Drawing.Point(197, 247)
        Me.txtAverage2.Name = "txtAverage2"
        Me.txtAverage2.ReadOnly = True
        Me.txtAverage2.Size = New System.Drawing.Size(141, 22)
        Me.txtAverage2.TabIndex = 10
        Me.txtAverage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.txtAverage2, "Display the average units shipped by the employee")
        '
        'txtAverage3
        '
        Me.txtAverage3.Cursor = System.Windows.Forms.Cursors.No
        Me.txtAverage3.Location = New System.Drawing.Point(364, 247)
        Me.txtAverage3.Name = "txtAverage3"
        Me.txtAverage3.ReadOnly = True
        Me.txtAverage3.Size = New System.Drawing.Size(139, 22)
        Me.txtAverage3.TabIndex = 11
        Me.txtAverage3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.txtAverage3, "Display the average units shipped by the employee")
        '
        'txtOverallAverage
        '
        Me.txtOverallAverage.Cursor = System.Windows.Forms.Cursors.No
        Me.txtOverallAverage.Location = New System.Drawing.Point(29, 287)
        Me.txtOverallAverage.Name = "txtOverallAverage"
        Me.txtOverallAverage.ReadOnly = True
        Me.txtOverallAverage.Size = New System.Drawing.Size(474, 22)
        Me.txtOverallAverage.TabIndex = 12
        Me.txtOverallAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.txtOverallAverage, "The overall average units shipped by the employees")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(56, 315)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 34)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip.SetToolTip(Me.btnEnter, "Input the value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(224, 315)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip.SetToolTip(Me.btnReset, "Reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(391, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 34)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.btnExit, "Exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(532, 363)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtOverallAverage)
        Me.Controls.Add(Me.txtAverage3)
        Me.Controls.Add(Me.txtAverage2)
        Me.Controls.Add(Me.txtAverage1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtPrint3)
        Me.Controls.Add(Me.txtPrint2)
        Me.Controls.Add(Me.txtPrint1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtPrint1 As TextBox
    Friend WithEvents txtPrint2 As TextBox
    Friend WithEvents txtPrint3 As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtAverage1 As TextBox
    Friend WithEvents txtAverage2 As TextBox
    Friend WithEvents txtAverage3 As TextBox
    Friend WithEvents txtOverallAverage As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip As ToolTip
End Class
