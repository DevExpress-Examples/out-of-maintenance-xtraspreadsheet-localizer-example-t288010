using DevExpress.XtraSpreadsheet.Localization;
using System;

namespace LocalizerExample
{
    class CustomSpreadsheetLocalizer : XtraSpreadsheetLocalizer
    {
        protected override void PopulateStringTable()
        {
            //base.PopulateStringTable();
            foreach (XtraSpreadsheetStringId s in Enum.GetValues(typeof(XtraSpreadsheetStringId)))
            {
                AddString(s, Enum.GetName(typeof(XtraSpreadsheetStringId), s));
            }
        }
    }
}
