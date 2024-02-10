Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Public Class Form16
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
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

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maximo As String
        Dim Agregar As New MySqlCommand
        comandos.Connection = conexion
        Try
            conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
            conexion.Open()
            MOSTRAR()
            LIMPIAR()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class