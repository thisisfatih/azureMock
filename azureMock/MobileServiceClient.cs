using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace azureMock
{
    public class MobileServiceClient
    {
        public static List<string> getPossibleMobileServiceClientThrows ( )
        {
            var possibleMobileServiceClientThrows = new List<string> ( );
            possibleMobileServiceClientThrows.Add ( "ArgumentNullException-mobileAppUri" );
            possibleMobileServiceClientThrows.Add ( "ArgumentException-mobileAppUri" );
            possibleMobileServiceClientThrows.Add ( "ArgumentNullException-client" );
            possibleMobileServiceClientThrows.Add ( "NO-THROW" );
            return possibleMobileServiceClientThrows;
        }
        public static List<string> getPossibleInvokeApiAsyncThrows ( )
        {
            var possibleMobileServiceClientThrows = new List<string> ( );
            possibleMobileServiceClientThrows.Add ( "ArgumentNullException-apiName" );
            possibleMobileServiceClientThrows.Add ( "MobileServiceConflictException" );
            possibleMobileServiceClientThrows.Add ( "MobileServiceInvalidOperationException" );
            possibleMobileServiceClientThrows.Add ( "MobileServiceLocalStoreException" );
            possibleMobileServiceClientThrows.Add ( "MobileServiceODataException" );
            possibleMobileServiceClientThrows.Add ( "MobileServicePreconditionFailedException" );
            possibleMobileServiceClientThrows.Add ( "MobileServicePushAbortException" );
            possibleMobileServiceClientThrows.Add ( "MobileServicePushFailedException" );
            possibleMobileServiceClientThrows.Add ( "FormatException" );
            possibleMobileServiceClientThrows.Add ( "NO-THROW" );
            return possibleMobileServiceClientThrows;
        }

        private static HttpMethod defaultHttpMethod = HttpMethod.Post;
        public JToken returnValue { get; set; }
        public class defaultMessage
        {
            public string message;
        }

        protected MobileServiceClient ( )
        {

        }
        public MobileServiceClient ( string mobileAppUri, params HttpMessageHandler[] handlers ) : this ( new Uri ( mobileAppUri, UriKind.Absolute ), handlers )
        {
        }
        public MobileServiceClient ( Uri mobileAppUri, params HttpMessageHandler[] handlers )
        {
            return;

            //if (mobileAppUri == null)
            //{
            //	throw new ArgumentNullException ( "mobileAppUri" );
            //}

            //if (mobileAppUri.IsAbsoluteUri)
            //{
            //	// Trailing slash in the MobileAppUri is important. Fix it right here before we pass it on further.
            //	this.MobileAppUri = new Uri ( MobileServiceUrlBuilder.AddTrailingSlash ( mobileAppUri.AbsoluteUri ), UriKind.Absolute );
            //}
            //else
            //{
            //	throw new ArgumentException (
            //		string.Format ( CultureInfo.InvariantCulture, Resources.MobileServiceClient_NotAnAbsoluteURI, mobileAppUri ),
            //		"mobileAppUri" );
            //}

            //this.InstallationId = GetApplicationInstallationId ( );

            //handlers = handlers ?? EmptyHttpMessageHandlers;
            //this.HttpClient = new MobileServiceHttpClient ( handlers, this.MobileAppUri, this.InstallationId );
            //this.Serializer = new MobileServiceSerializer ( );
            //this.EventManager = new MobileServiceEventManager ( );
            //this.SyncContext = new MobileServiceSyncContext ( this );

        }
        public MobileServiceClient ( string selectionMobileServiceClientThrows, string mobileAppUri, params HttpMessageHandler[] handlers )
            : this ( selectionMobileServiceClientThrows, new Uri ( mobileAppUri, UriKind.Absolute ), handlers )
        {
        }
        public MobileServiceClient ( string selectionMobileServiceClientThrows, Uri mobileAppUri, params HttpMessageHandler[] handlers )
        {
            if (selectionMobileServiceClientThrows == "ArgumentNullException-mobileAppUri")
            {
                throw new ArgumentNullException ( "mobileAppUri" );
            }
            else if (selectionMobileServiceClientThrows == "ArgumentException-mobileAppUri")
            {
                throw new ArgumentException ( string.Format ( CultureInfo.InvariantCulture, Resources.MobileServiceClient_NotAnAbsoluteURI, mobileAppUri ), "mobileAppUri" );
            }
            else if (selectionMobileServiceClientThrows == "ArgumentNullException-client")
            {
                throw new ArgumentNullException ( "client" );
            }
            else
            {

            }

            //if (mobileAppUri == null)
            //{
            //	throw new ArgumentNullException ( "mobileAppUri" );
            //}

            //if (mobileAppUri.IsAbsoluteUri)
            //{
            //	// Trailing slash in the MobileAppUri is important. Fix it right here before we pass it on further.
            //	this.MobileAppUri = new Uri ( MobileServiceUrlBuilder.AddTrailingSlash ( mobileAppUri.AbsoluteUri ), UriKind.Absolute );
            //}
            //else
            //{
            //	throw new ArgumentException (
            //		string.Format ( CultureInfo.InvariantCulture, Resources.MobileServiceClient_NotAnAbsoluteURI, mobileAppUri ),
            //		"mobileAppUri" );
            //}

            //this.InstallationId = GetApplicationInstallationId ( );

            //handlers = handlers ?? EmptyHttpMessageHandlers;
            //this.HttpClient = new MobileServiceHttpClient ( handlers, this.MobileAppUri, this.InstallationId );
            //this.Serializer = new MobileServiceSerializer ( );
            //this.EventManager = new MobileServiceEventManager ( );
            //this.SyncContext = new MobileServiceSyncContext ( this );

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


        public Task<JToken> InvokeApiAsync ( string apiName, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( apiName, null, null, null, cancellationToken );
        }
        public Task<JToken> InvokeApiAsync ( string apiName, JToken body, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( apiName, body, defaultHttpMethod, null, cancellationToken );
        }
        public Task<JToken> InvokeApiAsync ( string apiName, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( apiName, null, method, parameters, cancellationToken );
        }
        public async Task<JToken> InvokeApiAsync ( string apiName, JToken body, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            defaultMessage dm = new defaultMessage ( );
            dm.message = "Default JToken result message.";
            return JsonConvert.SerializeObject ( dm );

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

        }

        //return specification
        public Task<JToken> InvokeApiAsync ( JToken returnValue, string apiName, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( returnValue, apiName, null, null, null, cancellationToken );
        }
        public Task<JToken> InvokeApiAsync ( JToken returnValue, string apiName, JToken body, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( returnValue, apiName, body, defaultHttpMethod, null, cancellationToken );
        }
        public Task<JToken> InvokeApiAsync ( JToken returnValue, string apiName, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( returnValue, apiName, null, method, parameters, cancellationToken );
        }
        public async Task<JToken> InvokeApiAsync ( JToken returnValue, string apiName, JToken body, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return returnValue;

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

        }

        //throw specification
        public Task<JToken> InvokeApiAsync ( string selectionInvokeApiAsyncThrows, string apiName, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( selectionInvokeApiAsyncThrows, apiName, null, null, null, cancellationToken );
        }
        public Task<JToken> InvokeApiAsync ( string selectionInvokeApiAsyncThrows, string apiName, JToken body, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( selectionInvokeApiAsyncThrows, apiName, body, defaultHttpMethod, null, cancellationToken );
        }
        public Task<JToken> InvokeApiAsync ( string selectionInvokeApiAsyncThrows, string apiName, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            return this.InvokeApiAsync ( selectionInvokeApiAsyncThrows, apiName, null, method, parameters, cancellationToken );
        }
        public async Task<JToken> InvokeApiAsync ( string selectionInvokeApiAsyncThrows, string apiName, JToken body, HttpMethod method, IDictionary<string, string> parameters, CancellationToken cancellationToken = default ( CancellationToken ) )
        {
            if (selectionInvokeApiAsyncThrows == "ArgumentNullException-apiName")
            {
                throw new ArgumentNullException ( "apiName" );
            }
            else
            {

            }
            return null;

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
