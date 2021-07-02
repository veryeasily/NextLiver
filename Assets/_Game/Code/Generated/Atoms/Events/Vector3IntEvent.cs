using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Vector3Int`. Inherits from `AtomEvent&lt;Vector3Int&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector3Int", fileName = "Vector3IntEvent")]
    public sealed class Vector3IntEvent : AtomEvent<Vector3Int>
    {
    }
}
