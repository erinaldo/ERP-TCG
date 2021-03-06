﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions

Public Class d_OrdenCmpCotizacion
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenCmpCotizacion
        Try
            Dim oeOrdenCmpCotizacion = New e_OrdenCmpCotizacion(o_fila("Id").ToString _
                             , o_fila("IdOrdenCompra").ToString _
                             , o_fila("IdCotizacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdEquipo").ToString _
                             , o_fila("Orometro"))
            Return oeOrdenCmpCotizacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As Boolean
        Try
            With oeOrdenCmpCotizacion
                sqlhelper.ExecuteNonQuery("CMP.Isp_OrdenCompra_Cotizacion_IAE", .TipoOperacion, .PrefijoID,
                                          .Id _
                                                               , .IdOrdenCompra _
                                                               , .IdCotizacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_OrdenCompra_Cotizacion_IAE", "E", "", oeOrdenCmpCotizacion.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oe As e_OrdenCmpCotizacion) As e_OrdenCmpCotizacion
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenCompra_Cotizacion_Listar", "", oe.Id, oe.IdOrdenCompra)
            oe = New e_OrdenCmpCotizacion
            If ds.Tables(0).Rows.Count > 0 Then
                oe = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
