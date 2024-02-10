Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop
Public Class Form6
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comandos As MySqlCommand = New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Private Sub LIMPIAR()
        CLAVE_ID.Clear()
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
    End Sub
    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        Dim consulta As String
        Dim lista As Byte
        Dim adaptador1 As New MySqlDataAdapter
        Dim datos1 As New DataSet
        Dim adaptador2 As New MySqlDataAdapter
        Dim datos2 As New DataSet
        Try
            If buscar1.Text <> "" And COMBOBUS.Text = "VICTIMA" And Comboano.Text = "06/21 en adelante" Then
                consulta = "SELECT * FROM ((victima LEFT JOIN registro ON victima.Clave_Id = registro.Clave_Id)LEFT JOIN imputado ON victima.Clave_Id = imputado.Clave_Id) WHERE NombreVictima LIKE '%" & buscar1.Text & "%'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "victima")
                lista = datos.Tables("victima").Rows.Count
                DataGridView1.DataSource = datos
                DataGridView1.DataMember = "victima"
                If lista <> 0 Then
                    nombrev.Text = datos.Tables("victima").Rows(0).Item("NombreVictima")
                    edadv.Text = datos.Tables("victima").Rows(0).Item("EdadVictima")
                    direv.Text = datos.Tables("victima").Rows(0).Item("DireccionVictima")
                    dniv.Text = datos.Tables("victima").Rows(0).Item("DniVictima")
                    telv.Text = datos.Tables("victima").Rows(0).Item("TelefonoVictima")
                    polv.Text = datos.Tables("victima").Rows(0).Item("ProfesionVictima")
                    destv.Text = datos.Tables("victima").Rows(0).Item("DestinoVictima")
                    jerv.Text = datos.Tables("victima").Rows(0).Item("JerarquiaVictima")
                    legv.Text = datos.Tables("victima").Rows(0).Item("LegajoVictima")
                    otrov.Text = datos.Tables("victima").Rows(0).Item("OtroVictima")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA LA VICTIMA", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            If buscar1.Text <> "" And COMBOBUS.Text = "IMPUTADO/A" And Comboano.Text = "06/21 en adelante" Then
                consulta = "SELECT * FROM ((victima LEFT JOIN registro ON registro.Clave_Id = victima.Clave_Id)LEFT JOIN imputado ON registro.Clave_Id = imputado.Clave_Id) WHERE NombreDenunciado LIKE '%" & buscar1.Text & "%'"
                adaptador1 = New MySqlDataAdapter(consulta, conexion)
                datos1 = New DataSet
                adaptador1.Fill(datos1, "imputado")
                lista = datos1.Tables("imputado").Rows.Count
                DataGridView1.DataSource = datos1
                DataGridView1.DataMember = "imputado"
                If lista <> 0 Then
                    nombrei.Text = datos1.Tables("imputado").Rows(0).Item("NombreDenunciado")
                    edadi.Text = datos1.Tables("imputado").Rows(0).Item("EdadDenunciado")
                    direi.Text = datos1.Tables("imputado").Rows(0).Item("DireccionDenunciado")
                    dnii.Text = datos1.Tables("imputado").Rows(0).Item("DniDenunciado")
                    teli.Text = datos1.Tables("imputado").Rows(0).Item("TelefonoDenunciado")
                    poli.Text = datos1.Tables("imputado").Rows(0).Item("ProfesionDenunciado")
                    desti.Text = datos1.Tables("imputado").Rows(0).Item("DestinoDenunciado")
                    jeri.Text = datos1.Tables("imputado").Rows(0).Item("JerarquiaDenunciado")
                    legi.Text = datos1.Tables("imputado").Rows(0).Item("LegajoDenunciado")
                    otroi.Text = datos1.Tables("imputado").Rows(0).Item("OtroDenunciado")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA EL DENUNCIADO/A", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            If buscar1.Text <> "" And COMBOBUS.Text = "SEGUIMIENTO" And Comboano.Text = "06/21 en adelante" Then
                consulta = "SELECT * FROM((victima LEFT JOIN registro ON registro.Clave_Id = victima.Clave_Id)LEFT JOIN imputado ON registro.Clave_Id = imputado.Clave_Id) WHERE SEGUIMIENTO LIKE '%" & buscar1.Text & "%'"
                adaptador2 = New MySqlDataAdapter(consulta, conexion)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "registro")
                lista = datos2.Tables("registro").Rows.Count
                DataGridView1.DataSource = datos2
                DataGridView1.DataMember = "registro"
                If lista <> 0 Then
                    FECHA.Text = datos2.Tables("registro").Rows(0).Item("Fecha")
                    CONOCIMIENTO.Text = datos2.Tables("registro").Rows(0).Item("Conocimiento")
                    CARATULA.Text = datos2.Tables("registro").Rows(0).Item("Caratula")
                    ANTECEDENTES.Text = datos2.Tables("registro").Rows(0).Item("Antecedentes")
                    ALOJAMIENTO.Text = datos2.Tables("registro").Rows(0).Item("Alojamiento")
                    GRUPO.Text = datos2.Tables("registro").Rows(0).Item("Grupo")
                    MEDIDA.Text = datos2.Tables("registro").Rows(0).Item("Medida")
                    CUAL.Text = datos2.Tables("registro").Rows(0).Item("Cual")
                    OBSME.Text = datos2.Tables("registro").Rows(0).Item("Obsme")
                    EI.Text = datos2.Tables("registro").Rows(0).Item("EI")
                    QUIEN.Text = datos2.Tables("registro").Rows(0).Item("Quien")
                    OBSEI.Text = datos2.Tables("registro").Rows(0).Item("Obsei")
                    BOTON.Text = datos2.Tables("registro").Rows(0).Item("Boton")
                    OBSBO.Text = datos2.Tables("registro").Rows(0).Item("Obsbo")
                    DPG.Text = datos2.Tables("registro").Rows(0).Item("DPG")
                    OBSDPG.Text = datos2.Tables("registro").Rows(0).Item("Obsdpg")
                    MINORIDAD.Text = datos2.Tables("registro").Rows(0).Item("Minoridad")
                    OBSMI.Text = datos2.Tables("registro").Rows(0).Item("Obsmi")
                    SEGUIMIENTO.Text = datos2.Tables("registro").Rows(0).Item("Seguimiento")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA EL REGISTRO", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            If buscar1.Text <> "" And COMBOBUS.Text = "VICTIMA" And Comboano.Text = "05/20 a 05/21" Then
                consulta = "SELECT * FROM ((victimas LEFT JOIN seguimiento ON victimas.Clave_Id = seguimiento.Clave_Id)LEFT JOIN imputados ON victimas.Clave_Id = imputados.Clave_Id) WHERE NombreVictima LIKE '%" & buscar1.Text & "%'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "victimas")
                lista = datos.Tables("victimas").Rows.Count
                DataGridView1.DataSource = datos
                DataGridView1.DataMember = "victimas"
                If lista <> 0 Then
                    nombrev.Text = datos.Tables("victimas").Rows(0).Item("NombreVictima")
                    edadv.Text = datos.Tables("victimas").Rows(0).Item("EdadVictima")
                    direv.Text = datos.Tables("victimas").Rows(0).Item("DireccionVictima")
                    dniv.Text = datos.Tables("victimas").Rows(0).Item("DniVictima")
                    telv.Text = datos.Tables("victimas").Rows(0).Item("TelefonoVictima")
                    polv.Text = datos.Tables("victimas").Rows(0).Item("ProfesionVictima")
                    destv.Text = datos.Tables("victimas").Rows(0).Item("DestinoVictima")
                    jerv.Text = datos.Tables("victimas").Rows(0).Item("JerarquiaVictima")
                    legv.Text = datos.Tables("victimas").Rows(0).Item("LegajoVictima")
                    otrov.Text = datos.Tables("victimas").Rows(0).Item("OtroVictima")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA LA VICTIMA", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            If buscar1.Text <> "" And COMBOBUS.Text = "IMPUTADO/A" And Comboano.Text = "05/20 a 05/21" Then
                consulta = "SELECT * FROM ((victimas LEFT JOIN seguimiento ON seguimiento.Clave_Id = victimas.Clave_Id)LEFT JOIN imputados ON seguimiento.Clave_Id = imputados.Clave_Id) WHERE NombreDenunciado LIKE '%" & buscar1.Text & "%'"
                adaptador1 = New MySqlDataAdapter(consulta, conexion)
                datos1 = New DataSet
                adaptador1.Fill(datos1, "imputados")
                lista = datos1.Tables("imputados").Rows.Count
                DataGridView1.DataSource = datos1
                DataGridView1.DataMember = "imputados"
                If lista <> 0 Then
                    nombrei.Text = datos1.Tables("imputados").Rows(0).Item("NombreDenunciado")
                    edadi.Text = datos1.Tables("imputados").Rows(0).Item("EdadDenunciado")
                    direi.Text = datos1.Tables("imputados").Rows(0).Item("DireccionDenunciado")
                    dnii.Text = datos1.Tables("imputados").Rows(0).Item("DniDenunciado")
                    teli.Text = datos1.Tables("imputados").Rows(0).Item("TelefonoDenunciado")
                    poli.Text = datos1.Tables("imputados").Rows(0).Item("ProfesionDenunciado")
                    desti.Text = datos1.Tables("imputados").Rows(0).Item("DestinoDenunciado")
                    jeri.Text = datos1.Tables("imputados").Rows(0).Item("JerarquiaDenunciado")
                    legi.Text = datos1.Tables("imputados").Rows(0).Item("LegajoDenunciado")
                    otroi.Text = datos1.Tables("imputados").Rows(0).Item("OtroDenunciado")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA EL DENUNCIADO/A", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            If buscar1.Text <> "" And COMBOBUS.Text = "SEGUIMIENTO" And Comboano.Text = "05/20 a 05/21" Then
                consulta = "SELECT * FROM((victimas LEFT JOIN seguimiento ON seguimiento.Clave_Id = victimas.Clave_Id)LEFT JOIN imputados ON seguimiento.Clave_Id = imputados.Clave_Id) WHERE SEGUIMIENTO LIKE '%" & buscar1.Text & "%'"
                adaptador2 = New MySqlDataAdapter(consulta, conexion)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "seguimiento")
                lista = datos2.Tables("seguimiento").Rows.Count
                DataGridView1.DataSource = datos2
                DataGridView1.DataMember = "seguimiento"
                If lista <> 0 Then
                    FECHA.Text = datos2.Tables("seguimiento").Rows(0).Item("Fecha")
                    CONOCIMIENTO.Text = datos2.Tables("seguimiento").Rows(0).Item("Conocimiento")
                    CARATULA.Text = datos2.Tables("seguimiento").Rows(0).Item("Caratula")
                    ANTECEDENTES.Text = datos2.Tables("seguimiento").Rows(0).Item("Antecedentes")
                    ALOJAMIENTO.Text = datos2.Tables("seguimiento").Rows(0).Item("Alojamiento")
                    GRUPO.Text = datos2.Tables("seguimiento").Rows(0).Item("Grupo")
                    MEDIDA.Text = datos2.Tables("seguimiento").Rows(0).Item("Medida")
                    CUAL.Text = datos2.Tables("seguimiento").Rows(0).Item("Cual")
                    OBSME.Text = datos2.Tables("seguimiento").Rows(0).Item("Obsme")
                    EI.Text = datos2.Tables("seguimiento").Rows(0).Item("EI")
                    QUIEN.Text = datos2.Tables("seguimientoregistro").Rows(0).Item("Quien")
                    OBSEI.Text = datos2.Tables("seguimiento").Rows(0).Item("Obsei")
                    BOTON.Text = datos2.Tables("seguimiento").Rows(0).Item("Boton")
                    OBSBO.Text = datos2.Tables("seguimiento").Rows(0).Item("Obsbo")
                    DPG.Text = datos2.Tables("seguimiento").Rows(0).Item("DPG")
                    OBSDPG.Text = datos2.Tables("seguimiento").Rows(0).Item("Obsdpg")
                    MINORIDAD.Text = datos2.Tables("seguimiento").Rows(0).Item("Minoridad")
                    OBSMI.Text = datos2.Tables("seguimiento").Rows(0).Item("Obsmi")
                    SEGUIMIENTO.Text = datos2.Tables("seguimiento").Rows(0).Item("Seguimiento")
                    conexion.Close()
                Else
                    MsgBox("NO SE ENCUENTRA EL REGISTRO", vbCritical, "FIN BUSQUEDA")
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            If buscar1.Text = "" Then
                LIMPIAR()
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Documento As Word.Document
        Dim MSWord As New Word.Application
        MsgBox(" El documento se guardara en : C:\FICHA\FICHA DE CASOcopy.docx")
        FileCopy("C:\FICHA\FICHA DE CASOcopy1.docx", "C:\FICHA\FICHA DE CASOcopy.docx")
        Documento = MSWord.Documents.Open("C:\FICHA\FICHA DE CASOcopy.docx")
        Documento.Bookmarks.Item("Clave_Id").Range.Text = CLAVE_ID.Text
        Documento.Bookmarks.Item("Fecha").Range.Text = FECHA.Text
        Documento.Bookmarks.Item("Caratula").Range.Text = CARATULA.Text
        Documento.Bookmarks.Item("NombreVictima").Range.Text = nombrev.Text
        Documento.Bookmarks.Item("EdadVictima").Range.Text = edadv.Text
        Documento.Bookmarks.Item("DniVictima").Range.Text = dniv.Text
        Documento.Bookmarks.Item("TelefonoVictima").Range.Text = telv.Text
        Documento.Bookmarks.Item("ProfesionVictima").Range.Text = polv.Text
        Documento.Bookmarks.Item("JerarquiaVictima").Range.Text = jerv.Text
        Documento.Bookmarks.Item("LegajoVictima").Range.Text = legv.Text
        Documento.Bookmarks.Item("DestinoVictima").Range.Text = destv.Text
        Documento.Bookmarks.Item("OtroVictima").Range.Text = desti.Text
        Documento.Bookmarks.Item("NombreDenunciado").Range.Text = nombrei.Text
        Documento.Bookmarks.Item("EdadDenunciado").Range.Text = edadi.Text
        Documento.Bookmarks.Item("DniDenunciado").Range.Text = dnii.Text
        Documento.Bookmarks.Item("TelefonoDenunciado").Range.Text = teli.Text
        Documento.Bookmarks.Item("ProfesionDenunciado").Range.Text = poli.Text
        Documento.Bookmarks.Item("JerarquiaDenunciado").Range.Text = jeri.Text
        Documento.Bookmarks.Item("LegajoDenunciado").Range.Text = legi.Text
        Documento.Bookmarks.Item("DestinoDenunciado").Range.Text = desti.Text
        Documento.Bookmarks.Item("OtroDenunciado").Range.Text = desti.Text
        Documento.Bookmarks.Item("Antecedentes").Range.Text = ANTECEDENTES.Text
        Documento.Bookmarks.Item("Alojamiento").Range.Text = ALOJAMIENTO.Text
        Documento.Bookmarks.Item("Grupo").Range.Text = GRUPO.Text
        Documento.Bookmarks.Item("Conocimiento").Range.Text = CONOCIMIENTO.Text
        Documento.Bookmarks.Item("Medida").Range.Text = MEDIDA.Text
        Documento.Bookmarks.Item("Cual").Range.Text = CUAL.Text
        Documento.Bookmarks.Item("Obsme").Range.Text = OBSME.Text
        Documento.Bookmarks.Item("Boton").Range.Text = BOTON.Text
        Documento.Bookmarks.Item("Obsbo").Range.Text = OBSBO.Text
        Documento.Bookmarks.Item("Minoridad").Range.Text = MINORIDAD.Text
        Documento.Bookmarks.Item("Obsmi").Range.Text = OBSMI.Text
        Documento.Bookmarks.Item("DPG").Range.Text = DPG.Text
        Documento.Bookmarks.Item("Obsdgp").Range.Text = OBSDPG.Text
        Documento.Bookmarks.Item("EI").Range.Text = EI.Text
        Documento.Bookmarks.Item("Quien").Range.Text = QUIEN.Text
        Documento.Bookmarks.Item("Obsei").Range.Text = OBSEI.Text
        Documento.Bookmarks.Item("Seguimiento").Range.Text = SEGUIMIENTO.Text
        Documento.PrintPreview()
        MSWord.Visible = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim I As Integer
        I = DataGridView1.CurrentRow.Index
        CLAVE_ID.Text = DataGridView1.Item(0, I).Value().ToString()
        nombrev.Text = DataGridView1.Item(1, I).Value().ToString()
        edadv.Text = DataGridView1.Item(2, I).Value().ToString()
        direv.Text = DataGridView1.Item(3, I).Value().ToString()
        dniv.Text = DataGridView1.Item(4, I).Value().ToString()
        telv.Text = DataGridView1.Item(5, I).Value().ToString()
        polv.Text = DataGridView1.Item(6, I).Value().ToString()
        destv.Text = DataGridView1.Item(7, I).Value().ToString()
        jerv.Text = DataGridView1.Item(8, I).Value().ToString()
        legv.Text = DataGridView1.Item(9, I).Value().ToString()
        otrov.Text = DataGridView1.Item(10, I).Value().ToString()
        FECHA.Text = DataGridView1.Item(12, I).Value().ToString()
        CONOCIMIENTO.Text = DataGridView1.Item(13, I).Value().ToString()
        CARATULA.Text = DataGridView1.Item(14, I).Value().ToString()
        ANTECEDENTES.Text = DataGridView1.Item(15, I).Value().ToString()
        ALOJAMIENTO.Text = DataGridView1.Item(16, I).Value().ToString()
        GRUPO.Text = DataGridView1.Item(17, I).Value().ToString()
        MEDIDA.Text = DataGridView1.Item(18, I).Value().ToString()
        CUAL.Text = DataGridView1.Item(19, I).Value().ToString()
        OBSME.Text = DataGridView1.Item(20, I).Value().ToString()
        EI.Text = DataGridView1.Item(21, I).Value().ToString()
        QUIEN.Text = DataGridView1.Item(22, I).Value().ToString()
        OBSEI.Text = DataGridView1.Item(23, I).Value().ToString()
        BOTON.Text = DataGridView1.Item(24, I).Value().ToString()
        OBSBO.Text = DataGridView1.Item(25, I).Value().ToString()
        DPG.Text = DataGridView1.Item(26, I).Value().ToString()
        OBSDPG.Text = DataGridView1.Item(27, I).Value().ToString()
        MINORIDAD.Text = DataGridView1.Item(28, I).Value().ToString()
        OBSMI.Text = DataGridView1.Item(29, I).Value().ToString()
        SEGUIMIENTO.Text = DataGridView1.Item(30, I).Value().ToString()
        nombrei.Text = DataGridView1.Item(32, I).Value().ToString()
        edadi.Text = DataGridView1.Item(33, I).Value().ToString()
        direi.Text = DataGridView1.Item(34, I).Value().ToString()
        dnii.Text = DataGridView1.Item(35, I).Value().ToString()
        teli.Text = DataGridView1.Item(36, I).Value().ToString()
        poli.Text = DataGridView1.Item(37, I).Value().ToString()
        desti.Text = DataGridView1.Item(38, I).Value().ToString()
        jeri.Text = DataGridView1.Item(39, I).Value().ToString()
        legi.Text = DataGridView1.Item(40, I).Value().ToString()
        otroi.Text = DataGridView1.Item(41, I).Value().ToString()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Server= windows10.webhosting-network-services.com;  Database = rivgyfco_registro1;  Uid = rivgyfco_rivgyfco ; Pwd = Mozart1592vf@;"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class