using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace AspPost
{
	public class NewletterHandler : IHttpHandler
	{
		#region Implementation of IHttpHandler

		public const string MatchEmailPattern =
		   @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
	+ @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
	+ @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
	+ @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

		/// <summary>
		/// Enables processing of HTTP Web requests by a custom HttpHandler that implements the <see cref="T:System.Web.IHttpHandler"/> interface.
		/// </summary>
		/// <param name="context">An <see cref="T:System.Web.HttpContext"/> object that provides references to the intrinsic server objects (for example, Request, Response, Session, and Server) used to service HTTP requests. </param>
		public void ProcessRequest(HttpContext context)
		{
			HttpRequest request = context.Request;
			HttpResponse Response = context.Response;

			Newsletter newsletter = new Newsletter();
			newsletter.Gender = request["consumer_salutation"];
			newsletter.Name = request["consumer_firstname"];
			newsletter.SurName = request["consumer_lastname"];
			newsletter.EmailAddress = request["consumer_email"];

			if (string.IsNullOrEmpty(newsletter.EmailAddress) || !Regex.IsMatch(newsletter.EmailAddress, MatchEmailPattern))
				throw new HttpException((int) HttpStatusCode.BadRequest, "Inavlid Email");


			Response.Write("<html>");
			Response.Write("<body>");
			Response.Write("<h1>" + request["consumer_email"] + "</h1>");
			Response.Write("</body>");
			Response.Write("</html>");
		}

		/// <summary>
		/// Gets a value indicating whether another request can use the <see cref="T:System.Web.IHttpHandler"/> instance.
		/// </summary>
		/// <returns>
		/// true if the <see cref="T:System.Web.IHttpHandler"/> instance is reusable; otherwise, false.
		/// </returns>
		public bool IsReusable
		{
			get { return false; }
		}

		#endregion
	}
}

public class Newsletter
	{

		#region private variables

		private int userID;
		private string name;
		private string surname;
		private string emailAddress;
		private string gender;
		private int status;
		private string guid;
		private long titleId;
		private long maritalStatusId;
		private int children;
		private int zipCode;
		private string profession;
		private int notificationStatus;
		private string sourceId;
		private string list;

		#endregion

		#region properties

		public int Status
		{
			get { return status; }
			set { status = value; }
		}

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public string EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}

		public string SurName
		{
			get { return surname; }
			set { surname = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		public string GUID
		{
			get { return guid; }
			set { guid = value; }
		}

		public long TitleId
		{
			get { return titleId; }
			set { titleId = value; }
		}

		public long MaritalStatusId
		{
			get { return maritalStatusId; }
			set { maritalStatusId = value; }
		}

		public int Children
		{
			get { return children; }
			set { children = value; }
		}

		public int ZipCode
		{
			get { return zipCode; }
			set { zipCode = value; }
		}

		public string Profession
		{
			get { return profession; }
			set { profession = value; }
		}

		public int NotificationStatus
		{
			get { return notificationStatus; }
			set { notificationStatus = value; }
		}

		public string SourceId
		{
			get { return sourceId; }
			set { sourceId = value; }
		}

		public string List
		{
			get { return list; }
			set { list = value; }
		}

		#endregion
	}
