﻿#ExternalChecksum("..\..\..\..\Dialogs\Insert\TableDialog.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","A1C8366A9EEA0225D98C6D10CCE47DDC")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Fluent
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''TableDialog
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class TableDialog
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",4)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CancelButton As Fluent.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",9)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents OKButton As Fluent.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",14)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents RowsTextBox As Fluent.Spinner
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",15)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CellsTextBox As Fluent.Spinner
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",16)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderColorButton As Fluent.DropDownButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",17)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderColorGallery As Fluent.ColorGallery
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",20)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BackgroundColorGallery As Fluent.ColorGallery
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",22)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents PreviewBox As System.Windows.Controls.RichTextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",23)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CellBorderColorButton As Fluent.DropDownButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CellBorderColorGallery As Fluent.ColorGallery
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",27)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CellBackgroundColorGallery As Fluent.ColorGallery
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Document.Editor;component/dialogs/insert/tabledialog.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\Dialogs\Insert\TableDialog.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.CancelButton = CType(target,Fluent.Button)
            Return
        End If
        If (connectionId = 2) Then
            Me.OKButton = CType(target,Fluent.Button)
            Return
        End If
        If (connectionId = 3) Then
            Me.RowsTextBox = CType(target,Fluent.Spinner)
            Return
        End If
        If (connectionId = 4) Then
            Me.CellsTextBox = CType(target,Fluent.Spinner)
            Return
        End If
        If (connectionId = 5) Then
            Me.BorderColorButton = CType(target,Fluent.DropDownButton)
            Return
        End If
        If (connectionId = 6) Then
            Me.BorderColorGallery = CType(target,Fluent.ColorGallery)
            Return
        End If
        If (connectionId = 7) Then
            Me.BackgroundColorGallery = CType(target,Fluent.ColorGallery)
            Return
        End If
        If (connectionId = 8) Then
            Me.PreviewBox = CType(target,System.Windows.Controls.RichTextBox)
            Return
        End If
        If (connectionId = 9) Then
            Me.CellBorderColorButton = CType(target,Fluent.DropDownButton)
            Return
        End If
        If (connectionId = 10) Then
            Me.CellBorderColorGallery = CType(target,Fluent.ColorGallery)
            Return
        End If
        If (connectionId = 11) Then
            Me.CellBackgroundColorGallery = CType(target,Fluent.ColorGallery)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
