Public Class Citas_Medicas
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Allow only digits, backspace, spaces, hyphens, and parentheses
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> "("c AndAlso e.KeyChar <> ")"c Then
            e.Handled = True ' Disallow the character
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Citas_Medicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create buttons dynamically
        Dim botones() As String = {"Regresar", "Guardar"}
        Dim xPosButton As Integer = 100
        For i As Integer = 0 To botones.Length - 1
            Dim button As New Button()
            button.Text = botones(i)
            button.Name = "Button" & botones(i)
            button.Size = New Size(100, 30)
            button.Location = New Point(xPosButton, 400)
            AddHandler button.Click, AddressOf Button_Click
            Me.Controls.Add(button)
            xPosButton += 150
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Select Case clickedButton.Text
            Case "Regresar"
                Dim menuForm As New Menu_Principal()
                menuForm.Show()
                Me.Hide()
            Case "Guardar"
                SaveData()
        End Select
    End Sub

    Private Sub SaveData()
        Dim datos As String = "Datos guardados:" & Environment.NewLine
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = CType(ctrl, TextBox)
                datos &= txtBox.Name & ": " & txtBox.Text & Environment.NewLine
            End If
        Next
        MessageBox.Show(datos, "Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Here, you can add functionality to save the data to a file, database, etc.
    End Sub
End Class


