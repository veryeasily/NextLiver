#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3Int`. Inherits from `AtomDrawer&lt;Vector3IntEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3IntEvent))]
    public class Vector3IntEventDrawer : AtomDrawer<Vector3IntEvent> { }
}
#endif
