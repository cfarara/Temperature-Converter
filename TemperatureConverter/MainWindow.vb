''' <summary>
''' The MainWindow which displays the application.
''' </summary>
Public Class MainWindow

  Private p_sUserInput As String = String.Empty
  Private p_inputConverter As InputConverter = New InputConverter

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Environment.Exit(0)
  End Sub

  Private Sub Reset()
    Me.txtFrom.Text = String.Empty
    Me.txtTo.Text = String.Empty
    Me.cboFromScale.SelectedIndex = -1
    Me.cboToScale.SelectedIndex = -1
    Me.txtFrom.Focus()
  End Sub

  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    Me.Reset()
  End Sub

  Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
    Me.p_sUserInput = Me.txtFrom.Text
    Dim dNumInput As Double
    Try
      dNumInput = CDbl(Me.p_sUserInput)
    Catch ex As Exception
      Me.Reset()
      Return
    End Try
   If String.IsNullOrWhiteSpace(p_sUserInput) Then
      Me.Reset()
    ElseIf (Me.cboFromScale.SelectedIndex < 0) Or (Me.cboToScale.SelectedIndex < 0) Then
      MessageBox.Show("Please select temperature units to convert from and to.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      If Me.cboFromScale.SelectedIndex < 0 Then
        Me.cboFromScale.Focus()
        Me.cboFromScale.DroppedDown = True
      ElseIf Me.cboToScale.SelectedIndex < 0 Then
        Me.cboToScale.Focus()
        Me.cboToScale.DroppedDown = True

      End If
    Else
      Me.txtTo.Text = Math.Round(CDbl(Me.p_inputConverter.ConvertUserInput(dNumInput, Me.cboFromScale.SelectedIndex, Me.cboToScale.SelectedIndex).ToString()), 2).ToString()
    End If

  End Sub

  Private Sub txtFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrom.KeyPress
    Dim textBox As TextBox = CType(sender, TextBox)

    If (e.KeyChar = "-"c _
      AndAlso ((textBox.SelectionStart <> 0) OrElse textBox.Text.Contains("-"c))) Then

      e.Handled = True
    End If

    If (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) _
      AndAlso (e.KeyChar <> "-"c) AndAlso (e.KeyChar = CChar(CStr(Keys.Back)))) Then
      e.Handled = True
    End If

    If (e.KeyChar = "."c) AndAlso textBox.Text.IndexOf("."c) > -1 Then
      e.Handled = True
    End If

    If (e.KeyChar = "-"c) AndAlso textBox.Text.IndexOf("<"c) > -1 Then

      e.Handled = True
    End If

    If (Char.IsLetter(e.KeyChar)) Then
      e.Handled = True
    End If
  End Sub

  Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean

  Private Sub txtTo_GotFocus(sender As Object, e As EventArgs) Handles txtTo.GotFocus
    HideCaret(txtTo.Handle)
  End Sub

End Class
