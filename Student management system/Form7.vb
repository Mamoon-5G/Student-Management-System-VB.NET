Imports System.Data.OleDb
Public Class Form7
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim reader As OleDbDataReader
    Dim ds As New DataSet
    Dim str As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\siddi\OneDrive\Documents\login.mdb;")
        conn.Open()
        cmd = New OleDbCommand("select * from stud_data", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "stud_data")
        ComboBox3.Text = "select Enrollment_no"
        ComboBox3.DataSource = ds
        ComboBox3.DisplayMember = "stud_data.Enrollment_no"
        conn.Close()
        Timer1.Enabled = False
        Button4.Visible = False
        ProgressBar2.Visible = False
        Timer1.Interval = 1000
        ProgressBar2.Value = 0

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String
        conn.Open()
        str = "update stud_data set Full_name ='" & TextBox2.Text & "' , Roll_no =" & CInt(TextBox3.Text) & ", Gender = '" & ComboBox1.Text & "', Date_of_birth = " & CDate(DateTimePicker1.Text) & ", Phone_no = " & CDbl(TextBox4.Text) & ", Course =  '" & ComboBox2.Text & "' where [Enrollment_no] = " & CDbl(ComboBox3.Text) & ""
        cmd = New OleDbCommand(str, conn)
        Timer1.Enabled = True
        ProgressBar2.Visible = True
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer
        ProgressBar2.Increment(25)
        If ProgressBar2.Value = 100 Then
            Timer1.Stop()
            count = cmd.ExecuteNonQuery()

            MsgBox(count & " Record saved")
            conn.Close()
            Button4.Visible = True
        End If

    End Sub
End Class