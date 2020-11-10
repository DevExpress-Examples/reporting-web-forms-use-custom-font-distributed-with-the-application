# How to use a private font (a custom font distributed with the application) in XtraReport

This example demonstrates how to use a custom font distributed with the application in XtraReport.  

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5198/)**
<!-- run online end -->
  
  
The main idea of this approach is to use the [PrivateFontCollection](http://msdn.microsoft.com/en-us/library/system.drawing.text.privatefontcollection%28v=vs.110%29.aspx) class to store custom font families. Use the [Families](http://msdn.microsoft.com/en-us/library/system.drawing.text.fontcollection.families%28v=vs.110%29.aspx) property to access the FontFamily objects of your private fonts.   

In this example, the static "FontCollection" property of the "CustomFontsHelper" class is used to store the report's private fonts. Then, in the report constructor, the font families from this static collection are used to initialize fonts of the report components.  
  
  
This is a cross\-platform approach, so it can be used for all technologies supported by XtraReports. However, there are some notes:  
  
  
### Web Applications and CachedReportSource
The [Document Viewer](https://docs.devexpress.com/XtraReports/17738/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/document-viewer) component caches report documents by default. When the report is restored from the cache, the fonts are loaded from the system fonts. To overcome this behavior it is necessary to override the font loading code to make it use the PrivateFontCollection to restore fonts. The CustomFontConverter class *(inherited from the DevExpress.Utils.Serializing.PrintingSystemXmlSerializer.FontConverter class)* is used for this purpose in this code example. To force the Reporting components use this custom font converter it is necessary to unregister the default font converter class and then register the custom font converter when the application is started.

**Note:** The **Azure Web Service**, **macOS** and **Linux** hosting environments does not support the [PrivateFontCollection](http://msdn.microsoft.com/en-us/library/system.drawing.text.privatefontcollection%28v=vs.110%29.aspx) functionality.  
  
 
## Files to look at  
 
- [CustomFontConverter.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/CustomFontConverter.cs) (VB: [CustomFontConverter.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/CustomFontConverter.vb))  
- [CustomFontsHelper.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/CustomFontsHelper.cs) (VB: [CustomFontsHelper.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/CustomFontsHelper.vb)) 
- [Global.asax.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/Global.asax.cs) (VB: [CustomFontsHelper.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/Global.asax.vb)) 
- [Default.aspx](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/Default.aspx) (VB: [Default.aspx](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/Default.aspx))  
- [SampleReport.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/SampleReport.cs) (VB: [SampleReport.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/SampleReport.vb))  
  
## See also
[How to: Create a Private Font Collection (MSDN)](http://msdn.microsoft.com/en-us/library/y505zzfw%28v=vs.110%29.aspx)  
[How to display a report that uses a private (embedded) font in a DocumentPreviewControl (WPF Application)](https://www.devexpress.com/Support/Center/p/E5083)
