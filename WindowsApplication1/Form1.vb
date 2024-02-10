Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comandos.Connection = conexion
        'probar conexion'
        Try
            conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
            conexion.Open()
            MsgBox("BIENVENIDO A RIVGyF", vbInformation, "CONEXION EXITOSA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String
        Dim lista As Byte
        If usuario.Text = "COORDMDP" And contraseña.Text = "1992MDP" Then
            consulta = "SELECT * FROM login WHERE usuario = '" & usuario.Text & "' and contraseña= '" & contraseña.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "login")
            lista = datos.Tables("login").Rows.Count
            contraseña.Clear()
            Form2.Show()
            Me.Hide()
        ElseIf usuario.Text = "EQUIPO" And contraseña.Text = "EQUI21" Then
            consulta = "SELECT * FROM login WHERE usuario = '" & usuario.Text & "' and contraseña= '" & contraseña.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "login")
            lista = datos.Tables("login").Rows.Count
            contraseña.Clear()
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña invalida", vbCritical, "ERROR")
            contraseña.Clear()
            conexion.Close()
        End If
        conexion.Close()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form10.Show()
        Me.Hide()
    End Sub
End Class
