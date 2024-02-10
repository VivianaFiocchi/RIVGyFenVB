Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Public Class Form14
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form13.Show()
        Me.Hide()
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
    Private Sub MOSTRAR()
        Dim ODA As New MySqlDataAdapter
        Dim ODS As New DataSet
        Dim CON As String
        CON = "SELECT *FROM paraderos"
        ODA = New MySqlDataAdapter(CON, conexion)
        ODS.Tables.Add("paraderos")
        ODA.Fill(ODS.Tables("paraderos"))
        DataGridView1.DataSource = ODS.Tables("paraderos")
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Server= localhost;  Database = BASERIVGyF;  Uid = root ; Pwd = root;"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
End Class