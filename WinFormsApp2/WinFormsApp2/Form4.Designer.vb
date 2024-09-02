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
        Panel1 = New Panel()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 491)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(68, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 18)
        Label1.TabIndex = 3
        Label1.Text = "Frequent usable Computer"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Supercomputers", "Mainframe computers", "Minicomputers", "Tablet and Smartphone"})
        ComboBox1.Location = New Point(68, 173)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(225, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(230, 358)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 30)
        Button1.TabIndex = 5
        Button1.Text = "Finish"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 527)
        Controls.Add(Panel1)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
