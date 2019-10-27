﻿' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_Lado" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_Lado.svc o e_Lado.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.EntidadesWCF

Public Class e_Lado
    Implements Ie_Lado
    Implements IEquatable(Of e_Lado)

#Region "Declaracion de Variables"

    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String

#End Region

#Region "Propiedades"

    <DataMember()>
    Property Id As Integer = -1
    <DataMember()>
    Property IdEmpresaSis As String = ""
    <DataMember()>
    Property IdSucursal As String = ""
    <DataMember()>
    Property IdIsla As Integer = -1
    <DataMember()>
    Property Nombre As String = ""
    <DataMember()>
    Property Estado As Integer = -1
    <DataMember()>
    Property Usuario As String = ""
    <DataMember()>
    Property Activo As Integer = -1

#End Region

#Region "Metodos"

    Public Function Obtener(lado As e_Lado) As e_Lado Implements Ie_Lado.Obtener
        Return lado
    End Function

    Public Overloads Function Equals(other As e_Lado) As Boolean Implements IEquatable(Of e_Lado).Equals
        If Me.Id = other.Id Then Return True
        Return False
    End Function

#End Region


End Class
