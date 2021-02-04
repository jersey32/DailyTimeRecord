Public Class Controller
    ' Timer in Form1
    Public Sub label_timer()
        Form1.Timer1.Enabled = True
        Dashboard.Timer1.Enabled = True
    End Sub
    Public Sub timer()
        Form1.TimeAndDate.Text = Date.Now.ToString("MM-dd-yyyy  hh:mm:ss")
        Dashboard.TimeAndDate.Text = Date.Now.ToString("MM-dd-yyyy  hh:mm:ss")
    End Sub

    Public Sub add_employee()

    End Sub
End Class
