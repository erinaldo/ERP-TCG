﻿<DataContract()> _
Public Class e_SubFamiliaMaterial
    Implements Ie_SubFamiliaMaterial

#Region "Declaración de variables"
    Private _Id As String
    Private _Codigo As String = String.Empty
    Private _Nombre As String
    Private _Abreviatura As String = String.Empty
    Private _Activo As Boolean
    Private _idFamilia As String
    Private _Familia As String
    Private _Modificado As Boolean = False

    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public loCtaCtbleSubFam As New List(Of e_CtaCtbleSubFamiliaMat)
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal Id As String, _
            ByVal Codigo As String, _
            ByVal Nombre As String, _
            ByVal Abreviatura As String, _
            ByVal Activo As Boolean, _
            ByVal IdFamilia As String, _
            ByVal Familia As String)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Abreviatura = Abreviatura
        _Activo = Activo
        _idFamilia = IdFamilia
        _Familia = Familia
    End Sub
#End Region

#Region "Propiedades"
    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Abreviatura() As String
        Get
            Return _Abreviatura
        End Get
        Set(ByVal value As String)
            _Abreviatura = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Familia() As String
        Get
            Return _Familia
        End Get
        Set(ByVal value As String)
            _Familia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFamilia() As String
        Get
            Return _idFamilia
        End Get
        Set(ByVal value As String)
            _idFamilia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Modificado() As Boolean
        Get
            Return _Modificado
        End Get
        Set(ByVal value As Boolean)
            _Modificado = value
        End Set
    End Property

    Private _TipoOperacion As String

    <DataMember()> _
    Public Property TipoOperacion() As String
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As String)
            _TipoOperacion = value
        End Set
    End Property
#End Region

    Public Function Obtener(ByVal subFamiliaMaterial As e_SubFamiliaMaterial) As e_SubFamiliaMaterial Implements Ie_SubFamiliaMaterial.Obtener
        Return subFamiliaMaterial
    End Function

End Class
