using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `AnimationCurve`. Inherits from `UnityEvent&lt;AnimationCurve&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimationCurveUnityEvent : UnityEvent<AnimationCurve> { }
}
