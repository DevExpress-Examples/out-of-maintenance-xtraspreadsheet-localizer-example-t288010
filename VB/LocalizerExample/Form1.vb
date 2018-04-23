Imports DevExpress.XtraSpreadsheet.Localization
Imports System.Windows.Forms

Namespace LocalizerExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            XtraSpreadsheetLocalizer.Active = New CustomSpreadsheetLocalizer()
        End Sub
    End Class
End Namespace
