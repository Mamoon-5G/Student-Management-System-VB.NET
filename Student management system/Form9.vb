Imports System.Data.OleDb
Public Class Form9
        Dim cmd As OleDbCommand = New OleDbCommand
        Dim reader As OleDbDataReader
        Dim conn As OleDbConnection = New OleDbConnection
        Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim str As String
    Dim ds As DataSet = New DataSet
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Form2.Show()
            Me.Hide()
        End Sub

        Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarksDataSet4.marks' table. You can move, or remove it, as needed.
        Me.MarksTableAdapter3.Fill(Me.MarksDataSet4.marks)
        'TODO: This line of code loads data into the 'MarksDataSet3.marks' table. You can move, or remove it, as needed.
        Me.MarksTableAdapter.Fill(Me.MarksDataSet.marks)
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddi\OneDrive\Documents\marks.accdb")
        conn.Open()
        cmd = New OleDbCommand("select * from marks", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "marks")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "marks"

        ds.Tables.Clear()
        ds.Clear()
        adpt.Fill(ds, "marks")
        DataGridView1.DataSource = ds
        DataGridView1.Refresh()
        ComboBox1.Text = ""
        ComboBox1.Text = "Select Roll_no"
        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "marks.Roll_no"
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String
        Dim count As Integer
        conn.Open()
        str = "update marks set gad_marks = " & CDbl(TextBox1.Text) & ", jpr_marks = " & CDbl(TextBox2.Text) & ", sen_marks = " & CDbl(TextBox3.Text) & " where [Roll_No] = " & CDbl(ComboBox1.Text) & ""
        cmd = New OleDbCommand(str, conn)
        count = cmd.ExecuteNonQuery()
        MsgBox(count & " Record saved")
        conn.Close()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conn.Open()
        Dim count As Integer
        str = "insert into marks (Roll_no,gad_marks,jpr_marks,sen_marks) values (" & CInt(TextBox4.Text) & "," & CInt(TextBox6.Text) & "," & CInt(TextBox7.Text) & "," & CInt(TextBox6.Text) & ")"
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
        conn.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class