﻿Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Inventario
    Implements Il_Inventario
    Dim odInventario As New d_Inventario
    Dim odInventarioValorizado As New d_InventarioValorizado

    Public Function Listar(ByVal oeInventario As e_Inventario) As System.Collections.Generic.List(Of e_Inventario) Implements Il_Inventario.Listar
        Try
            Return odInventario.Listar(oeInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar1(ByVal oeInventario As e_Inventario) As System.Collections.Generic.List(Of e_Inventario) Implements Il_Inventario.Listar1
        Try
            Return odInventario.Listar1(oeInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar_Valorizado(ByVal oeInventarioValorizado As e_InventarioValorizado) As System.Collections.Generic.List(Of e_InventarioValorizado) Implements Il_Inventario.Listar_Valorizado
        Try
            Return odInventarioValorizado.Listar(oeInventarioValorizado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeInventario As e_Inventario) As e_Inventario Implements Il_Inventario.Obtener
        Try
            Return odInventario.Obtener(oeInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
