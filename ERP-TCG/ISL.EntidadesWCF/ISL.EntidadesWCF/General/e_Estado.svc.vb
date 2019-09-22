﻿''' <summary>
''' Clase Estado
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Estado
    Implements Ie_Estado
    Implements IPropiedadesBasicas

#Region "Declaracion de Variables"

    Private _Id As String
    Private _Codigo As String
    Private _Nombre As String
    Private _Activo As Boolean

    Public TipoOperacion As String

#End Region

#Region "Constructor"

    Sub New()

    End Sub

    Sub New(ByVal Id As String, ByVal Codigo As String, ByVal Nombre As String, ByVal Activo As Boolean)
        _Id = Id
        _Codigo = Codigo
        _Nombre = Nombre
        _Activo = Activo
    End Sub

#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Id de Estado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Id() As String Implements IPropiedadesBasicas.Id
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    ''' <summary>
    ''' Codigo de Estado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Codigo() As String Implements IPropiedadesBasicas.Codigo
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre de Estado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Nombre() As String Implements IPropiedadesBasicas.Nombre
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    ''' <summary>
    ''' Activo de Estado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember()> _
    Public Property Activo() As Boolean Implements IPropiedadesBasicas.Activo
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal estado As e_Estado) As e_Estado Implements Ie_Estado.Obtener
        Return estado
    End Function

#End Region

End Class


