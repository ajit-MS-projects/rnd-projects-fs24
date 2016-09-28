using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MyTests.Business
{
	public class ActiveCouponsResponse
	{
		//[JsonProperty(PropertyName = "activeCoupons")]
		public List<string> ActiveCoupons;
	}
	public class GutscheinbuchDealResponse
	{
		public List<Coupon> coupons { get; set; }
		public String apiVersion { get; set; }
		public String appLink { get; set; }
		public String iconBaseUrl { get; set; }
		public List<Category> couponCategories { get; set; }
		public String serverTime { get; set; }
		public String status { get; set; }
		public int statusCode { get; set; }
		public String statusMessage { get; set; }
		public List<Vendor> vendors { get; set; }
		public String changesSince { get; set; }
	}
	public class Category
	{
		public int count { get; set; }
		public String icon { get; set; }
		public String id { get; set; }
		public String mapIcon { get; set; }
		public String mapIconLastMinute { get; set; }
		public String name { get; set; } // enum?
		public String uid { get; set; }

	}
	public class Vendor
	{
		public String city { get; set; }
		public String companyName { get; set; }
		public String companyName2 { get; set; }
		public String country { get; set; }
		public String email { get; set; }
		public String houseNumber { get; set; }
		[JsonProperty(PropertyName = "images")]
		public List<CouponImage> ImageUrls { get; set; }
		public double latitude { get; set; }
		public double longitude { get; set; }
		public String street { get; set; }
		public String streetHint { get; set; }
		public String tel { get; set; }
		public String tel2 { get; set; }
		public String telHint { get; set; }
		public String uid { get; set; }
		public String vendorUrl { get; set; }
		public String zip { get; set; }
		public String zipCity { get; set; }
	}

	public class Coupon
	{
		public List<String> categories { get; set; }
		public String city { get; set; }
		public String code { get; set; }
		public String codeType { get; set; } // enum?
		public String companyName { get; set; }
		public String companyName2 { get; set; }
		public String country { get; set; }
		public String email { get; set; }
		public String houseNumber { get; set; }
		public String icon { get; set; }
		public String info { get; set; }
		[JsonProperty(PropertyName = "images")]
		public List<CouponImage> ImageUrls { get; set; }
		public bool isLastMinute { get; set; }
		public bool isNew { get; set; }
		public bool isOnlineCoupon { get; set; }
		public bool isTip { get; set; }
		public double latitude { get; set; }
		public String longDescription { get; set; }
		public double longitude { get; set; }
		public String newUntil { get; set; }
		public String optimizedLink { get; set; }
		public String shopLink { get; set; }
		public String street { get; set; }
		public String streetHint { get; set; }
		public int subsidiaryCount { get; set; }
		public String subtitle { get; set; }
		public String tel { get; set; }
		public String tel2 { get; set; }
		public String telHint { get; set; }
		public String title { get; set; }
		public String type { get; set; } // enum?
		public String uid { get; set; }
		public String validFrom { get; set; }
		public String validTo { get; set; }
		public String vendorID { get; set; }
		public String vendorUrl { get; set; }
		public String videoUrl { get; set; }
		public String zip { get; set; }
	}
	public class CouponImage
	{
		public String Url { get; set; }
	}
}
