#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AnimationCurvePair`. Inherits from `AtomEventEditor&lt;AnimationCurvePair, AnimationCurvePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AnimationCurvePairEvent))]
    public sealed class AnimationCurvePairEventEditor : AtomEventEditor<AnimationCurvePair, AnimationCurvePairEvent> { }
}
#endif
