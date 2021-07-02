#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Vector3Int`. Inherits from `AtomDrawer&lt;Vector3IntVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3IntVariable))]
    public class Vector3IntVariableDrawer : VariableDrawer<Vector3IntVariable> { }
}
#endif
