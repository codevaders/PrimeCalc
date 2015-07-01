Public Class formMain
    Dim varMode As Integer

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioSpec.Checked = True    'default mode (Specific Mode)
        inputSpec.Text = "1"    'default value of specific mode
        inputStart.Text = "1"   'default start value (range mode)
        inputEnd.Text = "100"   'default end value (range mode)
        outputStatus.Text = "Press Calculate"
    End Sub

    Private Sub radioSpec_CheckedChanged(sender As Object, e As EventArgs) Handles radioSpec.CheckedChanged
        inputSpec.Enabled = True
        chkDivisor.Enabled = True
        inputStart.Enabled = False
        inputEnd.Enabled = False
        inputSpec.Focus()
        varMode = 1     'specific mode is varMode 1
    End Sub

    Private Sub radioRange_CheckedChanged(sender As Object, e As EventArgs) Handles radioRange.CheckedChanged
        inputSpec.Enabled = False
        chkDivisor.Enabled = False
        inputStart.Enabled = True
        inputEnd.Enabled = True
        inputStart.Focus()
        varMode = 2     'range mode is varMode 2
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Select Case varMode
            Case Is = 1     'specific mode
                If inputSpec.Text >= 1 Then
                    outputStatus.Text = "Calculating..."
                    outputResult.AppendText(vbCrLf & "Input: " & inputSpec.Text & vbCrLf)
                    If chkDivisor.Checked = True Then
                        outputResult.AppendText("Divisors: " & vbCrLf)
                        Prime(Val(inputSpec.Text), True)
                    End If
                    outputResult.AppendText("Prime: " & Prime(Val(inputSpec.Text), False) & vbCrLf)
                    outputStatus.Text = "OK"
                Else
                    outputStatus.Text = "Input Error"
                End If
            Case Is = 2     'range mode
                If inputStart.Text >= 1 And inputEnd.Text >= inputStart.Text Then
                    outputStatus.Text = "Calculating..."
                    outputResult.AppendText(vbCrLf & "Start: " & inputStart.Text & vbCrLf & "Stop: " & inputEnd.Text & vbCrLf)
                    Dim cnt As Integer
                    For i = Val(inputStart.Text) To Val(inputEnd.Text) Step 1
                        If Prime(i, False) = True Then
                            outputResult.AppendText(i & vbCrLf)
                            cnt += 1
                        End If
                    Next
                    outputResult.AppendText("Total: " & cnt & vbCrLf)
                    outputStatus.Text = "OK"
                Else
                    outputStatus.Text = "Input Error"
                End If
        End Select
    End Sub

    'PRIME NUMBER CALCULATOR
    'num = input number (int)
    'cnt = counter (when num is prime number, cnt is 2) (int)
    'div = "Show divisor" checkbox (bool)
    'prm = return value (bool)
    Function Prime(num As Integer, div As Boolean) As Boolean
        Dim prm As Boolean
        Dim cnt As Integer
        For i = 1 To num Step 1
            If num Mod i = 0 Then
                If div = True Then  'if "Show divisor" checkbox is checked
                    outputResult.AppendText(i & vbCrLf)     'then print the divisors
                End If
                cnt += 1
            End If
        Next
        If cnt = 2 Then
            prm = True  'num is prime number
        Else
            prm = False 'num is not prime number
        End If
        Return prm
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        outputResult.Text = ""
        outputStatus.Text = "OK"
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If Not outputResult.SelectedText = "" Then
            Clipboard.SetText(outputResult.SelectedText)
        End If
    End Sub

    Private Sub btnCopyAll_Click(sender As Object, e As EventArgs) Handles btnCopyAll.Click
        If Not outputResult.Text = "" Then
            Clipboard.SetText(outputResult.Text)
        End If
    End Sub
End Class
