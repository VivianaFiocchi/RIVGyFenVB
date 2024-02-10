<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim NOMBRE_Y_APELLIDO_VLabel As System.Windows.Forms.Label
        Dim EDAD_VLabel As System.Windows.Forms.Label
        Dim DIRECCION_VLabel As System.Windows.Forms.Label
        Dim DNI_VLabel As System.Windows.Forms.Label
        Dim TELEFONO_VLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BUSCAR = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OBSERVACIONES = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombrev = New System.Windows.Forms.TextBox()
        Me.edadv = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FECHADESAP = New System.Windows.Forms.MaskedTextBox()
        Me.FECHAAP = New System.Windows.Forms.MaskedTextBox()
        Me.ANTV = New System.Windows.Forms.RichTextBox()
        Me.ANTA = New System.Windows.Forms.RichTextBox()
        NOMBRE_Y_APELLIDO_VLabel = New System.Windows.Forms.Label()
        EDAD_VLabel = New System.Windows.Forms.Label()
        DIRECCION_VLabel = New System.Windows.Forms.Label()
        DNI_VLabel = New System.Windows.Forms.Label()
        TELEFONO_VLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRE_Y_APELLIDO_VLabel
        '
        NOMBRE_Y_APELLIDO_VLabel.AutoSize = True
        NOMBRE_Y_APELLIDO_VLabel.BackColor = System.Drawing.Color.Transparent
        NOMBRE_Y_APELLIDO_VLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRE_Y_APELLIDO_VLabel.Location = New System.Drawing.Point(66, 275)
        NOMBRE_Y_APELLIDO_VLabel.Name = "NOMBRE_Y_APELLIDO_VLabel"
        NOMBRE_Y_APELLIDO_VLabel.Size = New System.Drawing.Size(140, 13)
        NOMBRE_Y_APELLIDO_VLabel.TabIndex = 341
        NOMBRE_Y_APELLIDO_VLabel.Text = "NOMBRE Y APELLIDO:"
        '
        'EDAD_VLabel
        '
        EDAD_VLabel.AutoSize = True
        EDAD_VLabel.BackColor = System.Drawing.Color.Transparent
        EDAD_VLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EDAD_VLabel.Location = New System.Drawing.Point(67, 301)
        EDAD_VLabel.Name = "EDAD_VLabel"
        EDAD_VLabel.Size = New System.Drawing.Size(45, 13)
        EDAD_VLabel.TabIndex = 343
        EDAD_VLabel.Text = "EDAD:"
        '
        'DIRECCION_VLabel
        '
        DIRECCION_VLabel.AutoSize = True
        DIRECCION_VLabel.BackColor = System.Drawing.Color.Transparent
        DIRECCION_VLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DIRECCION_VLabel.Location = New System.Drawing.Point(66, 327)
        DIRECCION_VLabel.Name = "DIRECCION_VLabel"
        DIRECCION_VLabel.Size = New System.Drawing.Size(147, 13)
        DIRECCION_VLabel.TabIndex = 345
        DIRECCION_VLabel.Text = "FECHA DESAPARICION:"
        '
        'DNI_VLabel
        '
        DNI_VLabel.AutoSize = True
        DNI_VLabel.BackColor = System.Drawing.Color.Transparent
        DNI_VLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNI_VLabel.Location = New System.Drawing.Point(67, 357)
        DNI_VLabel.Name = "DNI_VLabel"
        DNI_VLabel.Size = New System.Drawing.Size(424, 13)
        DNI_VLabel.TabIndex = 347
        DNI_VLabel.Text = "ANTECEDENTES DENUNCIAS VIOLENCIA DE GENERO Y/O FAMILIAR :"
        '
        'TELEFONO_VLabel
        '
        TELEFONO_VLabel.AutoSize = True
        TELEFONO_VLabel.BackColor = System.Drawing.Color.Transparent
        TELEFONO_VLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TELEFONO_VLabel.Location = New System.Drawing.Point(66, 392)
        TELEFONO_VLabel.Name = "TELEFONO_VLabel"
        TELEFONO_VLabel.Size = New System.Drawing.Size(423, 13)
        TELEFONO_VLabel.TabIndex = 349
        TELEFONO_VLabel.Text = "ANTEEDENTES DE DENUNCIAS POR AVERIGUCAION DE PARADEROS"
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(223, 192)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(45, 26)
        Me.ID.TabIndex = 358
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Indigo
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(585, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 46)
        Me.Button3.TabIndex = 357
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(686, 122)
        Me.DataGridView1.TabIndex = 356
        '
        'BUSCAR
        '
        Me.BUSCAR.Location = New System.Drawing.Point(139, 26)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(372, 20)
        Me.BUSCAR.TabIndex = 355
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(517, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 46)
        Me.Button1.TabIndex = 354
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 353
        Me.Label3.Text = "OBSERVACIONES"
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.Location = New System.Drawing.Point(201, 459)
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.Size = New System.Drawing.Size(519, 68)
        Me.OBSERVACIONES.TabIndex = 352
        Me.OBSERVACIONES.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 27)
        Me.Label1.TabIndex = 351
        Me.Label1.Text = "DATOS PERSONALES VICTIMA"
        '
        'nombrev
        '
        Me.nombrev.Location = New System.Drawing.Point(212, 272)
        Me.nombrev.Multiline = True
        Me.nombrev.Name = "nombrev"
        Me.nombrev.Size = New System.Drawing.Size(343, 20)
        Me.nombrev.TabIndex = 342
        '
        'edadv
        '
        Me.edadv.Location = New System.Drawing.Point(214, 298)
        Me.edadv.Name = "edadv"
        Me.edadv.Size = New System.Drawing.Size(48, 20)
        Me.edadv.TabIndex = 344
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Indigo
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(240, 544)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 46)
        Me.Button5.TabIndex = 361
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Indigo
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(378, 544)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 46)
        Me.Button4.TabIndex = 360
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Indigo
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(307, 544)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 46)
        Me.Button2.TabIndex = 359
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(199, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 362
        Me.Label2.Text = "ID"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Indigo
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(455, 544)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(57, 46)
        Me.Button6.TabIndex = 363
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 429)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 364
        Me.Label4.Text = "FECHA DE APARICION:"
        '
        'FECHADESAP
        '
        Me.FECHADESAP.Location = New System.Drawing.Point(214, 324)
        Me.FECHADESAP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FECHADESAP.Mask = "00/00/0000"
        Me.FECHADESAP.Name = "FECHADESAP"
        Me.FECHADESAP.Size = New System.Drawing.Size(76, 20)
        Me.FECHADESAP.TabIndex = 365
        Me.FECHADESAP.ValidatingType = GetType(Date)
        '
        'FECHAAP
        '
        Me.FECHAAP.Location = New System.Drawing.Point(214, 426)
        Me.FECHAAP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FECHAAP.Mask = "00/00/0000"
        Me.FECHAAP.Name = "FECHAAP"
        Me.FECHAAP.Size = New System.Drawing.Size(76, 20)
        Me.FECHAAP.TabIndex = 366
        Me.FECHAAP.ValidatingType = GetType(Date)
        '
        'ANTV
        '
        Me.ANTV.Location = New System.Drawing.Point(494, 345)
        Me.ANTV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ANTV.Name = "ANTV"
        Me.ANTV.Size = New System.Drawing.Size(220, 33)
        Me.ANTV.TabIndex = 367
        Me.ANTV.Text = ""
        '
        'ANTA
        '
        Me.ANTA.Location = New System.Drawing.Point(494, 383)
        Me.ANTA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ANTA.Name = "ANTA"
        Me.ANTA.Size = New System.Drawing.Size(220, 32)
        Me.ANTA.TabIndex = 368
        Me.ANTA.Text = ""
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RIVGyF.My.Resources.Resources._749d3e9529712210a77ee9725a9fa957_fondo_abstracto_colorido_de_ondas_y_espirales
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.ANTA)
        Me.Controls.Add(Me.ANTV)
        Me.Controls.Add(Me.FECHAAP)
        Me.Controls.Add(Me.FECHADESAP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BUSCAR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OBSERVACIONES)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NOMBRE_Y_APELLIDO_VLabel)
        Me.Controls.Add(Me.nombrev)
        Me.Controls.Add(EDAD_VLabel)
        Me.Controls.Add(Me.edadv)
        Me.Controls.Add(DIRECCION_VLabel)
        Me.Controls.Add(DNI_VLabel)
        Me.Controls.Add(TELEFONO_VLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.Text = "AV DE PARADEROS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BUSCAR As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OBSERVACIONES As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombrev As System.Windows.Forms.TextBox
    Friend WithEvents edadv As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FECHADESAP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FECHAAP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ANTV As System.Windows.Forms.RichTextBox
    Friend WithEvents ANTA As System.Windows.Forms.RichTextBox
End Class
