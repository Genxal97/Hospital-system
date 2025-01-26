Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar propiedades del formulario
        Me.Text = "Menú Principal"
        Me.Size = New Size(400, 300)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Etiqueta principal
        Dim Label1 As New Label()
        Label1.Text = "Menú Principal"
        Label1.Font = New Font("Arial", 16, FontStyle.Bold)
        Label1.AutoSize = True
        Label1.Location = New Point(130, 20)
        Me.Controls.Add(Label1)

        ' Etiquetas secundarias
        Dim Label2 As New Label()
        Label2.Text = "Registro de Pacientes"
        Label2.AutoSize = True
        Label2.Location = New Point(50, 80)
        Me.Controls.Add(Label2)

        Dim Label3 As New Label()
        Label3.Text = "Registro de Citas"
        Label3.AutoSize = True
        Label3.Location = New Point(50, 130)
        Me.Controls.Add(Label3)

        Dim Label4 As New Label()
        Label4.Text = "Disponibilidad Médica"
        Label4.AutoSize = True
        Label4.Location = New Point(50, 180)
        Me.Controls.Add(Label4)

        ' Botones
        Dim Button1 As New Button()
        Button1.Text = "Registro de Pacientes"
        Button1.Size = New Size(200, 30)
        Button1.Location = New Point(150, 75)
        AddHandler Button1.Click, AddressOf Button1_Click
        Me.Controls.Add(Button1)

        Dim Button2 As New Button()
        Button2.Text = "Registro de Citas"
        Button2.Size = New Size(200, 30)
        Button2.Location = New Point(150, 125)
        AddHandler Button2.Click, AddressOf Button2_Click
        Me.Controls.Add(Button2)

        Dim Button3 As New Button()
        Button3.Text = "Disponibilidad Médica"
        Button3.Size = New Size(200, 30)
        Button3.Location = New Point(150, 175)
        AddHandler Button3.Click, AddressOf Button3_Click
        Me.Controls.Add(Button3)
    End Sub

    ' Métodos para manejar eventos de los botones
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Navegando al Registro de Pacientes")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Navegando al Registro de Citas")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Navegando a la Disponibilidad Médica")
    End Sub
End Class
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
            button.Name = "Button" & botones(i)
            button.Size = New Size(100, 30)
            button.Location = New Point(xPosButton, yPosButton)
            AddHandler button.Click, AddressOf Button_Click
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
