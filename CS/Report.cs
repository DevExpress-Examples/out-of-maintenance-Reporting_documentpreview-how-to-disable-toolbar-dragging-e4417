using System;
using DevExpress.XtraReports.UI;

namespace MinimalisticReportPreviewDemo
{
	public class Report : DevExpress.XtraReports.UI.XtraReport
	{
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;

		public Report() 
		{
			InitializeComponent();
		}

		private void InitializeComponent() 
		{
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 33.00001F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 48F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 48F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.ReportHeader.HeightF = 47F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Bookmark = "Home";
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(222.9167F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "A sample report";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.ReportHeader});
            this.Bookmark = "Table of Contents";
            this.Margins = new DevExpress.Drawing.DXMargins(49, 51, 48, 48);
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

	}
}
