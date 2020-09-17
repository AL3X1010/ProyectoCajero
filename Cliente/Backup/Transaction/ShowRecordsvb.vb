Imports System.Data.OleDb

Public Class ShowRecordsvb

    Dim con As New OleDbConnection

    Private Sub ShowRecordsvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source='|DataDirectory|/transaction.mdb'"
        con.Open()
        showrecords()
        con.Close()

    End Sub

    Private Sub showrecords()
        Try

            'con.Open()
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter

            da = New OleDbDataAdapter("SELECT * FROM records", con)
            da.Fill(ds, "records")

            With ds.Tables("records").Rows(0)

                DataGridView1.DataSource = ds.Tables("records").DefaultView

            End With
            'con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        Dim cmd As New OleDbCommand
        cmd = New OleDbCommand("SELECT Password FROM admin WHERE Password =" & "'" & txtpass.Text & "'", con)
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Try
            If dr.Read = False Then
                grbwrongpass.Visible = True
                btnok.Visible = True
                btnlogin.Visible = False
                'txtpass.Visible = False

            Else
                MessageBox.Show("Log-in Successfuly")
                TabControl1.SelectedTab = TabPage2
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        btnlogin.Visible = True
        btnok.Visible = False
        grbwrongpass.Visible = False
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class