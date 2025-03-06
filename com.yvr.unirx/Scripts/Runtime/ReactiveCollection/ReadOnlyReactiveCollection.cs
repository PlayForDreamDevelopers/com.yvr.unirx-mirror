using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;

namespace YVR.UniRx
{
    public class ReadOnlyReactiveCollection<T> : ICollection<T>
    {
        private ReactiveCollection<T> m_Collection;

        public int Count => m_Collection.Count;

        public ReadOnlyReactiveCollection(ReactiveCollection<T> collection)
        {
            m_Collection = collection;
        }

        public T this[int index] => m_Collection[index];

        public IObservable<int> ObserveCountChanged(bool notifyCurrentCount = false) => m_Collection.ObserveCountChanged(notifyCurrentCount);

        public IObservable<Unit> ObserveReset() => m_Collection.ObserveReset();

        public IObservable<CollectionAddEvent<T>> ObserveAdd() => m_Collection.ObserveAdd();

        public IObservable<CollectionMoveEvent<T>> ObserveMove() => m_Collection.ObserveMove();

        public IObservable<CollectionRemoveEvent<T>> ObserveRemove()
        {
            return m_Collection.ObserveRemove();
        }

        public IObservable<CollectionReplaceEvent<T>> ObserveReplace() => m_Collection.ObserveReplace();

        public IEnumerator<T> GetEnumerator()
        {
            return m_Collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Contains(T item)
        {
            return m_Collection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            m_Collection.CopyTo(array, arrayIndex);
        }

        bool ICollection<T>.IsReadOnly => throw new NotImplementedException();

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}