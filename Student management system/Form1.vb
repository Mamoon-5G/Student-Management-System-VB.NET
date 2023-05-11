Imports System.Data.OleDb
Public Class LOGIN
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\siddi\OneDrive\Documents\login.mdb;")
        conn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("select * from login where [Username]='" & TextBox1.Text & "' and [Password]= '" & TextBox2.Text & "'", conn)
        Dim adpt As OleDbDataReader = cmd.ExecuteReader
        If (adpt.Read() = True) Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Login Failed")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If
    End Sub
End Class
