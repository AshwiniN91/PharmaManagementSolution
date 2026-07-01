Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System

Public Class Agent
    Dim Con As New SqlConnection("Data Source=DESKTOP-EGV91L6\SQLEXPRESS02;Initial Catalog=Pharmacenter;Integrated Security=True;Encrypt=False")
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        AgentGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpIdTb.Text = 0 Then
            MsgBox("Employee record is empty")
        Else
            Con.Open()
            Dim query As String
            query = "insert into EmployeeTbl (EmpId, EmpName, EmpSal, EmpAge, EmpPhone, EmpPassword) VALUES (@EmpId, @EmpName, @EmpSal, @EmpAge, @EmpPhone, @EmpPassword)"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@EmpId", EmpIdTb.Text)
            cmd.Parameters.AddWithValue("@EmpName", EmpNameTb.Text)
            cmd.Parameters.AddWithValue("@EmpSal", EmpAgeTb.Text)
            cmd.Parameters.AddWithValue("@EmpAge", EmpSalTb.Text)
            cmd.Parameters.AddWithValue("@EmpPhone", PhTb.Text)
            cmd.Parameters.AddWithValue("@EmpPassword", PwdTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Employee record Successfully Added")
            Con.Close()
            populate()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If EmpIdTb.Text = "" Or EmpNameTb.Text = "" Or EmpSalTb.Text = "" Or EmpAgeTb.Text = "" Or PhTb.Text = "" Or PwdTb.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Dim query1 As String = "Update EmployeeTbl set EmpName= @EmpName, EmpSal= @EmpSal, EmpAge= @EmpAge, EmpPhone = @EmpPhone, EmpPassword = @EmpPassword  where EmpId= @EmpId"
            Dim cmd1 As New SqlCommand(query1, Con)
            cmd1.Parameters.AddWithValue("@EmpId", EmpIdTb.Text.Trim())
            cmd1.Parameters.AddWithValue("@EmpName", EmpNameTb.Text.Trim())
            cmd1.Parameters.AddWithValue("@EmpSal", EmpSalTb.Text.Trim())
            cmd1.Parameters.AddWithValue("@EmpAge", EmpAgeTb.Text.Trim())
            cmd1.Parameters.AddWithValue("@EmpPhone", PhTb.Text.Trim())
            cmd1.Parameters.AddWithValue("@EmpPassword", PwdTb.Text.Trim())
            Con.Open()
            cmd1.ExecuteNonQuery()
            MsgBox("Employee record successfully updated")
            Con.Close()
            populate()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If EmpIdTb.Text.Trim = "" Then
            MsgBox("No Employee Selected")
        Else
            Dim query2 As String = "delete from EmployeeTbl where EmpId = @EmpId"
            Dim cmd2 As New SqlCommand(query2, Con)
            cmd2.Parameters.AddWithValue("@EmpId", EmpIdTb.Text.Trim())
            Con.Open()
            cmd2.ExecuteNonQuery()
            MsgBox("Employee Successfully Deleted")
            Con.Close()
            populate()
        End If


    End Sub

    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgentGV.Columns.Clear()
        populate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmpIdTb.Text = ""
        EmpNameTb.Text = ""
        EmpAgeTb.Text = ""
        EmpSalTb.Text = ""
        PhTb.Text = ""
        PwdTb.Text = ""
    End Sub

    Private Sub AgentGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AgentGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = AgentGV.Rows(index)
        EmpIdTb.Text = selectedrow.Cells(0).Value.ToString
        EmpNameTb.Text = selectedrow.Cells(1).Value.ToString
        EmpSalTb.Text = selectedrow.Cells(2).Value.ToString
        EmpAgeTb.Text = selectedrow.Cells(3).Value.ToString
        PhTb.Text = selectedrow.Cells(4).Value.ToString
        PwdTb.Text = selectedrow.Cells(5).Value.ToString
    End Sub
End Class