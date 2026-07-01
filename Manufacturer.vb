Imports System.Net.Mime
Imports Microsoft.Data.SqlClient

Public Class Manufacturer
    Dim Con As New SqlConnection("Data Source=DESKTOP-EGV91L6\SQLEXPRESS02;Initial Catalog=Pharmacenter;Integrated Security=True;Encrypt=False")
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from CompanyTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ManufacturerGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim query As String
        query = "insert into CompanyTbl (CompId, CompName, CompPhone, CompAddress) VALUES (@CompId, @CompName, @CompPhone, @CompAddress)"

        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.Parameters.AddWithValue("@CompId", CompIdTb.Text)
        cmd.Parameters.AddWithValue("@CompName", CompNameTb.Text)
        cmd.Parameters.AddWithValue("@CompPhone", CompPhTb.Text)
        cmd.Parameters.AddWithValue("@CompAddress", CompAddTb.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Manufacturer Successfully Added")
        Con.Close()
        populate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query1 As String = "Update CompanyTbl set CompName= @CompName, CompPhone= @CompPhone, CompAddress= @CompAddress  where CompId= @CompId"
        Dim cmd1 As New SqlCommand(query1, Con)
        cmd1.Parameters.AddWithValue("@CompId", CompIdTb.Text.Trim())
        cmd1.Parameters.AddWithValue("@CompName", CompNameTb.Text.Trim())
        cmd1.Parameters.AddWithValue("@CompPhone", CompPhTb.Text.Trim())
        cmd1.Parameters.AddWithValue("@CompAddress", CompAddTb.Text.Trim())
        Con.Open()
        cmd1.ExecuteNonQuery()
        Con.Close()
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query2 As String = "delete from CompanyTbl where CompId = @CompId"
        Dim cmd2 As New SqlCommand(query2, Con)
        cmd2.Parameters.AddWithValue("@CompId", CompIdTb.Text.Trim())
        Con.Open()
        cmd2.ExecuteNonQuery()
        Con.Close()
        populate()

    End Sub

    Private Sub Manufacturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManufacturerGV.Columns.Clear()
        populate()
    End Sub


    Private Sub ManufacturerGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManufacturerGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = ManufacturerGV.Rows(index)
        CompIdTb.Text = selectedrow.Cells(0).Value.ToString
        CompNameTb.Text = selectedrow.Cells(1).Value.ToString
        CompPhTb.Text = selectedrow.Cells(2).Value.ToString
        CompAddTb.Text = selectedrow.Cells(3).Value.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CompIdTb.Text = ""
        CompNameTb.Text = ""
        CompPhTb.Text = ""
        CompAddTb.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
End Class