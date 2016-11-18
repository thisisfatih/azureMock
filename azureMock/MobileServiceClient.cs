using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace azureMock
{
	public class MobileServiceClient
	{
		public List<string> possibleThrows()
		{
			var ls = new List<string>();
			ls.Add("ArgumentNullException");
			ls.Add("IsAbsoluteUri");
			ls.Add("Normal");
			return ls;
		} 

		public MobileServiceClient(Uri mobileAppUri, string throwDef, params HttpMessageHandler[] handlers)
		{
			if (throwDef== "ArgumentNullException")
			{
				throw new ArgumentNullException("mobileAppUri");
			}

			else if (throwDef == "IsAbsoluteUri")
			{
				throw new ArgumentException(
					string.Format(CultureInfo.InvariantCulture, Resources.MobileServiceClient_NotAnAbsoluteURI, mobileAppUri),
					"mobileAppUri");
			}
			else
			{

			}

			//if (mobileAppUri == null)
			//{
			//	throw new ArgumentNullException("mobileAppUri");
			//}

			//if (mobileAppUri.IsAbsoluteUri)
			//{
			//	// Trailing slash in the MobileAppUri is important. Fix it right here before we pass it on further.
			//	this.MobileAppUri = new Uri(MobileServiceUrlBuilder.AddTrailingSlash(mobileAppUri.AbsoluteUri), UriKind.Absolute);
			//}
			//else
			//{
			//	throw new ArgumentException(
			//		string.Format(CultureInfo.InvariantCulture, Resources.MobileServiceClient_NotAnAbsoluteURI, mobileAppUri),
			//		"mobileAppUri");
			//}

			//this.InstallationId = GetApplicationInstallationId();

			//handlers = handlers ?? EmptyHttpMessageHandlers;
			//this.HttpClient = new MobileServiceHttpClient(handlers, this.MobileAppUri, this.InstallationId);
			//this.Serializer = new MobileServiceSerializer();
			//this.EventManager = new MobileServiceEventManager();
			//this.SyncContext = new MobileServiceSyncContext(this);
		}
	}
}
