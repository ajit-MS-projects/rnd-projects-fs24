//
// Style various parts to match the jQuery UI theme.
//
function jQueryUIStyling() {
	
	$('input:button, input:submit').button();

	// Style tables.
	$('.webgrid-wrapper').addClass('ui-grid ui-widget ui-widget-content ui-corner-all');
	$('.webgrid-title').addClass('ui-grid-header ui-widget-header ui-corner-top');
	jQueryTableStyling();
}

//
// Style tables using jQuery UI theme. This function is 
// split out separately so that it can be part of the AJAX
// callback of the WebGrid WebHelper in ASP.NET MVC.
//
function jQueryTableStyling() {
	$('.webgrid').addClass('ui-grid-content ui-widget-content');
	$('.webgrid-header').addClass('ui-state-default');
	$('.webgrid-footer').addClass('ui-grid-footer ui-widget-header ui-corner-bottom ui-helper-clearfix');
}


