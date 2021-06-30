#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `AnimationCurve`. Inherits from `AtomDrawer&lt;AnimationCurveVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimationCurveVariable))]
    public class AnimationCurveVariableDrawer : VariableDrawer<AnimationCurveVariable> { }
}
#endif
