using System.Windows;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Report report = new Report();
            preview.DocumentSource = report;
            report.CreateDocument();
        }

        private void barManager_Loaded(object sender, RoutedEventArgs e) {
            barManager.Bars["DocumentPreviewToolBar"].ShowDragWidget = false;
        }
    }
}
