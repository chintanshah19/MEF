Imports System.ComponentModel.Composition
Imports Host.Plugin.Interface.Infrastructure.Plugin
Imports System.ComponentModel.Composition.Hosting

' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class Service1
    Implements DataManager


    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements DataManager.GetData
        Dim catalog = New AggregateCatalog()
        catalog.Catalogs.Add(New DirectoryCatalog("D:\Short\Projects\Others\Samples And R&D\My Created\MEF\eCP.Service.PluginInterface\Plugins"))
        Dim _container = New CompositionContainer(catalog)
        Dim oPluginContainer As New PluginContainer
        _container.ComposeParts(oPluginContainer)

        Dim oData As String = ""
        For Each o In oPluginContainer.Plugins
            oData &= "Plugin: " & o.Info & " \n"
            oData &= "  Plugin Method: " & o.ProcessData(" Hello ") & " \n"
        Next

        Return oData
    End Function

    Public Property Info As String Implements DataManager.Info

    Public Function ProcessData(pData As String) As String Implements DataManager.ProcessData
        Dim catalog = New AggregateCatalog()
        catalog.Catalogs.Add(New DirectoryCatalog("D:\Short\Projects\Others\Samples And R&D\My Created\MEF\eCP.Service.PluginInterface\Plugins"))
        Dim _container = New CompositionContainer(catalog)
        Dim oPluginContainer As New PluginContainer
        _container.ComposeParts(oPluginContainer)

        Dim oData As String = ""
        For Each o In oPluginContainer.Plugins
            If o.Info = pData Then
                Return o.ProcessData(pData)
            End If
        Next

        Return ""
    End Function
End Class
