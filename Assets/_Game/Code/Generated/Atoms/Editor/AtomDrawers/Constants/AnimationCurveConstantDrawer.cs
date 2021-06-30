#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `AnimationCurve`. Inherits from `AtomDrawer&lt;AnimationCurveConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimationCurveConstant))]
    public class AnimationCurveConstantDrawer : VariableDrawer<AnimationCurveConstant> { }
}
#endif
