<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134059666/13.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4898)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# OBSOLETE - ASPxGridView - How to display truncated text in a resizable column (using CSS)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4898)**
<!-- run online end -->


<p><strong>UPDATED:<br><br></strong>Starting with version v2015 vol 2 (v15.2), this functionality is available out of the box. Simply set the <strong>ASPxGridView.SettingsBehavior.AllowEllipsisInText</strong> / <strong>GridViewDataColumn.Settings.AllowEllipsisInText</strong> property to True to activate it. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2015/11/10/asp-net-grid-view-data-range-filter-adaptivity-and-more-coming-soon-in-v15-2.aspx">ASP.NET Grid View - Data Range Filter, Adaptivity and More (Coming soon in v15.2)</a> blog post and the <a href="http://demos.devexpress.com/ASPxGridViewDemos/Columns/TextEllipsis.aspx">Text Ellipsis</a> demo for more information.<br>If you have version v15.2+ available, consider using the built-in functionality instead of the approach detailed below.<br><br>This example demonstrates how to display truncated text in a resizable ASPxGridView column and show a full value as a tool tip.<br><br>1) Apply the following CSS class to column cells:</p>
<br>


```css
.truncated {
    white-space: nowrap;
    overflow: hidden;
    text-overflow: ellipsis;
}
```




```aspx
<dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="2">
    <CellStyle CssClass="truncated"></CellStyle>
</dx:GridViewDataTextColumn>
```


<p><br>2) Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_HtmlDataCellPreparedtopic"><u>ASPxGridView.HtmlDataCellPrepared</u></a> event to set tool tips for the same DataCell via the <strong>e.Cell.ToolTip</strong> property.<br><br><strong>S</strong><strong>ee Also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/E3934">ASPxGridView - How to display a truncated text in a column</a></p>

<br/>


