<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=7.0.13.220, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
	Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>View1</title>
</head>
<script runat="server">
	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
	}
</script>
<body>
    <div>
    	<form runat="server">
		<telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="100%">
<typereportsource 
			typename="MvcApplication1.Reports.Report2, MvcApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
</telerik:ReportViewer>
</form>
    </div>
</body>
</html>
