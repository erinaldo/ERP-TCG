﻿Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Deposito
    Implements Il_Deposito
    Dim odDeposito As New d_Deposito
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeDeposito As EntidadesWCF.e_Deposito) As Boolean Implements Il_Deposito.Eliminar
        Try
            Return odDeposito.Eliminar(oeDeposito)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDeposito As EntidadesWCF.e_Deposito) As Boolean Implements Il_Deposito.Guardar
        Try
            If Validar(oeDeposito) Then
                Return odDeposito.Guardar(oeDeposito)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDeposito As EntidadesWCF.e_Deposito) As System.Collections.Generic.List(Of EntidadesWCF.e_Deposito) Implements Il_Deposito.Listar
        Try
            Return odDeposito.Listar(oeDeposito)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDeposito As EntidadesWCF.e_Deposito) As EntidadesWCF.e_Deposito Implements Il_Deposito.Obtener
        Try
            Return odDeposito.Obtener(oeDeposito)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDeposito As EntidadesWCF.e_Deposito) As Boolean Implements Il_Deposito.Validar
        Try
            With oeDeposito
                l_FuncionesGenerales.ValidarCampoNoNulo(.Numero, "Debe ingresar numero de operacion")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCuentaBancaria, "Seleccione Cuenta Bancaria")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class