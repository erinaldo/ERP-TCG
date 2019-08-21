﻿Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ImprimeLibroElectronico
    Inherits frm_ReporteBasico

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ImprimeLibroElectronico = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ImprimeLibroElectronico()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Metodos"

    Public Sub CargarDatos(lo As List(Of e_DetalleLibroElectronico), Tipo As Integer)
        Try
            If lo.Count = 0 Then Throw New Exception("No se ha encontrado ningún dato")
            Select Case Tipo
                Case 0
                    CargarReporteLocalObjeto(lo, "Libro Unidades Fisicas", "DataSet1", "Reportes\Contabilidad\Libro12-1.rdlc")
                Case 1
                    CargarReporteLocalObjeto(lo, "Libro Valorizado Permanente", "DataSet1", "Reportes\Contabilidad\Libro13-1.rdlc")
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Cerrar el formulario"

    Private Sub frm_ImprimeLibroElectronico_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

End Class