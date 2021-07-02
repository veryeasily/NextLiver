using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Vector3Int`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Vector3IntVariable))]
    public sealed class Vector3IntVariableEditor : AtomVariableEditor<Vector3Int, Vector3IntPair> { }
}
