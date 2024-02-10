Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Public Class Form15
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ID.Clear()
        NUMERO.Clear()
        RECIBE.Clear()
        ASIGNADO.Clear()
        ENVIA.Clear()
        OBSSU.Clear()
        ID.Enabled = True
        Agregar.Connection = conexion
        Agregar.CommandType = CommandType.Text
        Agregar.CommandText = "Select MAX(ID) As maximo FROM sucesos"
        maximo = Convert.ToInt32(Agregar.ExecuteScalar()) + 1
        ID.Text = maximo
    End Sub

    Private Sub LIMPIAR()
        ID.Clear()
        NUMERO.Clear()
        RECIBE.Clear()
        ASIGNADO.Clear()
        ENVIA.Clear()
        OBSSU.Clear()
    End Sub
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
            If BUSCAR.Text <> "" And ComboBox1.Text = "OBSERVACIONES" Then
                CONSULTA = "SELECT * FROM sucesos WHERE OBSERVACIONES LIKE '%" & BUSCAR.Text & "%' "
                ODA = New MySqlDataAdapter(CONSULTA, conexion)
                ODS = New DataSet
                ODA.Fill(ODS, "sucesos")
                REGISTRO = ODS.Tables("sucesos").Rows.Count
                If REGISTRO <> 0 Then
                    DataGridView1.DataSource = ODS
                    DataGridView1.DataMember = "sucesos"
                    NUMERO.Text = ODS.Tables("sucesos").Rows(0).Item("SUCESO")
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
            If BUSCAR.Text <> "" And ComboBox1.Text = "SUCESO" Then
                CONSULTA = "SELECT * FROM sucesos WHERE SUCESO LIKE '%" & BUSCAR.Text & "%' "
                ODA = New MySqlDataAdapter(CONSULTA, conexion)
                ODS = New DataSet
                ODA.Fill(ODS, "sucesos")
                REGISTRO = ODS.Tables("sucesos").Rows.Count
                If REGISTRO <> 0 Then
                    DataGridView1.DataSource = ODS
                    DataGridView1.DataMember = "sucesos"
                    NUMERO.Text = ODS.Tables("sucesos").Rows(0).Item("SUCESO")
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
    Dim COMAND As New MySqlCommand
    Private Sub MOSTRAR()
        Dim ODA As New MySqlDataAdapter
        Dim ODS As New DataSet
        Dim CON As String
        CON = "SELECT *FROM sucesos"
        ODA = New MySqlDataAdapter(CON, conexion)
        ODS.Tables.Add("sucesos")
        ODA.Fill(ODS.Tables("sucesos"))
        DataGridView1.DataSource = ODS.Tables("sucesos")
    End Sub
    Public Sub ELIMINAR()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        MsgBox("¿Desea eliminar registro?", vbYesNo, "Eliminar")
        If vbYes Then
            Dim cmd As New MySqlCommand("DELETE FROM sucesos WHERE ID=" & Val(Me.ID.Text & ""), conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Confirmar")
            MOSTRAR()
        End If
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cons As String
        Dim conexion As MySqlConnection = New MySqlConnection
        conexion.ConnectionString = "Server= windows10.webhosting-network-services.com;  Database = rivgyfco_registro1;  Uid = rivgyfco_rivgyfco ; Pwd = Mozart1592vf@;"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            If (ID.Text <> "" And NUMERO.Text <> "" And RECIBE.Text <> "" And ASIGNADO.Text <> "" And ENVIA.Text <> "" And OBSSU.Text <> "") Then
                cons = "INSERT INTO sucesos VALUES('" + ID.Text + "','" + NUMERO.Text + "','" + RECIBE.Text + "', '" + ASIGNADO.Text + "', '" + ENVIA.Text + "', '" + OBSSU.Text + "')"
                comandos = New MySqlCommand(cons, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Se guardo correctamente", vbInformation, "Aviso")
                NUMERO.Clear()
                RECIBE.Clear()
                ASIGNADO.Clear()
                ENVIA.Clear()
                OBSSU.Clear()
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
            ACTUALIZAR = "UPDATE sucesos SET ID = '" & ID.Text &
"', SUCESO='" & NUMERO.Text &
          "',  RECIBE='" & RECIBE.Text &
           "', ASIGNADO='" & ASIGNADO.Text &
          "', ENVIA='" & ENVIA.Text &
           "', OBSERVACIONES='" & OBSSU.Text &
                    "' WHERE ID= '" & ID.Text & "' "
            COMAND = New MySqlCommand(ACTUALIZAR, conexion)
            COMAND.ExecuteNonQuery()
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
     NUMERO.Clear()
        RECIBE.Clear()
        ASIGNADO.Clear()
        ENVIA.Clear()
        OBSSU.Clear()
        ID.Enabled = True
        Agregar.Connection = conexion
        Agregar.CommandType = CommandType.Text
        Agregar.CommandText = "Select MAX(ID) As maximo FROM sucesos"
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
        NUMERO.Text = DataGridView1.Item(1, I).Value().ToString()
        RECIBE.Text = DataGridView1.Item(2, I).Value().ToString()
        ASIGNADO.Text = DataGridView1.Item(3, I).Value().ToString()
        ENVIA.Text = DataGridView1.Item(4, I).Value().ToString()
        OBSSU.Text = DataGridView1.Item(5, I).Value().ToString()
    End Sub
End Class