<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblQuestions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.MediumPurple
        Me.btnHome.Font = New System.Drawing.Font("Segoe Print", 13.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(1299, 925)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(319, 71)
        Me.btnHome.TabIndex = 70
        Me.btnHome.Text = "Back to Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblQuestions
        '
        Me.lblQuestions.AutoSize = True
        Me.lblQuestions.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lblQuestions.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestions.ForeColor = System.Drawing.Color.White
        Me.lblQuestions.Location = New System.Drawing.Point(247, 143)
        Me.lblQuestions.Name = "lblQuestions"
        Me.lblQuestions.Size = New System.Drawing.Size(963, 720)
        Me.lblQuestions.TabIndex = 71
        Me.lblQuestions.Text = resources.GetString("lblQuestions.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1279, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(912, 720)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 25.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(973, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(538, 118)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Question Bank"
        '
        'btnBot
        '
        Me.btnBot.BackColor = System.Drawing.Color.MediumPurple
        Me.btnBot.Font = New System.Drawing.Font("Segoe Print", 13.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBot.ForeColor = System.Drawing.Color.White
        Me.btnBot.Location = New System.Drawing.Point(871, 925)
        Me.btnBot.Name = "btnBot"
        Me.btnBot.Size = New System.Drawing.Size(319, 71)
        Me.btnBot.TabIndex = 74
        Me.btnBot.Text = "Chatbot"
        Me.btnBot.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chatbot.My.Resources.Resources._285_2853543_wallpaper_food_65_wallpapers_cartoon_food_cute_food
        Me.ClientSize = New System.Drawing.Size(2477, 1028)
        Me.Controls.Add(Me.btnBot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblQuestions)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents lblQuestions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBot As Button
End Class
