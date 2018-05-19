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


