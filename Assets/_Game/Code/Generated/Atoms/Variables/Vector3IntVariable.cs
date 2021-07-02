using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Vector3Int`. Inherits from `EquatableAtomVariable&lt;Vector3Int, Vector3IntPair, Vector3IntEvent, Vector3IntPairEvent, Vector3IntVector3IntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector3Int", fileName = "Vector3IntVariable")]
    public sealed class Vector3IntVariable : EquatableAtomVariable<Vector3Int, Vector3IntPair, Vector3IntEvent, Vector3IntPairEvent, Vector3IntVector3IntFunction>
    {
    }
}
