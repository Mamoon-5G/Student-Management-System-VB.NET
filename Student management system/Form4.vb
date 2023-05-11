Imports System.Data.OleDb
Public Class Form4
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim str As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim count As Integer
        str = "insert into stud_data (Full_name,Roll_no,Enrollment_no,Date_of_birth,Phone_no,Gender,Course) values ('" & TextBox1.Text & "'," & CInt(TextBox2.Text) & "," & CDbl(TextBox3.Text) & "," & CDate(DateTimePicker1.Text) & "," & CDec(TextBox5.Text) & ",'" & ComboBox1.Text & "','" & ComboBox2.Text & "')"
        cmd = New OleDbCommand(str, conn)

        count = cmd.ExecuteNonQuery()
        MsgBox(count & " Record saved")
        conn.Close()
        If MessageBox.Show("Do you Want to enter another record", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            DateTimePicker1.Text = ""
            Form3.Show()
            Me.Hide()
            Exit Sub
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DateTimePicker1.Text = ""

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\siddi\OneDrive\Documents\login.mdb;")
        
    End Sub
End Class