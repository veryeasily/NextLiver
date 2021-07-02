#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector3IntPair`. Inherits from `AtomEventEditor&lt;Vector3IntPair, Vector3IntPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector3IntPairEvent))]
    public sealed class Vector3IntPairEventEditor : AtomEventEditor<Vector3IntPair, Vector3IntPairEvent> { }
}
#endif
