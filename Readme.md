<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603777/22.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5198)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to use a custom font distributed with the application

This example shows how to create a report that uses the custom font shipped with the application.

![Report with Custom Fonts](./Images/report-with-custom-fonts.png)

In this example, the `CustomFontsHelper` static class uses a [PrivateFontCollection](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.text.privatefontcollection) object to store custom fonts and install them without affecting the system font collection. The report constructor uses font families from this static collection to create a new font and a [XRControlStyle](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControlStyle) report style based on the newly created font. The new custom style is added to the [XtraReport.StyleSheet](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.StyleSheet) collection.

Although this example is a WebForms application, the technique is valid for all DevExpress Reporting platforms.

## Document Fonts in Web Application Cache

The [Document Viewer](https://docs.devexpress.com/XtraReports/17738/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/document-viewer) component use cache to store documents generated from reports. When a report is restored from the cache, fonts are loaded from the system font collection, and you should implement and register a custom font converter to restore fonts from the private font collection. This example implements the `CustomFontConverter` class, inherited from the `DevExpress.Utils.Serializing.PrintingSystemXmlSerializer.FontConverter` class. 
 
To force Reporting components to use a custom font converter, unregister the default font converter class and register a custom font converter at the application startup (the `Global.asax` file).

**Note:** The **Azure Web Service**, **macOS**, and **Linux** hosting platforms do not support the **PrivateFontCollection** technique.

## Files to Look At  

- [CustomFontConverter.cs](CS/E5198/CustomFontConverter.cs) (VB: [CustomFontConverter.vb](VB/E5198/CustomFontConverter.vb))  
- [CustomFontsHelper.cs](CS/E5198/CustomFontsHelper.cs) (VB: [CustomFontsHelper.vb](VB/E5198/CustomFontsHelper.vb)) 
- [Global.asax.cs](CS/E5198/Global.asax.cs) (VB: [Global.asax.vb](VB/E5198/Global.asax.vb)) 
- [Default.aspx](CS/E5198/Default.aspx) (VB: [Default.aspx](VB/E5198/Default.aspx))  
- [SampleReport.cs](CS/E5198/SampleReport.cs) (VB: [SampleReport.vb](VB/E5198/SampleReport.vb))  
  
## Documentation
[How to: Create a Private Font Collection](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-a-private-font-collection)

## More Examples
[How to display a report that uses a private (embedded) font in a DocumentPreviewControl (WPF Application)](https://supportcenter.devexpress.com/ticket/details/e5083/how-to-display-a-report-that-uses-a-private-embedded-font-in-a-documentpreviewcontrol)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-use-custom-font-distributed-with-the-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-use-custom-font-distributed-with-the-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
