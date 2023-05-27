<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HeadPositionInput = New System.Windows.Forms.NumericUpDown()
        Me.InputTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CalculateSSTFButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.HeadPositionInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HeadPositionInput, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.InputTextBox, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CalculateSSTFButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.OutputTextBox, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(427, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'HeadPositionInput
        '
        Me.HeadPositionInput.AutoSize = True
        Me.HeadPositionInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeadPositionInput.Location = New System.Drawing.Point(8, 21)
        Me.HeadPositionInput.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.HeadPositionInput.Name = "HeadPositionInput"
        Me.HeadPositionInput.Size = New System.Drawing.Size(411, 20)
        Me.HeadPositionInput.TabIndex = 1
        Me.HeadPositionInput.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'InputTextBox
        '
        Me.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputTextBox.Location = New System.Drawing.Point(8, 60)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(411, 167)
        Me.InputTextBox.TabIndex = 3
        Me.InputTextBox.Text = "43,52,24,65,70,48,16,61"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Request: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Head Position:"
        '
        'CalculateSSTFButton
        '
        Me.CalculateSSTFButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalculateSSTFButton.Location = New System.Drawing.Point(8, 233)
        Me.CalculateSSTFButton.Name = "CalculateSSTFButton"
        Me.CalculateSSTFButton.Size = New System.Drawing.Size(411, 23)
        Me.CalculateSSTFButton.TabIndex = 4
        Me.CalculateSSTFButton.Text = "Calculate SSTF"
        Me.CalculateSSTFButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Output:"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputTextBox.Location = New System.Drawing.Point(8, 275)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(411, 167)
        Me.OutputTextBox.TabIndex = 6
        Me.OutputTextBox.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "SSTF Calculator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.HeadPositionInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents HeadPositionInput As NumericUpDown
    Friend WithEvents InputTextBox As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CalculateSSTFButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents OutputTextBox As RichTextBox
End Class
