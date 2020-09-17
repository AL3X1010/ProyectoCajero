Public Class Form1

    Private Sub NewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAccountToolStripMenuItem.Click
        newaccount.MdiParent = Me
        newaccount.Show()
    End Sub


    Private Sub ToolStripSplitButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.Click
        transaction.MdiParent = Me
        transaction.Show()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        ShowRecordsvb.MdiParent = Me
        ShowRecordsvb.Show()
    End Sub
End Class
