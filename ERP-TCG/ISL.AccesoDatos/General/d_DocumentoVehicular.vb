﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoVehicular

    Private sqlhelper As New SqlHelper
    Dim odDetalleDocumentoVehiculo As New d_DetalleDocumentoVehiculo
    Dim odCuotaDocumentoVehiculo As New d_CuotaDocumentoVehiculo
    Dim odBonificacionVehiculo As New d_BonificacionVehiculo
    Dim odRevisionTecnica As New d_RevisionTecnica
    Dim odDocVeh_Doc As New d_DocumentoVehicular_Documento

    Public Function Cargar(ByVal o_fila As DataRow) As e_DocumentoVehicular
        Try
            Dim oeDocumentoVehicular = New e_DocumentoVehicular(
                             o_fila("Id").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("Tipo Documento").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("IdEmpresaCertifica").ToString _
                             , o_fila("Empresa Emisora").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Peso").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdEmpresaPropietaria").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("NroResolucion").ToString _
                             , o_fila("Bonificacion").ToString _
                             , o_fila("Porcentaje").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("Resultado").ToString _
                             , o_fila("FechaAdquisicion").ToString
            )
            Return oeDocumentoVehicular
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As e_DocumentoVehicular
        Try
            Dim ds As DataSet
            With oeDocumentoVehicular
                ds = sqlhelper.ExecuteDataset("STD.Isp_DocumentoVehicular_Listar",
                                                  .TipoOperacion _
                                                , .Id _
                                                , .IdEmpresaEmisora _
                                                , .IdTipoDocumento _
                                                , .Activo _
                                                , .IdVehiculo _
                                                , .IndVigencia)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeDocumentoVehicular = Cargar(ds.Tables(0).Rows(0))
            Else
                oeDocumentoVehicular = New e_DocumentoVehicular
            End If
            Return oeDocumentoVehicular
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As List(Of e_DocumentoVehicular)
        Try
            Dim ldDocumentoVehicular As New List(Of e_DocumentoVehicular)
            Dim ds As DataSet
            With oeDocumentoVehicular
                ds = sqlhelper.ExecuteDataset("STD.Isp_DocumentoVehicular_Listar",
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdEmpresaEmisora _
                                            , .IdTipoDocumento _
                                            , .Activo _
                                            , .IdVehiculo _
                                            , .IndVigencia)
            End With
            oeDocumentoVehicular = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoVehicular = Cargar(o_Fila)
                    ldDocumentoVehicular.Add(oeDocumentoVehicular)
                Next
            Else
                ldDocumentoVehicular = New List(Of e_DocumentoVehicular)
            End If
            Return ldDocumentoVehicular
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean
        Try
            Dim ListaDocVeh_Doc_Ayuda As New List(Of e_DocumentoVehicular_Documento)
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeDocumentoVehicular
                    stResultado = sqlhelper.ExecuteScalar("STD.Isp_DocumentoVehicular_IAE",
                                                          .TipoOperacion _
                                                         , .PrefijoID _
                                                        , .Id _
                                                        , .IdEmpresaEmisora _
                                                        , .Numero _
                                                        , .IdTipoDocumento _
                                                        , .FechaEmision _
                                                        , .FechaVencimiento _
                                                        , .Importe _
                                                        , .Peso _
                                                        , .Descripcion _
                                                        , .Activo _
                                                        , .UsuarioCreacion _
                                                        , .IdEmpresaPropietaria _
                                                        , .IdMoneda _
                                                        , .NroResolucion _
                                                        , .Bonificacion _
                                                        , .Porcentaje _
                                                        , .Tipo _
                                                        , .Resultado _
                                                        , .FechaAdquisicion).ToString.Split("_")


                    ''replicamos soat a la tabla imagenesdocumento
                    If oeDocumentoVehicular.IdTipoDocumento = "1CH000000049" Then ''SOAT
                        oeDocumentoVehicular.Id = stResultado(0)
                        Dim d_ImgDoc As New d_ImagenesDocumentos
                        If Not d_ImgDoc.GuardarDesdeDocumentoVehicular(oeDocumentoVehicular) Then Throw New Exception("Error al guardar en imagenes documentos.")
                    End If

                    For Each Doc As e_DocumentoVehicular_Documento In oeDocumentoVehicular.ldDocVeh_Doc
                        Dim oe As New e_DocumentoVehicular_Documento
                        oe.PrefijoID = oeDocumentoVehicular.PrefijoID '@0001
                        oe.Numero = Doc.Id
                        Doc.Id = IIf(Len(Trim(Doc.Id)) = 12, Doc.Id, "")
                        Doc.IdDocumentoVehicular = stResultado(0)
                        Doc.UsuarioCreacion = .UsuarioCreacion
                        Doc.TipoOperacion = .TipoOperacion
                        Doc.PrefijoID = oeDocumentoVehicular.PrefijoID '@0001
                        oe.Id = odDocVeh_Doc.Guardar(Doc)
                        ListaDocVeh_Doc_Ayuda.Add(oe)
                    Next

                    If oeDocumentoVehicular.IdTipoDocumento = "1CH000000048" Then
                        For Each Detalle As e_DetalleDocumentoVehiculo In oeDocumentoVehicular.ldDetalleDocVeh
                            Detalle.IdDocumento = stResultado(0)
                            Detalle.UsuarioCreacion = .UsuarioCreacion
                            Detalle.TipoOperacion = .TipoOperacion
                            If Detalle.IdDocVeh_Doc = "0" Then
                                Detalle.IdDocVeh_Doc = Nothing
                            Else
                                Detalle.IdDocVeh_Doc = ListaDocVeh_Doc_Ayuda.Where(Function(i) i.Numero = Detalle.IdDocVeh_Doc).ToList(0).Id()
                            End If
                            If Detalle.IdDocVeh_Doc2 = "0" Then
                                Detalle.IdDocVeh_Doc2 = Nothing
                            Else
                                Detalle.IdDocVeh_Doc2 = ListaDocVeh_Doc_Ayuda.Where(Function(i) i.Numero = Detalle.IdDocVeh_Doc2).ToList(0).Id()
                            End If
                            Detalle.PrefijoID = oeDocumentoVehicular.PrefijoID '@0001
                            odDetalleDocumentoVehiculo.Guardar(Detalle)
                        Next
                    Else
                        For Each Detalle As e_DetalleDocumentoVehiculo In oeDocumentoVehicular.ldDetalleDocVeh
                            Detalle.IdDocumento = stResultado(0)
                            Detalle.UsuarioCreacion = .UsuarioCreacion
                            Detalle.TipoOperacion = .TipoOperacion
                            Detalle.PrefijoID = oeDocumentoVehicular.PrefijoID '@0001
                            odDetalleDocumentoVehiculo.Guardar(Detalle)
                        Next
                    End If

                    For Each Cuota As e_CuotaDocumentoVehiculo In oeDocumentoVehicular.ldCuotaDocVeh
                        Cuota.IdDocumento = stResultado(0)
                        Cuota.IdUsuarioCreacion = .UsuarioCreacion
                        Cuota.TipoOperacion = .TipoOperacion
                        If Cuota.IdDocVeh_Doc = "0" Then
                            Cuota.IdDocVeh_Doc = Nothing
                        Else
                            Cuota.IdDocVeh_Doc = ListaDocVeh_Doc_Ayuda.Where(Function(i) i.Numero = Cuota.IdDocVeh_Doc).ToList(0).Id()
                        End If
                        Cuota.PrefijoID = oeDocumentoVehicular.PrefijoID '@0001
                        odCuotaDocumentoVehiculo.Guardar(Cuota)
                    Next

                    For Each Bono As e_BonificacionVehiculo In oeDocumentoVehicular.ldBonoVeh
                        Bono.IdDocumentoVehicular = stResultado(0)
                        Bono.UsuarioCreacion = .UsuarioCreacion
                        Bono.TipoOperacion = .TipoOperacion
                        Bono.PrefijoID = oeDocumentoVehicular.PrefijoID '@0001
                        odBonificacionVehiculo.Guardar(Bono)
                    Next

                    For Each Revision As e_RevisionTecnica In oeDocumentoVehicular.ldRevisionTec
                        Revision.IdDocumentoVehicular = stResultado(0)
                        Revision.UsuarioCreacion = .UsuarioCreacion
                        Revision.TipoOperacion = .TipoOperacion
                        Revision.PrefijoID = oeDocumentoVehicular.PrefijoID '@0001
                        odRevisionTecnica.Guardar(Revision)
                    Next

                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function GuardarDetalle(ByVal ls_IdVehiculo As String,
                                   ByVal ls_IdDocumento As String,
                                   ByVal ls_UsuarioCreacion As String, ByVal PrefijoID As String) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_DetalleDocumentoVehiculo_IAE",
                                      "I",
                                      PrefijoID,
                                      "",
                                      ls_IdVehiculo,
                                      ls_IdDocumento,
                                      True,
                                      ls_UsuarioCreacion)

            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean
        Try
            Using transScope As New TransactionScope()
                sqlhelper.ExecuteNonQuery("STD.Isp_DocumentoVehicular_IAE", oeDocumentoVehicular.TipoOperacion,
                    "", oeDocumentoVehicular.Id)

                Dim d_ImgDoc As New d_ImagenesDocumentos
                If oeDocumentoVehicular.TipoDocumento = "1CH000000049" Then
                    If Not d_ImgDoc.EliminarDesdeDocumentoVehicular(oeDocumentoVehicular) Then Throw New Exception("Error al eliminar en imagenes documentos.")
                End If

                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarDts(ByVal oeDocVeh As e_DocumentoVehicular) As DataSet
        Try
            With oeDocVeh
                Return sqlhelper.ExecuteDataset("[STD].[Isp_DocumentoVehicular_Listar]",
                                              .TipoOperacion,
                                              .Id,
                                              .IdEmpresaEmisora,
                                              .TipoDocumento,
                                              .Activo,
                                              .IdVehiculo,
                                              .IndVigencia)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarProvisionar(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As List(Of e_DocumentoVehicular)
        Try
            Dim ldDocumentoVehicular As New List(Of e_DocumentoVehicular)
            Dim ds As DataSet
            With oeDocumentoVehicular
                ds = sqlhelper.ExecuteDataset("STD.Isp_DocumentoVehicular_Listar",
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdEmpresaEmisora _
                                            , .IdTipoDocumento _
                                            , .Activo _
                                            , .IdVehiculo _
                                            , .IndVigencia)
            End With
            oeDocumentoVehicular = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoVehicular = Cargar(o_Fila)
                    ldDocumentoVehicular.Add(oeDocumentoVehicular)
                Next
            Else
                ldDocumentoVehicular = New List(Of e_DocumentoVehicular)
            End If
            Return ldDocumentoVehicular
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar2(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As Boolean
        Try
            Dim ListaDocVeh_Doc_Ayuda As New List(Of e_DocumentoVehicular_Documento)
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeDocumentoVehicular
                    stResultado = sqlhelper.ExecuteScalar("STD.Isp_DocumentoVehicularDocumento_IAE",
                                                          .TipoOperacion _
                                                         , .PrefijoID _
                                                        , .Id _
                                                        , .IdEmpresaEmisora _
                                                        , .IdEmpresaPropietaria).ToString.Split("_")

                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ListarDevengo(ByVal oeDocumentoVehicular As e_DocumentoVehicular) As DataTable
        Try
            Dim ds As DataSet
            With oeDocumentoVehicular
                ds = sqlhelper.ExecuteDataset("STD.Isp_DocumentoVehicular_Listar",
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdEmpresaEmisora _
                                            , .IdTipoDocumento _
                                            , .Activo _
                                            , .IdVehiculo _
                                            , .IndVigencia)
            End With
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function UltimoIdDevengoInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "STD.DocumentoVehicularDevengo", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarDevengo(ByVal dtDevengo As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("STD.DocumentoVehicularDevengo", dtDevengo)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class