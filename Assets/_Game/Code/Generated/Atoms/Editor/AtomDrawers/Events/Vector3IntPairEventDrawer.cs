#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3IntPair`. Inherits from `AtomDrawer&lt;Vector3IntPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector3IntPairEvent))]
    public class Vector3IntPairEventDrawer : AtomDrawer<Vector3IntPairEvent> { }
}
#endif
