Imports System.Windows
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
			preview.DocumentSource = report
			report.CreateDocument()
		End Sub

		Private Sub barManager_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			barManager.Bars("DocumentPreviewToolBar").ShowDragWidget = False
		End Sub
	End Class
End Namespace
