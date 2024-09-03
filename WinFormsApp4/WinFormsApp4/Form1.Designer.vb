<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        TextBox6 = New TextBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(63, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(643, 101)
        Panel1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(118, 56)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 2
        Label2.Text = "Course :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(118, 13)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(184, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Student Name: "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(35, 162)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(671, 299)
        Panel2.TabIndex = 1
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(253, 205)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(184, 23)
        TextBox6.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(176, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 21)
        Label6.TabIndex = 8
        Label6.Text = "Final :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(253, 148)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(184, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(155, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 6
        Label3.Text = "Mid Term : "
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(253, 78)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(184, 23)
        TextBox4.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(176, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 21)
        Label4.TabIndex = 4
        Label4.Text = "Prelim : "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(35, 497)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 38)
        Button1.TabIndex = 2
        Button1.Text = "New Entry"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(288, 497)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 38)
        Button2.TabIndex = 3
        Button2.Text = "Compute"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(553, 497)
        Button3.Name = "Button3"
        Button3.Size = New Size(153, 38)
        Button3.TabIndex = 4
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(749, 563)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
