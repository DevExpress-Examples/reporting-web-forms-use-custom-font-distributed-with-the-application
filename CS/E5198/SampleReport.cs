using System.Drawing;


namespace E5198 {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        public SampleReport() {
            InitializeComponent();

            customFontStyle.Font = new Font(CustomFontsHelper.GetFamily("Miss Fajardose"), 48F, FontStyle.Regular, GraphicsUnit.Point);
        }        
    }
}
