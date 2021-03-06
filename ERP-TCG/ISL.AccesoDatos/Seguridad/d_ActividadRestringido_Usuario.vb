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

Public Class d_ActividadRestringido_Usuario

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ActividadRestringida_Usuario
        Try
            Dim oeActividadRestringida_Usuario = New e_ActividadRestringida_Usuario( _
                                                 o_fila("Id").ToString _
                                                 , o_fila("IdActividadRestringida").ToString _
                                                 , o_fila("AccionSistema").ToString _
                                                 , o_fila("ActividadRestringida").ToString _
                                                 , o_fila("IdActividadNegocio").ToString.Replace(" ", "") _
                                                 , o_fila("CodigoAccion").ToString _
                                                 , o_fila("IdUsuario").ToString _
                                                 , o_fila("FechaCreacion").ToString _
                                                 , o_fila("Activo").ToString)

            Return oeActividadRestringida_Usuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As e_ActividadRestringida_Usuario

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_ActividadRestringida_Usuario_Listar", _
                                          "", _
                                          oeActividadRestringida_Usuario.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeActividadRestringida_Usuario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeActividadRestringida_Usuario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As List(Of e_ActividadRestringida_Usuario)
        Try
            Dim ldActividadRestringida_Usuario As New List(Of e_ActividadRestringida_Usuario)
            Dim ds As DataSet
            With oeActividadRestringida_Usuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_ActividadRestringida_Usuario_Listar", .TipoOperacion _
                                                , .Id _
                                                , .IdActividadRestringida _
                                                , .IdUsuario _
                                                , .FechaCreacion _
                                                , .Activo)
            End With
            oeActividadRestringida_Usuario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeActividadRestringida_Usuario = Cargar(o_Fila)
                oeActividadRestringida_Usuario.IdProcesoNegocio = o_Fila("IdProcesoNegocio").ToString
                ldActividadRestringida_Usuario.Add(oeActividadRestringida_Usuario)
            Next
            Return ldActividadRestringida_Usuario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean
        Try
            With oeActividadRestringida_Usuario
                sqlhelper.ExecuteNonQuery("SGD.Isp_ActividadRestringida_Usuario_IAE",
                                            .TipoOperacion,
                                            .PrefijoID,
                                            .Id _
                                            , .IdActividadRestringida _
                                            , .IdUsuario _
                                            , .FechaCreacion _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal leActividadRestringidaU As List(Of e_ActividadRestringida_Usuario)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeARU In leActividadRestringidaU
                    'Guardar(oeARU)
                    If oeARU.TipoOperacion = "E" Then
                        Eliminar(oeARU)
                    Else
                        Guardar(oeARU)
                    End If
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista2(ByVal leActividadRestringidaU As List(Of e_ActividadRestringida_Usuario)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                Dim _idusu As String = ""
                Dim oeARUEli As New e_ActividadRestringida_Usuario
                For Each oeARU In leActividadRestringidaU
                    If _idusu <> oeARU.IdUsuario Then
                        _idusu = oeARU.IdUsuario
                        oeARUEli = New e_ActividadRestringida_Usuario
                        oeARUEli.TipoOperacion = "L"
                        oeARUEli.IdUsuario = _idusu
                        oeARUEli.PrefijoID = oeARU.PrefijoID '@0001
                        Guardar(oeARUEli)
                    End If
                    Guardar(oeARU)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeActividadRestringida_Usuario As e_ActividadRestringida_Usuario) As Boolean
        Try
            With oeActividadRestringida_Usuario
                sqlhelper.ExecuteNonQuery("SGD.Isp_ActividadRestringida_Usuario_IAE", "E", _
                                                "", _
                                                .Id, _
                                                .IdActividadRestringida, _
                                                .IdUsuario)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
