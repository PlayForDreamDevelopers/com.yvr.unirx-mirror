using UniRx;

namespace YVR.UniRx
{
    public static class ReactiveCollectionExtensions
    {
        public static ReadOnlyReactiveCollection<T>
            ToReadOnlyReactiveCollection<T>(this ReactiveCollection<T> collection)
        {
            return new ReadOnlyReactiveCollection<T>(collection);
        }
    }
}