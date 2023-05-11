Imports System.Data.OleDb
Public Class Form8
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adpt As New OleDbDataAdapter
    Dim reader As OleDbDataReader
    Dim ds As New dataset
    Dim str As String
    Dim n As String
    Dim avg As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        conn.Open()
        conn.Close()
    End Sub
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarksDataSet2.Attendence' table. You can move, or remove it, as needed.
        Me.AttendenceTableAdapter.Fill(Me.MarksDataSet2.Attendence)
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddi\OneDrive\Documents\marks.accdb")
        conn.Open()
        str = "select * from Attendence"
        cmd = New OleDbCommand(str, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "Attendence")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Attendence"
        ComboBox1.Text = ""
        ComboBox1.Text = "Select Roll_no"
        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "Attendence.Roll_no"

        conn.Close()
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        Button4.Visible = False

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        Button4.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String
        Dim count As Integer
        conn.Open()
        str = "update Attendence set Att_GAD = " & CDbl(TextBox1.Text) & ", Att_JPR = " & CDbl(TextBox2.Text) & ", Att_SEN = " & CDbl(TextBox3.Text) & " where [Roll_No] = " & CDbl(ComboBox1.Text) & ""
        cmd = New OleDbCommand(str, conn)
        count = cmd.ExecuteNonQuery()
        MsgBox(count & " Record saved")
        conn.Close()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conn.Open()
        Dim count As Integer
        str = "insert into Attendence (Roll_no,Name,Att_Gad,Att_JPR,Att_SEN) values (" & CInt(TextBox4.Text) & ",'" & TextBox5.Text & "'," & CInt(TextBox6.Text) & "," & CInt(TextBox7.Text) & "," & CInt(TextBox6.Text) & ")"
        cmd = New OleDbCommand(str, conn)

        count = cmd.ExecuteNonQuery()
        MsgBox(count & " Record saved")
        conn.Close()
        If MessageBox.Show("Do you Want to enter another record", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            TextBox4.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            Form3.Show()
            Me.Hide()
            Exit Sub
        End If
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
End Class