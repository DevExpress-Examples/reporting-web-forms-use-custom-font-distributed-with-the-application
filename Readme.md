<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5198)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to use a custom font distributed with the application

This example demonstrates how to create report that uses a custom font distributed with the application.

![Report with Custom Fonts](./Images/report-with-custom-fonts.png)

* Use the [PrivateFontCollection](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.text.privatefontcollection) class to store custom font families.
* Use the [Families](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.text.fontcollection.families) property to access the FontFamily objects of your private fonts.

In this example, the static **FontCollection** property of the **CustomFontsHelper** class stores a report's private fonts.
The report constructor uses font families from this static collection to initialize fonts of the report components.

This method is in effect on all platforms supported by DevExpress Reporting.

## Web Applications and CachedReportSource

The [Document Viewer](https://docs.devexpress.com/XtraReports/17738/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/document-viewer) component caches report documents.
When a report is restored from the cache, fonts are loaded from the system fonts. Override the font loading code to restore fonts from the **PrivateFontCollection**.
The **CustomFontConverter** class *(inherited from the **DevExpress.Utils.Serializing.PrintingSystemXmlSerializer.FontConverter** class)* implements this behavior in this code example.
To force the Reporting components to use the custom font converter, unregister the default font converter class and register the custom font converter at application startup.

**Note:** The **Azure Web Service**, **macOS**, and **Linux** hosting platforms do not support the **PrivateFontCollection**.

## Files to Look At  

- [CustomFontConverter.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/CustomFontConverter.cs) (VB: [CustomFontConverter.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/CustomFontConverter.vb))  
- [CustomFontsHelper.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/CustomFontsHelper.cs) (VB: [CustomFontsHelper.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/CustomFontsHelper.vb)) 
- [Global.asax.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/Global.asax.cs) (VB: [Global.asax.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/Global.asax.vb)) 
- [Default.aspx](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/Default.aspx) (VB: [Default.aspx](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/Default.aspx))  
- [SampleReport.cs](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/CS/E5198/SampleReport.cs) (VB: [SampleReport.vb](https://github.com/DevExpress-Examples/Reporting_how-to-use-a-private-font-a-custom-font-distributed-with-the-application-in-e5198/blob/18.2.11%2B/VB/E5198/SampleReport.vb))  
  
## Documentation
[How to: Create a Private Font Collection](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-a-private-font-collection?view=netframeworkdesktop-4.8)

## More Examples
[How to display a report that uses a private (embedded) font in a DocumentPreviewControl (WPF Application)](https://supportcenter.devexpress.com/ticket/details/e5083/how-to-display-a-report-that-uses-a-private-embedded-font-in-a-documentpreviewcontrol)
