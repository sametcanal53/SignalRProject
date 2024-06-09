namespace SignalR.Core.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> IsActiveConditions<T>(IEnumerable<T> queryable, bool? isActive = default) => queryable.Where(q => !isActive.HasValue || q.GetType().GetProperty("State") == null ? true : q.GetType().GetProperty("State").GetValue(q).Equals(isActive.Value));
    }
}
