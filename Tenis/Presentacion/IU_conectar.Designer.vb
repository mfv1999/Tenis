<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ConectarButton = New System.Windows.Forms.Button()
        Me.DefaultTextLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ConectarButton
        '
        Me.ConectarButton.Location = New System.Drawing.Point(101, 79)
        Me.ConectarButton.Name = "ConectarButton"
        Me.ConectarButton.Size = New System.Drawing.Size(257, 102)
        Me.ConectarButton.TabIndex = 0
        Me.ConectarButton.Text = "CONECTAR AL SISTEMA "
        Me.ConectarButton.UseVisualStyleBackColor = True
        '
        'DefaultTextLabel
        '
        Me.DefaultTextLabel.AutoSize = True
        Me.DefaultTextLabel.Location = New System.Drawing.Point(49, 32)
        Me.DefaultTextLabel.Name = "DefaultTextLabel"
        Me.DefaultTextLabel.Size = New System.Drawing.Size(371, 17)
        Me.DefaultTextLabel.TabIndex = 1
        Me.DefaultTextLabel.Text = "Bienvenido al sistema tenis , pulse el boton para comezar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 238)
        Me.Controls.Add(Me.DefaultTextLabel)
        Me.Controls.Add(Me.ConectarButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConectarButton As Button
    Friend WithEvents DefaultTextLabel As Label
End Class
