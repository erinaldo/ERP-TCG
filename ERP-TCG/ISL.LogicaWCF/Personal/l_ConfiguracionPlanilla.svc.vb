﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConfiguracionPlanilla
    Implements Il_ConfiguracionPlanilla

    Private odConfiguracionPlanilla As New d_ConfiguracionPlanilla
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean Implements Il_ConfiguracionPlanilla.Eliminar
        Try
            Return odConfiguracionPlanilla.Eliminar(oeConfiguracionPlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean Implements Il_ConfiguracionPlanilla.Guardar
        Try
            If Validar(oeConfiguracionPlanilla) Then
                Return odConfiguracionPlanilla.Guardar(oeConfiguracionPlanilla)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As List(Of e_ConfiguracionPlanilla) Implements Il_ConfiguracionPlanilla.Listar
        Try
            Return odConfiguracionPlanilla.Listar(oeConfiguracionPlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As e_ConfiguracionPlanilla Implements Il_ConfiguracionPlanilla.Obtener
        Try
            Return odConfiguracionPlanilla.Obtener(oeConfiguracionPlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean Implements Il_ConfiguracionPlanilla.Validar
        Try
            With oeConfiguracionPlanilla
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                ' If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
