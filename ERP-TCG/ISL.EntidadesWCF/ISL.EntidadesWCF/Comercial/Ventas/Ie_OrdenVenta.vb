﻿Imports System.ServiceModel

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "Ie_OrdenVenta" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface Ie_OrdenVenta


    <OperationContract()>
    Function Obtener(ByVal demanda As e_OrdenVenta) As e_OrdenVenta

End Interface
