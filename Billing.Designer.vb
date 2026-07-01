<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Panel1 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        BillGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        MediComboCb = New ComboBox()
        InStocklbl = New Label()
        Button = New Button()
        Button2 = New Button()
        Button3 = New Button()
        QtyTb = New TextBox()
        TotalAmntlbl = New Label()
        Label5 = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        CType(BillGV, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(1278, 150)
        Panel1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(1221, 9)
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
        Label2.Location = New Point(582, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 48)
        Label2.TabIndex = 2
        Label2.Text = "Billing"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(466, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 74)
        Label1.TabIndex = 1
        Label1.Text = "PharmaCenter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DeepPink
        Label3.Location = New Point(48, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(211, 48)
        Label3.TabIndex = 20
        Label3.Text = "Billing Form"
        ' 
        ' BillGV
        ' 
        BillGV.BackgroundColor = Color.White
        BillGV.BorderStyle = BorderStyle.None
        BillGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkOrchid
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        BillGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        BillGV.ColumnHeadersHeight = 30
        BillGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkOrchid
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        BillGV.DefaultCellStyle = DataGridViewCellStyle2
        BillGV.Location = New Point(378, 184)
        BillGV.Name = "BillGV"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.ControlDark
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        BillGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        BillGV.RowHeadersWidth = 62
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle4.ForeColor = Color.Black
        BillGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        BillGV.Size = New Size(815, 374)
        BillGV.TabIndex = 21
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Id"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "MedName"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Quantity"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "UnitPrice"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "TotalPrice"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' MediComboCb
        ' 
        MediComboCb.FormattingEnabled = True
        MediComboCb.Location = New Point(48, 259)
        MediComboCb.Name = "MediComboCb"
        MediComboCb.Size = New Size(257, 33)
        MediComboCb.TabIndex = 22
        MediComboCb.Text = "Select Medicine"
        ' 
        ' InStocklbl
        ' 
        InStocklbl.AutoSize = True
        InStocklbl.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InStocklbl.ForeColor = Color.Crimson
        InStocklbl.Location = New Point(58, 305)
        InStocklbl.Name = "InStocklbl"
        InStocklbl.Size = New Size(201, 38)
        InStocklbl.TabIndex = 23
        InStocklbl.Text = "Available Stock"
        ' 
        ' Button
        ' 
        Button.BackColor = Color.DarkOrchid
        Button.FlatAppearance.BorderSize = 0
        Button.FlatStyle = FlatStyle.Flat
        Button.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button.ForeColor = Color.White
        Button.Location = New Point(58, 420)
        Button.Name = "Button"
        Button.Size = New Size(209, 53)
        Button.TabIndex = 25
        Button.Text = "Add To Bill"
        Button.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrchid
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(547, 639)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 53)
        Button2.TabIndex = 26
        Button2.Text = "Print"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkOrchid
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(899, 639)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 53)
        Button3.TabIndex = 27
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' QtyTb
        ' 
        QtyTb.Location = New Point(48, 359)
        QtyTb.Name = "QtyTb"
        QtyTb.Size = New Size(257, 31)
        QtyTb.TabIndex = 31
        QtyTb.Text = "Quantity"
        ' 
        ' TotalAmntlbl
        ' 
        TotalAmntlbl.AutoSize = True
        TotalAmntlbl.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalAmntlbl.ForeColor = Color.Crimson
        TotalAmntlbl.Location = New Point(694, 580)
        TotalAmntlbl.Name = "TotalAmntlbl"
        TotalAmntlbl.Size = New Size(174, 38)
        TotalAmntlbl.TabIndex = 32
        TotalAmntlbl.Text = "TotalAmount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Crimson
        Label5.Location = New Point(668, 580)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 38)
        Label5.TabIndex = 33
        Label5.Text = "$"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Billing
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1278, 719)
        Controls.Add(Label5)
        Controls.Add(TotalAmntlbl)
        Controls.Add(QtyTb)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button)
        Controls.Add(InStocklbl)
        Controls.Add(MediComboCb)
        Controls.Add(BillGV)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "Billing"
        Text = "Select Medicine"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(BillGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BillGV As DataGridView
    Friend WithEvents MediComboCb As ComboBox
    Friend WithEvents InStocklbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmntlbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
