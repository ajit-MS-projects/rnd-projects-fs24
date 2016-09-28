using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.AspNet;
using Microsoft.AspNet.Membership.OpenAuth;

namespace WebApplication1
{
	internal  class AuthConfig
	{
		public  void RegisterOpenAuth()
		{
			// See http://go.microsoft.com/fwlink/?LinkId=252803 for details on setting up this ASP.NET
			// application to support logging in via external services.

			OpenAuth.AuthenticationClients.Add("ss", xx);.AddTwitter(
				consumerKey: "your Twitter consumer key",
				consumerSecret: "your Twitter consumer secret");

			//OpenAuth.AuthenticationClients.AddFacebook(
			//    appId: "your Facebook app id",
			//    appSecret: "your Facebook app secret");

			//OpenAuth.AuthenticationClients.AddMicrosoft(
			//    clientId: "your Microsoft account client id",
			//    clientSecret: "your Microsoft account client secret");

			//OpenAuth.AuthenticationClients.AddGoogle();
		}
		public IAuthenticationClient xx()
		{
			
		}
	}
}