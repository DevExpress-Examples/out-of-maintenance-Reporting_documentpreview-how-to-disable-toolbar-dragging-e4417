Imports System
Imports DevExpress.XtraReports.UI

Namespace MinimalisticReportPreviewDemo
    Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel2 As XRLabel
        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 33.00001F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 48F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 48F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
            Me.ReportHeader.HeightF = 47F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Bookmark = "Home"
            Me.xrLabel2.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(222.9167F, 23F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "A sample report"
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1, Me.ReportHeader})
            Me.Bookmark = "Table of Contents"
            Me.Margins = New System.Drawing.Printing.Margins(49, 51, 48, 48)
            Me.Version = "11.1"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

    End Class
End Namespace