<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBackHome = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1542, 594)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnBackHome
        '
        Me.btnBackHome.BackColor = System.Drawing.Color.MediumPurple
        Me.btnBackHome.Font = New System.Drawing.Font("Ink Free", 19.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackHome.ForeColor = System.Drawing.Color.White
        Me.btnBackHome.Location = New System.Drawing.Point(525, 716)
        Me.btnBackHome.Name = "btnBackHome"
        Me.btnBackHome.Size = New System.Drawing.Size(600, 100)
        Me.btnBackHome.TabIndex = 65
        Me.btnBackHome.Text = "Back Home"
        Me.btnBackHome.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Font = New System.Drawing.Font("Ink Free", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(645, 28)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(389, 79)
        Me.lblInstructions.TabIndex = 64
        Me.lblInstructions.Text = "Instructions"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chatbot.My.Resources.Resources._285_2853543_wallpaper_food_65_wallpapers_cartoon_food_cute_food
        Me.ClientSize = New System.Drawing.Size(1624, 846)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBackHome)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBackHome As Button
    Friend WithEvents lblInstructions As Label
End Class
