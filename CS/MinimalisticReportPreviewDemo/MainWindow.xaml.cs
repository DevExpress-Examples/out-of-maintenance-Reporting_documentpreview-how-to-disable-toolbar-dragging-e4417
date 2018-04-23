using System.Windows;
using DevExpress.Xpf.Printing;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Report report = new Report();

            XtraReportPreviewModel model = new XtraReportPreviewModel(report);
            report.CreateDocument();
            preview.Model = model;
        }

        private void barManager_Loaded(object sender, RoutedEventArgs e) {
            barManager.Bars["DocumentPreviewToolBar"].ShowDragWidget = false;
        }
    }
}
