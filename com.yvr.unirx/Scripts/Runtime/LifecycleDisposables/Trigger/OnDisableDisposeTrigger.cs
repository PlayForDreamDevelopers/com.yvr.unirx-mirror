using System;
using System.Collections.Generic;
using UnityEngine;
using YVR.Utilities;

namespace YVR.UniRx
{
    public class OnDisableDisposeTrigger : MonoBehaviour
    {
        private HashSet<IDisposable> m_Disposables = new();

        public void AddDispose(IDisposable disposable) { m_Disposables.Add(disposable); }

        private void OnDisable()
        {
            if (!Application.isPlaying) return;

            m_Disposables.ForEach(disposable => disposable.Dispose());
            m_Disposables.Clear();
        }
    }
}