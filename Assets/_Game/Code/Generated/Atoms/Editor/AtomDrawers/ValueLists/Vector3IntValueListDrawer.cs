#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Vector3Int`. Inherits from `AtomDrawer&lt;Vector3IntValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3IntValueList))]
    public class Vector3IntValueListDrawer : AtomDrawer<Vector3IntValueList> { }
}
#endif
