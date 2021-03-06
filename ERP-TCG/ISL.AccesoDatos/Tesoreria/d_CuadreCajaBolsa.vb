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

Public Class d_CuadreCajaBolsa
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuadreCajaBolsa
        Try
            Dim oeCuadreCajaBolsa = New e_CuadreCajaBolsa(o_fila("Id").ToString _
                             , o_fila("IdCuadreCaja").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Activo").ToString)
            Return oeCuadreCajaBolsa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As e_CuadreCajaBolsa

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[TES].[Isp_CuadreCajaBolsa_Listar]", "", oeCuadreCajaBolsa.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuadreCajaBolsa = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuadreCajaBolsa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As List(Of e_CuadreCajaBolsa)
        Try
            Dim ldCuadreCajaBolsa As New List(Of e_CuadreCajaBolsa)
            Dim ds As DataSet
            With oeCuadreCajaBolsa
                ds = sqlhelper.ExecuteDataset("[TES].[Isp_CuadreCajaBolsa_Listar]", "" _
                        , .Id _
                        , .IdCuadreCaja _
                        , .IdTrabajador)
            End With
            oeCuadreCajaBolsa = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCuadreCajaBolsa = Cargar(o_Fila)
                ldCuadreCajaBolsa.Add(oeCuadreCajaBolsa)
            Next
            Return ldCuadreCajaBolsa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean
        Try
            With oeCuadreCajaBolsa
                sqlhelper.ExecuteNonQuery("[TES].[Isp_CuadreCajaBolsa_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCuadreCaja _
                        , .IdTrabajador _
                        , .Fecha _
                        , .Importe _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[TES].[Isp_CuadreCajaBolsa_IAE]", "E", _
             "", oeCuadreCajaBolsa.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
