﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_ReporteRendimientoConductor
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteRendimientoConductor = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteRendimientoConductor()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Metodos"

    Public Sub CargarDatos(ByVal lista As List(Of e_ReporteTanqueoCombustible))
        Try
            CargarReporteLocalObjeto(lista, "Rendimiento Conductor", "DieselConductor", "Reportes\Logistica\Combustibles\ReporteDieselPiloto.rdlc")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ReporteRendimientoConductor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class