﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
    Inherits System.Windows.Forms.Form

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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Haga clic para accesar al sistema", Infragistics.Win.ToolTipImage.Info, "Información del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Digite su nombre de usuario", Infragistics.Win.ToolTipImage.Warning, "Información del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Digite su clave de acceso al sistema", Infragistics.Win.ToolTipImage.Warning, "Información del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Haga clic para cerrar el sistema", Infragistics.Win.ToolTipImage.Info, "Información del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Digite su clave de acceso al sistema", Infragistics.Win.ToolTipImage.Warning, "Información del sistema", Infragistics.Win.DefaultableBoolean.[Default])
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.btnAceptarR = New ISL.Controles.Boton(Me.components)
        Me.txtUsuarioR = New ISL.Controles.Texto(Me.components)
        Me.txtPasswordR = New ISL.Controles.Password(Me.components)
        Me.btnSalirR = New ISL.Controles.Boton(Me.components)
        Me.Password1 = New ISL.Controles.Password(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Imagen5 = New ISL.Controles.Imagen(Me.components)
        Me.lblFecha = New Infragistics.Win.Misc.UltraLabel()
        Me.lblHora = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraPictureBox3 = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.txtUsuarioR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasswordR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Password1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        '
        'btnAceptarR
        '
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.login
        Appearance13.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance13.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnAceptarR.Appearance = Appearance13
        Me.btnAceptarR.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAceptarR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptarR.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnAceptarR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptarR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAceptarR.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarR.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptarR.HotTrackAppearance = Appearance14
        Me.btnAceptarR.ImageSize = New System.Drawing.Size(35, 30)
        Me.btnAceptarR.Location = New System.Drawing.Point(522, 176)
        Me.btnAceptarR.Name = "btnAceptarR"
        Me.btnAceptarR.Size = New System.Drawing.Size(45, 42)
        Me.btnAceptarR.TabIndex = 7
        Me.btnAceptarR.Text = "&"
        UltraToolTipInfo5.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo5.ToolTipText = "Haga clic para accesar al sistema"
        UltraToolTipInfo5.ToolTipTitle = "Información del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.btnAceptarR, UltraToolTipInfo5)
        '
        'txtUsuarioR
        '
        Appearance11.BorderColor = System.Drawing.Color.SteelBlue
        Appearance11.BorderColor2 = System.Drawing.Color.DarkGray
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance11.TextVAlignAsString = "Middle"
        Me.txtUsuarioR.Appearance = Appearance11
        Me.txtUsuarioR.AutoSize = False
        Me.txtUsuarioR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuarioR.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtUsuarioR.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtUsuarioR.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUsuarioR.Location = New System.Drawing.Point(417, 83)
        Me.txtUsuarioR.Name = "txtUsuarioR"
        Me.txtUsuarioR.NullText = "USUARIO"
        Appearance12.ForeColor = System.Drawing.Color.Silver
        Appearance12.TextHAlignAsString = "Center"
        Me.txtUsuarioR.NullTextAppearance = Appearance12
        Me.txtUsuarioR.Size = New System.Drawing.Size(150, 25)
        Me.txtUsuarioR.TabIndex = 5
        UltraToolTipInfo4.ToolTipImage = Infragistics.Win.ToolTipImage.Warning
        UltraToolTipInfo4.ToolTipText = "Digite su nombre de usuario"
        UltraToolTipInfo4.ToolTipTitle = "Información del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtUsuarioR, UltraToolTipInfo4)
        '
        'txtPasswordR
        '
        Appearance9.BorderColor = System.Drawing.Color.SteelBlue
        Appearance9.BorderColor2 = System.Drawing.Color.DarkGray
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance9.TextVAlignAsString = "Middle"
        Me.txtPasswordR.Appearance = Appearance9
        Me.txtPasswordR.AutoSize = False
        Me.txtPasswordR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPasswordR.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPasswordR.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtPasswordR.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPasswordR.Location = New System.Drawing.Point(417, 114)
        Me.txtPasswordR.Name = "txtPasswordR"
        Me.txtPasswordR.NullText = "CLAVE"
        Appearance10.ForeColor = System.Drawing.Color.Silver
        Appearance10.TextHAlignAsString = "Center"
        Me.txtPasswordR.NullTextAppearance = Appearance10
        Me.txtPasswordR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordR.Size = New System.Drawing.Size(150, 25)
        Me.txtPasswordR.TabIndex = 6
        UltraToolTipInfo3.ToolTipImage = Infragistics.Win.ToolTipImage.Warning
        UltraToolTipInfo3.ToolTipText = "Digite su clave de acceso al sistema"
        UltraToolTipInfo3.ToolTipTitle = "Información del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtPasswordR, UltraToolTipInfo3)
        '
        'btnSalirR
        '
        Appearance6.ForegroundAlpha = Infragistics.Win.Alpha.Opaque
        Appearance6.Image = Global.ISL.Win.My.Resources.Resources.close_1
        Me.btnSalirR.Appearance = Appearance6
        Me.btnSalirR.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnSalirR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalirR.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3D
        Me.btnSalirR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalirR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalirR.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirR.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSalirR.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSalirR.Location = New System.Drawing.Point(417, 176)
        Me.btnSalirR.Name = "btnSalirR"
        Me.btnSalirR.ShowFocusRect = False
        Me.btnSalirR.Size = New System.Drawing.Size(45, 42)
        Me.btnSalirR.TabIndex = 21
        Me.btnSalirR.Text = "&"
        UltraToolTipInfo2.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo2.ToolTipText = "Haga clic para cerrar el sistema"
        UltraToolTipInfo2.ToolTipTitle = "Información del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.btnSalirR, UltraToolTipInfo2)
        '
        'Password1
        '
        Appearance3.BorderColor = System.Drawing.Color.SteelBlue
        Appearance3.BorderColor2 = System.Drawing.Color.DarkGray
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance3.TextVAlignAsString = "Middle"
        Me.Password1.Appearance = Appearance3
        Me.Password1.AutoSize = False
        Me.Password1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Password1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Password1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Password1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Password1.Location = New System.Drawing.Point(417, 145)
        Me.Password1.Name = "Password1"
        Me.Password1.NullText = "GIRO"
        Appearance4.ForeColor = System.Drawing.Color.Silver
        Appearance4.TextHAlignAsString = "Center"
        Me.Password1.NullTextAppearance = Appearance4
        Me.Password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password1.Size = New System.Drawing.Size(150, 25)
        Me.Password1.TabIndex = 26
        UltraToolTipInfo1.ToolTipImage = Infragistics.Win.ToolTipImage.Warning
        UltraToolTipInfo1.ToolTipText = "Digite su clave de acceso al sistema"
        UltraToolTipInfo1.ToolTipTitle = "Información del sistema"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.Password1, UltraToolTipInfo1)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Imagen5
        '
        Me.Imagen5.BackColor = System.Drawing.Color.White
        Me.Imagen5.BorderShadowColor = System.Drawing.Color.Empty
        Me.Imagen5.Image = CType(resources.GetObject("Imagen5.Image"), Object)
        Me.Imagen5.Location = New System.Drawing.Point(36, 54)
        Me.Imagen5.Name = "Imagen5"
        Me.Imagen5.Size = New System.Drawing.Size(355, 174)
        Me.Imagen5.TabIndex = 12
        '
        'lblFecha
        '
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColor2 = System.Drawing.Color.White
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.ForeColor = System.Drawing.Color.Black
        Appearance8.TextHAlignAsString = "Left"
        Me.lblFecha.Appearance = Appearance8
        Me.lblFecha.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.lblFecha.Location = New System.Drawing.Point(66, 36)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(224, 17)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.UseFlatMode = Infragistics.Win.DefaultableBoolean.[False]
        '
        'lblHora
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.BackColor2 = System.Drawing.Color.Transparent
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.ForeColor = System.Drawing.Color.Black
        Appearance7.TextHAlignAsString = "Right"
        Appearance7.TextVAlignAsString = "Top"
        Me.lblHora.Appearance = Appearance7
        Me.lblHora.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.lblHora.Location = New System.Drawing.Point(297, 34)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(72, 16)
        Me.lblHora.TabIndex = 9
        '
        'UltraPictureBox3
        '
        Appearance5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraPictureBox3.Appearance = Appearance5
        Me.UltraPictureBox3.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox3.Location = New System.Drawing.Point(34, 228)
        Me.UltraPictureBox3.Name = "UltraPictureBox3"
        Me.UltraPictureBox3.Size = New System.Drawing.Size(546, 6)
        Me.UltraPictureBox3.TabIndex = 24
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Anchor = System.Windows.Forms.AnchorStyles.None
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion2.Appearance = Appearance1
        Me.Agrupacion2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.Password1)
        Me.Agrupacion2.Controls.Add(Me.UltraPictureBox3)
        Me.Agrupacion2.Controls.Add(Me.btnSalirR)
        Me.Agrupacion2.Controls.Add(Me.lblHora)
        Me.Agrupacion2.Controls.Add(Me.lblFecha)
        Me.Agrupacion2.Controls.Add(Me.txtPasswordR)
        Me.Agrupacion2.Controls.Add(Me.txtUsuarioR)
        Me.Agrupacion2.Controls.Add(Me.btnAceptarR)
        Me.Agrupacion2.Controls.Add(Me.Imagen5)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.TextHAlignAsString = "Center"
        Appearance16.TextVAlignAsString = "Top"
        Me.Agrupacion2.HeaderAppearance = Appearance16
        Me.Agrupacion2.Location = New System.Drawing.Point(-36, -6)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(611, 276)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.BackColor2 = System.Drawing.Color.Transparent
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.ForeColor = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.Font = New System.Drawing.Font("Candara", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(36, 6)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(560, 28)
        Me.UltraLabel1.TabIndex = 25
        Me.UltraLabel1.Text = "Servicios y Consultoria General - ERP Software Empresarial"
        Me.UltraLabel1.UseFlatMode = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel2
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.BackColor2 = System.Drawing.Color.Transparent
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.ForeColor = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(38, 237)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(543, 21)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Todos los Derechos Reservados - Propiedad Intelectual Protegida y Registrada. ERP" &
    " TyL"
        Me.UltraLabel2.UseFlatMode = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(543, 251)
        Me.Controls.Add(Me.Agrupacion2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de acceso al sistema"
        Me.TransparencyKey = System.Drawing.Color.Teal
        CType(Me.txtUsuarioR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasswordR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Password1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents UltraPictureBox3 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents btnSalirR As ISL.Controles.Boton
    Friend WithEvents lblHora As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblFecha As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPasswordR As ISL.Controles.Password
    Friend WithEvents txtUsuarioR As ISL.Controles.Texto
    Friend WithEvents btnAceptarR As ISL.Controles.Boton
    Friend WithEvents Imagen5 As ISL.Controles.Imagen
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Password1 As Controles.Password
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class