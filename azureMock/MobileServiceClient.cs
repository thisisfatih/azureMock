using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace azureMock
{
	public class MobileServiceClient
	{
		public MobileServiceClient ( string mobileAppUri, params HttpMessageHandler[] handlers )
		{
			//do nothing.
		}
		public MobileServiceClient ( string mobileAppUri )
		{
			//throw new ArgumentNullException ( "instance" );
			//do nothing.
		}
		public IMobileServiceTable<T> GetTable<T> ( )
		{
			//string tableName = this.SerializerSettings.ContractResolver.ResolveTableName ( typeof ( T ) );
			return new MobileServiceTable<T> ( /*tableName*/ typeof ( T ).Name, this );
		}

		//public Task<T> InvokeApiAsync<T> ( string apiName, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	return this.InvokeApiAsync<string, T> ( apiName, null, null, null, cancellationToken );
		//}
		//public Task<U> InvokeApiAsync<T, U> ( string apiName, T body, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	return this.InvokeApiAsync<T, U> ( apiName, body, null, null, cancellationToken );
		//}
		//public Task<T> InvokeApiAsync<T> ( string apiName, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	return this.InvokeApiAsync<string, T> ( apiName, null, method, parameters, cancellationToken );
		//}

		//public async Task<U> InvokeApiAsync<T, U> ( string apiName, T body, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	if (string.IsNullOrWhiteSpace ( apiName ))
		//	{
		//		throw new ArgumentNullException ( "apiName" );
		//	}

		//	MobileServiceSerializer serializer = this.Serializer;
		//	string content = null;
		//	if (body != null)
		//	{
		//		content = serializer.Serialize ( body ).ToString ( );
		//	}

		//	string response = await this.InternalInvokeApiAsync ( apiName, content, method, parameters, MobileServiceFeatures.TypedApiCall, cancellationToken );
		//	if (string.IsNullOrEmpty ( response ))
		//	{
		//		return default ( U );
		//	}
		//	return serializer.Deserialize<U> ( JToken.Parse ( response ) );
		//}

		//public Task<JToken> InvokeApiAsync ( string apiName, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	return this.InvokeApiAsync ( apiName, null, null, null, cancellationToken );
		//}
		//public Task<JToken> InvokeApiAsync ( string apiName, JToken body, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	return this.InvokeApiAsync ( apiName, body, defaultHttpMethod, null, cancellationToken );
		//}
		//public Task<JToken> InvokeApiAsync ( string apiName, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	return this.InvokeApiAsync ( apiName, null, method, parameters, cancellationToken );
		//}
		public async Task<JToken> InvokeApiAsync ( JToken returnJSON, string apiName, JToken body, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
		{
			//if (string.IsNullOrWhiteSpace ( apiName ))
			//{
			//	throw new ArgumentNullException ( "apiName" );
			//}

			//string content = null;
			//if (body != null)
			//{
			//	switch (body.Type)
			//	{
			//		case JTokenType.Null:
			//			content = "null";
			//			break;
			//		case JTokenType.Boolean:
			//			content = body.ToString ( ).ToLowerInvariant ( );
			//			break;
			//		default:
			//			content = body.ToString ( );
			//			break;
			//	}
			//}

			//string response = await this.InternalInvokeApiAsync ( apiName, content, method, parameters, MobileServiceFeatures.JsonApiCall, cancellationToken );
			//return response.ParseToJToken ( this.SerializerSettings );
			return returnJSON;
		}

		//public async Task<HttpResponseMessage> InvokeApiAsync ( string apiName, HttpContent content, HttpMethod method, IDictionary<string, string> requestHeaders, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
		//{
		//	method = method ?? defaultHttpMethod;
		//	HttpResponseMessage response = await this.HttpClient.RequestAsync ( method, CreateAPIUriString ( apiName, parameters ), this.CurrentUser, content, requestHeaders: requestHeaders, features: MobileServiceFeatures.GenericApiCall, cancellationToken: cancellationToken );
		//	return response;
		//}
		//public async Task<HttpResponseMessage> InvokeApiAsync ( string apiName, HttpContent content, HttpMethod method, IDictionary<string, string> requestHeaders, IDictionary<string, string> parameters )
		//{
		//	method = method ?? defaultHttpMethod;
		//	HttpResponseMessage response = await this.HttpClient.RequestAsync ( method, CreateAPIUriString ( apiName, parameters ), this.CurrentUser, content, requestHeaders: requestHeaders, features: MobileServiceFeatures.GenericApiCall );
		//	return response;
		//}

	}
}
