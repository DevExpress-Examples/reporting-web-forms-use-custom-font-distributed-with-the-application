using DevExpress.Drawing;
using DevExpress.Utils.Serializing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace E5198 {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            string fontFilePath = HttpContext.Current.Server.MapPath("~/Fonts/MissFajardose-Regular.ttf");
            byte[] fontData = System.IO.File.ReadAllBytes(fontFilePath);
            DXFontRepository.Instance.AddFont(fontData);

            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}
