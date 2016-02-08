Imports System.Data.SQLite

Public Class frmMain
    'um...test?....I guess.'


    Private Sub mnuStrip_MouseLeave(sender As Object, e As EventArgs) Handles mnuStrip.MouseLeave
        'Mouse is out of the activation range, hide tool bar and shift up
        conMain.SplitterDistance -= mnuStrip.Height
        mnuStrip.Hide()
    End Sub

    Private Sub MenuActivator_MouseEnter(sender As Object, e As EventArgs) Handles MenuActivator.MouseEnter
        'Mouse is in the the bounds of the menu activator (an invisible button), show tool bar and shift everything down
        conMain.SplitterDistance += mnuStrip.Height
        mnuStrip.Show()
        mnuStrip.BringToFront()
    End Sub

    Private Sub mnuStrip_MouseEnter(sender As Object, e As EventArgs) Handles mnuStrip.MouseEnter
        'If the mouse is within the bounds of the menu strip at the top, keep it visible!
        mnuStrip.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Make a new database
        CreateDB("")
        'Lets insert some test data
        NewQuery("INSERT INTO tblMain (Application, Type, Location) values ('Netcare', 'Employee', 'RAH')")

        'Just incase
        lstInput.Items.Clear()

        'Now we read the data into the listbox, we can use our awesome read function!
        For Each dat As Dictionary(Of String, Object) In Read("SELECT * FROM tblMain order by Application ASC")
            lstInput.Items.Add("Application:   " & dat("Application"))
            lstInput.Items.Add("Type:   " & dat("Type"))
            lstInput.Items.Add("Location:   " & dat("Location"))
        Next

        'For testing, we dont want to keep the table on app close.
        NewQuery("DROP TABLE IF EXISTS tblMain")

        'So we have effectively Created a database, a table, test data, and read it all to a listbox using one button.
        'Go Visual Studio!
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        MessageBox.Show("Created By Jane Gallego, and some other random, in Visual Studio" & vbNewLine & "Version: " & Application.ProductVersion, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ChangelogToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem1.Click
        MessageBox.Show("There are no changes to log yet :/", "Changelog", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
