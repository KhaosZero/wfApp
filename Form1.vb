Public Class frmMain
    'um...test?....I guess.'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        staLoading(10)
    End Sub

    Private Sub mnuStrip_MouseLeave(sender As Object, e As EventArgs) Handles mnuStrip.MouseLeave
        'Mouse is out of the activation range, hide tool bar and shift up
        conMain.SplitterDistance -= mnuStrip.Height
        mnuStrip.Hide()
    End Sub

    Private Sub MenuActivator_MouseEnter(sender As Object, e As EventArgs) Handles MenuActivator.MouseEnter
        'Mouse is in the activation range, show tool bar and shift down
        conMain.SplitterDistance += mnuStrip.Height
        mnuStrip.Show()
        mnuStrip.BringToFront()
    End Sub

    Private Sub mnuStrip_MouseEnter(sender As Object, e As EventArgs) Handles mnuStrip.MouseEnter
        mnuStrip.Visible = True
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("Created By Jane Gallego, and some other random, in Visual Studio" & vbNewLine & "Version: " & Application.ProductVersion, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class
