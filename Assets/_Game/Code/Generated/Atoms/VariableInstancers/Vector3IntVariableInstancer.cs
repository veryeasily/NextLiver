using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Vector3Int`. Inherits from `AtomVariableInstancer&lt;Vector3IntVariable, Vector3IntPair, Vector3Int, Vector3IntEvent, Vector3IntPairEvent, Vector3IntVector3IntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Vector3Int Variable Instancer")]
    public class Vector3IntVariableInstancer : AtomVariableInstancer<
        Vector3IntVariable,
        Vector3IntPair,
        Vector3Int,
        Vector3IntEvent,
        Vector3IntPairEvent,
        Vector3IntVector3IntFunction>
    { }
}
