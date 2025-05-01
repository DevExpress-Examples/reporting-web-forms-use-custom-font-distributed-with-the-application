<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603777/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5198)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for Web Forms - How to Use a Custom Font Distributed With the Application

This example shows how to create a report that uses the custom font shipped with the application.

![Report with Custom Fonts](./Images/report-with-custom-fonts.png)

In this example, the [DXFontRepository](https://docs.devexpress.com/CoreLibraries/DevExpress.Drawing.DXFontRepository) object instance loads a font from a file. The report constructor creates a new font and a [XRControlStyle](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControlStyle) report style based on the newly created font. The new custom style is added to the [XtraReport.StyleSheet](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.StyleSheet) collection.

> **Note**
>
> Although this example is a Web Forms application, the technique is valid for all DevExpress Reporting platforms.

## Files to Review

- [Global.asax.cs](CS/E5198/Global.asax.cs) (VB: [Global.asax.vb](VB/E5198/Global.asax.vb)) 
- [Default.aspx](CS/E5198/Default.aspx) (VB: [Default.aspx](VB/E5198/Default.aspx))  
- [SampleReport.cs](CS/E5198/SampleReport.cs) (VB: [SampleReport.vb](VB/E5198/SampleReport.vb))  
  
## Documentation

- [DevExpress.Drawing Graphics Library](https://docs.devexpress.com/CoreLibraries/404247/devexpress-drawing-library)
- [DXFontRepository](https://docs.devexpress.com/CoreLibraries/DevExpress.Drawing.DXFontRepository)

## More Examples

- [Reporting for WPF - How to Display a Custom Font in a Report Preview](https://github.com/DevExpress-Examples/reporting-wpf-use-private-custom-font-distributed-with-application)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-use-custom-font-distributed-with-the-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-use-custom-font-distributed-with-the-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
