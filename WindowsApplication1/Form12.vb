Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Public Class Form12
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form9.Show()
        Me.Hide()
    End Sub
    Private Sub MOSTRAR()
        Dim ODA As New MySqlDataAdapter
        Dim ODS As New DataSet
        Dim CON As String
        CON = "SELECT * FROM ((registro LEFT JOIN victima ON registro.Clave_Id = victima.Clave_Id)LEFT JOIN imputado ON registro.Clave_Id = imputado.Clave_Id)"
        ODA = New MySqlDataAdapter(CON, conexion)
        ODS.Tables.Add("registro")
        ODA.Fill(ODS.Tables("registro"))
        DataGridView1.DataSource = ODS.Tables("registro")
    End Sub
    Private Sub MOSTRAR2()
        Dim ODA As New MySqlDataAdapter
        Dim ODS As New DataSet
        Dim CON As String
        CON = "SELECT * FROM ((seguimiento LEFT JOIN victimas ON seguimiento.Clave_Id = victimas.Clave_Id)LEFT JOIN imputados ON seguimiento.Clave_Id = imputados.Clave_Id)"
        ODA = New MySqlDataAdapter(CON, conexion)
        ODS.Tables.Add("seguimiento")
        ODA.Fill(ODS.Tables("seguimiento"))
        DataGridView1.DataSource = ODS.Tables("seguimiento")
    End Sub
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comandos.Connection = conexion
        Try
            conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ELIMINAR()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        If ComboBox1.Text = "06/21 en adelante" Then
            MsgBox("¿Desea eliminar registro?", vbYesNo, "Eliminar")
            If vbYes Then
                Dim cmd As New MySqlCommand("DELETE FROM registro WHERE Clave_ID=" & Val(Me.CLAVE_ID.Text & ""), conexion)
                cmd.ExecuteNonQuery()
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Confirmar")
                MOSTRAR()
            End If
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End If
        If ComboBox1.Text = "05/20 al 05/21" Then
            MsgBox("¿Desea eliminar registro?", vbYesNo, "Eliminar")
            If vbYes Then
                Dim cmd As New MySqlCommand("DELETE  FROM seguimiento WHERE Clave_Id=" & Val(Me.CLAVE_ID.Text & ""), conexion)
                Dim cd As New MySqlCommand("DELETE FROM imputados WHERE Clave_ID=" & Val(Me.CLAVE_ID.Text & ""), conexion)
                Dim cm As New MySqlCommand("DELETE FROM victimas WHERE Clave_ID=" & Val(Me.CLAVE_ID.Text & ""), conexion)
                cmd.ExecuteNonQuery()
                cd.ExecuteNonQuery()
                cm.ExecuteNonQuery()
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Confirmar")
                MOSTRAR2()
            End If
        End If
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
    Private Sub ELI_Click(sender As Object, e As EventArgs) Handles ELI.Click
        ELIMINAR()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim I As Integer
        I = DataGridView1.CurrentRow.Index
        CLAVE_ID.Text = DataGridView1.Item(0, I).Value().ToString()
    End Sub

    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        If ComboBox1.Text = "05/20 al 05/21" Then
            MOSTRAR2()
        End If
        If ComboBox1.Text = "06/21 en adelante" Then
            MOSTRAR()
        End If
    End Sub
End Class