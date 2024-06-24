
namespace SignalR.Core.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> self, Func<T, bool> predicate, bool condition) => condition ? self.Where(predicate) : self;
    }
}
