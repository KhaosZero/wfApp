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

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'The About... sub menu within the toolbar can go here
        MessageBox.Show("Created By Jane Gallego, and some other random, in Visual Studio" & vbNewLine & "Version: " & Application.ProductVersion, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub mnuLog_Click(sender As Object, e As EventArgs) Handles mnuLog.Click
        'Changes post-release will go here.
        MessageBox.Show("Heh.. a Changelog? You're funny.", "Changelog", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: 
        '- Make function that will accept a query and execute it: 
        'Public Function NewQuery(query As String)
        '- Make a function that will open a reader and return the read data:
        'Public Function Read(query As String)
        '- Move all this crap from button code

        'So here's what we do for now:
        'Creating the connection AND the database at the same time
        Dim conDB As SQLiteConnection = New SQLiteConnection("InfoDB.sqlite") '<- Database
        'Create datasource connection
        Dim con = New SQLiteConnection("Data Source=InfoDB.sqlite;Version=3")
        'Now OPEN
        con.Open()
        'Create query to execute, this query makes the table
        Dim sql As String = "CREATE TABLE IF NOT EXISTS tblMain (Application VARCHAR(20), Type VARCHAR(20), Location VARCHAR(20))"

        'Create our commands using the connection and the sql query
        Dim cmd1 As SQLiteCommand = New SQLiteCommand(sql, con)
        'Execute
        Try
            cmd1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'Lets make a new query to insert some test data
        sql = "INSERT INTO tblMain (Application, Type, Location) values ('Netcare', 'Employee', 'RAH')"
        Dim cmd2 As SQLiteCommand = New SQLiteCommand(sql, con)
        cmd2.ExecuteNonQuery()

        'Make another query to ask the table for data
        sql = "SELECT * FROM tblMain order by Application ASC"
        Dim cmd3 As SQLiteCommand = New SQLiteCommand(sql, con)

        'Make the reader to read the reply from the above query
        Dim reader As SQLiteDataReader = cmd3.ExecuteReader
        'Just incase
        lstInput.Items.Clear()

        'Now we read the data into the listbox
        While (reader.Read())
            lstInput.Items.Add("Application:   " & reader("Application"))
            lstInput.Items.Add("Type:   " & reader("Type"))
            lstInput.Items.Add("Location:   " & reader("Location"))
        End While

        'For testing, we dont want to keep the table on app close.
        sql = "DROP TABLE IF EXISTS tblMain"
        Dim cmd4 As SQLiteCommand = New SQLiteCommand(sql, con)
        cmd4.ExecuteNonQuery()

        'Dont forget to close the connection!
        con.Close()

        'So we have effectively Created a database, a table, test data, and read it all to a listbox using one button.
        'Go Visual Studio!
    End Sub
End Class
