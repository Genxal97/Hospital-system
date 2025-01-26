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

    'NOTE: The following procedure is required by the Windows Form Designer.
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
        Label6 = New Label()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(276, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 30)
        Label1.TabIndex = 0
        Label1.Text = "Registro de Citas"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(421, 244)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(276, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 19)
        Label2.TabIndex = 2
        Label2.Text = "Número de Teléfono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F)
        Label3.ForeColor = Color.DarkSlateGray
        Label3.Location = New Point(331, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 19)
        Label3.TabIndex = 3
        Label3.Text = "Nombre"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(421, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(421, 148)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F)
        Label4.ForeColor = Color.DarkSlateGray
        Label4.Location = New Point(339, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 19)
        Label4.TabIndex = 6
        Label4.Text = "Doctor"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(421, 285)
        DateTimePicker1.MinDate = New Date(2025, 1, 25, 20, 35, 9, 836)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 7
        DateTimePicker1.Value = New Date(2025, 1, 25, 20, 35, 9, 836)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F)
        Label5.ForeColor = Color.DarkSlateGray
        Label5.Location = New Point(309, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 19)
        Label5.TabIndex = 8
        Label5.Text = "Fecha de Cita"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(334, 151)
        Label6.Font = New Font("Segoe UI", 10.0F)
        Label6.ForeColor = Color.DarkSlateGray
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 9
        Label6.Text = "Apellidos"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(421, 202)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 10
        ' 
        ' Citas_Medicas
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
