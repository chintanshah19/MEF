﻿Imports eCP.Service.PluginInterface.Infrastructure.Plugin


<ServiceContract()>
Public Interface DataManager
    Inherits IPlugin

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String
End Interface