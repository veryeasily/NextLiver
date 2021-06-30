using System;
using UnityEngine.Events;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Ease`. Inherits from `UnityEvent&lt;Ease&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EaseUnityEvent : UnityEvent<Ease> { }
}
