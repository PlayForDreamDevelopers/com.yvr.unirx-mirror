using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using YVR.Utilities;

namespace YVR.UniRx
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class IDisposableExtensions
    {
        public static void DisposeOnDestroyed(this IDisposable self, Component component)
        {
            component.AutoAddingGetComponent<OnDestroyDisposeTrigger>().AddDispose(self);
        }

        public static void DisposeOnDisabled(this IDisposable self, Component component)
        {
            component.AutoAddingGetComponent<OnDisableDisposeTrigger>().AddDispose(self);
        }
    }
}