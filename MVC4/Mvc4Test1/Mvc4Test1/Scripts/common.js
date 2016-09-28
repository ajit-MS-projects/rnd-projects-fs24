$(document).ready(function () {
	//        $("#OrderedDate").datepicker({ dateFormat: 'dd.mm.yy' });
	//        $("#ApprovedDate").datepicker({ dateFormat: 'dd.mm.yy' });
	//        $("#ObsoleteDate").datepicker({ dateFormat: 'dd.mm.yy' });


	jQuery.validator.addMethod(
			'date',
			function (value, element, params) {

				if (this.optional(element)) {
					return true;
				};
				var result = false;
				try {
					//alert($.datepicker.parseDate("dd.mm.yy @", value));
					$.datepicker.parseDate('dd.mm.yy', value);
					result = true;
				} catch (err) {
					result = false;
				}
				return result;
			},
			''
		);
});
