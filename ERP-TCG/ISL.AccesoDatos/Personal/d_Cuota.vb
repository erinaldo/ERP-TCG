﻿Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_Cuota
    Inherits d_Persona

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' Cargar un Trabajador
    ''' </summary>
    ''' <param name="o_fila">Fila de Dato de Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Cuota
        Try
            Dim oeCuota = New e_Cuota(o_fila("Id"), _
                                      o_fila("IdTrabajador"), _
                                            o_fila("Codigo"), _
                                            o_fila("NombreCompleto"), _
                                            o_fila("Cuota"), _
                                            o_fila("FechaInicio"), _
                                            o_fila("FechaFin"), _
                                            o_fila("Activo"))
            Return oeCuota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtiene un Trabajador con su Cuota
    ''' </summary>
    ''' <param name="oeCuota">Objeto Cuota</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal oeCuota As e_Cuota) As e_Cuota
        Try
            Dim ds As DataSet
            With oeCuota
                ds = sqlhelper.ExecuteDataset("OPE.Isp_Cuota_Listar", .TipoOperacion, .Id)
            End With
            oeCuota = New e_Cuota
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuota = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Listar Cuota Trabajador
    ''' </summary>
    ''' <param name="oeCuota">Objeto Cuota</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Listar(ByVal oeCuota As e_Cuota) As List(Of e_Cuota)
        Try
            Dim olCuota As New List(Of e_Cuota)
            Dim ds As DataSet
            With oeCuota
                ds = sqlhelper.ExecuteDataset("OPE.Isp_Cuota_Listar", .TipoOperacion)
            End With
            oeCuota = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuota = Cargar(o_Fila)
                    olCuota.Add(oeCuota)
                Next
            End If
            Return olCuota
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Guardar Datos de Cuota de Trabajador
    ''' </summary>
    ''' <param name="oeCuota ">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Guardar(ByVal oeCuota As e_Cuota) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try

            With oeCuota
                sqlhelper.ExecuteScalar("OPE.Isp_Cuota_IAE", .TipoOperacion, _
                 .Id, .IdTrabajador, .Codigo, .FechaInicio, .FechaFin, .Cuota, _
                 .Activo, .FechaCreacion, .UsuarioCreacion, d_DatosConfiguracion.PrefijoID)
            End With
            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Eliminar una Asignacion de Cuota
    ''' </summary>
    ''' <param name="oeCuota">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Eliminar(ByVal oeCuota As e_Cuota) As Boolean
        Try
            With oeCuota
                sqlhelper.ExecuteNonQuery("OPE.Isp_Cuota_IAE" _
                                          , "E" _
                                          , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function


End Class