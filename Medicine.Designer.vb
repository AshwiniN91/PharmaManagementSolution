<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        MedicineTb = New TextBox()
        BpriceTb = New TextBox()
        SpriceTb = New TextBox()
        QtTb = New TextBox()
        CompCb = New ComboBox()
        MedicineGV = New DataGridView()
        MedName = New DataGridViewTextBoxColumn()
        Bprice = New DataGridViewTextBoxColumn()
        Sprice = New DataGridViewTextBoxColumn()
        MedQty = New DataGridViewTextBoxColumn()
        Exp_Date = New DataGridViewTextBoxColumn()
        Company = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel2 = New Panel()
        Label5 = New Label()
        ExpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Button5 = New Button()
        Button6 = New Button()
        Panel1.SuspendLayout()
        CType(MedicineGV, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(1572, 150)
        Panel1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(1525, 0)
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
        Label2.Location = New Point(752, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 48)
        Label2.TabIndex = 2
        Label2.Text = "Medicine"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(637, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 74)
        Label1.TabIndex = 1
        Label1.Text = "PharmaCenter"
        ' 
        ' MedicineTb
        ' 
        MedicineTb.Location = New Point(50, 221)
        MedicineTb.Name = "MedicineTb"
        MedicineTb.Size = New Size(257, 31)
        MedicineTb.TabIndex = 3
        MedicineTb.Text = "MedicineName"
        ' 
        ' BpriceTb
        ' 
        BpriceTb.Location = New Point(50, 284)
        BpriceTb.Name = "BpriceTb"
        BpriceTb.Size = New Size(257, 31)
        BpriceTb.TabIndex = 4
        BpriceTb.Text = "BuyingPrice"
        ' 
        ' SpriceTb
        ' 
        SpriceTb.Location = New Point(50, 344)
        SpriceTb.Name = "SpriceTb"
        SpriceTb.Size = New Size(257, 31)
        SpriceTb.TabIndex = 5
        SpriceTb.Text = "SellingPrice"
        ' 
        ' QtTb
        ' 
        QtTb.Location = New Point(50, 403)
        QtTb.Name = "QtTb"
        QtTb.Size = New Size(257, 31)
        QtTb.TabIndex = 6
        QtTb.Text = "Quantity"
        ' 
        ' CompCb
        ' 
        CompCb.FormattingEnabled = True
        CompCb.Location = New Point(50, 527)
        CompCb.Name = "CompCb"
        CompCb.Size = New Size(257, 33)
        CompCb.TabIndex = 7
        ' 
        ' MedicineGV
        ' 
        MedicineGV.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkOrchid
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.DarkOrchid
        DataGridViewCellStyle1.SelectionBackColor = Color.DarkOrchid
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        MedicineGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        MedicineGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MedicineGV.Columns.AddRange(New DataGridViewColumn() {MedName, Bprice, Sprice, MedQty, Exp_Date, Company})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.DeepPink
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        MedicineGV.DefaultCellStyle = DataGridViewCellStyle2
        MedicineGV.Location = New Point(412, 241)
        MedicineGV.Name = "MedicineGV"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkOrchid
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        MedicineGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        MedicineGV.RowHeadersWidth = 62
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        MedicineGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        MedicineGV.Size = New Size(1114, 319)
        MedicineGV.TabIndex = 8
        ' 
        ' MedName
        ' 
        MedName.HeaderText = "MedName"
        MedName.MinimumWidth = 8
        MedName.Name = "MedName"
        MedName.Width = 200
        ' 
        ' Bprice
        ' 
        Bprice.HeaderText = "Bprice"
        Bprice.MinimumWidth = 8
        Bprice.Name = "Bprice"
        Bprice.Width = 150
        ' 
        ' Sprice
        ' 
        Sprice.HeaderText = "Sprice"
        Sprice.MinimumWidth = 8
        Sprice.Name = "Sprice"
        Sprice.Width = 150
        ' 
        ' MedQty
        ' 
        MedQty.HeaderText = "MedQty"
        MedQty.MinimumWidth = 8
        MedQty.Name = "MedQty"
        MedQty.Width = 150
        ' 
        ' Exp_Date
        ' 
        Exp_Date.HeaderText = "Exp_Date"
        Exp_Date.MinimumWidth = 8
        Exp_Date.Name = "Exp_Date"
        Exp_Date.Width = 150
        ' 
        ' Company
        ' 
        Company.HeaderText = "Company"
        Company.MinimumWidth = 8
        Company.Name = "Company"
        Company.Width = 250
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DeepPink
        Label3.Location = New Point(829, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 48)
        Label3.TabIndex = 9
        Label3.Text = "Medicine List"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOrchid
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(283, 590)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 53)
        Button1.TabIndex = 10
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrchid
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(829, 590)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 53)
        Button2.TabIndex = 11
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkOrchid
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1103, 590)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 53)
        Button3.TabIndex = 12
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkOrchid
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(50, 590)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 53)
        Button4.TabIndex = 13
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrchid
        Panel2.Controls.Add(Label5)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 728)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1572, 25)
        Panel2.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(752, -7)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 32)
        Label5.TabIndex = 3
        Label5.Text = "PoweredByAsh"
        ' 
        ' ExpDate
        ' 
        ExpDate.Checked = True
        ExpDate.CustomizableEdges = CustomizableEdges1
        ExpDate.FillColor = Color.DarkOrchid
        ExpDate.Font = New Font("Segoe UI", 9F)
        ExpDate.ForeColor = Color.WhiteSmoke
        ExpDate.Format = DateTimePickerFormat.Long
        ExpDate.Location = New Point(50, 455)
        ExpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        ExpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        ExpDate.Name = "ExpDate"
        ExpDate.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ExpDate.Size = New Size(257, 54)
        ExpDate.TabIndex = 15
        ExpDate.Value = New Date(2026, 6, 5, 13, 45, 16, 603)
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkOrchid
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(1382, 590)
        Button5.Name = "Button5"
        Button5.Size = New Size(144, 53)
        Button5.TabIndex = 16
        Button5.Text = "Print"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DarkOrchid
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(545, 590)
        Button6.Name = "Button6"
        Button6.Size = New Size(105, 53)
        Button6.TabIndex = 17
        Button6.Text = "Clear"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Medicine
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1572, 753)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ExpDate)
        Controls.Add(Panel2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(MedicineGV)
        Controls.Add(CompCb)
        Controls.Add(QtTb)
        Controls.Add(SpriceTb)
        Controls.Add(BpriceTb)
        Controls.Add(MedicineTb)
        Controls.Add(Panel1)
        ForeColor = Color.DeepPink
        FormBorderStyle = FormBorderStyle.None
        Name = "Medicine"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PoweredByAsh"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(MedicineGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MedicineTb As TextBox
    Friend WithEvents BpriceTb As TextBox
    Friend WithEvents SpriceTb As TextBox
    Friend WithEvents QtTb As TextBox
    Friend WithEvents CompCb As ComboBox
    Friend WithEvents MedicineGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ExpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents MedName As DataGridViewTextBoxColumn
    Friend WithEvents Bprice As DataGridViewTextBoxColumn
    Friend WithEvents Sprice As DataGridViewTextBoxColumn
    Friend WithEvents MedQty As DataGridViewTextBoxColumn
    Friend WithEvents Exp_Date As DataGridViewTextBoxColumn
    Friend WithEvents Company As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
