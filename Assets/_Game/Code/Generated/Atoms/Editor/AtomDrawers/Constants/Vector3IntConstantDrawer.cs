#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Vector3Int`. Inherits from `AtomDrawer&lt;Vector3IntConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3IntConstant))]
    public class Vector3IntConstantDrawer : VariableDrawer<Vector3IntConstant> { }
}
#endif
