<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BUSCAR = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OBSSU = New System.Windows.Forms.RichTextBox()
        Me.ENVIA = New System.Windows.Forms.TextBox()
        Me.ASIGNADO = New System.Windows.Forms.TextBox()
        Me.RECIBE = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.NUMERO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SUCESO", "OBSERVACIONES"})
        Me.ComboBox1.Location = New System.Drawing.Point(169, 357)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 391
        '
        'BUSCAR
        '
        Me.BUSCAR.Location = New System.Drawing.Point(305, 357)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(169, 20)
        Me.BUSCAR.TabIndex = 390
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Bisque
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(77, 395)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(487, 106)
        Me.DataGridView1.TabIndex = 383
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(86, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 382
        Me.Label5.Text = "OBSERVACIONES:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(86, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 13)
        Me.Label4.TabIndex = 381
        Me.Label4.Text = "FECHA EN LA QUE SE ENVIA A LA SPG:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(86, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 380
        Me.Label3.Text = "PROFESIONAL ASIGNADO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(86, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 13)
        Me.Label2.TabIndex = 379
        Me.Label2.Text = "FECHA QUE SE RECIBE POR LA SPG:"
        '
        'OBSSU
        '
        Me.OBSSU.Location = New System.Drawing.Point(89, 227)
        Me.OBSSU.Name = "OBSSU"
        Me.OBSSU.Size = New System.Drawing.Size(427, 96)
        Me.OBSSU.TabIndex = 378
        Me.OBSSU.Text = ""
        '
        'ENVIA
        '
        Me.ENVIA.Location = New System.Drawing.Point(297, 167)
        Me.ENVIA.Name = "ENVIA"
        Me.ENVIA.Size = New System.Drawing.Size(144, 20)
        Me.ENVIA.TabIndex = 377
        '
        'ASIGNADO
        '
        Me.ASIGNADO.Location = New System.Drawing.Point(297, 126)
        Me.ASIGNADO.Name = "ASIGNADO"
        Me.ASIGNADO.Size = New System.Drawing.Size(259, 20)
        Me.ASIGNADO.TabIndex = 376
        '
        'RECIBE
        '
        Me.RECIBE.Location = New System.Drawing.Point(297, 85)
        Me.RECIBE.Name = "RECIBE"
        Me.RECIBE.Size = New System.Drawing.Size(144, 20)
        Me.RECIBE.TabIndex = 375
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(666, 5)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(37, 30)
        Me.ID.TabIndex = 374
        '
        'NUMERO
        '
        Me.NUMERO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUMERO.Location = New System.Drawing.Point(456, 5)
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.Size = New System.Drawing.Size(192, 30)
        Me.NUMERO.TabIndex = 373
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 27)
        Me.Label1.TabIndex = 372
        Me.Label1.Text = "CATE 911 - SUCESO NRO:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(492, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 46)
        Me.Button1.TabIndex = 388
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Indigo
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(609, 448)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(57, 46)
        Me.Button6.TabIndex = 387
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RIVGyF.My.Resources.Resources.nota_papel_sobre_fondo_memphis_53876_99285
        Me.ClientSize = New System.Drawing.Size(720, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BUSCAR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OBSSU)
        Me.Controls.Add(Me.ENVIA)
        Me.Controls.Add(Me.ASIGNADO)
        Me.Controls.Add(Me.RECIBE)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.NUMERO)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form16"
        Me.Text = "CATE 911 - SUCESOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BUSCAR As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OBSSU As System.Windows.Forms.RichTextBox
    Friend WithEvents ENVIA As System.Windows.Forms.TextBox
    Friend WithEvents ASIGNADO As System.Windows.Forms.TextBox
    Friend WithEvents RECIBE As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents NUMERO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
