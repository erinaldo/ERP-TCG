﻿' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Incidente" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Incidente.svc o e_Incidente.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_Incidente
    Implements Ie_Incidente
    Implements IEquatable(Of e_Incidente)

#Region "Propiedades"
    Private _id As String
    Private _codigo As String
    Private _idviaje As String
    Private _idtipoevento As String
    Private _tipoevento As String
    Private _idtipo As String
    Private _tipo As String
    Private _idoperador As String
    Private _operador As String
    Private _fechahora As Date
    Private _descripcion As String
    Private _idubicacion As String
    Private _ubicacion As String
    Private _referencialugar As String
    Private _observacion As String
    Private _estado As String
    Private _nombreestado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fechamodifica As Date
    Private _usuariomodifica As String

    <DataMember()> _
    Public Identificador As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String
    <DataMember()> _
    Public CodigoViaje As String
    <DataMember()> _
    Public Origen As String
    <DataMember()> _
    Public Destino As String
    <DataMember()> _
    Public Escala As String
    <DataMember()> _
    Public Piloto As String
    <DataMember()> _
    Public Copiloto As String
    <DataMember()> _
    Public Tracto As String
    <DataMember()> _
    Public TipoVehiculo As String
    <DataMember()> _
    Public Carreta As String
    <DataMember()> _
    Public Fecha As DateTime
    <DataMember()> _
    Public Cliente As String
    <DataMember()> _
    Public PesoToneladas As Decimal
    <DataMember()> _
    Public CargaMaterial As String

    <DataMember()> _
    Public leAreaIncidente As New List(Of e_AreaResponsableEvento)

    Public TipoOperacion As String
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdViaje() As String
        Get
            Return _idviaje
        End Get
        Set(ByVal value As String)
            _idviaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoEvento() As String
        Get
            Return _idtipoevento
        End Get
        Set(ByVal value As String)
            _idtipoevento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoEvento() As String
        Get
            Return _tipoevento
        End Get
        Set(ByVal value As String)
            _tipoevento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipo() As String
        Get
            Return _idtipo
        End Get
        Set(ByVal value As String)
            _idtipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdOperador() As String
        Get
            Return _idoperador
        End Get
        Set(ByVal value As String)
            _idoperador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Operador() As String
        Get
            Return _operador
        End Get
        Set(ByVal value As String)
            _operador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaHora() As Date
        Get
            Return _fechahora
        End Get
        Set(ByVal value As Date)
            _fechahora = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdUbicacion() As String
        Get
            Return _idubicacion
        End Get
        Set(ByVal value As String)
            _idubicacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ReferenciaLugar() As String
        Get
            Return _referencialugar
        End Get
        Set(ByVal value As String)
            _referencialugar = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NombreEstado() As String
        Get
            Return _nombreestado
        End Get
        Set(ByVal value As String)
            _nombreestado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub


#End Region

    Public Overloads Function Equals(ByVal oeIncidente As e_Incidente) _
    As Boolean Implements System.IEquatable(Of e_Incidente).Equals
        If Me.Identificador = oeIncidente.Identificador Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub DoWork() Implements Ie_Incidente.DoWork
    End Sub
End Class
