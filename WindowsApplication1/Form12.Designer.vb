<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ELI = New System.Windows.Forms.Button()
        Me.CLAVE_ID = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BUSCAR = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Enabled = False
        IdLabel.Font = New System.Drawing.Font("Century", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(475, 52)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(53, 33)
        IdLabel.TabIndex = 372
        IdLabel.Text = "Id:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 122)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(952, 449)
        Me.DataGridView1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(47, 615)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 47)
        Me.Button5.TabIndex = 364
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ELI
        '
        Me.ELI.BackgroundImage = CType(resources.GetObject("ELI.BackgroundImage"), System.Drawing.Image)
        Me.ELI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ELI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ELI.Location = New System.Drawing.Point(112, 615)
        Me.ELI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ELI.Name = "ELI"
        Me.ELI.Size = New System.Drawing.Size(63, 47)
        Me.ELI.TabIndex = 371
        Me.ELI.UseVisualStyleBackColor = True
        '
        'CLAVE_ID
        '
        Me.CLAVE_ID.Enabled = False
        Me.CLAVE_ID.Font = New System.Drawing.Font("Century", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLAVE_ID.Location = New System.Drawing.Point(540, 48)
        Me.CLAVE_ID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CLAVE_ID.Name = "CLAVE_ID"
        Me.CLAVE_ID.Size = New System.Drawing.Size(87, 40)
        Me.CLAVE_ID.TabIndex = 373
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"05/20 al 05/21", "06/21 en adelante"})
        Me.ComboBox1.Location = New System.Drawing.Point(47, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 24)
        Me.ComboBox1.TabIndex = 374
        '
        'BUSCAR
        '
        Me.BUSCAR.BackColor = System.Drawing.Color.Transparent
        Me.BUSCAR.BackgroundImage = CType(resources.GetObject("BUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BUSCAR.FlatAppearance.BorderSize = 0
        Me.BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BUSCAR.Location = New System.Drawing.Point(196, 38)
        Me.BUSCAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(71, 47)
        Me.BUSCAR.TabIndex = 375
        Me.BUSCAR.UseVisualStyleBackColor = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RIVGyF.My.Resources.Resources._41384824_pink_abstract_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 677)
        Me.ControlBox = False
        Me.Controls.Add(Me.BUSCAR)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CLAVE_ID)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.ELI)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form12"
        Me.Text = "VER TODOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ELI As System.Windows.Forms.Button
    Friend WithEvents CLAVE_ID As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BUSCAR As System.Windows.Forms.Button
End Class
