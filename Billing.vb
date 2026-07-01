Imports System.Drawing.Printing
Imports Microsoft.Data.SqlClient

Public Class Billing
    Dim Con As New SqlConnection("Data Source=DESKTOP-EGV91L6\SQLEXPRESS02;Initial Catalog=Pharmacenter;Integrated Security=True;Encrypt=False")

    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from MedicineTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        MediComboCb.DataSource = Tbl
        MediComboCb.DisplayMember = "MedName"
        MediComboCb.ValueMember = "MedName"
        Con.Close()
    End Sub

    Dim stock, Uprice
    Private Sub FetchQty()
        Con.Open()
        Dim query = "select * from MedicineTbl where MedName = '" & MediComboCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            'MsgBox("" + reader(0).ToString())
            stock = reader(3)
            Uprice = reader(2)
            InStocklbl.Text = "Available Stock Is: " + reader(3).ToString()
        End While
        Con.Close()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub



    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub

    Private Sub MediComboCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MediComboCb.SelectionChangeCommitted
        FetchQty()
    End Sub

    Dim i = 0, totprice
    Dim Grdtot = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button.Click
        If QtyTb.Text > stock Then
            MsgBox("No Enough InStock")
        ElseIf QtyTb.Text = "" Then
            MsgBox("Enter a Quantity")
        Else
            'Let's add Medicine to the Bill
            Dim rnum As Integer = BillGV.Rows.Add()
            i = i + 1
            BillGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillGV.Rows.Item(rnum).Cells("Column2").Value = MediComboCb.SelectedValue.ToString()
            BillGV.Rows.Item(rnum).Cells("Column3").Value = QtyTb.Text
            BillGV.Rows.Item(rnum).Cells("Column4").Value = Uprice
            BillGV.Rows.Item(rnum).Cells("Column5").Value = QtyTb.Text * Uprice
            Dim Subtot = QtyTb.Text * Uprice
            Grdtot = Grdtot + Subtot
            TotalAmntlbl.Text = Grdtot
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim image1 As New Bitmap(Me.BillGV.Width, Me.BillGV.Height)
        Me.BillGV.DrawToBitmap(image1, New Rectangle(0, 0, Me.BillGV.Width, Me.BillGV.Height))
        e.Graphics.DrawImage(image1, 100, 20)
    End Sub


End Class