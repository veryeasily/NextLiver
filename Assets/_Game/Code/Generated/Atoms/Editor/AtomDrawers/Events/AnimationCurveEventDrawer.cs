#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AnimationCurve`. Inherits from `AtomDrawer&lt;AnimationCurveEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimationCurveEvent))]
    public class AnimationCurveEventDrawer : AtomDrawer<AnimationCurveEvent> { }
}
#endif
