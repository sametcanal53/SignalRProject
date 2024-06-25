
namespace SignalR.Core.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate, bool condition) => condition ? enumerable.Where(predicate) : enumerable;
    }
}
