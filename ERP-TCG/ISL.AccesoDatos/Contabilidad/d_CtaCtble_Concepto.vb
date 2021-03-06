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

Public Class d_CtaCtble_Concepto
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CtaCtble_Concepto
        Try
            Dim oeCtaCtble_Concepto = New e_CtaCtble_Concepto( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("CuentaContable").ToString _
                             , o_fila("IdConceptoIngresos").ToString _
                             , o_fila("IdFlujoCaja").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Activo").ToString)
            Return oeCtaCtble_Concepto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As e_CtaCtble_Concepto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_CtaCtble_Concepto_Listar", "", oeCtaCtble_Concepto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCtaCtble_Concepto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCtaCtble_Concepto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As List(Of e_CtaCtble_Concepto)
        Try
            Dim ldCtaCtble_Concepto As New List(Of e_CtaCtble_Concepto)
            Dim ds As DataSet
            With oeCtaCtble_Concepto
                ds = sqlhelper.ExecuteDataset("CON.Isp_CtaCtble_Concepto_Listar", "", .Id _
                        , .IdCuentaContable, .IdConceptoIngresos, .IdMoneda, .Ejercicio)
            End With
            oeCtaCtble_Concepto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCtaCtble_Concepto = Cargar(o_Fila)
                ldCtaCtble_Concepto.Add(oeCtaCtble_Concepto)
            Next
            Return ldCtaCtble_Concepto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As Boolean
        Try
            With oeCtaCtble_Concepto
                sqlhelper.ExecuteNonQuery("CON.Isp_CtaCtble_Concepto_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCuentaContable _
                        , .IdConceptoIngresos _
                        , .IdFlujoCaja _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_CtaCtble_Concepto_IAE", "E", _
             "", oeCtaCtble_Concepto.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
