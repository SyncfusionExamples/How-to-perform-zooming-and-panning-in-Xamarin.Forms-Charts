# How-to-perform-zooming-and-panning-in-Xamarin.Forms-Charts
[Xamarin.Forms Chart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) allows you to zoom in to view the data clearly. To enable this feature, you need to add an instance of [ChartZoomPanBehavior](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartZoomPanBehavior.html) to the [ChartBehaviors](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartBehavior.html) collection property of SfChart.

Following properties are used to configure the zooming feature,

* [EnableZooming](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartZoomPanBehavior.html#Syncfusion_SfChart_XForms_ChartZoomPanBehavior_EnableZooming) – used to enable/disable the pinch zooming. Default value is true.
* [EnableDirectionalZooming](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartZoomPanBehavior.html#Syncfusion_SfChart_XForms_ChartZoomPanBehavior_EnableDirectionalZooming) - Enables or disables the pinch zooming based on pinch gesture direction. The default value of this property is false.
* [EnableDoubleTap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartZoomPanBehavior.html#Syncfusion_SfChart_XForms_ChartZoomPanBehavior_EnableDoubleTap) – when you enable this property, you can double tap on the chart to reset it to the original size or zoom in by one level.
* [EnablePanning](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartZoomPanBehavior.html#Syncfusion_SfChart_XForms_ChartZoomPanBehavior_EnablePanning) – used to enable/disable the panning. Default value is true.
* [MaximumZoomLevel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartZoomPanBehavior.html#Syncfusion_SfChart_XForms_ChartZoomPanBehavior_MaximumZoomLevel) - used to determine the maximum zoom level of the chart.


![](https://github.com/SyncfusionExamples/How-to-perform-zooming-and-panning-in-Xamarin.Forms-Charts/blob/main/chart_zooming_panning.gif)
