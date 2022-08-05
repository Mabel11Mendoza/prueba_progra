<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.btnGold = New System.Windows.Forms.Button()
        Me.btnTurquoise = New System.Windows.Forms.Button()
        Me.btnMediumPurple = New System.Windows.Forms.Button()
        Me.btnViolet = New System.Windows.Forms.Button()
        Me.btnGreenYellow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MistyRose
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(442, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Sistema de colores"
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(366, 154)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(422, 269)
        Me.txtColores.TabIndex = 12
        '
        'btnGold
        '
        Me.btnGold.BackColor = System.Drawing.Color.Gold
        Me.btnGold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGold.Location = New System.Drawing.Point(144, 350)
        Me.btnGold.Name = "btnGold"
        Me.btnGold.Size = New System.Drawing.Size(95, 34)
        Me.btnGold.TabIndex = 11
        Me.btnGold.Text = "Dorado"
        Me.btnGold.UseVisualStyleBackColor = False
        '
        'btnTurquoise
        '
        Me.btnTurquoise.BackColor = System.Drawing.Color.Turquoise
        Me.btnTurquoise.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTurquoise.Location = New System.Drawing.Point(144, 289)
        Me.btnTurquoise.Name = "btnTurquoise"
        Me.btnTurquoise.Size = New System.Drawing.Size(95, 34)
        Me.btnTurquoise.TabIndex = 10
        Me.btnTurquoise.Text = "Turquesa"
        Me.btnTurquoise.UseVisualStyleBackColor = False
        '
        'btnMediumPurple
        '
        Me.btnMediumPurple.BackColor = System.Drawing.Color.MediumPurple
        Me.btnMediumPurple.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMediumPurple.Location = New System.Drawing.Point(144, 233)
        Me.btnMediumPurple.Name = "btnMediumPurple"
        Me.btnMediumPurple.Size = New System.Drawing.Size(95, 33)
        Me.btnMediumPurple.TabIndex = 9
        Me.btnMediumPurple.Text = "purpura"
        Me.btnMediumPurple.UseVisualStyleBackColor = False
        '
        'btnViolet
        '
        Me.btnViolet.BackColor = System.Drawing.Color.Violet
        Me.btnViolet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViolet.Location = New System.Drawing.Point(144, 171)
        Me.btnViolet.Name = "btnViolet"
        Me.btnViolet.Size = New System.Drawing.Size(95, 34)
        Me.btnViolet.TabIndex = 8
        Me.btnViolet.Text = "Violeta"
        Me.btnViolet.UseVisualStyleBackColor = False
        '
        'btnGreenYellow
        '
        Me.btnGreenYellow.BackColor = System.Drawing.Color.GreenYellow
        Me.btnGreenYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreenYellow.Location = New System.Drawing.Point(144, 116)
        Me.btnGreenYellow.Name = "btnGreenYellow"
        Me.btnGreenYellow.Size = New System.Drawing.Size(95, 32)
        Me.btnGreenYellow.TabIndex = 7
        Me.btnGreenYellow.Text = "Verde"
        Me.btnGreenYellow.UseVisualStyleBackColor = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnGold)
        Me.Controls.Add(Me.btnTurquoise)
        Me.Controls.Add(Me.btnMediumPurple)
        Me.Controls.Add(Me.btnViolet)
        Me.Controls.Add(Me.btnGreenYellow)
        Me.Name = "form1"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtColores As TextBox
    Friend WithEvents btnGold As Button
    Friend WithEvents btnTurquoise As Button
    Friend WithEvents btnMediumPurple As Button
    Friend WithEvents btnViolet As Button
    Friend WithEvents btnGreenYellow As Button
End Class
