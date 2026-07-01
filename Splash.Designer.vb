<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Myprogressbar = New ProgressBar()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(346, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 54)
        Label1.TabIndex = 0
        Label1.Text = "PharmaCenter"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 332)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(927, 67)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(356, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(240, 45)
        Label2.TabIndex = 1
        Label2.Text = "PoweredByANR"
        ' 
        ' Myprogressbar
        ' 
        Myprogressbar.Location = New Point(334, 160)
        Myprogressbar.Name = "Myprogressbar"
        Myprogressbar.Size = New Size(338, 48)
        Myprogressbar.TabIndex = 3
        ' 
        ' Timer1
        ' 
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrchid
        ClientSize = New Size(927, 399)
        Controls.Add(Myprogressbar)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Myprogressbar As ProgressBar
    Friend WithEvents Timer1 As Timer

End Class
