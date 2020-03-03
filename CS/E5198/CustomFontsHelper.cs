using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Web;

namespace E5198 {
    public static class CustomFontsHelper {

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

        public static FontFamily GetFamily(string familyName) {
            return FontCollection.Families.FirstOrDefault(ff => ff.Name == familyName);
        }
    }
}