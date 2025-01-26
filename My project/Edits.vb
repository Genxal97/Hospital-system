<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblCondiciones = New System.Windows.Forms.Label()
        Me.clbCondiciones = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()

        ' Label1
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Arial", 16, FontStyle.Bold)
        Me.Label1.ForeColor = Color.DarkBlue
        Me.Label1.Location = New Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(200, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Pacientes"
        Me.Label1.TextAlign = ContentAlignment.MiddleCenter

        ' DateTimePicker1
        Me.DateTimePicker1.Location = New Point(542, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New Size(200, 23)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.MaxDate = DateTime.Now ' Limit to previous dates only

        ' lblFechaNacimiento
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.lblFechaNacimiento.ForeColor = Color.DarkBlue
        Me.lblFechaNacimiento.Location = New Point(578, 71)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New Size(150, 15)
        Me.lblFechaNacimiento.TabIndex = 2
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento"

        ' lblCondiciones
        Me.lblCondiciones.AutoSize = True
        Me.lblCondiciones.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.lblCondiciones.ForeColor = Color.DarkBlue
        Me.lblCondiciones.Location = New Point(577, 139)
        Me.lblCondiciones.Name = "lblCondiciones"
        Me.lblCondiciones.Size = New Size(150, 15)
        Me.lblCondiciones.TabIndex = 3
        Me.lblCondiciones.Text = "Condiciones Médicas"

        ' clbCondiciones
        Me.clbCondiciones.FormattingEnabled = True
        Me.clbCondiciones.Items.AddRange(New Object() {"Diabetes", "Hipertensión", "Alergias", "Asma", "Otras"})
        Me.clbCondiciones.Location = New Point(563, 157)
        Me.clbCondiciones.Name = "clbCondiciones"
        Me.clbCondiciones.Size = New Size(150, 76)
        Me.clbCondiciones.TabIndex = 4

        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clbCondiciones)
        Me.Controls.Add(Me.lblCondiciones)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistroDePacientes"
        Me.Text = "Registro de Pacientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblCondiciones As System.Windows.Forms.Label
    Friend WithEvents clbCondiciones As System.Windows.Forms.CheckedListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Citas_Medicas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(331, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 0
        Label1.Text = "Registro de Citas"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(461, 201)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(331, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 15)
        Label2.TabIndex = 2
        Label2.Text = "Numero de Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(375, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nombre"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(461, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(461, 147)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(383, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 6
        Label4.Text = "Doctor"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(461, 253)
        DateTimePicker1.MinDate = New Date(2025, 1, 25, 20, 35, 9, 836)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 7
        DateTimePicker1.Value = New Date(2025, 1, 25, 20, 35, 9, 836)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(370, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 15)
        Label5.TabIndex = 8
        Label5.Text = "Fecha de cita"
        ' 
        ' Citas_Medicas
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Citas_Medicas"
        Text = "Citas"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value < DateTime.Now Then
            MessageBox.Show("Please select a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Value = DateTime.Now
        End If
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
End Class


ublic Class RegistrodePacientes
    Inherits System.Windows.Forms.Form

    Private Sub RegistrodePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure InitializeComponent is called first
        Me.BackColor = Color.LightGray ' Set the form background to gray
        ' Call the method to add labels dynamically
        AddLabels()
    End Sub

    Private Sub AddLabels()
        ' Array of label texts
        Dim labels() As String = {"Nombre", "Apellidos", "Seguro Social", "Comentarios", "Teléfono", "Correo de electronico", "Dirección Postal"}

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
            txtBox.Location = New Point(150, yPos - 3)
            txtBox.BorderStyle = BorderStyle.FixedSingle

            ' Add the textbox to the form's controls
            Me.Controls.Add(txtBox)

            ' Update yPos for the next label and textbox
            yPos += 30
        Next

        ' Crear botones
        Dim botones() As String = {"Regresar", "Actualizar", "Siguiente"}
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
        Select Case clickedButton.Name
            Case "ButtonRegresar"
                Dim menuForm As New Menu_Principal()
                menuForm.Show()
                Me.Hide()
            Case "ButtonActualizar"
                Dim datos As String = "Datos ingresados:" & Environment.NewLine
                For Each ctrl As Control In Me.Controls
                    If TypeOf ctrl Is TextBox Then
                        Dim txtBox As TextBox = CType(ctrl, TextBox)
                        datos &= txtBox.Name & ": " & txtBox.Text & Environment.NewLine
                    End If
                Next
                MessageBox.Show(datos, "Información Actualizada")
            Case "ButtonSiguiente"
                MessageBox.Show("Navegando a la siguiente página...")
        End Select
    End Sub

End Class

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
        Dim botones() As String = {"Regresar", "Actualizar"}
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
            Case "Actualizar"
                MessageBox.Show("Datos actualizados correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class

Public Class DisponibilidadMedica
    Private Sub DisponibilidadMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial
        ComboBoxMedicos.Items.AddRange(New String() {"Dr. Juan Pérez", "Dra. María López"})
        CheckedListBoxDias.Items.AddRange(New String() {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"})
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim medico As String = ComboBoxMedicos.SelectedItem
        Dim dias As String = String.Join(", ", CheckedListBoxDias.CheckedItems.Cast(Of String)())
        Dim horaInicio As String = DateTimePickerInicio.Value.ToShortTimeString()
        Dim horaFin As String = DateTimePickerFin.Value.ToShortTimeString()

        ' Validación básica
        If String.IsNullOrEmpty(medico) OrElse String.IsNullOrEmpty(dias) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar disponibilidad (puedes reemplazar esto con una base de datos)
        DataGridViewDisponibilidad.Rows.Add(medico, dias, horaInicio, horaFin)
        MessageBox.Show("Disponibilidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
Public Class DisponibilidadMedica
    Private Sub DisponibilidadMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial
        ComboBoxMedicos.Items.AddRange(New String() {"Dr. Juan Pérez", "Dra. María López"})
        CheckedListBoxDias.Items.AddRange(New String() {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"})
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim medico As String = ComboBoxMedicos.SelectedItem
        Dim dias As String = String.Join(", ", CheckedListBoxDias.CheckedItems.Cast(Of String)())
        Dim horaInicio As String = DateTimePickerInicio.Value.ToShortTimeString()
        Dim horaFin As String = DateTimePickerFin.Value.ToShortTimeString()

        ' Validación básica
        If String.IsNullOrEmpty(medico) OrElse String.IsNullOrEmpty(dias) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar disponibilidad (puedes reemplazar esto con una base de datos)
        DataGridViewDisponibilidad.Rows.Add(medico, dias, horaInicio, horaFin)
        MessageBox.Show("Disponibilidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
