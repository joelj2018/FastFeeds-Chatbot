<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPlay1 = New System.Windows.Forms.TextBox()
        Me.btnQuit1 = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnStart1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(922, 418)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(483, 65)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Enter Player Name:"
        '
        'txtPlay1
        '
        Me.txtPlay1.BackColor = System.Drawing.Color.White
        Me.txtPlay1.Font = New System.Drawing.Font("Ink Free", 16.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlay1.Location = New System.Drawing.Point(865, 511)
        Me.txtPlay1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlay1.Name = "txtPlay1"
        Me.txtPlay1.Size = New System.Drawing.Size(600, 61)
        Me.txtPlay1.TabIndex = 14
        Me.txtPlay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnQuit1
        '
        Me.btnQuit1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnQuit1.Font = New System.Drawing.Font("Ink Free", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit1.ForeColor = System.Drawing.Color.White
        Me.btnQuit1.Location = New System.Drawing.Point(1400, 726)
        Me.btnQuit1.Name = "btnQuit1"
        Me.btnQuit1.Size = New System.Drawing.Size(200, 50)
        Me.btnQuit1.TabIndex = 13
        Me.btnQuit1.Text = "Quit Game"
        Me.btnQuit1.UseVisualStyleBackColor = False
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.BackColor = System.Drawing.Color.Transparent
        Me.lblChoose.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.ForeColor = System.Drawing.Color.White
        Me.lblChoose.Location = New System.Drawing.Point(184, 418)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(429, 65)
        Me.lblChoose.TabIndex = 12
        Me.lblChoose.Text = "Choose Category:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Food"})
        Me.ComboBox1.Location = New System.Drawing.Point(113, 515)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(600, 73)
        Me.ComboBox1.TabIndex = 11
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.MediumPurple
        Me.btnInstructions.Font = New System.Drawing.Font("Ink Free", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.Color.White
        Me.btnInstructions.Location = New System.Drawing.Point(965, 175)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(500, 100)
        Me.btnInstructions.TabIndex = 10
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnStart1
        '
        Me.btnStart1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnStart1.Font = New System.Drawing.Font("Ink Free", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart1.ForeColor = System.Drawing.Color.White
        Me.btnStart1.Location = New System.Drawing.Point(113, 175)
        Me.btnStart1.Name = "btnStart1"
        Me.btnStart1.Size = New System.Drawing.Size(500, 100)
        Me.btnStart1.TabIndex = 9
        Me.btnStart1.Text = "Lets Go!"
        Me.btnStart1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chatbot.My.Resources.Resources._285_2853543_wallpaper_food_65_wallpapers_cartoon_food_cute_food
        Me.ClientSize = New System.Drawing.Size(1624, 829)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPlay1)
        Me.Controls.Add(Me.btnQuit1)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnStart1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtPlay1 As TextBox
    Friend WithEvents btnQuit1 As Button
    Friend WithEvents lblChoose As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnStart1 As Button
End Class
