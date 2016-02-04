Module Functions

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



End Module
