Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Public Class Form8
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form9.Show()
        Me.Hide()
    End Sub
    Private Sub LIMPIAR()
        ID.Clear()
        nombrev.Clear()
        edadv.Clear()
        FECHADESAP.Clear()
        ANTV.Clear()
        ANTA.Clear()
        FECHAAP.Clear()
        OBSERVACIONES.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CONSULTA As String
        Dim ODA As New MySqlDataAdapter
        Dim ODS As DataSet
        Dim REGISTRO As Byte
        Dim cmd As New MySqlCommand
        If BUSCAR.Text <> "" Then
            CONSULTA = "SELECT * FROM paraderos WHERE NOMBREV LIKE '%" & BUSCAR.Text & "%'"
            ODA = New MySqlDataAdapter(CONSULTA, CONEXION)
            ODS = New DataSet
            ODA.Fill(ODS, "paraderos")
            REGISTRO = ODS.Tables("paraderos").Rows.Count
            If REGISTRO <> 0 Then
                DataGridView1.DataSource = ODS
                DataGridView1.DataMember = "paraderos"
                nombrev.Text = ODS.Tables("paraderos").Rows(0).Item("NOMBREV")
                CONEXION.Close()
            Else
                MsgBox("NO SE ENCONTRO REGISTRO", vbCritical, "ATENCION")
                CONEXION.Close()
            End If
        End If
        Try
            If BUSCAR.Text = "" Then
                MOSTRAR()
                LIMPIAR()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Dim COMAND As New MySqlCommand
    Public Sub ELIMINAR()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        MsgBox("¿Desea eliminar registro?", vbYesNo, "Eliminar")
        If vbYes Then
            Dim cmd As New MySqlCommand("DELETE FROM paraderos WHERE Clave_ID=" & Val(Me.ID.Text & ""), conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Confirmar")
            MOSTRAR()
        End If
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ELIMINAR()
        MOSTRAR()
    End Sub
    Private Sub MOSTRAR()
        Dim ODA As New MySqlDataAdapter
        Dim ODS As New DataSet
        Dim CON As String
        CON = "SELECT * FROM paraderos"
        ODA = New MySqlDataAdapter(CON, conexion)
        ODS.Tables.Add("paraderos")
        ODA.Fill(ODS.Tables("paraderos"))
        DataGridView1.DataSource = ODS.Tables("paraderos")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cons As String
        Dim conexion As MySqlConnection = New MySqlConnection
        conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            If (ID.Text <> "" And nombrev.Text <> "" And edadv.Text <> "" And FECHADESAP.Text <> "" And ANTV.Text <> "" And ANTA.Text <> "" And FECHAAP.Text <> "" And OBSERVACIONES.Text <> "") Then
                cons = "INSERT INTO paraderos VALUES('" + ID.Text + "','" + nombrev.Text + "','" + edadv.Text + "', '" + FECHADESAP.Text + "', '" + ANTV.Text + "', '" + ANTA.Text + "', '" + FECHAAP.Text + "', '" + OBSERVACIONES.Text + "')"
                comandos = New MySqlCommand(cons, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Se guardo correctamente", vbInformation, "Aviso")
                nombrev.Clear()
                edadv.Clear()
                FECHADESAP.Clear()
                ANTV.Clear()
                ANTA.Clear()
                FECHAAP.Clear()
                OBSERVACIONES.Clear()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ACTUALIZAR As String
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            ACTUALIZAR = "UPDATE paraderos SET Clave_ID= '" & ID.Text &
"', NOMBREV='" & nombrev.Text &
          "', EDADV='" & edadv.Text &
          "', FECHADESAP='" & FECHADESAP.Text &
           "', ANTV='" & ANTV.Text &
          "', ANTA='" & ANTA.Text &
           "', FECHAAPA='" & FECHAAP.Text &
          "', OBSERVACIONES='" & OBSERVACIONES.Text &
                    "' WHERE Clave_ID= '" & ID.Text & "' "
            comandos = New MySqlCommand(ACTUALIZAR, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Se modifico correctamente", vbInformation, "AVISO")
            MOSTRAR()
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE MODIFICO", vbCritical, "AVISO")
            conexion.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim maximo As String
        Dim Agregar As New MySqlCommand
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        nombrev.Clear()
        edadv.Clear()
        FECHADESAP.Clear()
        ANTV.Clear()
        ANTA.Clear()
        FECHAAP.Clear()
        OBSERVACIONES.Clear()
        ID.Enabled = True
        Agregar.Connection = conexion
        Agregar.CommandType = CommandType.Text
        Agregar.CommandText = "Select MAX(Clave_ID) As maximo FROM paraderos"
        maximo = Convert.ToInt32(Agregar.ExecuteScalar()) + 1
        ID.Text = maximo
        MOSTRAR()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim I As Integer
        I = DataGridView1.CurrentRow.Index
        ID.Text = DataGridView1.Item(0, I).Value().ToString()
        nombrev.Text = DataGridView1.Item(1, I).Value().ToString()
        edadv.Text = DataGridView1.Item(2, I).Value().ToString()
        FECHADESAP.Text = DataGridView1.Item(3, I).Value().ToString()
        ANTV.Text = DataGridView1.Item(4, I).Value().ToString()
        ANTA.Text = DataGridView1.Item(5, I).Value().ToString()
        FECHAAP.Text = DataGridView1.Item(6, I).Value().ToString()
        OBSERVACIONES.Text = DataGridView1.Item(7, I).Value().ToString()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim maximo As String
        Dim Agregar As New MySqlCommand
        comandos.Connection = conexion
        Try
            conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
            conexion.Open()
            MOSTRAR()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        nombrev.Clear()
        edadv.Clear()
        FECHADESAP.Clear()
        ANTV.Clear()
        ANTA.Clear()
        FECHAAP.Clear()
        OBSERVACIONES.Clear()
        ID.Enabled = True
        Agregar.Connection = conexion
        Agregar.CommandType = CommandType.Text
        Agregar.CommandText = "Select MAX(Clave_ID) As maximo FROM paraderos"
        maximo = Convert.ToInt32(Agregar.ExecuteScalar()) + 1
        ID.Text = maximo
    End Sub
End Class