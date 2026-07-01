Imports System.CodeDom
Imports Microsoft.Data.SqlClient

Public Class Medicine
    Dim Con As New SqlConnection("Data Source=DESKTOP-EGV91L6\SQLEXPRESS02;Initial Catalog=Pharmacenter;Integrated Security=True;Encrypt=False")
    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from CompanyTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CompCb.DataSource = Tbl
        CompCb.DisplayMember = "CompName"
        CompCb.ValueMember = "CompName"
        Con.Close()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from MedicineTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        MedicineGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim query As String
        query = "insert into MedicineTbl (MedName, Bprice, Sprice, MedQty, ExpDate, Company) VALUES (@MedName, @Bprice, @Sprice, @MedQty, @ExpDate, @Company)"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.Parameters.AddWithValue("@MedName", MedicineTb.Text)
        cmd.Parameters.AddWithValue("@Bprice", BpriceTb.Text)
        cmd.Parameters.AddWithValue("@Sprice", SpriceTb.Text)
        cmd.Parameters.AddWithValue("@MedQty", QtTb.Text)
        cmd.Parameters.AddWithValue("@ExpDate", ExpDate.Text)
        cmd.Parameters.AddWithValue("@Company", CompCb.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Medicine Successfully Added")
        Con.Close()
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MedicineTb.Text = "" Then
            MsgBox("No Medicine Selected")
        Else

            Dim query As String
            query = "delete from MedicineTbl where MedName = @MedName"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@MedName", MedicineTb.Text.Trim())
            Con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Deleted")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MedicineTb.Text = "" Or BpriceTb.Text = "" Or SpriceTb.Text = "" Or QtTb.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Dim query As String = "Update MedicineTbl set Bprice = @Bprice, Sprice = @Sprice, MedQty = @MedQty, ExpDate = @ExpDate, Company = @Company where MedName = @MedName"
            Dim cmd As New SqlCommand(query, Con)

            cmd.Parameters.AddWithValue("@MedName", MedicineTb.Text.Trim())
            cmd.Parameters.AddWithValue("@Bprice", BpriceTb.Text.Trim())
            cmd.Parameters.AddWithValue("@Sprice", SpriceTb.Text.Trim())
            cmd.Parameters.AddWithValue("@MedQty", QtTb.Text.Trim())
            cmd.Parameters.AddWithValue("@ExpDate", ExpDate.Text.Trim())
            cmd.Parameters.AddWithValue("@Company", CompCb.Text.Trim())
            Con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Updated")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        MedicineGV.Columns.Clear()
        populate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MedicineTb.Text = ""
        BpriceTb.Text = ""
        SpriceTb.Text = ""
        QtTb.Text = ""
        ExpDate.Text = ""
        CompCb.Text = ""
    End Sub

    Private Sub MedicineGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MedicineGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = MedicineGV.Rows(index)
        MedicineTb.Text = selectedrow.Cells(0).Value.ToString
        BpriceTb.Text = selectedrow.Cells(1).Value.ToString
        SpriceTb.Text = selectedrow.Cells(2).Value.ToString
        QtTb.Text = selectedrow.Cells(3).Value.ToString
        ExpDate.Text = selectedrow.Cells(4).Value.ToString
        CompCb.Text = selectedrow.Cells(5).Value.ToString

    End Sub
End Class