Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Printing
' ...

Namespace MinimalisticReportPreviewDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim report As New Report()

			Dim model As New XtraReportPreviewModel(report)
			report.CreateDocument()
			preview.Model = model
		End Sub

		Private Sub barManager_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			barManager.Bars("DocumentPreviewToolBar").ShowDragWidget = False
		End Sub
	End Class
End Namespace
