using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Vector3Int`. Inherits from `UnityEvent&lt;Vector3Int&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3IntUnityEvent : UnityEvent<Vector3Int> { }
}
