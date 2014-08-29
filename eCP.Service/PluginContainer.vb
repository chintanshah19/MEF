Imports System.ComponentModel.Composition
Imports eCP.Service.PluginInterface.Infrastructure.Plugin

Public Class PluginContainer
    <ImportMany(GetType(IPlugin))>
    Public Property Plugins As List(Of IPlugin)
End Class