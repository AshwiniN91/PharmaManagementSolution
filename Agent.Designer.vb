<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agent
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PwdTb = New TextBox()
        Label3 = New Label()
        AgentGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        Label5 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        EmpSalTb = New TextBox()
        EmpIdTb = New TextBox()
        EmpNameTb = New TextBox()
        EmpAgeTb = New TextBox()
        PhTb = New TextBox()
        Button6 = New Button()
        Panel1.SuspendLayout()
        CType(AgentGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrchid
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1270, 150)
        Panel1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(1227, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 54)
        Label4.TabIndex = 3
        Label4.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(567, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 48)
        Label2.TabIndex = 2
        Label2.Text = "Agent"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(450, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 74)
        Label1.TabIndex = 1
        Label1.Text = "PharmaCenter"
        ' 
        ' PwdTb
        ' 
        PwdTb.Location = New Point(75, 484)
        PwdTb.Name = "PwdTb"
        PwdTb.Size = New Size(257, 31)
        PwdTb.TabIndex = 17
        PwdTb.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DeepPink
        Label3.Location = New Point(829, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 48)
        Label3.TabIndex = 19
        Label3.Text = "Agent List"
        ' 
        ' AgentGV
        ' 
        AgentGV.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        AgentGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        AgentGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AgentGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column4, Column3, Column5, Column6})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        AgentGV.DefaultCellStyle = DataGridViewCellStyle2
        AgentGV.GridColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AgentGV.Location = New Point(451, 161)
        AgentGV.Name = "AgentGV"
        AgentGV.RowHeadersWidth = 62
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        AgentGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        AgentGV.Size = New Size(965, 370)
        AgentGV.TabIndex = 18
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "EmpId"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "EmpName"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "EmpSal"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "EmpAge"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Phone"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Password"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrchid
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 690)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1448, 25)
        Panel2.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(647, -7)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 32)
        Label5.TabIndex = 3
        Label5.Text = "PoweredByAsh"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkOrchid
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(75, 577)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 53)
        Button4.TabIndex = 24
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkOrchid
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1176, 577)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 53)
        Button3.TabIndex = 23
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrchid
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(891, 577)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 53)
        Button2.TabIndex = 22
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOrchid
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(341, 577)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 53)
        Button1.TabIndex = 21
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EmpSalTb
        ' 
        EmpSalTb.Location = New Point(75, 303)
        EmpSalTb.Name = "EmpSalTb"
        EmpSalTb.Size = New Size(257, 31)
        EmpSalTb.TabIndex = 28
        EmpSalTb.Text = "EmployeeSalary"
        ' 
        ' EmpIdTb
        ' 
        EmpIdTb.Location = New Point(75, 180)
        EmpIdTb.Name = "EmpIdTb"
        EmpIdTb.Size = New Size(257, 31)
        EmpIdTb.TabIndex = 29
        EmpIdTb.Text = "EmployeeId"
        ' 
        ' EmpNameTb
        ' 
        EmpNameTb.Location = New Point(75, 237)
        EmpNameTb.Name = "EmpNameTb"
        EmpNameTb.Size = New Size(257, 31)
        EmpNameTb.TabIndex = 30
        EmpNameTb.Text = "EmployeeName"
        ' 
        ' EmpAgeTb
        ' 
        EmpAgeTb.Location = New Point(75, 363)
        EmpAgeTb.Name = "EmpAgeTb"
        EmpAgeTb.Size = New Size(257, 31)
        EmpAgeTb.TabIndex = 31
        EmpAgeTb.Text = "EmployeeAge"
        ' 
        ' PhTb
        ' 
        PhTb.Location = New Point(75, 420)
        PhTb.Name = "PhTb"
        PhTb.Size = New Size(257, 31)
        PhTb.TabIndex = 32
        PhTb.Text = "Phone"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DarkOrchid
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(620, 577)
        Button6.Name = "Button6"
        Button6.Size = New Size(105, 53)
        Button6.TabIndex = 33
        Button6.Text = "Clear"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Agent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1448, 715)
        Controls.Add(Button6)
        Controls.Add(PhTb)
        Controls.Add(EmpAgeTb)
        Controls.Add(EmpNameTb)
        Controls.Add(EmpIdTb)
        Controls.Add(EmpSalTb)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        Controls.Add(AgentGV)
        Controls.Add(PwdTb)
        FormBorderStyle = FormBorderStyle.None
        Name = "Agent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agent"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(AgentGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents EmpId As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents EmpIdTb As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PwdTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AgentGV As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents EmpAgeTb As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents EmpSalTb As TextBox
    Friend WithEvents EmpNameTb As TextBox
    Friend WithEvents PhTb As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
