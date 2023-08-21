# Creating-an-Error-Bar-Chart-for-Exploring-the-Thermal-Expansion-of-Materials

## Error Bar in .NET MAUI Chart

[ErrorBarSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html) indicates the errors or uncertainty in reported values. This will find the possible variations in measurements, and in Chart control these values are displayed as data points.
The [HorizontalErrorValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html#Syncfusion_Maui_Charts_ErrorBarSeries_HorizontalErrorValue) and the [VerticalErrorValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html#Syncfusion_Maui_Charts_ErrorBarSeries_VerticalErrorValue) is used to set the error value(variation) to the series.


## Mode 
The error bar mode specifies whether the error bar should be drawn horizontally, vertically or both. The [Mode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html#Syncfusion_Maui_Charts_ErrorBarSeries_Mode) property used to switch the error bar mode. By default, the Mode value is [Both](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarMode.html#Syncfusion_Maui_Charts_ErrorBarMode_Both), which will display both horizontal and vertical error values.

### Both
To view both the horizontal and vertical error value, you can set the Mode as Both.

### Horizontal
To view horizontal error value, you can set the Mode as Horizontal.

### Vertical
To view vertical error value, you can set the Mode as Vertical.

## Direction 

The [HorizontalDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html#Syncfusion_Maui_Charts_ErrorBarSeries_HorizontalDirection) and [VerticalDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html#Syncfusion_Maui_Charts_ErrorBarSeries_VerticalDirection) specifies whether to show positive, negative, or both directions of error values.

[ErrorBarDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarDirection.html) contains below values:

*`Both` -  It indicates the actual data point value along with specific amount of positive and negative error values.

*`Plus` -  It indicates the actual data point value along with specific amount of positive error value.

*`Minus`-  It indicates the actual data point value along with specific amount of negative error value.

The following code illustrates how to set the [HorizontalDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html#Syncfusion_Maui_Charts_ErrorBarSeries_HorizontalDirection) and the [VerticalDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ErrorBarSeries.html#Syncfusion_Maui_Charts_ErrorBarSeries_VerticalDirection) values to error bar chart.

This sample demonstarte how the error bar series was used in real time examples.

Thermal expansion is a fundamental property of materials that describes their tendency to change shape or size in response to temperature changes. ErrorBar charts are excellent tools for visualizing and analyzing thermal expansion data.

![ThermalExpansionofMaterials](https://github.com/SyncfusionExamples/Creating-an-Error-Bar-Chart-for-Exploring-the-Thermal-Expansion-of-Materials/assets/102796134/99e06809-3c5b-4fff-989a-a3e88db01985)






