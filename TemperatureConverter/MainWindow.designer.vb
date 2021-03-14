<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.cboFromScale = New System.Windows.Forms.ComboBox()
        Me.cboToScale = New System.Windows.Forms.ComboBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboFromScale
        '
        Me.cboFromScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFromScale.FormattingEnabled = True
        Me.cboFromScale.Items.AddRange(New Object() {"FAHRENHEIT", "CELSIUS", "KELVIN"})
        Me.cboFromScale.Location = New System.Drawing.Point(251, 30)
        Me.cboFromScale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboFromScale.Name = "cboFromScale"
        Me.cboFromScale.Size = New System.Drawing.Size(160, 24)
        Me.cboFromScale.TabIndex = 2
        '
        'cboToScale
        '
        Me.cboToScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToScale.FormattingEnabled = True
        Me.cboToScale.Items.AddRange(New Object() {"FAHRENHEIT", "CELSIUS", "KELVIN"})
        Me.cboToScale.Location = New System.Drawing.Point(251, 75)
        Me.cboToScale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboToScale.Name = "cboToScale"
        Me.cboToScale.Size = New System.Drawing.Size(160, 24)
        Me.cboToScale.TabIndex = 4
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(96, 31)
        Me.txtFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFrom.MaxLength = 10
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(132, 22)
        Me.txtFrom.TabIndex = 1
        '
        'txtTo
        '
        Me.txtTo.CausesValidation = False
        Me.txtTo.Location = New System.Drawing.Point(96, 76)
        Me.txtTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(132, 22)
        Me.txtTo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To:"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(40, 127)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(124, 28)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 127)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 28)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(172, 127)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 28)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(463, 170)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cboToScale)
        Me.Controls.Add(Me.cboFromScale)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFromScale As ComboBox
    Friend WithEvents cboToScale As ComboBox
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
End Class
