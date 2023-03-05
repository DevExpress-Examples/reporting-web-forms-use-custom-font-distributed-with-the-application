using DevExpress.Drawing;
using System.Drawing;
using System.Linq;

namespace E5198 {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        public SampleReport() {
            InitializeComponent();

            customFontStyle.Font = 
                new DXFont("Miss Fajardose", 48F, DXFontStyle.Regular, DXGraphicsUnit.Point);
        }
    }
}
