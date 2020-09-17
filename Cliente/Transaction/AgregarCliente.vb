Imports System.Data.OleDb

Public Class newaccount

    Dim con As New OleDbConnection

    Private Sub newaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source='|DataDirectory|/transaction.mdb'"
        'con.Open()
        'con.Close()

    End Sub

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click

        Dim cmd As New OleDbCommand

        cmd = New OleDbCommand("SELECT Card_Number FROM records WHERE Card_Number=" & "'" & txtCardNum.Text & "'", con)
        con.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Try
            If dr.Read = True Then
                MsgBox("Card Number or Account Number is alreadt used!", vbCritical)
            Else


                Dim dt As New DataTable
                Dim ds As New DataSet
                ds.Tables.Add(dt)
                Dim da As New OleDbDataAdapter

                da = New OleDbDataAdapter("SELECT * FROM records", con)
                da.Fill(dt)

                Dim nr As DataRow = dt.NewRow
                Try
                    With nr

                        .Item("Card_Number") = txtCardNum.Text
                        .Item("Account_Number") = txtAccNum.Text
                        .Item("PIN") = txtPin.Text
                        .Item("First_Name") = txtFN.Text
                        .Item("Family_Name") = txtFamN.Text
                        .Item("Age") = txtage.Text
                        .Item("Status") = cmbStatus.Text
                        .Item("Address1") = txtaddr1.Text
                        .Item("Saving") = Val(txtinitialdep.Text)

                        dt.Rows.Add(nr)

                        Dim cb As New OleDbCommandBuilder(da)
                        da.Update(dt)

                        con.Close()
                        MessageBox.Show("Account Created", "Success", MessageBoxButtons.OK)
                        txtFN.Clear()
                        txtFamN.Clear()
                        txtage.Clear()
                        cmbStatus.Text = ""
                        rdbF.Checked = False
                        rdbM.Checked = False
                        txtaddr1.Clear()
                        txtCardNum.Clear()
                        txtAccNum.Clear()
                        txtPin.Clear()
                        txtinitialdep.Clear()

                    End With
                Catch ex As Exception
                    MsgBox(ex.ToString, vbCritical)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        End Try
        'End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtinitialdep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinitialdep.TextChanged
        'If Val(txtinitialdep.Text) < 500 Then
        'MsgBox("Minimum Initial Deposit is 500.", vbCritical)
        'txtinitialdep.Clear()
        'End If
    End Sub

    Private Sub txtCardNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCardNum.TextChanged
        If txtCardNum.TextLength = 11 Then
            If IsNumeric(txtCardNum.Text) Then
                Try

                    Dim cmd As New OleDbCommand
                    cmd = New OleDbCommand("SELECT * FROM records WHERE Card_Number=" & "'" & txtCardNum.Text & "'", con)

                    con.Open()
                    Dim dr As OleDbDataReader = cmd.ExecuteReader
                    If dr.Read = True Then
                        MsgBox("Card Number is already used.", vbCritical)
                        txtCardNum.Clear()
                    End If
                    con.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString, vbCritical)
                End Try
            End If
        End If
    End Sub

    Private Sub txtAccNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNum.TextChanged
        If txtAccNum.TextLength = 6 Then
            Try

                Dim cmd As New OleDbCommand
                cmd = New OleDbCommand("SELECT Account_Number FROM records WHERE Account_Number =" & "'" & txtAccNum.Text & "'", con)
                con.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                If dr.Read = True Then
                    MsgBox("Account Number Is Already In Use . .", vbCritical)
                    txtAccNum.Text = ""
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString, vbCritical)
            End Try
        End If
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub grpbPI_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpbPI.Enter

    End Sub

    Private Sub rdbM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbM.CheckedChanged

    End Sub
End Class