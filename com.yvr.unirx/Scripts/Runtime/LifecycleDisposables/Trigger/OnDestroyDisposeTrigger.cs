using System;
using System.Collections.Generic;
using UnityEngine;
using YVR.Utilities;

namespace YVR.UniRx
{
    public class OnDestroyDisposeTrigger : MonoBehaviour
    {
        private HashSet<IDisposable> m_Disposables = new();

        public void AddDispose(IDisposable disposable) { m_Disposables.Add(disposable); }

        private void OnDestroy()
        {
            if (!Application.isPlaying) return;

            m_Disposables.ForEach(disposable => disposable.Dispose());
            m_Disposables.Clear();
        }
    }
}