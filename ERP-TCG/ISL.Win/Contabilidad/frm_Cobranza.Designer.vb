﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cobranza
    Inherits frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroBoucher")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroBoucher")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoCajaBanco")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlujoCaja")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroBoucher")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoCajaBanco")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlujoCaja")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroBoucher")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cobranza))
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oePersona")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeEmpresa")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPersonaEmpresa")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaActividad")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Email")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Contacto")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oePersona")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("oeEmpresa")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.gridCobranzaAgregado = New ISL.Controles.Grilla(Me.components)
        Me.MenuDocumentos = New ISL.Controles.MenuContextual(Me.components)
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarNetoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarDetracciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro = New ISL.Controles.Filtro(Me.components)
        Me.gridCobranza = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.DecDifGanancia = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.OptCobro = New System.Windows.Forms.RadioButton()
        Me.OptGanancia = New System.Windows.Forms.RadioButton()
        Me.OptPerdida = New System.Windows.Forms.RadioButton()
        Me.UltraCalculatorDropDown1 = New Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.chkCalculadora = New ISL.Controles.Chequear(Me.components)
        Me.EtiImporteDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.lblTotalesME = New ISL.Controles.Etiqueta(Me.components)
        Me.lblTotalesMN = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ordCliente = New ISL.Controles.OrigenDatos(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.cbMedioPago = New System.Windows.Forms.CheckBox()
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaContable = New ISL.Controles.Combo(Me.components)
        Me.cboMedio = New ISL.Controles.Combo(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha = New ISL.Controles.Fecha(Me.components)
        Me.txtVoucher = New ISL.Controles.Texto(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.cboFlujoGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraCalculatorDropDown2 = New Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown()
        Me.Chequear2 = New ISL.Controles.Chequear(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        CType(Me.gridCobranzaAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDocumentos.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.DecDifGanancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCalculatorDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.UltraCalculatorDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chequear2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridCobranzaAgregado
        '
        Me.gridCobranzaAgregado.ContextMenuStrip = Me.MenuDocumentos
        Me.gridCobranzaAgregado.DataSource = Me.UltraDataSource1
        Me.gridCobranzaAgregado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.Caption = "TipoDoc"
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 74
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Width = 51
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Width = 91
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.Caption = "Fec.Emision"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Width = 73
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.Caption = "Fec.Venc."
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Width = 73
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance1
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Format = "#,##0.00"
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 119
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance2
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn13.Format = "#,##0.00"
        UltraGridColumn13.Header.VisiblePosition = 21
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn13.Width = 100
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn14.Header.Caption = "Cliente"
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Width = 265
        UltraGridColumn15.Header.VisiblePosition = 13
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 14
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 15
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn18.Header.Caption = "Mon."
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.Width = 31
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance3
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn35.Format = "#,##0.0000"
        UltraGridColumn35.Header.Caption = "T.C."
        UltraGridColumn35.Header.VisiblePosition = 11
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Width = 52
        UltraGridColumn36.Header.VisiblePosition = 16
        UltraGridColumn36.Hidden = True
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn37.CellAppearance = Appearance4
        UltraGridColumn37.Format = "#,##0.00"
        UltraGridColumn37.Header.Caption = "Detraccion"
        UltraGridColumn37.Header.VisiblePosition = 17
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn37.Width = 109
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance5
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn38.Format = "#,##0.00"
        UltraGridColumn38.Header.VisiblePosition = 18
        UltraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn38.Width = 101
        UltraGridColumn39.Header.VisiblePosition = 19
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 20
        UltraGridColumn40.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance6
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn41.Format = "#,##0.0000"
        UltraGridColumn41.Header.Caption = "Monto a Cobrar"
        UltraGridColumn41.Header.VisiblePosition = 22
        UltraGridColumn41.MaskInput = "{double:9.4}"
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn41.Width = 135
        UltraGridColumn42.Header.VisiblePosition = 23
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 24
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 25
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 26
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 31
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 32
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 33
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 34
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 27
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 28
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 29
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 30
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 35
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 36
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 37
        UltraGridColumn56.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 38
        UltraGridColumn1.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 39
        UltraGridColumn19.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn1, UltraGridColumn19})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranzaAgregado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridCobranzaAgregado.DisplayLayout.MaxColScrollRegions = 1
        Me.gridCobranzaAgregado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranzaAgregado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridCobranzaAgregado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridCobranzaAgregado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridCobranzaAgregado.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.gridCobranzaAgregado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridCobranzaAgregado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridCobranzaAgregado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridCobranzaAgregado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridCobranzaAgregado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranzaAgregado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridCobranzaAgregado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCobranzaAgregado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCobranzaAgregado.Location = New System.Drawing.Point(3, 3)
        Me.gridCobranzaAgregado.Name = "gridCobranzaAgregado"
        Me.gridCobranzaAgregado.Size = New System.Drawing.Size(1314, 244)
        Me.gridCobranzaAgregado.TabIndex = 0
        Me.gridCobranzaAgregado.Text = "Aplicacion de Cobro"
        '
        'MenuDocumentos
        '
        Me.MenuDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDocumentos.ForeColor = System.Drawing.Color.Black
        Me.MenuDocumentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarToolStripMenuItem, Me.CargarNetoToolStripMenuItem, Me.CargarDetracciónToolStripMenuItem})
        Me.MenuDocumentos.Name = "MenuContextual1"
        Me.MenuDocumentos.Size = New System.Drawing.Size(161, 70)
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        '
        'CargarNetoToolStripMenuItem
        '
        Me.CargarNetoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.CargarNetoToolStripMenuItem.Name = "CargarNetoToolStripMenuItem"
        Me.CargarNetoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CargarNetoToolStripMenuItem.Text = "Cargar Neto"
        '
        'CargarDetracciónToolStripMenuItem
        '
        Me.CargarDetracciónToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.CargarDetracciónToolStripMenuItem.Name = "CargarDetracciónToolStripMenuItem"
        Me.CargarDetracciónToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CargarDetracciónToolStripMenuItem.Text = "Cargar Detracción"
        '
        'UltraDataSource1
        '
        UltraDataColumn23.DataType = GetType(Double)
        UltraDataColumn40.DataType = GetType(Boolean)
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'Filtro
        '
        Me.Filtro.MenuSettings.RightAlignedMenus = True
        Me.Filtro.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2007
        '
        'gridCobranza
        '
        Me.gridCobranza.DataSource = Me.UltraDataSource2
        Me.gridCobranza.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn57.Header.VisiblePosition = 0
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 1
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.Caption = "TipoDoc"
        UltraGridColumn59.Header.VisiblePosition = 3
        UltraGridColumn59.Width = 78
        UltraGridColumn60.Header.VisiblePosition = 4
        UltraGridColumn60.Width = 54
        UltraGridColumn61.Header.VisiblePosition = 5
        UltraGridColumn61.Width = 108
        UltraGridColumn62.Header.Caption = "Fec.Emision"
        UltraGridColumn62.Header.VisiblePosition = 6
        UltraGridColumn62.Width = 81
        UltraGridColumn63.Header.Caption = "Fec.Venc."
        UltraGridColumn63.Header.VisiblePosition = 7
        UltraGridColumn63.Width = 81
        UltraGridColumn64.Header.VisiblePosition = 8
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 9
        UltraGridColumn65.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn66.CellAppearance = Appearance7
        UltraGridColumn66.Format = "#,##0.00"
        UltraGridColumn66.Header.VisiblePosition = 12
        UltraGridColumn66.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn66.Width = 130
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn67.CellAppearance = Appearance8
        UltraGridColumn67.Format = "#,##0.00"
        UltraGridColumn67.Header.VisiblePosition = 13
        UltraGridColumn67.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn67.Width = 117
        UltraGridColumn68.Header.Caption = "Cliente"
        UltraGridColumn68.Header.VisiblePosition = 2
        UltraGridColumn68.Width = 299
        UltraGridColumn69.Header.VisiblePosition = 14
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 15
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 16
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.Caption = "Mon."
        UltraGridColumn72.Header.VisiblePosition = 10
        UltraGridColumn72.Width = 35
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn73.CellAppearance = Appearance9
        UltraGridColumn73.Format = "#,##0.0000"
        UltraGridColumn73.Header.Caption = "T.C."
        UltraGridColumn73.Header.VisiblePosition = 11
        UltraGridColumn73.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn73.Width = 58
        UltraGridColumn74.Header.VisiblePosition = 17
        UltraGridColumn74.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn75.CellAppearance = Appearance10
        UltraGridColumn75.Format = "#,##0.00"
        UltraGridColumn75.Header.VisiblePosition = 18
        UltraGridColumn75.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn75.Width = 117
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn76.CellAppearance = Appearance11
        UltraGridColumn76.Format = "#,##0.00"
        UltraGridColumn76.Header.VisiblePosition = 19
        UltraGridColumn76.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn76.Width = 116
        UltraGridColumn77.Header.VisiblePosition = 20
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 21
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 22
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 23
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 24
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 25
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 26
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 27
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 28
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 29
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 30
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 31
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 32
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 33
        UltraGridColumn90.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 34
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 35
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 36
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 37
        UltraGridColumn168.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 38
        UltraGridColumn2.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 39
        UltraGridColumn20.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn2, UltraGridColumn20})
        Me.gridCobranza.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridCobranza.DisplayLayout.MaxColScrollRegions = 1
        Me.gridCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridCobranza.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridCobranza.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridCobranza.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.gridCobranza.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridCobranza.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridCobranza.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridCobranza.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCobranza.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridCobranza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCobranza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCobranza.Location = New System.Drawing.Point(3, 3)
        Me.gridCobranza.Name = "gridCobranza"
        Me.gridCobranza.Size = New System.Drawing.Size(1314, 182)
        Me.gridCobranza.TabIndex = 0
        Me.gridCobranza.Text = "Ventas"
        '
        'UltraDataSource2
        '
        UltraDataColumn64.DataType = GetType(Double)
        UltraDataColumn80.DataType = GetType(Boolean)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80})
        Me.UltraDataSource2.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance12
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(433, 117)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(884, 3)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(433, 117)
        Me.UltraExpandableGroupBox1.TabIndex = 16
        Me.UltraExpandableGroupBox1.Text = "Verificación de Totales:"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraCalculatorDropDown1)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraPanel1)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.chkCalculadora)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.EtiImporteDolares)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.EtiImporteSoles)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblTotalesME)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblTotalesMN)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta10)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta8)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta9)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(30, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(400, 111)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.DecDifGanancia)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.OptCobro)
        Me.UltraGroupBox4.Controls.Add(Me.OptGanancia)
        Me.UltraGroupBox4.Controls.Add(Me.OptPerdida)
        Me.UltraGroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.UltraGroupBox4.Location = New System.Drawing.Point(3, 46)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(226, 54)
        Me.UltraGroupBox4.TabIndex = 8
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'DecDifGanancia
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.DecDifGanancia.Appearance = Appearance13
        Me.DecDifGanancia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecDifGanancia.Enabled = False
        Me.DecDifGanancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecDifGanancia.ForeColor = System.Drawing.Color.Black
        Me.DecDifGanancia.Location = New System.Drawing.Point(142, 29)
        Me.DecDifGanancia.MaskInput = "{double:4.4}"
        Me.DecDifGanancia.Name = "DecDifGanancia"
        Me.DecDifGanancia.NullText = "0.00"
        Me.DecDifGanancia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecDifGanancia.Size = New System.Drawing.Size(71, 21)
        Me.DecDifGanancia.TabIndex = 4
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(7, 33)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(129, 15)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Especifique la diferencia:"
        '
        'OptCobro
        '
        Me.OptCobro.AutoSize = True
        Me.OptCobro.BackColor = System.Drawing.Color.Transparent
        Me.OptCobro.Checked = True
        Me.OptCobro.ForeColor = System.Drawing.Color.Navy
        Me.OptCobro.Location = New System.Drawing.Point(6, 6)
        Me.OptCobro.Name = "OptCobro"
        Me.OptCobro.Size = New System.Drawing.Size(54, 17)
        Me.OptCobro.TabIndex = 0
        Me.OptCobro.TabStop = True
        Me.OptCobro.Text = "Cobro"
        Me.OptCobro.UseVisualStyleBackColor = False
        '
        'OptGanancia
        '
        Me.OptGanancia.AutoSize = True
        Me.OptGanancia.BackColor = System.Drawing.Color.Transparent
        Me.OptGanancia.ForeColor = System.Drawing.Color.Navy
        Me.OptGanancia.Location = New System.Drawing.Point(65, 6)
        Me.OptGanancia.Name = "OptGanancia"
        Me.OptGanancia.Size = New System.Drawing.Size(69, 17)
        Me.OptGanancia.TabIndex = 1
        Me.OptGanancia.Text = "Ganancia"
        Me.OptGanancia.UseVisualStyleBackColor = False
        '
        'OptPerdida
        '
        Me.OptPerdida.AutoSize = True
        Me.OptPerdida.BackColor = System.Drawing.Color.Transparent
        Me.OptPerdida.ForeColor = System.Drawing.Color.Navy
        Me.OptPerdida.Location = New System.Drawing.Point(142, 6)
        Me.OptPerdida.Name = "OptPerdida"
        Me.OptPerdida.Size = New System.Drawing.Size(61, 17)
        Me.OptPerdida.TabIndex = 2
        Me.OptPerdida.Text = "Perdida"
        Me.OptPerdida.UseVisualStyleBackColor = False
        '
        'UltraCalculatorDropDown1
        '
        Me.UltraCalculatorDropDown1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraCalculatorDropDown1.Location = New System.Drawing.Point(232, 51)
        Me.UltraCalculatorDropDown1.Name = "UltraCalculatorDropDown1"
        Me.UltraCalculatorDropDown1.Size = New System.Drawing.Size(94, 22)
        Me.UltraCalculatorDropDown1.TabIndex = 9
        Me.UltraCalculatorDropDown1.Visible = False
        '
        'UltraPanel1
        '
        Appearance15.ImageBackground = CType(resources.GetObject("Appearance15.ImageBackground"), System.Drawing.Image)
        Me.UltraPanel1.Appearance = Appearance15
        Me.UltraPanel1.Location = New System.Drawing.Point(337, 46)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(56, 52)
        Me.UltraPanel1.TabIndex = 11
        '
        'chkCalculadora
        '
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.chkCalculadora.Appearance = Appearance16
        Me.chkCalculadora.AutoSize = True
        Me.chkCalculadora.BackColor = System.Drawing.Color.Transparent
        Me.chkCalculadora.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCalculadora.ForeColor = System.Drawing.Color.Black
        Me.chkCalculadora.Location = New System.Drawing.Point(235, 78)
        Me.chkCalculadora.Name = "chkCalculadora"
        Me.chkCalculadora.Size = New System.Drawing.Size(62, 17)
        Me.chkCalculadora.TabIndex = 10
        Me.chkCalculadora.Text = "Habilitar"
        '
        'EtiImporteDolares
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.EtiImporteDolares.Appearance = Appearance17
        Me.EtiImporteDolares.AutoSize = True
        Me.EtiImporteDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteDolares.Location = New System.Drawing.Point(99, 27)
        Me.EtiImporteDolares.Name = "EtiImporteDolares"
        Me.EtiImporteDolares.Size = New System.Drawing.Size(10, 15)
        Me.EtiImporteDolares.TabIndex = 5
        Me.EtiImporteDolares.Text = "0"
        '
        'EtiImporteSoles
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.EtiImporteSoles.Appearance = Appearance18
        Me.EtiImporteSoles.AutoSize = True
        Me.EtiImporteSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteSoles.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteSoles.Location = New System.Drawing.Point(99, 6)
        Me.EtiImporteSoles.Name = "EtiImporteSoles"
        Me.EtiImporteSoles.Size = New System.Drawing.Size(10, 15)
        Me.EtiImporteSoles.TabIndex = 1
        Me.EtiImporteSoles.Text = "0"
        '
        'lblTotalesME
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalesME.Appearance = Appearance19
        Me.lblTotalesME.AutoSize = True
        Me.lblTotalesME.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalesME.ForeColor = System.Drawing.Color.Black
        Me.lblTotalesME.Location = New System.Drawing.Point(316, 27)
        Me.lblTotalesME.Name = "lblTotalesME"
        Me.lblTotalesME.Size = New System.Drawing.Size(10, 15)
        Me.lblTotalesME.TabIndex = 7
        Me.lblTotalesME.Text = "0"
        '
        'lblTotalesMN
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalesMN.Appearance = Appearance20
        Me.lblTotalesMN.AutoSize = True
        Me.lblTotalesMN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalesMN.ForeColor = System.Drawing.Color.Black
        Me.lblTotalesMN.Location = New System.Drawing.Point(316, 6)
        Me.lblTotalesMN.Name = "lblTotalesMN"
        Me.lblTotalesMN.Size = New System.Drawing.Size(10, 15)
        Me.lblTotalesMN.TabIndex = 3
        Me.lblTotalesMN.Text = "0"
        '
        'Etiqueta10
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance21
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(140, 27)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(170, 15)
        Me.Etiqueta10.TabIndex = 6
        Me.Etiqueta10.Text = "Importe MN ($) + Diferencia ($):"
        '
        'Etiqueta8
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance22
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(142, 5)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(168, 15)
        Me.Etiqueta8.TabIndex = 2
        Me.Etiqueta8.Text = "Importe MN (S/)+Diferencia(S/):"
        '
        'Etiqueta9
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance23
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(1, 27)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(92, 15)
        Me.Etiqueta9.TabIndex = 4
        Me.Etiqueta9.Text = "Importe ME ($.) :"
        '
        'Etiqueta3
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance24
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(2, 6)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(91, 15)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Importe MN (S/):"
        '
        'cboCliente
        '
        Me.cboCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.CheckedListSettings.ListSeparator = ","
        Me.cboCliente.DataSource = Me.ordCliente
        Me.cboCliente.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn93.Header.VisiblePosition = 0
        UltraGridColumn93.Hidden = True
        UltraGridColumn93.Width = 19
        UltraGridColumn94.Header.VisiblePosition = 1
        UltraGridColumn94.Hidden = True
        UltraGridColumn94.Width = 18
        UltraGridColumn95.Header.VisiblePosition = 2
        UltraGridColumn95.Hidden = True
        UltraGridColumn95.Width = 31
        UltraGridColumn96.Header.VisiblePosition = 3
        UltraGridColumn96.Hidden = True
        UltraGridColumn96.Width = 28
        UltraGridColumn97.Header.VisiblePosition = 4
        UltraGridColumn97.Hidden = True
        UltraGridColumn97.Width = 25
        UltraGridColumn98.Header.VisiblePosition = 5
        UltraGridColumn98.Hidden = True
        UltraGridColumn98.Width = 17
        UltraGridColumn99.Header.VisiblePosition = 6
        UltraGridColumn99.Hidden = True
        UltraGridColumn99.Width = 25
        UltraGridColumn100.Header.VisiblePosition = 7
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.Width = 25
        UltraGridColumn101.Header.VisiblePosition = 8
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.Width = 25
        UltraGridColumn102.Header.VisiblePosition = 9
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.Width = 54
        UltraGridColumn103.Header.VisiblePosition = 10
        UltraGridColumn103.Width = 195
        UltraGridColumn104.Header.VisiblePosition = 11
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.Width = 54
        UltraGridColumn105.Header.VisiblePosition = 12
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.Width = 55
        UltraGridColumn106.Header.VisiblePosition = 13
        UltraGridColumn106.Width = 186
        UltraGridColumn107.Header.VisiblePosition = 14
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 15
        UltraGridColumn108.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108})
        Me.cboCliente.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.DropDownWidth = 400
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.Location = New System.Drawing.Point(603, 30)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(275, 22)
        Me.cboCliente.TabIndex = 11
        '
        'ordCliente
        '
        UltraDataColumn86.DataType = GetType(Boolean)
        Me.ordCliente.Band.Columns.AddRange(New Object() {UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96})
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(528, 31)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(70, 21)
        Me.txtRuc.TabIndex = 10
        Me.txtRuc.TabStop = False
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(528, 58)
        Me.txtGlosa.MaxLength = 100
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(350, 21)
        Me.txtGlosa.TabIndex = 13
        '
        'Etiqueta2
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance25
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(487, 62)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta2.TabIndex = 12
        Me.Etiqueta2.Text = "Glosa:"
        '
        'Etiqueta31
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance26
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(454, 35)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta31.TabIndex = 9
        Me.Etiqueta31.Text = "RUC/Cliente:"
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.cbMedioPago)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion6.Controls.Add(Me.cboCuentaContable)
        Me.Agrupacion6.Controls.Add(Me.cboMedio)
        Me.Agrupacion6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(14, 60)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(414, 59)
        Me.Agrupacion6.TabIndex = 6
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cbMedioPago
        '
        Me.cbMedioPago.AutoSize = True
        Me.cbMedioPago.BackColor = System.Drawing.Color.Transparent
        Me.cbMedioPago.ForeColor = System.Drawing.Color.Navy
        Me.cbMedioPago.Location = New System.Drawing.Point(6, 9)
        Me.cbMedioPago.Name = "cbMedioPago"
        Me.cbMedioPago.Size = New System.Drawing.Size(96, 17)
        Me.cbMedioPago.TabIndex = 0
        Me.cbMedioPago.Text = "Medio de Pago"
        Me.cbMedioPago.UseVisualStyleBackColor = False
        '
        'Etiqueta5
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance27
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(15, 35)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(87, 15)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Cta Ctble Cobro:"
        '
        'cboCuentaContable
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Appearance = Appearance28
        Me.cboCuentaContable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaContable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaContable.DropDownListWidth = 350
        Me.cboCuentaContable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaContable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaContable.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Location = New System.Drawing.Point(108, 31)
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.Size = New System.Drawing.Size(300, 22)
        Me.cboCuentaContable.TabIndex = 3
        Me.cboCuentaContable.ValueMember = "Id"
        '
        'cboMedio
        '
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Appearance = Appearance29
        Me.cboMedio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMedio.DropDownListWidth = 350
        Me.cboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedio.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Location = New System.Drawing.Point(108, 6)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(200, 22)
        Me.cboMedio.TabIndex = 1
        Me.cboMedio.ValueMember = "Id"
        '
        'DecTC
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance30
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(287, 6)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.000"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(68, 22)
        Me.DecTC.TabIndex = 3
        '
        'Etiqueta4
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance31
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(210, 10)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta4.TabIndex = 2
        Me.Etiqueta4.Text = "Tipo Cambio:"
        '
        'Fecha
        '
        Appearance32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Fecha.Appearance = Appearance32
        Me.Fecha.DateTime = New Date(2014, 2, 28, 0, 0, 0, 0)
        Me.Fecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Fecha.Location = New System.Drawing.Point(122, 6)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(82, 22)
        Me.Fecha.TabIndex = 1
        Me.Fecha.Value = New Date(2014, 2, 28, 0, 0, 0, 0)
        '
        'txtVoucher
        '
        Me.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVoucher.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucher.Location = New System.Drawing.Point(528, 85)
        Me.txtVoucher.MaxLength = 20
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(100, 21)
        Me.txtVoucher.TabIndex = 15
        '
        'cboCuentaBancaria
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance33
        Me.cboCuentaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCuentaBancaria.DropDownListWidth = 600
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(122, 33)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(300, 22)
        Me.cboCuentaBancaria.TabIndex = 5
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'cboFlujoGasto
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Appearance = Appearance34
        Me.cboFlujoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlujoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoGasto.DropDownListWidth = 400
        Me.cboFlujoGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Location = New System.Drawing.Point(528, 6)
        Me.cboFlujoGasto.Name = "cboFlujoGasto"
        Me.cboFlujoGasto.Size = New System.Drawing.Size(350, 21)
        Me.cboFlujoGasto.TabIndex = 8
        Me.cboFlujoGasto.ValueMember = "Id"
        '
        'Etiqueta18
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance35
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(78, 10)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta18.TabIndex = 0
        Me.Etiqueta18.Text = "Fecha:"
        '
        'Etiqueta17
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance36
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(463, 89)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta17.TabIndex = 14
        Me.Etiqueta17.Text = "Operacion:"
        '
        'Etiqueta11
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance37
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(26, 37)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(90, 15)
        Me.Etiqueta11.TabIndex = 4
        Me.Etiqueta11.Text = "Cuenta Bancaria:"
        '
        'Etiqueta6
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance38
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(448, 10)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta6.TabIndex = 7
        Me.Etiqueta6.Text = "Flujo de Caja:"
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraPanel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraCalculatorDropDown2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Chequear2)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(25, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(132, 126)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraPanel2
        '
        Appearance39.ImageBackground = CType(resources.GetObject("Appearance39.ImageBackground"), System.Drawing.Image)
        Me.UltraPanel2.Appearance = Appearance39
        Me.UltraPanel2.Location = New System.Drawing.Point(27, 3)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(78, 93)
        Me.UltraPanel2.TabIndex = 276
        '
        'UltraCalculatorDropDown2
        '
        Me.UltraCalculatorDropDown2.Location = New System.Drawing.Point(96, 91)
        Me.UltraCalculatorDropDown2.Name = "UltraCalculatorDropDown2"
        Me.UltraCalculatorDropDown2.Size = New System.Drawing.Size(30, 21)
        Me.UltraCalculatorDropDown2.TabIndex = 7
        Me.UltraCalculatorDropDown2.Text = "UltraCalculatorDropDown2"
        Me.UltraCalculatorDropDown2.Visible = False
        '
        'Chequear2
        '
        Me.Chequear2.BackColor = System.Drawing.Color.White
        Me.Chequear2.BackColorInternal = System.Drawing.Color.White
        Me.Chequear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequear2.ForeColor = System.Drawing.Color.Black
        Me.Chequear2.Location = New System.Drawing.Point(2, 105)
        Me.Chequear2.Name = "Chequear2"
        Me.Chequear2.Size = New System.Drawing.Size(126, 21)
        Me.Chequear2.TabIndex = 275
        Me.Chequear2.Text = "Habilitar calculadora"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta18)
        Me.UltraGroupBox1.Controls.Add(Me.txtVoucher)
        Me.UltraGroupBox1.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox1.Controls.Add(Me.cboCliente)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta11)
        Me.UltraGroupBox1.Controls.Add(Me.txtRuc)
        Me.UltraGroupBox1.Controls.Add(Me.Agrupacion6)
        Me.UltraGroupBox1.Controls.Add(Me.Fecha)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox1.Controls.Add(Me.cboFlujoGasto)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta31)
        Me.UltraGroupBox1.Controls.Add(Me.DecTC)
        Me.UltraGroupBox1.Controls.Add(Me.cboCuentaBancaria)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta6)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta17)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1320, 123)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.gridCobranza)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 373)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1320, 188)
        Me.UltraGroupBox2.TabIndex = 2
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.gridCobranzaAgregado)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 123)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1320, 250)
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'frm_Cobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 561)
        Me.Controls.Add(Me.UltraGroupBox3)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "frm_Cobranza"
        Me.Text = "Cobranza"
        CType(Me.gridCobranzaAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDocumentos.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCobranza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.DecDifGanancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCalculatorDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.UltraCalculatorDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chequear2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents gridCobranza As ISL.Controles.Grilla
    Friend WithEvents Fecha As ISL.Controles.Fecha
    Friend WithEvents txtVoucher As ISL.Controles.Texto
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents cboFlujoGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaContable As ISL.Controles.Combo
    Friend WithEvents EtiImporteSoles As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteDolares As ISL.Controles.Etiqueta
    Friend WithEvents cboMedio As ISL.Controles.Combo
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents gridCobranzaAgregado As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents lblTotalesMN As ISL.Controles.Etiqueta
    Friend WithEvents DecDifGanancia As ISL.Controles.NumeroDecimal
    Friend WithEvents lblTotalesME As ISL.Controles.Etiqueta
    Friend WithEvents UltraCalculatorDropDown1 As Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown
    Friend WithEvents chkCalculadora As ISL.Controles.Chequear
    Private WithEvents cboCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ordCliente As ISL.Controles.OrigenDatos
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraCalculatorDropDown2 As Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown
    Friend WithEvents Chequear2 As ISL.Controles.Chequear
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents OptPerdida As System.Windows.Forms.RadioButton
    Friend WithEvents OptGanancia As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents MenuDocumentos As ISL.Controles.MenuContextual
    Friend WithEvents CargarNetoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarDetracciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptCobro As System.Windows.Forms.RadioButton
    Friend WithEvents Filtro As ISL.Controles.Filtro
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbMedioPago As System.Windows.Forms.CheckBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
End Class
