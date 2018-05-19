Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub gridView_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs)
		If e.DataColumn.FieldName = "Description" OrElse e.DataColumn.FieldName = "CategoryName" Then
			If e.CellValue IsNot Nothing Then
				e.Cell.ToolTip = e.CellValue.ToString()
			End If
		End If
	End Sub
End Class