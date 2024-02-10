Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Public Class Form7
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CONSULTA As String
        Dim ODA As New MySqlDataAdapter
        Dim ODS As DataSet
        Dim REGISTRO As Byte
        Dim cmd As New MySqlCommand
        Try
            If BUSCAR.Text <> "" And ComboBox1.Text = "INSTALADA?" Then
                CONSULTA = "SELECT * FROM tobillera WHERE INSTALADA LIKE '%" & BUSCAR.Text & "%' "
                ODA = New MySqlDataAdapter(CONSULTA, conexion)
                ODS = New DataSet
                ODA.Fill(ODS, "tobillera")
                REGISTRO = ODS.Tables("tobillera").Rows.Count
                If REGISTRO <> 0 Then
                    DataGridView1.DataSource = ODS
                    DataGridView1.DataMember = "tobillera"
                    INST.Text = ODS.Tables("tobillera").Rows(0).Item("INSTALADA")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA REGISTRO", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            If BUSCAR.Text <> "" And ComboBox1.Text = "VICTIMA" Then
                CONSULTA = "SELECT * FROM tobillera WHERE NOMBREV LIKE '%" & BUSCAR.Text & "%' "
                ODA = New MySqlDataAdapter(CONSULTA, conexion)
                ODS = New DataSet
                ODA.Fill(ODS, "tobillera")
                REGISTRO = ODS.Tables("tobillera").Rows.Count
                If REGISTRO <> 0 Then
                    DataGridView1.DataSource = ODS
                    DataGridView1.DataMember = "tobillera"
                    INST.Text = ODS.Tables("tobillera").Rows(0).Item("NOMBREV")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA LA VICTIMA", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        direv.Clear()
        dniv.Clear()
        telv.Clear()
        OBSERVACIONES.Clear()
        ID.Enabled = True
        Agregar.Connection = conexion
        Agregar.CommandType = CommandType.Text
        Agregar.CommandText = "Select MAX(Clave_ID) As maximo FROM tobillera"
        maximo = Convert.ToInt32(Agregar.ExecuteScalar()) + 1
        ID.Text = maximo
    End Sub
    Private Sub MOSTRAR()
        Dim ODA As New MySqlDataAdapter
        Dim ODS As New DataSet
        Dim CON As String
        CON = "SELECT *FROM tobillera"
        ODA = New MySqlDataAdapter(CON, conexion)
        ODS.Tables.Add("tobillera")
        ODA.Fill(ODS.Tables("tobillera"))
        DataGridView1.DataSource = ODS.Tables("tobillera")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim maximo As String
        Dim Agregar As New MySqlCommand
        conexion.Close()
        conexion.Open()
        INST.Clear()
        nombrev.Clear()
        edadv.Clear()
        direv.Clear()
        dniv.Clear()
        telv.Clear()
        nombrei.Clear()
        edadi.Clear()
        direi.Clear()
        dnii.Clear()
        teli.Clear()
        OBSERVACIONES.Clear()
        ID.Enabled = True
        Agregar.Connection = conexion
        Agregar.CommandType = CommandType.Text
        Agregar.CommandText = "Select MAX(Clave_ID) As maximo FROM tobillera"
        maximo = Convert.ToInt32(Agregar.ExecuteScalar()) + 1
        ID.Text = maximo
        MOSTRAR()
    End Sub
    Public Sub ELIMINAR()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        MsgBox("¿Desea eliminar registro?", vbYesNo, "Eliminar")
        If vbYes Then
            Dim cmd As New MySqlCommand("DELETE FROM tobillera WHERE Clave_ID=" & Val(Me.ID.Text & ""), conexion)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cons As String
        Dim conexion As MySqlConnection = New MySqlConnection
        conexion.ConnectionString = "Server= windows10.webhosting-network-services.com;  Database = rivgyfco_registro1;  Uid = rivgyfco_rivgyfco ; Pwd = Mozart1592vf@;"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            If (ID.Text <> "" And INST.Text <> "" And nombrev.Text <> "" And edadv.Text <> "" And direv.Text <> "" And dniv.Text <> "" And telv.Text <> "" And nombrei.Text <> "" And edadi.Text <> "" And direi.Text <> "" And dnii.Text <> "" And teli.Text <> "" And OBSERVACIONES.Text <> "") Then
                cons = "INSERT INTO tobillera VALUES('" + ID.Text + "','" + INST.Text + "','" + nombrev.Text + "','" + edadv.Text + "', '" + direv.Text + "', '" + dniv.Text + "', '" + telv.Text + "', '" + nombrei.Text + "','" + edadi.Text + "', '" + direi.Text + "', '" + dnii.Text + "', '" + teli.Text + "', '" + OBSERVACIONES.Text + "')"
                comandos = New MySqlCommand(cons, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Se guardo correctamente", vbInformation, "Aviso")
                INST.Clear()
                nombrev.Clear()
                edadv.Clear()
                direv.Clear()
                dniv.Clear()
                telv.Clear()
                nombrei.Clear()
                edadi.Clear()
                direi.Clear()
                dnii.Clear()
                teli.Clear()
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
        Dim COMANDO As New MySqlCommand
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            ACTUALIZAR = "UPDATE tobillera SET Clave_ID= '" & ID.Text &
"', INSTALADA='" & INST.Text &
"', NOMBREV='" & nombrev.Text &
          "', EDADV='" & edadv.Text &
          "', DIRECCIONV='" & direv.Text &
           "', DNIV='" & dniv.Text &
          "', TELV='" & telv.Text &
    "', NOMBREI='" & nombrei.Text &
          "', EDADI='" & edadi.Text &
          "', DIRECCIONI='" & direi.Text &
           "', DNII='" & dnii.Text &
          "', TELI='" & teli.Text &
          "', OBSERVACIONES='" & OBSERVACIONES.Text &
                    "' WHERE Clave_ID= '" & ID.Text & "' "
            COMANDO = New MySqlCommand(ACTUALIZAR, conexion)
            COMANDO.ExecuteNonQuery()
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim I As Integer
        I = DataGridView1.CurrentRow.Index
        ID.Text = DataGridView1.Item(0, I).Value().ToString()
        INST.Text = DataGridView1.Item(1, I).Value().ToString()
        nombrev.Text = DataGridView1.Item(2, I).Value().ToString()
        edadv.Text = DataGridView1.Item(3, I).Value().ToString()
        direv.Text = DataGridView1.Item(4, I).Value().ToString()
        dniv.Text = DataGridView1.Item(5, I).Value().ToString()
        telv.Text = DataGridView1.Item(6, I).Value().ToString()
        nombrei.Text = DataGridView1.Item(7, I).Value().ToString()
        edadi.Text = DataGridView1.Item(8, I).Value().ToString()
        direi.Text = DataGridView1.Item(9, I).Value().ToString()
        dnii.Text = DataGridView1.Item(10, I).Value().ToString()
        teli.Text = DataGridView1.Item(11, I).Value().ToString()
        OBSERVACIONES.Text = DataGridView1.Item(12, I).Value().ToString()
    End Sub
End Class