﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-08-30  |   NSOFT   |   Se comento los mensaje emergentes
' @0002 |   2019-01-01  |   CT2010  |   LLenar Combo
' @0003 |   2019-10-01  |   CT2010  |   Cambiar la funcionalidad del archivo entorno.Tabla SGD.EmpresaSistemas en BD
'=================================================================================================================

Imports System.IO
Imports System.Xml
Imports System.Configuration
Imports System.Collections.Specialized
Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Net

<DataContract()> _
Public Class l_Disponibilidad
    Implements Il_Disponibilidad

    Private odEmpresaSistemas As New d_EmpresaSistemas
#Region "Declaración de variables"

    Public IPServidor As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor")

    'Archivo XML, que debe estar copiado en la carpeta compartida Imagenes del servidor
    'Public archivoXML As String = "\\" & IPServidor & "\Imagenes\Entorno.xml" '@0003
    'Public archivoXML As String = My.Computer.FileSystem.CombinePath("Imagenes", "Entorno.xml") '@0003

    'Private directorioFotos As String = "\\" & IPServidor & "\Fotos" '@0003
    Private directorioFotos As String = My.Computer.FileSystem.CombinePath("Fotos", "")


    'Public archivoXML As String = "\\" & IPServidor & "\Imagenes\Entorno2.xml"
    'Private directorioFotos As String = "D:\Fotos"

    'Public archivoXML As String = "\\" & IPServidor & "\Imagenes\Entorno3.xml"
    'Private directorioFotos As String = "\\" & IPServidor & "\Fotos2"

#End Region

#Region "Constructores"

    Public Sub New()

    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Indicador utilizada para mostrar un mensaje personalizado a los usuarios que intentan conectarse al sistema, mientras la base de datos se encuentra en mantenimiento
    ''' </summary>
    ''' <remarks></remarks>
    Private _mensajeInicial As String
    <DataMember()> _
    Public Property MensajeInicial() As String
        Get
            Return _mensajeInicial
        End Get
        Set(ByVal value As String)
            _mensajeInicial = value
        End Set
    End Property

    ''' <summary>
    ''' Indicador utilizado para mostrar un mensaje personalizado a los usuarios que están conectados al sistema, minutos antes que la base de datos pase a estar en mantenimiento
    ''' </summary>
    ''' <remarks></remarks>
    Private _mensajeUsuariosConectados As String
    <DataMember()> _
    Public Property MensajeUsuariosConectados() As String
        Get
            Return _mensajeUsuariosConectados
        End Get
        Set(ByVal value As String)
            _mensajeUsuariosConectados = value
        End Set
    End Property

    ''' <summary>
    ''' Indicador que permite determinar la disponibilidad de la conexión a la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private _estadoDisponibilidadBD As String
    <DataMember()> _
    Public Property EstadoDisponibilidadBD() As String
        Get
            Return _estadoDisponibilidadBD
        End Get
        Set(ByVal value As String)
            _estadoDisponibilidadBD = value
        End Set
    End Property

    ''' <summary>
    ''' Indicador que permite indicar si la réplica de la bd está Activa o no.
    ''' </summary>
    ''' <remarks></remarks>
    Private _estadoDisponibilidadReplica As String
    <DataMember()> _
    Public Property EstadoDisponibilidadReplica() As String
        Get
            Return _estadoDisponibilidadReplica
        End Get
        Set(ByVal value As String)
            _estadoDisponibilidadReplica = value
        End Set
    End Property

#End Region

