Imports Host.Plugin.Interface.Infrastructure.Plugin
Imports System.ComponentModel.Composition

<Export(GetType(IPlugin))>
Public Class DataHandler
    Implements IPlugin

    Public Property Info As String = "FBZ" Implements IPlugin.Info

    Public Function ProcessData(pData As String) As String Implements IPlugin.ProcessData
        Info = "FBZC Custom Data" & pData
        Return "Call from " & pData
    End Function
End Class
