namespace MvcApplication1.Reports
{
	partial class Report4
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for telerik Reporting designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report4));
			Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
			Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
			Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
			Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
			Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
			Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
			this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
			this.advertiserIdGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
			this.advertiserIdGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
			this.advertiserIdCaptionTextBox = new Telerik.Reporting.TextBox();
			this.advertiserIdDataTextBox = new Telerik.Reporting.TextBox();
			this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
			this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
			this.adImpressionsCaptionTextBox = new Telerik.Reporting.TextBox();
			this.clickRateCaptionTextBox = new Telerik.Reporting.TextBox();
			this.clicksCaptionTextBox = new Telerik.Reporting.TextBox();
			this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
			this.hourCaptionTextBox = new Telerik.Reporting.TextBox();
			this.leadRateCaptionTextBox = new Telerik.Reporting.TextBox();
			this.leadsCaptionTextBox = new Telerik.Reporting.TextBox();
			this.postViewLeadsCaptionTextBox = new Telerik.Reporting.TextBox();
			this.postViewSalesCaptionTextBox = new Telerik.Reporting.TextBox();
			this.salesCaptionTextBox = new Telerik.Reporting.TextBox();
			this.salesRateCaptionTextBox = new Telerik.Reporting.TextBox();
			this.salesValueCaptionTextBox = new Telerik.Reporting.TextBox();
			this.totalAffiliateCommissionCaptionTextBox = new Telerik.Reporting.TextBox();
			this.pageHeader = new Telerik.Reporting.PageHeaderSection();
			this.reportNameTextBox = new Telerik.Reporting.TextBox();
			this.pageFooter = new Telerik.Reporting.PageFooterSection();
			this.currentTimeTextBox = new Telerik.Reporting.TextBox();
			this.pageInfoTextBox = new Telerik.Reporting.TextBox();
			this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
			this.titleTextBox = new Telerik.Reporting.TextBox();
			this.reportFooter = new Telerik.Reporting.ReportFooterSection();
			this.detail = new Telerik.Reporting.DetailSection();
			this.adImpressionsDataTextBox = new Telerik.Reporting.TextBox();
			this.clickRateDataTextBox = new Telerik.Reporting.TextBox();
			this.clicksDataTextBox = new Telerik.Reporting.TextBox();
			this.dateDataTextBox = new Telerik.Reporting.TextBox();
			this.hourDataTextBox = new Telerik.Reporting.TextBox();
			this.leadRateDataTextBox = new Telerik.Reporting.TextBox();
			this.leadsDataTextBox = new Telerik.Reporting.TextBox();
			this.postViewLeadsDataTextBox = new Telerik.Reporting.TextBox();
			this.postViewSalesDataTextBox = new Telerik.Reporting.TextBox();
			this.salesDataTextBox = new Telerik.Reporting.TextBox();
			this.salesRateDataTextBox = new Telerik.Reporting.TextBox();
			this.salesValueDataTextBox = new Telerik.Reporting.TextBox();
			this.totalAffiliateCommissionDataTextBox = new Telerik.Reporting.TextBox();
			this.subReport1 = new Telerik.Reporting.SubReport();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionString = "ProductDb";
			this.sqlDataSource1.Name = "sqlDataSource1";
			this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
			// 
			// advertiserIdGroupHeaderSection
			// 
			this.advertiserIdGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
			this.advertiserIdGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.advertiserIdCaptionTextBox,
            this.advertiserIdDataTextBox});
			this.advertiserIdGroupHeaderSection.Name = "advertiserIdGroupHeaderSection";
			// 
			// advertiserIdGroupFooterSection
			// 
			this.advertiserIdGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(3.6093759536743164D);
			this.advertiserIdGroupFooterSection.Name = "advertiserIdGroupFooterSection";
			// 
			// advertiserIdCaptionTextBox
			// 
			this.advertiserIdCaptionTextBox.CanGrow = true;
			this.advertiserIdCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.advertiserIdCaptionTextBox.Name = "advertiserIdCaptionTextBox";
			this.advertiserIdCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.advertiserIdCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
			this.advertiserIdCaptionTextBox.StyleName = "Caption";
			this.advertiserIdCaptionTextBox.Value = "Advertiser Id:";
			// 
			// advertiserIdDataTextBox
			// 
			this.advertiserIdDataTextBox.CanGrow = true;
			this.advertiserIdDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1058332920074463D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.advertiserIdDataTextBox.Name = "advertiserIdDataTextBox";
			this.advertiserIdDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12.602499961853027D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.advertiserIdDataTextBox.StyleName = "Data";
			this.advertiserIdDataTextBox.Value = "=Fields.AdvertiserId";
			// 
			// labelsGroupHeaderSection
			// 
			this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
			this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.adImpressionsCaptionTextBox,
            this.clickRateCaptionTextBox,
            this.clicksCaptionTextBox,
            this.dateCaptionTextBox,
            this.hourCaptionTextBox,
            this.leadRateCaptionTextBox,
            this.leadsCaptionTextBox,
            this.postViewLeadsCaptionTextBox,
            this.postViewSalesCaptionTextBox,
            this.salesCaptionTextBox,
            this.salesRateCaptionTextBox,
            this.salesValueCaptionTextBox,
            this.totalAffiliateCommissionCaptionTextBox});
			this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
			this.labelsGroupHeaderSection.PrintOnEveryPage = true;
			// 
			// labelsGroupFooterSection
			// 
			this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
			this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
			this.labelsGroupFooterSection.Style.Visible = false;
			// 
			// adImpressionsCaptionTextBox
			// 
			this.adImpressionsCaptionTextBox.CanGrow = true;
			this.adImpressionsCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.adImpressionsCaptionTextBox.Name = "adImpressionsCaptionTextBox";
			this.adImpressionsCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.adImpressionsCaptionTextBox.StyleName = "Caption";
			this.adImpressionsCaptionTextBox.Value = "Ad Impressions";
			// 
			// clickRateCaptionTextBox
			// 
			this.clickRateCaptionTextBox.CanGrow = true;
			this.clickRateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2653205394744873D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.clickRateCaptionTextBox.Name = "clickRateCaptionTextBox";
			this.clickRateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.clickRateCaptionTextBox.StyleName = "Caption";
			this.clickRateCaptionTextBox.Value = "Click Rate";
			// 
			// clicksCaptionTextBox
			// 
			this.clicksCaptionTextBox.CanGrow = true;
			this.clicksCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4777243137359619D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.clicksCaptionTextBox.Name = "clicksCaptionTextBox";
			this.clicksCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.clicksCaptionTextBox.StyleName = "Caption";
			this.clicksCaptionTextBox.Value = "Clicks";
			// 
			// dateCaptionTextBox
			// 
			this.dateCaptionTextBox.CanGrow = true;
			this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.6901283264160156D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.dateCaptionTextBox.Name = "dateCaptionTextBox";
			this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.dateCaptionTextBox.StyleName = "Caption";
			this.dateCaptionTextBox.Value = "Date";
			// 
			// hourCaptionTextBox
			// 
			this.hourCaptionTextBox.CanGrow = true;
			this.hourCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.90253210067749D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.hourCaptionTextBox.Name = "hourCaptionTextBox";
			this.hourCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.hourCaptionTextBox.StyleName = "Caption";
			this.hourCaptionTextBox.Value = "Hour";
			// 
			// leadRateCaptionTextBox
			// 
			this.leadRateCaptionTextBox.CanGrow = true;
			this.leadRateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.1149358749389648D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.leadRateCaptionTextBox.Name = "leadRateCaptionTextBox";
			this.leadRateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.leadRateCaptionTextBox.StyleName = "Caption";
			this.leadRateCaptionTextBox.Value = "Lead Rate";
			// 
			// leadsCaptionTextBox
			// 
			this.leadsCaptionTextBox.CanGrow = true;
			this.leadsCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.3273396492004395D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.leadsCaptionTextBox.Name = "leadsCaptionTextBox";
			this.leadsCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.leadsCaptionTextBox.StyleName = "Caption";
			this.leadsCaptionTextBox.Value = "Leads";
			// 
			// postViewLeadsCaptionTextBox
			// 
			this.postViewLeadsCaptionTextBox.CanGrow = true;
			this.postViewLeadsCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.5397434234619141D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.postViewLeadsCaptionTextBox.Name = "postViewLeadsCaptionTextBox";
			this.postViewLeadsCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.postViewLeadsCaptionTextBox.StyleName = "Caption";
			this.postViewLeadsCaptionTextBox.Value = "Post View Leads";
			// 
			// postViewSalesCaptionTextBox
			// 
			this.postViewSalesCaptionTextBox.CanGrow = true;
			this.postViewSalesCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7521476745605469D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.postViewSalesCaptionTextBox.Name = "postViewSalesCaptionTextBox";
			this.postViewSalesCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.postViewSalesCaptionTextBox.StyleName = "Caption";
			this.postViewSalesCaptionTextBox.Value = "Post View Sales";
			// 
			// salesCaptionTextBox
			// 
			this.salesCaptionTextBox.CanGrow = true;
			this.salesCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.96455192565918D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.salesCaptionTextBox.Name = "salesCaptionTextBox";
			this.salesCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.salesCaptionTextBox.StyleName = "Caption";
			this.salesCaptionTextBox.Value = "Sales";
			// 
			// salesRateCaptionTextBox
			// 
			this.salesRateCaptionTextBox.CanGrow = true;
			this.salesRateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.176956176757813D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.salesRateCaptionTextBox.Name = "salesRateCaptionTextBox";
			this.salesRateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.salesRateCaptionTextBox.StyleName = "Caption";
			this.salesRateCaptionTextBox.Value = "Sales Rate";
			// 
			// salesValueCaptionTextBox
			// 
			this.salesValueCaptionTextBox.CanGrow = true;
			this.salesValueCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.389360427856445D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.salesValueCaptionTextBox.Name = "salesValueCaptionTextBox";
			this.salesValueCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.salesValueCaptionTextBox.StyleName = "Caption";
			this.salesValueCaptionTextBox.Value = "Sales Value";
			// 
			// totalAffiliateCommissionCaptionTextBox
			// 
			this.totalAffiliateCommissionCaptionTextBox.CanGrow = true;
			this.totalAffiliateCommissionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.601764678955078D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.totalAffiliateCommissionCaptionTextBox.Name = "totalAffiliateCommissionCaptionTextBox";
			this.totalAffiliateCommissionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.totalAffiliateCommissionCaptionTextBox.StyleName = "Caption";
			this.totalAffiliateCommissionCaptionTextBox.Value = "Total Affiliate Commission";
			// 
			// pageHeader
			// 
			this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
			this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
			this.pageHeader.Name = "pageHeader";
			// 
			// reportNameTextBox
			// 
			this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.reportNameTextBox.Name = "reportNameTextBox";
			this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.708333015441895D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.reportNameTextBox.StyleName = "PageInfo";
			this.reportNameTextBox.Value = "Report4";
			// 
			// pageFooter
			// 
			this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
			this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
			this.pageFooter.Name = "pageFooter";
			// 
			// currentTimeTextBox
			// 
			this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.currentTimeTextBox.Name = "currentTimeTextBox";
			this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.currentTimeTextBox.StyleName = "PageInfo";
			this.currentTimeTextBox.Value = "=NOW()";
			// 
			// pageInfoTextBox
			// 
			this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.pageInfoTextBox.Name = "pageInfoTextBox";
			this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
			this.pageInfoTextBox.StyleName = "PageInfo";
			this.pageInfoTextBox.Value = "=PageNumber";
			// 
			// reportHeader
			// 
			this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127D);
			this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
			this.reportHeader.Name = "reportHeader";
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D), Telerik.Reporting.Drawing.Unit.Cm(2D));
			this.titleTextBox.StyleName = "Title";
			this.titleTextBox.Value = "Report4";
			// 
			// reportFooter
			// 
			this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(5.0950021743774414D);
			this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.subReport1});
			this.reportFooter.Name = "reportFooter";
			// 
			// detail
			// 
			this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
			this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.adImpressionsDataTextBox,
            this.clickRateDataTextBox,
            this.clicksDataTextBox,
            this.dateDataTextBox,
            this.hourDataTextBox,
            this.leadRateDataTextBox,
            this.leadsDataTextBox,
            this.postViewLeadsDataTextBox,
            this.postViewSalesDataTextBox,
            this.salesDataTextBox,
            this.salesRateDataTextBox,
            this.salesValueDataTextBox,
            this.totalAffiliateCommissionDataTextBox});
			this.detail.Name = "detail";
			// 
			// adImpressionsDataTextBox
			// 
			this.adImpressionsDataTextBox.CanGrow = true;
			this.adImpressionsDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.adImpressionsDataTextBox.Name = "adImpressionsDataTextBox";
			this.adImpressionsDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.adImpressionsDataTextBox.StyleName = "Data";
			this.adImpressionsDataTextBox.Value = "=Fields.AdImpressions";
			// 
			// clickRateDataTextBox
			// 
			this.clickRateDataTextBox.CanGrow = true;
			this.clickRateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2653205394744873D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.clickRateDataTextBox.Name = "clickRateDataTextBox";
			this.clickRateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.clickRateDataTextBox.StyleName = "Data";
			this.clickRateDataTextBox.Value = "=Fields.ClickRate";
			// 
			// clicksDataTextBox
			// 
			this.clicksDataTextBox.CanGrow = true;
			this.clicksDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4777243137359619D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.clicksDataTextBox.Name = "clicksDataTextBox";
			this.clicksDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.clicksDataTextBox.StyleName = "Data";
			this.clicksDataTextBox.Value = "=Fields.Clicks";
			// 
			// dateDataTextBox
			// 
			this.dateDataTextBox.CanGrow = true;
			this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.6901283264160156D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.dateDataTextBox.Name = "dateDataTextBox";
			this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.dateDataTextBox.StyleName = "Data";
			this.dateDataTextBox.Value = "=Fields.Date";
			// 
			// hourDataTextBox
			// 
			this.hourDataTextBox.CanGrow = true;
			this.hourDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.90253210067749D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.hourDataTextBox.Name = "hourDataTextBox";
			this.hourDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.hourDataTextBox.StyleName = "Data";
			this.hourDataTextBox.Value = "=Fields.Hour";
			// 
			// leadRateDataTextBox
			// 
			this.leadRateDataTextBox.CanGrow = true;
			this.leadRateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.1149358749389648D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.leadRateDataTextBox.Name = "leadRateDataTextBox";
			this.leadRateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.leadRateDataTextBox.StyleName = "Data";
			this.leadRateDataTextBox.Value = "=Fields.LeadRate";
			// 
			// leadsDataTextBox
			// 
			this.leadsDataTextBox.CanGrow = true;
			this.leadsDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.3273396492004395D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.leadsDataTextBox.Name = "leadsDataTextBox";
			this.leadsDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.leadsDataTextBox.StyleName = "Data";
			this.leadsDataTextBox.Value = "=Fields.Leads";
			// 
			// postViewLeadsDataTextBox
			// 
			this.postViewLeadsDataTextBox.CanGrow = true;
			this.postViewLeadsDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.5397434234619141D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.postViewLeadsDataTextBox.Name = "postViewLeadsDataTextBox";
			this.postViewLeadsDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.postViewLeadsDataTextBox.StyleName = "Data";
			this.postViewLeadsDataTextBox.Value = "=Fields.PostViewLeads";
			// 
			// postViewSalesDataTextBox
			// 
			this.postViewSalesDataTextBox.CanGrow = true;
			this.postViewSalesDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7521476745605469D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.postViewSalesDataTextBox.Name = "postViewSalesDataTextBox";
			this.postViewSalesDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.postViewSalesDataTextBox.StyleName = "Data";
			this.postViewSalesDataTextBox.Value = "=Fields.PostViewSales";
			// 
			// salesDataTextBox
			// 
			this.salesDataTextBox.CanGrow = true;
			this.salesDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.96455192565918D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.salesDataTextBox.Name = "salesDataTextBox";
			this.salesDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.salesDataTextBox.StyleName = "Data";
			this.salesDataTextBox.Value = "=Fields.Sales";
			// 
			// salesRateDataTextBox
			// 
			this.salesRateDataTextBox.CanGrow = true;
			this.salesRateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.176956176757813D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.salesRateDataTextBox.Name = "salesRateDataTextBox";
			this.salesRateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.salesRateDataTextBox.StyleName = "Data";
			this.salesRateDataTextBox.Value = "=Fields.SalesRate";
			// 
			// salesValueDataTextBox
			// 
			this.salesValueDataTextBox.CanGrow = true;
			this.salesValueDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.389360427856445D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.salesValueDataTextBox.Name = "salesValueDataTextBox";
			this.salesValueDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.salesValueDataTextBox.StyleName = "Data";
			this.salesValueDataTextBox.Value = "=Fields.SalesValue";
			// 
			// totalAffiliateCommissionDataTextBox
			// 
			this.totalAffiliateCommissionDataTextBox.CanGrow = true;
			this.totalAffiliateCommissionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.601764678955078D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.totalAffiliateCommissionDataTextBox.Name = "totalAffiliateCommissionDataTextBox";
			this.totalAffiliateCommissionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1594871282577515D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
			this.totalAffiliateCommissionDataTextBox.StyleName = "Data";
			this.totalAffiliateCommissionDataTextBox.Value = "=Fields.TotalAffiliateCommission";
			// 
			// subReport1
			// 
			this.subReport1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.2744231224060059D), Telerik.Reporting.Drawing.Unit.Cm(0.9999995231628418D));
			this.subReport1.Name = "subReport1";
			this.subReport1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0000004768371582D), Telerik.Reporting.Drawing.Unit.Cm(2.8949007987976074D));
			// 
			// Report4
			// 
			this.DataSource = this.sqlDataSource1;
			group1.GroupFooter = this.advertiserIdGroupFooterSection;
			group1.GroupHeader = this.advertiserIdGroupHeaderSection;
			group1.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.AdvertiserId"));
			group1.Name = "advertiserIdGroup";
			group2.GroupFooter = this.labelsGroupFooterSection;
			group2.GroupHeader = this.labelsGroupHeaderSection;
			group2.Name = "labelsGroup";
			this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2});
			this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.advertiserIdGroupHeaderSection,
            this.advertiserIdGroupFooterSection,
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
			this.Name = "Report4";
			this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D));
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.Hour", Telerik.Reporting.SortDirection.Asc));
			this.Style.BackgroundColor = System.Drawing.Color.White;
			styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
			styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(97)))), ((int)(((byte)(74)))));
			styleRule1.Style.Font.Name = "Georgia";
			styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
			styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
			styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
			styleRule2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(168)))), ((int)(((byte)(212)))));
			styleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dotted;
			styleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
			styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
			styleRule2.Style.Font.Name = "Georgia";
			styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
			styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
			styleRule3.Style.Font.Name = "Georgia";
			styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
			styleRule4.Style.Font.Name = "Georgia";
			styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
			this.Width = Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private Telerik.Reporting.SqlDataSource sqlDataSource1;
		private Telerik.Reporting.GroupHeaderSection advertiserIdGroupHeaderSection;
		private Telerik.Reporting.TextBox advertiserIdCaptionTextBox;
		private Telerik.Reporting.TextBox advertiserIdDataTextBox;
		private Telerik.Reporting.GroupFooterSection advertiserIdGroupFooterSection;
		private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
		private Telerik.Reporting.TextBox adImpressionsCaptionTextBox;
		private Telerik.Reporting.TextBox clickRateCaptionTextBox;
		private Telerik.Reporting.TextBox clicksCaptionTextBox;
		private Telerik.Reporting.TextBox dateCaptionTextBox;
		private Telerik.Reporting.TextBox hourCaptionTextBox;
		private Telerik.Reporting.TextBox leadRateCaptionTextBox;
		private Telerik.Reporting.TextBox leadsCaptionTextBox;
		private Telerik.Reporting.TextBox postViewLeadsCaptionTextBox;
		private Telerik.Reporting.TextBox postViewSalesCaptionTextBox;
		private Telerik.Reporting.TextBox salesCaptionTextBox;
		private Telerik.Reporting.TextBox salesRateCaptionTextBox;
		private Telerik.Reporting.TextBox salesValueCaptionTextBox;
		private Telerik.Reporting.TextBox totalAffiliateCommissionCaptionTextBox;
		private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
		private Telerik.Reporting.PageHeaderSection pageHeader;
		private Telerik.Reporting.TextBox reportNameTextBox;
		private Telerik.Reporting.PageFooterSection pageFooter;
		private Telerik.Reporting.TextBox currentTimeTextBox;
		private Telerik.Reporting.TextBox pageInfoTextBox;
		private Telerik.Reporting.ReportHeaderSection reportHeader;
		private Telerik.Reporting.TextBox titleTextBox;
		private Telerik.Reporting.ReportFooterSection reportFooter;
		private Telerik.Reporting.DetailSection detail;
		private Telerik.Reporting.TextBox adImpressionsDataTextBox;
		private Telerik.Reporting.TextBox clickRateDataTextBox;
		private Telerik.Reporting.TextBox clicksDataTextBox;
		private Telerik.Reporting.TextBox dateDataTextBox;
		private Telerik.Reporting.TextBox hourDataTextBox;
		private Telerik.Reporting.TextBox leadRateDataTextBox;
		private Telerik.Reporting.TextBox leadsDataTextBox;
		private Telerik.Reporting.TextBox postViewLeadsDataTextBox;
		private Telerik.Reporting.TextBox postViewSalesDataTextBox;
		private Telerik.Reporting.TextBox salesDataTextBox;
		private Telerik.Reporting.TextBox salesRateDataTextBox;
		private Telerik.Reporting.TextBox salesValueDataTextBox;
		private Telerik.Reporting.TextBox totalAffiliateCommissionDataTextBox;
		private Telerik.Reporting.SubReport subReport1;

	}
}