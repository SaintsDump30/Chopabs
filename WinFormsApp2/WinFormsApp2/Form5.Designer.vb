<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(342, 400)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 3
        Label1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(46, 279)
        Button2.Name = "Button2"
        Button2.Size = New Size(254, 23)
        Button2.TabIndex = 2
        Button2.Text = "Done"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(46, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(254, 23)
        Button1.TabIndex = 1
        Button1.Text = "Show Grade"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(366, 424)
        Controls.Add(Panel1)
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
