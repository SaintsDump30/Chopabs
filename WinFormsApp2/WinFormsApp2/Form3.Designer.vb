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
        Panel1 = New Panel()
        Button1 = New Button()
        ListBox1 = New ListBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(391, 474)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(245, 382)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 34)
        Button1.TabIndex = 2
        Button1.Text = "Finish"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"Workstation", "Mainframe Computer", "SuperComputer", "Computer Animation", "Mini Computer", "Personal Computer", "Servers", "Laptop"})
        ListBox1.Location = New Point(72, 194)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(245, 64)
        ListBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(83, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 18)
        Label1.TabIndex = 0
        Label1.Text = "Frequently used computer"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(415, 502)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
End Class
