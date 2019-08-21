﻿Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF


Public Class frm_ReporteFacturaTicket
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteFacturaTicket = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteFacturaTicket()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    ''' <summary>
    ''' Cargar datos del reporte y enviarlos hacia el formulario básico de impresión
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub CargarDatos()
        Try
            Me.Text = "Reporte de consumo de facturac/ticket"
            CargarReporteRemoto("/Reportes/", "ALM - Reporte Factura Ticket D2")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


#Region "Cerrar el formulario"

    Private Sub frm_ReporteFacturaTicket_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class