Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl.label_timer()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ctrl.timer()
    End Sub

    Private Sub btn_addemployee_Click(sender As Object, e As EventArgs) Handles btn_addemployee.Click
        NewEmployee.Show()
        Me.Close()

    End Sub
End Class