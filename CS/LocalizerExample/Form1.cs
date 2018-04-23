using DevExpress.XtraSpreadsheet.Localization;
using System.Windows.Forms;

namespace LocalizerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XtraSpreadsheetLocalizer.Active = new CustomSpreadsheetLocalizer(); 
        }
    }
}
