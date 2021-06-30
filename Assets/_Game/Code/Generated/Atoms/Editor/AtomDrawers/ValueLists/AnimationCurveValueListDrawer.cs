#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `AnimationCurve`. Inherits from `AtomDrawer&lt;AnimationCurveValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimationCurveValueList))]
    public class AnimationCurveValueListDrawer : AtomDrawer<AnimationCurveValueList> { }
}
#endif
