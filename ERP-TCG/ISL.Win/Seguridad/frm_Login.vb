﻿Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports System.Net.Mail

Public Class frm_Login

#Region "Declaración de variables"

    'Dim olMenuProceso As New l_MenuProceso
    Dim mensajeEmergente As New c_Alertas
    Dim olUsuario As l_Usuario
    'Dim oeTrabSeguridad As New e_TrabajadorSeguridad
    'Dim olTrabSeguridad As New l_TrabajadorSeguridad

#End Region

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#Region "Eventos"



    ''' <summary>
    ''' Evento que se ejecuta cuando se hace clic en el botón Aceptar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAceptarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarR.Click
        Autenticar()
    End Sub

    Private Sub frm_Login_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Not gUsuarioSGI.Autenticado Then EnfocarControlInicial()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa al cuadro de texto del nombre del usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtUsuarioR_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuarioR.Enter
        txtUsuarioR.BackColor = Color.AliceBlue
        txtPasswordR.BackColor = Blanco

    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa datos del nombre del usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub txtUsuarioR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuarioR.ValueChanged
        txtUsuarioR.BackColor = Color.Lavender
        txtPasswordR.BackColor = Blanco
        ActivarBotonAceptar()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa datos de la clave de acceso o password
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtPasswordR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswordR.ValueChanged
        txtUsuarioR.BackColor = Blanco
        txtPasswordR.BackColor = Color.AliceBlue
        ActivarBotonAceptar()
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se ingresa al botón Aceptar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAceptarR_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptarR.Enter
        txtUsuarioR.BackColor = Blanco
        txtPasswordR.BackColor = Blanco
    End Sub

    ''' <summary>
    ''' Carga el formulario frm_Login
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim Encriptador As New ISL.Encripta.Genera
            'MsgBox(Encriptador.Desencriptar("C47F68340DCC65E21C5D1C5D402A85E3"))
            txtUsuarioR.Text = My.Settings.Usuario
            Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Default
            Dim Prefijo As New l_Configuracion
            If Prefijo.PrefijoID = "1SI" Then txtPasswordR.Text = "789-+"
            lblFecha.Text = RetornarDia(Date.Now.DayOfWeek) & " " & IIf(CStr(Date.Now.Day).Length = 2, CStr(Date.Now.Day), ("0" & CStr(Date.Now.Day))) & " de " & RetornarMes(Date.Now.Month) & " del " & Date.Now.Year
            Timer1.Start()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub linkRecuperarR_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Try
            olUsuario = New l_Usuario
            mensajeEmergente.Confirmacion(olUsuario.RecuperarClave(txtUsuarioR.Text), True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Función para verificar y/o autenticar al usuario que ingresa al SGI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Autenticar()
        Try
            olUsuario = New l_Usuario
            My.Settings.Usuario = txtUsuarioR.Text
            gUsuarioSGI = olUsuario.Autenticar(txtUsuarioR.Text, txtPasswordR.Text)
            If gUsuarioSGI.Autenticado Then
                If gUsuarioSGI.Controlado > 0 Then
                    Dim oeControlUsuario As New e_ControlUsuario
                    Dim olControlUsuario As New l_ControlUsuario
                    oeControlUsuario.IdUsuario = gUsuarioSGI.Id
                    oeControlUsuario.Ipv4 = gUsuarioSGI.ObtenerLoginWindows & "(" & gUsuarioSGI.ObtenerIP & ")"
                    oeControlUsuario.TipoOperacion = "I"
                    gIdControl = olControlUsuario.Guardar(oeControlUsuario)
                End If
                My.Settings.Save()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Evento para activar y/o desactivar el botón Aceptar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActivarBotonAceptar()
        If Not String.IsNullOrEmpty(txtUsuarioR.Text) And Not String.IsNullOrEmpty(txtPasswordR.Text) Then
            btnAceptarR.Enabled = True
        Else
            btnAceptarR.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Método para que el control inicial se cargue por defecto según corresponda
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EnfocarControlInicial()
        If Not String.IsNullOrEmpty(txtUsuarioR.Text) AndAlso txtUsuarioR.Text <> "." Then
            txtPasswordR.Focus()
            txtPasswordR.SelectAll()
        ElseIf txtUsuarioR.Text = "." OrElse String.IsNullOrEmpty(txtUsuarioR.Text) Then
            txtUsuarioR.Focus()
            txtUsuarioR.SelectAll()
        Else
            btnAceptarR.Focus()
        End If
    End Sub

#End Region

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblHora.Text = String.Format("{0:HH:mm tt}", DateTime.Now)
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se hace clic en el botón Salir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>   
    Private Sub btnSalirR_Click_1(sender As Object, e As EventArgs) Handles btnSalirR.Click
        Application.Exit()
    End Sub

    Private Sub txtPasswordR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswordR.KeyDown
        If e.KeyCode = Keys.Enter Then btnAceptarR.PerformClick()
    End Sub

    Private Sub UltraLabel1_Click(sender As Object, e As EventArgs) Handles UltraLabel1.Click

    End Sub
End Class