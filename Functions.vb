Module Functions

    Public Function staLoading(Increase As Integer)
        'Example usage of loading bar:
        'frmMain.prgLoad.PerformStep() 'Where PerformStep() is the value of step
        frmMain.staMain.Visible = True
        frmMain.prgLoad.ProgressBar.Value += Increase
        If (frmMain.prgLoad.ProgressBar.Value >= 100) Then
            'Loading Complete
            frmMain.staMain.Visible = False
        End If
    End Function



End Module
