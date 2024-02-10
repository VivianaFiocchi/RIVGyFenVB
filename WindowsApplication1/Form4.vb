Imports MySql.Data.MySqlClient
Public Class Form4
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form8.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form7.Show()
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Dim maximo As String
        Dim Agregar As New MySqlCommand
        maximo = "SELECT MAX(Clave_ID) as maximo FROM registro"
        Agregar = New MySqlCommand(maximo, conexion)
        Dim RESULTADO As Object
        RESULTADO = Agregar.ExecuteScalar + 1
        CLAVE_ID.Text = RESULTADO.ToString
        nombrev.Enabled = False
        edadv.Enabled = False
        direv.Enabled = False
        dniv.Enabled = False
        telv.Enabled = False
        polv.Enabled = False
        destv.Enabled = False
        jerv.Enabled = False
        legv.Enabled = False
        otrov.Enabled = False
        nombrei.Enabled = False
        edadi.Enabled = False
        direi.Enabled = False
        dnii.Enabled = False
        teli.Enabled = False
        poli.Enabled = False
        desti.Enabled = False
        jeri.Enabled = False
        legi.Enabled = False
        otroi.Enabled = False
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        Dim cons As String
        Dim conexion As MySqlConnection = New MySqlConnection
        conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            If (CLAVE_ID.Text <> "" And FECHA.Text <> "" And CONOCIMIENTO.Text <> "" And CARATULA.Text <> "" And ANTECEDENTES.Text <> "" And ALOJAMIENTO.Text <> "" And GRUPO.Text <> "" And MEDIDA.Text <> "" And CUAL.Text <> "" And OBSME.Text <> "" And EI.Text <> "" And QUIEN.Text <> "" And OBSEI.Text <> "" And BOTON.Text <> "" And OBSBO.Text <> "" And DPG.Text <> "" And OBSDPG.Text <> "" And MINORIDAD.Text <> "" And OBSMI.Text <> "" And SEGUIMIENTO.Text <> "") Then
                cons = "INSERT INTO registro VALUES('" + CLAVE_ID.Text + "','" + FECHA.Text + "','" + CONOCIMIENTO.Text + "', '" + CARATULA.Text + "', '" + ANTECEDENTES.Text + "', '" + ALOJAMIENTO.Text + "' , '" + GRUPO.Text + "', '" + MEDIDA.Text + "', '" + CUAL.Text + "', '" + OBSME.Text + "', '" + EI.Text + "', '" + QUIEN.Text + "', '" + OBSEI.Text + "', '" + BOTON.Text + "', '" + OBSBO.Text + "', '" + DPG.Text + "', '" + OBSDPG.Text + "', '" + MINORIDAD.Text + "', '" + OBSMI.Text + "', '" + SEGUIMIENTO.Text + "')"
                comandos = New MySqlCommand(cons, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Se guardo correctamente", vbInformation, "Aviso")
                nombrev.Enabled = True
                edadv.Enabled = True
                direv.Enabled = True
                dniv.Enabled = True
                telv.Enabled = True
                polv.Enabled = True
                destv.Enabled = True
                jerv.Enabled = True
                legv.Enabled = True
                otrov.Enabled = True
                nombrei.Enabled = True
                edadi.Enabled = True
                direi.Enabled = True
                dnii.Enabled = True
                teli.Enabled = True
                poli.Enabled = True
                desti.Enabled = True
                jeri.Enabled = True
                legi.Enabled = True
                otroi.Enabled = True
            Else
                MessageBox.Show("datos son requeridos")
            End If
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub BTAV_Click(sender As Object, e As EventArgs) Handles BTAV.Click
        Dim cons As String
        Dim conexion As MySqlConnection = New MySqlConnection
        conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            If (CLAVE_ID.Text <> "" And nombrev.Text <> "" And edadv.Text <> "" And direv.Text <> "" And dniv.Text <> "" And telv.Text <> "" And polv.Text <> "" And destv.Text <> "" And jerv.Text <> "" And legv.Text <> "" And otrov.Text <> "") Then
                cons = "INSERT INTO victima VALUES('" + CLAVE_ID.Text + "','" + nombrev.Text + "','" + edadv.Text + "', '" + direv.Text + "', '" + dniv.Text + "', '" + telv.Text + "' , '" + polv.Text + "', '" + destv.Text + "', '" + jerv.Text + "', '" + legv.Text + "', '" + otrov.Text + "')"
                comandos = New MySqlCommand(cons, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Se guardo correctamente", vbInformation, "Aviso")
                nombrev.Clear()
                edadv.Clear()
                direv.Clear()
                dniv.Clear()
                telv.Clear()
                polv.Clear()
                destv.Clear()
                jerv.Clear()
                legv.Clear()
                otrov.Clear()
            Else
                MessageBox.Show("datos son requeridos")
            End If
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BTAI_Click(sender As Object, e As EventArgs) Handles BTAI.Click
        Dim cons As String
        Dim conexion As MySqlConnection = New MySqlConnection
        conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            If (CLAVE_ID.Text <> "" And nombrei.Text <> "" And edadi.Text <> "" And direi.Text <> "" And dnii.Text <> "" And teli.Text <> "" And poli.Text <> "" And desti.Text <> "" And jeri.Text <> "" And legi.Text <> "" And otroi.Text <> "") Then
                cons = "INSERT INTO imputado VALUES('" + CLAVE_ID.Text + "','" + nombrei.Text + "','" + edadi.Text + "', '" + direi.Text + "', '" + dnii.Text + "', '" + teli.Text + "' , '" + poli.Text + "', '" + desti.Text + "', '" + jeri.Text + "', '" + legi.Text + "', '" + otroi.Text + "')"
                comandos = New MySqlCommand(cons, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Se guardo correctamente", vbInformation, "Aviso")
                nombrei.Clear()
                edadi.Clear()
                direi.Clear()
                dnii.Clear()
                teli.Clear()
                poli.Clear()
                desti.Clear()
                jeri.Clear()
                legi.Clear()
                otroi.Clear()
            Else
                MessageBox.Show("datos son requeridos")
            End If
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        FECHA.Clear()
        CONOCIMIENTO.Clear()
        CARATULA.Clear()
        ANTECEDENTES.Clear()
        ALOJAMIENTO.Clear()
        GRUPO.Clear()
        MEDIDA.Clear()
        CUAL.Clear()
        OBSME.Clear()
        EI.Clear()
        QUIEN.Clear()
        OBSEI.Clear()
        BOTON.Clear()
        OBSBO.Clear()
        DPG.Clear()
        OBSDPG.Clear()
        MINORIDAD.Clear()
        OBSMI.Clear()
        SEGUIMIENTO.Clear()
        nombrei.Clear()
        edadi.Clear()
        direi.Clear()
        dnii.Clear()
        teli.Clear()
        poli.Clear()
        desti.Clear()
        jeri.Clear()
        legi.Clear()
        otroi.Clear()
        nombrev.Clear()
        edadv.Clear()
        direv.Clear()
        dniv.Clear()
        telv.Clear()
        polv.Clear()
        destv.Clear()
        jerv.Clear()
        legv.Clear()
        otrov.Clear()
        nombrev.Enabled = False
        edadv.Enabled = False
        direv.Enabled = False
        dniv.Enabled = False
        telv.Enabled = False
        polv.Enabled = False
        destv.Enabled = False
        jerv.Enabled = False
        legv.Enabled = False
        otrov.Enabled = False
        nombrei.Enabled = False
        edadi.Enabled = False
        direi.Enabled = False
        dnii.Enabled = False
        teli.Enabled = False
        poli.Enabled = False
        desti.Enabled = False
        jeri.Enabled = False
        legi.Enabled = False
        otroi.Enabled = False
        CLAVE_ID.Enabled = True
        Dim maximo As String
        Dim Agregar As New MySqlCommand
        maximo = "SELECT MAX(Clave_ID) as maximo FROM registro"
        Agregar = New MySqlCommand(maximo, conexion)
        Dim RESULTADO As Object
        RESULTADO = Agregar.ExecuteScalar + 1
        CLAVE_ID.Text = RESULTADO.ToString
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

End Class