Imports System.Data.OleDb
Public Class Form5
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\siddi\OneDrive\Documents\login.mdb;")
        conn.Open()
        cmd = New OleDbCommand("select * from stud_data", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "stud_data")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "stud_data"

        ds.Tables.Clear()
        ds.Clear()
        adpt.Fill(ds, "stud_data")
        DataGridView1.DataSource = ds
        DataGridView1.Refresh()
        conn.Close()
    End Sub
End Class