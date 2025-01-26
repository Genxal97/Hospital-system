<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Principal
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.Label3 = New Label()
        Me.Label4 = New Label()
        Me.Button1 = New Button()
        Me.Button2 = New Button()
        Me.Button3 = New Button()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Arial", 16.0F, FontStyle.Bold)
        Me.Label1.Location = New Point(305, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(161, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menú Principal"
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Arial", 16.0F, FontStyle.Bold)
        Me.Label2.Location = New Point(35, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(235, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registro de Pacientes"
        ' 
        ' Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Arial", 16.0F, FontStyle.Bold)
        Me.Label3.Location = New Point(290, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(187, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Registro de Citas"
        ' 
        ' Label4
        ' 
        Me.Label4.AutoSize = True
        Me.Label4.Font = New Font("Arial", 16.0F, FontStyle.Bold)
        Me.Label4.Location = New Point(490, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(232, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Disponibilidad Médica"
        ' 
        ' Button1
        ' 
        Me.Button1.Location = New Point(53, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(200, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Registro de Pacientes"
        ' 
        ' Button2
        ' 
        Me.Button2.Location = New Point(290, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(200, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Registro de Citas"
        ' 
        ' Button3
        ' 
        Me.Button3.Location = New Point(507, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New Size(200, 30)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Disponibilidad Médica"
        ' 
        ' Menu_Principal
        ' 
        Me.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu_Principal"
        Me.Text = "Sistema Medico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class

