<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603777/13.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5198)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/E5198/Default.aspx) (VB: [Default.aspx](./VB/E5198/Default.aspx))
* [Default.aspx.cs](./CS/E5198/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/E5198/Default.aspx.vb))
* **[SampleReport.cs](./CS/E5198/SampleReport.cs) (VB: [SampleReport.vb](./VB/E5198/SampleReport.vb))**
<!-- default file list end -->
# How to use a private font (a custom font distributed with the application) in XtraReport


<p>This example demonstrates how to use a custom font distributed with the application in XtraReport.</p>
<br />
<p>The main idea of this approach is to use the <a href="http://msdn.microsoft.com/en-us/library/system.drawing.text.privatefontcollection%28v=vs.110%29.aspx"><u>PrivateFontCollection</u></a> class to store custom font families. Use the <a href="http://msdn.microsoft.com/en-us/library/system.drawing.text.fontcollection.families%28v=vs.110%29.aspx"><u>Families</u></a> property to access the FontFamily objects of your private fonts.</p>
<p>In this example, the static "FontCollection" property is used to store the report's private fonts. Then, in the report constructor, the private font families are used to specify fonts of the report controls.</p>
<p><strong><br /> </strong></p>
<p>This is a cross-platform approach, so it can be used for all technologies supported by XtraReports. However, there are some notes:</p>
<p><strong><br /> </strong><strong>ASP.NET<br /> </strong>The private font will be available only on your web server, so it won't be displayed in ASPxDocumentViewer by default if it is not installed on the client machine.</p>
<p>However, you can register this custom font on your webpage, for example by using the <a href="http://www.w3schools.com/cssref/css3_pr_font-face_rule.asp"><u>@font-face</u></a> CSS rule. In this case, add this rule to your webpage with the viewer and set your <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebDocumentViewerDocumentViewerReportViewerSettings_UseIFrametopic"><u>ASPxDocumentViewer.SettingsReportViewer.UseIFrame</u></a> property to the "false" value to prevent your report from being rendered in an iframe. This approach is demonstrated in this example.<br /><br /><strong>WPF</strong><br />The font cannot be registered globally by using the PrivateFontCollection in WPF, so the explicit reference to the embedded font is required there. The <a href="https://www.devexpress.com/Support/Center/p/E5083">E5083: How to display a report that uses a private font (distributed with the application) in DocumentPreview</a> code example demonstrates how to work around this limitation.<br /><br /></p>
<p><strong>See also:</strong><br /> <a href="http://msdn.microsoft.com/en-us/library/y505zzfw%28v=vs.110%29.aspx"><u>How to: Create a Private Font Collection (MSDN)</u></a></p>


<h3>Description</h3>

<p><br />
</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-use-custom-font-distributed-with-the-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-forms-use-custom-font-distributed-with-the-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
