<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkOrchid
        Label1.Location = New Point(136, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 54)
        Label1.TabIndex = 1
        Label1.Text = "Login"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(73, 124)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(257, 31)
        TextBox1.TabIndex = 2
        TextBox1.Text = "UserName"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(73, 181)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(257, 31)
        TextBox2.TabIndex = 3
        TextBox2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOrchid
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(51, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(291, 64)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkOrchid
        Label2.Location = New Point(162, 332)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 30)
        Label2.TabIndex = 5
        Label2.Text = "Clear"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(389, 404)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
