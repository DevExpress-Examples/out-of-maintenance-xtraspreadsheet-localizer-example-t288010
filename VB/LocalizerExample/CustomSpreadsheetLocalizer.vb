Imports DevExpress.XtraSpreadsheet.Localization
Imports System

Namespace LocalizerExample
    Friend Class CustomSpreadsheetLocalizer
        Inherits XtraSpreadsheetLocalizer

        Protected Overrides Sub PopulateStringTable()
            'base.PopulateStringTable();
            For Each s As XtraSpreadsheetStringId In System.Enum.GetValues(GetType(XtraSpreadsheetStringId))
                AddString(s, System.Enum.GetName(GetType(XtraSpreadsheetStringId), s))
            Next s
        End Sub
    End Class
End Namespace
