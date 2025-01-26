Public Class Menu_Principal
    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightGray ' Set the form background to gray
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open Form1 (Registro de Pacientes)
        Dim registroForm As New RegistrodePacientes()
        registroForm.show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create an instance of the Citas_Medicas form
        Dim citasForm As New Citas_Medicas()
        citasForm.Show() ' Show the Citas_Medicas form
        Me.Hide() ' Optionally hide the current form
    End Sub
End Class

