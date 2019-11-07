﻿Imports System.IO
Imports GleamTech.AspNet
Imports GleamTech.FileUltimate

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        Dim licenseFile = Hosting.ResolvePhysicalPath("~/App_Data/License.dat")
        If File.Exists(licenseFile) Then
	        FileUltimateConfiguration.Current.LicenseKey = File.ReadAllText(licenseFile)
        End If

    End Sub

End Class