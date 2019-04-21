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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.enBtn = New System.Windows.Forms.Button()
        Me.dec = New System.Windows.Forms.Button()
        Me.filel = New System.Windows.Forms.TextBox()
        Me.opFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.test = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.RichTextBox()
        Me.seedBar = New System.Windows.Forms.TrackBar()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtText = New System.Windows.Forms.RichTextBox()
        Me.flipBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.filel2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.outBtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.errorlbl1 = New System.Windows.Forms.Label()
        CType(Me.seedBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enBtn
        '
        Me.enBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.enBtn.Location = New System.Drawing.Point(122, 500)
        Me.enBtn.Name = "enBtn"
        Me.enBtn.Size = New System.Drawing.Size(100, 42)
        Me.enBtn.TabIndex = 0
        Me.enBtn.Text = "Encrypt"
        Me.enBtn.UseVisualStyleBackColor = True
        '
        'dec
        '
        Me.dec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dec.Location = New System.Drawing.Point(334, 500)
        Me.dec.Name = "dec"
        Me.dec.Size = New System.Drawing.Size(100, 42)
        Me.dec.TabIndex = 1
        Me.dec.Text = "Decrypt "
        Me.dec.UseVisualStyleBackColor = True
        '
        'filel
        '
        Me.filel.Location = New System.Drawing.Point(529, 42)
        Me.filel.Name = "filel"
        Me.filel.Size = New System.Drawing.Size(261, 20)
        Me.filel.TabIndex = 2
        '
        'opFile
        '
        Me.opFile.Location = New System.Drawing.Point(815, 38)
        Me.opFile.Name = "opFile"
        Me.opFile.Size = New System.Drawing.Size(75, 23)
        Me.opFile.TabIndex = 3
        Me.opFile.Text = "Open File"
        Me.opFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(529, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input Location (optional)"
        '
        'test
        '
        Me.test.AutoSize = True
        Me.test.Location = New System.Drawing.Point(28, 414)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(0, 13)
        Me.test.TabIndex = 7
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(84, 303)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(425, 96)
        Me.txtResult.TabIndex = 8
        Me.txtResult.Text = ""
        '
        'seedBar
        '
        Me.seedBar.Location = New System.Drawing.Point(12, 127)
        Me.seedBar.Minimum = 1
        Me.seedBar.Name = "seedBar"
        Me.seedBar.Size = New System.Drawing.Size(658, 45)
        Me.seedBar.TabIndex = 6
        Me.seedBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.seedBar.Value = 1
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtKey.Location = New System.Drawing.Point(162, 65)
        Me.txtKey.MaxLength = 12
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(151, 26)
        Me.txtKey.TabIndex = 9
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(83, 201)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(425, 96)
        Me.txtText.TabIndex = 10
        Me.txtText.Text = ""
        '
        'flipBtn
        '
        Me.flipBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.flipBtn.Location = New System.Drawing.Point(228, 500)
        Me.flipBtn.Name = "flipBtn"
        Me.flipBtn.Size = New System.Drawing.Size(100, 42)
        Me.flipBtn.TabIndex = 11
        Me.flipBtn.Text = "Flip Text"
        Me.flipBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Input box"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Output box"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Number Keyphrase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Encryption Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(647, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "10"
        '
        'filel2
        '
        Me.filel2.Location = New System.Drawing.Point(529, 522)
        Me.filel2.Name = "filel2"
        Me.filel2.Size = New System.Drawing.Size(261, 20)
        Me.filel2.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(532, 500)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Output Location (optional)"
        '
        'outBtn
        '
        Me.outBtn.Location = New System.Drawing.Point(815, 522)
        Me.outBtn.Name = "outBtn"
        Me.outBtn.Size = New System.Drawing.Size(75, 23)
        Me.outBtn.TabIndex = 20
        Me.outBtn.Text = "Open File"
        Me.outBtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.exitbtn.Location = New System.Drawing.Point(228, 573)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(100, 42)
        Me.exitbtn.TabIndex = 21
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'errorlbl1
        '
        Me.errorlbl1.AutoSize = True
        Me.errorlbl1.ForeColor = System.Drawing.Color.Red
        Me.errorlbl1.Location = New System.Drawing.Point(334, 77)
        Me.errorlbl1.Name = "errorlbl1"
        Me.errorlbl1.Size = New System.Drawing.Size(199, 13)
        Me.errorlbl1.TabIndex = 22
        Me.errorlbl1.Text = "Error keyphrase to big setting to max size"
        Me.errorlbl1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(921, 730)
        Me.Controls.Add(Me.errorlbl1)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.outBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.filel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.flipBtn)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.seedBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.opFile)
        Me.Controls.Add(Me.filel)
        Me.Controls.Add(Me.dec)
        Me.Controls.Add(Me.enBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Encryption System"
        CType(Me.seedBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enBtn As Button
    Friend WithEvents dec As Button
    Friend WithEvents filel As TextBox
    Friend WithEvents opFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents test As Label
    Friend WithEvents txtResult As RichTextBox
    Friend WithEvents seedBar As TrackBar
    Friend WithEvents txtKey As TextBox
    Friend WithEvents txtText As RichTextBox
    Friend WithEvents flipBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents filel2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents outBtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents errorlbl1 As Label
End Class