#Region "Métodos"

    ' ''' <summary>
    ' ''' Obtener una entidad de tipo e_DisponibilidadBaseDatos
    ' ''' </summary>
    ' ''' <param name="disponibilidadBaseDatos"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function Obtener(ByVal disponibilidadBaseDatos As e_DisponibilidadBaseDatos) As e_DisponibilidadBaseDatos Implements Ie_DisponibilidadBaseDatos.Obtener
    '    Return disponibilidadBaseDatos
    'End Function

    ''' <summary>
    ''' Función para obtener el estado de disponibilidad de acceso a la base de datos
    ''' a partir de la información contenida en el archivo de configuración Entorno.xml
    ''' ubicado en la carpeta compartida /Imagenes del servidor
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VerificarDisponibilidadBD() As Boolean Implements Il_Disponibilidad.VerificarDisponibilidadBD
        Try
            'Dim m_xmld As XmlDocument
            'Dim m_nodelist As XmlNodeList
            'Dim m_node As XmlNode
            ''Creamos el "XML Document"
            'm_xmld = New XmlDocument()
            'If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la disponibilidad del acceso a la base de datos")
            'm_xmld.Load(archivoXML)
            ''Obtenemos la lista de los nodos "name"
            'm_nodelist = m_xmld.SelectNodes("/Entorno/ConexionBD")
            ''Iniciamos el ciclo de lectura
            'For Each m_node In m_nodelist
            '    'Obtenemos el atributo del Estado
            '    EstadoDisponibilidadBD = m_node.Attributes.GetNamedItem("EstadoDisponibilidadBD").Value
            '    'Obtenemos el Elemento nombre
            '    MensajeInicial = m_node.ChildNodes.Item(0).InnerText
            '    'Obtenemos el Elemento apellido
            '    MensajeUsuariosConectados = m_node.ChildNodes.Item(1).InnerText
            'Next
            'If EstadoDisponibilidadBD = "Activa" Then Return True

            '@0003
            Dim oeEmpresaSistema As New e_EmpresaSistemas
            oeEmpresaSistema = odEmpresaSistemas.Obtener(oeEmpresaSistema)
            With oeEmpresaSistema
                If .EstadoDisponibilidadBD.Trim = "Activa" Then
                    Return True
                Else
                    MensajeInicial = .MensajeInicialBD.Trim
                    MensajeUsuariosConectados = .MensajeUsuariosConectadosBD.Trim
                End If
            End With
            '@0003
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función para obtener el estado de disponibilidad de la replicación de datos
    ''' a partir de la información contenida en el archivo de configuración Entorno.xml
    ''' ubicado en la carpeta compartida /Imagenes del servidor    
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VerificarDisponibilidadReplica() As Boolean Implements Il_Disponibilidad.VerificarDisponibilidadReplica
        Try
            '@0003 Inicio Comentario
            'Dim m_xmld As XmlDocument
            'Dim m_nodelist As XmlNodeList
            'Dim m_node As XmlNode
            ''Creamos el "XML Document"
            'm_xmld = New XmlDocument()
            'If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la disponibilidad del acceso a la base de datos")
            'm_xmld.Load(archivoXML)
            ''Obtenemos la lista de los nodos "name"
            'm_nodelist = m_xmld.SelectNodes("/Entorno/ConexionReplica")
            ''Iniciamos el ciclo de lectura
            'For Each m_node In m_nodelist
            '    'Obtenemos el atributo del Estado
            '    EstadoDisponibilidadReplica = m_node.Attributes.GetNamedItem("EstadoDisponibilidadReplica").Value
            '    'Obtenemos el Elemento nombre
            '    MensajeInicial = m_node.ChildNodes.Item(0).InnerText
            '    'Obtenemos el Elemento apellido
            '    MensajeUsuariosConectados = m_node.ChildNodes.Item(1).InnerText
            'Next
            'If EstadoDisponibilidadReplica = "Activa" Then Return True
            '@0003 Inicio
            Dim oeEmpresaSistema As New e_EmpresaSistemas
            oeEmpresaSistema = odEmpresaSistemas.Obtener(oeEmpresaSistema)
            With oeEmpresaSistema
                If .EstadoDisponibilidadReplica.Trim = "Activa" Then
                    Return True
                Else
                    MensajeInicial = .MensajeInicialRP.Trim
                    MensajeUsuariosConectados = .MensajeUsuariosConectadosRP.Trim
                End If
            End With
            '@0003 Fin
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FotosDisponibles() As Boolean Implements Il_Disponibilidad.FotosDisponibles
        Try
            If Directory.Exists(directorioFotos) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna la fecha límite para creación y/o modificación de información almacenada en el sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FechaLimite(area As gAreasSGI) As Date Implements Il_Disponibilidad.FechaLimite
        Try
            '@0003 Inicio Comentario
            'Dim m_xmld As XmlDocument
            'Dim m_nodelist As XmlNodeList
            'Dim m_node As XmlNode
            ''Creamos el "XML Document"
            'm_xmld = New XmlDocument()
            'If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la última Fecha del acceso a la base de datos")
            'm_xmld.Load(archivoXML)
            ''Obtenemos la lista de los nodos "name"
            'm_nodelist = m_xmld.SelectNodes("/Entorno/FechaLimite")
            ''Iniciamos el ciclo de lectura
            'Dim NroDias As String = String.Empty
            'For Each m_node In m_nodelist
            '    Select Case area
            '        Case gAreasSGI.Compras
            '            NroDias = m_node.Attributes.GetNamedItem("Compras").Value
            '        Case gAreasSGI.Ventas
            '            NroDias = m_node.Attributes.GetNamedItem("Ventas").Value
            '        Case gAreasSGI.Administracion
            '            NroDias = m_node.Attributes.GetNamedItem("Administracion").Value
            '        Case gAreasSGI.Contabilidad
            '            NroDias = m_node.Attributes.GetNamedItem("Contabilidad").Value
            '        Case gAreasSGI.Neumaticos
            '            NroDias = m_node.Attributes.GetNamedItem("Neumaticos").Value
            '        Case Else
            '            Throw New Exception("Area sin datos de configuración para fecha límite")
            '    End Select
            'Next
            'Return DateSerial(Now.Year, Now.Month, CInt(NroDias))
            '@0003 Inicio
            Dim NroDias As String = String.Empty
            Dim oeEmpresaSistema As New e_EmpresaSistemas
            oeEmpresaSistema = odEmpresaSistemas.Obtener(oeEmpresaSistema)
            With oeEmpresaSistema
                Select Case area
                    Case gAreasSGI.Compras
                        NroDias = .Compras.Trim
                    Case gAreasSGI.Ventas
                        NroDias = .Ventas.Trim
                    Case gAreasSGI.Administracion
                        NroDias = .Administracion.Trim
                    Case gAreasSGI.Contabilidad
                        NroDias = .Contabilidad.Trim
                    Case gAreasSGI.Neumaticos
                        NroDias = .Neumaticos.Trim
                    Case Else
                        Throw New Exception("Area sin datos de configuración para fecha límite")
                End Select
            End With
            Return DateSerial(Now.Year, Now.Month, CInt(NroDias))
            '@0003
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FechaLimitePerfil(Perifl As String) As Integer Implements Il_Disponibilidad.FechaLimitePerfil
        Try
            '@0003 Inicio Comentario
            'Dim m_xmld As XmlDocument
            'Dim m_nodelist As XmlNodeList
            'Dim m_node As XmlNode
            ''Creamos el "XML Document"
            'm_xmld = New XmlDocument()
            'If Not File.Exists(archivoXML) Then Throw New Exception("No se encuentra el archivo de Configuración para verificar la última Fecha del acceso a la base de datos")
            'm_xmld.Load(archivoXML)
            ''Obtenemos la lista de los nodos "name"
            'm_nodelist = m_xmld.SelectNodes("/Entorno/FechaLimite")
            ''Iniciamos el ciclo de lectura
            'Dim NroDias As String = String.Empty
            'For Each m_node In m_nodelist
            '    Select Case Perifl
            '        Case "Compras"
            '            NroDias = m_node.Attributes.GetNamedItem("Compras").Value
            '        Case "Ventas"
            '            NroDias = m_node.Attributes.GetNamedItem("Ventas").Value
            '        Case "Administracion"
            '            NroDias = m_node.Attributes.GetNamedItem("Administracion").Value
            '        Case "Contabilidad"
            '            NroDias = m_node.Attributes.GetNamedItem("Contabilidad").Value
            '        Case "Neumaticos"
            '            NroDias = m_node.Attributes.GetNamedItem("Neumaticos").Value
            '    End Select
            'Next
            'Return NroDias
            '@0003 Inicio
            Dim NroDias As String = String.Empty
            Dim oeEmpresaSistema As New e_EmpresaSistemas
            oeEmpresaSistema = odEmpresaSistemas.Obtener(oeEmpresaSistema)
            With oeEmpresaSistema
                Select Case Perifl
                    Case "Compras"
                        NroDias = .Compras.Trim
                    Case "Ventas"
                        NroDias = .Ventas.Trim
                    Case "Administracion"
                        NroDias = .Administracion.Trim
                    Case "Contabilidad"
                        NroDias = .Contabilidad.Trim
                    Case "Neumaticos"
                        NroDias = .Neumaticos.Trim
                End Select
            End With
            Return NroDias
            '@0003 Fin
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class

