using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace azureMock
{
	internal class MobileServiceTable<T> : MobileServiceTable, IMobileServiceTable<T>
	{
		public MobileServiceTable ( string tableName, MobileServiceClient client )/* : base ( tableName, client )*/
		{
			//this.queryProvider = new MobileServiceTableQueryProvider ( );
		}
		//public /*Task<IEnumerable<T>>*/ IEnumerable<T> ReadAsync ( )
		//{
		//	//return ReadAsync ( CreateQuery ( ) );
		//}
		//public /*Task<IEnumerable<U>>*/IEnumerable<U> ReadAsync<U> ( IMobileServiceTableQuery<U> query )
		//{
		//	if (query == null)
		//	{
		//		throw new ArgumentNullException ( "query" );
		//	}

		//	return query.ToEnumerableAsync ( );
		//}
		//public /*async Task<IEnumerable<U>>*/IEnumerable<U> ReadAsync<U> ( string query )
		//{
		//	QueryResult result = await base.ReadAsync ( query, null, MobileServiceFeatures.TypedTable );

		//	return new QueryResultEnumerable<U> ( result.TotalCount, result.NextLink,
		//		this.MobileServiceClient.Serializer.Deserialize ( result.Values, typeof ( U ) ).Cast<U> ( ) );
		//}
		public async Task InsertAsync ( T instance )
		{
			/*await*/
			this.InsertAsync ( instance, null );
		}
		public async Task InsertAsync ( T instance, IDictionary<string, string> parameters )
		{
			//if (instance == null)
			//{
			//	throw new ArgumentNullException ( "instance" );
			//}

			//MobileServiceSerializer serializer = this.MobileServiceClient.Serializer;
			//JObject value = serializer.Serialize ( instance ) as JObject;

			//string unused;
			//value = MobileServiceSerializer.RemoveSystemProperties ( value, out unused );

			//JToken insertedValue = await TransformHttpException ( serializer, ( ) => this.InsertAsync ( value, parameters, MobileServiceFeatures.TypedTable ) );

			//serializer.Deserialize<T> ( insertedValue, instance );
		}
		public async Task UpdateAsync ( T instance )
		{
			/*await*/
			this.UpdateAsync ( instance, null );
		}
		public async Task UpdateAsync ( T instance, IDictionary<string, string> parameters )
		{
			//if (instance == null)
			//{
			//	throw new ArgumentNullException ( "instance" );
			//}

			//MobileServiceSerializer serializer = this.MobileServiceClient.Serializer;
			//JObject value = serializer.Serialize ( instance ) as JObject;

			//JToken updatedValue = await TransformHttpException ( serializer, ( ) => this.UpdateAsync ( value, parameters, MobileServiceFeatures.TypedTable ) );


			//serializer.Deserialize<T> ( updatedValue, instance );
		}
		public Task UndeleteAsync ( T instance )
		{
			return this.UndeleteAsync ( instance, null );
		}
		public async Task UndeleteAsync ( T instance, IDictionary<string, string> parameters )
		{
			//if (instance == null)
			//{
			//	throw new ArgumentNullException ( "instance" );
			//}

			//MobileServiceSerializer serializer = this.MobileServiceClient.Serializer;
			//JObject value = serializer.Serialize ( instance ) as JObject;

			//JToken updatedValue = await TransformHttpException ( serializer, ( ) => this.UndeleteAsync ( value, parameters, MobileServiceFeatures.TypedTable ) );

			//serializer.Deserialize<T> ( updatedValue, instance );
		}
		public async Task DeleteAsync ( T instance )
		{
			//await this.DeleteAsync ( instance, null );
		}
		public async Task DeleteAsync ( T instance, IDictionary<string, string> parameters )
		{
			//if (instance == null)
			//{
			//	throw new ArgumentNullException ( "instance" );
			//}

			//MobileServiceSerializer serializer = this.MobileServiceClient.Serializer;
			//JObject value = serializer.Serialize ( instance ) as JObject;

			//await this.TransformHttpException ( serializer, ( ) => this.DeleteAsync ( value, parameters, MobileServiceFeatures.TypedTable ) );

			//// Clear the instance id since it's no longer associated with that
			//// id on the server (note that reflection is goodly enough to turn
			//// null into the correct value for us).
			//serializer.SetIdToDefault ( instance );
		}
		public new async Task<T> LookupAsync ( object id )
		{
			return await this.LookupAsync ( id, null );
		}
		public new async Task<T> LookupAsync ( object id, IDictionary<string, string> parameters )
		{
			//// Ensure that the id passed in is assignable to the Id property of T
			//this.MobileServiceClient.Serializer.EnsureValidIdForType<T> ( id );
			//JToken value = await base.LookupAsync ( id, parameters, MobileServiceFeatures.TypedTable );
			//return this.MobileServiceClient.Serializer.Deserialize<T> ( value );
			return default ( T );
		}
		public async Task RefreshAsync ( T instance )
		{
			/*await*/
			this.RefreshAsync ( instance, null );
		}
		public async Task RefreshAsync ( T instance, IDictionary<string, string> parameters )
		{
			//if (instance == null)
			//{
			//	throw new ArgumentNullException ( "instance" );
			//}

			//MobileServiceSerializer serializer = this.MobileServiceClient.Serializer;
			//object id = serializer.GetId ( instance, allowDefault: true );

			//if (MobileServiceSerializer.IsDefaultId ( id ))
			//{
			//	return;
			//}
			//if (id is string)
			//{
			//	MobileServiceSerializer.EnsureValidStringId ( id, allowDefault: true );
			//}

			//// Get the latest version of this element
			//JObject refreshed = await this.GetSingleValueAsync ( id, parameters );

			//// Deserialize that value back into the current instance
			//serializer.Deserialize<T> ( refreshed, instance );
		}
		public IMobileServiceTableQuery<T> CreateQuery ( )
		{
			return null;
			//return this.queryProvider.Create ( this, new T[0].AsQueryable ( ), new Dictionary<string, string> ( ), includeTotalCount: false );
		}
		public IMobileServiceTableQuery<T> Where ( Expression<Func<T, bool>> predicate )
		{
			return null;
			//return CreateQuery ( ).Where ( predicate );
		}
		public IMobileServiceTableQuery<U> Select<U> ( Expression<Func<T, U>> selector )
		{
			return null;
			//return CreateQuery ( ).Select ( selector );
		}
		public IMobileServiceTableQuery<T> OrderBy<TKey> ( Expression<Func<T, TKey>> keySelector )
		{
			return null;
			//return CreateQuery ( ).OrderBy ( keySelector );
		}
		public IMobileServiceTableQuery<T> OrderByDescending<TKey> ( Expression<Func<T, TKey>> keySelector )
		{
			return null;
			//return CreateQuery ( ).OrderByDescending ( keySelector );
		}
		public IMobileServiceTableQuery<T> ThenBy<TKey> ( Expression<Func<T, TKey>> keySelector )
		{
			return null;
			//return CreateQuery ( ).ThenBy ( keySelector );
		}
		public IMobileServiceTableQuery<T> ThenByDescending<TKey> ( Expression<Func<T, TKey>> keySelector )
		{
			return null;
			//return CreateQuery ( ).ThenByDescending ( keySelector );
		}
		public IMobileServiceTableQuery<T> Skip ( int count )
		{
			return null;
			//return CreateQuery ( ).Skip ( count );
		}
		public IMobileServiceTableQuery<T> Take ( int count )
		{
			return null;
			//return CreateQuery ( ).Take ( count );
		}
		public IMobileServiceTableQuery<T> IncludeTotalCount ( )
		{
			return null;
			//return this.CreateQuery ( ).IncludeTotalCount ( );
		}
		public IMobileServiceTableQuery<T> IncludeDeleted ( )
		{
			return null;
			//return this.CreateQuery ( ).IncludeDeleted ( );
		}
		public IMobileServiceTableQuery<T> WithParameters ( IDictionary<string, string> parameters )
		{
			return null;
			//return this.CreateQuery ( ).WithParameters ( parameters );
		}
		//public/* Task<IEnumerable<T>>*/IEnumerable<T> ToEnumerableAsync ( )
		//{
		//	return this.ReadAsync ( );
		//}
		public async Task<List<T>> ToListAsync ( List<T> returnList )
		{
			return returnList;
			//return new QueryResultList<T> ( await this.ReadAsync ( ) );
		}

		//private async Task<JToken> TransformHttpException ( MobileServiceSerializer serializer, Func<Task<JToken>> action )
		//{
		//	try
		//	{
		//		return await action ( );
		//	}
		//	catch (MobileServiceInvalidOperationException ex)
		//	{
		//		if (ex.Response.StatusCode != HttpStatusCode.PreconditionFailed &&
		//			ex.Response.StatusCode != HttpStatusCode.Conflict)
		//		{
		//			throw;
		//		}

		//		T item = default ( T );
		//		try
		//		{
		//			item = serializer.Deserialize<T> ( ex.Value );
		//		}
		//		catch { }

		//		if (ex.Response.StatusCode == HttpStatusCode.PreconditionFailed)
		//		{
		//			throw new MobileServicePreconditionFailedException<T> ( ex, item );
		//		}
		//		else if (ex.Response.StatusCode == HttpStatusCode.Conflict)
		//		{
		//			throw new MobileServiceConflictException<T> ( ex, item );
		//		}
		//		throw;
		//	}
		//}
		//private async Task<JObject> GetSingleValueAsync ( object id, IDictionary<string, string> parameters )
		//{
		//	Debug.Assert ( id != null );

		//	// Create a query for just this item
		//	string query = string.Format (
		//		CultureInfo.InvariantCulture,
		//		"$filter=({0} eq {1})",
		//		MobileServiceSystemColumns.Id,
		//		ODataExpressionVisitor.ToODataConstant ( id ) );

		//	// Send the query
		//	QueryResult response = await this.ReadAsync ( query, parameters, MobileServiceFeatures.TypedTable );

		//	return GetSingleValue ( response );
		//}
		//private static JObject GetSingleValue ( QueryResult response )
		//{
		//	// Get the first element in the response
		//	JObject jobject = response.Values.FirstOrDefault ( ) as JObject;

		//	if (jobject == null)
		//	{
		//		string responseStr = response != null ? response.ToString ( ) : "null";
		//		throw new InvalidOperationException (
		//			string.Format (
		//				CultureInfo.InvariantCulture,
		//				"Could not get object from response {0}.",
		//				responseStr ) );
		//	}

		//	return jobject;
		//}
	}
}
