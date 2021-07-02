using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Vector3IntPair`. Inherits from `AtomEvent&lt;Vector3IntPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector3IntPair", fileName = "Vector3IntPairEvent")]
    public sealed class Vector3IntPairEvent : AtomEvent<Vector3IntPair>
    {
    }
}
