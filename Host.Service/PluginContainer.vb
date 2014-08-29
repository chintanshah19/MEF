Imports System.ComponentModel.Composition
Imports Host.Plugin.Interface.Infrastructure.Plugin

Public Class PluginContainer
    <ImportMany(GetType(IPlugin))>
    Public Property Plugins As List(Of IPlugin)
End Class