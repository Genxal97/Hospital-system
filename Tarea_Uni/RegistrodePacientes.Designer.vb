<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrodePacientes
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

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        lblFechaNacimiento = New Label()
        lblCondiciones = New Label()
        clbCondiciones = New CheckedListBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 16.0F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(287, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 26)
        Label1.TabIndex = 0
        Label1.Text = "Registro de Pacientes"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(298, 115)
        DateTimePicker1.MaxDate = New Date(2025, 1, 24, 22, 45, 25, 781)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 1
        DateTimePicker1.Value = New Date(2025, 1, 24, 22, 45, 25, 781)
        ' 
        ' lblFechaNacimiento
        ' 
        lblFechaNacimiento.AutoSize = True
        lblFechaNacimiento.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        lblFechaNacimiento.ForeColor = Color.DarkBlue
        lblFechaNacimiento.Location = New Point(322, 96)
        lblFechaNacimiento.Name = "lblFechaNacimiento"
        lblFechaNacimiento.Size = New Size(154, 16)
        lblFechaNacimiento.TabIndex = 2
        lblFechaNacimiento.Text = "Fecha de Nacimiento"
        ' 
        ' lblCondiciones
        ' 
        lblCondiciones.AutoSize = True
        lblCondiciones.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        lblCondiciones.ForeColor = Color.DarkBlue
        lblCondiciones.Location = New Point(322, 167)
        lblCondiciones.Name = "lblCondiciones"
        lblCondiciones.Size = New Size(157, 16)
        lblCondiciones.TabIndex = 3
        lblCondiciones.Text = "Condiciones Médicas"
        ' 
        ' clbCondiciones
        ' 
        clbCondiciones.FormattingEnabled = True
        clbCondiciones.Items.AddRange(New Object() {"Diabetes", "Hipertensión", "Alergias", "Asma", "Otras"})
        clbCondiciones.Location = New Point(326, 199)
        clbCondiciones.Name = "clbCondiciones"
        clbCondiciones.Size = New Size(150, 76)
        clbCondiciones.TabIndex = 4
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(326, 297)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 19)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(403, 297)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 19)
        RadioButton2.TabIndex = 6
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RegistrodePacientes
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(clbCondiciones)
        Controls.Add(lblCondiciones)
        Controls.Add(lblFechaNacimiento)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        Name = "RegistrodePacientes"
        Text = "Registro de Pacientes"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblCondiciones As System.Windows.Forms.Label
    Friend WithEvents clbCondiciones As System.Windows.Forms.CheckedListBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class

