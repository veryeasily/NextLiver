using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Vector3Int`. Inherits from `SetVariableValue&lt;Vector3Int, Vector3IntPair, Vector3IntVariable, Vector3IntConstant, Vector3IntReference, Vector3IntEvent, Vector3IntPairEvent, Vector3IntVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Vector3Int", fileName = "SetVector3IntVariableValue")]
    public sealed class SetVector3IntVariableValue : SetVariableValue<
        Vector3Int,
        Vector3IntPair,
        Vector3IntVariable,
        Vector3IntConstant,
        Vector3IntReference,
        Vector3IntEvent,
        Vector3IntPairEvent,
        Vector3IntVector3IntFunction,
        Vector3IntVariableInstancer>
    { }
}
