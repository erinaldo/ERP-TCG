﻿Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Calibraciones
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Calibraciones = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Calibraciones()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private d_OrdenVenta As New l_OrdenVenta, LISTA_CALIBRACION As New List(Of e_OrdenVenta), CALIBRACION As New e_OrdenVenta
    Private d_OrdenVentaMaterial As New l_OrdenVentaMaterial : Private LISTA_DETALLE As New List(Of e_OrdenVentaMaterial) : Private DETALLE As New e_OrdenVentaMaterial
    Private d_Orden As New l_Orden, LISTA_OS As New List(Of e_Orden), OS As New e_Orden
    Private d_OrdenMaterial As New l_OrdenMaterial, LISTA_DETALLE_OS As New List(Of e_OrdenMaterial), DETALLE_OS As New e_OrdenMaterial
    Private d_almmaterial As New l_MaterialAlmacen, loAlmMaterial As New List(Of e_Material)
    Private loInventario As New List(Of e_Inventario), oeInventario As New e_Inventario, oeMovimientoInventario As New e_RegistroInventario
    Private loEmpresa As New List(Of e_Empresa)
    Private ls_EstadoGenerado As String = ""
    Private ejecuta As Integer = 0
    Private mdblCantidadPrecio As Double = 0
    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    Private ListVendedores As New List(Of e_Combo)
    Private oeCombo As New e_Combo
    Private olCombo As New l_Combo
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            mt_Listar()
            Operacion = "Inicializa"
            mt_ControlBotoneria()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            gmt_MostrarTabs(1, ficOrdenComercial, 1)
            mt_Inicializar()
            Operacion = "Nuevo"
            mt_ControlBotoneria()
            mt_ControlColumnas()
            gbeMateriales.Expanded = True
            cbgCliente.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griOrdenComercial.Selected.Rows.Count > 0 Then
                mt_Inicializar()
                mt_Mostrar()
                gmt_MostrarTabs(1, ficOrdenComercial, 1)
                Operacion = "Editar"
                mt_ControlBotoneria()
                mt_ControlColumnas()
                gbeMateriales.Expanded = False
                Me.lblOperacion.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If fc_Guardar() Then
                gmt_MostrarTabs(0, ficOrdenComercial, 2)
                Consultar(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            'Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            '    Case Windows.Forms.DialogResult.Yes
            '        Guardar()
            '    Case Windows.Forms.DialogResult.No
            gmt_MostrarTabs(0, ficOrdenComercial, 2)
            Consultar(True)
            'End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'Throw New Exception("No es posible eliminar Ordenes de Venta, solo se permite anular")
            With griOrdenComercial
                CALIBRACION = New e_OrdenVenta
                If .Selected.Rows.Count > 0 Then
                    CALIBRACION.Id = .ActiveRow.Cells("Id").Value
                    CALIBRACION = d_OrdenVenta.Obtener(CALIBRACION)
                    If CALIBRACION.IdEstado = "1CIX043" Then
                        If MessageBox.Show("Esta seguro de eliminar la Orden: " &
                                 .ActiveRow.Cells("OrdenComercial").Value.ToString & " ?",
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            CALIBRACION.TipoOperacion = "N"
                            CALIBRACION.UsuarioCrea = gUsuarioSGI.Id
                            d_OrdenVenta.EliminarExtornar(CALIBRACION)
                            MsgBox("La Informacion ha Sido Eliminada Correctamente", MsgBoxStyle.Information, Me.Text)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("Solo Puede Eliminar Ordenes Terminadas")
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griOrdenComercial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griOrdenComercial, Me.Text)
            MyBase.Exportar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OrdenVenMaterial_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            mt_ControlBotoneria()
            If ficOrdenComercial.Tabs(0).Selected Then
                Consultar(True)
            Else
                mt_ListarOS()
                If txtCodSaldoCtaCte.Tag.ToString.Trim = "" Then
                    mt_CargarSaldoCtaCte()
                    mt_ObtenerSaldoCtaCte()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub frm_OrdenVenMaterial_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenVenMaterial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        gmt_ControlBoton()
    End Sub

    Private Sub frm_OrdenVenMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            mt_InicializarLogicas()
            mt_CargarCombos()
            mt_AsientoModelo()
            dtpFechaInicio.Value = Date.Now.AddDays(-20)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griAlmacenMaterial_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griAlmacenMaterial.InitializeLayout
        'With griAlmacenMaterial
        '    .DisplayLayout.Bands(0).SortedColumns.Add("CodigoMaterial", False, True)
        '    .DisplayLayout.GroupByBox.Hidden = True
        '    .DisplayLayout.GroupByBox.Style = GroupByBoxStyle.Compact
        'End With
    End Sub

    Private Sub griAlmacenMaterial_CellChange(sender As Object, e As CellEventArgs) Handles griAlmacenMaterial.CellChange
        Try
            griAlmacenMaterial.UpdateData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griAlmacenMaterial_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griAlmacenMaterial.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griAlmacenMaterial.DisplayLayout.Bands(0).Layout.ActiveRow
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.Yellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnBuscarMat_Click(sender As Object, e As EventArgs) Handles btnBuscarMat.Click
        Try
            mt_ListarMateriales()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub txtMaterial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMaterial.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                mt_ListarMateriales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles cbgCliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cbgCliente.Text.Trim) Then
                    gmt_ListarEmpresa("6", cbgCliente, String.Empty, cbRuc.Checked)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbgCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cbgCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub griOrdenComercialMaterial_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griOrdenComercialMaterial.AfterCellUpdate
        Try
            Dim bolIgv As Boolean
            Dim dblPrecioUnitario As Double = 0
            Dim dblCostoUnitario As Double = 0
            Dim dblDscto As Double = 0
            Dim strGlosa As String = ""
            If griOrdenComercialMaterial.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Seleccion"
                        With griOrdenComercialMaterial.Rows(e.Cell.Row.Index)
                            If .Cells("Seleccion").Value Then
                                .Appearance.BackColor = Color.Yellow
                                .Appearance.ForeColor = Color.Red
                            Else
                                .Appearance.BackColor = Color.White
                                .Appearance.ForeColor = Color.Black
                            End If
                        End With
                    Case "IdAlmacen"
                        With griOrdenComercialMaterial
                            Dim IdAlmacen As String = ""
                            If .ActiveRow.Index > -1 Then
                                IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                gmt_ComboGrillaSubAlmacen(IdAlmacen, griOrdenComercialMaterial)
                                .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacen")
                                .ActiveRow.Cells("IdSubAlmacen").Value = gloSubAlm.Where(Function(i) i.Descripcion = IdAlmacen).ToList.Item(0).Id.Trim
                            End If
                        End With
                        'Case "IdSubAlmacen"
                        '    With griOrdenComercialMaterial
                        '        oeAlmMaterial = New e_MaterialAlmacen
                        '        If .ActiveRow.Index > -1 Then
                        '            oeAlmMaterial.TipoOperacion = "1"
                        '            oeAlmMaterial.IdEmpresaSis = gs_IdEmpresaSistema
                        '            oeAlmMaterial.IdSucursal = gs_PrefijoIdSucursal
                        '            oeAlmMaterial.IdMaterial = .ActiveRow.Cells("IdMaterial").Value
                        '            oeAlmMaterial.IdSubAlmacen = .ActiveRow.Cells("IdSubAlmacen").Value
                        '            oeAlmMaterial = olAlmMaterial.Obtener(oeAlmMaterial)
                        '            .ActiveRow.Cells("PrecioUnitario").Value = Math.Round(oeAlmMaterial.Costo * (mdblIGV + 1), 4)
                        '        End If
                        '    End With
                    Case "IndImpuesto"
                        With griOrdenComercialMaterial.Rows(e.Cell.Row.Index)
                            dblCostoUnitario = 0
                            bolIgv = .Cells("IndImpuesto").Value
                            dblCostoUnitario = .Cells("CostoUnitario").Value
                            If dblCostoUnitario = 0 Then Throw New Exception("El precio unitario sin impuesto no puede ser menor o igual a 0.")
                            If dblCostoUnitario > 0 Then
                                dblPrecioUnitario = IIf(bolIgv, dblCostoUnitario * (mdblIGV + 1), dblCostoUnitario)
                                .Cells("PrecioUnitario").Value = dblPrecioUnitario
                            End If
                        End With
                    Case "Cantidad"
                        With griOrdenComercialMaterial.ActiveRow
                            If .Cells("Cantidad").Value < 0 Then
                                .Cells("Cantidad").Value = mdblCantidadPrecio
                                Throw New Exception("El cantidad ingresada no puede ser menor o igual a 0. ")
                            End If
                            If .Cells("Cantidad").Value.Equals("") Then
                                .Cells("Cantidad").Value = 1
                            End If
                            .Cells("PrecioTotal").Value = Math.Round(.Cells("Cantidad").Value * .Cells("PrecioUnitario").Value, 4)
                            .Cells("CantidadPendiente").Value = .Cells("Cantidad").Value
                        End With
                    Case "CantidadAtender"
                        With griOrdenComercialMaterial.ActiveRow
                            If .Index > -1 Then
                                If .Cells("CantidadAtender").Value > .Cells("Cantidad").Value Then
                                    .Cells("CantidadAtender").Value = mdblCantidadPrecio
                                    Throw New Exception("La Cantidad a Atender no Puede ser Mayor al Cantidad Solicitada.")
                                End If
                                If .Cells("CantidadAtender").Value > .Cells("CantidadPendiente").Value Then
                                    .Cells("CantidadAtender").Value = mdblCantidadPrecio
                                    'Throw New Exception("La Cantidad a Atender no Puede ser Mayor a la Cantidad Pendiente.")
                                End If
                                If .Cells("CantidadAtender").Value.Equals("") Then
                                    .Cells("CantidadAtender").Value = 1
                                End If
                            End If
                        End With
                    Case "CostoUnitario"
                        dblPrecioUnitario = 0
                        dblCostoUnitario = 0
                        With griOrdenComercialMaterial.ActiveRow
                            bolIgv = .Cells("IndImpuesto").Value
                            dblCostoUnitario = .Cells("CostoUnitario").Value
                            'If dblCostoUnitario = 0 Then Throw New Exception("El precio unitario sin impuesto no puede ser menor o igual a 0.")
                            If dblCostoUnitario > 0 Then
                                dblPrecioUnitario = IIf(bolIgv, dblCostoUnitario * (mdblIGV + 1), dblCostoUnitario)
                                If dblPrecioUnitario < .Cells("Dscto").Value Then
                                    .Cells("CostoUnitario").Value = mdblCantidadPrecio
                                End If
                                .Cells("PrecioUnitario").Value = dblPrecioUnitario - .Cells("Dscto").Value
                            End If

                            If .Cells("CostoUnitario").Value.Equals("") Then
                                .Cells("CostoUnitario").Value = 1
                            End If
                        End With
                    Case "PrecioUnitario"
                        dblPrecioUnitario = 0
                        With griOrdenComercialMaterial.Rows(e.Cell.Row.Index)
                            If .Index > -1 Then
                                dblPrecioUnitario = Convert.ToDouble(.Cells("PrecioUnitario").Value)
                                If dblPrecioUnitario < 0 Then
                                    .Cells("PrecioUnitario").Value = mdblCantidadPrecio
                                    Throw New Exception("El precio unitario con impuesto no puede ser menor o igual a 0.")
                                End If
                                If dblPrecioUnitario < .Cells("Dscto").Value Then
                                    .Cells("PrecioUnitario").Value = mdblCantidadPrecio
                                End If
                                .Cells("PrecioTotal").Value = Math.Round((.Cells("PrecioUnitario").Value - .Cells("Dscto").Value) * .Cells("Cantidad").Value, 4)
                            End If
                            If .Cells("PrecioUnitario").Value.Equals("") Then
                                .Cells("PrecioUnitario").Value = 1
                            End If
                        End With
                    Case "Dscto"
                        dblDscto = 0
                        With griOrdenComercialMaterial.Rows(e.Cell.Row.Index)
                            If .Index > -1 Then
                                dblDscto = Convert.ToDouble(.Cells("Dscto").Value)
                                If dblDscto < 0 Then
                                    .Cells("Dscto").Value = mdblCantidadPrecio
                                    Throw New Exception("El descuento no puede ser menor o igual a 0.")
                                End If
                                If dblDscto > .Cells("PrecioUnitario").Value Then
                                    .Cells("Dscto").Value = mdblCantidadPrecio
                                    Throw New Exception("El Descuento no puede ser mayor al Total.")
                                End If
                                .Cells("PrecioTotal").Value = Math.Round((.Cells("PrecioUnitario").Value - .Cells("Dscto").Value) * .Cells("Cantidad").Value, 4)
                                .Cells("PDscto").Value = Math.Round(.Cells("Dscto").Value * 100 / .Cells("PrecioUnitario").Value, 4, MidpointRounding.AwayFromZero)
                            End If
                            If .Cells("Dscto").Value.Equals("") Then
                                .Cells("Dscto").Value = 0
                            End If
                        End With
                    Case "Glosa"
                        With griOrdenComercialMaterial.Rows(e.Cell.Row.Index)
                            If .Index > -1 Then
                                If IsDBNull(e.Cell.Value) Then
                                    e.Cell.Value = strGlosa
                                End If
                            End If
                        End With
                End Select
            End If
            mt_CalcularTotalOrden()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griOrdenComercialMaterial_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griOrdenComercialMaterial.BeforeCellUpdate
        Try
            With griOrdenComercialMaterial
                Select Case e.Cell.Column.Key
                    Case "Cantidad", "CostoUnitario", "PrecioUnitario", "CantidadAtender", "Dscto"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0.0
                        mdblCantidadPrecio = e.Cell.Value
                    Case "Glosa"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griOrdenComercialMaterial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griOrdenComercialMaterial.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdenComercialMaterial_CellChange(sender As Object, e As CellEventArgs) Handles griOrdenComercialMaterial.CellChange
        griOrdenComercialMaterial.UpdateData()
    End Sub

    Private Sub rdbNroOrden_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNroOrden.CheckedChanged
        If rdbNroOrden.Checked Then
            grbDatosBasicos.Enabled = False
            grbNroOrden.Enabled = True
            txtNroOrden.Focus()
        Else
            grbDatosBasicos.Enabled = True
            grbNroOrden.Enabled = False
        End If
    End Sub

    Private Sub rdbDatosBasicos_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDatosBasicos.CheckedChanged
        If rdbDatosBasicos.Checked Then
            grbDatosBasicos.Enabled = True
            grbNroOrden.Enabled = False
        Else
            grbDatosBasicos.Enabled = False
            grbNroOrden.Enabled = True
            txtNroOrden.Focus()
        End If
    End Sub

    Private Sub griOrdenComercialMaterial_ClickCellButton(sender As Object, e As CellEventArgs) Handles griOrdenComercialMaterial.ClickCellButton
        Try
            With griOrdenComercialMaterial
                Select Case e.Cell.Column.Key
                    Case "CantidadPendiente"
                        .ActiveRow.Cells("CantidadAtender").Value = .ActiveCell.Value
                        .ActiveRow.Selected = True
                End Select
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griOrdenComercial_DoubleClick(sender As Object, e As EventArgs) Handles griOrdenComercial.DoubleClick
        If griOrdenComercial.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griOrdenComercial_AfterRowActivate(sender As Object, e As EventArgs) Handles griOrdenComercial.AfterRowActivate
        btnAtender.Enabled = 0 : btnAnular.Enabled = 0 : btnEliminar.Enabled = 0
        If griOrdenComercial.ActiveRow.Index > -1 Then
            Select Case griOrdenComercial.ActiveRow.Cells("Estado").Value
                Case "EVALUADA"
                    btnAtender.Enabled = 1
                    btnAnular.Enabled = 1
                Case "ATENDIDO PARCIALMENTE"
                    btnAtender.Enabled = 1
                Case "TERMINADO"
                    btnEliminar.Enabled = 1
            End Select
        End If
        btnAnular.Enabled = 1
    End Sub

    Private Sub btnAtender_Click(sender As Object, e As EventArgs) Handles btnAtender.Click
        Editar()
        Operacion = "Atender"
        mt_ControlColumnas()
        mt_MenuDetalle(0, 1, 0, 0, 0)
        mt_ControlBotoneria()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs)
        Try
            CALIBRACION = New e_OrdenVenta
            CALIBRACION.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
            CALIBRACION.TipoOperacion = "G"
            If d_OrdenVenta.Guardar(CALIBRACION) Then
                MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                Consultar(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            If fc_AnularOrdenVenta() Then
                MessageBox.Show("Orden de Venta Anulada satisfactoriamente", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Consultar(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub griOrdenIngreso_Click(sender As Object, e As EventArgs) Handles griOrdenSalida.Click
        Try
            '  mt_ListarDetalleOS()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub txtNroOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroOrden.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub



    Private Sub ficDetalleOrdenComercial_SelectedTabChanged(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetalleOrdenComercial.SelectedTabChanged
        Try
            Select Case ficDetalleOrdenComercial.SelectedTab.Index
                Case 0
                    If griOrdenComercialMaterial.Rows.Count > 0 Then
                        If LISTA_DETALLE.Sum(Function(i) i.CantidadPendiente) = 0 Then
                            mt_MenuDetalle(0, 0, 0, 0, 0)
                            gbeMateriales.Visible = True
                        Else
                            mt_MenuDetalle(0, 1, 0, 0, 0)
                        End If
                    Else
                        mt_MenuDetalle(0, 0, 0, 0, 0)
                        gbeMateriales.Visible = True
                    End If
                Case 1
                    mt_MenuDetalle(0, 0, 0, 0, 0)
                    gbeMateriales.Visible = False
                    griOrdenSalida.Selected.Rows.Clear()
                    For j As Integer = 0 To griOrdenSalida.Rows.Count - 1
                        griOrdenSalida.Rows.Item(j).Activated = False
                    Next
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griOrdenIngreso_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griOrdenSalida.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdenIngreso_AfterRowActivate(sender As Object, e As EventArgs) Handles griOrdenSalida.AfterRowActivate
        If ficDetalleOrdenComercial.SelectedTab.Index = 1 Then
            mnuDetalle.Tools("GenerarGuia").SharedProps.Enabled = True
            With griOrdenSalida.ActiveRow
                If .Index > -1 Then
                    If .Cells("Empresa").Value = "" Then
                        mt_MenuDetalle(0, 0, 0, 1, 0)
                    Else
                        If .Cells("Empresa").Value = "GUIA DE REMISION - REMITENTE" Then
                            If .Cells("Estado").Value = "GENERADO" Then
                                mt_MenuDetalle(0, 0, 1, 0, 0)
                            Else
                                mt_MenuDetalle(0, 0, 0, 0, 0)
                            End If
                        Else
                            If .Cells("Estado").Value = "GENERADO" Then
                                mt_MenuDetalle(0, 0, 1, 0, 0)
                            Else
                                mt_MenuDetalle(0, 0, 0, 0, 0)
                            End If
                        End If
                    End If
                Else
                    mt_MenuDetalle(0, 0, 0, 0, 0)
                End If
            End With
        End If
    End Sub

    Private Sub griAlmacenMaterial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
        e.Cancel = True
    End Sub

    Private Sub griOrdenComercial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griOrdenComercial.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Me.decTipoCambio.Value = gfc_TipoCambio(dtpFecha.Value, True)
    End Sub

    Private Sub cbgCliente_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cbgCliente.EditorButtonClick
        Try
            Select Case e.Button.Key
                Case "Right"
                    'gmt_ActualizaListaGlobal(0)
                    loEmpresa = New List(Of e_Empresa)
                    cbgCliente.DataSource = loEmpresa
                    cbgCliente.Text = String.Empty
                Case "Left"
                    Dim frm As New frm_Empresa
                    frm = frm.getInstancia()
                    With frm
                        .MdiParent = frm_Menu
                        .Show()
                        .Nuevo()
                    End With
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub mnuDetalle_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    mt_AsignarMaterial()
                Case "Quitar"
                    mt_QuitarMaterial()
                Case "GenerarOS"
                    mt_GenerarOS()
                Case "GenerarGuia"
                    mt_GenerarDocumento("GenerarGuia")
                Case "EjecutarOS"
                    mt_EjecutarOS()
                Case "GenerarNotaSalida"
                    mt_GenerarDocumento("GENERARNOTASALIDA")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles cbDocumento.CheckedChanged
        If cbDocumento.Checked Then
            If CALIBRACION.Estado <> "TERMINADA" Then
                If Operacion = "Atender" Or Operacion = "Nuevo" Or Operacion = "Editar" Then
                    grbDocAsoc.Enabled = True
                    cmbTipoDocumento.Focus()
                End If
            Else
                grbDocAsoc.Enabled = False
                cbDocumento.Checked = False
            End If
        Else
            grbDocAsoc.Enabled = False
        End If
    End Sub

    Private Sub txtSerie_Enter(sender As Object, e As EventArgs) Handles txtSerie.Enter
        txtSerie.Select(0, 4)
        Me.txtSerie.SelectAll()
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
        txtNumero.Text = FormatoDocumento(CStr(gfc_ObtenerNumeroDoc(txtSerie.Text, cmbTipoDocumento.Value, 2)), 8)
    End Sub

    Private Sub txtNumero_Enter(sender As Object, e As EventArgs) Handles txtNumero.Enter
        txtNumero.Select(0, 8)
        Me.txtNumero.SelectAll()
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        txtNumero.Text = FormatoDocumento(txtNumero.Text, 8)
    End Sub

    Private Sub btnEmitirDoc_Click(sender As Object, e As EventArgs) Handles btnEmitirDoc.Click
        Try
            mt_EmitirDocumento(True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub chkTransporte_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransporte.CheckedChanged
        If chkTransporte.Checked Then
            Me.UltraGroupBox12.Size = New Size(684, 78)
        Else
            Me.UltraGroupBox12.Size = New Size(684, 39)
            cboOrigenViaje.SelectedIndex = -1
            cboDestinoViaje.SelectedIndex = -1
        End If
    End Sub

    'Private Sub btnCrearCtaCte_Click(sender As Object, e As EventArgs) Handles btnCrearCtaCte.Click
    '    Try
    '        If MessageBox.Show("Proveedor: " & cbgCliente.Text & Environment.NewLine & "Moneda: " & cmbMoneda.Text & Environment.NewLine &
    '                           "¿Desea crear Cuenta Corriente?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '            Dim _frm As New frm_CuentaCorriente()
    '            _frm = _frm.getInstancia()
    '            _frm.MdiParent = frm_Menu
    '            _frm.Show()
    '            _frm.mt_InstanciaExterna("CLIENTE", cbgCliente.Value, cmbMoneda.Value, ls_EstadoGenerado)
    '            _frm.Nuevo()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub

    Private Sub btnFacturarSer_Click(sender As Object, e As EventArgs) Handles btnFacturarSer.Click
        Try
            mt_GenerarDocumento("FACTURA_SERVICIO")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnBoletearSer_Click(sender As Object, e As EventArgs) Handles btnBoletearSer.Click
        Try
            mt_GenerarDocumento("BOLETA_SERVICIO")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgCliente_Validated(sender As Object, e As EventArgs) Handles cbgCliente.Validated
        Try
            mt_ObtenerSaldoCtaCte()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Try
            ContextMenuStrip1.Items("EliminarToolStripMenuItem").Visible = False
            If griOrdenSalida.Selected.Rows.Count > 0 Then
                If griOrdenSalida.ActiveRow.Cells("Empresa").Value = "" Then
                    ContextMenuStrip1.Items("EliminarToolStripMenuItem").Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            If Operacion = "Atender" Then
                OS = New e_Orden
                OS.Id = griOrdenSalida.ActiveRow.Cells("Id").Value
                OS.TipoReferencia = 6
                OS.UsuarioCreacion = gUsuarioSGI.Id
                If griOrdenSalida.ActiveRow.Cells("NombreReferencia").Value = "" Then
                    If d_Orden.Eliminar(OS) Then
                        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                        mt_ListarOS()
                        If txtCodSaldoCtaCte.Tag.ToString.Trim = "" Then
                            mt_CargarSaldoCtaCte()
                            mt_ObtenerSaldoCtaCte()
                        End If
                        DETALLE = New e_OrdenVentaMaterial
                        LISTA_DETALLE = New List(Of e_OrdenVentaMaterial)
                        DETALLE.IdOrdenComercial = CALIBRACION.Id
                        LISTA_CALIBRACION.AddRange(d_OrdenVenta.Listar(CALIBRACION))
                        griOrdenComercialMaterial.DataSource = LISTA_DETALLE
                        griOrdenComercialMaterial.DataBind()
                        mt_CombosGrilla(griOrdenComercialMaterial)
                    End If
                Else
                    Throw New Exception("No Puede Eliminar Orden Asociada a Documento")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub griDetalleOrden_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griDetalleOrden.AfterCellUpdate
        Try
            If griDetalleOrden.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "IdAlmacen"
                        With griDetalleOrden
                            Dim IdAlmacen As String = ""
                            If .ActiveRow.Index > -1 Then
                                IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                gmt_ComboGrillaSubAlmacen(IdAlmacen, griDetalleOrden)
                                .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacen")
                                .ActiveRow.Cells("IdSubAlmacen").Value = gloSubAlm.Where(Function(i) i.Descripcion = IdAlmacen).ToList.Item(0).Id.Trim
                            End If
                        End With
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub griDetalleOrden_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleOrden.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griDetalleOrden_CellChange(sender As Object, e As CellEventArgs) Handles griDetalleOrden.CellChange
        griDetalleOrden.UpdateData()
    End Sub

    Private Sub btn_ActualizarDetOrden_Click(sender As Object, e As EventArgs) Handles btn_ActualizarDetOrden.Click
        Try
            mt_ActualizarDetalles()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griOrdenSalida_DoubleClick(sender As Object, e As EventArgs) Handles griOrdenSalida.DoubleClick
        Try
            mt_ListarDetalleOS()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griOrdenComercialMaterial_KeyDown(sender As Object, e As KeyEventArgs) Handles griOrdenComercialMaterial.KeyDown
        Try
            With griOrdenComercialMaterial
                If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Down Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.BelowCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
                If e.KeyValue = Keys.Up Then
                    .PerformAction(UltraGridAction.ExitEditMode, False, False)
                    .PerformAction(UltraGridAction.AboveCell, False, False)
                    e.Handled = True
                    .PerformAction(UltraGridAction.EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmbTipoDocumento_Validated(sender As Object, e As EventArgs) Handles cmbTipoDocumento.Validated
        Try
            If cbgCliente.Value <> "" Then
                Dim oeCliente As New e_Empresa
                Dim olCliente As New l_Empresa
                oeCliente.Id = cbgCliente.Value
                oeCliente.TipoOperacion = "LST"
                oeCliente = olCliente.Obtener(oeCliente)
                ''''''''''''''''''''''''''''''''''''''''
                'If cmbTipoDocumento.Text = "FACTURA" Then
                '    If oeCliente.IdTipoDoc = DNI Then ''DNI
                '        MsgBox("No puede generar una factura con DNI, Por favor cambie su Cliente con numero de Ruc", MsgBoxStyle.Information, "Aviso")
                '        cmbTipoDocumento.SelectedIndex = -1
                '    End If
                'Else
                '    If oeCliente.IdTipoDoc = Ruc Then ''RUC
                '        MsgBox("No puede generar una boleta con RUC, Por favor cambie su Cliente con numero de DNI", MsgBoxStyle.Information, "Aviso")
                '        cmbTipoDocumento.SelectedIndex = -1
                '    End If
                'End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cboVendedor_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboVendedor.EditorButtonClick
        Try
            If txtEstado.Text = "TERMINADO" Or txtEstado.Text = "ATENDIDO PARCIALMENTE" Or txtEstado.Text = "ATENDIDO" Then
                ' If gUsuarioEOS.lePerfil(0).Perfil = "JEFE DE VENTAS" Then
                CALIBRACION.TipoOperacion = "W"
                CALIBRACION.IdVendedorTrabajador = cboVendedor.Value
                CALIBRACION.Id = CALIBRACION.Id
                CALIBRACION.Fecha = CALIBRACION.Fecha
                CALIBRACION.UsuarioCrea = gUsuarioSGI.Id
                CALIBRACION.lstOrdenComercialMaterial.AddRange(LISTA_DETALLE)
                d_OrdenVenta.Guardar(CALIBRACION)
                MsgBox("Se actualizó la Orden para el Vendedor: " & cboVendedor.Text, MsgBoxStyle.Information, "EOS")
                'Else
                '    MsgBox("Ud. No tiene permiso para actualizar Vendedores..!! Póngase en contacto con su Jefatura.", MsgBoxStyle.Information, "EOS")
                'End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub


#End Region

#Region "Metodos"

    Private Sub mt_Inicializar()
        'oeDocumento = New e_MovimientoDocumento
        CALIBRACION = New e_OrdenVenta
        DETALLE = New e_OrdenVentaMaterial
        LISTA_DETALLE = New List(Of e_OrdenVentaMaterial)
        griOrdenComercialMaterial.DataSource = LISTA_DETALLE
        'oeAlmMaterial = New e_Material
        loAlmMaterial = New List(Of e_Material)
        griAlmacenMaterial.DataSource = loAlmMaterial
        'loEmpresa = New List(Of e_Empresa)
        cbgCliente.DataSource = loEmpresa
        cbgCliente.Text = String.Empty
        'loOrdenSalida = New List(Of e_Orden)
        griOrdenSalida.DataSource = lista_os
        'loDetalleOrdenSalida = New List(Of e_OrdenMaterial)
        griDetalleOrden.DataSource = LISTA_DETALLE_OS
        dtpFecha.Value = Date.Now
        dtpFechaPago.Value = Date.Now
        decSubTotal.Value = 0
        decImpuesto.Value = 0
        decTotal.Value = 0
        txtOrden.Text = String.Empty
        txtEstado.Text = "POR GENERAR"
        txtGlosa.Text = String.Empty
        cmbMoneda.SelectedIndex = 0
        txtMaterial.Text = String.Empty
        gbeMateriales.Visible = True
        cboTipoPago.SelectedIndex = 0
        cmbTipoDocumento.Value = 0
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtEstadoDoc.Text = String.Empty
        ficDetalleOrdenComercial.Tabs(0).Selected = True
        cbDocumento.Enabled = True
        cbDocumento.Checked = False
        grbDocAsoc.Enabled = False
        mt_MenuDetalle(1, 1, 1, 1, 1)
        Me.decTipoCambio.Value = gfc_TipoCambio(Me.dtpFecha.Value, True)
        btnEmitirDoc.Enabled = False
        'mstrIdCuentaContable = ""
        txtCodSaldoCtaCte.Text = String.Empty
        txtCodSaldoCtaCte.Tag = String.Empty
        txtCodSaldoCtaCte.Appearance.ForeColor = Color.Black
        btnCrearCtaCte.Enabled = False
        'chkFactSer.Checked = False '19-8
        'chkFacturado.Checked = False '19-8
        btnFacturarSer.Enabled = False '19-08
        btnBoletearSer.Enabled = False
        'chkFacturado.Enabled = False '19-8
        btn_ActualizarDetOrden.Enabled = False
    End Sub

    Private Sub mt_ControlBotoneria()
        Select Case ficOrdenComercial.SelectedTab.Index
            Case 0
                If griOrdenComercial.Rows.Count > 0 Then
                    gmt_ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                Else
                    gmt_ControlBoton(1, 1)
                End If
            Case 1
                If CALIBRACION.Estado = "GENERADO" Or CALIBRACION.Estado = "" Then
                    gmt_ControlBoton(0, 0, 0, 1, 1)
                ElseIf CALIBRACION.Estado = "EVALUADA" And Operacion = "Editar" Then
                    gmt_ControlBoton(0, 0, 0, 1, 1)
                Else
                    gmt_ControlBoton(0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub mt_InicializarLogicas()
        d_OrdenVenta = New l_OrdenVenta
        d_OrdenVentaMaterial = New l_OrdenVentaMaterial
        'olAlmMaterial = New l_MaterialAlmacen
        'olCombo = New l_Combo
        'olOrdenSalida = New l_Orden
        'olDetalleOrden = New l_OrdenMaterial
        'olOrdDocumento = New l_Orden_Documento
        'olDocumento = New l_MovimientoDocumento
        'olAsientoModelo = New l_AsientoModelo
        'olReferencia = New l_AsientoModelo_Referencia
        'olCtaCtable = New l_CuentaContable
        'olTDDato = New l_TablaDinamica_Dato
        'olEstado = New l_EstadoOrden
        'olTipoDoc = New l_TipoDocumento
        'olCliente = New l_Cliente
    End Sub

    Private Sub mt_CargarCombos()
        Try

            Dim olMoneda As New l_Moneda : Dim oeMoneda As New e_Moneda
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            Dim loMoneda = olMoneda.Listar(oeMoneda)
            gmt_ComboEspecifico(cmbMoneda, loMoneda, 0, "Nombre")

            Dim loMoneda1 As New List(Of e_Moneda)
            oeMoneda = New e_Moneda
            oeMoneda.Id = ""
            oeMoneda.Nombre = "TODOS"
            loMoneda1.Add(oeMoneda)
            loMoneda1.AddRange(loMoneda)
            gmt_ComboEspecifico(cmbMonedaB, loMoneda1, 0, "Nombre")

            Dim oeTipoPago As New e_TipoPago : Dim olTipoPago As New l_TipoPago : Dim llTipoPago As New List(Of e_TipoPago)
            oeTipoPago.Id = "CERO"
            oeTipoPago.Nombre = "TODOS"
            llTipoPago.Add(oeTipoPago)
            oeTipoPago = New e_TipoPago
            oeTipoPago.Activo = True
            llTipoPago.AddRange(olTipoPago.Listar(oeTipoPago))

            oeTipoPago.Activo = True
            LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), 0)

            Dim oeTipoDoc As New e_TipoDocumento : Dim olTipoDoc As New l_TipoDocumento : Dim loTipoDoc As New List(Of e_TipoDocumento)
            oeTipoDoc.TipoOperacion = "X"
            loTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            gmt_ComboEspecifico(cmbTipoDocumento, loTipoDoc, -1)

            Dim oeEmpresa As New e_Empresa : Dim olEmpresa As New l_Empresa : Dim loEmpresaCliente As New List(Of e_Empresa)

            cbgCliente.DataSource = loEmpresaCliente
            cbgClienteAlterno.DataSource = loEmpresaCliente

            Dim olCombo As New l_Combo
            Dim ListLugar As New List(Of e_Combo)
            Dim oeCombo As New e_Combo
            oeCombo.IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
            ''Lugares
            oeCombo.TipoOperacion = "LUGAR"
            ListLugar.AddRange(olCombo.Listar(oeCombo))

            gmt_ComboEspecifico(cboOrigenViaje, ListLugar, -1)
            gmt_ComboEspecifico(cboDestinoViaje, ListLugar, -1)

            ''Vendedores
            Dim ListVendedores As New List(Of e_Combo)
            oeCombo.TipoOperacion = "VEND"
            ListVendedores.AddRange(olCombo.Listar(oeCombo))
            gmt_ComboEspecifico(cboVendedor, ListVendedores, 3)
            ' Cargar Estado
            Dim olEstado As New l_EstadoOrden : Dim leEstado As New List(Of e_EstadoOrden) : Dim oeEstado As New e_EstadoOrden
            oeEstado.Id = ""
            oeEstado.Nombre = "TODOS"
            leEstado.Add(oeEstado)
            oeEstado = New e_EstadoOrden
            oeEstado.Activo = True
            oeEstado.TipoOperacion = "2"
            leEstado.AddRange(olEstado.Listar(oeEstado))
            gmt_ComboEspecifico(cboEstado, leEstado, 3)
            '_IdEstadoOrden = cboEstadoOrden.Value
            cboEstado.SelectedIndex = 0

            'Cargar Asiento Modelo
            Dim oeAsientoModelo As e_AsientoModelo
            Dim olAsientoModelo As l_AsientoModelo
            Dim loAsientoModelo As List(Of e_AsientoModelo)
            oeAsientoModelo = New e_AsientoModelo
            oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = "1PY000000005"
            loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

            Dim _leEstAux3 = leEstado.Where(Function(it) it.Nombre = "GENERADO").ToList
            If _leEstAux3.Count > 0 Then ls_EstadoGenerado = _leEstAux3(0).Id
            ' Cargar Saldo Cuenta Corriente
            mt_CargarSaldoCtaCte()
            ' Cargar Tipo Movimiento Cuenta Corriente
            'oeTDDato = New e_TablaDinamica_Dato : leTipoMovCtaCte = New List(Of e_TablaDinamica_Dato)
            'oeTDDato.TipoOperacion = "G" : oeTDDato.TipoReferencia = "TipoMovimientoCtaCte" : oeTDDato.IdReferencia = "NOMBRE"
            'leTipoMovCtaCte = olTDDato.Listar(oeTDDato)
            'Dim _leMCCProv = leTipoMovCtaCte.Where(Function(it) it.Descripcion.Contains("CLIENTE")).ToList
            'If _leMCCProv.Count > 0 Then
            '    Dim _leProv1 = _leMCCProv.Where(Function(it) it.Descripcion.Contains("FACTURA")).ToList
            '    If _leProv1.Count > 0 Then ls_IdProv1 = _leProv1(0).Id
            '    Dim _leProv2 = _leMCCProv.Where(Function(it) it.Descripcion.Contains("CREDITO")).ToList
            '    If _leProv2.Count > 0 Then ls_IdProv2 = _leProv2(0).Id
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            With CALIBRACION
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                If rdbDatosBasicos.Checked Then
                    .IdEmpresa = cbgClienteB.Value
                    .IdEstado = cboEstado.Value
                    .Fecha = dtpFechaInicio.Value
                    .FechaCrea = dtpFechaFin.Value
                Else
                    .OrdenComercial = txtNroOrden.Text
                End If
            End With
            griOrdenComercial.DataSource = d_OrdenVenta.Listar(CALIBRACION).Where(Function(it) it.IdTipoVenta = "CALIBRACION")
            mt_CombosGrillaPrincipal(griOrdenComercial)
            For Each fila As UltraGridRow In griOrdenComercial.Rows
                Select Case fila.Cells("Estado").Value
                    Case "EVALUADA"
                        fila.CellAppearance.BackColor = Me.colorEvaluado.Color
                    Case "ATENDIDO PARCIALMENTE"
                        fila.CellAppearance.BackColor = Me.colorParcial.Color
                    Case "ATENDIDO"
                        fila.CellAppearance.BackColor = Me.colorAtendido.Color
                    Case "ANULADO"
                        fila.CellAppearance.BackColor = Me.colorAnulado.Color
                    Case "TERMINADO"
                        fila.CellAppearance.BackColor = Me.colorTerminado.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Mostrar()
        Try
            CALIBRACION = New e_OrdenVenta
            CALIBRACION.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
            CALIBRACION = d_OrdenVenta.Obtener(CALIBRACION)
            With CALIBRACION
                gmt_ListarEmpresa("", cbgCliente, .IdEmpresa, False)
                cbgCliente.Value = .IdEmpresa
                cmbMoneda.Value = .IdMoneda
                txtOrden.Text = .OrdenComercial
                txtEstado.Text = .Estado
                txtGlosa.Text = .Glosa
                decTipoCambio.Value = .TipoCambio
                decSubTotal.Value = .Total
                decImpuesto.Value = 0
                decTotal.Value = .Total
                cboVendedor.Value = .IdVendedorTrabajador
                dtpFecha.Value = .Fecha
            End With
            With DETALLE
                .IdOrdenComercial = CALIBRACION.Id
            End With
            LISTA_DETALLE = d_OrdenVentaMaterial.Listar(DETALLE)
            griOrdenComercialMaterial.DataSource = LISTA_DETALLE
            griOrdenComercialMaterial.DataBind()
            mt_CombosGrilla(griOrdenComercialMaterial)
            'If griOrdenComercial.ActiveRow.Cells("ESTADO").Text = "TERMINADO" Then
            '    ejecuta = 1 'Para mostrar --ORDENES ASOCIADAS de tipo 'V' 
            'Else
            '    ejecuta = 0 'Para mostrar --ORDENES ASOCIADAS de tipo 'C' 
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ListarMateriales()
        Try

            If txtMaterial.Text = String.Empty Then Throw New Exception("Escriba Nombre del Material")
            loAlmMaterial = d_almmaterial.Listar(New e_MaterialAlmacen With {.IdMaterial = txtMaterial.Text})
            griAlmacenMaterial.DataSource = loAlmMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mt_AsignarMaterial()
        Try
            For Each oe As e_Material In loAlmMaterial.Where(Function(i) i.Seleccion = True).ToList
                DETALLE = New e_OrdenVentaMaterial
                With DETALLE
                    oe.Seleccion = False
                    .TipoOperacion = "I"
                    .PrefijoID = gs_PrefijoIdSucursal
                    .IndImpuesto = True
                    .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    .IdSucursal = gs_PrefijoIdSucursal
                    .UsuarioCrea = gUsuarioSGI.Id
                    .IdMaterial = oe.Id
                    .Material = oe.Nombre
                    .Codigo = oe.Codigo
                    .Cantidad = 1
                    .CantidadPendiente = 1
                    .CostoUnitario = oe.Precio   'oe.CostoUnitario
                    .CostoInventario = 0 'oe.CostoUnitario
                    .PrecioUnitario = oe.Precio * (mdblIGV + 1)
                    '.IdTipoUnidadMedida = oe.idu
                    .IdAlmacen = oe.IdAlmacen
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .PrecioTotal = Math.Round(.PrecioUnitario * .Cantidad, 4)
                    .IndOperacion = IIf(chkTransporte.Checked, 1, 0)
                    .IdOrigen = cboOrigenViaje.Value
                    .IdDestino = cboDestinoViaje.Value
                End With
                If LISTA_DETALLE.Where(Function(i) i.IdMaterial = DETALLE.IdMaterial And i.TipoOperacion <> "E").ToList.Count > 0 Then
                    griOrdenComercialMaterial.DataBind()
                    mt_CalcularTotalOrden()
                    mt_CombosGrilla(griOrdenComercialMaterial)
                    griAlmacenMaterial.DataBind()
                    Throw New Exception("Material: " & DETALLE.Material & " ya Asignado a la Orden")
                End If
                LISTA_DETALLE.Add(DETALLE)
            Next
            griAlmacenMaterial.DataBind()
            griOrdenComercialMaterial.DataBind()
            mt_CalcularTotalOrden()
            mt_CombosGrilla(griOrdenComercialMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mt_QuitarMaterial()
        Try
            If griOrdenComercialMaterial.Selected.Rows.Count > 0 Then
                DETALLE = New e_OrdenVentaMaterial
                DETALLE = griOrdenComercialMaterial.ActiveRow.ListObject
                If DETALLE.TipoOperacion = "I" Then
                    LISTA_DETALLE.Remove(DETALLE)
                Else
                    DETALLE.TipoOperacion = "E"
                    griOrdenComercialMaterial.ActiveRow.Hidden = True
                End If
            End If
            griOrdenComercialMaterial.DataBind()
            mt_CalcularTotalOrden()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CombosGrilla(Grilla As UltraGrid)
        Try
            'With Grilla
            '    For j As Integer = 0 To .Rows.Count - 1
            '        Dim strIdTipoUnidad As String = .Rows(j).Cells("IdTipoUnidadMedida").Value
            '        gfc_CombroGrillaCelda("IdUnidadMedida", "Nombre", j, Grilla, olCombo.ComboGrilla(gloUniMed.Where(Function(i) i.Descripcion = strIdTipoUnidad).ToList))

            '        Dim strIdMaterial As String = .Rows(j).Cells("IdMaterial").Value.ToString
            '        gfc_CombroGrillaCelda("IdAlmacen", "Nombre", j, Grilla, olCombo.ComboGrilla(gloAlmMat.Where(Function(i) i.Descripcion = strIdMaterial).ToList))

            '        Dim strIdAlmacen As String = .Rows(j).Cells("IdAlmacen").Value.ToString
            '        gfc_CombroGrillaCelda("IdSubAlmacen", "Nombre", j, Grilla, olCombo.ComboGrilla(gloSubAlm.Where(Function(i) i.Descripcion = strIdAlmacen).ToList))
            '    Next
            '    .DataBind()
            'End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CombosGrillaPrincipal(Grilla As UltraGrid)
        Try
            With Grilla
                For j As Integer = 0 To .Rows.Count - 1
                    Dim strIdTrabajadorVendedor As String = .Rows(j).Cells("IdVendedorTrabajador").Value.ToString
                    gfc_CombroGrillaCelda("IdVendedorTrabajador", "Nombre", j, Grilla, olCombo.ComboGrilla(ListVendedores.Where(Function(i) i.Id = strIdTrabajadorVendedor).ToList))
                Next
                .DataBind()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CalcularTotalOrden()
        Try
            Dim bolIndicador As Boolean = False
            Dim dblTotalOrden As Double = 0
            For Each oe As e_OrdenVentaMaterial In LISTA_DETALLE.Where(Function(i) i.TipoOperacion <> "E").ToList
                dblTotalOrden += oe.PrecioTotal '- oe.Dscto
                If oe.IndImpuesto Then
                    bolIndicador = True
                    oe.CostoUnitario = Math.Round(oe.PrecioUnitario / (1 + mdblIGV), 2)
                Else
                    oe.CostoUnitario = Math.Round(oe.PrecioUnitario, 2, MidpointRounding.AwayFromZero)
                End If
            Next
            decTotal.Value = Math.Round(dblTotalOrden, 2)
            If bolIndicador Then
                decSubTotal.Value = Math.Round(dblTotalOrden / (1 + mdblIGV), 2)
                decImpuesto.Value = decTotal.Value - decSubTotal.Value
            Else
                decImpuesto.Value = 0
                decSubTotal.Value = decTotal.Value
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GenerarOS()
        Try
            If Mid(txtOrden.Text, 1, 5) = "OVSIS" Then
                If LISTA_DETALLE.Sum(Function(i) i.CantidadAtender) = 0 Then Throw New Exception("Cantidad a Atender no Puede ser 0.")
                If fc_LlenaObjeto() Then
                    If d_OrdenVenta.Guardar(CALIBRACION) Then
                        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                        grbDocAsoc.Enabled = False
                        cbDocumento.Checked = False
                        cbDocumento.Enabled = False
                        Me.ficDetalleOrdenComercial.Tabs(1).Selected = True
                        mt_ListarOS()
                    End If
                End If
            Else
                'If oeDocumento.Id = "" Then Throw New Exception("Tiene Que Emitir el Documento antes de Generar la Orden de Salida")
                If LISTA_DETALLE.Sum(Function(i) i.CantidadAtender) = 0 Then Throw New Exception("Cantidad a Atender no Puede ser 0.")
                If fc_LlenaObjeto() Then
                    If d_OrdenVenta.Guardar(CALIBRACION) Then
                        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                        grbDocAsoc.Enabled = False
                        cbDocumento.Checked = False
                        cbDocumento.Enabled = False
                        Me.ficDetalleOrdenComercial.Tabs(1).Selected = True
                        mt_ListarOS()
                    End If
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EjecutarOS()
        Try
            If griOrdenSalida.Selected.Rows.Count > 0 Then
                OS = New e_Orden
                OS.Id = griOrdenSalida.ActiveRow.Cells("Id").Value
                OS = d_Orden.Obtener(OS)
                DETALLE_OS = New e_OrdenMaterial
                LISTA_DETALLE_OS = New List(Of e_OrdenMaterial)
                DETALLE_OS.IdOrden = OS.Id
                DETALLE_OS.IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                LISTA_DETALLE_OS.AddRange(d_OrdenMaterial.Listar(DETALLE_OS))
                With griDetalleOrden
                    For j As Integer = 0 To .Rows.Count - 1
                        LISTA_DETALLE_OS(j).IdAlmacen = .Rows(j).Cells("IdAlmacen").Value.ToString
                        LISTA_DETALLE_OS(j).IdSubAlmacen = .Rows(j).Cells("IdSubAlmacen").Value.ToString
                    Next
                    .DataBind()
                End With
                OS.TipoOperacion = "T"
                OS.oeOrdenIngreso = New e_Orden : OS.oeOrdenSalida = New e_Orden
                mt_Inventario(LISTA_DETALLE_OS, OS.IdMovimientoInventario)
                OS.lstInventario = New List(Of e_Inventario)
                OS.lstInventario.AddRange(loInventario)
                If d_Orden.Guardar(OS, New List(Of e_RegistroInventario)) Then
                    MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                    mt_ListarOS()
                    ejecuta = 0
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GenerarDocumento(TipoDoc As String)
        Try
            Select Case TipoDoc
                Case "GenerarGuia"
                    'OS = New e_Orden
                    'OS.Id = griOrdenSalida.ActiveRow.Cells("Id").Value
                    'OS = olOrdenSalida.Obtener(OS)
                    'Dim frm As New frm_GuiaRemisionVenta
                    'frm = frm.getInstancia()
                    'With frm
                    '    .MdiParent = frm_Menu
                    '    .mt_TransponerOrdenDocumento(OS)
                    '    .Show()
                    'End With

                    'Case "FACTURA"

                    '    Dim frm As New frm_FacturaVenta
                    '    frm = frm.getInstancia
                    '    With frm
                    '        .MdiParent = frm_Menu
                    '        .mt_TransponerOCDocumento(CALIBRACION)
                    '        '.mt_TransponerOrdenDocumento(OS, CALIBRACION.IdTipoPago, IIf(CALIBRACION.Impuesto > 0, True, False))
                    '        .Show()
                    '    End With


                    'Case "BOLETA"
                    '    Dim frm As New frm_BoletaVenta
                    '    frm = frm.getInstancia
                    '    With frm
                    '        .MdiParent = frm_Menu
                    '        .mt_TransponerOCDocumento(CALIBRACION)
                    '        .Show()
                    '    End With

                    'Case "ORDEN_SERVICIO"
                    '    Dim frm As New frm_OrdenComServicio
                    '    frm = frm.getInstancia
                    '    With frm
                    '        .MdiParent = frm_Menu
                    '        '.mt_TransponerOS(CALIBRACION)
                    '        .Show()
                    '    End With

                    'Case "FACTURA_SERVICIO"
                    '    Dim frm As New frm_FacturaVenta
                    '    frm = frm.getInstancia
                    '    With frm
                    '        .MdiParent = frm_Menu
                    '        .mt_TransponerOCDocumento(CALIBRACION)
                    '        .Show()
                    '    End With

                    'Case "BOLETA_SERVICIO"
                    '    Dim frm As New frm_BoletaVenta
                    '    frm = frm.getInstancia
                    '    With frm
                    '        .MdiParent = frm_Menu
                    '        .mt_TransponerOCDocumento(CALIBRACION)
                    '        .Show()
                    '    End With

                    'Case "GENERARNOTASALIDA"
                    '    OS = New e_Orden
                    '    OS.Id = griOrdenSalida.ActiveRow.Cells("Id").Value
                    '    OS = olOrdenSalida.Obtener(OS)
                    '    Dim frm As New Frm_NotaSalida
                    '    frm = frm.getInstancia()
                    '    With frm
                    '        .MdiParent = frm_Menu
                    '        .mt_TransponerOrdenDocumento(OS)
                    '        .Show()
                    '    End With
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_ValidarGenDoc() As Boolean
        Try

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_MenuDetalle(AgregarQuitar As Boolean, Generar As Boolean, Ejecutar As Boolean, Documento As Boolean, Material As Boolean)
        Try
            mnuDetalle.Tools("Agregar").SharedProps.Enabled = AgregarQuitar
            mnuDetalle.Tools("Quitar").SharedProps.Enabled = AgregarQuitar
            mnuDetalle.Tools("GenerarOS").SharedProps.Enabled = Generar
            mnuDetalle.Tools("GenerarGuia").SharedProps.Enabled = Documento
            mnuDetalle.Tools("EjecutarOS").SharedProps.Enabled = Ejecutar
            mnuDetalle.Tools("GenerarNotaSalida").SharedProps.Enabled = Documento
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlColumnas()
        gmt_OcultarColumna(griOrdenComercialMaterial, True, "IndOperacion", "IdOrigen", "IdDestino")
        With griOrdenComercialMaterial.DisplayLayout.Bands(0)
            Select Case CALIBRACION.Estado
                Case "", "GENERADO"
                    'If Operacion = "Evaluar" Then
                    '    Me.lblOperacion.Text = "EVALUANDO OC"
                    '    .Columns("CantidadPendiente").Hidden = True
                    '    .Columns("CantidadAtender").Hidden = True
                    '    .Columns("Cantidad").CellActivation = Activation.NoEdit
                    '    .Columns("Cantidad").CellClickAction = CellClickAction.RowSelect
                    '    .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                    '    .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                    '    .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                    '    .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                    '    .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                    '    .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                    '    .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                    '    .Columns("CantidadAtender").CellActivation = Activation.NoEdit
                    '    .Columns("CantidadAtender").CellClickAction = CellClickAction.RowSelect
                    '    mt_MenuDetalle(0, 0, 0, 0, 0)
                    'Else
                    Me.lblOperacion.Text = "GENERANDO OV"
                    .Columns("CantidadPendiente").Hidden = True
                    .Columns("CantidadAtender").Hidden = True
                    .Columns("Dscto").Hidden = False
                    .Columns("CantidadAtender").CellActivation = Activation.NoEdit
                    .Columns("CantidadAtender").CellClickAction = CellClickAction.RowSelect
                    .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                    .Columns("IndImpuesto").CellClickAction = CellClickAction.CellSelect
                    .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                    .Columns("Cantidad").CellActivation = Activation.AllowEdit
                    .Columns("Cantidad").CellClickAction = CellClickAction.EditAndSelectText
                    .Columns("CostoUnitario").CellActivation = Activation.AllowEdit
                    .Columns("CostoUnitario").CellClickAction = CellClickAction.EditAndSelectText
                    .Columns("PrecioUnitario").CellActivation = Activation.AllowEdit
                    .Columns("PrecioUnitario").CellClickAction = CellClickAction.EditAndSelectText
                    .Columns("Dscto").CellActivation = Activation.AllowEdit
                    .Columns("Dscto").CellClickAction = CellClickAction.EditAndSelectText
                    mt_MenuDetalle(1, 0, 0, 0, 1)
                    '  End If
                Case "EVALUADA", "ATENDIDO PARCIALMENTE"
                    If Operacion = "Atender" Then
                        Me.lblOperacion.Text = "ATENDIENDO OV"
                        .Columns("CantidadPendiente").Hidden = False
                        .Columns("CantidadAtender").Hidden = False
                        .Columns("Dscto").Hidden = True
                        .Columns("IndImpuesto").Hidden = True
                        .Columns("Cantidad").CellActivation = Activation.NoEdit
                        .Columns("Cantidad").CellClickAction = CellClickAction.RowSelect
                        .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                        .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                        .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                        .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                        .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                        .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                        .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                        .Columns("CantidadAtender").CellActivation = Activation.AllowEdit
                        .Columns("CantidadAtender").CellClickAction = CellClickAction.EditAndSelectText
                        .Columns("Dscto").CellActivation = Activation.NoEdit
                        .Columns("Dscto").CellClickAction = CellClickAction.RowSelect
                        If LISTA_DETALLE.Sum(Function(i) i.CantidadPendiente) = 0 Then
                            mt_MenuDetalle(0, 0, 0, 0, 0)
                        Else
                            mt_MenuDetalle(0, 1, 0, 0, 0)
                        End If
                    Else
                        Me.lblOperacion.Text = ""
                        .Columns("CantidadPendiente").Hidden = True
                        .Columns("CantidadAtender").Hidden = True
                        .Columns("Dscto").Hidden = False
                        .Columns("IndImpuesto").Hidden = False
                        .Columns("Cantidad").CellActivation = Activation.NoEdit
                        .Columns("Cantidad").CellClickAction = CellClickAction.RowSelect
                        .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                        .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                        .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                        .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                        .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                        .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                        .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                        .Columns("CantidadAtender").CellActivation = Activation.NoEdit
                        .Columns("CantidadAtender").CellClickAction = CellClickAction.RowSelect
                        .Columns("Dscto").CellActivation = Activation.NoEdit
                        .Columns("Dscto").CellClickAction = CellClickAction.RowSelect
                        mt_MenuDetalle(0, 0, 0, 0, 0)
                    End If
                Case "ATENDIDO"
                    .Columns("CantidadPendiente").Hidden = True
                    .Columns("CantidadAtender").Hidden = True
                    .Columns("Dscto").Hidden = False
                    .Columns("IndImpuesto").Hidden = False
                    .Columns("Cantidad").CellActivation = Activation.NoEdit
                    .Columns("Cantidad").CellClickAction = CellClickAction.RowSelect
                    .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                    .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                    .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                    .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                    .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                    .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                    .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                    .Columns("CantidadAtender").CellActivation = Activation.NoEdit
                    .Columns("CantidadAtender").CellClickAction = CellClickAction.RowSelect
                    .Columns("Dscto").CellActivation = Activation.NoEdit
                    .Columns("Dscto").CellClickAction = CellClickAction.RowSelect
                    mt_MenuDetalle(0, 0, 1, 1, 0)
                Case "TERMINADO"
                    Me.lblOperacion.Text = ""
                    .Columns("CantidadPendiente").Hidden = True
                    .Columns("CantidadAtender").Hidden = True
                    .Columns("Dscto").Hidden = False
                    .Columns("Dscto").Hidden = False
                    .Columns("Cantidad").CellActivation = Activation.NoEdit
                    .Columns("Cantidad").CellClickAction = CellClickAction.RowSelect
                    .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                    .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                    .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                    .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                    .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                    .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                    .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                    .Columns("CantidadAtender").CellActivation = Activation.NoEdit
                    .Columns("CantidadAtender").CellClickAction = CellClickAction.RowSelect
                    .Columns("Dscto").CellActivation = Activation.NoEdit
                    .Columns("Dscto").CellClickAction = CellClickAction.RowSelect
                    mt_MenuDetalle(0, 0, 0, 0, 0)
            End Select
        End With
    End Sub

    Private Sub mt_ListarOS()
        Try
            OS = New e_Orden
            LISTA_OS = New List(Of e_Orden)
            ' If ejecuta = 0 Then : OS.TipoOperacion = "C" : Else : OS.TipoOperacion = "V" : End If
            OS.TipoOperacion = "V"
            OS.NroOrden = CALIBRACION.Id
            OS.IdMovimientoInventario = 6
            LISTA_OS.AddRange(d_Orden.Listar(OS))
            griOrdenSalida.DataSource = LISTA_OS
            For Each fila As UltraGridRow In griOrdenSalida.Rows
                Select Case fila.Cells("Estado").Value
                    Case "GENERADO"
                        fila.CellAppearance.BackColor = Color.White
                    Case "ATENDIDO"
                        fila.CellAppearance.BackColor = Me.colorAtendido.Color
                    Case "TERMINADO"
                        fila.CellAppearance.BackColor = Color.LightGreen
                End Select

                '--20-08-2015
                'If UCase(fila.Cells("Empresa").Text).Trim = "GUIA DE REMISION - REMITENTE" Then
                '    If chkFactSer.Checked Then
                '        btnFacturarSer.Enabled = True
                '        btnBoletearSer.Enabled = True
                '    Else
                '        btnFacturarSer.Enabled = False
                '        btnBoletearSer.Enabled = False
                '    End If

                '    If chkFacturado.Checked Then btnFacturarSer.Enabled = False : btnBoletearSer.Enabled = False
                '    'Exit For
                'End If
                '---
            Next
            griOrdenSalida.Selected.Rows.Clear()
            For j As Integer = 0 To griOrdenSalida.Rows.Count - 1
                griOrdenSalida.Rows.Item(j).Activated = False
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ListarDetalleOS()
        Try
            If griOrdenSalida.Selected.Rows.Count > 0 Then
                DETALLE_OS = New e_OrdenMaterial
                LISTA_DETALLE_OS = New List(Of e_OrdenMaterial)
                DETALLE_OS.IdOrden = griOrdenSalida.ActiveRow.Cells("Id").Value
                LISTA_DETALLE_OS = d_OrdenMaterial.Listar(DETALLE_OS)
                griDetalleOrden.DataSource = LISTA_DETALLE_OS
                mt_CombosGrilla(griDetalleOrden)
                If griOrdenSalida.ActiveRow.Cells("IdEstado").Value = "1CIX025" Then
                    btn_ActualizarDetOrden.Enabled = True
                Else
                    btn_ActualizarDetOrden.Enabled = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Inventario(lo As List(Of e_OrdenMaterial), IdTipoMovimiento As String)
        Try
            Dim FechaServidor As Date = ObtenerFechaServidor()
            loInventario = New List(Of e_Inventario)
            For Each oe As e_OrdenMaterial In lo
                oeInventario = New e_Inventario
                With oeInventario
                    .IdSucursalSistema = gs_PrefijoIdSucursal
                    .IdEmpresaSistema = gs_IdClienteProveedorSistema.Trim
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .CantidadSalida = oe.CantidadMaterial
                    If CALIBRACION.IdMoneda = "1CIX00000000000005" Then
                        .ValorUnitario = Math.Round(oe.PrecioUnitario / (mdblIGV + 1), 4)
                    Else
                        .ValorUnitario = Math.Round(oe.PrecioUnitario * decTipoCambio.Value / (mdblIGV + 1), 4)
                    End If
                    .Usuario = gUsuarioSGI.Id
                    .FechaCreacion = FechaServidor
                End With
                oeMovimientoInventario = New e_RegistroInventario
                With oeMovimientoInventario
                    .TipoOperacion = "I"
                    .IdSucursal = gs_PrefijoIdSucursal
                    .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    '.IdTipoMovimientoInventario = IdTipoMovimiento
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .Cantidad = oe.CantidadMaterial
                End With
                'oeInventario.oeMovimientoInventario = New e_MovimientoInventario
                'oeInventario.oeMovimientoInventario = oeMovimientoInventario
                loInventario.Add(oeInventario)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub mt_GeneraDocumento()
    '    Try
    '        oeDocumento = New e_MovimientoDocumento
    '        With oeDocumento
    '            .TipoOperacion = "I"
    '            .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
    '            .IdSucursal = gs_PrefijoIdSucursal
    '            .PrefijoID = gs_PrefijoIdSucursal
    '            .IdClienteProveedor = CALIBRACION.IdEmpresa
    '            .IdTipoDocumento = cmbTipoDocumento.Value
    '            .IdEstadoDocumento = "1CIX025"
    '            .IdPeriodo = ""
    '            '.CuentaContable = ""
    '            .IdMoneda = cmbMoneda.Value
    '            .Tipo = 2
    '            .IdTipoBien = 1
    '            If txtSerie.Text <> "" Then .Serie = FormatoDocumento(txtSerie.Text, 4)
    '            If txtNumero.Text <> "" Then .Numero = FormatoDocumento(txtNumero.Text, 8)
    '            .FechaEmision = dtpFechaDoc.Value
    '            .FechaVencimiento = dtpFechaPago.Value
    '            .NoGravado = 0
    '            .IndCompraVenta = 2
    '            .SubTotal = Math.Round(decSubTotal.Value, 2)
    '            .IGV = Math.Round(decImpuesto.Value, 2)
    '            .Total = Math.Round(decTotal.Value, 2)
    '            .Saldo = .Total
    '            .TipoCambio = decTipoCambio.Value
    '            .IdUsuarioCrea = gUsuarioSGI.Id
    '            .Mac_PC_Local = MacPCLocal()
    '            .lstDetalleDocumento = New List(Of e_DetalleDocumento)
    '            .lstDetalleDocumento = fc_DetalleDoc()
    '            '.lstOrdenDocumento = New List(Of e_Orden_Documento)
    '            '.lstOrdenDocumento = fc_OrdDocumento()
    '            .Venta = New e_Venta
    '            .Venta = fc_LlenarVenta()
    '        End With
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub mt_AsientoModelo()
        'Try
        '    oeReferencia = New e_AsientoModelo_Referencia
        '    loReferencia = New List(Of e_AsientoModelo_Referencia)
        '    oeReferencia.TipoOperacion = "N"
        '    'oeReferencia.IdReferencia = ls_IdActividadNegocio
        '    oeReferencia.Activo = True
        '    loReferencia = olReferencia.Listar(oeReferencia)
        '    If loReferencia.Count > 0 Then DTReferencia = gfc_GeneraDTRef(loReferencia)
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub mt_ListarCtaCtble(ByVal numEjercicio As Integer)
        'Try
        '    oeCtaCtble = New e_CuentaContable
        '    oeCtaCtble.Ejercicio = numEjercicio
        '    oeCtaCtble.TipoOperacion = "N"
        '    oeCtaCtble.Movimiento = 1 : oeCtaCtble.CuentaAsociada = New List(Of e_CuentaAsociada)
        '    'oeCtaCtble.MonedaExtranjera = -1 : oeCtaCtble.FlujoCaja = -1 : oeCtaCtble.Conciliacion = -1
        '    'oeCtaCtble.IndDocumento = -1
        '    'oeCtaCtble.ob = -1
        '    'oeCtaCtble.de = -1 : oeCtaCtble.IndHaber = -1
        '    loCtaCtble = olCtaCtable.Listar(oeCtaCtble)
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub mt_ObtenerAsiento(IdMoneda As String)
        'Try
        '    dtAux = New Data.DataTable
        '    Dim _rwAux() As Data.DataRow
        '    Dim cadSQL As String = String.Empty
        '    Dim _TipoDocAux As String = String.Empty
        '    cadSQL = "TipoRef1 = 5 AND IdRef1 = '" & IdMoneda & "'"
        '    _rwAux = DTReferencia.Select(cadSQL, "")
        '    If _rwAux.Count = 0 Then Throw New Exception("No existe configuración contable para Ventas.")
        '    dtAux = _rwAux.CopyToDataTable
        '    oeAsientoModelo = New e_AsientoModelo
        '    oeAsientoModelo.TipoOperacion = "" : oeAsientoModelo.Activo = True : oeAsientoModelo.CargaCompleta = True : oeAsientoModelo.Cuentas = -1
        '    oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
        '    oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
        '    For Each oe As e_DetalleAsientoModelo In oeAsientoModelo.leDetalle
        '        oeCtaCtble = New e_CuentaContable
        '        oeCtaCtble.Cuenta = oe.Cuenta : oeCtaCtble.TipoBusca = 2
        '        oeEmpresa = New e_Empresa
        '        Dim olEmpresa As New l_Empresa
        '        oeEmpresa.TipoOperacion = "CLI"
        '        oeEmpresa.Id = CALIBRACION.IdEmpresa
        '        oeEmpresa = olEmpresa.Obtener(oeEmpresa)
        '        If Microsoft.VisualBasic.Left(oe.Cuenta.Trim, 2) = "12" Then '20-07
        '            If oeEmpresa.IndRelacionada Then
        '                oeCtaCtble.Cuenta = Replace(oe.Cuenta, "2", "3", 1, 1)
        '            End If
        '        End If
        '        If loCtaCtble.Contains(oeCtaCtble) Then
        '            oe.oeCtaCtble = loCtaCtble.Item(loCtaCtble.IndexOf(oeCtaCtble))
        '            'If oe.oeCtaCtble.IndDocumento Then
        '            '    mstrIdCuentaContable = oe.oeCtaCtble.Id
        '            'End If
        '        End If
        '    Next
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub mt_EmitirDocumento(IndMensaje As Boolean)
        'Try
        '    Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "VTA")
        '    oeCliente = New e_Cliente
        '    oeCliente.TipoClienteProveedor = 1
        '    oeCliente = olCliente.Obtener(oeCliente)

        '    oeMoneda = cmbMoneda.Items(cmbMoneda.SelectedIndex).ListObject

        '    oeTipoDoc = New e_TipoDocumento
        '    oeTipoDoc.TipoOperacion = ""
        '    oeTipoDoc.Id = cmbTipoDocumento.Value
        '    oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)

        '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

        '        mt_ListarCtaCtble(frm.Año1.Año)

        '        Dim oeDoc As New e_MovimientoDocumento
        '        oeDoc.Id = oeDocumento.Id : oeDoc.CargaCompleta = True
        '        oeDoc = olDocumento.Obtener(oeDoc)

        '        oeDoc.IdPeriodo = frm.cboMes.Value : oeDoc.Ejercicio = frm.Año1.Año
        '        oeDoc.Venta.TipoDoc = oeTipoDoc : oeDoc.Venta.Cliente = oeCliente : oeDoc.Venta.Moneda = oeMoneda

        '        oeAsientoModelo = New e_AsientoModelo
        '        oeAsientoModelo.Equivale = 1 : oeAsientoModelo.IdMoneda = oeMoneda.Id

        '        If loAsientoModelo.Contains(oeAsientoModelo) Then
        '            oeAsientoModelo = loAsientoModelo.Item(loAsientoModelo.IndexOf(oeAsientoModelo))
        '            oeAsientoModelo.TipoOperacion = ""
        '            oeAsientoModelo.Ejercicio = oeDoc.FechaEmision.Year
        '            oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
        '            For Each _oeDet In oeAsientoModelo.leDetalle
        '                oeCtaCtble = New e_CuentaContable
        '                oeCtaCtble.Cuenta = "12121" : oeCtaCtble.Equivale = 0
        '                If loCtaCtble.Contains(oeCtaCtble) Then
        '                    oeCtaCtble = loCtaCtble.Item(loCtaCtble.IndexOf(oeCtaCtble))
        '                    _oeDet.IdCuentaContable = oeCtaCtble.Id
        '                End If
        '            Next

        '            'oeCuentaCorriente = New e_CuentaCorriente
        '            'oeCuentaCorriente.Tipo = 3 : oeCuentaCorriente.IdTrabajador = oeMovDocumento.IdClienteProveedor
        '            'oeCuentaCorriente = olCuentaCorriente.Obtener(oeCuentaCorriente)
        '            'oeMovDocumento.IdUsuarioCrea = gUsuarioSGI.Id
        '            'If oeMovDocumento.IndAfectaAnticipo Then
        '            '    oeDocAsoc = New e_DocumentoAsociado
        '            '    oeDocAsoc.TipoOperacion = "T"
        '            '    oeDocAsoc.IdMovimientoDocumento = oeMovDocumento.Id
        '            '    oeMovDocumento.DocAsoc = olDocAsoc.Listar(oeDocAsoc)
        '            'End If
        '            'oeMovDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
        '            'If oeCuentaCorriente.Id <> "" Then
        '            '    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, False, String.Empty, b_anticipo)
        '            'Else
        '            '    With oeCuentaCorriente
        '            '        .Tipooperacion = "I" : .Tipo = 3 : .IdTrabajador = oeMovDocumento.IdClienteProveedor
        '            '        .Saldo = 0 : .TotalCargo = 0 : .TotalAbono = 0 : .Ejercicio = frm.Año1.Año : .Usuario = gUsuarioSGI.Id
        '            '        .IdEstado = "HABILITADA" : .IdMoneda = "1CH01" : .Glosa = "CUENTA DE EMPRESA"
        '            '    End With
        '            '    oeCuentaCorriente.PrefijoID = gs_PrefijoIdSucursal '@0001
        '            '    olCuentaCorriente.Guardar(oeCuentaCorriente)
        '            '    _banEmis = olMovDocumento.GuardarVentaAsiento(oeMovDocumento, oeAsientoModel, oeServCtaCtble, False, String.Empty, b_anticipo)
        '            'End If

        '            ' Actualizar Cuenta para Empresas Relacionada
        '            'Dim _oeEmpr As New e_Cliente
        '            '_oeEmpr.Equivale = 1
        '            '_oeEmpr.Id = oeDoc.IdClienteProveedor.Trim
        '            'If leCliente.Contains(_oeEmpr) Then
        '            '    _oeEmpr = leCliente.Item(leCliente.IndexOf(_oeEmpr))
        '            '    If _oeEmpr.IndRelacionada = 1 Then
        '            '        For Each _oeDet In oeAsientoModelo.leDetalle
        '            '            If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "12" Then
        '            '                Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
        '            '                Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 3) & "33" & Microsoft.VisualBasic.Right(strCuenta, 1)
        '            '                _oeDet.Cuenta = strNuevaCuenta
        '            '                oeCtaContable = New e_CuentaContable
        '            '                oeCtaContable.Cuenta = strNuevaCuenta : oeCtaContable.Equivale = 0
        '            '                If leCtaContable.Contains(oeCtaContable) Then
        '            '                    oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
        '            '                    _oeDet.IdCuentaContable = oeCtaContable.Id
        '            '                End If
        '            '            End If
        '            '        Next
        '            '    End If
        '            'End If
        '        Else
        '            Throw New Exception("No Existe Configuracion Contable")
        '        End If
        '    End If

        '    '    Ejercicio = frm.cmbEjercicio.Text
        '    '    mt_ListarCtaCtble(Ejercicio)
        '    '    Dim oeDoc As New e_MovimientoDocumento
        '    '    If frm.cmbPeriodo.Value <> gfc_ObtenerPeriodo(dtpFechaDoc.Value) Then Throw New Exception("El documento no se puede emitir, Pertenece a otro Periodo..!")
        '    '    oeDoc.TipoOperacion = "2"
        '    '    oeDoc.Id = oeDocumento.Id : oeDoc.CargaCompleta = True
        '    '    oeDoc = olDocumento.Obtener(oeDoc)
        '    '    oeDoc.TipoOperacion = "C"
        '    '    oeDoc.IdUsuarioCrea = gUsuarioSGI.Id
        '    '    oeDoc.IdPeriodo = frm.cmbPeriodo.Value
        '    '    oeDoc.IdEstadoDocumento = "1CIX020"
        '    '    oeDoc.FechaCreacion = ObtenerFechaServidor()
        '    '    mt_ObtenerAsiento(oeDoc.IdMoneda)
        '    '    oeDoc.IdCuentaContable = oeCtaCtble.Cuenta
        '    '    'oeDoc.Venta.IdAsientoModelo = oeAsientoModelo.Id
        '    '    oeDoc.Venta.TipoOperacion = "A"
        '    '    'oeDoc.Venta. = gUsuarioSGI.Id
        '    '    'If Not olAsientoModelo.GuardarVentaMaterial(oeAsientoModelo, oeDoc) Then
        '    '    '    Throw New Exception("Error Enviando el Documento")
        '    '    'Else
        '    '    '    If IndMensaje Then
        '    '    '        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
        '    '    '        gmt_MostrarTabs(0, ficOrdenComercial, 2)
        '    '    '        Consultar(True)
        '    '    '    End If
        '    '    'End If
        '    '    'If cb_CobroAutomatico.Checked Then gfc_CobroAutomatico(oeDocumento.Id, frm.cmbPeriodo.Value, loCtaCtble, oeDoc.FechaCrea)
        '    'End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub mt_CargarSaldoCtaCte()
        'Try
        '    oeSaldoCtaCte = New e_SaldoCuentaCorriente : leSaldoCtaCte = New List(Of e_SaldoCuentaCorriente)
        '    oeSaldoCtaCte.TipoOperacion = "C"
        '    leSaldoCtaCte = olSaldoCtaCte.Listar(oeSaldoCtaCte)
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub mt_ObtenerSaldoCtaCte()
        Try
            'txtCodSaldoCtaCte.Text = String.Empty : txtCodSaldoCtaCte.Tag = String.Empty
            'txtCodSaldoCtaCte.Appearance.ForeColor = Color.Black
            'btnCrearCtaCte.Enabled = False
            'Dim _IdEmpresaAux As String = String.Empty
            'If cbgCliente.Value <> "" Then _IdEmpresaAux = cbgCliente.Value 'IIf(gfc_ValidarEmpresa(cbgCliente.Value), cbgCliente.Value, "")
            'If _IdEmpresaAux <> "" AndAlso cmbMoneda.SelectedIndex > -1 Then
            '    If leSaldoCtaCte.Count > 0 Then
            '        oeSaldoCtaCte = New e_SaldoCuentaCorriente
            '        oeSaldoCtaCte.TipoBusca = 3
            '        oeSaldoCtaCte.IdReferencia = _IdEmpresaAux
            '        oeSaldoCtaCte.IdMoneda = cmbMoneda.Value
            '        If leSaldoCtaCte.Contains(oeSaldoCtaCte) Then
            '            oeSaldoCtaCte = leSaldoCtaCte.Item(leSaldoCtaCte.IndexOf(oeSaldoCtaCte))
            '            txtCodSaldoCtaCte.Text = oeSaldoCtaCte.NroCuentaCte
            '            txtCodSaldoCtaCte.Tag = oeSaldoCtaCte.Id
            '        Else
            '            txtCodSaldoCtaCte.Text = "NO TIENE CUENTA CTE"
            '            txtCodSaldoCtaCte.Tag = String.Empty
            '            txtCodSaldoCtaCte.Appearance.ForeColor = Color.Red
            '            btnCrearCtaCte.Enabled = True
            '        End If
            '    Else
            '        txtCodSaldoCtaCte.Text = "NO TIENE CUENTA CTE"
            '        txtCodSaldoCtaCte.Tag = String.Empty
            '        txtCodSaldoCtaCte.Appearance.ForeColor = Color.Red
            '        btnCrearCtaCte.Enabled = True
            '    End If
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CrearOrdendeServ()
        Try
            ''Variables de la Nueva Orden Asociada a la Actual, para el Serv. de Venta de Transporte
            Dim oeOrdenCom As New e_OrdenVenta
            Dim olOrdenCom As New l_OrdenVenta
            Dim loOrdenCom As New List(Of e_OrdenVenta)

            oeOrdenCom.Id = CALIBRACION.Id
            oeOrdenCom = olOrdenCom.Obtener(oeOrdenCom)
            oeOrdenCom.Glosa = "PRESTACION DE SERVICIOS DE TRANSPORTE"
            oeOrdenCom.Fecha = ObtenerFechaServidor()
            oeOrdenCom.TipoExistencia = "2"
            oeOrdenCom.IdOrdenReferencia = CALIBRACION.Id
            oeOrdenCom.TipoOperacion = "I"
            ''''''
            'Dim oeComercialServ As New e_OrdenVentaServicio
            'oeOrdenCom.lstOrdenComercialServicio = New List(Of e_OrdenVentaServicio)
            'For Each oe In LISTA_DETALLE
            '    With oeComercialServ
            '        .TipoOperacion = "I"
            '        .IdRequerimientoServicio = ""
            '        .IndImpuesto = True
            '        .IdEmpresaSis = gs_IdEmpresaSistema
            '        .IdSucursal = gs_PrefijoIdSucursal
            '        .UsuarioCrea = gUsuarioSGI.Id
            '        .IdServicio = "1CIX00000152"
            '        .Cantidad = 1
            '        .CostoUnitario = 1
            '        .PrecioUnitario = 1
            '        .PrecioTotal = 1
            '        oeOrdenCom.lstOrdenComercialServicio.Add(oeComercialServ)
            '    End With

            'Next
            olOrdenCom.Guardar(oeOrdenCom)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ActualizarDetalles()
        Try
            For Each oe As e_OrdenMaterial In LISTA_DETALLE_OS
                oe.TipoOperacion = "A"
                d_OrdenMaterial.Guardar(oe)
            Next
            MsgBox("Se Actualizó Correctamente el Detalle de la Orden", MsgBoxStyle.Information, Me.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region

#Region "Funciones"

    Private Function fc_Guardar() As Boolean
        Try
            If Not fc_LlenaObjeto() Then Return False
            'mt_ObtenerSaldoCtaCte()
            'If txtCodSaldoCtaCte.Tag.ToString.Trim = "" Then Throw New Exception("¡Ingrese Cuenta Corriente!")
            If d_OrdenVenta.Guardar(CALIBRACION) Then
                'If cbDocumento.Checked = True AndAlso cmbTipoDocumento.Text <> "" Then
                '    If oeDocumento.Id.Trim <> "" Then
                '        Select Case MessageBox.Show("¿Desea Emitir el Documento?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                '            Case Windows.Forms.DialogResult.Yes
                '                mt_EmitirDocumento(False)
                '        End Select
                '        MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                '        oeDocumento = New e_MovimientoDocumento
                '        oeDocumento.TipoOperacion = ""
                '        oeDocumento.Id = CALIBRACION.oeDocumento.Id
                '        oeDocumento = olDocumento.Obtener(oeDocumento)
                '        'Select Case oeDocumento.IdTipoDocumento
                '        '    Case "1CIX001"
                '        '        gmt_GeneraZip(oeDocumento.RutaImpresionXML)
                '        '    Case "1CIX007", "1CIX008"
                '        '        If oeDocumento.RutaImpresionXML <> "" Then gmt_GeneraZip(oeDocumento.RutaImpresionXML)
                '        'End Select
                '        'gmt_ImprimirDocElectronico(oeDocumento.Id, oeDocumento.IdTipoDocumento)
                '        'If My.Computer.Network.IsAvailable Then gr_EnviarEmail(oeDocumento)
                '    End If
                'End If
                'MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
                'fc_Imprimir_Documento()
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub fc_Imprimir_Documento()
        Dim id As String = ""
        Try
            'If cbDocumento.Checked = True Then
            '    If cmbTipoDocumento.Text = "FACTURA" And txtSerie.Text = "0003" Or cmbTipoDocumento.Text = "FACTURA" And txtSerie.Text = "0004" Then
            '        Dim formulario As New frm_ImpresionFacturas
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    ElseIf cmbTipoDocumento.Text = "BOLETA DE VENTA" And txtSerie.Text = "0003" Or cmbTipoDocumento.Text = "BOLETA DE VENTA" And txtSerie.Text = "0004" Then
            '        Dim formulario As New frm_ImpresionBoletas
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    ElseIf cmbTipoDocumento.Text = "FACTURA" And txtSerie.Text = "0028" Then
            '        Dim formulario As New frm_ImpresionFacturasPiedra
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    ElseIf cmbTipoDocumento.Text = "BOLETA DE VENTA" And txtSerie.Text = "0028" Then
            '        Dim formulario As New frm_ImpresionBoletasPiedra
            '        id = oeDocumento.Id
            '        formulario.mt_CargarDatos(id, "")
            '        formulario.ShowDialog()
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub mt_CobroAutomatico()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function fc_LlenaObjeto() As Boolean
        Try
            With CALIBRACION
                .PrefijoID = gs_PrefijoIdSucursal
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .UsuarioCrea = gUsuarioSGI.Login
                .Tipo = 2
                .TipoExistencia = 1
                .TipoCambio = decTipoCambio.Value
                '.IndFactSer = chkFactSer.Checked
                .IdVendedorTrabajador = cboVendedor.Value
                If cbgCliente.SelectedRow Is Nothing Then Throw New Exception("Seleccione Cliente")
                .IdEmpresa = cbgCliente.Value
                Select Case Operacion
                    Case "Nuevo"
                        .TipoOperacion = "I"
                        .IdEstado = "1CH000000011" 'Evaluado
                        If cbDocumento.Checked = True Then : .IndFacturadoProducto = True : End If
                        .IdTrabajadorAprobacion = gUsuarioSGI.oePersona.Id
                        fc_ValidarNumeroDoc()
                        'If Not fc_EmitirDocumento() Then
                        '    Return False
                        'End If
                    Case "Editar"
                        .TipoOperacion = "A"
                        If cbDocumento.Checked = True Then : .IndFacturadoProducto = True : End If
                        fc_ValidarNumeroDoc()
                        'If oeDocumento.Id = "" Then
                        '    If Not fc_EmitirDocumento() Then
                        '        Return False
                        '    End If
                        'End If
                    Case "Atender"
                        If LISTA_DETALLE.Sum(Function(i) i.CantidadAtender) = 0 Then Throw New Exception("Cantidad a Atender no Puede ser 0.")
                        .TipoOperacion = "T"
                        .oeOrdenSalida = New e_Orden
                        .oeOrdenSalida = fc_GenerarOrdenSalida()
                        '.oeOrdenSalida.IdOrdenDocumento = fc_OrdenDocumento().Id
                        For Each oe As e_OrdenVentaMaterial In LISTA_DETALLE
                            If oe.CantidadPendiente - oe.CantidadAtender >= 0 Then
                                oe.CantidadPendiente = oe.CantidadPendiente - oe.CantidadAtender
                                oe.CantidadAtender = 0
                            End If
                        Next
                        If LISTA_DETALLE.Sum(Function(i) i.CantidadPendiente) = 0 Then
                            .IdEstado = "1CIX004"
                        Else
                            .IdEstado = "1CIX005"
                        End If
                End Select
                .lstOrdenComercialMaterial = New List(Of e_OrdenVentaMaterial)
                .lstOrdenComercialMaterial.AddRange(LISTA_DETALLE)
                .Fecha = dtpFecha.Value
                .IdMoneda = cmbMoneda.Value
                .IdTipoPago = cboTipoPago.Value
                .Glosa = txtGlosa.Text
                .Total = decTotal.Value
                .SubTotal = decSubTotal.Value
                .Impuesto = decImpuesto.Value
                .TipoCompra = 0
                .IdTipoVenta = "CALIBRACION"
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ActualizarTipoPago()
        Try
            Dim oe As New e_Combo
            oe.Id = cboTipoPago.Value
            oe.Tipo = 0
            If TipoPagoPublic.Contains(oe) Then
                oe = TipoPagoPublic.Item(TipoPagoPublic.IndexOf(oe))
                dtpFechaPago.Value = dtpFecha.Value.AddDays(CInt(oe.Descripcion))
            Else
                Throw New Exception("No se Encuentra el Tipo de Pago. Verificar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Function fc_EmitirDocumento() As Boolean
    '    Try
    '        If cbDocumento.Checked Then
    '            mt_GeneraDocumento()
    '            CALIBRACION.oeDocumento = oeDocumento
    '        Else
    '            Select Case MessageBox.Show("¿Desea Guardar la Orden sin Documento?", "Mensaje del Sistema",
    '                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
    '                Case Windows.Forms.DialogResult.No
    '                    Return False
    '            End Select
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Private Function fc_GenerarOrdenSalida() As e_Orden
        Try
            OS = New e_Orden
            With OS
                .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                .IdSucursal = gs_PrefijoIdSucursal
                .Glosa = cmbTipoDocumento.Text & " " & txtSerie.Text & " - " & txtNumero.Text
                .TipoOperacion = "I"
                .TipoReferencia = "ORDEN VENTA"
                .Referencia = CALIBRACION.OrdenComercial
                .TipoCambio = decTipoCambio.Value
                .IdEmpresaSis = CALIBRACION.IdEmpresa
                .IdMovimientoInventario = "1CIX006"
                .IdMoneda = CALIBRACION.IdMoneda
                .IdEstadoOrden = "1CIX025"
                .UsuarioCreacion = gUsuarioSGI.Id
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .lstInventario = New List(Of e_Inventario)
            End With
            LISTA_DETALLE_OS = New List(Of e_OrdenMaterial)
            For Each oe As e_OrdenVentaMaterial In LISTA_DETALLE.Where(Function(i) i.CantidadAtender > 0).ToList
                DETALLE_OS = New e_OrdenMaterial
                With DETALLE_OS
                    .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
                    .IdSucursal = gs_PrefijoIdSucursal
                    .UsuarioCreacion = OS.UsuarioCreacion
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMaterial = oe.IdMaterial
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .CantidadMaterial = oe.CantidadAtender
                    .PrecioUnitario = oe.PrecioUnitario
                    '.PrecioTotal = Math.Round(.PrecioUnitario * .CantidadMaterial, 4)
                End With
                LISTA_DETALLE_OS.Add(DETALLE_OS)
            Next
            OS.Total = LISTA_DETALLE_OS.Sum(Function(i) i.PrecioUnitario * i.CantidadMaterial)
            OS.lstOrdenMaterial.AddRange(LISTA_DETALLE_OS)
            Return OS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cbgClienteAlterno_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cbgClienteAlterno.InitializeLayout
        Me.cbgClienteAlterno.ValueMember = "Id"
        Me.cbgClienteAlterno.DisplayMember = "Nombre"
        With cbgClienteAlterno.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("TipoEmpresa").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("IdDireccionTanqueo").Hidden = True
            .Columns("Morosidad").Hidden = True
            .Columns("Credito").Hidden = True
            .Columns("IndNivelComercial").Hidden = True
            .Columns("Moneda").Hidden = True
            .Columns("IndClasificacion").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("IndCategoriaEmpresaSGI").Hidden = True
            '.Columns("Activo").Hidden = True
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    'Private Function fc_DetalleDoc() As List(Of e_DetalleDocumento)
    'Try
    '    loDetDocumento = New List(Of e_DetalleDocumento)
    '    For Each oe As e_OrdenVentaMaterial In LISTA_DETALLE
    '        oeDetDocumento = New e_DetalleDocumento
    '        With oeDetDocumento
    '            .TipoOperacion = "I"
    '            .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
    '            .IdSucursal = gs_PrefijoIdSucursal
    '            .PrefijoID = gs_PrefijoIdSucursal
    '            .IdMaterialServicio = oe.IdMaterial
    '            .IdTipoUnidadMedida = oe.IdTipoUnidadMedida
    '            .IdUnidadMedida = oe.IdUnidadMedida
    '            .CodigoMaterialServicio = oe.Codigo
    '            .Cantidad = oe.Cantidad
    '            .IndGravado = oe.IndImpuesto
    '            .IndServicioMaterial = "M"
    '            .Precio = oe.PrecioUnitario
    '            .Total = oe.PrecioTotal
    '            .PrecioUnitarioSinImp = Math.Round(IIf(oe.IndImpuesto, (oe.PrecioUnitario - oe.Dscto) / (1 + mdblIGV), oe.PrecioUnitario - oe.Dscto), 4, MidpointRounding.AwayFromZero)
    '            .UsuarioCreacion = gUsuarioSGI.Id
    '        End With
    '        loDetDocumento.Add(oeDetDocumento)
    '    Next
    '    Return loDetDocumento
    'Catch ex As Exception
    '    Throw ex
    'End Try
    ' End Function

    'Private Function fc_OrdDocumento() As List(Of e_Orden_Documento)
    '    Try
    '        oeOrdDocumento = New e_Orden_Documento
    '        loOrdDocumento = New List(Of e_Orden_Documento)
    '        With oeOrdDocumento
    '            .IdOrden = CALIBRACION.Id
    '            .TipoOrden = 2
    '            .TipoOperacion = "I"
    '            .TipoExistencia = 1
    '            .UsuarioCreacion = gUsuarioSGI.Id
    '            loOrdDocumento.Add(oeOrdDocumento)
    '        End With
    '        Return loOrdDocumento
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Private Sub cbgCliente_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cbgCliente.InitializeLayout
        Me.cbgCliente.ValueMember = "Id"
        Me.cbgCliente.DisplayMember = "Nombre"
        With cbgCliente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("TipoEmpresa").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("IdDireccionTanqueo").Hidden = True
            .Columns("Morosidad").Hidden = True
            .Columns("Credito").Hidden = True
            .Columns("IndNivelComercial").Hidden = True
            .Columns("Moneda").Hidden = True
            .Columns("IndClasificacion").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("IndCategoriaEmpresaSGI").Hidden = True
            '.Columns("Activo").Hidden = True
            .Columns("Ruc").Header.Caption = "N° RUC"
            .Columns("Ruc").Width = 80
            .Columns("Nombre").Width = 250
        End With
    End Sub

    Private Sub cboTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoPago.ValueChanged
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Function fc_OrdenDocumento() As e_Orden_Documento
    '    Try
    '        oeOrdDocumento = New e_Orden_Documento
    '        With oeOrdDocumento
    '            .IdDocumento = oeDocumento.Id.Trim
    '            .IdTipoDocumento = oeDocumento.IdTipoDocumento
    '            .IdOrden = String.Empty
    '            .TipoOrden = 1
    '            .TipoOperacion = "I"
    '            .TipoExistencia = 1
    '            .UsuarioCreacion = gUsuarioSGI.Id
    '        End With
    '        Return oeOrdDocumento
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Private Function fc_LlenarVenta() As e_Venta
    '    Try
    '        oeVenta = New e_Venta
    '        With oeVenta
    '            .IdEmpresaSis = gs_IdClienteProveedorSistema.Trim
    '            .IdSucursal = gs_PrefijoIdSucursal
    '            .PrefijoID = gs_PrefijoIdSucursal
    '            .Gravado = Math.Round(decSubTotal.Value, 2)
    '            .IGV = Math.Round(decImpuesto.Value, 2)
    '            .IdTipoPago = cboTipoPago.Value
    '            .Glosa = txtGlosa.Text
    '            .IdTipoVenta = "1CH000036"
    '            .IndCliente = 2
    '            '.u = gUsuarioSGI.Id
    '            .TipoOperacion = "I"
    '            '.IdVendedorTrabajador = cboVendedor.Value
    '        End With
    '        Return oeVenta
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Private Function fc_AnularOrdenVenta() As Boolean
        Try
            CALIBRACION = New e_OrdenVenta
            CALIBRACION.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
            CALIBRACION = d_OrdenVenta.Obtener(CALIBRACION)
            CALIBRACION.TipoOperacion = "X"

            'oeOrdDocumento = New e_Orden_Documento
            'oeOrdDocumento.IdOrden = CALIBRACION.Id
            'oeOrdDocumento.TipoOrden = 2
            'oeOrdDocumento = olOrdDocumento.Obtener(oeOrdDocumento)
            'If oeOrdDocumento.Id <> "" Then Throw New Exception("Cuenta con un documento asociado, no es posible anularla")
            If d_OrdenVenta.Guardar(CALIBRACION) Then
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return False
    End Function

    Private Function fc_ValidarNumeroDoc() As Boolean
        Try
            If cbDocumento.Checked = True Then
                If txtNumero.Text = "" Or txtSerie.Text = "" Or txtNumero.Text = "0000000000" Or txtSerie.Text = "0000" Then
                    Throw New Exception("!..El Numero de Documento es Incorrecto..!")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cbgClienteAlterno_KeyDown(sender As Object, e As KeyEventArgs) Handles cbgClienteAlterno.KeyDown

    End Sub

    Private Sub cbgClienteAlterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbgClienteAlterno.KeyPress

    End Sub

#End Region

End Class