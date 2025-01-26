
Public Class RegistrodePacientes
    Inherits System.Windows.Forms.Form
    Private Sub RegistrodePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Ensure InitializeComponent is called first
            Me.BackColor = Color.LightGray ' Set the form background to gray
            ' Call the method to add labels dynamically
            AddLabels()
        End Sub

        Private Sub AddLabels()
            ' Array of label texts
            Dim labels() As String = {"Nombre", "Apellidos", "Seguro Social", "Teléfono", "Correo de electronico", "Dirección Postal", "Comentarios"}

            ' Starting position for the labels and textboxes
            Dim yPos As Integer = 20

            ' Loop through each text to create styled labels and textboxes
            For Each labelText As String In labels
                ' Create a new label
                Dim lbl As New Label()

                ' Set label properties to enhance appearance
                lbl.Text = labelText
                lbl.AutoSize = True
                lbl.Font = New Font("Arial", 10, FontStyle.Bold)
                lbl.ForeColor = Color.DarkBlue
                lbl.Location = New Point(20, yPos)

                ' Add the label to the form's controls
                Me.Controls.Add(lbl)

                ' Create a corresponding textbox
                Dim txtBox As New TextBox()
                txtBox.Name = "TextBox" & labelText.Replace(" ", "")
                txtBox.Size = New Size(200, 20)
                txtBox.Location = New Point(20, yPos + 25) ' Position textbox below label
                txtBox.BorderStyle = BorderStyle.FixedSingle

                ' Set specific properties for numeric-only fields
                If labelText = "Seguro Social" OrElse labelText = "Teléfono" Then
                    AddHandler txtBox.KeyPress, AddressOf NumericTextBox_KeyPress
                End If

                ' Add the textbox to the form's controls
                Me.Controls.Add(txtBox)

                ' Update yPos for the next label and textbox
                yPos += 60 ' Increase spacing to accommodate label and textbox
            Next

            ' Crear botones
            Dim botones() As String = {"Regresar", "Guardar"}
            Dim xPosButton As Integer = 20
            Dim yPosButton As Integer = yPos + 20 ' Position buttons below the last label and textbox
            For i As Integer = 0 To botones.Length - 1
                Dim button As New Button()
                button.Text = botones(i)
                button.Name = "Button" & botones(i) ' ButtonRegresar or ButtonGuardar
                button.Size = New Size(100, 30)
                button.Location = New Point(xPosButton, yPosButton)
                AddHandler button.Click, AddressOf Button_Click ' Attach the click event
                Me.Controls.Add(button)
                xPosButton += 120 ' Space buttons horizontally
            Next
        End Sub

        Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
            ' Allow only digits and control keys (e.g., backspace)
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End Sub

        Private Sub Button_Click(sender As Object, e As EventArgs)
            Dim clickedButton As Button = CType(sender, Button)
            Select Case clickedButton.Name
                Case "ButtonRegresar"
                    Dim menuForm As New Menu_Principal()
                    menuForm.Show()
                    Me.Hide()
                Case "ButtonGuardar"
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
        End Sub
    End Class






