#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AnimationCurve`. Inherits from `AtomEventEditor&lt;AnimationCurve, AnimationCurveEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AnimationCurveEvent))]
    public sealed class AnimationCurveEventEditor : AtomEventEditor<AnimationCurve, AnimationCurveEvent> { }
}
#endif
