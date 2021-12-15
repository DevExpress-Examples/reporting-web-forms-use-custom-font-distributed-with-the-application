using System;
using System.Web;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Text;


namespace E5198 {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        public SampleReport() {
            InitializeComponent();

            customFontStyle.Font = new Font(FontCollection.Families[0], 48F, FontStyle.Regular, GraphicsUnit.Point);
        }

        static PrivateFontCollection fontCollection;
        public static FontCollection FontCollection {
            get {
                if (fontCollection == null) {
                    fontCollection = new PrivateFontCollection();
                    fontCollection.AddFontFile(HttpContext.Current.Server.MapPath("~/Fonts/MissFajardose-Regular.ttf"));
                }
                return fontCollection;
            }
        }
    }
}
