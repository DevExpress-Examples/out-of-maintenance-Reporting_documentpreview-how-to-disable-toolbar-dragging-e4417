<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598011/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4417)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [Report.cs](./CS/Report.cs) (VB: [Report.vb](./VB/Report.vb))
<!-- default file list end -->
# DocumentPreview - how to disable toolbar dragging


<p>To prevent Bar from being dragged by a user, set the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfBarsBar_ShowDragWidgettopic">Bar.ShowDragWidget Property </a> of the "DocumentPreviewToolBar" to false in the <strong>BarManager.Loaded</strong> event handler instead of the corresponding event handler of the main window.</p>

<br/>


