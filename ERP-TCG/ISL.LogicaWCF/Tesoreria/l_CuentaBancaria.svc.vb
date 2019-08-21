﻿Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaBancaria
    Implements Il_CuentaBancaria

    Dim odCuentaBancaria As New d_CuentaBancaria
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria) As Boolean Implements Il_CuentaBancaria.Eliminar
        Try
            Return odCuentaBancaria.Eliminar(oeCuentaBancaria)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria) As Boolean Implements Il_CuentaBancaria.Guardar
        Try
            If Validar(oeCuentaBancaria) Then
                Return odCuentaBancaria.Guardar(oeCuentaBancaria)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria) As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaBancaria) Implements Il_CuentaBancaria.Listar
        Try
            Return odCuentaBancaria.Listar(oeCuentaBancaria)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria) As EntidadesWCF.e_CuentaBancaria Implements Il_CuentaBancaria.Obtener
        Try
            Return odCuentaBancaria.Obtener(oeCuentaBancaria)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaBancaria As EntidadesWCF.e_CuentaBancaria) As Boolean Implements Il_CuentaBancaria.Validar
        Try
            With oeCuentaBancaria
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdBanco, "Seleccione banco")
                l_FuncionesGenerales.ValidarCampoNoNulo(.NumeroCuenta, "Ingrese numero de cuenta")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMoneda, "Seleccione moneda")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Contacto, "Ingrese contacto")
                l_FuncionesGenerales.ValidarCampoNoNulo(.TasaActiva, "Ingrese tasa activa")
                l_FuncionesGenerales.ValidarCampoNoNulo(.TasaPasiva, "Ingrese tasa pasiva")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdBanco, "Ingrese linea de credito")
                ValidarDuplicado(.Id, .IdBanco, .NumeroCuenta)
                If .SaldoInicial = 0 Then Throw New Exception("Saldo Inicial Tiene que ser Mayor que 0.00")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal IDBANCO As String, ByVal NUMEROCUENTA As String) As Boolean Implements Il_CuentaBancaria.ValidarDuplicado
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(IDBANCO, "No ha Ingresado el Banco")
            l_FuncionesGenerales.ValidarCampoNoNulo(NUMEROCUENTA, "No ha Ingreado el número de cuenta")
            Dim oeCuentaBancaria As New e_CuentaBancaria
            oeCuentaBancaria.Id = ID
            oeCuentaBancaria.IdBanco = IDBANCO
            oeCuentaBancaria.NumeroCuenta = NUMEROCUENTA
            oeCuentaBancaria = odCuentaBancaria.Obtener(oeCuentaBancaria)

            If oeCuentaBancaria.Id <> "" Then
                If ID = "" OrElse oeCuentaBancaria.Id <> ID Then
                    Throw New Exception("Ya existe: " & oeCuentaBancaria.NombreBanco & " " & oeCuentaBancaria.NumeroCuenta)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class