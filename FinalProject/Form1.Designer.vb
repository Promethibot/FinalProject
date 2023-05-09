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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdiSEK = New System.Windows.Forms.RadioButton()
        Me.rdiAUD = New System.Windows.Forms.RadioButton()
        Me.rdiARG = New System.Windows.Forms.RadioButton()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picCity = New System.Windows.Forms.PictureBox()
        Me.btnConv = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.picCity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency Converter"
        '
        'rdiSEK
        '
        Me.rdiSEK.AutoSize = True
        Me.rdiSEK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiSEK.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiSEK.Location = New System.Drawing.Point(410, 240)
        Me.rdiSEK.Name = "rdiSEK"
        Me.rdiSEK.Size = New System.Drawing.Size(185, 23)
        Me.rdiSEK.TabIndex = 2
        Me.rdiSEK.TabStop = True
        Me.rdiSEK.Text = "Swedish Kronor (SEK)"
        Me.rdiSEK.UseVisualStyleBackColor = True
        '
        'rdiAUD
        '
        Me.rdiAUD.AutoSize = True
        Me.rdiAUD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiAUD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiAUD.Location = New System.Drawing.Point(410, 211)
        Me.rdiAUD.Name = "rdiAUD"
        Me.rdiAUD.Size = New System.Drawing.Size(202, 23)
        Me.rdiAUD.TabIndex = 3
        Me.rdiAUD.TabStop = True
        Me.rdiAUD.Text = "Australian Dollar (AUD)"
        Me.rdiAUD.UseVisualStyleBackColor = True
        '
        'rdiARG
        '
        Me.rdiARG.AutoSize = True
        Me.rdiARG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiARG.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiARG.Location = New System.Drawing.Point(410, 182)
        Me.rdiARG.Name = "rdiARG"
        Me.rdiARG.Size = New System.Drawing.Size(202, 23)
        Me.rdiARG.TabIndex = 4
        Me.rdiARG.TabStop = True
        Me.rdiARG.Text = "Argentinian Peso (ARS)"
        Me.rdiARG.UseVisualStyleBackColor = True
        '
        'tbxInput
        '
        Me.tbxInput.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInput.Location = New System.Drawing.Point(545, 94)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(100, 27)
        Me.tbxInput.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Amount in USD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(406, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Convert to..."
        '
        'picCity
        '
        Me.picCity.Location = New System.Drawing.Point(-7, -10)
        Me.picCity.Name = "picCity"
        Me.picCity.Size = New System.Drawing.Size(356, 478)
        Me.picCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCity.TabIndex = 1
        Me.picCity.TabStop = False
        '
        'btnConv
        '
        Me.btnConv.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnConv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConv.Enabled = False
        Me.btnConv.FlatAppearance.BorderSize = 0
        Me.btnConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConv.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConv.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnConv.Location = New System.Drawing.Point(410, 298)
        Me.btnConv.Name = "btnConv"
        Me.btnConv.Size = New System.Drawing.Size(108, 34)
        Me.btnConv.TabIndex = 8
        Me.btnConv.Text = "Convert"
        Me.btnConv.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(580, 298)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 34)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(468, 346)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(160, 75)
        Me.lblResult.TabIndex = 10
        Me.lblResult.Text = "$12345.00 USD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is equal to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12345.00 ARG"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResult.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(734, 451)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.rdiARG)
        Me.Controls.Add(Me.rdiAUD)
        Me.Controls.Add(Me.rdiSEK)
        Me.Controls.Add(Me.picCity)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Converter"
        CType(Me.picCity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdiSEK As RadioButton
    Friend WithEvents rdiAUD As RadioButton
    Friend WithEvents rdiARG As RadioButton
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents picCity As PictureBox
    Friend WithEvents btnConv As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblResult As Label
End Class
