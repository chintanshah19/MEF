Imports System.ComponentModel
Imports System.ServiceModel

Namespace Infrastructure.Plugin

    <ServiceContract()>
    Public Interface IPlugin

        <DefaultValue("Test")>
        Property Info As String

        <OperationContract()>
        Function ProcessData(ByVal pData As String) As String
    End Interface
End Namespace
