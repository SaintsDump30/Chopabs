<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        Label2 = New Label()
        Label3 = New Label()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(CheckBox5)
        Panel1.Controls.Add(CheckBox4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(517, 624)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(124, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 23)
        Label1.TabIndex = 0
        Label1.Text = "Types of Computer Viruses"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Verdana", 12F, FontStyle.Italic)
        CheckBox1.Location = New Point(124, 218)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(123, 22)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Boot Sector"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Verdana", 12F, FontStyle.Italic)
        CheckBox2.Location = New Point(124, 260)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(142, 22)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "Trojan Horses"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Verdana", 12F, FontStyle.Italic)
        CheckBox3.Location = New Point(124, 302)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(140, 22)
        CheckBox3.TabIndex = 3
        CheckBox3.Text = "Web Scripting"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(320, 23)
        Label2.TabIndex = 4
        Label2.Text = "Test II. Identify types of Viruses"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(305, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 1
        Label3.Text = "Label3"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Verdana", 12F, FontStyle.Italic)
        CheckBox4.Location = New Point(124, 349)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(105, 22)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "Resident "
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Verdana", 12F, FontStyle.Italic)
        CheckBox5.Location = New Point(124, 393)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(158, 22)
        CheckBox5.TabIndex = 6
        CheckBox5.Text = "Computer Worm"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(353, 503)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 39)
        Button1.TabIndex = 7
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(539, 644)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label3 As Label
End Class
