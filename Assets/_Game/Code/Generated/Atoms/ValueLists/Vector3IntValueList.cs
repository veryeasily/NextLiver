using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Vector3Int`. Inherits from `AtomValueList&lt;Vector3Int, Vector3IntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Vector3Int", fileName = "Vector3IntValueList")]
    public sealed class Vector3IntValueList : AtomValueList<Vector3Int, Vector3IntEvent> { }
}
