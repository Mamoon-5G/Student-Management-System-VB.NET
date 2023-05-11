Imports System.Data.OleDb
Public Class Form6
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\siddi\OneDrive\Documents\login.mdb;")
        conn.Open()
        Dim count As Integer
        If MessageBox.Show("Do you really want to Delete this Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            MsgBox("Operation Cancelled")
            Exit Sub
        End If
        str = "delete * from stud_data where [Enrollment_no] = " & CDbl(ComboBox1.Text) & ""
        cmd = New OleDbCommand(str, conn)
        count = cmd.ExecuteNonQuery
        MsgBox(count & " Records Deleted ")
        conn.Close()
        ComboBox1.Text = ""
        DataGridView1.Visible = False
        Form3.Show()
        Me.Hide()
       
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\siddi\OneDrive\Documents\login.mdb;")
        conn.Open()
        ComboBox1.Text = ""
        cmd = New OleDbCommand("select * from Stud_data", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "stud_data")
        ComboBox1.Text = "Select Enrollment_no"
        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "stud_data.Enrollment_no"
        DataGridView1.Visible = False
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Visible = True
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\siddi\OneDrive\Documents\login.mdb;")
        conn.Open()
        str = "select * from stud_data where [Enrollment_no] = " & ComboBox1.Text & ""
        cmd = New OleDbCommand(str, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "Stud_data")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Stud_data"
        conn.Close()
       
    End Sub
End Class