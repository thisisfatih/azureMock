using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace azureMock
{
	public interface IMobileServiceTable<T> : IMobileServiceTable
	{
		//IEnumerable<U> ReadAsync<U>/*Task<IEnumerable<U>>*/  ( string query );
		//IEnumerable<U> ReadAsync<U>/*Task<IEnumerable<U>>*/  ( IMobileServiceTableQuery<U> query );
		//IEnumerable<T>/*Task<IEnumerable<T>>*/  ReadAsync ( );
		//T/*new Task<T>*/ LookupAsync ( object id );
		//T/*new Task<T>*/ LookupAsync ( object id, IDictionary<string, string> parameters );
		Task RefreshAsync ( T instance );
		Task RefreshAsync ( T instance, IDictionary<string, string> parameters );
		Task InsertAsync ( T instance );
		Task InsertAsync ( T instance, IDictionary<string, string> parameters );
		Task UpdateAsync ( T instance );
		Task UpdateAsync ( T instance, IDictionary<string, string> parameters );
		Task UndeleteAsync ( T instance );
		Task UndeleteAsync ( T instance, IDictionary<string, string> parameters );
		Task DeleteAsync ( T instance );
		Task DeleteAsync ( T instance, IDictionary<string, string> parameters );
		IMobileServiceTableQuery<T> CreateQuery ( );
		IMobileServiceTableQuery<T> IncludeTotalCount ( );
		IMobileServiceTableQuery<T> IncludeDeleted ( );
		IMobileServiceTableQuery<T> WithParameters ( IDictionary<string, string> parameters );
		IMobileServiceTableQuery<T> Where ( Expression<Func<T, bool>> predicate );
		IMobileServiceTableQuery<U> Select<U> ( Expression<Func<T, U>> selector );
		IMobileServiceTableQuery<T> OrderBy<TKey> ( Expression<Func<T, TKey>> keySelector );
		IMobileServiceTableQuery<T> OrderByDescending<TKey> ( Expression<Func<T, TKey>> keySelector );
		IMobileServiceTableQuery<T> ThenBy<TKey> ( Expression<Func<T, TKey>> keySelector );
		IMobileServiceTableQuery<T> ThenByDescending<TKey> ( Expression<Func<T, TKey>> keySelector );
		IMobileServiceTableQuery<T> Skip ( int count );
		IMobileServiceTableQuery<T> Take ( int count );
		//IEnumerable<T> /*Task<IEnumerable<T>> ToEnumerableAsync ( );
		Task<List<T>> ToListAsync ( );
	}
}
