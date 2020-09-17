Imports System.Data.OleDb

Public Class transaction

    Dim val1 As Double
    Dim val2 As Double
    Dim ansa As Double
    Dim bal As Double
    Dim PIN1 As Double
    Dim PIN2 As Double

    Dim con As New OleDbConnection

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If btnInsert.Text = "GET ATM CARD" Then
            TabControl1.SelectedTab = TabPage1
            btnInsert.Text = "Insert ATM Card"
            Label5.Text = "INSERT CARD"
            Label6.Visible = False
            ProgressBar1.Visible = False

        ElseIf btnInsert.Text = "Insert ATM Card" Then
            Label5.Text = "PLEASE WAIT "
            Label6.Visible = True
            ProgressBar1.Visible = True
            btnInsert.Enabled = False
            Timer1.Start()

        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            TabControl1.SelectedTab = TabPage2
            Timer1.Stop()
            btn2.Text = ">"
            btn6.Text = "<"
            ProgressBar1.Refresh()
        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If btn2.Text = ">" Then
            TabControl1.SelectedTab = TabPage3
            btn2.Text = ">>"
            btn3.Text = ">>"
            btn6.Text = "<<"
        ElseIf btn2.Text = ">>" Then
            TabControl1.SelectedTab = TabPage9
            btn2.Text = ""
            btn3.Text = ""
            btn6.Text = ""
            btn8.Text = "<<<<"
            Label66.Text = "Account Number:"
            Label65.Text = "Account Name:"
            Label64.Text = "Amount:"
            Label63.Text = "PIN:"
            Label61.Text = "DEPOSIT"
        ElseIf btn2.Text = ">>>" Then
            TabControl1.SelectedTab = TabPage9
            btn2.Text = ""
            btn3.Text = ""
            btn6.Text = ""
            btn8.Text = "<<<<"
            Label66.Text = "Numero ng Account:"
            Label65.Text = "Pangalan ng Account:"
            Label64.Text = "Halaga:"
            Label63.Text = "PIN:"
            Label61.Text = "IDEPOSITO"
        End If
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click

        If btn6.Text = "<" Then
            TabControl1.SelectedTab = TabPage7
            btn2.Text = ">>>"
            btn3.Text = ">>>"
            btn6.Text = "<<<"
        ElseIf btn6.Text = "<<" Then
            TabControl1.SelectedTab = TabPage4
            btn2.Text = ""
            btn3.Text = ""
            btn6.Text = ""
            btn8.Text = "<<"
            Label22.Text = "Account Number:"
            Label23.Text = "Account Name:"
            Label24.Text = "Amount:"
            Label25.Text = "Enter PIN:"
            txtAccNum.Text = ""
            txtAccName.Text = ""
            txtamount.Text = ""
            txtEpin.Text = ""
        ElseIf btn6.Text = "<<<" Then
            TabControl1.SelectedTab = TabPage4
            btn2.Text = ""
            btn3.Text = ""
            btn6.Text = ""
            btn8.Text = "<<"
            Label22.Text = "Numero ng Account:"
            Label23.Text = "Pangalan ng Account:"
            Label24.Text = "Halaga:"
            Label25.Text = "PIN:"
            txtAccNum.Text = ""
            txtAccName.Text = ""
            txtamount.Text = ""
            txtEpin.Text = ""
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtAccNum.Text & txtamount.Text & txtEpin.Text = "" Then
            TabControl1.SelectedTab = TabPage6
            btnInsert.Text = "GET YOUR CARD"
            btnInsert.Enabled = True

        Else
            TabControl1.SelectedTab = TabPage5
            lblDateTime.Text = Form1.DateTimePicker1.Value
            btnInsert.Enabled = True
            btnInsert.Text = "GET YOUR CARD"

        End If

    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If btn8.Text = "<<" Then

            If txtAccNum.Text & txtAccName.Text & txtamount.Text & txtEpin.Text = "" Then

                TabControl1.SelectedTab = TabPage6
                btnInsert.Text = "GET ATM CARD"
                btnInsert.Enabled = True

            Else

                ansa = val2 - val1
                Try
                    con.Open()

                    Dim ds As New DataSet
                    Dim da As New OleDbDataAdapter

                    da = New OleDbDataAdapter("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum.Text & "'", con)
                    da.Fill(ds, "records")

                    With ds.Tables("records").Rows(0)


                        .Item("Saving") = ansa


                        Dim cb As New OleDbCommandBuilder(da)
                        da.Update(ds, "records")

                    End With

                    con.Close()

                    TabControl1.SelectedTab = TabPage5
                    btn8.Text = ""
                    lblDateTime.Text = Form1.DateTimePicker1.Value
                    lbltransac.Text = "WITHDRAW"
                    lblAmount.Text = val1
                    btnInsert.Text = "GET ATM CARD"
                    btnInsert.Enabled = True
                    lblavailbal.Text = ansa
                    lbltotalbal.Text = ansa

                Catch ex As Exception
                    MsgBox(ex.ToString, vbCritical)
                End Try

            End If



        ElseIf btn8.Text = "<<<" Then
            TabControl1.SelectedTab = TabPage5
            btn8.Text = ""
            lblDateTime.Text = Form1.DateTimePicker1.Value
            lbltransac.Text = "BALANCE"
            lblAmount.Text = "NONE"
            btnInsert.Text = "GET ATM CARD"
            btnInsert.Enabled = True
            lblavailbal.Text = bal
            lbltotalbal.Text = bal
        ElseIf btn8.Text = "<<<<" Then
            If txtAccNum2.Text & txtAccN2.Text & txtAmount1.Text & txtEPIN1.Text = "" Then
                TabControl1.SelectedTab = TabPage6
                btnInsert.Text = "GET ATM CARD"
                btnInsert.Enabled = True
            Else
                ansa = val2 + val1
                Try


                    con.Open()

                    Dim ds As New DataSet
                    Dim da As New OleDbDataAdapter

                    da = New OleDbDataAdapter("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum2.Text & "'", con)
                    da.Fill(ds, "records")

                    With ds.Tables("records").Rows(0)

                        .Item("Saving") = ansa

                        Dim cb As New OleDbCommandBuilder(da)
                        da.Update(ds, "records")

                    End With

                    con.Close()

                    TabControl1.SelectedTab = TabPage5
                    btn8.Text = ""
                    lblDateTime.Text = Form1.DateTimePicker1.Value
                    lbltransac.Text = "DEPOSIT"
                    lblAmount.Text = val1
                    lblavailbal.Text = ansa
                    lbltotalbal.Text = ansa
                    btnInsert.Text = "GET ATM CARD"
                    btnInsert.Enabled = True

                Catch ex As Exception
                    MsgBox(ex.ToString, vbCritical)
                End Try


            End If

        End If
    End Sub

    Private Sub transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "provider=microsoft.jet.oledb.4.0; data source='|DataDirectory|/transaction.mdb'"
        con.Open()
        con.Close()

    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If btn3.Text = ">>" Then
            TabControl1.SelectedTab = TabPage8
            btn2.Text = ""
            btn3.Text = ""
            btn6.Text = ""
            btn8.Text = "<<<"
            Label58.Text = "Account Number:"
            Label57.Text = "Account Name:"
            Label56.Text = "PIN:"
            Label62.Text = "INQUIRE"

        ElseIf btn3.Text = ">>>" Then

            TabControl1.SelectedTab = TabPage8
            btn2.Text = ""
            btn3.Text = ""
            btn6.Text = ""
            btn8.Text = "<<<"
            Label58.Text = "Numero ng Account:"
            Label57.Text = "Pangalan ng Account:"
            Label56.Text = "PIN:"
            Label62.Text = "MAG INQUIRE"

        End If
    End Sub

    Private Sub txtAccNum_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccNum.TextChanged
        If txtAccNum.TextLength = 6 Then
            Try
                Dim cmd As New OleDbCommand

                cmd = New OleDbCommand("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum.Text & "'", con)

                con.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                If dr.Read = False Then
                    MsgBox("Card Number is Incorrect . . ", vbCritical)
                    txtAccNum.Text = ""
                    con.Close()
                Else
                    Dim ds As New DataSet
                    Dim da As New OleDbDataAdapter

                    da = New OleDbDataAdapter("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum.Text & "'", con)
                    da.Fill(ds, "records")
                    Try
                        With ds.Tables("records").Rows(0)

                            txtAccName.Text = .Item("Account_Name")
                            val2 = Val(.Item("Saving"))
                            PIN2 = Val(.Item("PIN"))

                        End With

                    Catch ex As Exception
                        MsgBox(ex.ToString, vbCritical)
                    End Try

                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, vbCritical)
            End Try

        End If
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        val1 = Val(txtamount.Text)
        If val1 > val2 Then
            MsgBox("Amount Exceed", vbCritical)
            txtamount.Clear()
        End If
    End Sub

    Private Sub txtAccNum1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNum1.TextChanged
        If txtAccNum1.TextLength = 6 Then
            Try
                Dim cmd As New OleDbCommand

                cmd = New OleDbCommand("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum1.Text & "'", con)

                con.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                If dr.Read = False Then
                    MsgBox("Card Number is Incorrect . . ", vbCritical)
                    txtAccNum1.Text = ""
                    con.Close()
                Else

                    Dim ds As New DataSet
                    Dim da As New OleDbDataAdapter

                    da = New OleDbDataAdapter("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum1.Text & "'", con)
                    da.Fill(ds, "records")
                    With ds.Tables("records").Rows(0)

                        txtAccN1.Text = .Item("Account_Name")
                        bal = Val(.Item("Saving"))
                        PIN2 = Val(.Item("PIN"))

                    End With
                    con.Close()

                End If
            Catch ex As Exception
                MsgBox(ex.ToString, vbCritical)
            End Try

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtAccNum2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccNum2.TextChanged
        If txtAccNum2.TextLength = 6 Then

            Dim cmd As New OleDbCommand
            cmd = New OleDbCommand("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum2.Text & "'", con)

            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            If dr.Read = False Then
                MsgBox("Card Number is Incorrect!", vbCritical)
                txtAccNum2.Text = ""
                con.Close()
            Else

                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter

                da = New OleDbDataAdapter("SELECT * FROM records WHERE Account_Number=" & "'" & txtAccNum2.Text & "'", con)
                da.Fill(ds, "records")
                Try
                    With ds.Tables("records").Rows(0)

                        txtAccN2.Text = .Item("Account_Name")
                        val2 = Val(.Item("Saving"))
                        PIN1 = Val(.Item("PIN"))

                    End With
                Catch ex As Exception
                    MsgBox(ex.ToString, vbCritical)
                End Try

                con.Close()
            End If

        End If
    End Sub

    Private Sub txtAmount1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount1.TextChanged
        val1 = Val(txtAmount1.Text)
    End Sub

    Private Sub txtEPIN1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEPIN1.TextChanged
        PIN2 = Val(txtEPIN1.Text)

        If txtEPIN1.TextLength = 4 Then
            If Not PIN2 = PIN1 Then
                MsgBox("Incorrect PIN!", vbCritical)
                txtEPIN1.Clear()
            End If
        End If
    End Sub

    Private Sub txtEpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEpin.TextChanged
        PIN1 = Val(txtEpin.Text)
        If txtEpin.TextLength = 4 Then
            If Not PIN1 = PIN2 Then
                MsgBox("Incorrect PIN!", vbCritical)
                txtEpin.Clear()
            End If
        End If
    End Sub

    Private Sub txtPIN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPIN.TextChanged
        PIN1 = Val(txtPIN.Text)
        If txtPIN.TextLength = 4 Then
            If Not PIN1 = PIN2 Then
                MsgBox("Incorrect PIN", vbCritical)
                txtPIN.Clear()
            End If
        End If
    End Sub
End Class