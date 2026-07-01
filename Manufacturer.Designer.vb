<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manufacturer
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
        CompIdTb = New TextBox()
        Label3 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label5 = New Label()
        ManufacturerGV = New DataGridView()
        CompanyId = New DataGridViewTextBoxColumn()
        CompanyName = New DataGridViewTextBoxColumn()
        PhoneNumber = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        CompNameTb = New TextBox()
        CompPhTb = New TextBox()
        CompAddTb = New TextBox()
        Button5 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ManufacturerGV, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(1375, 150)
        Panel1.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(1325, 0)
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
        Label2.Location = New Point(564, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 48)
        Label2.TabIndex = 2
        Label2.Text = "Manufacturer"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(499, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 74)
        Label1.TabIndex = 1
        Label1.Text = "PharmaCenter"
        ' 
        ' CompIdTb
        ' 
        CompIdTb.Location = New Point(50, 268)
        CompIdTb.Name = "CompIdTb"
        CompIdTb.Size = New Size(257, 31)
        CompIdTb.TabIndex = 8
        CompIdTb.Text = "CompanyId"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DeepPink
        Label3.Location = New Point(714, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(296, 48)
        Label3.TabIndex = 13
        Label3.Text = "Manufacturer List"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkOrchid
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(51, 535)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 53)
        Button4.TabIndex = 17
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
        Button3.Location = New Point(703, 535)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 53)
        Button3.TabIndex = 16
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
        Button2.Location = New Point(511, 535)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 53)
        Button2.TabIndex = 15
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
        Button1.Location = New Point(196, 535)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 53)
        Button1.TabIndex = 14
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrchid
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 672)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1375, 25)
        Panel2.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(627, -7)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 32)
        Label5.TabIndex = 3
        Label5.Text = "PoweredByAsh"
        ' 
        ' ManufacturerGV
        ' 
        ManufacturerGV.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkOrchid
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.DarkOrchid
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ManufacturerGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ManufacturerGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ManufacturerGV.Columns.AddRange(New DataGridViewColumn() {CompanyId, CompanyName, PhoneNumber, Address})
        ManufacturerGV.Location = New Point(440, 230)
        ManufacturerGV.Name = "ManufacturerGV"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkOrchid
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkOrchid
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        ManufacturerGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        ManufacturerGV.RowHeadersWidth = 62
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ManufacturerGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        ManufacturerGV.Size = New Size(864, 281)
        ManufacturerGV.TabIndex = 12
        ' 
        ' CompanyId
        ' 
        CompanyId.HeaderText = "CompanyId"
        CompanyId.MinimumWidth = 8
        CompanyId.Name = "CompanyId"
        CompanyId.Width = 150
        ' 
        ' CompanyName
        ' 
        CompanyName.HeaderText = "CompanyName"
        CompanyName.MinimumWidth = 8
        CompanyName.Name = "CompanyName"
        CompanyName.Width = 150
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.HeaderText = "PhoneNumber"
        PhoneNumber.MinimumWidth = 8
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Width = 150
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.MinimumWidth = 8
        Address.Name = "Address"
        Address.Width = 350
        ' 
        ' CompNameTb
        ' 
        CompNameTb.Location = New Point(50, 327)
        CompNameTb.Name = "CompNameTb"
        CompNameTb.Size = New Size(257, 31)
        CompNameTb.TabIndex = 19
        CompNameTb.Text = "CompanyName"
        ' 
        ' CompPhTb
        ' 
        CompPhTb.Location = New Point(50, 387)
        CompPhTb.Name = "CompPhTb"
        CompPhTb.Size = New Size(257, 31)
        CompPhTb.TabIndex = 20
        CompPhTb.Text = "PhoneNumber"
        ' 
        ' CompAddTb
        ' 
        CompAddTb.Location = New Point(50, 444)
        CompAddTb.Name = "CompAddTb"
        CompAddTb.Size = New Size(257, 31)
        CompAddTb.TabIndex = 21
        CompAddTb.Text = "CompanyAddress"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkOrchid
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(348, 535)
        Button5.Name = "Button5"
        Button5.Size = New Size(96, 53)
        Button5.TabIndex = 22
        Button5.Text = "Clear"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Manufacturer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1375, 697)
        Controls.Add(Button5)
        Controls.Add(CompAddTb)
        Controls.Add(CompPhTb)
        Controls.Add(CompNameTb)
        Controls.Add(Panel2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(ManufacturerGV)
        Controls.Add(Panel1)
        Controls.Add(CompIdTb)
        Name = "Manufacturer"
        Text = "Manufacturer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ManufacturerGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CompIdTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ManufacturerGV As DataGridView
    Friend WithEvents CompNameTb As TextBox
    Friend WithEvents CompPhTb As TextBox
    Friend WithEvents CompAddTb As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents CompanyId As DataGridViewTextBoxColumn
    Friend WithEvents CompanyName As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
End Class
