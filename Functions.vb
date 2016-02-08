Imports System.Data.SQLite

Module Functions
    Public dbName As String = "InfoDB"
    'Dim con = New SQLiteConnection("Data Source=" & dbName & ".sqlite;Version=3")
    Dim conDB As String = "Data Source=" & dbName & ".sqlite;Version=3"

    Public Function staLoading(Increase As Integer)
        'Example usage of loading bar:
        'staLoading(10) to make the progress bar increase by.. 10%!
        frmMain.staMain.Visible = True
        frmMain.prgLoad.ProgressBar.Value += Increase
        If (frmMain.prgLoad.ProgressBar.Value >= 100) Then
            'Loading Complete
            frmMain.staMain.Visible = False
            frmMain.prgLoad.ProgressBar.Value = 0
        End If
    End Function

    Public Function CreateDB(name)
        'For now, the creation of the DB will be handled by this client application. 
        'Later, we can make this check happen by the admin application- where the editing of the records will also take place.

        'For ease of use, the default name is "InfoDB". Call the CreateDB function with "" to use default, otherwise give it a name
        If (name <> Nothing) Then
            dbName = name.Trim
        End If

        'Make the DB
        Dim conDB As SQLiteConnection = New SQLiteConnection(dbName & ".sqlite")
        'Make the table
        NewQuery("CREATE TABLE IF NOT EXISTS tblMain (Application VARCHAR(20), Type VARCHAR(20), Location VARCHAR(20))")
    End Function

    Public Function NewQuery(query As String)
        'Query the DB without any return
        Dim con As New SQLiteConnection(conDB)
        con.Open()

        Dim sql As String = query
        Dim cmd1 As SQLiteCommand = New SQLiteCommand(sql, con)
        Try
            cmd1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Function

    Public Function Read(query As String)
        'Function to read the data returned from a query into an array. We do it in a seperate function so that we dont need to open a reader for every query.
        ' Usage:
        ' Dim result As Dictionary(Read(query As String))
        Dim con As New SQLiteConnection(conDB)
        con.Open()

        Dim sql As String = query
        Dim cmd1 As SQLiteCommand = New SQLiteCommand(sql, con)
        Dim reader As SQLiteDataReader = cmd1.ExecuteReader
        Dim result As New ArrayList()

        While reader.Read()
            'Insert each column into our dictionary
            Dim dict As New Dictionary(Of String, Object)
            For count As Integer = 0 To (reader.FieldCount - 1)
                dict.Add(reader.GetName(count), reader(count))
            Next

            'Translate a dictionary to an array
            result.Add(dict)
        End While
        con.Close()

        Return result
    End Function
End Module
